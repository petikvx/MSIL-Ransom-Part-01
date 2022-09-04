using System;

namespace ns0;

internal class Class34
{
	internal class Class35
	{
		public short[] short_0;

		public short[] short_1;

		public byte[] byte_0;

		public int[] int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		private Class34 class34_0;

		public Class35(Class34 class34_1, int int_4, int int_5, int int_6)
		{
			class34_0 = class34_1;
			int_1 = int_5;
			int_3 = int_6;
			short_0 = new short[int_4];
			int_0 = new int[int_6];
		}

		public void method_0()
		{
			int i = default(int);
			try
			{
				for (i = 0; i < short_0.Length; i++)
				{
					short_0[i] = 0;
				}
				short_1 = null;
				byte_0 = null;
			}
			catch (Exception exception_)
			{
				Class14.smethod_23(exception_, this, i);
				throw;
			}
		}

		public void method_1(int int_4)
		{
			try
			{
				class34_0.class37_0.method_7(short_1[int_4] & 0xFFFF, byte_0[int_4]);
			}
			catch (Exception exception_)
			{
				Class14.smethod_23(exception_, this, int_4);
				throw;
			}
		}

		public void method_2()
		{
			bool flag = default(bool);
			int i = default(int);
			try
			{
				flag = true;
				for (i = 0; i < short_0.Length; i++)
				{
					if (short_0[i] != 0)
					{
						flag = false;
					}
				}
				if (!flag)
				{
					throw new Exception();
				}
			}
			catch (Exception exception_)
			{
				Class14.smethod_24(exception_, this, flag, i);
				throw;
			}
		}

		public void method_3(short[] short_2, byte[] byte_1)
		{
			try
			{
				short_1 = short_2;
				byte_0 = byte_1;
			}
			catch (Exception exception_)
			{
				Class14.smethod_24(exception_, this, short_2, byte_1);
				throw;
			}
		}

		public void method_4()
		{
			int[] array = default(int[]);
			int num = default(int);
			int i = default(int);
			int j = default(int);
			int num2 = default(int);
			try
			{
				array = new int[int_3];
				num = 0;
				short_1 = new short[short_0.Length];
				for (i = 0; i < int_3; i++)
				{
					array[i] = num;
					num += int_0[i] << 15 - i;
				}
				for (j = 0; j < int_2; j++)
				{
					num2 = byte_0[j];
					if (num2 > 0)
					{
						short_1[j] = smethod_0(array[num2 - 1]);
						array[num2 - 1] += 1 << 16 - num2;
					}
				}
			}
			catch (Exception exception_)
			{
				Class14.smethod_27(exception_, this, array, num, i, j, num2);
				throw;
			}
		}

		private void method_5(int[] int_4)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int i = default(int);
			int[] array = default(int[]);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			try
			{
				byte_0 = new byte[short_0.Length];
				num = int_4.Length / 2;
				num2 = (num + 1) / 2;
				num3 = 0;
				for (i = 0; i < int_3; i++)
				{
					int_0[i] = 0;
				}
				array = new int[num];
				array[num - 1] = 0;
				for (num4 = num - 1; num4 >= 0; num4--)
				{
					if (int_4[2 * num4 + 1] != -1)
					{
						num5 = array[num4] + 1;
						if (num5 > int_3)
						{
							num5 = int_3;
							num3++;
						}
						num6 = (array[int_4[2 * num4]] = (array[int_4[2 * num4 + 1]] = num5));
					}
					else
					{
						num7 = array[num4];
						int_0[num7 - 1]++;
						byte_0[int_4[2 * num4]] = (byte)array[num4];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				num8 = int_3 - 1;
				while (true)
				{
					if (int_0[--num8] != 0)
					{
						do
						{
							int_0[num8]--;
							int_0[++num8]++;
							num3 -= 1 << int_3 - 1 - num8;
						}
						while (num3 > 0 && num8 < int_3 - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				int_0[int_3 - 1] += num3;
				int_0[int_3 - 2] -= num3;
				num9 = 2 * num2;
				for (num10 = int_3; num10 != 0; num10--)
				{
					num11 = int_0[num10 - 1];
					while (num11 > 0)
					{
						num12 = 2 * int_4[num9++];
						if (int_4[num12 + 1] == -1)
						{
							byte_0[int_4[num12]] = (byte)num10;
							num11--;
						}
					}
				}
			}
			catch (Exception exception_)
			{
				Class14.smethod_32(exception_, new object[16]
				{
					this, int_4, num, num2, num3, i, array, num4, num5, num7,
					num8, num9, num10, num11, num12, num6
				});
				throw;
			}
		}

		public void method_6()
		{
			int num = default(int);
			int[] array = default(int[]);
			int num2 = default(int);
			int num3 = default(int);
			int i = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int[] array2 = default(int[]);
			int[] array3 = default(int[]);
			int num9 = default(int);
			int j = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			int num17 = default(int);
			try
			{
				num = short_0.Length;
				array = new int[num];
				num2 = 0;
				num3 = 0;
				for (i = 0; i < num; i++)
				{
					num4 = short_0[i];
					if (num4 != 0)
					{
						num5 = num2++;
						while (num5 > 0 && short_0[array[num6 = (num5 - 1) / 2]] > num4)
						{
							array[num5] = array[num6];
							num5 = num6;
						}
						array[num5] = i;
						num3 = i;
					}
				}
				while (num2 < 2)
				{
					num7 = ((num3 < 2) ? (++num3) : 0);
					array[num2++] = num7;
				}
				int_2 = Math.Max(num3 + 1, int_1);
				num8 = num2;
				array2 = new int[4 * num2 - 2];
				array3 = new int[2 * num2 - 1];
				num9 = num8;
				for (j = 0; j < num2; j++)
				{
					num10 = (array2[2 * j] = array[j]);
					array2[2 * j + 1] = -1;
					array3[j] = short_0[num10] << 8;
					array[j] = j;
				}
				do
				{
					num11 = array[0];
					num12 = array[--num2];
					num13 = 0;
					for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					num15 = array3[num12];
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
					num16 = array[0];
					num12 = num9++;
					array2[2 * num12] = num11;
					array2[2 * num12 + 1] = num16;
					num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
					num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
					num13 = 0;
					for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
				}
				while (num2 > 1);
				if (array[0] != array2.Length / 2 - 1)
				{
					throw new Exception(Class49.smethod_0(1251269019, 794452688, 27999841));
				}
				method_5(array2);
			}
			catch (Exception exception_)
			{
				Class14.smethod_32(exception_, new object[23]
				{
					this, num, array, num2, num3, i, num4, num5, num6, num7,
					num8, array2, array3, num9, j, num10, num11, num12, num13, num14,
					num15, num16, num17
				});
				throw;
			}
		}

		public int method_7()
		{
			int num = default(int);
			int i = default(int);
			try
			{
				num = 0;
				for (i = 0; i < short_0.Length; i++)
				{
					num += short_0[i] * byte_0[i];
				}
				return num;
			}
			catch (Exception exception_)
			{
				Class14.smethod_24(exception_, this, num, i);
				throw;
			}
		}

		public void method_8(Class35 class35_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				num = -1;
				num2 = 0;
				while (num2 < int_2)
				{
					num3 = 1;
					num4 = byte_0[num2];
					if (num4 == 0)
					{
						num5 = 138;
						num6 = 3;
					}
					else
					{
						num5 = 6;
						num6 = 3;
						if (num != num4)
						{
							class35_0.short_0[num4]++;
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < int_2 && num == byte_0[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						class35_0.short_0[num] += (short)num3;
					}
					else if (num != 0)
					{
						class35_0.short_0[int_4]++;
					}
					else if (num3 <= 10)
					{
						class35_0.short_0[int_5]++;
					}
					else
					{
						class35_0.short_0[int_6]++;
					}
				}
			}
			catch (Exception exception_)
			{
				Class14.smethod_29(exception_, this, class35_0, num5, num6, num3, num, num2, num4);
				throw;
			}
		}

		public void method_9(Class35 class35_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				num = -1;
				num2 = 0;
				while (num2 < int_2)
				{
					num3 = 1;
					num4 = byte_0[num2];
					if (num4 == 0)
					{
						num5 = 138;
						num6 = 3;
					}
					else
					{
						num5 = 6;
						num6 = 3;
						if (num != num4)
						{
							class35_0.method_1(num4);
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < int_2 && num == byte_0[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						while (num3-- > 0)
						{
							class35_0.method_1(num);
						}
					}
					else if (num != 0)
					{
						class35_0.method_1(int_4);
						class34_0.class37_0.method_7(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						class35_0.method_1(int_5);
						class34_0.class37_0.method_7(num3 - 3, 3);
					}
					else
					{
						class35_0.method_1(int_6);
						class34_0.class37_0.method_7(num3 - 11, 7);
					}
				}
			}
			catch (Exception exception_)
			{
				Class14.smethod_29(exception_, this, class35_0, num5, num6, num3, num, num2, num4);
				throw;
			}
		}
	}

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static int int_4;

	private static int int_5;

	private static int int_6;

	private static int int_7;

	private static int[] int_8;

	private static byte[] byte_0;

	public Class37 class37_0;

	private Class35 class35_0;

	private Class35 class35_1;

	private Class35 class35_2;

	private short[] short_0;

	private byte[] byte_1;

	private int int_9;

	private int int_10;

	private static short[] short_1;

	private static byte[] byte_2;

	private static short[] short_2;

	private static byte[] byte_3;

	static Class34()
	{
		int_0 = 16384;
		int_1 = 286;
		int_2 = 30;
		int_3 = 19;
		int_4 = 16;
		int_5 = 17;
		int_6 = 18;
		int_7 = 256;
		int_8 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
		byte_0 = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
			5, 13, 3, 11, 7, 15
		};
		short_1 = new short[int_1];
		byte_2 = new byte[int_1];
		int num = 0;
		while (num < 144)
		{
			short_1[num] = smethod_0(48 + num << 8);
			byte_2[num++] = 8;
		}
		while (num < 256)
		{
			short_1[num] = smethod_0(256 + num << 7);
			byte_2[num++] = 9;
		}
		while (num < 280)
		{
			short_1[num] = smethod_0(-256 + num << 9);
			byte_2[num++] = 7;
		}
		while (num < int_1)
		{
			short_1[num] = smethod_0(-88 + num << 8);
			byte_2[num++] = 8;
		}
		short_2 = new short[int_2];
		byte_3 = new byte[int_2];
		for (num = 0; num < int_2; num++)
		{
			short_2[num] = smethod_0(num << 11);
			byte_3[num] = 5;
		}
	}

	public Class34(Class37 class37_1)
	{
		class37_0 = class37_1;
		class35_0 = new Class35(this, int_1, 257, 15);
		class35_1 = new Class35(this, int_2, 1, 15);
		class35_2 = new Class35(this, int_3, 4, 7);
		short_0 = new short[int_0];
		byte_1 = new byte[int_0];
	}

	public static short smethod_0(int int_11)
	{
		try
		{
			return (short)((byte_0[int_11 & 0xF] << 12) | (byte_0[(int_11 >> 4) & 0xF] << 8) | (byte_0[(int_11 >> 8) & 0xF] << 4) | byte_0[int_11 >> 12]);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, int_11);
			throw;
		}
	}

	public void method_0()
	{
		try
		{
			int_9 = 0;
			int_10 = 0;
			class35_0.method_0();
			class35_1.method_0();
			class35_2.method_0();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	private int method_1(int int_11)
	{
		int num = default(int);
		try
		{
			if (int_11 == 255)
			{
				return 285;
			}
			num = 257;
			while (int_11 >= 8)
			{
				num += 4;
				int_11 >>= 1;
			}
			return num + int_11;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_11, num);
			throw;
		}
	}

	private int method_2(int int_11)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (int_11 >= 4)
			{
				num += 2;
				int_11 >>= 1;
			}
			return num + int_11;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_11, num);
			throw;
		}
	}

	public void method_3(int int_11)
	{
		int i = default(int);
		try
		{
			class35_2.method_4();
			class35_0.method_4();
			class35_1.method_4();
			class37_0.method_7(class35_0.int_2 - 257, 5);
			class37_0.method_7(class35_1.int_2 - 1, 5);
			class37_0.method_7(int_11 - 4, 4);
			for (i = 0; i < int_11; i++)
			{
				class37_0.method_7(class35_2.byte_0[int_8[i]], 3);
			}
			class35_0.method_9(class35_2);
			class35_1.method_9(class35_2);
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_11, i);
			throw;
		}
	}

	public void method_4()
	{
		int i = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			for (i = 0; i < int_9; i++)
			{
				num = byte_1[i] & 0xFF;
				num2 = short_0[i];
				if (num2-- != 0)
				{
					num3 = method_1(num);
					class35_0.method_1(num3);
					num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						class37_0.method_7(num & ((1 << num4) - 1), num4);
					}
					num5 = method_2(num2);
					class35_1.method_1(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						class37_0.method_7(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					class35_0.method_1(num);
				}
			}
			class35_0.method_1(int_7);
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, this, i, num, num2, num3, num4, num5);
			throw;
		}
	}

	public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
	{
		try
		{
			class37_0.method_7(bool_0 ? 1 : 0, 3);
			class37_0.method_6();
			class37_0.method_2(int_12);
			class37_0.method_2(~int_12);
			class37_0.method_4(byte_4, int_11, int_12);
			method_0();
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, byte_4, int_11, int_12, bool_0);
			throw;
		}
	}

	public void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int i = default(int);
		int j = default(int);
		try
		{
			class35_0.short_0[int_7]++;
			class35_0.method_6();
			class35_1.method_6();
			class35_0.method_8(class35_2);
			class35_1.method_8(class35_2);
			class35_2.method_6();
			num = 4;
			for (num2 = 18; num2 > num; num2--)
			{
				if (class35_2.byte_0[int_8[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			num3 = 14 + num * 3 + class35_2.method_7() + class35_0.method_7() + class35_1.method_7() + int_10;
			num4 = int_10;
			for (i = 0; i < int_1; i++)
			{
				num4 += class35_0.short_0[i] * byte_2[i];
			}
			for (j = 0; j < int_2; j++)
			{
				num4 += class35_1.short_0[j] * byte_3[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (int_11 >= 0 && int_12 + 4 < num3 >> 3)
			{
				method_5(byte_4, int_11, int_12, bool_0);
			}
			else if (num3 == num4)
			{
				class37_0.method_7(2 + (bool_0 ? 1 : 0), 3);
				class35_0.method_3(short_1, byte_2);
				class35_1.method_3(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class37_0.method_7(4 + (bool_0 ? 1 : 0), 3);
				method_3(num);
				method_4();
				method_0();
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[11]
			{
				this, byte_4, int_11, int_12, bool_0, num, num2, num3, num4, i,
				j
			});
			throw;
		}
	}

	public bool method_7()
	{
		try
		{
			return int_9 + 16 >= int_0;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public bool method_8(int int_11)
	{
		int num = default(int);
		try
		{
			short_0[int_9] = 0;
			byte[] array = byte_1;
			num = int_9++;
			array[num] = (byte)int_11;
			class35_0.short_0[int_11]++;
			return method_7();
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_11, num);
			throw;
		}
	}

	public bool method_9(int int_11, int int_12)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			short_0[int_9] = (short)int_11;
			byte[] array = byte_1;
			num = int_9++;
			array[num] = (byte)(int_12 - 3);
			num2 = method_1(int_12 - 3);
			class35_0.short_0[num2]++;
			if (num2 >= 265 && num2 < 285)
			{
				int_10 += (num2 - 261) / 4;
			}
			num3 = method_2(int_11 - 1);
			class35_1.short_0[num3]++;
			if (num3 >= 4)
			{
				int_10 += num3 / 2 - 1;
			}
			return method_7();
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, int_11, int_12, num2, num3, num);
			throw;
		}
	}
}
