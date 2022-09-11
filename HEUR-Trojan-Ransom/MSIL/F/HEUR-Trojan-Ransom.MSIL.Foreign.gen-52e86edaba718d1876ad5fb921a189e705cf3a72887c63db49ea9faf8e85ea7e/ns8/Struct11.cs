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

namespace ns8;

internal struct Struct11 : Interface0
{
	private readonly MySqlDbType mySqlDbType_0;

	private readonly double double_0;

	private readonly double double_1;

	private readonly int int_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly byte[] byte_0;

	[NonSerialized]
	internal static GetString getString_0;

	public double? XCoordinate => double_0;

	public double? YCoordinate => double_1;

	public int? SRID => int_0;

	MySqlDbType Interface0.MySqlDbType => mySqlDbType_0;

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	object Interface0.Value => Value;

	public byte[] Value
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
	}

	Type Interface0.SystemType => typeof(byte[]);

	string Interface0.MySqlTypeName => getString_0(107358319);

	public Struct11(bool bool_1)
		: this(MySqlDbType.Geometry, bool_1)
	{
	}

	public Struct11(double double_2, double double_3)
		: this(MySqlDbType.Geometry, double_2, double_3, 0)
	{
	}

	public Struct11(double double_2, double double_3, int int_1)
		: this(MySqlDbType.Geometry, double_2, double_3, int_1)
	{
	}

	internal Struct11(MySqlDbType mySqlDbType_1, bool bool_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		bool_1 = true;
		double_0 = 0.0;
		double_1 = 0.0;
		int_0 = 0;
		byte_0 = null;
		bool_0 = true;
	}

	internal Struct11(MySqlDbType mySqlDbType_1, double double_2, double double_3, int int_1)
	{
		mySqlDbType_0 = mySqlDbType_1;
		double_0 = double_2;
		double_1 = double_3;
		bool_0 = false;
		int_0 = int_1;
		byte_0 = new byte[25];
		byte[] bytes = BitConverter.GetBytes(int_1);
		for (int i = 0; i < bytes.Length; i++)
		{
			Value[i] = bytes[i];
		}
		long num = BitConverter.DoubleToInt64Bits(double_2);
		long num2 = BitConverter.DoubleToInt64Bits(double_3);
		Value[4] = 1;
		Value[5] = 1;
		for (int j = 0; j < 8; j++)
		{
			Value[j + 9] = (byte)((ulong)num & 0xFFuL);
			num >>= 8;
		}
		for (int k = 0; k < 8; k++)
		{
			Value[k + 17] = (byte)((ulong)num2 & 0xFFuL);
			num2 >>= 8;
		}
	}

	public Struct11(MySqlDbType mySqlDbType_1, byte[] byte_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException(getString_0(107358356));
		}
		byte[] array = new byte[byte_1.Length];
		for (int i = 0; i < byte_1.Length; i++)
		{
			array[i] = byte_1[i];
		}
		int startIndex = ((byte_1.Length == 25) ? 9 : 5);
		int startIndex2 = ((byte_1.Length == 25) ? 17 : 13);
		byte_0 = array;
		double_0 = BitConverter.ToDouble(byte_1, startIndex);
		double_1 = BitConverter.ToDouble(byte_1, startIndex2);
		int_0 = ((byte_1.Length == 25) ? BitConverter.ToInt32(byte_1, 0) : 0);
		bool_0 = false;
		mySqlDbType_0 = mySqlDbType_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_1, object object_0, int int_1)
	{
		byte[] array = null;
		try
		{
			array = ((Struct11)object_0).Value;
		}
		catch
		{
			array = object_0 as byte[];
		}
		if (array == null)
		{
			Struct11 struct11_ = new Struct11(0.0, 0.0);
			smethod_2(object_0.ToString(), out struct11_);
			array = struct11_.Value;
		}
		byte[] array2 = new byte[25];
		for (int i = 0; i < array.Length; i++)
		{
			if (array.Length < 25)
			{
				array2[i + 4] = array[i];
			}
			else
			{
				array2[i] = array[i];
			}
		}
		class167_0.method_18(getString_0(107359403));
		class167_0.method_3(39);
		smethod_0(array2, 25, class167_0);
		class167_0.method_3(39);
	}

	private static void smethod_0(byte[] byte_1, int int_1, Class167 class167_0)
	{
		for (int i = 0; i < int_1; i++)
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
		Struct11 @struct;
		if (bool_1)
		{
			@struct = new Struct11(mySqlDbType_0, bool_1: true);
		}
		else
		{
			if (long_0 == -1L)
			{
				long_0 = class167_0.method_8();
			}
			byte[] byte_ = new byte[long_0];
			class167_0.method_2(byte_, 0, (int)long_0);
			@struct = new Struct11(mySqlDbType_0, byte_);
		}
		return @struct;
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = (int)class167_0.method_8();
		class167_0.Position += num;
	}

	string ValueType.ToString()
	{
		if (!IsNull)
		{
			if (int_0 == 0)
			{
				return string.Format(CultureInfo.InvariantCulture.NumberFormat, getString_0(107358338), new object[2] { double_0, double_1 });
			}
			return string.Format(CultureInfo.InvariantCulture.NumberFormat, getString_0(107358285), new object[3] { double_0, double_1, int_0 });
		}
		return string.Empty;
	}

	public static Struct11 smethod_1(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException(getString_0(107392848));
		}
		if (!string_0.Contains(getString_0(107358252)) && !string_0.Contains(getString_0(107358275)) && !string_0.Contains(getString_0(107358266)))
		{
			throw new FormatException(getString_0(107358221));
		}
		Struct11 struct11_ = new Struct11(0.0, 0.0);
		smethod_2(string_0, out struct11_);
		return struct11_;
	}

	public static bool smethod_2(string string_0, out Struct11 struct11_0)
	{
		string[] array = new string[0];
		string text = string.Empty;
		bool flag = false;
		bool flag2 = false;
		double result = 0.0;
		double result2 = 0.0;
		int result3 = 0;
		try
		{
			if (string_0.Contains(getString_0(107408846)))
			{
				array = string_0.Split(new char[1] { ';' });
			}
			else
			{
				text = string_0;
			}
			if (array.Length > 1 || text != string.Empty)
			{
				string[] array2 = ((text != string.Empty) ? text : array[1]).Replace(getString_0(107358266), getString_0(107397895)).Replace(getString_0(107358275), getString_0(107397895)).Replace(getString_0(107409445), getString_0(107397895))
					.Split(new char[1] { ' ' });
				if (array2.Length > 1)
				{
					flag = double.TryParse(array2[0], out result);
					flag2 = double.TryParse(array2[1], out result2);
				}
				if (array.Length >= 1)
				{
					int.TryParse(array[0].Replace(getString_0(107357644), getString_0(107397895)), out result3);
				}
			}
			if (flag && flag2)
			{
				struct11_0 = new Struct11(result, result2, result3);
				return true;
			}
		}
		catch
		{
		}
		struct11_0 = new Struct11(bool_1: true);
		return false;
	}

	public static void smethod_3(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359343)] = getString_0(107358319);
		@class[getString_0(107359362)] = MySqlDbType.Geometry;
		@class[getString_0(107359309)] = 25;
		@class[getString_0(107359324)] = getString_0(107358319);
		@class[getString_0(107359275)] = DBNull.Value;
		@class[getString_0(107359250)] = getString_0(107359237);
		@class[getString_0(107358704)] = false;
		@class[getString_0(107358675)] = true;
		@class[getString_0(107358690)] = false;
		@class[getString_0(107358637)] = false;
		@class[getString_0(107358648)] = true;
		@class[getString_0(107358619)] = false;
		@class[getString_0(107358578)] = true;
		@class[getString_0(107358593)] = true;
		@class[getString_0(107358544)] = false;
		@class[getString_0(107358515)] = false;
		@class[getString_0(107358530)] = 0;
		@class[getString_0(107358481)] = 0;
		@class[getString_0(107358496)] = DBNull.Value;
		@class[getString_0(107358951)] = false;
		@class[getString_0(107358926)] = DBNull.Value;
		@class[getString_0(107358932)] = DBNull.Value;
		@class[getString_0(107358911)] = DBNull.Value;
	}

	public string method_0()
	{
		if (!IsNull)
		{
			return string.Format(CultureInfo.InvariantCulture.NumberFormat, getString_0(107358338), new object[2] { double_0, double_1 });
		}
		return string.Empty;
	}

	static Struct11()
	{
		Strings.CreateGetStringDelegate(typeof(Struct11));
	}
}
