using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class33
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

	private Class30 class30_0;

	private Class29 class29_0;

	private Class24 class24_0;

	private Class25 class25_0;

	private Class25 class25_1;

	private Class13 class13_0;

	public Class33()
		: this(bool_2: false)
	{
	}

	public Class33(bool bool_2)
	{
		bool_1 = bool_2;
		class13_0 = new Class13();
		class30_0 = new Class30();
		class29_0 = new Class29();
		int_17 = (bool_2 ? 2 : 0);
	}

	public void method_0()
	{
		int num = default(int);
		try
		{
			int_17 = (bool_1 ? 2 : 0);
			num = (int_24 = (int_23 = 0));
			class30_0.method_8();
			class29_0.method_8();
			class24_0 = null;
			class25_0 = null;
			class25_1 = null;
			bool_0 = false;
			class13_0.imethod_1();
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	private bool method_1()
	{
		int num = default(int);
		try
		{
			num = class30_0.method_0(16);
			if (num < 0)
			{
				return false;
			}
			class30_0.method_1(16);
			num = ((num << 8) | (num >> 8)) & 0xFFFF;
			if (num % 31 != 0)
			{
				throw new FormatException(Class52.smethod_0(538280389, 1487824204, 1829032547));
			}
			if ((num & 0xF00) != Class20.int_4 << 8)
			{
				throw new FormatException(Class52.smethod_0(1777412888, 1487824248, 1829032569));
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
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	private bool method_2()
	{
		int num = default(int);
		try
		{
			while (true)
			{
				if (int_19 > 0)
				{
					num = class30_0.method_0(8);
					if (num < 0)
					{
						break;
					}
					class30_0.method_1(8);
					int_18 = (int_18 << 8) | num;
					int_19 -= 8;
					continue;
				}
				return false;
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	private bool method_3()
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		try
		{
			num = class29_0.method_5();
			while (num >= 258)
			{
				num2 = int_17;
				switch (num2)
				{
				case 7:
					while (((num3 = class25_0.method_1(class30_0)) & -256) == 0)
					{
						class29_0.method_0(num3);
						if (--num < 258)
						{
							return true;
						}
					}
					if (num3 >= 257)
					{
						try
						{
							int_20 = int_13[num3 - 257];
							int_19 = int_14[num3 - 257];
						}
						catch (Exception)
						{
							throw new FormatException(Class52.smethod_0(1439822154, 1487824372, 1829032547));
						}
						goto case 8;
					}
					if (num3 < 0)
					{
						return false;
					}
					class25_1 = null;
					class25_0 = null;
					int_17 = 2;
					return true;
				case 8:
					if (int_19 > 0)
					{
						int_17 = 8;
						num5 = class30_0.method_0(int_19);
						if (num5 < 0)
						{
							return false;
						}
						class30_0.method_1(int_19);
						int_20 += num5;
					}
					int_17 = 9;
					goto case 9;
				case 9:
					num3 = class25_1.method_1(class30_0);
					if (num3 >= 0)
					{
						try
						{
							int_21 = int_15[num3];
							int_19 = int_16[num3];
						}
						catch (Exception)
						{
							throw new FormatException(Class52.smethod_0(1361944079, 1487824154, 1829032551));
						}
						goto case 10;
					}
					return false;
				case 10:
					if (int_19 > 0)
					{
						int_17 = 10;
						num4 = class30_0.method_0(int_19);
						if (num4 < 0)
						{
							return false;
						}
						class30_0.method_1(int_19);
						int_21 += num4;
					}
					break;
				default:
					throw new FormatException();
				}
				class29_0.method_2(int_20, int_21);
				num -= int_20;
				int_17 = 7;
			}
			return true;
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, num, num3, num5, num4, num2);
			throw;
		}
	}

	private bool method_4()
	{
		int num = default(int);
		object[] array = default(object[]);
		try
		{
			while (true)
			{
				if (int_19 > 0)
				{
					num = class30_0.method_0(8);
					if (num < 0)
					{
						break;
					}
					class30_0.method_1(8);
					int_18 = (int_18 << 8) | num;
					int_19 -= 8;
					continue;
				}
				if ((int)class13_0.imethod_0() != int_18)
				{
					array = new object[4]
					{
						Class52.smethod_0(1899262671, 1487824316, 1829032565),
						(int)class13_0.imethod_0(),
						Class52.smethod_0(921155668, 1487824322, 1829032519),
						int_18
					};
					throw new FormatException(string.Concat(array));
				}
				int_17 = 12;
				return false;
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, num, array);
			throw;
		}
	}

	private bool method_5()
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		try
		{
			num = int_17;
			switch (num)
			{
			default:
				throw new FormatException();
			case 0:
				return method_1();
			case 1:
				return method_2();
			case 2:
				if (bool_0)
				{
					if (bool_1)
					{
						int_17 = 12;
						return false;
					}
					class30_0.method_5();
					int_19 = 32;
					int_17 = 11;
					return true;
				}
				num2 = class30_0.method_0(3);
				if (num2 < 0)
				{
					return false;
				}
				class30_0.method_1(3);
				if (((uint)num2 & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				num3 = num2 >> 1;
				switch (num3)
				{
				default:
					throw new FormatException(Class52.smethod_0(713354933, 1487823958, 1829032555) + num2);
				case 0:
					class30_0.method_5();
					int_17 = 3;
					break;
				case 1:
					class25_0 = Class25.class25_0;
					class25_1 = Class25.class25_1;
					int_17 = 7;
					break;
				case 2:
					class24_0 = new Class24();
					int_17 = 6;
					break;
				}
				return true;
			case 3:
				num4 = (int_22 = class30_0.method_0(16));
				if (num4 < 0)
				{
					return false;
				}
				class30_0.method_1(16);
				int_17 = 4;
				goto case 4;
			case 4:
				num6 = class30_0.method_0(16);
				if (num6 < 0)
				{
					return false;
				}
				class30_0.method_1(16);
				if (num6 != (int_22 ^ 0xFFFF))
				{
					throw new FormatException(Class52.smethod_0(913806555, 1487824260, 1829032575));
				}
				int_17 = 5;
				goto case 5;
			case 5:
				num5 = class29_0.method_3(class30_0, int_22);
				int_22 -= num5;
				if (int_22 == 0)
				{
					int_17 = 2;
					return true;
				}
				return !class30_0.method_6();
			case 6:
				if (!class24_0.method_0(class30_0))
				{
					return false;
				}
				class25_0 = class24_0.method_1();
				class25_1 = class24_0.method_2();
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
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, this, num2, num6, num5, num, num3, num4);
			throw;
		}
	}

	public void method_6(byte[] byte_0)
	{
		try
		{
			method_7(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_0);
			throw;
		}
	}

	public void method_7(byte[] byte_0, int int_25, int int_26)
	{
		try
		{
			if (!method_13())
			{
				throw new InvalidOperationException();
			}
			class13_0.imethod_4(byte_0, int_25, int_26);
			if ((int)class13_0.imethod_0() != int_18)
			{
				throw new ArgumentException(Class52.smethod_0(1591326360, 1487823916, 1829032549));
			}
			class13_0.imethod_1();
			class29_0.method_4(byte_0, int_25, int_26);
			int_17 = 2;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_0, int_25, int_26);
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

	public void method_9(byte[] byte_0, int int_25, int int_26)
	{
		try
		{
			class30_0.method_9(byte_0, int_25, int_26);
			int_24 += int_26;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_0, int_25, int_26);
			throw;
		}
	}

	public int method_10(byte[] byte_0)
	{
		try
		{
			return method_11(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_0);
			throw;
		}
	}

	public int method_11(byte[] byte_0, int int_25, int int_26)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			if (int_26 < 0)
			{
				throw new ArgumentOutOfRangeException(Class52.smethod_0(1513885993, 1487823876, 1829032515));
			}
			if (int_26 == 0)
			{
				return 0;
			}
			num = 0;
			do
			{
				if (int_17 != 11)
				{
					num2 = class29_0.method_7(byte_0, int_25, int_26);
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
			while (method_5() || (class29_0.method_6() > 0 && int_17 != 11));
			return num;
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, byte_0, int_25, int_26, num, num2);
			throw;
		}
	}

	[SpecialName]
	public bool method_12()
	{
		try
		{
			return class30_0.method_6();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public bool method_13()
	{
		try
		{
			if (int_17 == 1)
			{
				return int_19 == 0;
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
	public bool method_14()
	{
		try
		{
			if (int_17 == 12)
			{
				return class29_0.method_6() == 0;
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
	public int method_15()
	{
		try
		{
			if (!method_13())
			{
				return (int)class13_0.imethod_0();
			}
			return int_18;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_16()
	{
		try
		{
			return int_23;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_17()
	{
		try
		{
			return int_24 - method_18();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_18()
	{
		try
		{
			return class30_0.method_4();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}
}
