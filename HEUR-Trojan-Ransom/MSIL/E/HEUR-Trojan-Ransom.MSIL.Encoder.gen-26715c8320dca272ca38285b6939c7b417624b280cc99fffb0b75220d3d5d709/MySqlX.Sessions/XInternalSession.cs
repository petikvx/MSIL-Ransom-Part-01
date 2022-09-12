using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;
using MySql.Data.X.Communication;
using MySql.Data.X.XDevAPI.Common;
using MySqlX.Communication;
using MySqlX.DataAccess;
using MySqlX.Protocol;
using MySqlX.Protocol.X;
using MySqlX.Security;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using Mysqlx.Connection;
using Mysqlx.Datatypes;
using Mysqlx.Expect;

namespace MySqlX.Sessions;

internal class XInternalSession : InternalSession
{
	private XCompressionController _readerCompressionController;

	private XCompressionController _writerCompressionController;

	private XProtocol protocol;

	private XPacketReaderWriter _reader;

	private XPacketReaderWriter _writer;

	private bool serverSupportsTls;

	private const string mysqlxNamespace = "mysqlx";

	internal bool _supportsPreparedStatements = true;

	private int _stmtId;

	private List<int> _preparedStatements = new List<int>();

	internal bool? sessionResetNoReauthentication;

	private Ssh _sshHandler;

	public XInternalSession(MySqlXConnectionStringBuilder settings)
		: base(settings)
	{
	}

	protected override void Open()
	{
		if (Settings.ConnectionProtocol == MySqlConnectionProtocol.Sockets && Settings.IsSshEnabled())
		{
			_sshHandler = new Ssh(Settings.SshHostName, Settings.SshUserName, Settings.SshPassword, Settings.SshKeyFile, Settings.SshPassphrase, Settings.SshPort, Settings.Server, Settings.Port, isXProtocol: true);
			_sshHandler.StartClient();
		}
		bool unix = Settings.ConnectionProtocol == MySqlConnectionProtocol.UnixSocket || Settings.ConnectionProtocol == MySqlConnectionProtocol.UnixSocket;
		_stream = MyNetworkStream.CreateStream((Settings.Server == "127.0.0.1" || Settings.Server == "::1") ? "localhost" : Settings.Server, Settings.ConnectTimeout, Settings.Keepalive, Settings.Port, unix);
		if (_stream == null)
		{
			throw new MySqlException(ResourcesX.UnableToConnect);
		}
		_reader = new XPacketReaderWriter(_stream);
		_writer = new XPacketReaderWriter(_stream);
		protocol = new XProtocol(_reader, _writer);
		Settings.CharacterSet = (string.IsNullOrWhiteSpace(Settings.CharacterSet) ? "utf8mb4" : Settings.CharacterSet);
		Encoding encoding = Encoding.GetEncoding((string.Compare(Settings.CharacterSet, "utf8mb4", ignoreCase: true) == 0) ? "UTF-8" : Settings.CharacterSet);
		SetState(SessionState.Connecting, broadcast: false);
		try
		{
			GetAndSetCapabilities();
		}
		catch (Exception)
		{
			if (Settings.ConnectionProtocol == MySqlConnectionProtocol.Sockets && Settings.IsSshEnabled())
			{
				_sshHandler?.StopClient();
			}
			throw;
		}
		if (Settings.SslMode != 0)
		{
			if (!serverSupportsTls)
			{
				throw new MySqlException(string.Format(Resources.NoServerSSLSupport, Settings.Server));
			}
			new Ssl(Settings.Server, Settings.SslMode, Settings.CertificateFile, Settings.CertificateStoreLocation, Settings.CertificatePassword, Settings.CertificateThumbprint, Settings.SslCa, Settings.SslCert, Settings.SslKey, Settings.TlsVersion).StartSSL(ref _stream, encoding, Settings.ToString());
			if (_readerCompressionController != null && _readerCompressionController.IsCompressionEnabled)
			{
				_reader = new XPacketReaderWriter(_stream, _readerCompressionController);
				_writer = new XPacketReaderWriter(_stream, _writerCompressionController);
			}
			else
			{
				_reader = new XPacketReaderWriter(_stream);
				_writer = new XPacketReaderWriter(_stream);
			}
			protocol.SetXPackets(_reader, _writer);
		}
		else if (_readerCompressionController != null && _readerCompressionController.IsCompressionEnabled)
		{
			_reader = new XPacketReaderWriter(_stream, _readerCompressionController);
			_writer = new XPacketReaderWriter(_stream, _writerCompressionController);
			protocol.SetXPackets(_reader, _writer);
		}
		Authenticate();
		SetState(SessionState.Open, broadcast: false);
	}

	internal void Authenticate()
	{
		if (Settings.Auth == MySqlAuthenticationMode.Default)
		{
			if ((Settings.SslMode != 0 && serverSupportsTls) || Settings.ConnectionProtocol == MySqlConnectionProtocol.UnixSocket)
			{
				Settings.Auth = MySqlAuthenticationMode.PLAIN;
				AuthenticatePlain();
				return;
			}
			bool flag = false;
			Settings.Auth = MySqlAuthenticationMode.MYSQL41;
			try
			{
				AuthenticateMySQL41();
				flag = true;
			}
			catch (MySqlException ex)
			{
				if (ex.Code != 1045)
				{
					throw;
				}
			}
			if (flag)
			{
				return;
			}
			try
			{
				Settings.Auth = MySqlAuthenticationMode.SHA256_MEMORY;
				AuthenticateSha256Memory();
				flag = true;
				return;
			}
			catch (MySqlException ex2)
			{
				if (ex2.Code == 1045)
				{
					throw new MySqlException(1045u, "HY000", ResourcesX.AuthenticationFailed);
				}
				throw;
			}
		}
		switch (Settings.Auth)
		{
		default:
			throw new NotImplementedException(Settings.Auth.ToString());
		case MySqlAuthenticationMode.PLAIN:
			AuthenticatePlain();
			break;
		case MySqlAuthenticationMode.MYSQL41:
			AuthenticateMySQL41();
			break;
		case MySqlAuthenticationMode.EXTERNAL:
			AuthenticateExternal();
			break;
		case MySqlAuthenticationMode.SHA256_MEMORY:
			AuthenticateSha256Memory();
			break;
		}
	}

	private void GetAndSetCapabilities()
	{
		protocol.GetServerCapabilities();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		Capability capability = null;
		if (Settings.SslMode != 0)
		{
			capability = ((IEnumerable<Capability>)protocol.Capabilities.Capabilities_).FirstOrDefault((Capability i) => i.Name.ToLowerInvariant() == "tls");
			if (capability != null)
			{
				serverSupportsTls = true;
				dictionary.Add("tls", "1");
			}
		}
		if (Settings.ConnectionAttributes.ToLower() != "false")
		{
			dictionary.Add("session_connect_attrs", GetConnectionAttributes(Settings.ConnectionAttributes));
		}
		if (Settings.Compression != CompressionType.Disabled)
		{
			capability = ((IEnumerable<Capability>)protocol.Capabilities.Capabilities_).FirstOrDefault((Capability i) => i.Name.ToLowerInvariant() == "compression");
			if (Settings.Compression == CompressionType.Required && capability == null)
			{
				throw new NotSupportedException(ResourcesX.CompressionNotSupportedByServer);
			}
			if (capability != null)
			{
				Dictionary<string, List<string>> dictionary2 = ((IEnumerable<Mysqlx.Datatypes.Object.Types.ObjectField>)capability.Value.Obj.Fld).ToDictionary((Mysqlx.Datatypes.Object.Types.ObjectField field) => field.Key, (Mysqlx.Datatypes.Object.Types.ObjectField field) => ((IEnumerable<Any>)field.Value.Array.Value).ToDictionary((Any value) => value.Scalar.VString.Value.ToStringUtf8().ToLowerInvariant()).Keys.ToList());
				if (dictionary2.ContainsKey("algorithm"))
				{
					string[] serverSupportedAlgorithms = dictionary2["algorithm"].ToList().ToArray();
					Dictionary<string, object> dictionary3 = NegotiateCompression(serverSupportedAlgorithms);
					if (dictionary3 != null)
					{
						dictionary.Add("compression", dictionary3);
						string compressionAlgorithm = dictionary3.First().Value.ToString();
						_readerCompressionController = new XCompressionController(compressionAlgorithm, initializeForCompression: false);
						_writerCompressionController = new XCompressionController(compressionAlgorithm, initializeForCompression: true);
						_reader = new XPacketReaderWriter(_stream, _readerCompressionController);
						_writer = new XPacketReaderWriter(_stream, _writerCompressionController);
					}
				}
			}
		}
		try
		{
			protocol.SetCapabilities(dictionary);
		}
		catch (MySqlException ex)
		{
			if (ex.Message == "Capability 'session_connect_attrs' doesn't exist")
			{
				dictionary.Remove("session_connect_attrs");
			}
			protocol.SetCapabilities(dictionary);
		}
	}

	private Dictionary<string, object> NegotiateCompression(string[] serverSupportedAlgorithms)
	{
		if (serverSupportedAlgorithms != null && serverSupportedAlgorithms.Length != 0)
		{
			XCompressionController.LoadLibzstdLibrary();
			if (!XCompressionController.ClientSupportedCompressionAlgorithms.Any((string element) => serverSupportedAlgorithms.Contains(element)))
			{
				if (Settings.Compression == CompressionType.Preferred)
				{
					MySqlTrace.LogWarning(-1, ResourcesX.CompressionAlgorithmNegotiationFailed);
					return null;
				}
				if (Settings.Compression == CompressionType.Required)
				{
					throw new NotSupportedException(ResourcesX.CompressionAlgorithmNegotiationFailed);
				}
			}
			string text = null;
			for (int i = 0; i < XCompressionController.ClientSupportedCompressionAlgorithms.Length; i++)
			{
				if (serverSupportedAlgorithms.Contains(XCompressionController.ClientSupportedCompressionAlgorithms[i]))
				{
					text = XCompressionController.ClientSupportedCompressionAlgorithms[i];
					break;
				}
			}
			if (text == null)
			{
				return null;
			}
			return new Dictionary<string, object>
			{
				{ "algorithm", text },
				{ "server_combine_mixed_messages", true }
			};
		}
		return null;
	}

	private Dictionary<string, string> GetConnectionAttributes(string connectionAttrs)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (connectionAttrs.StartsWith("[") && connectionAttrs.EndsWith("]"))
		{
			connectionAttrs = connectionAttrs.Substring(1, connectionAttrs.Length - 2);
			if (!string.IsNullOrWhiteSpace(connectionAttrs))
			{
				string[] array = connectionAttrs.Split(new char[1] { ',' });
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[1] { '=' });
					string text = array2[0].Trim();
					string value = ((array2.Length > 1) ? array2[1].Trim() : string.Empty);
					if (!(text == string.Empty))
					{
						if (!text.StartsWith("_"))
						{
							try
							{
								dictionary.Add(text, value);
							}
							catch (ArgumentException)
							{
								throw new MySqlException(string.Format(ResourcesX.DuplicateUserDefinedAttribute, text));
							}
							continue;
						}
						throw new MySqlException(ResourcesX.InvalidUserDefinedAttribute);
					}
					throw new MySqlException(ResourcesX.EmptyKeyConnectionAttribute);
				}
			}
		}
		else if (connectionAttrs != "true")
		{
			throw new MySqlException(ResourcesX.InvalidConnectionAttributes);
		}
		MySqlConnectAttrs mySqlConnectAttrs = new MySqlConnectAttrs();
		dictionary.Add("_pid", mySqlConnectAttrs.PID);
		dictionary.Add("_platform", mySqlConnectAttrs.Platform);
		dictionary.Add("_os", mySqlConnectAttrs.OSName);
		dictionary.Add("_source_host", Settings.Server);
		dictionary.Add("_client_name", mySqlConnectAttrs.ClientName);
		dictionary.Add("_client_version", mySqlConnectAttrs.ClientVersion);
		dictionary.Add("_client_license", mySqlConnectAttrs.ClientLicence);
		dictionary.Add("_framework", mySqlConnectAttrs.Framework);
		return dictionary;
	}

	private void AuthenticateMySQL41()
	{
		MySQL41AuthenticationPlugin mySQL41AuthenticationPlugin = new MySQL41AuthenticationPlugin(Settings);
		protocol.SendAuthStart(mySQL41AuthenticationPlugin.AuthName, null, null);
		byte[] salt = protocol.ReadAuthContinue();
		protocol.SendAuthContinue(mySQL41AuthenticationPlugin.Continue(salt));
		protocol.ReadAuthOk();
	}

	private void AuthenticatePlain()
	{
		PlainAuthenticationPlugin plainAuthenticationPlugin = new PlainAuthenticationPlugin(Settings);
		protocol.SendAuthStart(plainAuthenticationPlugin.AuthName, plainAuthenticationPlugin.GetAuthData(), null);
		protocol.ReadAuthOk();
	}

	private void AuthenticateExternal()
	{
		ExternalAuthenticationPlugin externalAuthenticationPlugin = new ExternalAuthenticationPlugin(Settings);
		protocol.SendAuthStart(externalAuthenticationPlugin.AuthName, Encoding.UTF8.GetBytes(""), null);
		protocol.ReadAuthOk();
	}

	private void AuthenticateSha256Memory()
	{
		Sha256MemoryAuthenticationPlugin sha256MemoryAuthenticationPlugin = new Sha256MemoryAuthenticationPlugin();
		protocol.SendAuthStart(sha256MemoryAuthenticationPlugin.PluginName, null, null);
		byte[] nonce = protocol.ReadAuthContinue();
		string s = Settings.Database + "\0" + Settings.UserID + "\0";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		byte[] clientHash = sha256MemoryAuthenticationPlugin.GetClientHash(Settings.Password, nonce);
		byte[] array = new byte[bytes.Length + clientHash.Length];
		bytes.CopyTo(array, 0);
		clientHash.CopyTo(array, bytes.Length);
		protocol.SendAuthContinue(array);
		protocol.ReadAuthOk();
	}

	protected internal void SetState(SessionState newState, bool broadcast)
	{
		if (newState != base.SessionState || broadcast)
		{
			_ = base.SessionState;
			base.SessionState = newState;
		}
	}

	internal override ProtocolBase GetProtocol()
	{
		return protocol;
	}

	public override void Close()
	{
		try
		{
			try
			{
				_readerCompressionController?.Close();
				_writerCompressionController?.Close();
				foreach (int preparedStatement in _preparedStatements)
				{
					DeallocatePreparedStatement(preparedStatement);
					_preparedStatements.Remove(preparedStatement);
				}
			}
			catch (Exception)
			{
			}
			protocol.SendSessionClose();
		}
		finally
		{
			if (Settings.ConnectionProtocol == MySqlConnectionProtocol.Sockets && Settings.IsSshEnabled())
			{
				_sshHandler?.StopClient();
			}
			base.SessionState = SessionState.Closed;
			_stream.Dispose();
		}
	}

	public void CreateCollection(string schemaName, string collectionName)
	{
		ExecuteCmdNonQuery(XpluginStatementCommand.XPLUGIN_STMT_CREATE_COLLECTION, true, new KeyValuePair<string, object>("schema", schemaName), new KeyValuePair<string, object>("name", collectionName));
	}

	public void CreateCollection(string schemaName, string collectionName, CreateCollectionOptions options)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!options.Equals(null))
		{
			if (!string.IsNullOrEmpty(options.Validation.Level.ToString()))
			{
				dictionary.Add("level", options.Validation.Level.ToString()!.ToLowerInvariant());
			}
			if (!string.IsNullOrEmpty(options.Validation.Schema))
			{
				dictionary.Add("schema", new DbDoc(options.Validation.Schema));
			}
		}
		ExecuteCmdNonQueryOptions(XpluginStatementCommand.XPLUGIN_STMT_CREATE_COLLECTION, true, new KeyValuePair<string, object>("schema", schemaName), new KeyValuePair<string, object>("name", collectionName), new KeyValuePair<string, object>("reuse_existing", options.ReuseExisting), new KeyValuePair<string, object>("options", dictionary));
	}

	public void ModifyCollection(string schemaName, string collectionName, ModifyCollectionOptions? options)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!options.Equals(null))
		{
			if (options.Value.Validation.Level.HasValue)
			{
				dictionary.Add("level", options.Value.Validation.Level.ToString()!.ToLowerInvariant());
			}
			if (options.Value.Validation.Schema != null)
			{
				dictionary.Add("schema", new DbDoc(options.Value.Validation.Schema));
			}
		}
		ExecuteCmdNonQueryOptions(XpluginStatementCommand.XPLUGIN_STMT_MODIFY_COLLECTION, true, new KeyValuePair<string, object>("schema", schemaName), new KeyValuePair<string, object>("name", collectionName), new KeyValuePair<string, object>("options", dictionary));
	}

	public void DropCollection(string schemaName, string collectionName)
	{
		ExecuteCmdNonQuery(XpluginStatementCommand.XPLUGIN_STMT_DROP_COLLECTION, true, new KeyValuePair<string, object>("schema", schemaName), new KeyValuePair<string, object>("name", collectionName));
	}

	public Result CreateCollectionIndex(CreateCollectionIndexStatement statement)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		list.Add(new KeyValuePair<string, object>("name", statement.createIndexParams.IndexName));
		list.Add(new KeyValuePair<string, object>("collection", statement.Target.Name));
		list.Add(new KeyValuePair<string, object>("schema", statement.Target.Schema.Name));
		list.Add(new KeyValuePair<string, object>("unique", false));
		if (statement.createIndexParams.Type != null)
		{
			list.Add(new KeyValuePair<string, object>("type", statement.createIndexParams.Type));
		}
		for (int i = 0; i < statement.createIndexParams.Fields.Count; i++)
		{
			CreateIndexParams.IndexField indexField = statement.createIndexParams.Fields[i];
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("member", indexField.Field);
			if (indexField.Type != null)
			{
				dictionary.Add("type", indexField.Type);
			}
			if (!indexField.Required.HasValue)
			{
				dictionary.Add("required", false);
			}
			else
			{
				dictionary.Add("required", indexField.Required.Value);
			}
			if (indexField.Options.HasValue)
			{
				dictionary.Add("options", (ulong)indexField.Options.Value);
			}
			if (indexField.Srid.HasValue)
			{
				dictionary.Add("srid", (ulong)indexField.Srid.Value);
			}
			if (indexField.Array.HasValue)
			{
				dictionary.Add("array", indexField.Array.Value);
			}
			list.Add(new KeyValuePair<string, object>("constraint", dictionary));
		}
		return ExecuteCreateCollectionIndex(XpluginStatementCommand.XPLUGIN_STMT_CREATE_COLLECTION_INDEX, throwOnFail: false, list.ToArray());
	}

	public void DropCollectionIndex(string schemaName, string collectionName, string indexName)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		list.Add(new KeyValuePair<string, object>("schema", schemaName));
		list.Add(new KeyValuePair<string, object>("collection", collectionName));
		list.Add(new KeyValuePair<string, object>("name", indexName));
		ExecuteCmdNonQuery(XpluginStatementCommand.XPLUGIN_STMT_DROP_COLLECTION_INDEX, throwOnFail: false, list.ToArray());
	}

	public long TableCount(Schema schema, string name, string type)
	{
		try
		{
			string sql = $"SELECT COUNT(*) FROM {ExprUnparser.QuoteIdentifier(schema.Name)}.{ExprUnparser.QuoteIdentifier(name)}";
			return (long)ExecuteQueryAsScalar(sql);
		}
		catch (MySqlException ex) when (ex.Code == 1146)
		{
			throw new MySqlException(string.Format(ResourcesX.CollectionTableDoesNotExist, type.ToString(), name, schema.Name));
		}
	}

	public bool TableExists(Schema schema, string name)
	{
		string sql = $"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{schema.Name}' AND table_name = '{name}'";
		return (ulong)(long)ExecuteQueryAsScalar(sql) > 0uL;
	}

	private Result ExecuteCmdNonQuery(string cmd, bool throwOnFail, params KeyValuePair<string, object>[] args)
	{
		protocol.SendExecuteStatement("mysqlx", cmd, args);
		return new Result(this);
	}

	private Result ExecuteCmdNonQueryOptions(string cmd, bool throwOnFail, params KeyValuePair<string, object>[] args)
	{
		protocol.SendExecuteStatementOptions("mysqlx", cmd, args);
		return new Result(this);
	}

	private Result ExecuteCreateCollectionIndex(string cmd, bool throwOnFail, params KeyValuePair<string, object>[] args)
	{
		protocol.SendCreateCollectionIndexStatement("mysqlx", cmd, args);
		return new Result(this);
	}

	public List<T> GetObjectList<T>(Schema s, params string[] types) where T : DatabaseObject
	{
		for (int i = 0; i < types.Length; i++)
		{
			types[i] = types[i].ToUpperInvariant();
		}
		ReadOnlyCollection<Row> readOnlyCollection = GetRowResult("list_objects", new KeyValuePair<string, object>("schema", s.Name)).FetchAll();
		List<T> list = new List<T>();
		foreach (Row item2 in readOnlyCollection)
		{
			if (types.Contains(item2.GetString("type").ToUpperInvariant()))
			{
				List<object> list2 = new List<object>(new object[2]
				{
					s,
					item2.GetString("name")
				});
				if (item2["name"] is byte[])
				{
					byte[] array = item2["name"] as byte[];
					list2[1] = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				switch (item2.GetString("type").ToUpperInvariant())
				{
				case "VIEW":
					list2.Add(true);
					break;
				case "TABLE":
					list2.Add(false);
					break;
				}
				T item = (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.NonPublic, null, list2.ToArray(), null);
				list.Add(item);
			}
		}
		return list;
	}

	public string GetObjectType(Schema s, string name)
	{
		return (GetRowResult("list_objects", new KeyValuePair<string, object>("schema", s.Name), new KeyValuePair<string, object>("pattern", name)).FetchOne() ?? throw new MySqlException(string.Format(ResourcesX.NoObjectFound, name))).GetString("type");
	}

	public RowResult GetRowResult(string cmd, params KeyValuePair<string, object>[] args)
	{
		protocol.SendExecuteStatement("mysqlx", cmd, args);
		return new RowResult(this);
	}

	public Result Insert(Collection collection, DbDoc[] json, List<string> newIds, bool upsert)
	{
		protocol.SendInsert(collection.Schema.Name, isRelational: false, collection.Name, json, null, upsert);
		return new Result(this);
	}

	public Result DeleteDocs(RemoveStatement rs)
	{
		protocol.SendDelete(rs.Target.Schema.Name, rs.Target.Name, isRelational: false, rs.FilterData);
		return new Result(this);
	}

	public Result DeleteRows(TableDeleteStatement statement)
	{
		protocol.SendDelete(statement.Target.Schema.Name, statement.Target.Name, isRelational: true, statement.FilterData);
		return new Result(this);
	}

	public Result ModifyDocs(ModifyStatement ms)
	{
		protocol.SendUpdate(ms.Target.Schema.Name, ms.Target.Name, isRelational: false, ms.FilterData, ms.Updates);
		return new Result(this);
	}

	public Result UpdateRows(TableUpdateStatement statement)
	{
		protocol.SendUpdate(statement.Target.Schema.Name, statement.Target.Name, isRelational: true, statement.FilterData, statement.updates);
		return new Result(this);
	}

	public DocResult FindDocs(FindStatement fs)
	{
		protocol.SendFind(fs.Target.Schema.Name, fs.Target.Name, isRelational: false, fs.FilterData, fs.findParams);
		return new DocResult(this);
	}

	public RowResult FindRows(TableSelectStatement ss)
	{
		protocol.SendFind(ss.Target.Schema.Name, ss.Target.Name, isRelational: true, ss.FilterData, ss.findParams);
		return new RowResult(this);
	}

	public Result InsertRows(TableInsertStatement statement)
	{
		XProtocol xProtocol = protocol;
		string name = statement.Target.Schema.Name;
		string name2 = statement.Target.Name;
		object[] rows = statement.values.ToArray();
		xProtocol.SendInsert(name, isRelational: true, name2, rows, statement.fields, upsert: false);
		return new Result(this);
	}

	protected Result ExpectOpen(Open.Types.Condition.Types.Key condition, object value = null)
	{
		protocol.SendExpectOpen(condition, value);
		return new Result(this);
	}

	public Result ExpectDocidGenerated()
	{
		return ExpectOpen(Mysqlx.Expect.Open.Types.Condition.Types.Key.ExpectDocidGenerated);
	}

	public void ResetSession()
	{
		if (!sessionResetNoReauthentication.HasValue)
		{
			try
			{
				ExpectOpen(Mysqlx.Expect.Open.Types.Condition.Types.Key.ExpectFieldExist, "6.1");
				sessionResetNoReauthentication = true;
			}
			catch
			{
				sessionResetNoReauthentication = false;
			}
		}
		protocol.SendResetSession(sessionResetNoReauthentication.Value);
		protocol.ReadOk();
	}

	public int PrepareStatement<TResult>(BaseStatement<TResult> statement) where TResult : BaseResult
	{
		int num = Interlocked.Increment(ref _stmtId);
		switch (statement.GetType().Name)
		{
		case "TableUpdateStatement":
		{
			TableUpdateStatement tableUpdateStatement = statement as TableUpdateStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.Update, tableUpdateStatement.Target.Schema.Name, tableUpdateStatement.Target.Name, isRelational: true, tableUpdateStatement.FilterData, null, tableUpdateStatement.updates);
			break;
		}
		case "RemoveStatement":
		{
			RemoveStatement removeStatement = statement as RemoveStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.Delete, removeStatement.Target.Schema.Name, removeStatement.Target.Name, isRelational: false, removeStatement.FilterData, null);
			break;
		}
		case "ModifyStatement":
		{
			ModifyStatement modifyStatement = statement as ModifyStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.Update, modifyStatement.Target.Schema.Name, modifyStatement.Target.Name, isRelational: false, modifyStatement.FilterData, null, modifyStatement.Updates);
			break;
		}
		case "SqlStatement":
		{
			SqlStatement sqlStatement = statement as SqlStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.SqlStatement, null, null, isRelational: true, null, null, null, sqlStatement.parameters.ToArray(), null, upsert: false, sqlStatement.SQL);
			break;
		}
		case "FindStatement":
		{
			FindStatement findStatement = statement as FindStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.Find, findStatement.Target.Schema.Name, findStatement.Target.Name, isRelational: false, findStatement.FilterData, findStatement.findParams);
			break;
		}
		case "TableInsertStatement":
		{
			TableInsertStatement tableInsertStatement = statement as TableInsertStatement;
			XProtocol xProtocol = protocol;
			string name = tableInsertStatement.Target.Schema.Name;
			string name2 = tableInsertStatement.Target.Name;
			object[] rows = tableInsertStatement.values.ToArray();
			xProtocol.SendPrepareStatement((uint)num, PreparedStatementType.Insert, name, name2, isRelational: true, null, null, null, rows, tableInsertStatement.fields);
			break;
		}
		case "TableSelectStatement":
		{
			TableSelectStatement tableSelectStatement = statement as TableSelectStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.Find, tableSelectStatement.Target.Schema.Name, tableSelectStatement.Target.Name, isRelational: true, tableSelectStatement.FilterData, tableSelectStatement.findParams);
			break;
		}
		case "TableDeleteStatement":
		{
			TableDeleteStatement tableDeleteStatement = statement as TableDeleteStatement;
			protocol.SendPrepareStatement((uint)num, PreparedStatementType.Delete, tableDeleteStatement.Target.Schema.Name, tableDeleteStatement.Target.Name, isRelational: true, tableDeleteStatement.FilterData, null);
			break;
		}
		default:
			throw new NotSupportedException(statement.GetType().Name);
		}
		_preparedStatements.Add(num);
		return num;
	}

	public TResult ExecutePreparedStatement<TResult>(int stmtId, IEnumerable args) where TResult : BaseResult
	{
		protocol.SendExecutePreparedStatement((uint)stmtId, args);
		BaseResult baseResult = null;
		if (typeof(TResult) == typeof(DocResult))
		{
			baseResult = new DocResult(this);
		}
		else if (typeof(TResult) == typeof(RowResult))
		{
			baseResult = new RowResult(this);
		}
		else if (typeof(TResult) == typeof(SqlResult))
		{
			baseResult = new SqlResult(this);
		}
		else
		{
			if (!(typeof(TResult) == typeof(Result)))
			{
				throw new ArgumentNullException(typeof(TResult).Name);
			}
			baseResult = new Result(this);
		}
		return (TResult)baseResult;
	}

	public void DeallocatePreparedStatement(int stmtId)
	{
		protocol.SendDeallocatePreparedStatement((uint)stmtId);
		_preparedStatements.Remove(stmtId);
	}

	public string GetCompressionAlgorithm(bool fromReaderController)
	{
		if (fromReaderController && _readerCompressionController != null)
		{
			return _readerCompressionController.CompressionAlgorithm;
		}
		if (!fromReaderController && _writerCompressionController != null)
		{
			return _writerCompressionController.CompressionAlgorithm;
		}
		return null;
	}
}
