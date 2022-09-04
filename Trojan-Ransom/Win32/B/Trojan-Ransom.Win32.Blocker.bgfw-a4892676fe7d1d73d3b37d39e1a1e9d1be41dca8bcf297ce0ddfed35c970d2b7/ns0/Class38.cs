using System;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal class Class38 : Class37
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

	private Enum0 enum0_0;

	private int int_33;

	private int int_34;

	private int int_35;

	private int int_36;

	private int int_37;

	private byte[] byte_1;

	private int int_38;

	private int int_39;

	private int int_40;

	private Class18 class18_0;

	private Class24 class24_0;

	private Class13 class13_0;

	public Class38(Class18 class18_1)
	{
		class18_0 = class18_1;
		class24_0 = new Class24(class18_1);
		class13_0 = new Class13();
		byte_0 = new byte[65536];
		short_0 = new short[32768];
		short_1 = new short[32768];
		int_31 = 1;
		int_30 = 1;
	}

	public void method_0()
	{
		class24_0.method_0();
		class13_0.imethod_1();
		int_31 = 1;
		int_30 = 1;
		int_32 = 0;
		int_38 = 0;
		bool_1 = false;
		int_29 = 2;
		for (int i = 0; i < 32768; i++)
		{
			short_0[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			short_1[j] = 0;
		}
	}

	public void method_1()
	{
		class13_0.imethod_1();
	}

	[SpecialName]
	public int method_2()
	{
		return (int)class13_0.imethod_0();
	}

	[SpecialName]
	public int method_3()
	{
		return int_38;
	}

	[SpecialName]
	public Enum0 method_4()
	{
		return enum0_0;
	}

	[SpecialName]
	public void method_5(Enum0 enum0_1)
	{
		enum0_0 = enum0_1;
	}

	public void method_6(int int_41)
	{
		int_36 = Class37.int_21[int_41];
		int_34 = Class37.int_22[int_41];
		int_35 = Class37.int_23[int_41];
		int_33 = Class37.int_24[int_41];
		if (Class37.int_25[int_41] == int_37)
		{
			return;
		}
		switch (int_37)
		{
		case 0:
			if (int_31 > int_30)
			{
				class24_0.method_5(byte_0, int_30, int_31 - int_30, bool_0: false);
				int_30 = int_31;
			}
			method_7();
			break;
		case 1:
			if (int_31 > int_30)
			{
				class24_0.method_6(byte_0, int_30, int_31 - int_30, bool_0: false);
				int_30 = int_31;
			}
			break;
		case 2:
			if (bool_1)
			{
				class24_0.method_8(byte_0[int_31 - 1] & 0xFF);
			}
			if (int_31 > int_30)
			{
				class24_0.method_6(byte_0, int_30, int_31 - int_30, bool_0: false);
				int_30 = int_31;
			}
			bool_1 = false;
			int_29 = 2;
			break;
		}
		int_37 = Class37.int_25[int_41];
	}

	private void method_7()
	{
		int_27 = (byte_0[int_31] << 5) ^ byte_0[int_31 + 1];
	}

	private int method_8()
	{
		int num = ((int_27 << 5) ^ byte_0[int_31 + 2]) & 0x7FFF;
		short num2 = (short_1[int_31 & 0x7FFF] = short_0[num]);
		short_0[num] = (short)int_31;
		int_27 = num;
		return num2 & 0xFFFF;
	}

	private void method_9()
	{
		Array.Copy(byte_0, 32768, byte_0, 0, 32768);
		int_28 -= 32768;
		int_31 -= 32768;
		int_30 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = short_0[i] & 0xFFFF;
			short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = short_1[j] & 0xFFFF;
			short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	public void method_10()
	{
		if (int_31 >= 65274)
		{
			method_9();
		}
		while (int_32 < 262 && int_39 < int_40)
		{
			int num = 65536 - int_32 - int_31;
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

	private bool method_11(int int_41)
	{
		int num = int_33;
		int num2 = int_35;
		short[] array = short_1;
		int num3 = int_31;
		int num4 = int_31 + int_29;
		int num5 = Math.Max(int_29, 2);
		int num6 = Math.Max(int_31 - 32506, 0);
		int num7 = int_31 + 258 - 1;
		byte b = byte_0[num4 - 1];
		byte b2 = byte_0[num4];
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
			int num8 = int_41 + 2;
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

	public void method_12(byte[] byte_2, int int_41, int int_42)
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

	private bool method_13(bool bool_2, bool bool_3)
	{
		if (!bool_2 && int_32 == 0)
		{
			return false;
		}
		int_31 += int_32;
		int_32 = 0;
		int num = int_31 - int_30;
		if (num < Class37.int_20 && (int_30 >= 32768 || num < 32506) && !bool_2)
		{
			return true;
		}
		bool flag = bool_3;
		if (num > Class37.int_20)
		{
			num = Class37.int_20;
			flag = false;
		}
		class24_0.method_5(byte_0, int_30, num, flag);
		int_30 += num;
		return !flag;
	}

	private bool method_14(bool bool_2, bool bool_3)
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
					int num;
					if (int_32 >= 3 && (num = method_8()) != 0 && enum0_0 != Enum0.const_2 && int_31 - num <= 32506 && method_11(num))
					{
						class24_0.method_9(int_31 - int_28, int_29);
						int_32 -= int_29;
						if (int_29 <= int_34 && int_32 >= 3)
						{
							while (--int_29 > 0)
							{
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
						class24_0.method_8(byte_0[int_31] & 0xFF);
						int_31++;
						int_32--;
						if (class24_0.method_7())
						{
							break;
						}
					}
					continue;
				}
				class24_0.method_6(byte_0, int_30, int_31 - int_30, bool_3);
				int_30 = int_31;
				return false;
			}
			return true;
		}
		bool flag = bool_3 && int_32 == 0;
		class24_0.method_6(byte_0, int_30, int_31 - int_30, flag);
		int_30 = int_31;
		return !flag;
	}

	private bool method_15(bool bool_2, bool bool_3)
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
					int num = int_28;
					int num2 = int_29;
					if (int_32 >= 3)
					{
						int num3 = method_8();
						if (enum0_0 != Enum0.const_2 && num3 != 0 && int_31 - num3 <= 32506 && method_11(num3) && int_29 <= 5 && (enum0_0 == Enum0.const_1 || (int_29 == 3 && int_31 - int_28 > int_26)))
						{
							int_29 = 2;
						}
					}
					if (num2 >= 3 && int_29 <= num2)
					{
						class24_0.method_9(int_31 - 1 - num, num2);
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
							class24_0.method_8(byte_0[int_31 - 1] & 0xFF);
						}
						bool_1 = true;
						int_31++;
						int_32--;
					}
					continue;
				}
				if (bool_1)
				{
					class24_0.method_8(byte_0[int_31 - 1] & 0xFF);
				}
				bool_1 = false;
				class24_0.method_6(byte_0, int_30, int_31 - int_30, bool_3);
				int_30 = int_31;
				return false;
			}
			return true;
		}
		while (!class24_0.method_7());
		int num4 = int_31 - int_30;
		if (bool_1)
		{
			num4--;
		}
		bool flag = bool_3 && int_32 == 0 && !bool_1;
		class24_0.method_6(byte_0, int_30, num4, flag);
		int_30 += num4;
		return !flag;
	}

	public bool method_16(bool bool_2, bool bool_3)
	{
		while (true)
		{
			method_10();
			bool bool_4 = bool_2 && int_39 == int_40;
			bool flag;
			switch (int_37)
			{
			case 0:
				flag = method_13(bool_4, bool_3);
				goto IL_0079;
			case 1:
				flag = method_14(bool_4, bool_3);
				goto IL_0079;
			case 2:
				flag = method_15(bool_4, bool_3);
				goto IL_0079;
			default:
				{
					throw new InvalidOperationException(Class39.smethod_0(726167404, 1008441376, 591083619));
				}
				IL_0079:
				if (!class18_0.method_9() || !flag)
				{
					return flag;
				}
				break;
			}
		}
	}

	public void method_17(byte[] byte_2, int int_41, int int_42)
	{
		if (int_39 < int_40)
		{
			throw new InvalidOperationException(Class39.smethod_0(1054810850, 1008441346, 591083533));
		}
		int num = int_41 + int_42;
		if (0 > int_41 || int_41 > num || num > byte_2.Length)
		{
			throw new ArgumentOutOfRangeException();
		}
		byte_1 = byte_2;
		int_39 = int_41;
		int_40 = num;
	}

	public bool method_18()
	{
		return int_40 == int_39;
	}
}
