using System;
using ns1;

namespace ns0;

internal class Class15
{
	private static int int_0;

	private short[] short_0;

	public static Class15 class15_0;

	public static Class15 class15_1;

	static Class15()
	{
		int_0 = 15;
		try
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			class15_0 = new Class15(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class15_1 = new Class15(array);
		}
		catch (Exception)
		{
			throw new ApplicationException(Class44.smethod_0(169494463, 311520891, 315723922));
		}
	}

	public Class15(byte[] byte_0)
	{
		method_0(byte_0);
	}

	private void method_0(byte[] byte_0)
	{
		int[] array = new int[int_0 + 1];
		int[] array2 = new int[int_0 + 1];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= int_0; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		if (num2 != 65536)
		{
			throw new Exception(Class44.smethod_0(1370307139, 311520829, 315723914));
		}
		short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = int_0; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			int num9 = num2 & 0x1FF80;
			for (int k = num9; k < num8; k += 128)
			{
				short_0[Class24.smethod_0(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num10 = byte_0[l];
			if (num10 == 0)
			{
				continue;
			}
			num2 = array2[num10];
			int num11 = Class24.smethod_0(num2);
			if (num10 <= 9)
			{
				do
				{
					short_0[num11] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < 512);
			}
			else
			{
				int num12 = short_0[num11 & 0x1FF];
				int num13 = 1 << (num12 & 0xF);
				num12 = -(num12 >> 4);
				do
				{
					short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < num13);
			}
			array2[num10] = num2 + (1 << 16 - num10);
		}
	}

	public int method_1(Class20 class20_0)
	{
		int num;
		int num2;
		if ((num = class20_0.method_0(9)) >= 0)
		{
			if ((num2 = short_0[num]) >= 0)
			{
				class20_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = class20_0.method_0(int_)) >= 0)
			{
				num2 = short_0[num3 | (num >> 9)];
				class20_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			int num4 = class20_0.method_3();
			num = class20_0.method_0(num4);
			num2 = short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= num4)
			{
				class20_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int num5 = class20_0.method_3();
		num = class20_0.method_0(num5);
		num2 = short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= num5)
		{
			class20_0.method_1(num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}
}
