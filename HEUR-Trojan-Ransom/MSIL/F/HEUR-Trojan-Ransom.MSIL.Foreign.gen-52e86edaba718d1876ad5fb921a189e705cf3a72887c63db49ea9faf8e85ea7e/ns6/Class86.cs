using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using MySqlX.Protocol.X;
using Mysqlx;
using Mysqlx.Connection;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Expect;
using Mysqlx.Expr;
using Mysqlx.Notice;
using Mysqlx.Resultset;
using Mysqlx.Session;
using Mysqlx.Sql;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns11;
using ns12;
using ns15;
using ns16;
using ns17;
using ns19;
using ns21;
using ns22;
using ns27;
using ns5;
using ns7;
using ns8;

namespace ns6;

internal sealed class Class86 : Class85
{
	[CompilerGenerated]
	private sealed class Class96
	{
		public Delete delete_0;

		internal void method_0(Limit limit_0)
		{
			delete_0.Limit = limit_0;
		}

		internal void method_1(Expr expr_0)
		{
			delete_0.Criteria = expr_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class97
	{
		public Update update_0;

		internal void method_0(Limit limit_0)
		{
			update_0.Limit = limit_0;
		}

		internal void method_1(Expr expr_0)
		{
			update_0.Criteria = expr_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class98
	{
		public Find find_0;

		internal void method_0(Limit limit_0)
		{
			find_0.Limit = limit_0;
		}

		internal void method_1(Expr expr_0)
		{
			find_0.Criteria = expr_0;
		}
	}

	private Class108 class108_0;

	private Class109 class109_0;

	private Class109 class109_1;

	[CompilerGenerated]
	private Capabilities capabilities_0;

	[NonSerialized]
	internal static GetString getString_1;

	public Capabilities Capabilities
	{
		[CompilerGenerated]
		get
		{
			return capabilities_0;
		}
		[CompilerGenerated]
		protected set
		{
			capabilities_0 = value;
		}
	}

	public Class86(Class109 class109_2, Class109 class109_3)
	{
		class109_0 = class109_2;
		class109_1 = class109_3;
	}

	public void method_0(string string_0, byte[] byte_0, byte[] byte_1)
	{
		AuthenticateStart authenticateStart = new AuthenticateStart();
		authenticateStart.MechName = string_0;
		if (byte_0 != null)
		{
			authenticateStart.AuthData = ByteString.CopyFrom(byte_0);
		}
		if (byte_1 != null)
		{
			authenticateStart.InitialResponse = ByteString.CopyFrom(byte_1);
		}
		class109_1.method_1(Enum30.const_3, authenticateStart);
	}

	public byte[] method_1()
	{
		Class108 @class = method_8();
		if (@class.int_0 != 3)
		{
			throw new MySqlException(getString_1(107406533));
		}
		AuthenticateContinue authenticateContinue = AuthenticateContinue.Parser.ParseFrom(@class.byte_0);
		if (!authenticateContinue.AuthData.IsEmpty)
		{
			return authenticateContinue.AuthData.ToByteArray();
		}
		return null;
	}

	public void method_2(byte[] byte_0)
	{
		AuthenticateContinue authenticateContinue = new AuthenticateContinue();
		authenticateContinue.AuthData = ByteString.CopyFrom(byte_0);
		class109_1.method_1(Enum30.const_4, authenticateContinue);
	}

	public void method_3()
	{
		Class108 @class = method_8();
		switch (@class.int_0)
		{
		default:
			throw new MySqlException(getString_1(107406533));
		case 11:
			method_3();
			break;
		case 1:
		{
			Error error = Error.Parser.ParseFrom(@class.byte_0);
			throw new MySqlException(error.Code, error.SqlState, error.Msg);
		}
		case 4:
			break;
		}
	}

	public void method_4()
	{
		class109_1.method_1(Enum30.const_0, new CapabilitiesGet());
		Class108 @class = method_8();
		if (@class.int_0 != 2)
		{
			method_6(@class.int_0, 2);
		}
		Capabilities = Capabilities.Parser.ParseFrom(@class.byte_0);
	}

	public void method_5(Dictionary<string, object> dictionary_0)
	{
		if (dictionary_0 == null || dictionary_0.Count == 0)
		{
			return;
		}
		CapabilitiesSet capabilitiesSet = new CapabilitiesSet();
		Capabilities capabilities = new Capabilities();
		foreach (KeyValuePair<string, object> item2 in dictionary_0)
		{
			Capability item = new Capability
			{
				Name = item2.Key,
				Value = Class103.smethod_19(item2.Value)
			};
			capabilities.Capabilities_.Add(item);
		}
		capabilitiesSet.Capabilities = capabilities;
		class109_1.method_1(Enum30.const_1, capabilitiesSet);
		method_30();
	}

	private void method_6(int int_0, int int_1)
	{
		throw new MySqlException(string.Format(getString_1(107406480), int_1, int_0));
	}

	public override void vmethod_1(string string_0, params object[] object_0)
	{
		method_17(string_0, object_0);
	}

	public override bool vmethod_2(Class48 class48_0)
	{
		while (true)
		{
			Class108 @class = method_7();
			switch (@class.int_0)
			{
			case 1:
				@class = method_8();
				method_20(@class);
				break;
			case 11:
				method_10(@class, class48_0);
				@class = method_8();
				break;
			case 12:
				return true;
			default:
				return false;
			}
		}
	}

	private Class108 method_7()
	{
		if (class108_0 != null)
		{
			return class108_0;
		}
		class108_0 = class109_0.method_2();
		return class108_0;
	}

	private Class108 method_8()
	{
		Class108 result = ((class108_0 != null) ? class108_0 : class109_0.method_2());
		class108_0 = null;
		return result;
	}

	private void method_9(Frame frame_0)
	{
	}

	private void method_10(Class108 class108_1, Class48 class48_0)
	{
		Frame frame = Frame.Parser.ParseFrom(class108_1.byte_0);
		if (frame.Scope == Frame.Class23.Enum5.const_1)
		{
			method_9(frame);
			return;
		}
		switch (frame.Type)
		{
		case 1u:
			method_12(class48_0, frame.Payload.ToByteArray());
			break;
		case 3u:
			method_11(class48_0, frame.Payload.ToByteArray());
			break;
		case 2u:
			break;
		}
	}

	private void method_11(Class48 class48_0, byte[] byte_0)
	{
		SessionStateChanged sessionStateChanged = SessionStateChanged.Parser.ParseFrom(byte_0);
		switch (sessionStateChanged.Param)
		{
		case SessionStateChanged.Class25.Enum8.const_4:
			class48_0.ulong_0 = sessionStateChanged.Value[0].VUnsignedInt;
			break;
		case SessionStateChanged.Class25.Enum8.const_3:
			class48_0.ulong_1 = sessionStateChanged.Value[0].VUnsignedInt;
			break;
		case SessionStateChanged.Class25.Enum8.const_11:
		{
			foreach (Scalar item in sessionStateChanged.Value)
			{
				class48_0.list_1.Add(item.VOctets.Value.ToStringUtf8());
			}
			break;
		}
		case SessionStateChanged.Class25.Enum8.const_9:
			class48_0.method_0(new Class78(0u, sessionStateChanged.Value[0].VString.Value.ToStringUtf8()));
			break;
		}
	}

	private void method_12(Class48 class48_0, byte[] byte_0)
	{
		Warning warning = Warning.Parser.ParseFrom(byte_0);
		Class78 @class = new Class78(warning.Code, warning.Msg);
		if (warning.Level != 0)
		{
			@class.uint_1 = (uint)warning.Level;
		}
		class48_0.method_0(@class);
	}

	private Any method_13(object object_0)
	{
		if (object_0 is string)
		{
			return Class103.smethod_15((string)object_0);
		}
		if (object_0 is bool)
		{
			return Class103.smethod_18((bool)object_0);
		}
		return Class103.smethod_19(object_0);
	}

	private Mysqlx.Datatypes.Object.Types.ObjectField method_14(string string_0, object object_0, bool bool_0 = true)
	{
		return Class103.smethod_16(string_0, object_0, bool_0);
	}

	public void method_15()
	{
		class109_1.method_1(Enum30.const_6, new Mysqlx.Session.Close());
	}

	public void method_16()
	{
		Mysqlx.Connection.Close imessage_ = new Mysqlx.Connection.Close();
		class109_1.method_1(Enum30.const_2, imessage_);
	}

	public void method_17(string string_0, params object[] object_0)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = getString_1(107406411);
		stmtExecute.Stmt = ByteString.CopyFromUtf8(string_0);
		stmtExecute.CompactMetadata = false;
		if (object_0 != null)
		{
			foreach (object object_ in object_0)
			{
				stmtExecute.Args.Add(method_13(object_));
			}
		}
		class109_1.method_1(Enum30.const_7, stmtExecute);
	}

	public void method_18(string string_0, string string_1, params KeyValuePair<string, object>[] keyValuePair_0)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = string_0;
		stmtExecute.Stmt = ByteString.CopyFromUtf8(string_1);
		stmtExecute.CompactMetadata = false;
		if (keyValuePair_0 != null)
		{
			Any any = Class103.smethod_17(Any.Class31.Enum14.const_2);
			for (int i = 0; i < keyValuePair_0.Length; i++)
			{
				KeyValuePair<string, object> keyValuePair = keyValuePair_0[i];
				if (string_1 == getString_1(107406374))
				{
					any.Obj.Fld.Add(method_14(keyValuePair.Key, keyValuePair.Value, bool_0: false));
				}
				else
				{
					any.Obj.Fld.Add(method_14(keyValuePair.Key, keyValuePair.Value));
				}
			}
			stmtExecute.Args.Add(any);
		}
		class109_1.method_1(Enum30.const_7, stmtExecute);
	}

	public void method_19(string string_0, string string_1, params KeyValuePair<string, object>[] keyValuePair_0)
	{
		StmtExecute stmtExecute = new StmtExecute();
		stmtExecute.Namespace = string_0;
		stmtExecute.Stmt = ByteString.CopyFromUtf8(string_1);
		stmtExecute.CompactMetadata = false;
		if (keyValuePair_0 != null)
		{
			Any any = Class103.smethod_17(Any.Class31.Enum14.const_2);
			Mysqlx.Datatypes.Array array = new Mysqlx.Datatypes.Array();
			for (int i = 0; i < keyValuePair_0.Length; i++)
			{
				KeyValuePair<string, object> keyValuePair = keyValuePair_0[i];
				if (keyValuePair.Value is Dictionary<string, object> && keyValuePair.Key == getString_1(107406955))
				{
					Any any2 = Class103.smethod_17(Any.Class31.Enum14.const_2);
					foreach (KeyValuePair<string, object> item in keyValuePair.Value as Dictionary<string, object>)
					{
						any2.Obj.Fld.Add(method_14(item.Key, item.Value, (item.Key == getString_1(107406945)) ? true : false));
					}
					array.Value.Add(any2);
				}
				else
				{
					any.Obj.Fld.Add(method_14(keyValuePair.Key, keyValuePair.Value, bool_0: false));
				}
			}
			if (array.Value.Count > 0)
			{
				Mysqlx.Datatypes.Object.Types.ObjectField objectField = new Mysqlx.Datatypes.Object.Types.ObjectField();
				objectField.Key = getString_1(107406955);
				Any any3 = Class103.smethod_17(Any.Class31.Enum14.const_3);
				any3.Array = array;
				objectField.Value = any3;
				any.Obj.Fld.Add(objectField);
			}
			stmtExecute.Args.Add(any);
		}
		class109_1.method_1(Enum30.const_7, stmtExecute);
	}

	private void method_20(Class108 class108_1)
	{
		Error error = Error.Parser.ParseFrom(class108_1.byte_0);
		throw new MySqlException(error.Code, error.SqlState, error.Msg);
	}

	public override List<byte[]> vmethod_0(Class48 class48_0)
	{
		if (method_7().int_0 != 13)
		{
			if (class48_0 != null)
			{
				vmethod_4(class48_0);
			}
			return null;
		}
		Row row = Row.Parser.ParseFrom(method_8().byte_0);
		List<byte[]> list = new List<byte[]>(row.Field.Count);
		for (int i = 0; i < row.Field.Count; i++)
		{
			list.Add(row.Field[i].ToByteArray());
		}
		return list;
	}

	public override void vmethod_4(Class48 class48_0)
	{
		class48_0.bool_0 = false;
		Class108 @class;
		while (true)
		{
			@class = method_7();
			if (@class.int_0 != 16)
			{
				if (@class.int_0 != 0)
				{
					if (@class.int_0 == 14)
					{
						method_8();
						continue;
					}
					if (@class.int_0 == 11)
					{
						method_10(method_8(), class48_0);
						continue;
					}
					if (@class.int_0 != 1)
					{
						break;
					}
					method_20(method_8());
					continue;
				}
				method_30();
				return;
			}
			class48_0.bool_1 = true;
			method_8();
			return;
		}
		if (@class.int_0 != 17)
		{
			throw new MySqlException(Class122.ThrowingAwayResults);
		}
		method_8();
	}

	public override List<Class47> vmethod_3()
	{
		List<Class47> list = new List<Class47>();
		while (method_7().int_0 == 12)
		{
			Class108 @class = method_8();
			ColumnMetaData columnMetaData_ = ColumnMetaData.Parser.ParseFrom(@class.byte_0);
			list.Add(method_21(columnMetaData_));
		}
		return list;
	}

	private Class47 method_21(ColumnMetaData columnMetaData_0)
	{
		Class47 @class = new Class47();
		@class.class87_0 = Class104.smethod_0(@class, columnMetaData_0.Type);
		@class.class87_0.Column = @class;
		if (!columnMetaData_0.Name.IsEmpty)
		{
			@class.ColumnLabel = columnMetaData_0.Name.ToStringUtf8();
		}
		if (!columnMetaData_0.OriginalName.IsEmpty)
		{
			@class.ColumnName = columnMetaData_0.OriginalName.ToStringUtf8();
		}
		if (!columnMetaData_0.Table.IsEmpty)
		{
			@class.TableLabel = columnMetaData_0.Table.ToStringUtf8();
		}
		if (!columnMetaData_0.OriginalTable.IsEmpty)
		{
			@class.TableName = columnMetaData_0.OriginalTable.ToStringUtf8();
		}
		if (!columnMetaData_0.Schema.IsEmpty)
		{
			@class.SchemaName = columnMetaData_0.Schema.ToStringUtf8();
		}
		if (!columnMetaData_0.Catalog.IsEmpty)
		{
			@class.DatabaseName = columnMetaData_0.Catalog.ToStringUtf8();
		}
		if (columnMetaData_0.Collation > 0L)
		{
			@class.ulong_0 = columnMetaData_0.Collation;
			@class.CollationName = Class107.smethod_0((int)columnMetaData_0.Collation);
			@class.CharacterSetName = @class.CollationName.Split(new char[1] { '_' })[0];
		}
		if (columnMetaData_0.Length != 0)
		{
			@class.Length = columnMetaData_0.Length;
		}
		if (columnMetaData_0.FractionalDigits != 0)
		{
			@class.FractionalDigits = columnMetaData_0.FractionalDigits;
		}
		if (columnMetaData_0.Flags != 0)
		{
			@class.class87_0.Flags = columnMetaData_0.Flags;
		}
		if (columnMetaData_0.ContentType != 0)
		{
			@class.class87_0.ContentType = columnMetaData_0.ContentType;
		}
		@class.class87_0.vmethod_0();
		return @class;
	}

	public void method_22(string string_0, bool bool_0, string string_1, object[] object_0, string[] string_2, bool bool_1)
	{
		Insert insert = new Insert();
		insert.Collection = Class103.smethod_21(string_0, string_1);
		insert.DataModel = ((!bool_0) ? Enum15.const_1 : Enum15.const_2);
		insert.Upsert = bool_1;
		if (string_2 != null && string_2.Length != 0)
		{
			foreach (string s in string_2)
			{
				insert.Projection.Add(new ExprParser(s).method_35());
			}
		}
		foreach (object obj in object_0)
		{
			Insert.Types.TypedRow typedRow = new Insert.Types.TypedRow();
			object[] array = (obj.GetType().IsArray ? ((object[])obj) : new object[1] { obj });
			foreach (object object_ in array)
			{
				typedRow.Field.Add(Class103.smethod_23(object_, bool_0));
			}
			insert.Row.Add(typedRow);
		}
		class109_1.method_1(Enum30.const_9, insert);
	}

	private void method_23(Action<Limit> action_0, Action<Expr> action_1, Action<IEnumerable<Order>> action_2, Class73 class73_0, Action<IEnumerable<Scalar>> action_3)
	{
		if (class73_0.HasLimit)
		{
			Limit limit = new Limit();
			limit.RowCount = (ulong)class73_0.long_0;
			if (class73_0.long_1 != -1L)
			{
				limit.Offset = (ulong)class73_0.long_1;
			}
			action_0(limit);
		}
		if (!string.IsNullOrEmpty(class73_0.string_0))
		{
			action_1(class73_0.method_1(class73_0.bool_0));
			if (class73_0.dictionary_0 != null && class73_0.dictionary_0.Count > 0)
			{
				action_3(class73_0.method_2(class73_0.dictionary_0));
			}
		}
		if (class73_0.string_1 != null && class73_0.string_1.Length != 0)
		{
			action_2(class73_0.method_0(class73_0.bool_0));
		}
	}

	public void method_24(string string_0, string string_1, bool bool_0, Class73 class73_0)
	{
		Delete delete_0 = new Delete();
		delete_0.DataModel = ((!bool_0) ? Enum15.const_1 : Enum15.const_2);
		delete_0.Collection = Class103.smethod_21(string_0, string_1);
		method_23(delegate(Limit limit_0)
		{
			delete_0.Limit = limit_0;
		}, delegate(Expr expr_0)
		{
			delete_0.Criteria = expr_0;
		}, delete_0.Order.Add, class73_0, delete_0.Args.Add);
		class109_1.method_1(Enum30.const_11, delete_0);
	}

	public void method_25(string string_0, string string_1, bool bool_0, Class73 class73_0, List<Class75> list_0)
	{
		Update update_0 = new Update();
		update_0.DataModel = ((!bool_0) ? Enum15.const_1 : Enum15.const_2);
		update_0.Collection = Class103.smethod_21(string_0, string_1);
		method_23(delegate(Limit limit_0)
		{
			update_0.Limit = limit_0;
		}, delegate(Expr expr_0)
		{
			update_0.Criteria = expr_0;
		}, update_0.Order.Add, class73_0, update_0.Args.Add);
		foreach (Class75 item in list_0)
		{
			UpdateOperation updateOperation = new UpdateOperation();
			updateOperation.Operation = item.Type;
			updateOperation.Source = item.method_1(bool_0);
			if (item.HasValue)
			{
				updateOperation.Value = item.method_0();
			}
			update_0.Operation.Add(updateOperation);
		}
		class109_1.method_1(Enum30.const_10, update_0);
	}

	internal Find method_26(string string_0, string string_1, bool bool_0, Class73 class73_0, Class74 class74_0)
	{
		Find find_0 = new Find();
		find_0.Collection = Class103.smethod_21(string_0, string_1);
		find_0.DataModel = ((!bool_0) ? Enum15.const_1 : Enum15.const_2);
		if (class74_0.enum25_0 != 0)
		{
			find_0.Locking = (Find.Class35.Enum21)class74_0.enum25_0;
		}
		if (class74_0.enum45_0 != 0)
		{
			find_0.LockingOptions = (Find.Class35.Enum22)class74_0.enum45_0;
		}
		if (class74_0.string_4 != null && class74_0.string_4.Length != 0)
		{
			find_0.Projection.Add(new ExprParser(Class103.smethod_24(class74_0.string_4)).method_34());
		}
		method_23(delegate(Limit limit_0)
		{
			find_0.Limit = limit_0;
		}, delegate(Expr expr_0)
		{
			find_0.Criteria = expr_0;
		}, find_0.Order.Add, class73_0, find_0.Args.Add);
		return find_0;
	}

	public void method_27(string string_0, string string_1, bool bool_0, Class73 class73_0, Class74 class74_0)
	{
		Find imessage_ = method_26(string_0, string_1, bool_0, class73_0, class74_0);
		class109_1.method_1(Enum30.const_8, imessage_);
	}

	public void method_28(Open.Types.Condition.Class29.Enum11 enum11_0)
	{
		Open open = new Open();
		Open.Types.Condition condition = new Open.Types.Condition();
		condition.ConditionKey = (uint)enum11_0;
		open.Cond.Add(condition);
		class109_1.method_1(Enum30.const_12, open);
	}

	internal void method_29()
	{
		try
		{
			if (method_30().IndexOf(getString_1(107406345), 0, StringComparison.OrdinalIgnoreCase) < 0)
			{
				throw new ArgumentException();
			}
		}
		catch (IOException)
		{
		}
		catch (Exception ex2)
		{
			throw new MySqlException(getString_1(107406340), ex2);
		}
	}

	internal string method_30()
	{
		Class108 @class = method_8();
		if (@class.int_0 == 1)
		{
			throw new MySqlException(Error.Parser.ParseFrom(@class.byte_0).Msg);
		}
		if (@class.int_0 != 0)
		{
			throw new InvalidOperationException();
		}
		return Ok.Parser.ParseFrom(@class.byte_0).Msg;
	}

	internal void method_31(Class109 class109_2, Class109 class109_3)
	{
		class109_0 = class109_2;
		class109_1 = class109_3;
	}

	static Class86()
	{
		Strings.CreateGetStringDelegate(typeof(Class86));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107397808), getString_1(107397803)).Replace(getString_1(107397766), getString_1(107397761)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397756)))
		{
			throw new SecurityException(getString_1(107397731));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
