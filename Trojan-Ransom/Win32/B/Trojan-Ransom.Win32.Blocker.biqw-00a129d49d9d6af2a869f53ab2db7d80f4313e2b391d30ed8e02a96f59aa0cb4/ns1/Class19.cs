using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using ns4;

namespace ns1;

internal class Class19
{
	internal sealed class Class20
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

		private static readonly int[] int_13 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static readonly int[] int_14 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static readonly int[] int_15 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static readonly int[] int_16 = new int[30]
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

		private bool bool_0;

		private Class21 class21_0;

		private Class22 class22_0;

		private Class24 class24_0;

		private Class23 class23_0;

		private Class23 class23_1;

		public Class20(byte[] byte_0)
		{
			class21_0 = new Class21();
			class22_0 = new Class22();
			int_17 = 2;
			class21_0.method_5(byte_0, 0, byte_0.Length);
		}

		private bool method_0()
		{
			int num = class22_0.method_5();
			while (num >= 258)
			{
				switch (int_17)
				{
				case 7:
				{
					int num2;
					while (((num2 = class23_0.method_1(class21_0)) & -256) == 0)
					{
						class22_0.method_0(num2);
						if (--num < 258)
						{
							return true;
						}
					}
					if (num2 >= 257)
					{
						int_19 = int_13[num2 - 257];
						int_18 = int_14[num2 - 257];
						goto case 8;
					}
					if (num2 < 0)
					{
						return false;
					}
					class23_1 = null;
					class23_0 = null;
					int_17 = 2;
					return true;
				}
				case 8:
					if (int_18 > 0)
					{
						int_17 = 8;
						int num4 = class21_0.method_0(int_18);
						if (num4 < 0)
						{
							return false;
						}
						class21_0.method_1(int_18);
						int_19 += num4;
					}
					int_17 = 9;
					goto case 9;
				case 9:
				{
					int num2 = class23_1.method_1(class21_0);
					if (num2 >= 0)
					{
						int_20 = int_15[num2];
						int_18 = int_16[num2];
						goto case 10;
					}
					return false;
				}
				case 10:
					if (int_18 > 0)
					{
						int_17 = 10;
						int num3 = class21_0.method_0(int_18);
						if (num3 < 0)
						{
							return false;
						}
						class21_0.method_1(int_18);
						int_20 += num3;
					}
					class22_0.method_2(int_19, int_20);
					num -= int_19;
					int_17 = 7;
					break;
				}
			}
			return true;
		}

		private bool method_1()
		{
			switch (int_17)
			{
			case 2:
			{
				if (bool_0)
				{
					int_17 = 12;
					return false;
				}
				int num = class21_0.method_0(3);
				if (num < 0)
				{
					return false;
				}
				class21_0.method_1(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (num >> 1)
				{
				case 0:
					class21_0.method_2();
					int_17 = 3;
					break;
				case 1:
					class23_0 = Class23.class23_0;
					class23_1 = Class23.class23_1;
					int_17 = 7;
					break;
				case 2:
					class24_0 = new Class24();
					int_17 = 6;
					break;
				}
				return true;
			}
			case 3:
				if ((int_21 = class21_0.method_0(16)) < 0)
				{
					return false;
				}
				class21_0.method_1(16);
				int_17 = 4;
				goto case 4;
			case 4:
			{
				int num2 = class21_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				class21_0.method_1(16);
				int_17 = 5;
				goto case 5;
			}
			case 5:
			{
				int num3 = class22_0.method_3(class21_0, int_21);
				int_21 -= num3;
				if (int_21 == 0)
				{
					int_17 = 2;
					return true;
				}
				return !class21_0.IsNeedingInput;
			}
			case 6:
				if (!class24_0.method_0(class21_0))
				{
					return false;
				}
				class23_0 = class24_0.method_1();
				class23_1 = class24_0.method_2();
				int_17 = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return method_0();
			default:
				return false;
			case 12:
				return false;
			}
		}

		public int method_2(byte[] byte_0, int int_22, int int_23)
		{
			int num = 0;
			do
			{
				if (int_17 != 11)
				{
					int num2 = class22_0.method_7(byte_0, int_22, int_23);
					int_22 += num2;
					num += num2;
					int_23 -= num2;
					if (int_23 == 0)
					{
						return num;
					}
				}
			}
			while (method_1() || (class22_0.method_6() > 0 && int_17 != 11));
			return num;
		}
	}

	internal sealed class Class21
	{
		private byte[] byte_0;

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		public int method_0(int int_3)
		{
			if (int_2 < int_3)
			{
				if (int_0 == int_1)
				{
					return -1;
				}
				uint_0 |= (uint)(((byte_0[int_0++] & 0xFF) | ((byte_0[int_0++] & 0xFF) << 8)) << int_2);
				int_2 += 16;
			}
			return (int)(uint_0 & ((1 << int_3) - 1));
		}

		public void method_1(int int_3)
		{
			uint_0 >>= int_3;
			int_2 -= int_3;
		}

		public void method_2()
		{
			uint_0 >>= int_2 & 7;
			int_2 &= -8;
		}

		public int method_3(byte[] byte_1, int int_3, int int_4)
		{
			int num = 0;
			while (int_2 > 0 && int_4 > 0)
			{
				byte_1[int_3++] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
				int_4--;
				num++;
			}
			if (int_4 == 0)
			{
				return num;
			}
			int num2 = int_1 - int_0;
			if (int_4 > num2)
			{
				int_4 = num2;
			}
			Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
			int_0 += int_4;
			if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
			{
				uint_0 = byte_0[int_0++] & 0xFFu;
				int_2 = 8;
			}
			return num + int_4;
		}

		public void method_4()
		{
			int_2 = 0;
			int_1 = 0;
			int_0 = 0;
			uint_0 = 0u;
		}

		public void method_5(byte[] byte_1, int int_3, int int_4)
		{
			if (int_0 < int_1)
			{
				throw new InvalidOperationException();
			}
			int num = int_3 + int_4;
			if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
			{
				if (((uint)int_4 & (true ? 1u : 0u)) != 0)
				{
					uint_0 |= (uint)((byte_1[int_3++] & 0xFF) << int_2);
					int_2 += 8;
				}
				byte_0 = byte_1;
				int_0 = int_3;
				int_1 = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	internal sealed class Class22
	{
		private const int int_0 = 32768;

		private const int int_1 = 32767;

		private byte[] byte_0 = new byte[32768];

		private int int_2 = 0;

		private int int_3 = 0;

		public void method_0(int int_4)
		{
			if (int_3++ == 32768)
			{
				throw new InvalidOperationException();
			}
			byte_0[int_2++] = (byte)int_4;
			int_2 &= 32767;
		}

		private void method_1(int int_4, int int_5, int int_6)
		{
			while (int_5-- > 0)
			{
				byte_0[int_2++] = byte_0[int_4++];
				int_2 &= 32767;
				int_4 &= 0x7FFF;
			}
		}

		public void method_2(int int_4, int int_5)
		{
			if ((int_3 += int_4) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (int_2 - int_5) & 0x7FFF;
			int num2 = 32768 - int_4;
			if (num <= num2 && int_2 < num2)
			{
				if (int_4 <= int_5)
				{
					Array.Copy(byte_0, num, byte_0, int_2, int_4);
					int_2 += int_4;
				}
				else
				{
					while (int_4-- > 0)
					{
						byte_0[int_2++] = byte_0[num++];
					}
				}
			}
			else
			{
				method_1(num, int_4, int_5);
			}
		}

		public int method_3(Class21 class21_0, int int_4)
		{
			int_4 = Math.Min(Math.Min(int_4, 32768 - int_3), class21_0.AvailableBytes);
			int num = 32768 - int_2;
			int num2;
			if (int_4 > num)
			{
				num2 = class21_0.method_3(byte_0, int_2, num);
				if (num2 == num)
				{
					num2 += class21_0.method_3(byte_0, 0, int_4 - num);
				}
			}
			else
			{
				num2 = class21_0.method_3(byte_0, int_2, int_4);
			}
			int_2 = (int_2 + num2) & 0x7FFF;
			int_3 += num2;
			return num2;
		}

		public void method_4(byte[] byte_1, int int_4, int int_5)
		{
			if (int_3 > 0)
			{
				throw new InvalidOperationException();
			}
			if (int_5 > 32768)
			{
				int_4 += int_5 - 32768;
				int_5 = 32768;
			}
			Array.Copy(byte_1, int_4, byte_0, 0, int_5);
			int_2 = int_5 & 0x7FFF;
		}

		public int method_5()
		{
			return 32768 - int_3;
		}

		public int method_6()
		{
			return int_3;
		}

		public int method_7(byte[] byte_1, int int_4, int int_5)
		{
			int num = int_2;
			if (int_5 > int_3)
			{
				int_5 = int_3;
			}
			else
			{
				num = (int_2 - int_3 + int_5) & 0x7FFF;
			}
			int num2 = int_5;
			int num3 = int_5 - num;
			if (num3 > 0)
			{
				Array.Copy(byte_0, 32768 - num3, byte_1, int_4, num3);
				int_4 += num3;
				int_5 = num;
			}
			Array.Copy(byte_0, num - int_5, byte_1, int_4, int_5);
			int_3 -= num2;
			if (int_3 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}

		public void method_8()
		{
			int_2 = 0;
			int_3 = 0;
		}
	}

	internal sealed class Class23
	{
		private const int int_0 = 15;

		private short[] short_0;

		public static readonly Class23 class23_0;

		public static readonly Class23 class23_1;

		static Class23()
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
			class23_0 = new Class23(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class23_1 = new Class23(array);
		}

		public Class23(byte[] byte_0)
		{
			method_0(byte_0);
		}

		private void method_0(byte[] byte_0)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			foreach (int num in byte_0)
			{
				if (num > 0)
				{
					int[] array3;
					int[] array4 = (array3 = array);
					nint num2 = num;
					array4[num] = array3[num2] + 1;
				}
			}
			int num3 = 0;
			int num4 = 512;
			for (int j = 1; j <= 15; j++)
			{
				array2[j] = num3;
				num3 += array[j] << 16 - j;
				if (j >= 10)
				{
					int num5 = array2[j] & 0x1FF80;
					int num6 = num3 & 0x1FF80;
					num4 += num6 - num5 >> 16 - j;
				}
			}
			short_0 = new short[num4];
			int num7 = 512;
			for (int num8 = 15; num8 >= 10; num8--)
			{
				int num9 = num3 & 0x1FF80;
				num3 -= array[num8] << 16 - num8;
				int num10 = num3 & 0x1FF80;
				for (int k = num10; k < num9; k += 128)
				{
					short_0[Class26.smethod_0(k)] = (short)((-num7 << 4) | num8);
					num7 += 1 << num8 - 9;
				}
			}
			for (int l = 0; l < byte_0.Length; l++)
			{
				int num11 = byte_0[l];
				if (num11 == 0)
				{
					continue;
				}
				num3 = array2[num11];
				int num12 = Class26.smethod_0(num3);
				if (num11 <= 9)
				{
					do
					{
						short_0[num12] = (short)((l << 4) | num11);
						num12 += 1 << num11;
					}
					while (num12 < 512);
				}
				else
				{
					int num13 = short_0[num12 & 0x1FF];
					int num14 = 1 << (num13 & 0xF);
					num13 = -(num13 >> 4);
					do
					{
						short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
						num12 += 1 << num11;
					}
					while (num12 < num14);
				}
				array2[num11] = num3 + (1 << 16 - num11);
			}
		}

		public int method_1(Class21 class21_0)
		{
			int num;
			int num2;
			if ((num = class21_0.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					class21_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int int_ = num2 & 0xF;
				if ((num = class21_0.method_0(int_)) >= 0)
				{
					num2 = short_0[num3 | (num >> 9)];
					class21_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = class21_0.AvailableBits;
				num = class21_0.method_0(availableBits);
				num2 = short_0[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					class21_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int availableBits2 = class21_0.AvailableBits;
			num = class21_0.method_0(availableBits2);
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
			{
				class21_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class Class24
	{
		private const int int_0 = 0;

		private const int int_1 = 1;

		private const int int_2 = 2;

		private const int int_3 = 3;

		private const int int_4 = 4;

		private const int int_5 = 5;

		private static readonly int[] int_6 = new int[3] { 3, 3, 11 };

		private static readonly int[] int_7 = new int[3] { 2, 3, 7 };

		private byte[] byte_0;

		private byte[] byte_1;

		private Class23 class23_0;

		private int int_8;

		private int int_9;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private byte byte_2;

		private int int_14;

		private static readonly int[] int_15 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		public bool method_0(Class21 class21_0)
		{
			while (true)
			{
				switch (int_8)
				{
				case 5:
				{
					int num = int_7[int_13];
					int num2 = class21_0.method_0(num);
					if (num2 >= 0)
					{
						class21_0.method_1(num);
						num2 += int_6[int_13];
						while (num2-- > 0)
						{
							byte_1[int_14++] = byte_2;
						}
						if (int_14 == int_12)
						{
							return true;
						}
						goto IL_009b;
					}
					return false;
				}
				case 4:
				{
					int num3;
					while (((num3 = class23_0.method_1(class21_0)) & -16) == 0)
					{
						byte_1[int_14++] = (byte_2 = (byte)num3);
						if (int_14 == int_12)
						{
							return true;
						}
					}
					if (num3 >= 0)
					{
						if (num3 >= 17)
						{
							byte_2 = 0;
						}
						int_13 = num3 - 16;
						int_8 = 5;
						goto case 5;
					}
					return false;
				}
				case 3:
					while (int_14 < int_11)
					{
						int num4 = class21_0.method_0(3);
						if (num4 >= 0)
						{
							class21_0.method_1(3);
							byte_0[int_15[int_14]] = (byte)num4;
							int_14++;
							continue;
						}
						return false;
					}
					class23_0 = new Class23(byte_0);
					byte_0 = null;
					int_14 = 0;
					int_8 = 4;
					goto case 4;
				case 2:
					int_11 = class21_0.method_0(4);
					if (int_11 >= 0)
					{
						int_11 += 4;
						class21_0.method_1(4);
						byte_0 = new byte[19];
						int_14 = 0;
						int_8 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_10 = class21_0.method_0(5);
					if (int_10 >= 0)
					{
						int_10++;
						class21_0.method_1(5);
						int_12 = int_9 + int_10;
						byte_1 = new byte[int_12];
						int_8 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_9 = class21_0.method_0(5);
					if (int_9 >= 0)
					{
						int_9 += 257;
						class21_0.method_1(5);
						int_8 = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_009b:
				int_8 = 4;
			}
		}

		public Class23 method_1()
		{
			byte[] destinationArray = new byte[int_9];
			Array.Copy(byte_1, 0, destinationArray, 0, int_9);
			return new Class23(destinationArray);
		}

		public Class23 method_2()
		{
			byte[] destinationArray = new byte[int_10];
			Array.Copy(byte_1, int_9, destinationArray, 0, int_10);
			return new Class23(destinationArray);
		}
	}

	internal sealed class Class25
	{
		private const int int_0 = 4;

		private const int int_1 = 8;

		private const int int_2 = 16;

		private const int int_3 = 20;

		private const int int_4 = 28;

		private const int int_5 = 30;

		private int int_6 = 16;

		private long long_0 = 0L;

		private Class29 class29_0;

		private Class28 class28_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_6 == 30)
				{
					return class29_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => class28_0.method_8();

		public Class25()
		{
			class29_0 = new Class29();
			class28_0 = new Class28(class29_0);
		}

		public void method_0()
		{
			int_6 |= 12;
		}

		public void method_1(byte[] byte_0)
		{
			class28_0.method_7(byte_0);
		}

		public int method_2(byte[] byte_0)
		{
			int num = 0;
			int num2 = byte_0.Length;
			int num3 = num2;
			while (true)
			{
				int num4 = class29_0.method_4(byte_0, num, num2);
				num += num4;
				long_0 += num4;
				num2 -= num4;
				if (num2 == 0 || int_6 == 30)
				{
					break;
				}
				if (class28_0.method_6((int_6 & 4) != 0, (int_6 & 8) != 0))
				{
					continue;
				}
				if (int_6 != 16)
				{
					if (int_6 == 20)
					{
						for (int num5 = 8 + (-class29_0.BitCount & 7); num5 > 0; num5 -= 10)
						{
							class29_0.method_3(2, 10);
						}
						int_6 = 16;
					}
					else if (int_6 == 28)
					{
						class29_0.method_2();
						int_6 = 30;
					}
					continue;
				}
				return num3 - num2;
			}
			return num3 - num2;
		}
	}

	internal sealed class Class26
	{
		public sealed class Class27
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class26 class26_0;

			public Class27(Class26 class26_1, int int_4, int int_5, int int_6)
			{
				class26_0 = class26_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}

			public void method_0(int int_4)
			{
				class26_0.class29_0.method_3(short_1[int_4] & 0xFFFF, byte_0[int_4]);
			}

			public void method_1(short[] short_2, byte[] byte_1)
			{
				short_1 = short_2;
				byte_0 = byte_1;
			}

			public void method_2()
			{
				int[] array = new int[int_3];
				int num = 0;
				short_1 = new short[short_0.Length];
				for (int i = 0; i < int_3; i++)
				{
					array[i] = num;
					num += int_2[i] << 15 - i;
				}
				for (int j = 0; j < int_1; j++)
				{
					int num2 = byte_0[j];
					if (num2 > 0)
					{
						short_1[j] = smethod_0(array[num2 - 1]);
						int[] array2;
						int[] array3 = (array2 = array);
						int num3 = num2 - 1;
						nint num4 = num3;
						array3[num3] = array2[num4] + (1 << 16 - num2);
					}
				}
			}

			private void method_3(int[] int_4)
			{
				byte_0 = new byte[short_0.Length];
				int num = int_4.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < int_3; i++)
				{
					int_2[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				int[] array2;
				nint num8;
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
						int[] array3 = (array2 = int_2);
						int num7 = num6 - 1;
						num8 = num7;
						array3[num7] = array2[num8] + 1;
						byte_0[int_4[2 * num4]] = (byte)array[num4];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num9 = int_3 - 1;
				while (true)
				{
					if (int_2[--num9] != 0)
					{
						do
						{
							int[] array4 = (array2 = int_2);
							int num10 = num9;
							num8 = num10;
							array4[num10] = array2[num8] - 1;
							int[] array5 = (array2 = int_2);
							int num11 = ++num9;
							num8 = num11;
							array5[num11] = array2[num8] + 1;
							num3 -= 1 << int_3 - 1 - num9;
						}
						while (num3 > 0 && num9 < int_3 - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				int[] array6 = (array2 = int_2);
				int num12 = int_3 - 1;
				num8 = num12;
				array6[num12] = array2[num8] + num3;
				int[] array7 = (array2 = int_2);
				int num13 = int_3 - 2;
				num8 = num13;
				array7[num13] = array2[num8] - num3;
				int num14 = 2 * num2;
				for (int num15 = int_3; num15 != 0; num15--)
				{
					int num16 = int_2[num15 - 1];
					while (num16 > 0)
					{
						int num17 = 2 * int_4[num14++];
						if (int_4[num17 + 1] == -1)
						{
							byte_0[int_4[num17]] = (byte)num15;
							num16--;
						}
					}
				}
			}

			public void method_4()
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
				int_1 = Math.Max(num3 + 1, int_0);
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
				method_3(array2);
			}

			public int method_5()
			{
				int num = 0;
				for (int i = 0; i < short_0.Length; i++)
				{
					num += short_0[i] * byte_0[i];
				}
				return num;
			}

			public void method_6(Class27 class27_0)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < int_1)
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
							short[] array;
							short[] array2 = (array = class27_0.short_0);
							nint num7 = num4;
							array2[num4] = (short)(array[num7] + 1);
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < int_1 && num == byte_0[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					if (num3 < num6)
					{
						short[] array;
						short[] array3 = (array = class27_0.short_0);
						int num8 = num;
						nint num7 = num8;
						array3[num8] = (short)(array[num7] + (short)num3);
					}
					else if (num != 0)
					{
						short[] array;
						(array = class27_0.short_0)[16] = (short)(array[16] + 1);
					}
					else if (num3 <= 10)
					{
						short[] array;
						(array = class27_0.short_0)[17] = (short)(array[17] + 1);
					}
					else
					{
						short[] array;
						(array = class27_0.short_0)[18] = (short)(array[18] + 1);
					}
				}
			}

			public void method_7(Class27 class27_0)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < int_1)
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
							class27_0.method_0(num4);
							num3 = 0;
						}
					}
					num = num4;
					num2++;
					while (num2 < int_1 && num == byte_0[num2])
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
							class27_0.method_0(num);
						}
					}
					else if (num != 0)
					{
						class27_0.method_0(16);
						class26_0.class29_0.method_3(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						class27_0.method_0(17);
						class26_0.class29_0.method_3(num3 - 3, 3);
					}
					else
					{
						class27_0.method_0(18);
						class26_0.class29_0.method_3(num3 - 11, 7);
					}
				}
			}
		}

		private const int int_0 = 16384;

		private const int int_1 = 286;

		private const int int_2 = 30;

		private const int int_3 = 19;

		private const int int_4 = 16;

		private const int int_5 = 17;

		private const int int_6 = 18;

		private const int int_7 = 256;

		private static readonly int[] int_8;

		private static readonly byte[] byte_0;

		private Class29 class29_0;

		private Class27 class27_0;

		private Class27 class27_1;

		private Class27 class27_2;

		private short[] short_0;

		private byte[] byte_1;

		private int int_9;

		private int int_10;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		private static readonly short[] short_2;

		private static readonly byte[] byte_3;

		public static short smethod_0(int int_11)
		{
			return (short)((byte_0[int_11 & 0xF] << 12) | (byte_0[(int_11 >> 4) & 0xF] << 8) | (byte_0[(int_11 >> 8) & 0xF] << 4) | byte_0[int_11 >> 12]);
		}

		static Class26()
		{
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
			short_1 = new short[286];
			byte_2 = new byte[286];
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
			while (num < 286)
			{
				short_1[num] = smethod_0(-88 + num << 8);
				byte_2[num++] = 8;
			}
			short_2 = new short[30];
			byte_3 = new byte[30];
			for (num = 0; num < 30; num++)
			{
				short_2[num] = smethod_0(num << 11);
				byte_3[num] = 5;
			}
		}

		public Class26(Class29 class29_1)
		{
			class29_0 = class29_1;
			class27_0 = new Class27(this, 286, 257, 15);
			class27_1 = new Class27(this, 30, 1, 15);
			class27_2 = new Class27(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		public void method_0()
		{
			int_9 = 0;
			int_10 = 0;
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
			class27_2.method_2();
			class27_0.method_2();
			class27_1.method_2();
			class29_0.method_3(class27_0.int_1 - 257, 5);
			class29_0.method_3(class27_1.int_1 - 1, 5);
			class29_0.method_3(int_11 - 4, 4);
			for (int i = 0; i < int_11; i++)
			{
				class29_0.method_3(class27_2.byte_0[int_8[i]], 3);
			}
			class27_0.method_7(class27_2);
			class27_1.method_7(class27_2);
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
					class27_0.method_0(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						class29_0.method_3(num & ((1 << num4) - 1), num4);
					}
					int num5 = method_2(num2);
					class27_1.method_0(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						class29_0.method_3(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					class27_0.method_0(num);
				}
			}
			class27_0.method_0(256);
		}

		public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			class29_0.method_3(bool_0 ? 1 : 0, 3);
			class29_0.method_2();
			class29_0.method_0(int_12);
			class29_0.method_0(~int_12);
			class29_0.method_1(byte_4, int_11, int_12);
			method_0();
		}

		public void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			short[] array;
			(array = class27_0.short_0)[256] = (short)(array[256] + 1);
			class27_0.method_4();
			class27_1.method_4();
			class27_0.method_6(class27_2);
			class27_1.method_6(class27_2);
			class27_2.method_4();
			int num = 4;
			for (int num2 = 18; num2 > num; num2--)
			{
				if (class27_2.byte_0[int_8[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			int num3 = 14 + num * 3 + class27_2.method_5() + class27_0.method_5() + class27_1.method_5() + int_10;
			int num4 = int_10;
			for (int i = 0; i < 286; i++)
			{
				num4 += class27_0.short_0[i] * byte_2[i];
			}
			for (int j = 0; j < 30; j++)
			{
				num4 += class27_1.short_0[j] * byte_3[j];
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
				class29_0.method_3(2 + (bool_0 ? 1 : 0), 3);
				class27_0.method_1(short_1, byte_2);
				class27_1.method_1(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class29_0.method_3(4 + (bool_0 ? 1 : 0), 3);
				method_3(num);
				method_4();
				method_0();
			}
		}

		public bool method_7()
		{
			return int_9 >= 16384;
		}

		public bool method_8(int int_11)
		{
			short_0[int_9] = 0;
			byte_1[int_9++] = (byte)int_11;
			short[] array;
			short[] array2 = (array = class27_0.short_0);
			nint num = int_11;
			array2[int_11] = (short)(array[num] + 1);
			return method_7();
		}

		public bool method_9(int int_11, int int_12)
		{
			short_0[int_9] = (short)int_11;
			byte_1[int_9++] = (byte)(int_12 - 3);
			int num = method_1(int_12 - 3);
			short[] array;
			short[] array2 = (array = class27_0.short_0);
			nint num2 = num;
			array2[num] = (short)(array[num2] + 1);
			if (num >= 265 && num < 285)
			{
				int_10 += (num - 261) / 4;
			}
			int num3 = method_2(int_11 - 1);
			short[] array3 = (array = class27_1.short_0);
			num2 = num3;
			array3[num3] = (short)(array[num2] + 1);
			if (num3 >= 4)
			{
				int_10 += num3 / 2 - 1;
			}
			return method_7();
		}
	}

	internal sealed class Class28
	{
		private const int int_0 = 258;

		private const int int_1 = 3;

		private const int int_2 = 32768;

		private const int int_3 = 32767;

		private const int int_4 = 32768;

		private const int int_5 = 32767;

		private const int int_6 = 5;

		private const int int_7 = 262;

		private const int int_8 = 32506;

		private const int int_9 = 4096;

		private int int_10;

		private short[] short_0;

		private short[] short_1;

		private int int_11;

		private int int_12;

		private bool bool_0;

		private int int_13;

		private int int_14;

		private int int_15;

		private byte[] byte_0;

		private byte[] byte_1;

		private int int_16;

		private int int_17;

		private int int_18;

		private Class29 class29_0;

		private Class26 class26_0;

		public Class28(Class29 class29_1)
		{
			class29_0 = class29_1;
			class26_0 = new Class26(class29_1);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int_14 = 1;
			int_13 = 1;
		}

		private void method_0()
		{
			int_10 = (byte_0[int_14] << 5) ^ byte_0[int_14 + 1];
		}

		private int method_1()
		{
			int num = ((int_10 << 5) ^ byte_0[int_14 + 2]) & 0x7FFF;
			short num2 = (short_1[int_14 & 0x7FFF] = short_0[num]);
			short_0[num] = (short)int_14;
			int_10 = num;
			return num2 & 0xFFFF;
		}

		private void method_2()
		{
			Array.Copy(byte_0, 32768, byte_0, 0, 32768);
			int_11 -= 32768;
			int_14 -= 32768;
			int_13 -= 32768;
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

		public void method_3()
		{
			if (int_14 >= 65274)
			{
				method_2();
			}
			while (int_15 < 262 && int_17 < int_18)
			{
				int num = 65536 - int_15 - int_14;
				if (num > int_18 - int_17)
				{
					num = int_18 - int_17;
				}
				Array.Copy(byte_1, int_17, byte_0, int_14 + int_15, num);
				int_17 += num;
				int_16 += num;
				int_15 += num;
			}
			if (int_15 >= 3)
			{
				method_0();
			}
		}

		private bool method_4(int int_19)
		{
			int num = 128;
			int num2 = 128;
			short[] array = short_1;
			int num3 = int_14;
			int num4 = int_14 + int_12;
			int num5 = Math.Max(int_12, 2);
			int num6 = Math.Max(int_14 - 32506, 0);
			int num7 = int_14 + 258 - 1;
			byte b = byte_0[num4 - 1];
			byte b2 = byte_0[num4];
			if (num5 >= 8)
			{
				num >>= 2;
			}
			if (num2 > int_15)
			{
				num2 = int_15;
			}
			do
			{
				if (byte_0[int_19 + num5] != b2 || byte_0[int_19 + num5 - 1] != b || byte_0[int_19] != byte_0[num3] || byte_0[int_19 + 1] != byte_0[num3 + 1])
				{
					continue;
				}
				int num8 = int_19 + 2;
				num3 += 2;
				while (byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					int_11 = int_19;
					num4 = num3;
					num5 = num3 - int_14;
					if (num5 >= num2)
					{
						break;
					}
					b = byte_0[num4 - 1];
					b2 = byte_0[num4];
				}
				num3 = int_14;
			}
			while ((int_19 = array[int_19 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			int_12 = Math.Min(num5, int_15);
			return int_12 >= 3;
		}

		private bool method_5(bool bool_1, bool bool_2)
		{
			if (int_15 < 262 && !bool_1)
			{
				return false;
			}
			do
			{
				if (int_15 >= 262 || bool_1)
				{
					if (int_15 != 0)
					{
						if (int_14 >= 65274)
						{
							method_2();
						}
						int num = int_11;
						int num2 = int_12;
						if (int_15 >= 3)
						{
							int num3 = method_1();
							if (num3 != 0 && int_14 - num3 <= 32506 && method_4(num3) && int_12 <= 5 && int_12 == 3 && int_14 - int_11 > 4096)
							{
								int_12 = 2;
							}
						}
						if (num2 >= 3 && int_12 <= num2)
						{
							class26_0.method_9(int_14 - 1 - num, num2);
							num2 -= 2;
							do
							{
								int_14++;
								int_15--;
								if (int_15 >= 3)
								{
									method_1();
								}
							}
							while (--num2 > 0);
							int_14++;
							int_15--;
							bool_0 = false;
							int_12 = 2;
						}
						else
						{
							if (bool_0)
							{
								class26_0.method_8(byte_0[int_14 - 1] & 0xFF);
							}
							bool_0 = true;
							int_14++;
							int_15--;
						}
						continue;
					}
					if (bool_0)
					{
						class26_0.method_8(byte_0[int_14 - 1] & 0xFF);
					}
					bool_0 = false;
					class26_0.method_6(byte_0, int_13, int_14 - int_13, bool_2);
					int_13 = int_14;
					return false;
				}
				return true;
			}
			while (!class26_0.method_7());
			int num4 = int_14 - int_13;
			if (bool_0)
			{
				num4--;
			}
			bool flag = bool_2 && int_15 == 0 && !bool_0;
			class26_0.method_6(byte_0, int_13, num4, flag);
			int_13 += num4;
			return !flag;
		}

		public bool method_6(bool bool_1, bool bool_2)
		{
			bool flag;
			do
			{
				method_3();
				bool bool_3 = bool_1 && int_17 == int_18;
				flag = method_5(bool_3, bool_2);
			}
			while (class29_0.IsFlushed && flag);
			return flag;
		}

		public void method_7(byte[] byte_2)
		{
			byte_1 = byte_2;
			int_17 = 0;
			int_18 = byte_2.Length;
		}

		public bool method_8()
		{
			return int_18 == int_17;
		}
	}

	internal sealed class Class29
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		public void method_0(int int_3)
		{
			byte_0[int_1++] = (byte)int_3;
			byte_0[int_1++] = (byte)(int_3 >> 8);
		}

		public void method_1(byte[] byte_1, int int_3, int int_4)
		{
			Array.Copy(byte_1, int_3, byte_0, int_1, int_4);
			int_1 += int_4;
		}

		public void method_2()
		{
			if (int_2 > 0)
			{
				byte_0[int_1++] = (byte)uint_0;
				if (int_2 > 8)
				{
					byte_0[int_1++] = (byte)(uint_0 >> 8);
				}
			}
			uint_0 = 0u;
			int_2 = 0;
		}

		public void method_3(int int_3, int int_4)
		{
			uint_0 |= (uint)(int_3 << int_2);
			int_2 += int_4;
			if (int_2 >= 16)
			{
				byte_0[int_1++] = (byte)uint_0;
				byte_0[int_1++] = (byte)(uint_0 >> 8);
				uint_0 >>= 16;
				int_2 -= 16;
			}
		}

		public int method_4(byte[] byte_1, int int_3, int int_4)
		{
			if (int_2 >= 8)
			{
				byte_0[int_1++] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
			}
			if (int_4 > int_1 - int_0)
			{
				int_4 = int_1 - int_0;
				Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
				int_0 = 0;
				int_1 = 0;
			}
			else
			{
				Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
				int_0 += int_4;
			}
			return int_4;
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public void method_0(int int_0)
		{
			WriteByte((byte)((uint)int_0 & 0xFFu));
			WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
		}

		public void method_1(int int_0)
		{
			method_0(int_0);
			method_0(int_0 >> 16);
		}

		public int method_2()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int method_3()
		{
			return method_2() | (method_2() << 16);
		}

		public Stream0()
		{
		}

		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}

	public static string string_0;

	private static bool smethod_0(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !smethod_0(executingAssembly, callingAssembly))
		{
			return null;
		}
		Stream0 stream = new Stream0(byte_0);
		byte[] array = new byte[0];
		int num = stream.method_3();
		if (num == 67324752)
		{
			short num2 = (short)stream.method_2();
			int num3 = stream.method_2();
			int num4 = stream.method_2();
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException(GClass4.smethod_0("AŧɻͽѵԱ\u0658ݪ\u086f३੩\u0b79ప൚\u0e61འ\u1068ᅤተ፶ᑰᕤ"));
			}
			stream.method_3();
			stream.method_3();
			stream.method_3();
			int num5 = stream.method_3();
			int num6 = stream.method_2();
			int num7 = stream.method_2();
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class20 @class = new Class20(array2);
			array = new byte[num5];
			@class.method_2(array, 0, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException(GClass4.smethod_0("[ţɧ\u0365ѥվ٦ܧࡎॠ\u0a65୧౧൳"));
			}
			if (num8 == 1)
			{
				int num9 = stream.method_3();
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = stream.method_3();
					num11 = stream.method_3();
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class20 class2 = new Class20(array3);
					class2.method_2(array, i, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 225, 20, 113, 205, 134, 94, 121, 113 };
				byte[] byte_2 = new byte[8] { 192, 85, 153, 91, 166, 215, 109, 6 };
				using Class18 class3 = new Class18();
				using ICryptoTransform cryptoTransform = class3.method_0(byte_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = smethod_1(byte_3);
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class17 class4 = new Class17();
				using ICryptoTransform cryptoTransform2 = class4.method_0(byte_4, byte_5, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = smethod_1(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		return smethod_5(byte_0, 1, null, null);
	}

	public static byte[] smethod_3(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return smethod_5(byte_0, 2, byte_1, byte_2);
	}

	public static byte[] smethod_4(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return smethod_5(byte_0, 3, byte_1, byte_2);
	}

	private static byte[] smethod_5(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Stream0 stream = new Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class25 class4 = new Class25();
				DateTime now = DateTime.Now;
				long num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				uint num4 = uint.MaxValue;
				uint num5 = uint.MaxValue;
				int num6 = 0;
				int num7 = byte_0.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_0[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				stream.method_1(67324752);
				stream.method_0(20);
				stream.method_0(0);
				stream.method_0(8);
				stream.method_1((int)num3);
				stream.method_1((int)num5);
				long position3 = stream.Position;
				stream.method_1(0);
				stream.method_1(byte_0.Length);
				byte[] bytes = Encoding.UTF8.GetBytes(GClass4.smethod_0("}šɥͷѣռ"));
				stream.method_0(bytes.Length);
				stream.method_0(0);
				stream.Write(bytes, 0, bytes.Length);
				class4.method_1(byte_0);
				while (!class4.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = class4.method_2(array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				class4.method_0();
				while (!class4.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = class4.method_2(array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class4.TotalOut;
				stream.method_1(33639248);
				stream.method_0(20);
				stream.method_0(20);
				stream.method_0(0);
				stream.method_0(8);
				stream.method_1((int)num3);
				stream.method_1((int)num5);
				stream.method_1((int)totalOut);
				stream.method_1(byte_0.Length);
				stream.method_0(bytes.Length);
				stream.method_0(0);
				stream.method_0(0);
				stream.method_0(0);
				stream.method_0(0);
				stream.method_1(0);
				stream.method_1(0);
				stream.Write(bytes, 0, bytes.Length);
				stream.method_1(101010256);
				stream.method_0(0);
				stream.method_0(0);
				stream.method_0(1);
				stream.method_0(1);
				stream.method_1(46 + bytes.Length);
				stream.method_1((int)(30 + bytes.Length + totalOut));
				stream.method_0(0);
				stream.Seek(position3, SeekOrigin.Begin);
				stream.method_1((int)totalOut);
				break;
			}
			case 1:
			{
				stream.method_1(25000571);
				stream.method_1(byte_0.Length);
				byte[] array5;
				for (int i = 0; i < byte_0.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_0.Length - i)];
					Buffer.BlockCopy(byte_0, i, array5, 0, array5.Length);
					long position = stream.Position;
					stream.method_1(0);
					stream.method_1(array5.Length);
					Class25 class3 = new Class25();
					class3.method_1(array5);
					while (!class3.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = class3.method_2(array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					class3.method_0();
					while (!class3.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = class3.method_2(array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					stream.method_1((int)class3.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				stream.method_1(41777787);
				byte[] array3 = smethod_5(byte_0, 1, null, null);
				using (Class18 class2 = new Class18())
				{
					using ICryptoTransform cryptoTransform2 = class2.method_0(byte_1, byte_2, bool_0: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				stream.method_1(58555003);
				byte[] array = smethod_5(byte_0, 1, null, null);
				using (Class17 @class = new Class17())
				{
					using ICryptoTransform cryptoTransform = @class.method_0(byte_1, byte_2, bool_0: false);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			string_0 = GClass4.smethod_0("Ośɚ\u0327дԵش\u0730࠸ड") + ex.Message;
			throw;
		}
	}
}
