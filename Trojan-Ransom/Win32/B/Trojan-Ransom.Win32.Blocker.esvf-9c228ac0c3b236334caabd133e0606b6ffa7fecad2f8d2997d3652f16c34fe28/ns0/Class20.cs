using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class20
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

	private Class37 class37_0;

	private Class32 class32_0;

	public Class20()
		: this(int_2, bool_1: false)
	{
	}

	public Class20(int int_18)
		: this(int_18, bool_1: false)
	{
	}

	public Class20(int int_18, bool bool_1)
	{
		if (int_18 == int_2)
		{
			int_18 = 6;
		}
		else if (int_18 < int_3 || int_18 > int_0)
		{
			throw new ArgumentOutOfRangeException(Class46.smethod_0(18513733, 288402604, 1654622722));
		}
		class37_0 = new Class37();
		class32_0 = new Class32(class37_0);
		bool_0 = bool_1;
		method_11(Enum12.const_0);
		method_10(int_18);
		method_0();
	}

	public void method_0()
	{
		try
		{
			int_16 = (bool_0 ? int_10 : int_8);
			int_17 = 0;
			class37_0.method_0();
			class32_0.method_0();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_1()
	{
		try
		{
			return class32_0.method_2();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_2()
	{
		try
		{
			return class32_0.method_3();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_3()
	{
		try
		{
			return int_17;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public void method_4()
	{
		try
		{
			int_16 |= int_6;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public void method_5()
	{
		try
		{
			int_16 |= int_6 | int_7;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public bool method_6()
	{
		try
		{
			if (int_16 == int_13)
			{
				return class37_0.method_9();
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public bool method_7()
	{
		try
		{
			return class32_0.method_18();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public void method_8(byte[] byte_0)
	{
		try
		{
			method_9(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_0);
			throw;
		}
	}

	public void method_9(byte[] byte_0, int int_18, int int_19)
	{
		try
		{
			if ((int_16 & int_7) != 0)
			{
				throw new InvalidOperationException(Class46.smethod_0(524854235, 288402674, 1654622782));
			}
			class32_0.method_17(byte_0, int_18, int_19);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_0, int_18, int_19);
			throw;
		}
	}

	public void method_10(int int_18)
	{
		try
		{
			if (int_18 == int_2)
			{
				int_18 = 6;
			}
			else if (int_18 < int_3 || int_18 > int_0)
			{
				throw new ArgumentOutOfRangeException(Class46.smethod_0(870390621, 288402632, 1654622722));
			}
			if (int_15 != int_18)
			{
				int_15 = int_18;
				class32_0.method_6(int_18);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, int_18);
			throw;
		}
	}

	public void method_11(Enum12 enum12_0)
	{
		try
		{
			class32_0.method_5(enum12_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, enum12_0);
			throw;
		}
	}

	public int method_12(byte[] byte_0)
	{
		try
		{
			return method_13(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_0);
			throw;
		}
	}

	public int method_13(byte[] byte_0, int int_18, int int_19)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		try
		{
			num = int_19;
			if (int_16 == int_14)
			{
				throw new InvalidOperationException(Class46.smethod_0(1136792084, 288402610, 1654622746));
			}
			if (int_16 < int_10)
			{
				num2 = int_4 + 112 << 8;
				num3 = int_15 - 1 >> 1;
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
				class37_0.method_8(num2);
				if ((int_16 & int_5) != 0)
				{
					num4 = class32_0.method_2();
					class32_0.method_1();
					class37_0.method_8(num4 >> 16);
					class37_0.method_8(num4 & 0xFFFF);
				}
				int_16 = int_10 | (int_16 & (int_6 | int_7));
			}
			while (true)
			{
				num5 = class37_0.method_10(byte_0, int_18, int_19);
				int_18 += num5;
				int_17 += num5;
				int_19 -= num5;
				if (int_19 == 0 || int_16 == int_13)
				{
					break;
				}
				if (class32_0.method_16((int_16 & int_6) != 0, (int_16 & int_7) != 0))
				{
					continue;
				}
				if (int_16 != int_10)
				{
					if (int_16 == int_11)
					{
						if (int_15 != int_3)
						{
							for (num6 = 8 + (-class37_0.method_5() & 7); num6 > 0; num6 -= 10)
							{
								class37_0.method_7(2, 10);
							}
						}
						int_16 = int_10;
					}
					else if (int_16 == int_12)
					{
						class37_0.method_6();
						if (!bool_0)
						{
							num7 = class32_0.method_2();
							class37_0.method_8(num7 >> 16);
							class37_0.method_8(num7 & 0xFFFF);
						}
						int_16 = int_13;
					}
					continue;
				}
				return num - int_19;
			}
			return num - int_19;
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[11]
			{
				this, byte_0, int_18, int_19, num, num2, num3, num4, num5, num6,
				num7
			});
			throw;
		}
	}

	public void method_14(byte[] byte_0)
	{
		try
		{
			method_15(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_0);
			throw;
		}
	}

	public void method_15(byte[] byte_0, int int_18, int int_19)
	{
		try
		{
			if (int_16 != int_8)
			{
				throw new InvalidOperationException();
			}
			int_16 = int_9;
			class32_0.method_12(byte_0, int_18, int_19);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_0, int_18, int_19);
			throw;
		}
	}
}
