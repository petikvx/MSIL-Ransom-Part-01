using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns21;
using ns22;
using ns6;

namespace MySql.Data.Types;

[Serializable]
public struct MySqlDateTime : IComparable, IConvertible, Interface0
{
	private readonly MySqlDbType _type;

	private int _millisecond;

	private int _microsecond;

	public int TimezoneOffset;

	[NonSerialized]
	internal static GetString getString_0;

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
				throw new ArgumentOutOfRangeException(getString_0(107358858), Class121.InvalidMillisecondValue);
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
				throw new ArgumentOutOfRangeException(getString_0(107358809), Class121.InvalidMicrosecondValue);
			}
			_microsecond = value;
			_millisecond = value / 1000;
		}
	}

	public bool IsNull { get; }

	MySqlDbType Interface0.MySqlDbType => _type;

	object Interface0.Value => method_2();

	public DateTime Value => method_2();

	Type Interface0.SystemType => typeof(DateTime);

	string Interface0.MySqlTypeName => _type switch
	{
		MySqlDbType.Newdate => getString_0(107358824), 
		MySqlDbType.Date => getString_0(107407689), 
		MySqlDbType.Timestamp => getString_0(107407639), 
		_ => getString_0(107407658), 
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
		: this(smethod_0(dateTime))
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

	private void method_0(Class167 class167_0, MySqlDateTime mySqlDateTime_0)
	{
		string text = string.Format(getString_0(107358779), mySqlDateTime_0.Year, mySqlDateTime_0.Month, mySqlDateTime_0.Day);
		if (_type != MySqlDbType.Date)
		{
			text = ((mySqlDateTime_0.Microsecond > 0) ? string.Format(getString_0(107358713), text, mySqlDateTime_0.Hour, mySqlDateTime_0.Minute, mySqlDateTime_0.Second, mySqlDateTime_0.Microsecond) : string.Format(getString_0(107358746), text, mySqlDateTime_0.Hour, mySqlDateTime_0.Minute, mySqlDateTime_0.Second));
		}
		class167_0.method_18(getString_0(107408148) + text + getString_0(107408148));
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_0, object object_0, int int_0)
	{
		string text = object_0 as string;
		MySqlDateTime mySqlDateTime_;
		if (object_0 is DateTime)
		{
			mySqlDateTime_ = new MySqlDateTime(_type, (DateTime)object_0);
		}
		else if (text != null)
		{
			mySqlDateTime_ = smethod_0(text);
		}
		else
		{
			if (!(object_0 is MySqlDateTime))
			{
				throw new MySqlException(getString_0(107358184));
			}
			mySqlDateTime_ = (MySqlDateTime)object_0;
		}
		if (!bool_0)
		{
			method_0(class167_0, mySqlDateTime_);
			return;
		}
		if (mySqlDateTime_.Microsecond > 0)
		{
			class167_0.method_3(11);
		}
		else
		{
			class167_0.method_3(7);
		}
		class167_0.method_14(mySqlDateTime_.Year, 2);
		class167_0.method_3((byte)mySqlDateTime_.Month);
		class167_0.method_3((byte)mySqlDateTime_.Day);
		if (_type == MySqlDbType.Date)
		{
			class167_0.method_3(0);
			class167_0.method_3(0);
			class167_0.method_3(0);
		}
		else
		{
			class167_0.method_3((byte)mySqlDateTime_.Hour);
			class167_0.method_3((byte)mySqlDateTime_.Minute);
			class167_0.method_3((byte)mySqlDateTime_.Second);
		}
		if (mySqlDateTime_.Microsecond > 0)
		{
			long num = mySqlDateTime_.Microsecond;
			for (int i = 0; i < 4; i++)
			{
				class167_0.method_3((byte)((ulong)num & 0xFFuL));
				num >>= 8;
			}
		}
	}

	internal static MySqlDateTime smethod_0(string string_0)
	{
		return default(MySqlDateTime).method_1(string_0);
	}

	internal static MySqlDateTime smethod_1(string string_0, Struct23 struct23_0)
	{
		return default(MySqlDateTime).method_1(string_0);
	}

	private MySqlDateTime method_1(string string_0)
	{
		string[] array = string_0.Split('-', ' ', ':', '/', '.');
		int year = int.Parse(array[0]);
		int month = int.Parse(array[1]);
		int day = int.Parse(array[2]);
		int hour = 0;
		int minute = 0;
		int second = 0;
		int microsecond = 0;
		if (array.Length > 3)
		{
			hour = int.Parse(array[3]);
			minute = int.Parse(array[4]);
			second = int.Parse(array[5]);
		}
		if (array.Length > 6)
		{
			microsecond = int.Parse(array[6].PadRight(6, '0'));
		}
		return new MySqlDateTime(_type, year, month, day, hour, minute, second, microsecond);
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_0)
	{
		if (bool_0)
		{
			return new MySqlDateTime(_type, isNull: true);
		}
		if (long_0 >= 0L)
		{
			string string_ = class167_0.method_22(long_0);
			return method_1(string_);
		}
		long num = class167_0.method_1();
		int year = 0;
		int month = 0;
		int day = 0;
		int hour = 0;
		int minute = 0;
		int second = 0;
		int microsecond = 0;
		if (num >= 4L)
		{
			year = class167_0.method_13(2);
			month = class167_0.method_1();
			day = class167_0.method_1();
		}
		if (num > 4L)
		{
			hour = class167_0.method_1();
			minute = class167_0.method_1();
			second = class167_0.method_1();
		}
		if (num > 7L)
		{
			microsecond = class167_0.method_12();
			class167_0.method_1();
		}
		return new MySqlDateTime(_type, year, month, day, hour, minute, second, microsecond);
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = class167_0.method_1();
		class167_0.Position += num;
	}

	public DateTime method_2()
	{
		if (!IsValidDateTime)
		{
			throw new MySqlConversionException(getString_0(107358103));
		}
		DateTimeKind kind = DateTimeKind.Unspecified;
		if (_type == MySqlDbType.Timestamp)
		{
			kind = ((TimezoneOffset == 0) ? DateTimeKind.Utc : DateTimeKind.Local);
		}
		return new DateTime(Year, Month, Day, Hour, Minute, Second, kind).AddTicks(_microsecond * 10);
	}

	private static string smethod_2(string string_0, int int_0, int int_1, int int_2)
	{
		string_0 = string_0.Replace(getString_0(107358054), getString_0(107358017));
		string_0 = string_0.Replace(getString_0(107358008), getString_0(107358035));
		string_0 = string_0.Replace(getString_0(107358030), getString_0(107358025));
		string_0 = string_0.Replace(getString_0(107357984), getString_0(107357979));
		string_0 = string_0.Replace(getString_0(107357974), getString_0(107357997));
		string_0 = string_0.Replace(getString_0(107357952), getString_0(107357947));
		string_0 = string_0.Replace(getString_0(107357970), getString_0(107357965));
		int num = int_2 - int_2 / 1000 * 1000;
		num -= num / 100 * 100;
		int num2 = num - num / 10 * 10;
		return string.Format(string_0, int_0, int_1, int_2, num, num2);
	}

	string ValueType.ToString()
	{
		if (IsValidDateTime)
		{
			DateTime dateTime = new DateTime(Year, Month, Day, Hour, Minute, Second).AddTicks(_microsecond * 10);
			if (_type != MySqlDbType.Date)
			{
				return dateTime.ToString();
			}
			return dateTime.ToString(getString_0(107357984));
		}
		string text = smethod_2(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern, Month, Day, Year);
		if (_type == MySqlDbType.Date)
		{
			return text;
		}
		return string.Format(arg1: new DateTime(1, 2, 3, Hour, Minute, Second).AddTicks(_microsecond * 10).ToLongTimeString(), format: getString_0(107358436), arg0: text);
	}

	[SpecialName]
	public static DateTime smethod_3(MySqlDateTime mySqlDateTime_0)
	{
		if (!mySqlDateTime_0.IsValidDateTime)
		{
			return DateTime.MinValue;
		}
		return mySqlDateTime_0.method_2();
	}

	internal static void smethod_4(Class176 class176_0)
	{
		string[] array = new string[3]
		{
			getString_0(107407689),
			getString_0(107407658),
			getString_0(107407639)
		};
		MySqlDbType[] array2 = new MySqlDbType[3]
		{
			MySqlDbType.Date,
			MySqlDbType.DateTime,
			MySqlDbType.Timestamp
		};
		for (int i = 0; i < array.Length; i++)
		{
			Class177 @class = class176_0.method_4();
			@class[getString_0(107359328)] = array[i];
			@class[getString_0(107359347)] = array2[i];
			@class[getString_0(107359294)] = 0;
			@class[getString_0(107359309)] = array[i];
			@class[getString_0(107359260)] = null;
			@class[getString_0(107359235)] = getString_0(107358423);
			@class[getString_0(107358689)] = false;
			@class[getString_0(107358660)] = true;
			@class[getString_0(107358675)] = false;
			@class[getString_0(107358622)] = true;
			@class[getString_0(107358633)] = true;
			@class[getString_0(107358604)] = false;
			@class[getString_0(107358563)] = true;
			@class[getString_0(107358578)] = true;
			@class[getString_0(107358529)] = false;
			@class[getString_0(107358500)] = false;
			@class[getString_0(107358515)] = 0;
			@class[getString_0(107358466)] = 0;
			@class[getString_0(107358481)] = DBNull.Value;
			@class[getString_0(107358936)] = false;
			@class[getString_0(107358911)] = null;
			@class[getString_0(107358917)] = null;
			@class[getString_0(107358896)] = null;
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
		return method_2();
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

	static MySqlDateTime()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlDateTime));
	}
}
