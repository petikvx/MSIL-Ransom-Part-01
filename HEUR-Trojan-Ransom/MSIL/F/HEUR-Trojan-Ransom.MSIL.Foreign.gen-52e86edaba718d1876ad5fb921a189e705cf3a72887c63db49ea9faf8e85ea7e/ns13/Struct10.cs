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

namespace ns13;

internal struct Struct10 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly double double_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Double;

	object Interface0.Value => Value;

	public double Value
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
	}

	Type Interface0.SystemType => typeof(double);

	string Interface0.MySqlTypeName => getString_0(107408495);

	public Struct10(bool bool_1)
	{
		bool_0 = bool_1;
		double_0 = 0.0;
	}

	public Struct10(double double_1)
	{
		bool_0 = false;
		double_0 = double_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		double value = (object_0 as double?) ?? Convert.ToDouble(object_0);
		if (bool_1)
		{
			class167_0.method_4(BitConverter.GetBytes(value));
		}
		else
		{
			class167_0.method_18(value.ToString(getString_0(107358343), CultureInfo.InvariantCulture));
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct10(bool_1: true);
		}
		if (long_0 == -1L)
		{
			byte[] array = new byte[8];
			class167_0.method_2(array, 0, 8);
			return new Struct10(BitConverter.ToDouble(array, 0));
		}
		string text = class167_0.method_22(long_0);
		double double_;
		try
		{
			double_ = double.Parse(text, CultureInfo.InvariantCulture);
		}
		catch (OverflowException)
		{
			double_ = ((!text.StartsWith(getString_0(107409334), StringComparison.Ordinal)) ? double.MaxValue : double.MinValue);
		}
		return new Struct10(double_);
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 8;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359336)] = getString_0(107408495);
		@class[getString_0(107359355)] = MySqlDbType.Double;
		@class[getString_0(107359302)] = 0;
		@class[getString_0(107359317)] = getString_0(107408495);
		@class[getString_0(107359268)] = null;
		@class[getString_0(107359243)] = getString_0(107358338);
		@class[getString_0(107358697)] = false;
		@class[getString_0(107358668)] = true;
		@class[getString_0(107358683)] = false;
		@class[getString_0(107358630)] = true;
		@class[getString_0(107358641)] = true;
		@class[getString_0(107358612)] = false;
		@class[getString_0(107358571)] = true;
		@class[getString_0(107358586)] = true;
		@class[getString_0(107358537)] = false;
		@class[getString_0(107358508)] = false;
		@class[getString_0(107358523)] = 0;
		@class[getString_0(107358474)] = 0;
		@class[getString_0(107358489)] = DBNull.Value;
		@class[getString_0(107358944)] = false;
		@class[getString_0(107358919)] = null;
		@class[getString_0(107358925)] = null;
		@class[getString_0(107358904)] = null;
	}

	static Struct10()
	{
		Strings.CreateGetStringDelegate(typeof(Struct10));
	}
}
