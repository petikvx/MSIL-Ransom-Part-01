using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns14;
using ns2;
using ns21;
using ns22;
using ns27;
using ns7;
using ns8;

namespace MySql.Data.MySqlClient;

[TypeConverter(typeof(Class170))]
public sealed class MySqlParameter : DbParameter, ICloneable, IDataParameter, IDbDataParameter
{
	[CompilerGenerated]
	private DataRowVersion dataRowVersion_0;

	private object object_0;

	private string string_0;

	private MySqlDbType mySqlDbType_0;

	private bool bool_0 = true;

	private DbType dbType_0;

	[CompilerGenerated]
	private Class151 class151_0;

	[CompilerGenerated]
	private Encoding encoding_0;

	[CompilerGenerated]
	private ParameterDirection parameterDirection_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private byte byte_0;

	[CompilerGenerated]
	private byte byte_1;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private Interface0 interface0_0;

	[CompilerGenerated]
	private IList ilist_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_2;

	[NonSerialized]
	internal static GetString getString_0;

	[Category("Data")]
	DataRowVersion DbParameter.SourceVersion
	{
		[CompilerGenerated]
		get
		{
			return dataRowVersion_0;
		}
		[CompilerGenerated]
		set
		{
			dataRowVersion_0 = value;
		}
	}

	[Category("Misc")]
	string DbParameter.ParameterName
	{
		get
		{
			return string_0;
		}
		set
		{
			method_1(value);
		}
	}

	internal Class151 Collection
	{
		[CompilerGenerated]
		get
		{
			return class151_0;
		}
		[CompilerGenerated]
		set
		{
			class151_0 = value;
		}
	}

	internal Encoding Encoding
	{
		[CompilerGenerated]
		get
		{
			return encoding_0;
		}
		[CompilerGenerated]
		set
		{
			encoding_0 = value;
		}
	}

	internal bool TypeHasBeenSet => !bool_0;

	internal string BaseName
	{
		get
		{
			if (!ParameterName.StartsWith(getString_0(107409977), StringComparison.Ordinal) && !ParameterName.StartsWith(getString_0(107409950), StringComparison.Ordinal))
			{
				return ParameterName;
			}
			return ParameterName.Substring(1);
		}
	}

	[Category("Data")]
	ParameterDirection DbParameter.Direction
	{
		[CompilerGenerated]
		get
		{
			return parameterDirection_0;
		}
		[CompilerGenerated]
		set
		{
			parameterDirection_0 = value;
		}
	}

	[Browsable(false)]
	bool DbParameter.IsNullable
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	[DbProviderSpecificTypeProperty(true)]
	[Category("Data")]
	public MySqlDbType MySqlDbType
	{
		get
		{
			return mySqlDbType_0;
		}
		set
		{
			method_4(value);
			bool_0 = false;
		}
	}

	[Category("Data")]
	byte DbParameter.Precision
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
		[CompilerGenerated]
		set
		{
			byte_0 = value;
		}
	}

	[Category("Data")]
	byte DbParameter.Scale
	{
		[CompilerGenerated]
		get
		{
			return byte_1;
		}
		[CompilerGenerated]
		set
		{
			byte_1 = value;
		}
	}

	[Category("Data")]
	int DbParameter.Size
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	[Category("Data")]
	[TypeConverter(typeof(StringConverter))]
	object DbParameter.Value
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
			byte[] array = value as byte[];
			string text = value as string;
			if (array != null)
			{
				Size = array.Length;
			}
			else if (text != null)
			{
				Size = text.Length;
			}
			if (bool_0)
			{
				method_5();
			}
		}
	}

	internal Interface0 ValueObject
	{
		[CompilerGenerated]
		get
		{
			return interface0_0;
		}
		[CompilerGenerated]
		private set
		{
			interface0_0 = value;
		}
	}

	public IList PossibleValues
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		internal set
		{
			ilist_0 = value;
		}
	}

	[Category("Data")]
	string DbParameter.SourceColumn
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	bool DbParameter.SourceColumnNullMapping
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	DbType DbParameter.DbType
	{
		get
		{
			return dbType_0;
		}
		set
		{
			method_8(value);
			bool_0 = false;
		}
	}

	public MySqlParameter method_0()
	{
		return new MySqlParameter(string_0, mySqlDbType_0, Direction, SourceColumn, SourceVersion, object_0)
		{
			bool_0 = bool_0
		};
	}

	object ICloneable.Clone()
	{
		return method_0();
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType, int size, string sourceColumn)
		: this(parameterName, dbType)
	{
		Size = size;
		Direction = ParameterDirection.Input;
		SourceColumn = sourceColumn;
		SourceVersion = DataRowVersion.Default;
	}

	public MySqlParameter()
	{
		SourceVersion = DataRowVersion.Default;
		Direction = ParameterDirection.Input;
	}

	public MySqlParameter(string parameterName, object value)
		: this()
	{
		ParameterName = parameterName;
		Value = value;
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType)
		: this(parameterName, null)
	{
		MySqlDbType = dbType;
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType, int size)
		: this(parameterName, dbType)
	{
		Size = size;
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType, int size, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value)
		: this(parameterName, dbType, size, sourceColumn)
	{
		Direction = direction;
		IsNullable = isNullable;
		Precision = precision;
		Scale = scale;
		Value = value;
		SourceVersion = sourceVersion;
	}

	internal MySqlParameter(string name, MySqlDbType type, ParameterDirection dir, string col, DataRowVersion sourceVersion, object val)
		: this(name, type)
	{
		Direction = dir;
		SourceColumn = col;
		Value = val;
		SourceVersion = sourceVersion;
	}

	private void method_1(string string_2)
	{
		Collection?.method_10(this, string_0, string_2);
		string_0 = string_2;
	}

	string object.ToString()
	{
		return string_0;
	}

	internal int method_2()
	{
		return mySqlDbType_0 switch
		{
			MySqlDbType.UByte => 32769, 
			MySqlDbType.UInt16 => 32770, 
			MySqlDbType.UInt32 => 32771, 
			MySqlDbType.UInt64 => 32776, 
			MySqlDbType.UInt24 => 32771, 
			MySqlDbType.Bit => 32776, 
			_ => (int)mySqlDbType_0, 
		};
	}

	internal void method_3(Class167 class167_0, bool bool_3, MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		if (!bool_3 && (object_0 == null || object_0 == DBNull.Value))
		{
			class167_0.method_18(getString_0(107405085));
			return;
		}
		if (ValueObject.MySqlDbType == MySqlDbType.Guid)
		{
			Struct12 @struct = (Struct12)(object)ValueObject;
			@struct.OldGuids = mySqlConnectionStringBuilder_0.OldGuids;
			ValueObject = @struct;
		}
		if (ValueObject.MySqlDbType == MySqlDbType.Geometry)
		{
			Struct11 struct11_ = (Struct11)(object)ValueObject;
			if (struct11_.IsNull && Value != null)
			{
				Struct11.smethod_2(Value!.ToString(), out struct11_);
			}
			ValueObject = struct11_;
		}
		ValueObject.imethod_0(class167_0, bool_3, object_0, Size);
	}

	private void method_4(MySqlDbType mySqlDbType_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		ValueObject = Class145.smethod_0(mySqlDbType_0);
		method_7();
	}

	private void method_5()
	{
		if (object_0 == null || object_0 == DBNull.Value)
		{
			return;
		}
		if (object_0 is Guid)
		{
			MySqlDbType = MySqlDbType.Guid;
			return;
		}
		if (object_0 is TimeSpan)
		{
			MySqlDbType = MySqlDbType.Time;
			return;
		}
		if (object_0 is bool)
		{
			MySqlDbType = MySqlDbType.Byte;
			return;
		}
		Type type = object_0.GetType();
		string name = type.Name;
		switch (Class192.smethod_0(name))
		{
		case 765439473u:
			if (name == getString_0(107351405))
			{
				MySqlDbType = MySqlDbType.Int16;
				return;
			}
			break;
		case 697196164u:
			if (name == getString_0(107350857))
			{
				MySqlDbType = MySqlDbType.Int64;
				return;
			}
			break;
		case 423635464u:
			if (name == getString_0(107351423))
			{
				MySqlDbType = MySqlDbType.Byte;
				return;
			}
			break;
		case 1324880019u:
			if (name == getString_0(107350848))
			{
				MySqlDbType = MySqlDbType.UInt64;
				return;
			}
			break;
		case 1323747186u:
			if (name == getString_0(107351396))
			{
				MySqlDbType = MySqlDbType.UInt16;
				return;
			}
			break;
		case 2386971688u:
			if (name == getString_0(107350840))
			{
				MySqlDbType = MySqlDbType.Double;
				return;
			}
			break;
		case 1615808600u:
			if (name == getString_0(107350826))
			{
				MySqlDbType = MySqlDbType.VarChar;
				return;
			}
			break;
		case 2779444460u:
			if (name == getString_0(107350831))
			{
				MySqlDbType = MySqlDbType.Decimal;
				return;
			}
			break;
		case 2711245919u:
			if (name == getString_0(107351419))
			{
				MySqlDbType = MySqlDbType.Int32;
				return;
			}
			break;
		case 2615964816u:
			if (name == getString_0(107350871))
			{
				MySqlDbType = MySqlDbType.DateTime;
				return;
			}
			break;
		case 3538687084u:
			if (name == getString_0(107351410))
			{
				MySqlDbType = MySqlDbType.UInt32;
				return;
			}
			break;
		case 3409549631u:
			if (name == getString_0(107351446))
			{
				MySqlDbType = MySqlDbType.UByte;
				return;
			}
			break;
		case 4051133705u:
			if (name == getString_0(107350817))
			{
				MySqlDbType = MySqlDbType.Float;
				return;
			}
			break;
		case 3851314394u:
			if (!(name == getString_0(107387250)))
			{
			}
			break;
		}
		if (type.GetTypeInfo().BaseType == typeof(Enum))
		{
			MySqlDbType = MySqlDbType.Int32;
		}
		else
		{
			MySqlDbType = MySqlDbType.Blob;
		}
	}

	internal long method_6()
	{
		if (Value != null && Value != DBNull.Value)
		{
			if (Value is byte[])
			{
				return ((byte[])Value).Length;
			}
			if (Value is string)
			{
				return ((string)Value).Length * 4;
			}
			if (!(Value is decimal) && !(Value is float))
			{
				return 32L;
			}
			return 64L;
		}
		return 4L;
	}

	public override void ResetDbType()
	{
		bool_0 = true;
	}

	private void method_7()
	{
		switch (mySqlDbType_0)
		{
		case MySqlDbType.TinyBlob:
		case MySqlDbType.MediumBlob:
		case MySqlDbType.LongBlob:
		case MySqlDbType.Blob:
			dbType_0 = DbType.Object;
			break;
		case MySqlDbType.Enum:
		case MySqlDbType.Set:
		case MySqlDbType.VarChar:
			dbType_0 = DbType.String;
			break;
		case MySqlDbType.String:
			dbType_0 = DbType.StringFixedLength;
			break;
		case MySqlDbType.Decimal:
		case MySqlDbType.NewDecimal:
			dbType_0 = DbType.Decimal;
			break;
		case MySqlDbType.Byte:
			dbType_0 = DbType.SByte;
			break;
		case MySqlDbType.Int16:
			dbType_0 = DbType.Int16;
			break;
		case MySqlDbType.Float:
			dbType_0 = DbType.Single;
			break;
		case MySqlDbType.Double:
			dbType_0 = DbType.Double;
			break;
		case MySqlDbType.Int64:
			dbType_0 = DbType.Int64;
			break;
		case MySqlDbType.Int32:
		case MySqlDbType.Int24:
			dbType_0 = DbType.Int32;
			break;
		case MySqlDbType.Time:
			dbType_0 = DbType.Time;
			break;
		case MySqlDbType.Timestamp:
		case MySqlDbType.DateTime:
			dbType_0 = DbType.DateTime;
			break;
		case MySqlDbType.Date:
		case MySqlDbType.Year:
		case MySqlDbType.Newdate:
			dbType_0 = DbType.Date;
			break;
		case MySqlDbType.Bit:
			dbType_0 = DbType.UInt64;
			break;
		case MySqlDbType.Guid:
			dbType_0 = DbType.Guid;
			break;
		case MySqlDbType.UByte:
			dbType_0 = DbType.Byte;
			break;
		case MySqlDbType.UInt16:
			dbType_0 = DbType.UInt16;
			break;
		case MySqlDbType.UInt64:
			dbType_0 = DbType.UInt64;
			break;
		case MySqlDbType.UInt32:
		case MySqlDbType.UInt24:
			dbType_0 = DbType.UInt32;
			break;
		}
	}

	private void method_8(DbType dbType_1)
	{
		dbType_0 = dbType_1;
		switch (dbType_0)
		{
		case DbType.Byte:
		case DbType.Boolean:
			mySqlDbType_0 = MySqlDbType.UByte;
			break;
		case DbType.Date:
			mySqlDbType_0 = MySqlDbType.Date;
			break;
		case DbType.DateTime:
			mySqlDbType_0 = MySqlDbType.DateTime;
			break;
		case DbType.Currency:
		case DbType.Decimal:
			mySqlDbType_0 = MySqlDbType.Decimal;
			break;
		case DbType.Double:
			mySqlDbType_0 = MySqlDbType.Double;
			break;
		case DbType.Guid:
			mySqlDbType_0 = MySqlDbType.Guid;
			break;
		case DbType.Int16:
			mySqlDbType_0 = MySqlDbType.Int16;
			break;
		case DbType.Int32:
			mySqlDbType_0 = MySqlDbType.Int32;
			break;
		case DbType.Int64:
			mySqlDbType_0 = MySqlDbType.Int64;
			break;
		case DbType.SByte:
			mySqlDbType_0 = MySqlDbType.Byte;
			break;
		case DbType.Single:
			mySqlDbType_0 = MySqlDbType.Float;
			break;
		case DbType.AnsiString:
		case DbType.String:
			mySqlDbType_0 = MySqlDbType.VarChar;
			break;
		case DbType.Time:
			mySqlDbType_0 = MySqlDbType.Time;
			break;
		case DbType.UInt16:
			mySqlDbType_0 = MySqlDbType.UInt16;
			break;
		case DbType.UInt32:
			mySqlDbType_0 = MySqlDbType.UInt32;
			break;
		case DbType.UInt64:
			mySqlDbType_0 = MySqlDbType.UInt64;
			break;
		default:
			mySqlDbType_0 = MySqlDbType.Blob;
			break;
		case DbType.AnsiStringFixedLength:
		case DbType.StringFixedLength:
			mySqlDbType_0 = MySqlDbType.String;
			break;
		}
		if (dbType_0 == DbType.Object && object_0 is byte[] array && array.Length == 25)
		{
			mySqlDbType_0 = MySqlDbType.Geometry;
		}
		ValueObject = Class145.smethod_0(mySqlDbType_0);
	}

	static MySqlParameter()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlParameter));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398419), getString_0(107398414)).Replace(getString_0(107398377), getString_0(107398372)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_3: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398367)))
		{
			throw new SecurityException(getString_0(107398342));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_3, [MarshalAs(UnmanagedType.Bool)] out bool bool_4);
}
