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

internal struct Struct7 : Interface0
{
	private ulong ulong_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[NonSerialized]
	internal static GetString getString_0;

	public bool ReadAsString
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		private set
		{
			bool_1 = value;
		}
	}

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Bit;

	object Interface0.Value => ulong_0;

	Type Interface0.SystemType => typeof(ulong);

	string Interface0.MySqlTypeName => getString_0(107359177);

	public Struct7(bool bool_2)
	{
		ulong_0 = 0uL;
		IsNull = bool_2;
		ReadAsString = false;
	}

	public void imethod_0(Class167 class167_0, bool bool_2, object object_0, int int_0)
	{
		ulong long_ = (object_0 as ulong?) ?? Convert.ToUInt64(object_0);
		if (bool_2)
		{
			class167_0.method_14((long)long_, 8);
		}
		else
		{
			class167_0.method_18(long_.ToString());
		}
	}

	public Interface0 imethod_1(Class167 class167_0, long long_0, bool bool_2)
	{
		IsNull = bool_2;
		if (bool_2)
		{
			return this;
		}
		if (long_0 == -1L)
		{
			long_0 = class167_0.method_8();
		}
		if (ReadAsString)
		{
			ulong_0 = ulong.Parse(class167_0.method_22(long_0));
		}
		else
		{
			ulong_0 = class167_0.method_9((int)long_0);
		}
		return this;
	}

	public void imethod_2(Class167 class167_0)
	{
		int num = (int)class167_0.method_8();
		class167_0.Position += num;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359311)] = getString_0(107359177);
		@class[getString_0(107359330)] = MySqlDbType.Bit;
		@class[getString_0(107359277)] = 64;
		@class[getString_0(107359292)] = getString_0(107359177);
		@class[getString_0(107359243)] = DBNull.Value;
		@class[getString_0(107359218)] = typeof(ulong).ToString();
		@class[getString_0(107358672)] = false;
		@class[getString_0(107358643)] = true;
		@class[getString_0(107358658)] = false;
		@class[getString_0(107358605)] = false;
		@class[getString_0(107358616)] = true;
		@class[getString_0(107358587)] = false;
		@class[getString_0(107358546)] = true;
		@class[getString_0(107358561)] = true;
		@class[getString_0(107358512)] = false;
		@class[getString_0(107358483)] = false;
		@class[getString_0(107358498)] = 0;
		@class[getString_0(107358449)] = 0;
		@class[getString_0(107358464)] = DBNull.Value;
		@class[getString_0(107358919)] = false;
		@class[getString_0(107358894)] = DBNull.Value;
		@class[getString_0(107358900)] = DBNull.Value;
		@class[getString_0(107358879)] = DBNull.Value;
	}

	static Struct7()
	{
		Strings.CreateGetStringDelegate(typeof(Struct7));
	}
}
