using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class32 : Class31
{
	private static int int_26 = 4096;

	private int int_27;

	private short[] short_0;

	private short[] short_1;

	private int int_28;

	private int int_29;

	private bool bool_1;

	private int int_30;

	private int int_31;

	private int int_32;

	private byte[] byte_0;

	private Enum12 enum12_0;

	private int int_33;

	private int int_34;

	private int int_35;

	private int int_36;

	private int int_37;

	private byte[] byte_1;

	private int int_38;

	private int int_39;

	private int int_40;

	private Class37 class37_0;

	private Class34 class34_0;

	private Class13 class13_0;

	public Class32(Class37 class37_1)
	{
		class37_0 = class37_1;
		class34_0 = new Class34(class37_1);
		class13_0 = new Class13();
		byte_0 = new byte[65536];
		short_0 = new short[32768];
		short_1 = new short[32768];
		int_30 = (int_31 = 1);
	}

	public void method_0()
	{
		int num = default(int);
		int i = default(int);
		int j = default(int);
		try
		{
			class34_0.method_0();
			class13_0.imethod_1();
			num = (int_30 = (int_31 = 1));
			int_32 = 0;
			int_38 = 0;
			bool_1 = false;
			int_29 = 2;
			for (i = 0; i < 32768; i++)
			{
				short_0[i] = 0;
			}
			for (j = 0; j < 32768; j++)
			{
				short_1[j] = 0;
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, i, j, num);
			throw;
		}
	}

	public void method_1()
	{
		try
		{
			class13_0.imethod_1();
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
			return (int)class13_0.imethod_0();
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
			return int_38;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public Enum12 method_4()
	{
		try
		{
			return enum12_0;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public void method_5(Enum12 enum12_1)
	{
		try
		{
			enum12_0 = enum12_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, enum12_1);
			throw;
		}
	}

	public void method_6(int int_41)
	{
		int num = default(int);
		try
		{
			int_36 = Class31.int_21[int_41];
			int_34 = Class31.int_22[int_41];
			int_35 = Class31.int_23[int_41];
			int_33 = Class31.int_24[int_41];
			if (Class31.int_25[int_41] == int_37)
			{
				return;
			}
			num = int_37;
			switch (num)
			{
			case 0:
				if (int_31 > int_30)
				{
					class34_0.method_5(byte_0, int_30, int_31 - int_30, bool_0: false);
					int_30 = int_31;
				}
				method_7();
				break;
			case 1:
				if (int_31 > int_30)
				{
					class34_0.method_6(byte_0, int_30, int_31 - int_30, bool_0: false);
					int_30 = int_31;
				}
				break;
			case 2:
				if (bool_1)
				{
					class34_0.method_8(byte_0[int_31 - 1] & 0xFF);
				}
				if (int_31 > int_30)
				{
					class34_0.method_6(byte_0, int_30, int_31 - int_30, bool_0: false);
					int_30 = int_31;
				}
				bool_1 = false;
				int_29 = 2;
				break;
			}
			int_37 = Class31.int_25[int_41];
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_41, num);
			throw;
		}
	}

	private void method_7()
	{
		try
		{
			int_27 = (byte_0[int_31] << 5) ^ byte_0[int_31 + 1];
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	private int method_8()
	{
		int num = default(int);
		short num2 = default(short);
		try
		{
			num = ((int_27 << 5) ^ byte_0[int_31 + 2]) & 0x7FFF;
			num2 = (short_1[int_31 & 0x7FFF] = short_0[num]);
			short_0[num] = (short)int_31;
			int_27 = num;
			return num2 & 0xFFFF;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, num2, num);
			throw;
		}
	}

	private void method_9()
	{
		int i = default(int);
		int num = default(int);
		int j = default(int);
		int num2 = default(int);
		try
		{
			Array.Copy(byte_0, 32768, byte_0, 0, 32768);
			int_28 -= 32768;
			int_31 -= 32768;
			int_30 -= 32768;
			for (i = 0; i < 32768; i++)
			{
				num = short_0[i] & 0xFFFF;
				short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (j = 0; j < 32768; j++)
			{
				num2 = short_1[j] & 0xFFFF;
				short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, i, num, j, num2);
			throw;
		}
	}

	public void method_10()
	{
		int num = default(int);
		try
		{
			if (int_31 >= 65274)
			{
				method_9();
			}
			while (int_32 < 262 && int_39 < int_40)
			{
				num = 65536 - int_32 - int_31;
				if (num > int_40 - int_39)
				{
					num = int_40 - int_39;
				}
				Array.Copy(byte_1, int_39, byte_0, int_31 + int_32, num);
				class13_0.imethod_4(byte_1, int_39, num);
				int_39 += num;
				int_38 += num;
				int_32 += num;
			}
			if (int_32 >= 3)
			{
				method_7();
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	private bool method_11(int int_41)
	{
		int num = default(int);
		int num2 = default(int);
		short[] array = default(short[]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte b = default(byte);
		byte b2 = default(byte);
		int num8 = default(int);
		try
		{
			num = int_33;
			num2 = int_35;
			array = short_1;
			num3 = int_31;
			num4 = int_31 + int_29;
			num5 = Math.Max(int_29, 2);
			num6 = Math.Max(int_31 - 32506, 0);
			num7 = int_31 + 258 - 1;
			b = byte_0[num4 - 1];
			b2 = byte_0[num4];
			if (num5 >= int_36)
			{
				num >>= 2;
			}
			if (num2 > int_32)
			{
				num2 = int_32;
			}
			do
			{
				if (byte_0[int_41 + num5] != b2 || byte_0[int_41 + num5 - 1] != b || byte_0[int_41] != byte_0[num3] || byte_0[int_41 + 1] != byte_0[num3 + 1])
				{
					continue;
				}
				num8 = int_41 + 2;
				num3 += 2;
				while (byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					int_28 = int_41;
					num4 = num3;
					num5 = num3 - int_31;
					if (num5 >= num2)
					{
						break;
					}
					b = byte_0[num4 - 1];
					b2 = byte_0[num4];
				}
				num3 = int_31;
			}
			while ((int_41 = array[int_41 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			int_29 = Math.Min(num5, int_32);
			return int_29 >= 3;
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[13]
			{
				this, int_41, num, num2, array, num3, num8, num4, num5, num6,
				num7, b, b2
			});
			throw;
		}
	}

	public void method_12(byte[] byte_2, int int_41, int int_42)
	{
		try
		{
			class13_0.imethod_4(byte_2, int_41, int_42);
			if (int_42 >= 3)
			{
				if (int_42 > 32506)
				{
					int_41 += int_42 - 32506;
					int_42 = 32506;
				}
				Array.Copy(byte_2, int_41, byte_0, int_31, int_42);
				method_7();
				int_42--;
				while (--int_42 > 0)
				{
					method_8();
					int_31++;
				}
				int_31 += 2;
				int_30 = int_31;
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_2, int_41, int_42);
			throw;
		}
	}

	private bool method_13(bool bool_2, bool bool_3)
	{
		int num = default(int);
		bool flag = default(bool);
		try
		{
			if (!bool_2 && int_32 == 0)
			{
				return false;
			}
			int_31 += int_32;
			int_32 = 0;
			num = int_31 - int_30;
			if (num < Class31.int_20 && (int_30 >= 32768 || num < 32506) && !bool_2)
			{
				return true;
			}
			flag = bool_3;
			if (num > Class31.int_20)
			{
				num = Class31.int_20;
				flag = false;
			}
			class34_0.method_5(byte_0, int_30, num, flag);
			int_30 += num;
			return !flag;
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, bool_2, bool_3, num, flag);
			throw;
		}
	}

	private bool method_14(bool bool_2, bool bool_3)
	{
		int num = default(int);
		int num2 = default(int);
		bool flag = default(bool);
		try
		{
			if (int_32 < 262 && !bool_2)
			{
				return false;
			}
			while (true)
			{
				if (int_32 >= 262 || bool_2)
				{
					if (int_32 != 0)
					{
						if (int_31 > 65274)
						{
							method_9();
						}
						if (int_32 >= 3 && (num = method_8()) != 0 && enum12_0 != Enum12.const_2 && int_31 - num <= 32506 && method_11(num))
						{
							class34_0.method_9(int_31 - int_28, int_29);
							int_32 -= int_29;
							if (int_29 <= int_34 && int_32 >= 3)
							{
								while (true)
								{
									num2 = --int_29;
									if (num2 <= 0)
									{
										break;
									}
									int_31++;
									method_8();
								}
								int_31++;
							}
							else
							{
								int_31 += int_29;
								if (int_32 >= 2)
								{
									method_7();
								}
							}
							int_29 = 2;
						}
						else
						{
							class34_0.method_8(byte_0[int_31] & 0xFF);
							int_31++;
							int_32--;
							if (class34_0.method_7())
							{
								break;
							}
						}
						continue;
					}
					class34_0.method_6(byte_0, int_30, int_31 - int_30, bool_3);
					int_30 = int_31;
					return false;
				}
				return true;
			}
			flag = bool_3 && int_32 == 0;
			class34_0.method_6(byte_0, int_30, int_31 - int_30, flag);
			int_30 = int_31;
			return !flag;
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, bool_2, bool_3, num, flag, num2);
			throw;
		}
	}

	private bool method_15(bool bool_2, bool bool_3)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		try
		{
			if (int_32 < 262 && !bool_2)
			{
				return false;
			}
			do
			{
				if (int_32 >= 262 || bool_2)
				{
					if (int_32 != 0)
					{
						if (int_31 >= 65274)
						{
							method_9();
						}
						num = int_28;
						num2 = int_29;
						if (int_32 >= 3)
						{
							num3 = method_8();
							if (enum12_0 != Enum12.const_2 && num3 != 0 && int_31 - num3 <= 32506 && method_11(num3) && int_29 <= 5 && (enum12_0 == Enum12.const_1 || (int_29 == 3 && int_31 - int_28 > int_26)))
							{
								int_29 = 2;
							}
						}
						if (num2 >= 3 && int_29 <= num2)
						{
							class34_0.method_9(int_31 - 1 - num, num2);
							num2 -= 2;
							do
							{
								int_31++;
								int_32--;
								if (int_32 >= 3)
								{
									method_8();
								}
							}
							while (--num2 > 0);
							int_31++;
							int_32--;
							bool_1 = false;
							int_29 = 2;
						}
						else
						{
							if (bool_1)
							{
								class34_0.method_8(byte_0[int_31 - 1] & 0xFF);
							}
							bool_1 = true;
							int_31++;
							int_32--;
						}
						continue;
					}
					if (bool_1)
					{
						class34_0.method_8(byte_0[int_31 - 1] & 0xFF);
					}
					bool_1 = false;
					class34_0.method_6(byte_0, int_30, int_31 - int_30, bool_3);
					int_30 = int_31;
					return false;
				}
				return true;
			}
			while (!class34_0.method_7());
			num4 = int_31 - int_30;
			if (bool_1)
			{
				num4--;
			}
			flag = bool_3 && int_32 == 0 && !bool_1;
			class34_0.method_6(byte_0, int_30, num4, flag);
			int_30 += num4;
			return !flag;
		}
		catch (Exception exception_)
		{
			Class14.smethod_29(exception_, this, bool_2, bool_3, num, num2, num3, num4, flag);
			throw;
		}
	}

	public bool method_16(bool bool_2, bool bool_3)
	{
		bool flag = default(bool);
		int num = default(int);
		bool flag2 = default(bool);
		try
		{
			while (true)
			{
				method_10();
				flag = bool_2 && int_39 == int_40;
				num = int_37;
				switch (num)
				{
				case 0:
					flag2 = method_13(flag, bool_3);
					goto IL_003f;
				case 1:
					flag2 = method_14(flag, bool_3);
					goto IL_003f;
				case 2:
					flag2 = method_15(flag, bool_3);
					goto IL_003f;
				default:
					{
						throw new InvalidOperationException(Class57.smethod_0(2094933434, 707718193, 711455860));
					}
					IL_003f:
					if (!class37_0.method_9() || !flag2)
					{
						return flag2;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, bool_2, bool_3, flag2, flag, num);
			throw;
		}
	}

	public void method_17(byte[] byte_2, int int_41, int int_42)
	{
		int num = default(int);
		try
		{
			if (int_39 < int_40)
			{
				throw new InvalidOperationException(Class57.smethod_0(1664881463, 707718163, 711455770));
			}
			num = int_41 + int_42;
			if (0 > int_41 || int_41 > num || num > byte_2.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte_1 = byte_2;
			int_39 = int_41;
			int_40 = num;
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, byte_2, int_41, int_42, num);
			throw;
		}
	}

	public bool method_18()
	{
		try
		{
			return int_40 == int_39;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}
}
