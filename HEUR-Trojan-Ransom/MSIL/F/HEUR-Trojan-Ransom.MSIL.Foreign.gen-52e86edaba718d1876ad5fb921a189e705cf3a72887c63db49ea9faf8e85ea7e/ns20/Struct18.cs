using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns22;
using ns6;

namespace ns20;

internal struct Struct18 : Interface0
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private TimeSpan timeSpan_0;

	[NonSerialized]
	internal static GetString getString_0;

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Time;

	object Interface0.Value => Value;

	public TimeSpan Value
	{
		[CompilerGenerated]
		get
		{
			return timeSpan_0;
		}
		[CompilerGenerated]
		private set
		{
			timeSpan_0 = value;
		}
	}

	Type Interface0.SystemType => typeof(TimeSpan);

	string Interface0.MySqlTypeName => getString_0(107407688);

	public Struct18(bool bool_1)
	{
		IsNull = bool_1;
		Value = TimeSpan.MinValue;
	}

	public Struct18(TimeSpan timeSpan_1)
	{
		IsNull = false;
		Value = timeSpan_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		if (!(object_0 is TimeSpan timeSpan))
		{
			throw new MySqlException(getString_0(107357498));
		}
		bool flag = timeSpan.TotalMilliseconds < 0.0;
		TimeSpan timeSpan2 = timeSpan.Duration();
		if (bool_1)
		{
			if (timeSpan2.Milliseconds > 0)
			{
				class167_0.method_3(12);
			}
			else
			{
				class167_0.method_3(8);
			}
			class167_0.method_3((byte)(flag ? 1u : 0u));
			class167_0.method_14(timeSpan2.Days, 4);
			class167_0.method_3((byte)timeSpan2.Hours);
			class167_0.method_3((byte)timeSpan2.Minutes);
			class167_0.method_3((byte)timeSpan2.Seconds);
			if (timeSpan2.Milliseconds > 0)
			{
				long long_ = timeSpan2.Milliseconds * 1000;
				class167_0.method_14(long_, 4);
			}
		}
		else
		{
			string string_ = string.Format(getString_0(107357933), flag ? getString_0(107409366) : getString_0(107397920), timeSpan2.Days, timeSpan2.Hours, timeSpan2.Minutes, timeSpan2.Seconds, timeSpan2.Ticks % 10000000L / 10L);
			class167_0.method_18(string_);
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct18(bool_1: true);
		}
		if (long_0 >= 0L)
		{
			string string_ = class167_0.method_22(long_0);
			method_1(string_);
			return this;
		}
		long num = class167_0.method_1();
		int num2 = 0;
		if (num > 0L)
		{
			num2 = class167_0.method_1();
		}
		IsNull = false;
		switch (num)
		{
		case 0L:
			IsNull = true;
			break;
		case 5L:
			Value = new TimeSpan(class167_0.method_13(4), 0, 0, 0);
			break;
		case 8L:
			Value = new TimeSpan(class167_0.method_13(4), class167_0.method_1(), class167_0.method_1(), class167_0.method_1());
			break;
		default:
			Value = new TimeSpan(class167_0.method_13(4), class167_0.method_1(), class167_0.method_1(), class167_0.method_1(), class167_0.method_13(4) / 1000000);
			break;
		}
		if (num2 == 1)
		{
			Value = Value.Negate();
		}
		return this;
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = class167_0.method_1();
		class167_0.Position += num;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359368)] = getString_0(107407688);
		@class[getString_0(107359387)] = MySqlDbType.Time;
		@class[getString_0(107359334)] = 0;
		@class[getString_0(107359349)] = getString_0(107407688);
		@class[getString_0(107359300)] = null;
		@class[getString_0(107359275)] = getString_0(107357876);
		@class[getString_0(107358729)] = false;
		@class[getString_0(107358700)] = true;
		@class[getString_0(107358715)] = false;
		@class[getString_0(107358662)] = true;
		@class[getString_0(107358673)] = true;
		@class[getString_0(107358644)] = false;
		@class[getString_0(107358603)] = true;
		@class[getString_0(107358618)] = true;
		@class[getString_0(107358569)] = false;
		@class[getString_0(107358540)] = false;
		@class[getString_0(107358555)] = 0;
		@class[getString_0(107358506)] = 0;
		@class[getString_0(107358521)] = DBNull.Value;
		@class[getString_0(107358976)] = false;
		@class[getString_0(107358951)] = null;
		@class[getString_0(107358957)] = null;
		@class[getString_0(107358936)] = null;
	}

	string ValueType.ToString()
	{
		return string.Format(getString_0(107358786), Value.Days, Value.Hours, Value.Minutes, Value.Seconds);
	}

	private void method_1(string string_0)
	{
		string[] array = string_0.Split(':', '.');
		int num = int.Parse(array[0]);
		int num2 = int.Parse(array[1]);
		int num3 = int.Parse(array[2]);
		int num4 = 0;
		if (array.Length > 3)
		{
			array[3] = array[3].PadRight(7, '0');
			num4 = int.Parse(array[3]);
		}
		if (num < 0 || array[0].StartsWith(getString_0(107409366), StringComparison.Ordinal))
		{
			num2 *= -1;
			num3 *= -1;
			num4 *= -1;
		}
		int num5 = num / 24;
		num -= num5 * 24;
		Value = new TimeSpan(num5, num, num2, num3).Add(new TimeSpan(num4));
		IsNull = false;
	}

	static Struct18()
	{
		Strings.CreateGetStringDelegate(typeof(Struct18));
	}
}
