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

internal struct Struct19 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly byte byte_0;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.UByte;

	object Interface0.Value => Value;

	public byte Value
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
	}

	Type Interface0.SystemType => typeof(byte);

	string Interface0.MySqlTypeName => getString_0(107408577);

	public Struct19(bool bool_1)
	{
		bool_0 = bool_1;
		byte_0 = 0;
	}

	public Struct19(byte byte_1)
	{
		bool_0 = false;
		byte_0 = byte_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		byte byte_ = (object_0 as byte?) ?? Convert.ToByte(object_0);
		if (bool_1)
		{
			class167_0.method_3(byte_);
		}
		else
		{
			class167_0.method_18(byte_.ToString());
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct19(bool_1: true);
		}
		if (long_0 == -1L)
		{
			return new Struct19(class167_0.method_1());
		}
		return new Struct19(byte.Parse(class167_0.method_22(long_0)));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.method_1();
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359371)] = getString_0(107357826);
		@class[getString_0(107359390)] = MySqlDbType.UByte;
		@class[getString_0(107359337)] = 0;
		@class[getString_0(107359352)] = getString_0(107408478);
		@class[getString_0(107359303)] = null;
		@class[getString_0(107359278)] = getString_0(107357845);
		@class[getString_0(107358732)] = true;
		@class[getString_0(107358703)] = true;
		@class[getString_0(107358718)] = false;
		@class[getString_0(107358665)] = true;
		@class[getString_0(107358676)] = true;
		@class[getString_0(107358647)] = false;
		@class[getString_0(107358606)] = true;
		@class[getString_0(107358621)] = true;
		@class[getString_0(107358572)] = false;
		@class[getString_0(107358543)] = true;
		@class[getString_0(107358558)] = 0;
		@class[getString_0(107358509)] = 0;
		@class[getString_0(107358524)] = DBNull.Value;
		@class[getString_0(107358979)] = false;
		@class[getString_0(107358954)] = null;
		@class[getString_0(107358960)] = null;
		@class[getString_0(107358939)] = null;
	}

	static Struct19()
	{
		Strings.CreateGetStringDelegate(typeof(Struct19));
	}
}
