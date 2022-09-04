using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Data.SQLite;

public abstract class SQLiteConvert
{
	private static string[] _datetimeFormats = new string[17]
	{
		"THHmmss", "THHmm", "HH:mm:ss", "HH:mm", "HH:mm:ss.FFFFFFF", "yy-MM-dd", "yyyy-MM-dd", "yyyy-MM-dd HH:mm:ss.FFFFFFF", "yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm",
		"yyyy-MM-ddTHH:mm:ss.FFFFFFF", "yyyy-MM-ddTHH:mm", "yyyy-MM-ddTHH:mm:ss", "yyyyMMddHHmmss", "yyyyMMddHHmm", "yyyyMMddTHHmmssFFFFFFF", "yyyyMMdd"
	};

	private static Encoding _utf8 = new UTF8Encoding();

	internal SQLiteDateFormats _datetimeFormat;

	private static Type[] _affinitytotype = new Type[8]
	{
		typeof(object),
		typeof(long),
		typeof(double),
		typeof(string),
		typeof(byte[]),
		typeof(object),
		typeof(DateTime),
		typeof(object)
	};

	private static DbType[] _typetodbtype = new DbType[19]
	{
		DbType.Object,
		DbType.Binary,
		DbType.Object,
		DbType.Boolean,
		DbType.SByte,
		DbType.SByte,
		DbType.Byte,
		DbType.Int16,
		DbType.UInt16,
		DbType.Int32,
		DbType.UInt32,
		DbType.Int64,
		DbType.UInt64,
		DbType.Single,
		DbType.Double,
		DbType.Decimal,
		DbType.DateTime,
		DbType.Object,
		DbType.String
	};

	private static int[] _dbtypetocolumnsize = new int[26]
	{
		2147483647, 2147483647, 1, 1, 8, 8, 8, 8, 8, 16,
		2, 4, 8, 2147483647, 1, 4, 2147483647, 8, 2, 4,
		8, 8, 2147483647, 2147483647, 2147483647, 2147483647
	};

	private static object[] _dbtypetonumericprecision = new object[25]
	{
		DBNull.Value,
		DBNull.Value,
		3,
		DBNull.Value,
		19,
		DBNull.Value,
		DBNull.Value,
		53,
		53,
		DBNull.Value,
		5,
		10,
		19,
		DBNull.Value,
		3,
		24,
		DBNull.Value,
		DBNull.Value,
		5,
		10,
		19,
		53,
		DBNull.Value,
		DBNull.Value,
		DBNull.Value
	};

	private static object[] _dbtypetonumericscale = new object[25]
	{
		DBNull.Value,
		DBNull.Value,
		0,
		DBNull.Value,
		4,
		DBNull.Value,
		DBNull.Value,
		DBNull.Value,
		DBNull.Value,
		DBNull.Value,
		0,
		0,
		0,
		DBNull.Value,
		0,
		DBNull.Value,
		DBNull.Value,
		DBNull.Value,
		0,
		0,
		0,
		0,
		DBNull.Value,
		DBNull.Value,
		DBNull.Value
	};

	private static SQLiteTypeNames[] _dbtypeNames = new SQLiteTypeNames[15]
	{
		new SQLiteTypeNames("INTEGER", DbType.Int64),
		new SQLiteTypeNames("TINYINT", DbType.Byte),
		new SQLiteTypeNames("INT", DbType.Int32),
		new SQLiteTypeNames("VARCHAR", DbType.AnsiString),
		new SQLiteTypeNames("NVARCHAR", DbType.String),
		new SQLiteTypeNames("CHAR", DbType.AnsiStringFixedLength),
		new SQLiteTypeNames("NCHAR", DbType.StringFixedLength),
		new SQLiteTypeNames("FLOAT", DbType.Double),
		new SQLiteTypeNames("REAL", DbType.Single),
		new SQLiteTypeNames("BIT", DbType.Boolean),
		new SQLiteTypeNames("DECIMAL", DbType.Decimal),
		new SQLiteTypeNames("DATETIME", DbType.DateTime),
		new SQLiteTypeNames("BLOB", DbType.Binary),
		new SQLiteTypeNames("UNIQUEIDENTIFIER", DbType.Guid),
		new SQLiteTypeNames("SMALLINT", DbType.Int16)
	};

	private static Type[] _dbtypeToType = new Type[26]
	{
		typeof(string),
		typeof(byte[]),
		typeof(byte),
		typeof(bool),
		typeof(decimal),
		typeof(DateTime),
		typeof(DateTime),
		typeof(decimal),
		typeof(double),
		typeof(Guid),
		typeof(short),
		typeof(int),
		typeof(long),
		typeof(object),
		typeof(sbyte),
		typeof(float),
		typeof(string),
		typeof(DateTime),
		typeof(ushort),
		typeof(uint),
		typeof(ulong),
		typeof(double),
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	};

	private static TypeAffinity[] _typecodeAffinities = new TypeAffinity[19]
	{
		TypeAffinity.Null,
		TypeAffinity.Blob,
		TypeAffinity.Null,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Int64,
		TypeAffinity.Double,
		TypeAffinity.Double,
		TypeAffinity.Double,
		TypeAffinity.DateTime,
		TypeAffinity.Null,
		TypeAffinity.Text
	};

	private static SQLiteTypeNames[] _typeNames = new SQLiteTypeNames[43]
	{
		new SQLiteTypeNames("COUNTER", DbType.Int64),
		new SQLiteTypeNames("AUTOINCREMENT", DbType.Int64),
		new SQLiteTypeNames("IDENTITY", DbType.Int64),
		new SQLiteTypeNames("LONGTEXT", DbType.String),
		new SQLiteTypeNames("LONGCHAR", DbType.String),
		new SQLiteTypeNames("LONGVARCHAR", DbType.String),
		new SQLiteTypeNames("LONG", DbType.Int64),
		new SQLiteTypeNames("TINYINT", DbType.Byte),
		new SQLiteTypeNames("INTEGER", DbType.Int64),
		new SQLiteTypeNames("INT", DbType.Int32),
		new SQLiteTypeNames("VARCHAR", DbType.String),
		new SQLiteTypeNames("NVARCHAR", DbType.String),
		new SQLiteTypeNames("CHAR", DbType.String),
		new SQLiteTypeNames("NCHAR", DbType.String),
		new SQLiteTypeNames("TEXT", DbType.String),
		new SQLiteTypeNames("NTEXT", DbType.String),
		new SQLiteTypeNames("STRING", DbType.String),
		new SQLiteTypeNames("DOUBLE", DbType.Double),
		new SQLiteTypeNames("FLOAT", DbType.Double),
		new SQLiteTypeNames("REAL", DbType.Single),
		new SQLiteTypeNames("BIT", DbType.Boolean),
		new SQLiteTypeNames("YESNO", DbType.Boolean),
		new SQLiteTypeNames("LOGICAL", DbType.Boolean),
		new SQLiteTypeNames("BOOL", DbType.Boolean),
		new SQLiteTypeNames("NUMERIC", DbType.Decimal),
		new SQLiteTypeNames("DECIMAL", DbType.Decimal),
		new SQLiteTypeNames("MONEY", DbType.Decimal),
		new SQLiteTypeNames("CURRENCY", DbType.Decimal),
		new SQLiteTypeNames("TIME", DbType.DateTime),
		new SQLiteTypeNames("DATE", DbType.DateTime),
		new SQLiteTypeNames("SMALLDATE", DbType.DateTime),
		new SQLiteTypeNames("BLOB", DbType.Binary),
		new SQLiteTypeNames("BINARY", DbType.Binary),
		new SQLiteTypeNames("VARBINARY", DbType.Binary),
		new SQLiteTypeNames("IMAGE", DbType.Binary),
		new SQLiteTypeNames("GENERAL", DbType.Binary),
		new SQLiteTypeNames("OLEOBJECT", DbType.Binary),
		new SQLiteTypeNames("GUID", DbType.Guid),
		new SQLiteTypeNames("UNIQUEIDENTIFIER", DbType.Guid),
		new SQLiteTypeNames("MEMO", DbType.String),
		new SQLiteTypeNames("NOTE", DbType.String),
		new SQLiteTypeNames("SMALLINT", DbType.Int16),
		new SQLiteTypeNames("BIGINT", DbType.Int64)
	};

	internal SQLiteConvert(SQLiteDateFormats fmt)
	{
		_datetimeFormat = fmt;
	}

	public static byte[] ToUTF8(string sourceText)
	{
		int num = _utf8.GetByteCount(sourceText) + 1;
		byte[] array = new byte[num];
		num = _utf8.GetBytes(sourceText, 0, sourceText.Length, array, 0);
		array[num] = 0;
		return array;
	}

	public byte[] ToUTF8(DateTime dateTimeValue)
	{
		return ToUTF8(ToString(dateTimeValue));
	}

	public virtual string ToString(IntPtr nativestring, int nativestringlen)
	{
		return UTF8ToString(nativestring, nativestringlen);
	}

	public static string UTF8ToString(IntPtr nativestring, int nativestringlen)
	{
		if (nativestringlen != 0 && !(nativestring == IntPtr.Zero))
		{
			if (nativestringlen == -1)
			{
				do
				{
					nativestringlen++;
				}
				while (Marshal.ReadByte(nativestring, nativestringlen) != 0);
			}
			byte[] array = new byte[nativestringlen];
			Marshal.Copy(nativestring, array, 0, nativestringlen);
			return _utf8.GetString(array, 0, nativestringlen);
		}
		return "";
	}

	public DateTime ToDateTime(string dateText)
	{
		return _datetimeFormat switch
		{
			SQLiteDateFormats.Ticks => new DateTime(Convert.ToInt64(dateText, CultureInfo.InvariantCulture)), 
			SQLiteDateFormats.JulianDay => ToDateTime(Convert.ToDouble(dateText, CultureInfo.InvariantCulture)), 
			_ => DateTime.ParseExact(dateText, _datetimeFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None), 
		};
	}

	public DateTime ToDateTime(double julianDay)
	{
		return DateTime.FromOADate(julianDay - 2415018.5);
	}

	public double ToJulianDay(DateTime value)
	{
		return value.ToOADate() + 2415018.5;
	}

	public string ToString(DateTime dateValue)
	{
		return _datetimeFormat switch
		{
			SQLiteDateFormats.Ticks => dateValue.Ticks.ToString(CultureInfo.InvariantCulture), 
			SQLiteDateFormats.JulianDay => ToJulianDay(dateValue).ToString(CultureInfo.InvariantCulture), 
			_ => dateValue.ToString(_datetimeFormats[7], CultureInfo.InvariantCulture), 
		};
	}

	internal DateTime ToDateTime(IntPtr ptr, int len)
	{
		return ToDateTime(ToString(ptr, len));
	}

	public static string[] Split(string source, char separator)
	{
		char[] array = new char[2] { '"', separator };
		char[] array2 = new char[1] { '"' };
		int startIndex = 0;
		List<string> list = new List<string>();
		while (source.Length > 0)
		{
			startIndex = source.IndexOfAny(array, startIndex);
			if (startIndex == -1)
			{
				break;
			}
			if (source[startIndex] == array[0])
			{
				startIndex = source.IndexOfAny(array2, startIndex + 1);
				if (startIndex == -1)
				{
					break;
				}
				startIndex++;
				continue;
			}
			string text = source.Substring(0, startIndex).Trim();
			if (text.Length > 1 && text[0] == array2[0] && text[text.Length - 1] == text[0])
			{
				text = text.Substring(1, text.Length - 2);
			}
			source = source.Substring(startIndex + 1).Trim();
			if (text.Length > 0)
			{
				list.Add(text);
			}
			startIndex = 0;
		}
		if (source.Length > 0)
		{
			string text = source.Trim();
			if (text.Length > 1 && text[0] == array2[0] && text[text.Length - 1] == text[0])
			{
				text = text.Substring(1, text.Length - 2);
			}
			list.Add(text);
		}
		string[] array3 = new string[list.Count];
		list.CopyTo(array3, 0);
		return array3;
	}

	public static bool ToBoolean(object source)
	{
		if (source is bool)
		{
			return (bool)source;
		}
		return ToBoolean(source.ToString());
	}

	public static bool ToBoolean(string source)
	{
		if (string.Compare(source, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(source, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		switch (source.ToLower(CultureInfo.InvariantCulture))
		{
		case "yes":
		case "y":
		case "1":
		case "on":
			return true;
		default:
			throw new ArgumentException("source");
		case "no":
		case "n":
		case "0":
		case "off":
			return false;
		}
	}

	internal static void ColumnToType(SQLiteStatement stmt, int i, SQLiteType typ)
	{
		typ.Type = TypeNameToDbType(stmt._sql.ColumnType(stmt, i, out typ.Affinity));
	}

	internal static Type SQLiteTypeToType(SQLiteType t)
	{
		if (t.Type == DbType.Object)
		{
			return _affinitytotype[(int)t.Affinity];
		}
		return DbTypeToType(t.Type);
	}

	internal static DbType TypeToDbType(Type typ)
	{
		TypeCode typeCode = Type.GetTypeCode(typ);
		if (typeCode == TypeCode.Object)
		{
			if ((object)typ == typeof(byte[]))
			{
				return DbType.Binary;
			}
			if ((object)typ == typeof(Guid))
			{
				return DbType.Guid;
			}
			return DbType.String;
		}
		return _typetodbtype[(int)typeCode];
	}

	internal static int DbTypeToColumnSize(DbType typ)
	{
		return _dbtypetocolumnsize[(int)typ];
	}

	internal static object DbTypeToNumericPrecision(DbType typ)
	{
		return _dbtypetonumericprecision[(int)typ];
	}

	internal static object DbTypeToNumericScale(DbType typ)
	{
		return _dbtypetonumericscale[(int)typ];
	}

	internal static string DbTypeToTypeName(DbType typ)
	{
		int num = 0;
		while (true)
		{
			if (num < _dbtypeNames.Length)
			{
				if (_dbtypeNames[num].dataType == typ)
				{
					break;
				}
				num++;
				continue;
			}
			return string.Empty;
		}
		return _dbtypeNames[num].typeName;
	}

	internal static Type DbTypeToType(DbType typ)
	{
		return _dbtypeToType[(int)typ];
	}

	internal static TypeAffinity TypeToAffinity(Type typ)
	{
		TypeCode typeCode = Type.GetTypeCode(typ);
		if (typeCode == TypeCode.Object)
		{
			if ((object)typ != typeof(byte[]) && (object)typ != typeof(Guid))
			{
				return TypeAffinity.Text;
			}
			return TypeAffinity.Blob;
		}
		return _typecodeAffinities[(int)typeCode];
	}

	internal static DbType TypeNameToDbType(string Name)
	{
		if (string.IsNullOrEmpty(Name))
		{
			return DbType.Object;
		}
		int num = _typeNames.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (string.Compare(Name, 0, _typeNames[num2].typeName, 0, _typeNames[num2].typeName.Length, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num2++;
				continue;
			}
			return DbType.Object;
		}
		return _typeNames[num2].dataType;
	}
}
