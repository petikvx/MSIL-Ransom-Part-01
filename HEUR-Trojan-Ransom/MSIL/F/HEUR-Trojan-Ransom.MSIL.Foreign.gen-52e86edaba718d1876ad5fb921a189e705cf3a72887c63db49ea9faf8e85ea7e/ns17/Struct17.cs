using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns17;

internal struct Struct17 : Interface0
{
	private readonly MySqlDbType mySqlDbType_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly string string_0;

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

	MySqlDbType Interface0.MySqlDbType => mySqlDbType_0;

	object Interface0.Value => Value;

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
	}

	Type Interface0.SystemType => typeof(string);

	string Interface0.MySqlTypeName
	{
		get
		{
			if (mySqlDbType_0 != MySqlDbType.Set)
			{
				if (mySqlDbType_0 != MySqlDbType.Enum)
				{
					return getString_0(107359825);
				}
				return getString_0(107359240);
			}
			return getString_0(107359789);
		}
	}

	public Struct17(MySqlDbType mySqlDbType_1, bool bool_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		bool_0 = bool_1;
		string_0 = string.Empty;
	}

	public Struct17(MySqlDbType mySqlDbType_1, string string_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		bool_0 = false;
		string_0 = string_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		string text = object_0.ToString();
		if (int_0 > 0)
		{
			int_0 = Math.Min(int_0, text.Length);
			text = text.Substring(0, int_0);
		}
		if (bool_1)
		{
			class167_0.method_17(text);
		}
		else
		{
			class167_0.method_18(getString_0(107408185) + MySqlHelper.smethod_31(text) + getString_0(107408185));
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		if (bool_1)
		{
			return new Struct17(mySqlDbType_0, bool_1: true);
		}
		string empty = string.Empty;
		return new Struct17(string_1: (long_0 != -1L) ? class167_0.method_22(long_0) : class167_0.method_20(), mySqlDbType_1: mySqlDbType_0);
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = (int)class167_0.method_8();
		class167_0.Position += num;
	}

	internal static void smethod_0(Class176 class176_0)
	{
		string[] array = new string[10]
		{
			getString_0(107359802),
			getString_0(107357556),
			getString_0(107359825),
			getString_0(107357547),
			getString_0(107359789),
			getString_0(107359240),
			getString_0(107359113),
			getString_0(107407650),
			getString_0(107359143),
			getString_0(107359173)
		};
		MySqlDbType[] array2 = new MySqlDbType[10]
		{
			MySqlDbType.String,
			MySqlDbType.String,
			MySqlDbType.VarChar,
			MySqlDbType.VarChar,
			MySqlDbType.Set,
			MySqlDbType.Enum,
			MySqlDbType.TinyText,
			MySqlDbType.Text,
			MySqlDbType.MediumText,
			MySqlDbType.LongText
		};
		for (int i = 0; i < array.Length; i++)
		{
			Class177 @class = class176_0.method_4();
			@class[getString_0(107359365)] = array[i];
			@class[getString_0(107359384)] = array2[i];
			@class[getString_0(107359331)] = 0;
			@class[getString_0(107359346)] = ((i < 4) ? (array[i] + getString_0(107357502)) : array[i]);
			@class[getString_0(107359297)] = ((i < 4) ? getString_0(107357525) : null);
			@class[getString_0(107359272)] = getString_0(107357516);
			@class[getString_0(107358726)] = false;
			@class[getString_0(107358697)] = true;
			@class[getString_0(107358712)] = false;
			@class[getString_0(107358659)] = false;
			@class[getString_0(107358670)] = true;
			@class[getString_0(107358641)] = false;
			@class[getString_0(107358600)] = true;
			@class[getString_0(107358615)] = true;
			@class[getString_0(107358566)] = true;
			@class[getString_0(107358537)] = false;
			@class[getString_0(107358552)] = 0;
			@class[getString_0(107358503)] = 0;
			@class[getString_0(107358518)] = DBNull.Value;
			@class[getString_0(107358973)] = false;
			@class[getString_0(107358948)] = null;
			@class[getString_0(107358954)] = null;
			@class[getString_0(107358933)] = null;
		}
	}

	static Struct17()
	{
		Strings.CreateGetStringDelegate(typeof(Struct17));
	}
}
