using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns15;
using ns16;
using ns19;
using ns2;
using ns20;
using ns21;
using ns23;
using ns4;
using ns7;
using ns8;

namespace ns6;

[DefaultMember("Item")]
internal sealed class Class142 : DbDataReader, IDisposable, IDataReader, IDataRecord
{
	private bool bool_0 = true;

	internal long long_0;

	internal Class143 class143_0;

	private readonly bool bool_1;

	private Class139 class139_0;

	[CompilerGenerated]
	private readonly Class172 class172_0;

	[CompilerGenerated]
	private MySqlCommand mySqlCommand_0;

	[CompilerGenerated]
	private Class175 class175_0;

	[CompilerGenerated]
	private CommandBehavior commandBehavior_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal Class172 Statement
	{
		[CompilerGenerated]
		get
		{
			return class172_0;
		}
	}

	internal MySqlCommand Command
	{
		[CompilerGenerated]
		get
		{
			return mySqlCommand_0;
		}
		[CompilerGenerated]
		private set
		{
			mySqlCommand_0 = value;
		}
	}

	internal Class175 ResultSet
	{
		[CompilerGenerated]
		get
		{
			return class175_0;
		}
		[CompilerGenerated]
		private set
		{
			class175_0 = value;
		}
	}

	internal CommandBehavior CommandBehavior
	{
		[CompilerGenerated]
		get
		{
			return commandBehavior_0;
		}
		[CompilerGenerated]
		private set
		{
			commandBehavior_0 = value;
		}
	}

	int DbDataReader.FieldCount => ResultSet?.Size ?? 0;

	bool DbDataReader.HasRows => ResultSet?.HasRows ?? false;

	bool DbDataReader.IsClosed => !bool_0;

	int DbDataReader.RecordsAffected
	{
		get
		{
			if (!bool_1)
			{
				return (int)long_0;
			}
			if (long_0 == 0L)
			{
				return -1;
			}
			return (int)long_0;
		}
	}

	object DbDataReader.this[int ordinal] => GetValue(ordinal);

	object DbDataReader.this[string name] => this[GetOrdinal(name)];

	int DbDataReader.Depth => 0;

	internal Class142(MySqlCommand mySqlCommand_1, Class172 class172_1, CommandBehavior commandBehavior_1)
	{
		Command = mySqlCommand_1;
		class139_0 = Command.Connection;
		CommandBehavior = commandBehavior_1;
		class143_0 = class139_0.class143_0;
		long_0 = -1L;
		class172_0 = class172_1;
		if (mySqlCommand_1.CommandType == CommandType.StoredProcedure && mySqlCommand_1.UpdatedRowSource == UpdateRowSource.FirstReturnedRecord)
		{
			bool_1 = true;
		}
	}

	void DbDataReader.Close()
	{
		if (!bool_0)
		{
			return;
		}
		bool flag = (CommandBehavior & CommandBehavior.CloseConnection) != 0;
		CommandBehavior commandBehavior = CommandBehavior;
		try
		{
			if (!commandBehavior.Equals(CommandBehavior.SchemaOnly))
			{
				CommandBehavior = CommandBehavior.Default;
			}
			while (NextResult())
			{
			}
		}
		catch (MySqlException ex)
		{
			if (!ex.IsQueryAborted)
			{
				bool flag2 = false;
				Exception ex2 = ex;
				while (ex2 != null)
				{
					if (!(ex2 is IOException))
					{
						ex2 = ex2.InnerException;
						continue;
					}
					flag2 = true;
					break;
				}
				if (!flag2)
				{
					throw;
				}
			}
		}
		catch (IOException)
		{
		}
		finally
		{
			class139_0.Reader = null;
			CommandBehavior = commandBehavior;
		}
		Command.method_3(this);
		CommandBehavior = CommandBehavior.Default;
		if (Command.Canceled && class139_0.class143_0.Version.method_0(5, 1, 0))
		{
			method_31();
		}
		if (flag)
		{
			class139_0.Close();
		}
		Command = null;
		class139_0.IsInUse = false;
		class139_0 = null;
		bool_0 = false;
	}

	public bool method_0(string string_0)
	{
		return GetBoolean(GetOrdinal(string_0));
	}

	bool DbDataReader.GetBoolean(int ordinal)
	{
		object value = GetValue(ordinal);
		if (int.TryParse(value as string, out var result))
		{
			return Convert.ToBoolean(result);
		}
		return Convert.ToBoolean(value);
	}

	public byte method_1(string string_0)
	{
		return GetByte(GetOrdinal(string_0));
	}

	byte DbDataReader.GetByte(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: false);
		if (@interface is Struct19 @struct)
		{
			return @struct.Value;
		}
		return (byte)((Struct8)(object)@interface).Value;
	}

	public sbyte method_2(string string_0)
	{
		return method_3(GetOrdinal(string_0));
	}

	public sbyte method_3(int int_0)
	{
		Interface0 @interface = method_30(int_0, bool_2: false);
		return ((Struct8)(object)@interface).Value;
	}

	long DbDataReader.GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (ordinal >= FieldCount)
		{
			method_34(new IndexOutOfRangeException());
		}
		Interface0 @interface = method_30(ordinal, bool_2: false);
		if (!(@interface is Struct6) && !(@interface is Struct12))
		{
			method_34(new MySqlException(getString_0(107353601)));
		}
		byte[] array = null;
		array = ((!(@interface is Struct6 @struct)) ? ((Struct12)(object)@interface).Bytes : @struct.Value);
		if (buffer == null)
		{
			return array.Length;
		}
		if (bufferOffset >= buffer.Length || bufferOffset < 0)
		{
			method_34(new IndexOutOfRangeException(getString_0(107354040)));
		}
		if (buffer.Length < bufferOffset + length)
		{
			method_34(new ArgumentException(getString_0(107353979)));
		}
		if (dataOffset < 0L || ((ulong)dataOffset >= (ulong)array.Length && (ulong)array.Length > 0uL))
		{
			method_34(new IndexOutOfRangeException(getString_0(107353938)));
		}
		if ((ulong)array.Length < (ulong)(dataOffset + length))
		{
			length = (int)(array.Length - dataOffset);
		}
		Buffer.BlockCopy(array, (int)dataOffset, buffer, bufferOffset, length);
		return length;
	}

	private object method_4(Interface0 interface0_0, int int_0, Type type_0)
	{
		ResultSet.Fields[int_0].method_1(type_0);
		return Convert.ChangeType(interface0_0.Value, type_0, CultureInfo.InvariantCulture);
	}

	public char method_5(string string_0)
	{
		return GetChar(GetOrdinal(string_0));
	}

	char DbDataReader.GetChar(int ordinal)
	{
		return GetString(ordinal)[0];
	}

	long DbDataReader.GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
	{
		if (ordinal >= FieldCount)
		{
			method_34(new IndexOutOfRangeException());
		}
		string @string = GetString(ordinal);
		if (buffer == null)
		{
			return @string.Length;
		}
		if (bufferOffset >= buffer.Length || bufferOffset < 0)
		{
			method_34(new IndexOutOfRangeException(getString_0(107354040)));
		}
		if (buffer.Length < bufferOffset + length)
		{
			method_34(new ArgumentException(getString_0(107353979)));
		}
		if (dataOffset < 0L || dataOffset >= @string.Length)
		{
			method_34(new IndexOutOfRangeException(getString_0(107353845)));
		}
		if (@string.Length < length)
		{
			length = @string.Length;
		}
		@string.CopyTo((int)dataOffset, buffer, bufferOffset, length);
		return length;
	}

	string DbDataReader.GetDataTypeName(int ordinal)
	{
		if (!bool_0)
		{
			method_34(new Exception(getString_0(107353268)));
		}
		if (ordinal >= FieldCount)
		{
			method_34(new IndexOutOfRangeException());
		}
		return ResultSet.Values[ordinal].MySqlTypeName;
	}

	public MySqlDateTime method_6(string string_0)
	{
		return method_7(GetOrdinal(string_0));
	}

	public MySqlDateTime method_7(int int_0)
	{
		return (MySqlDateTime)(object)method_30(int_0, bool_2: true);
	}

	public DateTime method_8(string string_0)
	{
		return GetDateTime(GetOrdinal(string_0));
	}

	DateTime DbDataReader.GetDateTime(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		MySqlDateTime mySqlDateTime = ((!(@interface is MySqlDateTime)) ? MySqlDateTime.smethod_0(GetString(ordinal)) : ((MySqlDateTime)(object)@interface));
		mySqlDateTime.TimezoneOffset = class143_0.int_0;
		if (class139_0.Settings.ConvertZeroDateTime && !mySqlDateTime.IsValidDateTime)
		{
			return DateTime.MinValue;
		}
		return mySqlDateTime.method_2();
	}

	public Struct9 method_9(string string_0)
	{
		return method_10(GetOrdinal(string_0));
	}

	public Struct9 method_10(int int_0)
	{
		return (Struct9)(object)method_30(int_0, bool_2: false);
	}

	public decimal method_11(string string_0)
	{
		return GetDecimal(GetOrdinal(string_0));
	}

	decimal DbDataReader.GetDecimal(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct9 @struct)
		{
			return @struct.Value;
		}
		return Convert.ToDecimal(@interface.Value);
	}

	public double method_12(string string_0)
	{
		return GetDouble(GetOrdinal(string_0));
	}

	double DbDataReader.GetDouble(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct10 @struct)
		{
			return @struct.Value;
		}
		return Convert.ToDouble(@interface.Value);
	}

	public Type method_13(string string_0)
	{
		return GetFieldType(GetOrdinal(string_0));
	}

	Type DbDataReader.GetFieldType(int ordinal)
	{
		if (!bool_0)
		{
			method_34(new Exception(getString_0(107353268)));
		}
		if (ordinal >= FieldCount)
		{
			method_34(new IndexOutOfRangeException());
		}
		Interface0 @interface = ResultSet.Values[ordinal];
		if (@interface is MySqlDateTime)
		{
			if (!class139_0.Settings.AllowZeroDateTime)
			{
				return typeof(DateTime);
			}
			return typeof(MySqlDateTime);
		}
		return @interface.SystemType;
	}

	public float method_14(string string_0)
	{
		return GetFloat(GetOrdinal(string_0));
	}

	float DbDataReader.GetFloat(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct16 @struct)
		{
			return @struct.Value;
		}
		return Convert.ToSingle(@interface.Value);
	}

	public Guid method_15(string string_0)
	{
		return GetGuid(GetOrdinal(string_0));
	}

	Guid DbDataReader.GetGuid(int ordinal)
	{
		object value = GetValue(ordinal);
		if (value is Guid)
		{
			return (Guid)value;
		}
		if (value is string)
		{
			return new Guid(value as string);
		}
		if (value is byte[])
		{
			byte[] array = (byte[])value;
			if (array.Length == 16)
			{
				return new Guid(array);
			}
		}
		method_34(new MySqlException(Class121.ValueNotSupportedForGuid));
		return Guid.Empty;
	}

	public short method_16(string string_0)
	{
		return GetInt16(GetOrdinal(string_0));
	}

	short DbDataReader.GetInt16(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct13 @struct)
		{
			return @struct.Value;
		}
		return (short)method_4(@interface, ordinal, typeof(short));
	}

	public int method_17(string string_0)
	{
		return GetInt32(GetOrdinal(string_0));
	}

	int DbDataReader.GetInt32(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct14 @struct)
		{
			return @struct.Value;
		}
		return (int)method_4(@interface, ordinal, typeof(int));
	}

	public long method_18(string string_0)
	{
		return GetInt64(GetOrdinal(string_0));
	}

	long DbDataReader.GetInt64(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct15 @struct)
		{
			return @struct.Value;
		}
		return (long)method_4(@interface, ordinal, typeof(long));
	}

	string DbDataReader.GetName(int ordinal)
	{
		if (!bool_0)
		{
			method_34(new Exception(getString_0(107353268)));
		}
		if (ordinal >= FieldCount)
		{
			method_34(new IndexOutOfRangeException());
		}
		return ResultSet.Fields[ordinal].string_1;
	}

	int DbDataReader.GetOrdinal(string name)
	{
		if (!bool_0 || ResultSet == null)
		{
			method_34(new Exception(getString_0(107353268)));
		}
		return ResultSet.method_0(name);
	}

	public string method_19(string string_0)
	{
		return GetString(GetOrdinal(string_0));
	}

	string DbDataReader.GetString(int ordinal)
	{
		Interface0 @interface = method_30(ordinal, bool_2: true);
		if (@interface is Struct6 @struct)
		{
			byte[] value = @struct.Value;
			return ResultSet.Fields[ordinal].encoding_0.GetString(value, 0, value.Length);
		}
		return @interface.Value.ToString();
	}

	public TimeSpan method_20(string string_0)
	{
		return method_21(GetOrdinal(string_0));
	}

	public TimeSpan method_21(int int_0)
	{
		return ((Struct18)(object)method_30(int_0, bool_2: true)).Value;
	}

	object DbDataReader.GetValue(int ordinal)
	{
		if (!bool_0)
		{
			method_34(new Exception(getString_0(107353268)));
		}
		if (ordinal >= FieldCount)
		{
			method_34(new IndexOutOfRangeException());
		}
		Interface0 @interface = method_30(ordinal, bool_2: false);
		if (@interface.IsNull)
		{
			return DBNull.Value;
		}
		if (@interface is MySqlDateTime mySqlDateTime)
		{
			if (!mySqlDateTime.IsValidDateTime && class139_0.Settings.ConvertZeroDateTime)
			{
				return DateTime.MinValue;
			}
			if (class139_0.Settings.AllowZeroDateTime)
			{
				return @interface;
			}
			return mySqlDateTime.method_2();
		}
		return @interface.Value;
	}

	int DbDataReader.GetValues(object[] values)
	{
		int num = Math.Min(values.Length, FieldCount);
		for (int i = 0; i < num; i++)
		{
			values[i] = GetValue(i);
		}
		return num;
	}

	public ushort method_22(string string_0)
	{
		return method_23(GetOrdinal(string_0));
	}

	public ushort method_23(int int_0)
	{
		Interface0 @interface = method_30(int_0, bool_2: true);
		if (@interface is Struct20 @struct)
		{
			return @struct.Value;
		}
		return (ushort)method_4(@interface, int_0, typeof(ushort));
	}

	public uint method_24(string string_0)
	{
		return method_25(GetOrdinal(string_0));
	}

	public uint method_25(int int_0)
	{
		Interface0 @interface = method_30(int_0, bool_2: true);
		if (@interface is Struct21 @struct)
		{
			return @struct.Value;
		}
		return (uint)method_4(@interface, int_0, typeof(uint));
	}

	public ulong method_26(string string_0)
	{
		return method_27(GetOrdinal(string_0));
	}

	public ulong method_27(int int_0)
	{
		Interface0 @interface = method_30(int_0, bool_2: true);
		if (@interface is Struct22 @struct)
		{
			return @struct.Value;
		}
		return (ulong)method_4(@interface, int_0, typeof(ulong));
	}

	IDataReader IDataRecord.GetData(int i)
	{
		return GetData(i);
	}

	bool DbDataReader.IsDBNull(int ordinal)
	{
		return DBNull.Value == GetValue(ordinal);
	}

	bool DbDataReader.NextResult()
	{
		if (!bool_0)
		{
			method_34(new MySqlException(Class121.NextResultIsClosed));
		}
		bool flag = Command.CommandType == CommandType.TableDirect && Command.EnableCaching && (CommandBehavior & CommandBehavior.SequentialAccess) == 0;
		if (ResultSet != null)
		{
			ResultSet.method_4();
			if (flag)
			{
				Class179.smethod_0(Command.CommandText, ResultSet);
			}
		}
		if (ResultSet != null && ((CommandBehavior & CommandBehavior.SingleResult) != 0 || flag))
		{
			return false;
		}
		try
		{
			do
			{
				ResultSet = null;
				if (flag)
				{
					ResultSet = Class179.smethod_1(Command.CommandText, Command.CacheAge);
				}
				if (ResultSet == null)
				{
					ResultSet = class143_0.vmethod_5(Statement.StatementId, bool_5: false);
					if (ResultSet == null)
					{
						return false;
					}
					if (ResultSet.IsOutputParameters && Command.CommandType == CommandType.StoredProcedure)
					{
						StoredProcedure obj = Statement as StoredProcedure;
						obj.method_12(this);
						ResultSet.method_4();
						if (!obj.ServerProvidingOutputParameters)
						{
							return false;
						}
						ResultSet = class143_0.vmethod_5(Statement.StatementId, bool_5: true);
					}
					ResultSet.Cached = flag;
				}
				if (ResultSet.Size == 0)
				{
					Command.LastInsertedId = ResultSet.InsertedId;
					if (long_0 == -1L)
					{
						long_0 = ResultSet.AffectedRows;
					}
					else
					{
						long_0 += ResultSet.AffectedRows;
					}
				}
			}
			while (ResultSet.Size == 0);
			return true;
		}
		catch (MySqlException ex)
		{
			if (ex.IsFatal)
			{
				class139_0.method_6();
			}
			if (ex.Number == 0)
			{
				throw new MySqlException(Class121.FatalErrorReadingResult, ex);
			}
			if ((CommandBehavior & CommandBehavior.CloseConnection) != 0)
			{
				Close();
			}
			throw;
		}
	}

	bool DbDataReader.Read()
	{
		if (!bool_0)
		{
			method_34(new MySqlException(getString_0(107353255)));
		}
		if (ResultSet == null)
		{
			return false;
		}
		try
		{
			return ResultSet.method_2(CommandBehavior);
		}
		catch (TimeoutException exception_)
		{
			class139_0.method_9(exception_);
			throw;
		}
		catch (ThreadAbortException exception_2)
		{
			class139_0.method_9(exception_2);
			throw;
		}
		catch (MySqlException ex)
		{
			if (ex.IsFatal)
			{
				class139_0.method_6();
			}
			if (ex.IsQueryAborted)
			{
				throw;
			}
			throw new MySqlException(Class121.FatalErrorDuringRead, ex);
		}
	}

	public Struct11 method_28(int int_0)
	{
		try
		{
			Interface0 @interface = method_30(int_0, bool_2: false);
			if (@interface is Struct11 || @interface is Struct6)
			{
				return new Struct11(MySqlDbType.Geometry, (byte[])@interface.Value);
			}
		}
		catch
		{
			method_34(new Exception(getString_0(107353190)));
		}
		return new Struct11(bool_1: true);
	}

	public Struct11 method_29(string string_0)
	{
		return method_28(GetOrdinal(string_0));
	}

	IEnumerator DbDataReader.GetEnumerator()
	{
		return new DbEnumerator((IDataReader)this, (CommandBehavior & CommandBehavior.CloseConnection) != 0);
	}

	private Interface0 method_30(int int_0, bool bool_2)
	{
		if (int_0 < 0 || int_0 >= FieldCount)
		{
			method_34(new ArgumentException(Class121.InvalidColumnOrdinal));
		}
		Interface0 @interface = ResultSet[int_0];
		if (bool_2 && @interface.IsNull)
		{
			throw new SqlNullValueException();
		}
		return @interface;
	}

	private void method_31()
	{
		MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107353109), class139_0)
		{
			InternallyCreated = true
		};
		try
		{
			mySqlCommand.method_6();
		}
		catch (MySqlException ex)
		{
			if (ex.Number != 1146)
			{
				throw;
			}
		}
	}

	private void method_32()
	{
		if (!class143_0.SupportsOutputParameters || !Command.IsPrepared)
		{
			method_33();
		}
		if ((CommandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return;
		}
		ResultSet.method_2(CommandBehavior);
		string text = getString_0(107353096);
		for (int i = 0; i < FieldCount; i++)
		{
			string text2 = GetName(i);
			if (text2.StartsWith(text))
			{
				text2 = text2.Remove(0, text.Length);
			}
			Command.Parameters.method_15(text2, bool_1: true).Value = GetValue(i);
		}
	}

	private void method_33()
	{
		for (int i = 0; i < FieldCount; i++)
		{
			string name = GetName(i);
			name = name.Remove(0, getString_0(107353587).Length + 1);
			Interface0 @interface = Class145.smethod_0(Command.Parameters.method_15(name, bool_1: true).MySqlDbType);
			if (@interface is Struct7 @struct)
			{
				@struct.ReadAsString = true;
				ResultSet.method_8(i, @struct);
			}
			else
			{
				ResultSet.method_8(i, @interface);
			}
		}
	}

	T DbDataReader.GetFieldValue<T>(int ordinal)
	{
		if (typeof(T).Equals(typeof(DateTimeOffset)))
		{
			DateTime result = default(DateTime);
			return (T)Convert.ChangeType(new DateTimeOffset(DateTime.TryParse(GetValue(ordinal).ToString(), out result) ? result : DateTime.MinValue), typeof(T));
		}
		return base.GetFieldValue<T>(ordinal);
	}

	private void method_34(Exception exception_0)
	{
		class139_0?.method_15(exception_0);
		throw exception_0;
	}

	void IDisposable.Dispose()
	{
		method_35(bool_2: true);
		GC.SuppressFinalize(this);
	}

	internal void method_35(bool bool_2)
	{
		if (bool_2)
		{
			Close();
		}
	}

	void object.Finalize()
	{
		try
		{
			method_35(bool_2: false);
		}
		finally
		{
			base.Finalize();
		}
	}

	DataTable DbDataReader.GetSchemaTable()
	{
		if (FieldCount == 0)
		{
			return null;
		}
		DataTable dataTable = new DataTable(getString_0(107353538));
		dataTable.Columns.Add(getString_0(107353553), typeof(string));
		dataTable.Columns.Add(getString_0(107353504), typeof(int));
		dataTable.Columns.Add(getString_0(107359549), typeof(int));
		dataTable.Columns.Add(getString_0(107353515), typeof(int));
		dataTable.Columns.Add(getString_0(107353490), typeof(int));
		dataTable.Columns.Add(getString_0(107353441), typeof(bool));
		dataTable.Columns.Add(getString_0(107353428), typeof(bool));
		dataTable.Columns[getString_0(107353428)]!.AllowDBNull = true;
		dataTable.Columns.Add(getString_0(107353451), typeof(string));
		dataTable.Columns.Add(getString_0(107353398), typeof(string));
		dataTable.Columns.Add(getString_0(107353377), typeof(string));
		dataTable.Columns.Add(getString_0(107353388), typeof(string));
		dataTable.Columns.Add(getString_0(107359490), typeof(Type));
		dataTable.Columns.Add(getString_0(107353335), typeof(bool));
		dataTable.Columns.Add(getString_0(107353350), typeof(int));
		dataTable.Columns.Add(getString_0(107352789), typeof(bool));
		dataTable.Columns.Add(getString_0(107352808), typeof(bool));
		dataTable.Columns.Add(getString_0(107352759), typeof(bool));
		dataTable.Columns.Add(getString_0(107352774), typeof(bool));
		dataTable.Columns.Add(getString_0(107352753), typeof(bool));
		dataTable.Columns.Add(getString_0(107352704), typeof(bool));
		dataTable.Columns.Add(getString_0(107358859), typeof(bool));
		dataTable.Columns.Add(getString_0(107352723), typeof(bool));
		int num = 1;
		for (int i = 0; i < FieldCount; i++)
		{
			Class145 @class = ResultSet.Fields[i];
			DataRow dataRow = dataTable.NewRow();
			dataRow[getString_0(107353553)] = @class.string_1;
			dataRow[getString_0(107353504)] = num++;
			dataRow[getString_0(107359549)] = (@class.IsTextField ? (@class.int_0 / @class.MaxLength) : @class.int_0);
			int precision = @class.Precision;
			int scale = @class.Scale;
			dataRow[getString_0(107353515)] = (short)precision;
			dataRow[getString_0(107353490)] = (short)scale;
			dataRow[getString_0(107359490)] = GetFieldType(i);
			dataRow[getString_0(107353350)] = (int)@class.Type;
			dataRow[getString_0(107358859)] = @class.IsBlob && (@class.int_0 > 255 || @class.int_0 == -1);
			dataRow[getString_0(107353335)] = @class.AllowsNull;
			dataRow[getString_0(107352723)] = false;
			dataRow[getString_0(107352753)] = false;
			dataRow[getString_0(107353441)] = false;
			dataRow[getString_0(107353428)] = @class.IsPrimaryKey;
			dataRow[getString_0(107352774)] = @class.IsAutoIncrement;
			dataRow[getString_0(107353377)] = @class.string_5;
			dataRow[getString_0(107353451)] = null;
			dataRow[getString_0(107353388)] = @class.string_4;
			dataRow[getString_0(107353398)] = @class.string_2;
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	static Class142()
	{
		Strings.CreateGetStringDelegate(typeof(Class142));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398313), getString_0(107398308)).Replace(getString_0(107398271), getString_0(107398266)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398261)))
		{
			throw new SecurityException(getString_0(107398236));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
