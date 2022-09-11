using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns19;

internal struct Struct13 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly short short_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Int16;

	object Interface0.Value => Value;

	public short Value
	{
		[CompilerGenerated]
		get
		{
			return short_0;
		}
	}

	Type Interface0.SystemType => typeof(short);

	string Interface0.MySqlTypeName => getString_0(107408576);

	public Struct13(bool bool_1)
	{
		bool_0 = bool_1;
		short_0 = 0;
	}

	public Struct13(short short_1)
	{
		bool_0 = false;
		short_0 = short_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		int num = (object_0 as int?) ?? Convert.ToInt32(object_0);
		if (bool_1)
		{
			class167_0.method_14(num, 2);
		}
		else
		{
			class167_0.method_18(num.ToString());
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct13(bool_1: true);
		}
		if (long_0 == -1L)
		{
			return new Struct13((short)class167_0.method_13(2));
		}
		return new Struct13(short.Parse(class167_0.method_22(long_0)));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 2;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359351)] = getString_0(107408576);
		@class[getString_0(107359370)] = MySqlDbType.Int16;
		@class[getString_0(107359317)] = 0;
		@class[getString_0(107359332)] = getString_0(107408576);
		@class[getString_0(107359283)] = null;
		@class[getString_0(107359258)] = getString_0(107357582);
		@class[getString_0(107358712)] = true;
		@class[getString_0(107358683)] = true;
		@class[getString_0(107358698)] = false;
		@class[getString_0(107358645)] = true;
		@class[getString_0(107358656)] = true;
		@class[getString_0(107358627)] = false;
		@class[getString_0(107358586)] = true;
		@class[getString_0(107358601)] = true;
		@class[getString_0(107358552)] = false;
		@class[getString_0(107358523)] = false;
		@class[getString_0(107358538)] = 0;
		@class[getString_0(107358489)] = 0;
		@class[getString_0(107358504)] = DBNull.Value;
		@class[getString_0(107358959)] = false;
		@class[getString_0(107358934)] = null;
		@class[getString_0(107358940)] = null;
		@class[getString_0(107358919)] = null;
	}

	static Struct13()
	{
		Strings.CreateGetStringDelegate(typeof(Struct13));
	}
}
