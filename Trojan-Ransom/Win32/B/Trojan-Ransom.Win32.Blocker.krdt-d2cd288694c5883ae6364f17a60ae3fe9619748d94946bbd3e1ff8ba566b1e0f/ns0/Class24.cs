using System;
using ns2;
using ns6;

namespace ns0;

internal class Class24
{
	internal class _007B
	{
		public short[] short_0;

		public short[] short_1;

		public byte[] byte_0;

		public int[] int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		private Class24 class24_0;

		public _007B(Class24 class24_1, int int_4, int int_5, int int_6)
		{
			class24_0 = class24_1;
			int_1 = int_5;
			int_3 = int_6;
			short_0 = new short[int_4];
			int_0 = new int[int_6];
		}

		public void method_0()
		{
			for (int i = 0; i < short_0.Length; i++)
			{
				short_0[i] = 0;
			}
			short_1 = null;
			byte_0 = null;
		}

		public void method_1(int int_4)
		{
			class24_0.class26_0.method_7(short_1[int_4] & 0xFFFF, byte_0[int_4]);
		}

		public void method_2()
		{
			bool flag = true;
			for (int i = 0; i < short_0.Length; i++)
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

		public void method_3(short[] short_2, byte[] byte_1)
		{
			short_1 = short_2;
			byte_0 = byte_1;
		}

		public void method_4()
		{
			int[] array = new int[int_3];
			int num = 0;
			short_1 = new short[short_0.Length];
			for (int i = 0; i < int_3; i++)
			{
				array[i] = num;
				num += int_0[i] << 15 - i;
			}
			for (int j = 0; j < int_2; j++)
			{
				int num2 = byte_0[j];
				if (num2 > 0)
				{
					short_1[j] = smethod_0(array[num2 - 1]);
					array[num2 - 1] += 1 << 16 - num2;
				}
			}
		}

		private void method_5(int[] int_4)
		{
			byte_0 = new byte[short_0.Length];
			int num = int_4.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 0;
			for (int i = 0; i < int_3; i++)
			{
				int_0[i] = 0;
			}
			int[] array = new int[num];
			array[num - 1] = 0;
			for (int num4 = num - 1; num4 >= 0; num4--)
			{
				if (int_4[2 * num4 + 1] != -1)
				{
					int num5 = array[num4] + 1;
					if (num5 > int_3)
					{
						num5 = int_3;
						num3++;
					}
					array[int_4[2 * num4]] = (array[int_4[2 * num4 + 1]] = num5);
				}
				else
				{
					int num6 = array[num4];
					int_0[num6 - 1]++;
					byte_0[int_4[2 * num4]] = (byte)array[num4];
				}
			}
			if (num3 == 0)
			{
				return;
			}
			int num7 = int_3 - 1;
			while (true)
			{
				if (int_0[--num7] != 0)
				{
					do
					{
						int_0[num7]--;
						int_0[++num7]++;
						num3 -= 1 << int_3 - 1 - num7;
					}
					while (num3 > 0 && num7 < int_3 - 1);
					if (num3 <= 0)
					{
						break;
					}
				}
			}
			int_0[int_3 - 1] += num3;
			int_0[int_3 - 2] -= num3;
			int num8 = 2 * num2;
			for (int num9 = int_3; num9 != 0; num9--)
			{
				int num10 = int_0[num9 - 1];
				while (num10 > 0)
				{
					int num11 = 2 * int_4[num8++];
					if (int_4[num11 + 1] == -1)
					{
						byte_0[int_4[num11]] = (byte)num9;
						num10--;
					}
				}
			}
		}

		public void method_6()
		{
			int num = short_0.Length;
			int[] array = new int[num];
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				int num4 = short_0[i];
				if (num4 != 0)
				{
					int num5 = num2++;
					int num6;
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
				int num7 = ((num3 < 2) ? (++num3) : 0);
				array[num2++] = num7;
			}
			int_2 = Math.Max(num3 + 1, int_1);
			int num8 = num2;
			int[] array2 = new int[4 * num2 - 2];
			int[] array3 = new int[2 * num2 - 1];
			int num9 = num8;
			for (int j = 0; j < num2; j++)
			{
				int num10 = (array2[2 * j] = array[j]);
				array2[2 * j + 1] = -1;
				array3[j] = short_0[num10] << 8;
				array[j] = j;
			}
			do
			{
				int num11 = array[0];
				int num12 = array[--num2];
				int num13 = 0;
				int num14;
				for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				int num15 = array3[num12];
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
				int num16 = array[0];
				num12 = num9++;
				array2[2 * num12] = num11;
				array2[2 * num12 + 1] = num16;
				int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
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
				throw new Exception(Class38.smethod_0(1289173728, 306750943, 656073755));
			}
			method_5(array2);
		}

		public int method_7()
		{
			int num = 0;
			for (int i = 0; i < short_0.Length; i++)
			{
				num += short_0[i] * byte_0[i];
			}
			return num;
		}

		public void method_8(_007B _007B_0)
		{
			int num = -1;
			int num2 = 0;
			while (num2 < int_2)
			{
				int num3 = 1;
				int num4 = byte_0[num2];
				int num5;
				int num6;
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
						_007B_0.short_0[num4]++;
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
					_007B_0.short_0[num] += (short)num3;
				}
				else if (num != 0)
				{
					_007B_0.short_0[int_4]++;
				}
				else if (num3 <= 10)
				{
					_007B_0.short_0[int_5]++;
				}
				else
				{
					_007B_0.short_0[int_6]++;
				}
			}
		}

		public void method_9(_007B _007B_0)
		{
			int num = -1;
			int num2 = 0;
			while (num2 < int_2)
			{
				int num3 = 1;
				int num4 = byte_0[num2];
				int num5;
				int num6;
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
						_007B_0.method_1(num4);
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
						_007B_0.method_1(num);
					}
				}
				else if (num != 0)
				{
					_007B_0.method_1(int_4);
					class24_0.class26_0.method_7(num3 - 3, 2);
				}
				else if (num3 <= 10)
				{
					_007B_0.method_1(int_5);
					class24_0.class26_0.method_7(num3 - 3, 3);
				}
				else
				{
					_007B_0.method_1(int_6);
					class24_0.class26_0.method_7(num3 - 11, 7);
				}
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

	public Class26 class26_0;

	private _007B _007B_0;

	private _007B _007B_1;

	private _007B _007B_2;

	private short[] short_0;

	private byte[] byte_1;

	private int int_9;

	private int int_10;

	private static short[] short_1;

	private static byte[] byte_2;

	private static short[] short_2;

	private static byte[] byte_3;

	static Class24()
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

	public Class24(Class26 class26_1)
	{
		class26_0 = class26_1;
		_007B_0 = new _007B(this, int_1, 257, 15);
		_007B_1 = new _007B(this, int_2, 1, 15);
		_007B_2 = new _007B(this, int_3, 4, 7);
		short_0 = new short[int_0];
		byte_1 = new byte[int_0];
	}

	public static short smethod_0(int int_11)
	{
		return (short)((byte_0[int_11 & 0xF] << 12) | (byte_0[(int_11 >> 4) & 0xF] << 8) | (byte_0[(int_11 >> 8) & 0xF] << 4) | byte_0[int_11 >> 12]);
	}

	public void method_0()
	{
		int_9 = 0;
		int_10 = 0;
		_007B_0.method_0();
		_007B_1.method_0();
		_007B_2.method_0();
	}

	private int method_1(int int_11)
	{
		if (int_11 == 255)
		{
			return 285;
		}
		int num = 257;
		while (int_11 >= 8)
		{
			num += 4;
			int_11 >>= 1;
		}
		return num + int_11;
	}

	private int method_2(int int_11)
	{
		int num = 0;
		while (int_11 >= 4)
		{
			num += 2;
			int_11 >>= 1;
		}
		return num + int_11;
	}

	public void method_3(int int_11)
	{
		_007B_2.method_4();
		_007B_0.method_4();
		_007B_1.method_4();
		class26_0.method_7(_007B_0.int_2 - 257, 5);
		class26_0.method_7(_007B_1.int_2 - 1, 5);
		class26_0.method_7(int_11 - 4, 4);
		for (int i = 0; i < int_11; i++)
		{
			class26_0.method_7(_007B_2.byte_0[int_8[i]], 3);
		}
		_007B_0.method_9(_007B_2);
		_007B_1.method_9(_007B_2);
	}

	public void method_4()
	{
		for (int i = 0; i < int_9; i++)
		{
			int num = byte_1[i] & 0xFF;
			int num2 = short_0[i];
			if (num2-- != 0)
			{
				int num3 = method_1(num);
				_007B_0.method_1(num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					class26_0.method_7(num & ((1 << num4) - 1), num4);
				}
				int num5 = method_2(num2);
				_007B_1.method_1(num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					class26_0.method_7(num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				_007B_0.method_1(num);
			}
		}
		_007B_0.method_1(int_7);
	}

	public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
	{
		class26_0.method_7(bool_0 ? 1 : 0, 3);
		class26_0.method_6();
		class26_0.method_2(int_12);
		class26_0.method_2(~int_12);
		class26_0.method_4(byte_4, int_11, int_12);
		method_0();
	}

	public void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
	{
		_007B_0.short_0[int_7]++;
		_007B_0.method_6();
		_007B_1.method_6();
		_007B_0.method_8(_007B_2);
		_007B_1.method_8(_007B_2);
		_007B_2.method_6();
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (_007B_2.byte_0[int_8[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + _007B_2.method_7() + _007B_0.method_7() + _007B_1.method_7() + int_10;
		int num4 = int_10;
		for (int i = 0; i < int_1; i++)
		{
			num4 += _007B_0.short_0[i] * byte_2[i];
		}
		for (int j = 0; j < int_2; j++)
		{
			num4 += _007B_1.short_0[j] * byte_3[j];
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
			class26_0.method_7(2 + (bool_0 ? 1 : 0), 3);
			_007B_0.method_3(short_1, byte_2);
			_007B_1.method_3(short_2, byte_3);
			method_4();
			method_0();
		}
		else
		{
			class26_0.method_7(4 + (bool_0 ? 1 : 0), 3);
			method_3(num);
			method_4();
			method_0();
		}
	}

	public bool method_7()
	{
		return int_9 + 16 >= int_0;
	}

	public bool method_8(int int_11)
	{
		short_0[int_9] = 0;
		byte_1[int_9++] = (byte)int_11;
		_007B_0.short_0[int_11]++;
		return method_7();
	}

	public bool method_9(int int_11, int int_12)
	{
		short_0[int_9] = (short)int_11;
		byte_1[int_9++] = (byte)(int_12 - 3);
		int num = method_1(int_12 - 3);
		_007B_0.short_0[num]++;
		if (num >= 265 && num < 285)
		{
			int_10 += (num - 261) / 4;
		}
		int num2 = method_2(int_11 - 1);
		_007B_1.short_0[num2]++;
		if (num2 >= 4)
		{
			int_10 += num2 / 2 - 1;
		}
		return method_7();
	}
}
