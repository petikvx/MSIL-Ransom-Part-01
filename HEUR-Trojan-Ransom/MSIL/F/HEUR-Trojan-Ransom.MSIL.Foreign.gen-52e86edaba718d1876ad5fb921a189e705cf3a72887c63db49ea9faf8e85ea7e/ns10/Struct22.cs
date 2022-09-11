using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns10;

internal struct Struct22 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly ulong ulong_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.UInt64;

	object Interface0.Value => Value;

	public ulong Value
	{
		[CompilerGenerated]
		get
		{
			return ulong_0;
		}
	}

	Type Interface0.SystemType => typeof(ulong);

	string Interface0.MySqlTypeName => getString_0(107408535);

	public Struct22(bool bool_1)
	{
		bool_0 = bool_1;
		ulong_0 = 0uL;
	}

	public Struct22(ulong ulong_1)
	{
		bool_0 = false;
		ulong_0 = ulong_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		ulong long_ = (object_0 as ulong?) ?? Convert.ToUInt64(object_0);
		if (bool_1)
		{
			class167_0.method_14((long)long_, 8);
		}
		else
		{
			class167_0.method_18(long_.ToString());
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct22(bool_1: true);
		}
		if (long_0 == -1L)
		{
			return new Struct22(class167_0.method_11(8));
		}
		return new Struct22(ulong.Parse(class167_0.method_22(long_0)));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 8;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359381)] = getString_0(107408535);
		@class[getString_0(107359400)] = MySqlDbType.UInt64;
		@class[getString_0(107359347)] = 0;
		@class[getString_0(107359362)] = getString_0(107407876);
		@class[getString_0(107359313)] = null;
		@class[getString_0(107359288)] = getString_0(107357751);
		@class[getString_0(107358742)] = true;
		@class[getString_0(107358713)] = true;
		@class[getString_0(107358728)] = false;
		@class[getString_0(107358675)] = true;
		@class[getString_0(107358686)] = true;
		@class[getString_0(107358657)] = false;
		@class[getString_0(107358616)] = true;
		@class[getString_0(107358631)] = true;
		@class[getString_0(107358582)] = false;
		@class[getString_0(107358553)] = true;
		@class[getString_0(107358568)] = 0;
		@class[getString_0(107358519)] = 0;
		@class[getString_0(107358534)] = DBNull.Value;
		@class[getString_0(107358989)] = false;
		@class[getString_0(107358964)] = null;
		@class[getString_0(107358970)] = null;
		@class[getString_0(107358949)] = null;
	}

	static Struct22()
	{
		Strings.CreateGetStringDelegate(typeof(Struct22));
	}
}
