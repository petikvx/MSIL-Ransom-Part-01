using System;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal class Class31
{
	private const int int_0 = 0;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private const int int_3 = 3;

	private const int int_4 = 4;

	private const int int_5 = 5;

	private const int int_6 = 6;

	private const int int_7 = 7;

	private const int int_8 = 8;

	private const int int_9 = 9;

	private const int int_10 = 10;

	private const int int_11 = 11;

	private const int int_12 = 12;

	private static int[] int_13 = new int[29]
	{
		3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
		15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
		67, 83, 99, 115, 131, 163, 195, 227, 258
	};

	private static int[] int_14 = new int[29]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
		4, 4, 4, 4, 5, 5, 5, 5, 0
	};

	private static int[] int_15 = new int[30]
	{
		1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
		33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
		1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
	};

	private static int[] int_16 = new int[30]
	{
		0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
		4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
		9, 9, 10, 10, 11, 11, 12, 12, 13, 13
	};

	private int int_17;

	private int int_18;

	private int int_19;

	private int int_20;

	private int int_21;

	private int int_22;

	private bool bool_0;

	private int int_23;

	private int int_24;

	private bool bool_1;

	private Class22 class22_0;

	private Class34 class34_0;

	private Class20 class20_0;

	private Class21 class21_0;

	private Class21 class21_1;

	private Class13 class13_0;

	public Class31()
		: this(bool_2: false)
	{
	}

	public Class31(bool bool_2)
	{
		bool_1 = bool_2;
		class13_0 = new Class13();
		class22_0 = new Class22();
		class34_0 = new Class34();
		int_17 = (bool_2 ? 2 : 0);
	}

	public void method_0()
	{
		int_17 = (bool_1 ? 2 : 0);
		int_23 = 0;
		int_24 = 0;
		class22_0.method_8();
		class34_0.method_8();
		class20_0 = null;
		class21_0 = null;
		class21_1 = null;
		bool_0 = false;
		class13_0.imethod_1();
	}

	private bool method_1()
	{
		int num = class22_0.method_0(16);
		if (num < 0)
		{
			return false;
		}
		class22_0.method_1(16);
		num = ((num << 8) | (num >> 8)) & 0xFFFF;
		if (num % 31 != 0)
		{
			throw new FormatException(Class40.smethod_0(1556401473, 1687546225, 111587401));
		}
		if ((num & 0xF00) != Class15.int_4 << 8)
		{
			throw new FormatException(Class40.smethod_0(1241150088, 1687546181, 111587411));
		}
		if ((num & 0x20) == 0)
		{
			int_17 = 2;
		}
		else
		{
			int_17 = 1;
			int_19 = 32;
		}
		return true;
	}

	private bool method_2()
	{
		while (true)
		{
			if (int_19 > 0)
			{
				int num = class22_0.method_0(8);
				if (num < 0)
				{
					break;
				}
				class22_0.method_1(8);
				int_18 = (int_18 << 8) | num;
				int_19 -= 8;
				continue;
			}
			return false;
		}
		return false;
	}

	private bool method_3()
	{
		int num = class34_0.method_5();
		while (num >= 258)
		{
			switch (int_17)
			{
			case 7:
			{
				int num2;
				while (((num2 = class21_0.method_1(class22_0)) & -256) == 0)
				{
					class34_0.method_0(num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					try
					{
						int_20 = int_13[num2 - 257];
						int_19 = int_14[num2 - 257];
					}
					catch (Exception)
					{
						throw new FormatException(Class40.smethod_0(15301468, 1687546313, 111587401));
					}
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class21_1 = null;
				class21_0 = null;
				int_17 = 2;
				return true;
			}
			case 8:
				if (int_19 > 0)
				{
					int_17 = 8;
					int num4 = class22_0.method_0(int_19);
					if (num4 < 0)
					{
						return false;
					}
					class22_0.method_1(int_19);
					int_20 += num4;
				}
				int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = class21_1.method_1(class22_0);
				if (num2 >= 0)
				{
					try
					{
						int_21 = int_15[num2];
						int_19 = int_16[num2];
					}
					catch (Exception)
					{
						throw new FormatException(Class40.smethod_0(358732622, 1687546151, 111587405));
					}
					goto case 10;
				}
				return false;
			}
			case 10:
				if (int_19 > 0)
				{
					int_17 = 10;
					int num3 = class22_0.method_0(int_19);
					if (num3 < 0)
					{
						return false;
					}
					class22_0.method_1(int_19);
					int_21 += num3;
				}
				break;
			default:
				throw new FormatException();
			}
			class34_0.method_2(int_20, int_21);
			num -= int_20;
			int_17 = 7;
		}
		return true;
	}

	private bool method_4()
	{
		while (true)
		{
			if (int_19 > 0)
			{
				int num = class22_0.method_0(8);
				if (num < 0)
				{
					break;
				}
				class22_0.method_1(8);
				int_18 = (int_18 << 8) | num;
				int_19 -= 8;
				continue;
			}
			if ((int)class13_0.imethod_0() != int_18)
			{
				throw new FormatException(Class40.smethod_0(479760167, 1687546241, 111587423) + (int)class13_0.imethod_0() + Class40.smethod_0(225830013, 1687546367, 111587437) + int_18);
			}
			int_17 = 12;
			return false;
		}
		return false;
	}

	private bool method_5()
	{
		switch (int_17)
		{
		default:
			throw new FormatException();
		case 0:
			return method_1();
		case 1:
			return method_2();
		case 2:
		{
			if (bool_0)
			{
				if (bool_1)
				{
					int_17 = 12;
					return false;
				}
				class22_0.method_5();
				int_19 = 32;
				int_17 = 11;
				return true;
			}
			int num = class22_0.method_0(3);
			if (num < 0)
			{
				return false;
			}
			class22_0.method_1(3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				bool_0 = true;
			}
			switch (num >> 1)
			{
			default:
				throw new FormatException(Class40.smethod_0(1786209016, 1687545963, 111587393) + num);
			case 0:
				class22_0.method_5();
				int_17 = 3;
				break;
			case 1:
				class21_0 = Class21.class21_0;
				class21_1 = Class21.class21_1;
				int_17 = 7;
				break;
			case 2:
				class20_0 = new Class20();
				int_17 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((int_22 = class22_0.method_0(16)) < 0)
			{
				return false;
			}
			class22_0.method_1(16);
			int_17 = 4;
			goto case 4;
		case 4:
		{
			int num3 = class22_0.method_0(16);
			if (num3 < 0)
			{
				return false;
			}
			class22_0.method_1(16);
			if (num3 != (int_22 ^ 0xFFFF))
			{
				throw new FormatException(Class40.smethod_0(1604088323, 1687546297, 111587413));
			}
			int_17 = 5;
			goto case 5;
		}
		case 5:
		{
			int num2 = class34_0.method_3(class22_0, int_22);
			int_22 -= num2;
			if (int_22 == 0)
			{
				int_17 = 2;
				return true;
			}
			return !class22_0.method_6();
		}
		case 6:
			if (!class20_0.method_0(class22_0))
			{
				return false;
			}
			class21_0 = class20_0.method_1();
			class21_1 = class20_0.method_2();
			int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return method_3();
		case 11:
			return method_4();
		case 12:
			return false;
		}
	}

	public void method_6(byte[] byte_0)
	{
		method_7(byte_0, 0, byte_0.Length);
	}

	public void method_7(byte[] byte_0, int int_25, int int_26)
	{
		if (!method_13())
		{
			throw new InvalidOperationException();
		}
		class13_0.imethod_4(byte_0, int_25, int_26);
		if ((int)class13_0.imethod_0() != int_18)
		{
			throw new ArgumentException(Class40.smethod_0(354611674, 1687545873, 111587407));
		}
		class13_0.imethod_1();
		class34_0.method_4(byte_0, int_25, int_26);
		int_17 = 2;
	}

	public void method_8(byte[] byte_0)
	{
		method_9(byte_0, 0, byte_0.Length);
	}

	public void method_9(byte[] byte_0, int int_25, int int_26)
	{
		class22_0.method_9(byte_0, int_25, int_26);
		int_24 += int_26;
	}

	public int method_10(byte[] byte_0)
	{
		return method_11(byte_0, 0, byte_0.Length);
	}

	public int method_11(byte[] byte_0, int int_25, int int_26)
	{
		if (int_26 < 0)
		{
			throw new ArgumentOutOfRangeException(Class40.smethod_0(2088113457, 1687545913, 111587433));
		}
		if (int_26 == 0)
		{
			return 0;
		}
		int num = 0;
		do
		{
			if (int_17 != 11)
			{
				int num2 = class34_0.method_7(byte_0, int_25, int_26);
				class13_0.imethod_4(byte_0, int_25, num2);
				int_25 += num2;
				num += num2;
				int_23 += num2;
				int_26 -= num2;
				if (int_26 == 0)
				{
					return num;
				}
			}
		}
		while (method_5() || (class34_0.method_6() > 0 && int_17 != 11));
		return num;
	}

	[SpecialName]
	public bool method_12()
	{
		return class22_0.method_6();
	}

	[SpecialName]
	public bool method_13()
	{
		if (int_17 == 1)
		{
			return int_19 == 0;
		}
		return false;
	}

	[SpecialName]
	public bool method_14()
	{
		if (int_17 == 12)
		{
			return class34_0.method_6() == 0;
		}
		return false;
	}

	[SpecialName]
	public int method_15()
	{
		if (!method_13())
		{
			return (int)class13_0.imethod_0();
		}
		return int_18;
	}

	[SpecialName]
	public int method_16()
	{
		return int_23;
	}

	[SpecialName]
	public int method_17()
	{
		return int_24 - method_18();
	}

	[SpecialName]
	public int method_18()
	{
		return class22_0.method_4();
	}
}
