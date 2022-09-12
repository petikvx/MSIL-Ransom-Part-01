using System;
using System.Globalization;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

[Serializable]
public struct MySqlDateTime : IComparable, IConvertible, IMySqlValue
{
	private readonly MySqlDbType _type;

	private int _millisecond;

	private int _microsecond;

	public int TimezoneOffset;

	public bool IsValidDateTime
	{
		get
		{
			if (Year != 0 && Month != 0)
			{
				return Day != 0;
			}
			return false;
		}
	}

	public int Year { get; set; }

	public int Month { get; set; }

	public int Day { get; set; }

	public int Hour { get; set; }

	public int Minute { get; set; }

	public int Second { get; set; }

	public int Millisecond
	{
		get
		{
			return _millisecond;
		}
		set
		{
			if (value < 0 || value > 999)
			{
				throw new ArgumentOutOfRangeException("Millisecond", Resources.InvalidMillisecondValue);
			}
			_millisecond = value;
			_microsecond = value * 1000;
		}
	}

	public int Microsecond
	{
		get
		{
			return _microsecond;
		}
		set
		{
			if (value < 0 || value > 999999)
			{
				throw new ArgumentOutOfRangeException("Microsecond", Resources.InvalidMicrosecondValue);
			}
			_microsecond = value;
			_millisecond = value / 1000;
		}
	}

	public bool IsNull { get; }

	MySqlDbType IMySqlValue.MySqlDbType => _type;

	object IMySqlValue.Value => GetDateTime();

	public DateTime Value => GetDateTime();

	Type IMySqlValue.SystemType => typeof(DateTime);

	string IMySqlValue.MySqlTypeName => _type switch
	{
		MySqlDbType.Newdate => "NEWDATE", 
		MySqlDbType.Date => "DATE", 
		MySqlDbType.Timestamp => "TIMESTAMP", 
		_ => "DATETIME", 
	};

	public MySqlDateTime(int year, int month, int day, int hour, int minute, int second, int microsecond)
		: this(MySqlDbType.DateTime, year, month, day, hour, minute, second, microsecond)
	{
	}

	public MySqlDateTime(DateTime dt)
		: this(MySqlDbType.DateTime, dt)
	{
	}

	public MySqlDateTime(MySqlDateTime mdt)
	{
		Year = mdt.Year;
		Month = mdt.Month;
		Day = mdt.Day;
		Hour = mdt.Hour;
		Minute = mdt.Minute;
		Second = mdt.Second;
		_microsecond = 0;
		_millisecond = 0;
		_type = MySqlDbType.DateTime;
		IsNull = false;
		TimezoneOffset = 0;
	}

	public MySqlDateTime(string dateTime)
		: this(Parse(dateTime))
	{
	}

	internal MySqlDateTime(MySqlDbType type, int year, int month, int day, int hour, int minute, int second, int microsecond)
	{
		IsNull = false;
		_type = type;
		Year = year;
		Month = month;
		Day = day;
		Hour = hour;
		Minute = minute;
		Second = second;
		_microsecond = microsecond;
		_millisecond = _microsecond / 1000;
		TimezoneOffset = 0;
	}

	internal MySqlDateTime(MySqlDbType type, bool isNull)
		: this(type, 0, 0, 0, 0, 0, 0, 0)
	{
		IsNull = isNull;
	}

	internal MySqlDateTime(MySqlDbType type, DateTime val)
		: this(type, 0, 0, 0, 0, 0, 0, 0)
	{
		IsNull = false;
		Year = val.Year;
		Month = val.Month;
		Day = val.Day;
		Hour = val.Hour;
		Minute = val.Minute;
		Second = val.Second;
		Microsecond = (int)(val.Ticks % 10000000L) / 10;
	}

	private void SerializeText(MySqlPacket packet, MySqlDateTime value)
	{
		string text = $"{value.Year:0000}-{value.Month:00}-{value.Day:00}";
		if (_type != MySqlDbType.Date)
		{
			text = ((value.Microsecond > 0) ? $"{text} {value.Hour:00}:{value.Minute:00}:{value.Second:00}.{value.Microsecond:000000}" : $"{text} {value.Hour:00}:{value.Minute:00}:{value.Second:00}");
		}
		packet.WriteStringNoNull("'" + text + "'");
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object value, int length)
	{
		string text = value as string;
		MySqlDateTime value2;
		if (value is DateTime)
		{
			value2 = new MySqlDateTime(_type, (DateTime)value);
		}
		else if (text != null)
		{
			value2 = Parse(text);
		}
		else
		{
			if (!(value is MySqlDateTime))
			{
				throw new MySqlException("Unable to serialize date/time value.");
			}
			value2 = (MySqlDateTime)value;
		}
		if (!binary)
		{
			SerializeText(packet, value2);
			return;
		}
		if (value2.Microsecond > 0)
		{
			packet.WriteByte(11);
		}
		else
		{
			packet.WriteByte(7);
		}
		packet.WriteInteger(value2.Year, 2);
		packet.WriteByte((byte)value2.Month);
		packet.WriteByte((byte)value2.Day);
		if (_type == MySqlDbType.Date)
		{
			packet.WriteByte(0);
			packet.WriteByte(0);
			packet.WriteByte(0);
		}
		else
		{
			packet.WriteByte((byte)value2.Hour);
			packet.WriteByte((byte)value2.Minute);
			packet.WriteByte((byte)value2.Second);
		}
		if (value2.Microsecond > 0)
		{
			long num = value2.Microsecond;
			for (int i = 0; i < 4; i++)
			{
				packet.WriteByte((byte)((ulong)num & 0xFFuL));
				num >>= 8;
			}
		}
	}

	internal static MySqlDateTime Parse(string s)
	{
		return default(MySqlDateTime).ParseMySql(s);
	}

	internal static MySqlDateTime Parse(string s, DBVersion version)
	{
		return default(MySqlDateTime).ParseMySql(s);
	}

	private MySqlDateTime ParseMySql(string s)
	{
		string[] array = s.Split('-', ' ', ':', '/', '.');
		int year = int.Parse(array[0], CultureInfo.InvariantCulture);
		int month = int.Parse(array[1], CultureInfo.InvariantCulture);
		int day = int.Parse(array[2], CultureInfo.InvariantCulture);
		int hour = 0;
		int minute = 0;
		int second = 0;
		int microsecond = 0;
		if (array.Length > 3)
		{
			hour = int.Parse(array[3], CultureInfo.InvariantCulture);
			minute = int.Parse(array[4], CultureInfo.InvariantCulture);
			second = int.Parse(array[5], CultureInfo.InvariantCulture);
		}
		if (array.Length > 6)
		{
			microsecond = int.Parse(array[6].PadRight(6, '0'), CultureInfo.InvariantCulture);
		}
		return new MySqlDateTime(_type, year, month, day, hour, minute, second, microsecond);
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlDateTime(_type, isNull: true);
		}
		if (length >= 0L)
		{
			string s = packet.ReadString(length);
			return ParseMySql(s);
		}
		long num = packet.ReadByte();
		int year = 0;
		int month = 0;
		int day = 0;
		int hour = 0;
		int minute = 0;
		int second = 0;
		int microsecond = 0;
		if (num >= 4L)
		{
			year = packet.ReadInteger(2);
			month = packet.ReadByte();
			day = packet.ReadByte();
		}
		if (num > 4L)
		{
			hour = packet.ReadByte();
			minute = packet.ReadByte();
			second = packet.ReadByte();
		}
		if (num > 7L)
		{
			microsecond = packet.Read3ByteInt();
			packet.ReadByte();
		}
		return new MySqlDateTime(_type, year, month, day, hour, minute, second, microsecond);
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = packet.ReadByte();
		packet.Position += num;
	}

	public DateTime GetDateTime()
	{
		if (!IsValidDateTime)
		{
			throw new MySqlConversionException("Unable to convert MySQL date/time value to System.DateTime");
		}
		DateTimeKind kind = DateTimeKind.Unspecified;
		if (_type == MySqlDbType.Timestamp)
		{
			kind = ((TimezoneOffset == 0) ? DateTimeKind.Utc : DateTimeKind.Local);
		}
		return new DateTime(Year, Month, Day, Hour, Minute, Second, kind).AddTicks(_microsecond * 10);
	}

	private static string FormatDateCustom(string format, int monthVal, int dayVal, int yearVal)
	{
		format = format.Replace("MM", "{0:00}");
		format = format.Replace("M", "{0}");
		format = format.Replace("dd", "{1:00}");
		format = format.Replace("d", "{1}");
		format = format.Replace("yyyy", "{2:0000}");
		format = format.Replace("yy", "{3:00}");
		format = format.Replace("y", "{4:0}");
		int num = yearVal - yearVal / 1000 * 1000;
		num -= num / 100 * 100;
		int num2 = num - num / 10 * 10;
		return string.Format(format, monthVal, dayVal, yearVal, num, num2);
	}

	public override string ToString()
	{
		if (IsValidDateTime)
		{
			DateTime dateTime = new DateTime(Year, Month, Day, Hour, Minute, Second).AddTicks(_microsecond * 10);
			if (_type != MySqlDbType.Date)
			{
				return dateTime.ToString(CultureInfo.InvariantCulture);
			}
			return dateTime.ToString("d", CultureInfo.InvariantCulture);
		}
		string text = FormatDateCustom(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern, Month, Day, Year);
		if (_type == MySqlDbType.Date)
		{
			return text;
		}
		return $"{text} {new DateTime(1, 2, 3, Hour, Minute, Second).AddTicks(_microsecond * 10).ToLongTimeString()}";
	}

	public static explicit operator DateTime(MySqlDateTime val)
	{
		if (!val.IsValidDateTime)
		{
			return DateTime.MinValue;
		}
		return val.GetDateTime();
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		string[] array = new string[3] { "DATE", "DATETIME", "TIMESTAMP" };
		MySqlDbType[] array2 = new MySqlDbType[3]
		{
			MySqlDbType.Date,
			MySqlDbType.DateTime,
			MySqlDbType.Timestamp
		};
		for (int i = 0; i < array.Length; i++)
		{
			MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
			mySqlSchemaRow["TypeName"] = array[i];
			mySqlSchemaRow["ProviderDbType"] = array2[i];
			mySqlSchemaRow["ColumnSize"] = 0;
			mySqlSchemaRow["CreateFormat"] = array[i];
			mySqlSchemaRow["CreateParameters"] = null;
			mySqlSchemaRow["DataType"] = "System.DateTime";
			mySqlSchemaRow["IsAutoincrementable"] = false;
			mySqlSchemaRow["IsBestMatch"] = true;
			mySqlSchemaRow["IsCaseSensitive"] = false;
			mySqlSchemaRow["IsFixedLength"] = true;
			mySqlSchemaRow["IsFixedPrecisionScale"] = true;
			mySqlSchemaRow["IsLong"] = false;
			mySqlSchemaRow["IsNullable"] = true;
			mySqlSchemaRow["IsSearchable"] = true;
			mySqlSchemaRow["IsSearchableWithLike"] = false;
			mySqlSchemaRow["IsUnsigned"] = false;
			mySqlSchemaRow["MaximumScale"] = 0;
			mySqlSchemaRow["MinimumScale"] = 0;
			mySqlSchemaRow["IsConcurrencyType"] = DBNull.Value;
			mySqlSchemaRow["IsLiteralSupported"] = false;
			mySqlSchemaRow["LiteralPrefix"] = null;
			mySqlSchemaRow["LiteralSuffix"] = null;
			mySqlSchemaRow["NativeDataType"] = null;
		}
	}

	int IComparable.CompareTo(object obj)
	{
		MySqlDateTime mySqlDateTime = (MySqlDateTime)obj;
		if (Year < mySqlDateTime.Year)
		{
			return -1;
		}
		if (Year > mySqlDateTime.Year)
		{
			return 1;
		}
		if (Month < mySqlDateTime.Month)
		{
			return -1;
		}
		if (Month > mySqlDateTime.Month)
		{
			return 1;
		}
		if (Day < mySqlDateTime.Day)
		{
			return -1;
		}
		if (Day > mySqlDateTime.Day)
		{
			return 1;
		}
		if (Hour < mySqlDateTime.Hour)
		{
			return -1;
		}
		if (Hour > mySqlDateTime.Hour)
		{
			return 1;
		}
		if (Minute < mySqlDateTime.Minute)
		{
			return -1;
		}
		if (Minute > mySqlDateTime.Minute)
		{
			return 1;
		}
		if (Second < mySqlDateTime.Second)
		{
			return -1;
		}
		if (Second > mySqlDateTime.Second)
		{
			return 1;
		}
		if (Microsecond < mySqlDateTime.Microsecond)
		{
			return -1;
		}
		if (Microsecond > mySqlDateTime.Microsecond)
		{
			return 1;
		}
		return 0;
	}

	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return GetDateTime();
	}

	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	string IConvertible.ToString(IFormatProvider provider)
	{
		return null;
	}

	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	TypeCode IConvertible.GetTypeCode()
	{
		return TypeCode.Empty;
	}

	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return 0m;
	}

	object IConvertible.ToType(Type conversionType, IFormatProvider provider)
	{
		return null;
	}

	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}
}
