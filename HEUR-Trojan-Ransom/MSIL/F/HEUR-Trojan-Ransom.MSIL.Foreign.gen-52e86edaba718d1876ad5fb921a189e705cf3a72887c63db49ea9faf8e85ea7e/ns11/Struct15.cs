using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns11;

internal struct Struct15 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly long long_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Int64;

	object Interface0.Value => Value;

	public long Value
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
	}

	Type Interface0.SystemType => typeof(long);

	string Interface0.MySqlTypeName => getString_0(107408512);

	public Struct15(bool bool_1)
	{
		bool_0 = bool_1;
		long_0 = 0L;
	}

	public Struct15(long long_1)
	{
		bool_0 = false;
		long_0 = long_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		long num = (object_0 as long?) ?? Convert.ToInt64(object_0);
		if (bool_1)
		{
			class167_0.method_14(num, 8);
		}
		else
		{
			class167_0.method_18(num.ToString());
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_1, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct15(bool_1: true);
		}
		if (long_1 == -1L)
		{
			return new Struct15((long)class167_0.method_11(8));
		}
		return new Struct15(long.Parse(class167_0.method_22(long_1)));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 8;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359358)] = getString_0(107408512);
		@class[getString_0(107359377)] = MySqlDbType.Int64;
		@class[getString_0(107359324)] = 0;
		@class[getString_0(107359339)] = getString_0(107408512);
		@class[getString_0(107359290)] = null;
		@class[getString_0(107359265)] = getString_0(107357555);
		@class[getString_0(107358719)] = true;
		@class[getString_0(107358690)] = true;
		@class[getString_0(107358705)] = false;
		@class[getString_0(107358652)] = true;
		@class[getString_0(107358663)] = true;
		@class[getString_0(107358634)] = false;
		@class[getString_0(107358593)] = true;
		@class[getString_0(107358608)] = true;
		@class[getString_0(107358559)] = false;
		@class[getString_0(107358530)] = false;
		@class[getString_0(107358545)] = 0;
		@class[getString_0(107358496)] = 0;
		@class[getString_0(107358511)] = DBNull.Value;
		@class[getString_0(107358966)] = false;
		@class[getString_0(107358941)] = null;
		@class[getString_0(107358947)] = null;
		@class[getString_0(107358926)] = null;
	}

	static Struct15()
	{
		Strings.CreateGetStringDelegate(typeof(Struct15));
	}
}
