using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class12
{
	public static int int_0 = 9;

	public static int int_1 = 1;

	public static int int_2 = -1;

	public static int int_3 = 0;

	public static int int_4 = 8;

	private static int int_5 = 1;

	private static int int_6 = 4;

	private static int int_7 = 8;

	private static int int_8 = 0;

	private static int int_9 = 1;

	private static int int_10 = 16;

	private static int int_11 = 20;

	private static int int_12 = 28;

	private static int int_13 = 30;

	private static int int_14 = 127;

	private int int_15;

	private bool bool_0;

	private int int_16;

	private int int_17;

	private Class27 class27_0;

	private Class22 class22_0;

	public Class12()
		: this(int_2, bool_1: false)
	{
	}

	public Class12(int int_18)
		: this(int_18, bool_1: false)
	{
	}

	public Class12(int int_18, bool bool_1)
	{
		if (int_18 == int_2)
		{
			int_18 = 6;
		}
		else if (int_18 < int_3 || int_18 > int_0)
		{
			throw new ArgumentOutOfRangeException(Class36.smethod_0(1865616018, 382658142, 2088753297));
		}
		class27_0 = new Class27();
		class22_0 = new Class22(class27_0);
		bool_0 = bool_1;
		method_11(Enum11.const_0);
		method_10(int_18);
		method_0();
	}

	public void method_0()
	{
		int_16 = (bool_0 ? int_10 : int_8);
		int_17 = 0;
		class27_0.method_0();
		class22_0.method_0();
	}

	[SpecialName]
	public int method_1()
	{
		return class22_0.method_2();
	}

	[SpecialName]
	public int method_2()
	{
		return class22_0.method_3();
	}

	[SpecialName]
	public int method_3()
	{
		return int_17;
	}

	public void method_4()
	{
		int_16 |= int_6;
	}

	public void method_5()
	{
		int_16 |= int_6 | int_7;
	}

	[SpecialName]
	public bool method_6()
	{
		if (int_16 == int_13)
		{
			return class27_0.method_9();
		}
		return false;
	}

	[SpecialName]
	public bool method_7()
	{
		return class22_0.method_18();
	}

	public void method_8(byte[] byte_0)
	{
		method_9(byte_0, 0, byte_0.Length);
	}

	public void method_9(byte[] byte_0, int int_18, int int_19)
	{
		if ((int_16 & int_7) != 0)
		{
			throw new InvalidOperationException(Class36.smethod_0(2105729943, 382658048, 2088753325));
		}
		class22_0.method_17(byte_0, int_18, int_19);
	}

	public void method_10(int int_18)
	{
		if (int_18 == int_2)
		{
			int_18 = 6;
		}
		else if (int_18 < int_3 || int_18 > int_0)
		{
			throw new ArgumentOutOfRangeException(Class36.smethod_0(122723044, 382658106, 2088753297));
		}
		if (int_15 != int_18)
		{
			int_15 = int_18;
			class22_0.method_6(int_18);
		}
	}

	public void method_11(Enum11 enum11_0)
	{
		class22_0.method_5(enum11_0);
	}

	public int method_12(byte[] byte_0)
	{
		return method_13(byte_0, 0, byte_0.Length);
	}

	public int method_13(byte[] byte_0, int int_18, int int_19)
	{
		int num = int_19;
		if (int_16 == int_14)
		{
			throw new InvalidOperationException(Class36.smethod_0(811316148, 382658112, 2088753289));
		}
		if (int_16 < int_10)
		{
			int num2 = int_4 + 112 << 8;
			int num3 = int_15 - 1 >> 1;
			if (num3 < 0 || num3 > 3)
			{
				num3 = 3;
			}
			num2 |= num3 << 6;
			if ((int_16 & int_5) != 0)
			{
				num2 |= 0x20;
			}
			num2 += 31 - num2 % 31;
			class27_0.method_8(num2);
			if ((int_16 & int_5) != 0)
			{
				int num4 = class22_0.method_2();
				class22_0.method_1();
				class27_0.method_8(num4 >> 16);
				class27_0.method_8(num4 & 0xFFFF);
			}
			int_16 = int_10 | (int_16 & (int_6 | int_7));
		}
		while (true)
		{
			int num5 = class27_0.method_10(byte_0, int_18, int_19);
			int_18 += num5;
			int_17 += num5;
			int_19 -= num5;
			if (int_19 == 0 || int_16 == int_13)
			{
				break;
			}
			if (class22_0.method_16((int_16 & int_6) != 0, (int_16 & int_7) != 0))
			{
				continue;
			}
			if (int_16 != int_10)
			{
				if (int_16 == int_11)
				{
					if (int_15 != int_3)
					{
						for (int num6 = 8 + (-class27_0.method_5() & 7); num6 > 0; num6 -= 10)
						{
							class27_0.method_7(2, 10);
						}
					}
					int_16 = int_10;
				}
				else if (int_16 == int_12)
				{
					class27_0.method_6();
					if (!bool_0)
					{
						int num7 = class22_0.method_2();
						class27_0.method_8(num7 >> 16);
						class27_0.method_8(num7 & 0xFFFF);
					}
					int_16 = int_13;
				}
				continue;
			}
			return num - int_19;
		}
		return num - int_19;
	}

	public void method_14(byte[] byte_0)
	{
		method_15(byte_0, 0, byte_0.Length);
	}

	public void method_15(byte[] byte_0, int int_18, int int_19)
	{
		if (int_16 != int_8)
		{
			throw new InvalidOperationException();
		}
		int_16 = int_9;
		class22_0.method_12(byte_0, int_18, int_19);
	}
}
