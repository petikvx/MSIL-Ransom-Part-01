using System;

namespace ns0;

internal class Class25
{
	private static int int_0;

	private short[] short_0;

	public static Class25 class25_0;

	public static Class25 class25_1;

	static Class25()
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
			class25_0 = new Class25(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class25_1 = new Class25(array);
		}
		catch (Exception)
		{
			throw new ApplicationException(Class54.smethod_0(1917745294, 41947320, 1447030521));
		}
	}

	public Class25(byte[] byte_0)
	{
		method_0(byte_0);
	}

	private void method_0(byte[] byte_0)
	{
		int[] array = default(int[]);
		int[] array2 = default(int[]);
		int i = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int j = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int k = default(int);
		int l = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		try
		{
			array = new int[int_0 + 1];
			array2 = new int[int_0 + 1];
			for (i = 0; i < byte_0.Length; i++)
			{
				num = byte_0[i];
				if (num > 0)
				{
					array[num]++;
				}
			}
			num2 = 0;
			num3 = 512;
			for (j = 1; j <= int_0; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					num4 = array2[j] & 0x1FF80;
					num5 = num2 & 0x1FF80;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			if (num2 != 65536)
			{
				throw new Exception(Class54.smethod_0(454370133, 41947390, 1447030497));
			}
			short_0 = new short[num3];
			num6 = 512;
			for (num7 = int_0; num7 >= 10; num7--)
			{
				num8 = num2 & 0x1FF80;
				num2 -= array[num7] << 16 - num7;
				num9 = num2 & 0x1FF80;
				for (k = num9; k < num8; k += 128)
				{
					short_0[Class34.smethod_0(k)] = (short)((-num6 << 4) | num7);
					num6 += 1 << num7 - 9;
				}
			}
			for (l = 0; l < byte_0.Length; l++)
			{
				num10 = byte_0[l];
				if (num10 == 0)
				{
					continue;
				}
				num2 = array2[num10];
				num11 = Class34.smethod_0(num2);
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
					num12 = short_0[num11 & 0x1FF];
					num13 = 1 << (num12 & 0xF);
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
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[21]
			{
				this, byte_0, array, array2, i, num, num2, num3, j, num4,
				num5, num6, num7, num8, num9, k, l, num10, num11, num12,
				num13
			});
			throw;
		}
	}

	public int method_1(Class30 class30_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			if ((num = class30_0.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					class30_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				num3 = -(num2 >> 4);
				num4 = num2 & 0xF;
				if ((num = class30_0.method_0(num4)) >= 0)
				{
					num2 = short_0[num3 | (num >> 9)];
					class30_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				num5 = class30_0.method_3();
				num = class30_0.method_0(num5);
				num2 = short_0[num3 | (num >> 9)];
				if ((num2 & 0xF) <= num5)
				{
					class30_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			num6 = class30_0.method_3();
			num = class30_0.method_0(num6);
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= num6)
			{
				class30_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_29(exception_, this, class30_0, num, num2, num3, num4, num5, num6);
			throw;
		}
	}
}
