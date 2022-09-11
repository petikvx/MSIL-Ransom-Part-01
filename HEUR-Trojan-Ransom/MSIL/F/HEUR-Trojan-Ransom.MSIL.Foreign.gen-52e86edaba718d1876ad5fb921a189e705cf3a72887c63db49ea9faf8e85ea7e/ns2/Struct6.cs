using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns22;
using ns6;

namespace ns2;

internal struct Struct6 : Interface0
{
	private readonly MySqlDbType mySqlDbType_0;

	private readonly byte[] byte_0;

	[CompilerGenerated]
	private readonly bool bool_0;

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

	object Interface0.Value => byte_0;

	public byte[] Value => byte_0;

	Type Interface0.SystemType => typeof(byte[]);

	string Interface0.MySqlTypeName => mySqlDbType_0 switch
	{
		MySqlDbType.TinyBlob => getString_0(107358983), 
		MySqlDbType.MediumBlob => getString_0(107359002), 
		MySqlDbType.LongBlob => getString_0(107358953), 
		_ => getString_0(107359137), 
	};

	public Struct6(MySqlDbType mySqlDbType_1, bool bool_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		bool_0 = bool_1;
		byte_0 = null;
	}

	public Struct6(MySqlDbType mySqlDbType_1, byte[] byte_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		bool_0 = false;
		byte_0 = byte_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_0)
	{
		byte[] array = object_0 as byte[];
		if (array == null)
		{
			if (object_0 is char[] chars)
			{
				array = class167_0.Encoding.GetBytes(chars);
			}
			else
			{
				string text = object_0.ToString();
				if (int_0 == 0)
				{
					int_0 = text.Length;
				}
				else
				{
					text = text.Substring(0, int_0);
				}
				array = class167_0.Encoding.GetBytes(text);
			}
		}
		if (int_0 == 0)
		{
			int_0 = array.Length;
		}
		if (array == null)
		{
			throw new MySqlException(getString_0(107358972));
		}
		if (bool_1)
		{
			class167_0.method_16(int_0);
			class167_0.method_5(array, 0, int_0);
			return;
		}
		class167_0.method_18(getString_0(107359367));
		class167_0.method_3(39);
		smethod_0(array, int_0, class167_0);
		class167_0.method_3(39);
	}

	private static void smethod_0(byte[] byte_1, int int_0, Class167 class167_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			byte b = byte_1[i];
			switch (b)
			{
			case 0:
				class167_0.method_3(92);
				class167_0.method_3(48);
				break;
			default:
				class167_0.method_3(b);
				break;
			case 34:
			case 39:
			case 92:
				class167_0.method_3(92);
				class167_0.method_3(b);
				break;
			}
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_1)
	{
		Struct6 @struct;
		if (bool_1)
		{
			@struct = new Struct6(mySqlDbType_0, bool_1: true);
		}
		else
		{
			if (long_0 == -1L)
			{
				long_0 = class167_0.method_8();
			}
			byte[] byte_ = new byte[long_0];
			class167_0.method_2(byte_, 0, (int)long_0);
			@struct = new Struct6(mySqlDbType_0, byte_);
		}
		return @struct;
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = (int)class167_0.method_8();
		class167_0.Position += num;
	}

	public static void smethod_1(Class176 class176_0)
	{
		string[] array = new string[6]
		{
			getString_0(107359137),
			getString_0(107359100),
			getString_0(107359134),
			getString_0(107359160),
			getString_0(107359042),
			getString_0(107359065)
		};
		MySqlDbType[] array2 = new MySqlDbType[6]
		{
			MySqlDbType.Blob,
			MySqlDbType.TinyBlob,
			MySqlDbType.MediumBlob,
			MySqlDbType.LongBlob,
			MySqlDbType.Binary,
			MySqlDbType.VarBinary
		};
		long[] array3 = new long[6] { 65535L, 255L, 16777215L, 4294967295L, 255L, 65535L };
		string[] array4 = new string[6]
		{
			null,
			null,
			null,
			null,
			getString_0(107359386),
			getString_0(107359337)
		};
		string[] array5 = new string[6]
		{
			null,
			null,
			null,
			null,
			getString_0(107359348),
			getString_0(107359348)
		};
		for (int i = 0; i < array.Length; i++)
		{
			Class177 @class = class176_0.method_4();
			@class[getString_0(107359307)] = array[i];
			@class[getString_0(107359326)] = array2[i];
			@class[getString_0(107359273)] = array3[i];
			@class[getString_0(107359288)] = array4[i];
			@class[getString_0(107359239)] = array5[i];
			@class[getString_0(107359214)] = getString_0(107359201);
			@class[getString_0(107358668)] = false;
			@class[getString_0(107358639)] = true;
			@class[getString_0(107358654)] = false;
			@class[getString_0(107358601)] = i >= 4;
			@class[getString_0(107358612)] = false;
			@class[getString_0(107358583)] = array3[i] > 255L;
			@class[getString_0(107358542)] = true;
			@class[getString_0(107358557)] = false;
			@class[getString_0(107358508)] = false;
			@class[getString_0(107358479)] = DBNull.Value;
			@class[getString_0(107358494)] = DBNull.Value;
			@class[getString_0(107358445)] = DBNull.Value;
			@class[getString_0(107358460)] = DBNull.Value;
			@class[getString_0(107358915)] = false;
			@class[getString_0(107358890)] = getString_0(107358901);
			@class[getString_0(107358896)] = DBNull.Value;
			@class[getString_0(107358875)] = DBNull.Value;
		}
	}

	static Struct6()
	{
		Strings.CreateGetStringDelegate(typeof(Struct6));
	}
}
