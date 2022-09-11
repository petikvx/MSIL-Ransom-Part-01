using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns15;

internal struct Struct9 : Interface0
{
	private readonly string string_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private byte byte_0;

	[CompilerGenerated]
	private byte byte_1;

	[NonSerialized]
	internal static GetString getString_0;

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Decimal;

	public byte Precision
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

	public byte Scale
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

	object Interface0.Value => Value;

	public decimal Value => Convert.ToDecimal(string_0, CultureInfo.InvariantCulture);

	Type Interface0.SystemType => typeof(decimal);

	string Interface0.MySqlTypeName => getString_0(107408451);

	internal Struct9(bool bool_1)
	{
		bool_0 = bool_1;
		string_0 = null;
		Scale = 0;
		Precision = 0;
	}

	internal Struct9(string string_1)
	{
		bool_0 = false;
		Scale = 0;
		Precision = 0;
		string_0 = string_1;
	}

	public double method_0()
	{
		return double.Parse(string_0);
	}

	string ValueType.ToString()
	{
		return string_0;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		string text = ((object_0 as decimal?) ?? Convert.ToDecimal(object_0)).ToString(CultureInfo.InvariantCulture);
		if (bool_1)
		{
			class167_0.method_17(text);
		}
		else
		{
			class167_0.method_18(text);
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct9(bool_1: true);
		}
		return new Struct9((long_0 == -1L) ? class167_0.method_20() : class167_0.method_22(long_0));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = (int)class167_0.method_8();
		class167_0.Position += num;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359333)] = getString_0(107408451);
		@class[getString_0(107359352)] = MySqlDbType.NewDecimal;
		@class[getString_0(107359299)] = 0;
		@class[getString_0(107359314)] = getString_0(107358407);
		@class[getString_0(107359265)] = getString_0(107358414);
		@class[getString_0(107359240)] = getString_0(107358393);
		@class[getString_0(107358694)] = false;
		@class[getString_0(107358665)] = true;
		@class[getString_0(107358680)] = false;
		@class[getString_0(107358627)] = true;
		@class[getString_0(107358638)] = true;
		@class[getString_0(107358609)] = false;
		@class[getString_0(107358568)] = true;
		@class[getString_0(107358583)] = true;
		@class[getString_0(107358534)] = false;
		@class[getString_0(107358505)] = false;
		@class[getString_0(107358520)] = 0;
		@class[getString_0(107358471)] = 0;
		@class[getString_0(107358486)] = DBNull.Value;
		@class[getString_0(107358941)] = false;
		@class[getString_0(107358916)] = null;
		@class[getString_0(107358922)] = null;
		@class[getString_0(107358901)] = null;
	}

	static Struct9()
	{
		Strings.CreateGetStringDelegate(typeof(Struct9));
	}
}
