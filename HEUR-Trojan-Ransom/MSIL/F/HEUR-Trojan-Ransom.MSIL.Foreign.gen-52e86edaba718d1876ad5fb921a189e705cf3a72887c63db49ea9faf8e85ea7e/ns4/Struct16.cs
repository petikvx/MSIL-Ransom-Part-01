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

namespace ns4;

internal struct Struct16 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly float float_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Float;

	object Interface0.Value => Value;

	public float Value
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
	}

	Type Interface0.SystemType => typeof(float);

	string Interface0.MySqlTypeName => getString_0(107408529);

	public Struct16(bool bool_1)
	{
		bool_0 = bool_1;
		float_0 = 0f;
	}

	public Struct16(float float_1)
	{
		bool_0 = false;
		float_0 = float_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		float value = (object_0 as float?) ?? Convert.ToSingle(object_0);
		if (bool_1)
		{
			class167_0.method_4(BitConverter.GetBytes(value));
		}
		else
		{
			class167_0.method_18(value.ToString(getString_0(107358368), CultureInfo.InvariantCulture));
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct16(bool_1: true);
		}
		if (long_0 == -1L)
		{
			byte[] array = new byte[4];
			class167_0.method_2(array, 0, 4);
			return new Struct16(BitConverter.ToSingle(array, 0));
		}
		return new Struct16(float.Parse(class167_0.method_22(long_0), CultureInfo.InvariantCulture));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 4;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359361)] = getString_0(107408529);
		@class[getString_0(107359380)] = MySqlDbType.Float;
		@class[getString_0(107359327)] = 0;
		@class[getString_0(107359342)] = getString_0(107408529);
		@class[getString_0(107359293)] = null;
		@class[getString_0(107359268)] = getString_0(107357541);
		@class[getString_0(107358722)] = false;
		@class[getString_0(107358693)] = true;
		@class[getString_0(107358708)] = false;
		@class[getString_0(107358655)] = true;
		@class[getString_0(107358666)] = true;
		@class[getString_0(107358637)] = false;
		@class[getString_0(107358596)] = true;
		@class[getString_0(107358611)] = true;
		@class[getString_0(107358562)] = false;
		@class[getString_0(107358533)] = false;
		@class[getString_0(107358548)] = 0;
		@class[getString_0(107358499)] = 0;
		@class[getString_0(107358514)] = DBNull.Value;
		@class[getString_0(107358969)] = false;
		@class[getString_0(107358944)] = null;
		@class[getString_0(107358950)] = null;
		@class[getString_0(107358929)] = null;
	}

	static Struct16()
	{
		Strings.CreateGetStringDelegate(typeof(Struct16));
	}
}
