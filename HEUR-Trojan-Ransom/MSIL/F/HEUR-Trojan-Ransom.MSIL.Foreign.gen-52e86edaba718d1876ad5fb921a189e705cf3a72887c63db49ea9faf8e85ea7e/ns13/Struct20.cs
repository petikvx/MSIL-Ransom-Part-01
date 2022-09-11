using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns13;

internal struct Struct20 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly ushort ushort_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.UInt16;

	object Interface0.Value => Value;

	public ushort Value
	{
		[CompilerGenerated]
		get
		{
			return ushort_0;
		}
	}

	Type Interface0.SystemType => typeof(ushort);

	string Interface0.MySqlTypeName => getString_0(107408599);

	public Struct20(bool bool_1)
	{
		bool_0 = bool_1;
		ushort_0 = 0;
	}

	public Struct20(ushort ushort_1)
	{
		bool_0 = false;
		ushort_0 = ushort_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		int num = ((object_0 is ushort) ? ((ushort)object_0) : Convert.ToUInt16(object_0));
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
			return new Struct20(bool_1: true);
		}
		if (long_0 == -1L)
		{
			return new Struct20((ushort)class167_0.method_13(2));
		}
		return new Struct20(ushort.Parse(class167_0.method_22(long_0)));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 2;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359374)] = getString_0(107408599);
		@class[getString_0(107359393)] = MySqlDbType.UInt16;
		@class[getString_0(107359340)] = 0;
		@class[getString_0(107359355)] = getString_0(107408424);
		@class[getString_0(107359306)] = null;
		@class[getString_0(107359281)] = getString_0(107357799);
		@class[getString_0(107358735)] = true;
		@class[getString_0(107358706)] = true;
		@class[getString_0(107358721)] = false;
		@class[getString_0(107358668)] = true;
		@class[getString_0(107358679)] = true;
		@class[getString_0(107358650)] = false;
		@class[getString_0(107358609)] = true;
		@class[getString_0(107358624)] = true;
		@class[getString_0(107358575)] = false;
		@class[getString_0(107358546)] = true;
		@class[getString_0(107358561)] = 0;
		@class[getString_0(107358512)] = 0;
		@class[getString_0(107358527)] = DBNull.Value;
		@class[getString_0(107358982)] = false;
		@class[getString_0(107358957)] = null;
		@class[getString_0(107358963)] = null;
		@class[getString_0(107358942)] = null;
	}

	static Struct20()
	{
		Strings.CreateGetStringDelegate(typeof(Struct20));
	}
}
