using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Google.Protobuf;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.Communication;
using MySqlX.Data;
using MySqlX.DataAccess;
using MySqlX.Protocol.X;
using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using Mysqlx;
using Mysqlx.Connection;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Expect;
using Mysqlx.Expr;
using Mysqlx.Notice;
using Mysqlx.Prepare;
using Mysqlx.Resultset;
using Mysqlx.Session;
using Mysqlx.Sql;

namespace MySqlX.Protocol;

internal class XProtocol : ProtocolBase
{
	private CommunicationPacket pendingPacket;

	private XPacketReaderWriter _reader;

	private XPacketReaderWriter _writer;

	public Capabilities Capabilities { get; protected set; }

	public XProtocol(XPacketReaderWriter reader, XPacketReaderWriter writer)
	{
		_reader = reader;
		_writer = writer;
	}

	public void SendAuthStart(string method, byte[] authData, byte[] initialResponse)
	{
		AuthenticateStart authenticateStart = new AuthenticateStart();
		authenticateStart.MechName = method;
		if (authData != null)
		{
			authenticateStart.AuthData = ByteString.CopyFrom(authData);
		}
		if (initialResponse != null)
		{
			authenticateStart.InitialResponse = ByteString.CopyFrom(initialResponse);
		}
		_writer.Write(ClientMessageId.SESS_AUTHENTICATE_START, authenticateStart);
	}

	public byte[] ReadAuthContinue()
	{
		CommunicationPacket communicationPacket = ReadPacket();
		if (communicationPacket.MessageType != 3)
		{
			throw new MySqlException("Unexpected message encountered during authentication handshake");
		}
		AuthenticateContinue authenticateContinue = AuthenticateContinue.Parser.ParseFrom(communicationPacket.Buffer);
		if (!authenticateContinue.AuthData.IsEmpty)
		{
			return authenticateContinue.AuthData.ToByteArray();
		}
		return null;
	}

	public void SendAuthContinue(byte[] data)
	{
		AuthenticateContinue authenticateContinue = new AuthenticateContinue();
		authenticateContinue.AuthData = ByteString.CopyFrom(data);
		_writer.Write(ClientMessageId.SESS_AUTHENTICATE_CONTINUE, authenticateContinue);
	}

	public void ReadAuthOk()
	{
		CommunicationPacket communicationPacket = ReadPacket();
		switch (communicationPacket.MessageType)
		{
		default:
			throw new MySqlException("Unexpected message encountered during authentication handshake");
		case 11:
			ReadAuthOk();
			break;
		case 1:
		{
			Error error = Error.Parser.ParseFrom(communicationPacket.Buffer);
			throw new MySqlException(error.Code, error.SqlState, error.Msg);
		}
		case 4:
			break;
		}
	}

	public void GetServerCapabilities()
	{
		_writer.Write(ClientMessageId.CON_CAPABILITIES_GET, new CapabilitiesGet());
		CommunicationPacket communicationPacket = ReadPacket();
		if (communicationPacket.MessageType == 11)
		{
			communicationPacket = ReadPacket();
		}
		if (communicationPacket.MessageType != 2)
		{
			ThrowUnexpectedMessage(communicationPacket.MessageType, 2);
		}
		Capabilities = Capabilities.Parser.ParseFrom(communicationPacket.Buffer);
	}

	public void SetCapabilities(Dictionary<string, object> clientCapabilities)
	{
		if (clientCapabilities == null || clientCapabilities.Count == 0)
		{
			return;
		}
		CapabilitiesSet capabilitiesSet = new CapabilitiesSet();
		Capabilities capabilities = new Capabilities();
		foreach (KeyValuePair<string, object> clientCapability in clientCapabilities)
		{
			Any value = new Any();
			if (clientCapability.Key == "tls")
			{
				value = ExprUtil.BuildAny(clientCapability.Value);
			}
			else if (clientCapability.Key == "session_connect_attrs" || clientCapability.Key == "compression")
			{
				Mysqlx.Datatypes.Object @object = new Mysqlx.Datatypes.Object();
				if (clientCapability.Key == "session_connect_attrs")
				{
					foreach (KeyValuePair<string, string> item2 in (Dictionary<string, string>)clientCapability.Value)
					{
						@object.Fld.Add(new Mysqlx.Datatypes.Object.Types.ObjectField
						{
							Key = item2.Key,
							Value = ExprUtil.BuildAny(item2.Value)
						});
					}
				}
				else if (clientCapability.Key == "compression")
				{
					foreach (KeyValuePair<string, object> item3 in (Dictionary<string, object>)clientCapability.Value)
					{
						@object.Fld.Add(new Mysqlx.Datatypes.Object.Types.ObjectField
						{
							Key = item3.Key,
							Value = ExprUtil.BuildAny(item3.Value)
						});
					}
				}
				value = new Any
				{
					Type = Any.Types.Type.Object,
					Obj = @object
				};
			}
			Capability item = new Capability
			{
				Name = clientCapability.Key,
				Value = value
			};
			capabilities.Capabilities_.Add(item);
		}
		capabilitiesSet.Capabilities = capabilities;
		_writer.Write(ClientMessageId.CON_CAPABILITIES_SET, capabilitiesSet);
		ReadOk();
	}

	private void ThrowUnexpectedMessage(int received, int expected)
	{
		if (received == 10)
		{
			throw new MySqlException("Unsupported protocol version.");
		}
		throw new MySqlException($"Expected message id: {expected}.  Received message id: {received}");
	}

	public override void SendSQL(string sql, params object[] args)
	{
		SendExecuteSQLStatement(sql, args);
	}

	public override bool HasData(BaseResult rs)
	{
		while (true)
		{
			CommunicationPacket communicationPacket = PeekPacket();
			switch (communicationPacket.MessageType)
			{
			case 1:
				communicationPacket = ReadPacket();
				DecodeAndThrowError(communicationPacket);
				break;
			case 11:
				ProcessNotice(communicationPacket, rs);
				communicationPacket = ReadPacket();
				break;
			case 12:
				return true;
			default:
				return false;
			}
		}
	}

	private CommunicationPacket PeekPacket()
	{
		if (pendingPacket != null)
		{
			return pendingPacket;
		}
		pendingPacket = _reader.Read();
		return pendingPacket;
	}

	private CommunicationPacket ReadPacket()
	{
		CommunicationPacket result = ((pendingPacket != null) ? pendingPacket : _reader.Read());
		pendingPacket = null;
		return result;
	}

	private void ProcessGlobalNotice(Frame frame)
	{
	}

	private void ProcessNotice(CommunicationPacket packet, BaseResult rs)
	{
		Frame frame = Frame.Parser.ParseFrom(packet.Buffer);
		if (frame.Scope == Frame.Types.Scope.Global)
		{
			ProcessGlobalNotice(frame);
			return;
		}
		switch (frame.Type)
		{
		case 1u:
			ProcessWarning(rs, frame.Payload.ToByteArray());
			break;
		case 3u:
			ProcessSessionStateChanged(rs, frame.Payload.ToByteArray());
			break;
		case 2u:
			break;
		}
	}

	private void ProcessSessionStateChanged(BaseResult rs, byte[] payload)
	{
		SessionStateChanged sessionStateChanged = SessionStateChanged.Parser.ParseFrom(payload);
		switch (sessionStateChanged.Param)
		{
		case SessionStateChanged.Types.Parameter.RowsAffected:
			rs._recordsAffected = sessionStateChanged.Value[0].VUnsignedInt;
			rs._affectedItemsCount = rs._recordsAffected;
			break;
		case SessionStateChanged.Types.Parameter.GeneratedInsertId:
			rs._autoIncrementValue = sessionStateChanged.Value[0].VUnsignedInt;
			break;
		case SessionStateChanged.Types.Parameter.GeneratedDocumentIds:
		{
			foreach (Scalar item in sessionStateChanged.Value)
			{
				rs._documentIds.Add(item.VOctets.Value.ToStringUtf8());
			}
			break;
		}
		case SessionStateChanged.Types.Parameter.ProducedMessage:
			rs.AddWarning(new WarningInfo(0u, sessionStateChanged.Value[0].VString.Value.ToStringUtf8()));
			break;
		}
	}

	private void ProcessWarning(BaseResult rs, byte[] payload)
	{
		Warning warning = Warning.Parser.ParseFrom(payload);
		WarningInfo warningInfo = new WarningInfo(warning.Code, warning.Msg);
		if (warning.Level != 0)
		{
			warningInfo.Level = (uint)warning.Level;
		}
		rs.AddWarning(warningInfo);
	}

	private Any CreateAny(object o)
	{
		if (o is string)
		{
			return ExprUtil.BuildAny((string)o);
		}
		if (o is bool)
		{
			return ExprUtil.BuildAny((bool)o);
		}
		return ExprUtil.BuildAny(o);
	}

	private Mysqlx.Datatypes.Object.Types.ObjectField CreateObject(string key, object value, bool evaluateStringExpression = true)
	{
		return ExprUtil.BuildObject(key, value, evaluateStringExpression);
	}

	public void SendSessionClose()
	{
		_writer.Write(ClientMessageId.SESS_CLOSE, new Mysqlx.Session.Close());
	}

	public void SendConnectionClose()
	{
		Mysqlx.Connection.Close message = new Mysqlx.Connection.Close();
		_writer.Write(ClientMessageId.CON_CLOSE, message);
	}

	internal StmtExecute CreateExecuteSQLStatement(string stmt, params object[] args)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = "sql";
		stmtExecute.Stmt = ByteString.CopyFromUtf8(stmt);
		stmtExecute.CompactMetadata = false;
		if (args != null)
		{
			foreach (object o in args)
			{
				stmtExecute.Args.Add(CreateAny(o));
			}
		}
		return stmtExecute;
	}

	public void SendExecuteSQLStatement(string stmt, params object[] args)
	{
		StmtExecute message = CreateExecuteSQLStatement(stmt, args);
		_writer.Write(ClientMessageId.SQL_STMT_EXECUTE, message);
	}

	public void SendExecuteStatement(string ns, string stmt, params KeyValuePair<string, object>[] args)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = ns;
		stmtExecute.Stmt = ByteString.CopyFromUtf8(stmt);
		stmtExecute.CompactMetadata = false;
		if (args != null)
		{
			Any any = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
			for (int i = 0; i < args.Length; i++)
			{
				KeyValuePair<string, object> keyValuePair = args[i];
				if (stmt != null && stmt == "drop_collection_index")
				{
					any.Obj.Fld.Add(CreateObject(keyValuePair.Key, keyValuePair.Value, evaluateStringExpression: false));
				}
				else
				{
					any.Obj.Fld.Add(CreateObject(keyValuePair.Key, keyValuePair.Value));
				}
			}
			stmtExecute.Args.Add(any);
		}
		_writer.Write(ClientMessageId.SQL_STMT_EXECUTE, stmtExecute);
	}

	public void SendExecuteStatementOptions(string ns, string stmt, params KeyValuePair<string, object>[] args)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = ns;
		stmtExecute.Stmt = ByteString.CopyFromUtf8(stmt);
		stmtExecute.CompactMetadata = false;
		if (args != null)
		{
			Mysqlx.Datatypes.Object.Types.ObjectField objectField = new Mysqlx.Datatypes.Object.Types.ObjectField();
			Mysqlx.Datatypes.Object.Types.ObjectField objectField2 = new Mysqlx.Datatypes.Object.Types.ObjectField();
			Mysqlx.Datatypes.Object.Types.ObjectField objectField3 = new Mysqlx.Datatypes.Object.Types.ObjectField();
			Any any = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
			Any any2 = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
			Any any3 = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
			Any value = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
			for (int i = 0; i < args.Length; i++)
			{
				KeyValuePair<string, object> keyValuePair = args[i];
				if (keyValuePair.Value is Dictionary<string, object> && keyValuePair.Key == "options")
				{
					foreach (KeyValuePair<string, object> item in keyValuePair.Value as Dictionary<string, object>)
					{
						any3.Obj.Fld.Add(CreateObject(item.Key, item.Value));
					}
				}
				else if (keyValuePair.Key == "reuse_existing")
				{
					value = ExprUtil.BuildAny(keyValuePair.Value);
				}
				else
				{
					any2.Obj.Fld.Add(CreateObject(keyValuePair.Key, keyValuePair.Value));
				}
			}
			objectField.Key = "options";
			objectField2.Key = "validation";
			objectField2.Value = any3;
			objectField3.Key = "reuse_existing";
			objectField3.Value = value;
			any.Obj.Fld.Add(objectField2);
			if (stmt == "create_collection")
			{
				any.Obj.Fld.Add(objectField3);
			}
			objectField.Value = any;
			any2.Obj.Fld.Add(objectField);
			stmtExecute.Args.Add(any2);
		}
		_writer.Write(ClientMessageId.SQL_STMT_EXECUTE, stmtExecute);
	}

	public void SendCreateCollectionIndexStatement(string ns, string stmt, params KeyValuePair<string, object>[] args)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = ns;
		stmtExecute.Stmt = ByteString.CopyFromUtf8(stmt);
		stmtExecute.CompactMetadata = false;
		if (args != null)
		{
			Any any = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
			Mysqlx.Datatypes.Array array = new Mysqlx.Datatypes.Array();
			for (int i = 0; i < args.Length; i++)
			{
				KeyValuePair<string, object> keyValuePair = args[i];
				if (keyValuePair.Value is Dictionary<string, object> && keyValuePair.Key == "constraint")
				{
					Any any2 = ExprUtil.BuildEmptyAny(Any.Types.Type.Object);
					foreach (KeyValuePair<string, object> item in keyValuePair.Value as Dictionary<string, object>)
					{
						any2.Obj.Fld.Add(CreateObject(item.Key, item.Value, (item.Key == "member") ? true : false));
					}
					array.Value.Add(any2);
				}
				else
				{
					any.Obj.Fld.Add(CreateObject(keyValuePair.Key, keyValuePair.Value, evaluateStringExpression: false));
				}
			}
			if (array.Value.Count > 0)
			{
				Mysqlx.Datatypes.Object.Types.ObjectField objectField = new Mysqlx.Datatypes.Object.Types.ObjectField();
				objectField.Key = "constraint";
				Any any3 = ExprUtil.BuildEmptyAny(Any.Types.Type.Array);
				any3.Array = array;
				objectField.Value = any3;
				any.Obj.Fld.Add(objectField);
			}
			stmtExecute.Args.Add(any);
		}
		_writer.Write(ClientMessageId.SQL_STMT_EXECUTE, stmtExecute);
	}

	private void DecodeAndThrowError(CommunicationPacket p)
	{
		Error error = Error.Parser.ParseFrom(p.Buffer);
		throw new MySqlException(error.Code, error.SqlState, error.Msg);
	}

	public override List<byte[]> ReadRow(BaseResult rs)
	{
		if (PeekPacket().MessageType != 13)
		{
			if (rs != null)
			{
				CloseResult(rs);
			}
			return null;
		}
		Mysqlx.Resultset.Row row = Mysqlx.Resultset.Row.Parser.ParseFrom(ReadPacket().Buffer);
		List<byte[]> list = new List<byte[]>(row.Field.Count);
		for (int i = 0; i < row.Field.Count; i++)
		{
			list.Add(row.Field[i].ToByteArray());
		}
		return list;
	}

	public override void CloseResult(BaseResult rs)
	{
		rs._hasData = false;
		CommunicationPacket communicationPacket;
		while (true)
		{
			communicationPacket = PeekPacket();
			if (communicationPacket.MessageType != 16)
			{
				if (communicationPacket.MessageType != 0)
				{
					if (communicationPacket.MessageType == 14)
					{
						ReadPacket();
						continue;
					}
					if (communicationPacket.MessageType == 11)
					{
						ProcessNotice(ReadPacket(), rs);
						continue;
					}
					if (communicationPacket.MessageType != 1)
					{
						break;
					}
					rs._session.ActiveResult = null;
					DecodeAndThrowError(ReadPacket());
					continue;
				}
				ReadOk();
				return;
			}
			rs._hasMoreResults = true;
			ReadPacket();
			return;
		}
		if (communicationPacket.MessageType != 17)
		{
			throw new MySqlException(ResourcesX.ThrowingAwayResults);
		}
		ReadPacket();
	}

	public override List<MySqlX.XDevAPI.Relational.Column> LoadColumnMetadata()
	{
		List<MySqlX.XDevAPI.Relational.Column> list = new List<MySqlX.XDevAPI.Relational.Column>();
		while (PeekPacket().MessageType == 12)
		{
			CommunicationPacket communicationPacket = ReadPacket();
			ColumnMetaData colData = ColumnMetaData.Parser.ParseFrom(communicationPacket.Buffer);
			list.Add(DecodeColumn(colData));
		}
		return list;
	}

	private MySqlX.XDevAPI.Relational.Column DecodeColumn(ColumnMetaData colData)
	{
		MySqlX.XDevAPI.Relational.Column column = new MySqlX.XDevAPI.Relational.Column();
		column._decoder = XValueDecoderFactory.GetValueDecoder(column, colData.Type);
		column._decoder.Column = column;
		if (!colData.Name.IsEmpty)
		{
			column.ColumnLabel = colData.Name.ToStringUtf8();
		}
		if (!colData.OriginalName.IsEmpty)
		{
			column.ColumnName = colData.OriginalName.ToStringUtf8();
		}
		if (!colData.Table.IsEmpty)
		{
			column.TableLabel = colData.Table.ToStringUtf8();
		}
		if (!colData.OriginalTable.IsEmpty)
		{
			column.TableName = colData.OriginalTable.ToStringUtf8();
		}
		if (!colData.Schema.IsEmpty)
		{
			column.SchemaName = colData.Schema.ToStringUtf8();
		}
		if (!colData.Catalog.IsEmpty)
		{
			column.DatabaseName = colData.Catalog.ToStringUtf8();
		}
		if (colData.Collation > 0L)
		{
			column._collationNumber = colData.Collation;
			column.CollationName = CollationMap.GetCollationName((int)colData.Collation);
			column.CharacterSetName = column.CollationName.Split(new char[1] { '_' })[0];
		}
		if (colData.Length != 0)
		{
			column.Length = colData.Length;
		}
		if (colData.FractionalDigits != 0)
		{
			column.FractionalDigits = colData.FractionalDigits;
		}
		if (colData.Flags != 0)
		{
			column._decoder.Flags = colData.Flags;
		}
		if (colData.ContentType != 0)
		{
			column._decoder.ContentType = colData.ContentType;
		}
		column._decoder.SetMetadata();
		return column;
	}

	internal Insert CreateInsertMessage(string schema, bool isRelational, string collection, object[] rows, string[] columns, bool upsert)
	{
		Insert insert = new Insert();
		insert.Collection = ExprUtil.BuildCollection(schema, collection);
		insert.DataModel = ((!isRelational) ? DataModel.Document : DataModel.Table);
		insert.Upsert = upsert;
		if (columns != null && columns.Length != 0)
		{
			foreach (string s in columns)
			{
				insert.Projection.Add(new ExprParser(s).ParseTableInsertField());
			}
		}
		foreach (object obj in rows)
		{
			Insert.Types.TypedRow typedRow = new Insert.Types.TypedRow();
			object[] array = (obj.GetType().IsArray ? ((object[])obj) : new object[1] { obj });
			foreach (object value in array)
			{
				typedRow.Field.Add(ExprUtil.ArgObjectToExpr(value, isRelational));
			}
			insert.Row.Add(typedRow);
		}
		return insert;
	}

	public void SendInsert(string schema, bool isRelational, string collection, object[] rows, string[] columns, bool upsert)
	{
		Insert message = CreateInsertMessage(schema, isRelational, collection, rows, columns, upsert);
		_writer.Write(ClientMessageId.CRUD_INSERT, message);
	}

	private void ApplyFilter(Action<Limit> setLimit, Action<Expr> setCriteria, Action<IEnumerable<Order>> setOrder, FilterParams filter, Action<IEnumerable<Scalar>> addParams)
	{
		if (filter.HasLimit)
		{
			Limit limit = new Limit();
			limit.RowCount = (ulong)filter.Limit;
			if (filter.Offset != -1L)
			{
				limit.Offset = (ulong)filter.Offset;
			}
			setLimit(limit);
		}
		if (!string.IsNullOrEmpty(filter.Condition))
		{
			setCriteria(filter.GetConditionExpression(filter.IsRelational));
			if (filter.Parameters != null && filter.Parameters.Count > 0)
			{
				addParams(filter.GetArgsExpression(filter.Parameters));
			}
		}
		if (filter.OrderBy != null && filter.OrderBy.Length != 0)
		{
			setOrder(filter.GetOrderByExpressions(filter.IsRelational));
		}
	}

	internal Delete CreateDeleteMessage(string schema, string collection, bool isRelational, FilterParams filter)
	{
		Delete msg = new Delete();
		msg.DataModel = ((!isRelational) ? DataModel.Document : DataModel.Table);
		msg.Collection = ExprUtil.BuildCollection(schema, collection);
		ApplyFilter(delegate(Limit v)
		{
			msg.Limit = v;
		}, delegate(Expr v)
		{
			msg.Criteria = v;
		}, msg.Order.Add, filter, msg.Args.Add);
		return msg;
	}

	public void SendDelete(string schema, string collection, bool isRelational, FilterParams filter)
	{
		Delete message = CreateDeleteMessage(schema, collection, isRelational, filter);
		_writer.Write(ClientMessageId.CRUD_DELETE, message);
	}

	internal Update CreateUpdateMessage(string schema, string collection, bool isRelational, FilterParams filter, List<UpdateSpec> updates)
	{
		Update msg = new Update();
		msg.DataModel = ((!isRelational) ? DataModel.Document : DataModel.Table);
		msg.Collection = ExprUtil.BuildCollection(schema, collection);
		ApplyFilter(delegate(Limit v)
		{
			msg.Limit = v;
		}, delegate(Expr v)
		{
			msg.Criteria = v;
		}, msg.Order.Add, filter, msg.Args.Add);
		foreach (UpdateSpec update in updates)
		{
			UpdateOperation updateOperation = new UpdateOperation();
			updateOperation.Operation = update.Type;
			updateOperation.Source = update.GetSource(isRelational);
			if (update.Type != UpdateOperation.Types.UpdateType.ItemRemove || (update.Type == UpdateOperation.Types.UpdateType.ItemRemove && update.HasValue))
			{
				updateOperation.Value = update.GetValue(update.Type);
			}
			msg.Operation.Add(updateOperation);
		}
		return msg;
	}

	public void SendUpdate(string schema, string collection, bool isRelational, FilterParams filter, List<UpdateSpec> updates)
	{
		Update message = CreateUpdateMessage(schema, collection, isRelational, filter, updates);
		_writer.Write(ClientMessageId.CRUD_UPDATE, message);
	}

	internal Find CreateFindMessage(string schema, string collection, bool isRelational, FilterParams filter, FindParams findParams)
	{
		Find builder = new Find();
		builder.Collection = ExprUtil.BuildCollection(schema, collection);
		builder.DataModel = ((!isRelational) ? DataModel.Document : DataModel.Table);
		if (findParams.GroupBy != null && findParams.GroupBy.Length != 0)
		{
			builder.Grouping.AddRange(new ExprParser(ExprUtil.JoinString(findParams.GroupBy)).ParseExprList());
		}
		if (findParams.GroupByCritieria != null)
		{
			builder.GroupingCriteria = new ExprParser(findParams.GroupByCritieria).Parse();
		}
		if (findParams.Locking != 0)
		{
			builder.Locking = (Find.Types.RowLock)findParams.Locking;
		}
		if (findParams.LockingOption != 0)
		{
			builder.LockingOptions = (Find.Types.RowLockOptions)findParams.LockingOption;
		}
		if (findParams.Projection != null && findParams.Projection.Length != 0)
		{
			ExprParser exprParser = new ExprParser(ExprUtil.JoinString(findParams.Projection));
			builder.Projection.Add((builder.DataModel == DataModel.Document) ? exprParser.ParseDocumentProjection() : exprParser.ParseTableSelectProjection());
			if (exprParser.tokenPos < exprParser.tokens.Count)
			{
				throw new ArgumentException($"Expression has unexpected token '{exprParser.tokens[exprParser.tokenPos].value}' at position {exprParser.tokenPos}.");
			}
		}
		ApplyFilter(delegate(Limit v)
		{
			builder.Limit = v;
		}, delegate(Expr v)
		{
			builder.Criteria = v;
		}, builder.Order.Add, filter, builder.Args.Add);
		return builder;
	}

	public void SendFind(string schema, string collection, bool isRelational, FilterParams filter, FindParams findParams)
	{
		Find message = CreateFindMessage(schema, collection, isRelational, filter, findParams);
		_writer.Write(ClientMessageId.CRUD_FIND, message);
	}

	public void SendExpectOpen(Open.Types.Condition.Types.Key condition, object value = null)
	{
		Open open = new Open();
		Open.Types.Condition condition2 = new Open.Types.Condition();
		condition2.ConditionKey = (uint)condition;
		condition2.ConditionValue = ((value != null) ? ByteString.CopyFromUtf8((string)value) : null);
		open.Cond.Add(condition2);
		_writer.Write(ClientMessageId.EXPECT_OPEN, open);
	}

	public void SendResetSession(bool sessionResetNoReauthentication)
	{
		Reset reset = new Reset();
		if (sessionResetNoReauthentication)
		{
			reset.KeepOpen = sessionResetNoReauthentication;
		}
		_writer.Write(ClientMessageId.SESS_RESET, reset);
	}

	internal void ReadOkClose()
	{
		try
		{
			if (ReadOk().IndexOf("bye", 0, StringComparison.OrdinalIgnoreCase) < 0)
			{
				throw new ArgumentException();
			}
		}
		catch (IOException)
		{
		}
		catch (Exception ex2)
		{
			throw new MySqlException("Unexpected message encountered during closing session", ex2);
		}
	}

	internal string ReadOk()
	{
		CommunicationPacket communicationPacket = ReadPacket();
		if (communicationPacket.MessageType == 1)
		{
			Error error = Error.Parser.ParseFrom(communicationPacket.Buffer);
			throw new MySqlException(error.Code, error.SqlState, error.Msg);
		}
		if (communicationPacket.MessageType != 0)
		{
			throw new InvalidOperationException();
		}
		return Ok.Parser.ParseFrom(communicationPacket.Buffer).Msg;
	}

	internal void SetXPackets(XPacketReaderWriter reader, XPacketReaderWriter writer)
	{
		_reader = reader;
		_writer = writer;
	}

	public void SendPrepareStatement(uint stmtId, PreparedStatementType type, string schema, string collection, bool isRelational, FilterParams filter, FindParams findParams, List<UpdateSpec> updateSpecs = null, object[] rows = null, string[] columns = null, bool upsert = false, string sql = null)
	{
		Prepare prepare = new Prepare();
		prepare.StmtId = stmtId;
		prepare.Stmt = new Prepare.Types.OneOfMessage();
		switch (type)
		{
		case PreparedStatementType.Find:
		{
			prepare.Stmt.Type = Prepare.Types.OneOfMessage.Types.Type.Find;
			Find find = CreateFindMessage(schema, collection, isRelational, filter, findParams);
			find.Args.Clear();
			if (filter.HasLimit)
			{
				uint count2 = (uint)filter.Parameters.Count;
				find.Limit = null;
				find.LimitExpr = new LimitExpr
				{
					RowCount = new Expr
					{
						Type = Expr.Types.Type.Placeholder,
						Position = count2++
					},
					Offset = new Expr
					{
						Type = Expr.Types.Type.Placeholder,
						Position = count2++
					}
				};
			}
			prepare.Stmt.Find = find;
			break;
		}
		case PreparedStatementType.Insert:
		{
			prepare.Stmt.Type = Prepare.Types.OneOfMessage.Types.Type.Insert;
			Insert insert = CreateInsertMessage(schema, isRelational, collection, rows, columns, upsert);
			insert.Args.Clear();
			uint num = 0u;
			foreach (Insert.Types.TypedRow item in insert.Row)
			{
				foreach (Expr item2 in item.Field)
				{
					if (item2.Type == Expr.Types.Type.Literal)
					{
						item2.Type = Expr.Types.Type.Placeholder;
						item2.Literal = null;
						item2.Position = num++;
					}
				}
			}
			prepare.Stmt.Insert = insert;
			break;
		}
		case PreparedStatementType.Update:
		{
			prepare.Stmt.Type = Prepare.Types.OneOfMessage.Types.Type.Update;
			Update update = CreateUpdateMessage(schema, collection, isRelational, filter, updateSpecs);
			update.Args.Clear();
			if (filter.HasLimit)
			{
				uint count3 = (uint)filter.Parameters.Count;
				update.Limit = null;
				update.LimitExpr = new LimitExpr
				{
					RowCount = new Expr
					{
						Type = Expr.Types.Type.Placeholder,
						Position = count3++
					}
				};
			}
			prepare.Stmt.Update = update;
			break;
		}
		case PreparedStatementType.Delete:
		{
			prepare.Stmt.Type = Prepare.Types.OneOfMessage.Types.Type.Delete;
			Delete delete = CreateDeleteMessage(schema, collection, isRelational, filter);
			delete.Args.Clear();
			if (filter.HasLimit)
			{
				uint count = (uint)filter.Parameters.Count;
				delete.Limit = null;
				delete.LimitExpr = new LimitExpr
				{
					RowCount = new Expr
					{
						Type = Expr.Types.Type.Placeholder,
						Position = count++
					}
				};
			}
			prepare.Stmt.Delete = delete;
			break;
		}
		case PreparedStatementType.SqlStatement:
		{
			prepare.Stmt.Type = Prepare.Types.OneOfMessage.Types.Type.Stmt;
			StmtExecute stmtExecute = CreateExecuteSQLStatement(sql, rows);
			stmtExecute.Args.Clear();
			prepare.Stmt.StmtExecute = stmtExecute;
			break;
		}
		}
		_writer.Write(40, prepare);
		ReadOk();
	}

	public void SendExecutePreparedStatement(uint stmtId, IEnumerable args)
	{
		Execute execute = new Execute();
		execute.StmtId = stmtId;
		AddArgs(execute.Args.Add, args);
		_writer.Write(41, execute);
	}

	public void AddArgs(Action<Any> addFunction, IEnumerable args)
	{
		foreach (object arg in args)
		{
			if (arg.GetType().IsArray)
			{
				AddArgs(addFunction, (System.Array)arg);
			}
			else
			{
				addFunction(ExprUtil.BuildAny(arg));
			}
		}
	}

	public void SendDeallocatePreparedStatement(uint stmtId)
	{
		Deallocate deallocate = new Deallocate();
		deallocate.StmtId = stmtId;
		_writer.Write(42, deallocate);
		ReadOk();
	}
}
