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

namespace ns19;

internal struct Struct21 : Interface0
{
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly uint uint_0;

	[NonSerialized]
	internal static GetString getString_0;

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
	}

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.UInt32;

	object Interface0.Value => Value;

	public uint Value
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
	}

	Type Interface0.SystemType => typeof(uint);

	string Interface0.MySqlTypeName
	{
		get
		{
			if (!bool_0)
			{
				return getString_0(107408589);
			}
			return getString_0(107408558);
		}
	}

	private Struct21(MySqlDbType mySqlDbType_0)
	{
		bool_0 = mySqlDbType_0 == MySqlDbType.Int24;
		bool_1 = true;
		uint_0 = 0u;
	}

	public Struct21(MySqlDbType mySqlDbType_0, bool bool_2)
		: this(mySqlDbType_0)
	{
		bool_1 = bool_2;
	}

	public Struct21(MySqlDbType mySqlDbType_0, uint uint_1)
		: this(mySqlDbType_0)
	{
		bool_1 = false;
		uint_0 = uint_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_2, object object_0, int int_0)
	{
		uint num = (object_0 as uint?) ?? Convert.ToUInt32(object_0);
		if (bool_2)
		{
			class167_0.method_14(num, bool_0 ? 3 : 4);
		}
		else
		{
			class167_0.method_18(num.ToString());
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_2)
	{
		if (bool_2)
		{
			return new Struct21(((Interface0)this).MySqlDbType, bool_2: true);
		}
		if (long_0 == -1L)
		{
			return new Struct21(((Interface0)this).MySqlDbType, (uint)class167_0.method_13(4));
		}
		return new Struct21(((Interface0)this).MySqlDbType, uint.Parse(class167_0.method_22(long_0), NumberStyles.Any, CultureInfo.InvariantCulture));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 4;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		string[] array = new string[2]
		{
			getString_0(107408558),
			getString_0(107408589)
		};
		MySqlDbType[] array2 = new MySqlDbType[2]
		{
			MySqlDbType.UInt24,
			MySqlDbType.UInt32
		};
		for (int i = 0; i < array.Length; i++)
		{
			Class177 @class = class176_0.method_4();
			@class[getString_0(107359378)] = array[i];
			@class[getString_0(107359397)] = array2[i];
			@class[getString_0(107359344)] = 0;
			@class[getString_0(107359359)] = array[i] + getString_0(107357782);
			@class[getString_0(107359310)] = null;
			@class[getString_0(107359285)] = getString_0(107357769);
			@class[getString_0(107358739)] = true;
			@class[getString_0(107358710)] = true;
			@class[getString_0(107358725)] = false;
			@class[getString_0(107358672)] = true;
			@class[getString_0(107358683)] = true;
			@class[getString_0(107358654)] = false;
			@class[getString_0(107358613)] = true;
			@class[getString_0(107358628)] = true;
			@class[getString_0(107358579)] = false;
			@class[getString_0(107358550)] = true;
			@class[getString_0(107358565)] = 0;
			@class[getString_0(107358516)] = 0;
			@class[getString_0(107358531)] = DBNull.Value;
			@class[getString_0(107358986)] = false;
			@class[getString_0(107358961)] = null;
			@class[getString_0(107358967)] = null;
			@class[getString_0(107358946)] = null;
		}
	}

	static Struct21()
	{
		Strings.CreateGetStringDelegate(typeof(Struct21));
	}
}
