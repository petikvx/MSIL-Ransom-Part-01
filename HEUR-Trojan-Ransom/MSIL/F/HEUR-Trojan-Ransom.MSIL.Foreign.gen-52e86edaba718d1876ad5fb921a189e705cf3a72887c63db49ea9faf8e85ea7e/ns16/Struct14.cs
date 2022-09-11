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

namespace ns16;

internal struct Struct14 : Interface0
{
	private readonly int int_0;

	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

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

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Int32;

	object Interface0.Value => int_0;

	public int Value => int_0;

	Type Interface0.SystemType => typeof(int);

	string Interface0.MySqlTypeName
	{
		get
		{
			if (!bool_0)
			{
				return getString_0(107408566);
			}
			return getString_0(107408535);
		}
	}

	private Struct14(MySqlDbType mySqlDbType_0)
	{
		bool_0 = mySqlDbType_0 == MySqlDbType.Int24;
		bool_1 = true;
		int_0 = 0;
	}

	public Struct14(MySqlDbType mySqlDbType_0, bool bool_2)
		: this(mySqlDbType_0)
	{
		bool_1 = bool_2;
	}

	public Struct14(MySqlDbType mySqlDbType_0, int int_1)
		: this(mySqlDbType_0)
	{
		bool_1 = false;
		int_0 = int_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_2, object object_0, int int_1)
	{
		int num = (object_0 as int?) ?? Convert.ToInt32(object_0);
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
			return new Struct14(((Interface0)this).MySqlDbType, bool_2: true);
		}
		if (long_0 == -1L)
		{
			return new Struct14(((Interface0)this).MySqlDbType, class167_0.method_13(4));
		}
		return new Struct14(((Interface0)this).MySqlDbType, int.Parse(class167_0.method_22(long_0), CultureInfo.InvariantCulture));
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.Position += 4;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		string[] array = new string[3]
		{
			getString_0(107408566),
			getString_0(107359788),
			getString_0(107408535)
		};
		MySqlDbType[] array2 = new MySqlDbType[3]
		{
			MySqlDbType.Int32,
			MySqlDbType.Year,
			MySqlDbType.Int24
		};
		for (int i = 0; i < array.Length; i++)
		{
			Class177 @class = class176_0.method_4();
			@class[getString_0(107359355)] = array[i];
			@class[getString_0(107359374)] = array2[i];
			@class[getString_0(107359321)] = 0;
			@class[getString_0(107359336)] = array[i];
			@class[getString_0(107359287)] = null;
			@class[getString_0(107359262)] = getString_0(107357601);
			@class[getString_0(107358716)] = array2[i] != MySqlDbType.Year;
			@class[getString_0(107358687)] = true;
			@class[getString_0(107358702)] = false;
			@class[getString_0(107358649)] = true;
			@class[getString_0(107358660)] = true;
			@class[getString_0(107358631)] = false;
			@class[getString_0(107358590)] = true;
			@class[getString_0(107358605)] = true;
			@class[getString_0(107358556)] = false;
			@class[getString_0(107358527)] = false;
			@class[getString_0(107358542)] = 0;
			@class[getString_0(107358493)] = 0;
			@class[getString_0(107358508)] = DBNull.Value;
			@class[getString_0(107358963)] = false;
			@class[getString_0(107358938)] = null;
			@class[getString_0(107358944)] = null;
			@class[getString_0(107358923)] = null;
		}
	}

	static Struct14()
	{
		Strings.CreateGetStringDelegate(typeof(Struct14));
	}
}
