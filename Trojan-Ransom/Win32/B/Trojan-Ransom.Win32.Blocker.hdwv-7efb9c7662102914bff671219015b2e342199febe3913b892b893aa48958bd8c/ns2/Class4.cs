using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using ns1;

namespace ns2;

internal class Class4
{
	internal sealed class Class5
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

		private Class6 class6_0;

		private Class7 class7_0;

		private Class9 class9_0;

		private Class8 class8_0;

		private Class8 class8_1;

		public Class5(byte[] bytes)
		{
			class6_0 = new Class6();
			class7_0 = new Class7();
			int_17 = 2;
			class6_0.method_5(bytes, 0, bytes.Length);
		}

		private bool method_0()
		{
			int num = class7_0.method_5();
			while (num >= 258)
			{
				switch (int_17)
				{
				case 7:
				{
					int num2;
					while (((num2 = class8_0.method_1(class6_0)) & -256) == 0)
					{
						class7_0.method_0(num2);
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
					class8_1 = null;
					class8_0 = null;
					int_17 = 2;
					return true;
				}
				case 8:
					if (int_18 > 0)
					{
						int_17 = 8;
						int num4 = class6_0.method_0(int_18);
						if (num4 < 0)
						{
							return false;
						}
						class6_0.method_1(int_18);
						int_19 += num4;
					}
					int_17 = 9;
					goto case 9;
				case 9:
				{
					int num2 = class8_1.method_1(class6_0);
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
						int num3 = class6_0.method_0(int_18);
						if (num3 < 0)
						{
							return false;
						}
						class6_0.method_1(int_18);
						int_20 += num3;
					}
					class7_0.method_2(int_19, int_20);
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
				int num = class6_0.method_0(3);
				if (num < 0)
				{
					return false;
				}
				class6_0.method_1(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (num >> 1)
				{
				case 0:
					class6_0.method_2();
					int_17 = 3;
					break;
				case 1:
					class8_0 = Class8.class8_0;
					class8_1 = Class8.class8_1;
					int_17 = 7;
					break;
				case 2:
					class9_0 = new Class9();
					int_17 = 6;
					break;
				}
				return true;
			}
			case 3:
				if ((int_21 = class6_0.method_0(16)) < 0)
				{
					return false;
				}
				class6_0.method_1(16);
				int_17 = 4;
				goto case 4;
			case 4:
			{
				int num2 = class6_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				class6_0.method_1(16);
				int_17 = 5;
				goto case 5;
			}
			case 5:
			{
				int num3 = class7_0.method_3(class6_0, int_21);
				int_21 -= num3;
				if (int_21 == 0)
				{
					int_17 = 2;
					return true;
				}
				return !class6_0.IsNeedingInput;
			}
			case 6:
				if (!class9_0.method_0(class6_0))
				{
					return false;
				}
				class8_0 = class9_0.method_1();
				class8_1 = class9_0.method_2();
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

		public int method_2(byte[] buf, int offset, int len)
		{
			int num = 0;
			do
			{
				if (int_17 != 11)
				{
					int num2 = class7_0.method_7(buf, offset, len);
					offset += num2;
					num += num2;
					len -= num2;
					if (len == 0)
					{
						return num;
					}
				}
			}
			while (method_1() || (class7_0.method_6() > 0 && int_17 != 11));
			return num;
		}
	}

	internal sealed class Class6
	{
		private byte[] byte_0;

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

		public int AvailableBits => int_2;

		public int AvailableBytes => int_1 - int_0 + (int_2 >> 3);

		public bool IsNeedingInput => int_0 == int_1;

		public int method_0(int n)
		{
			if (int_2 < n)
			{
				if (int_0 == int_1)
				{
					return -1;
				}
				uint_0 |= (uint)(((byte_0[int_0++] & 0xFF) | ((byte_0[int_0++] & 0xFF) << 8)) << int_2);
				int_2 += 16;
			}
			return (int)(uint_0 & ((1 << n) - 1));
		}

		public void method_1(int n)
		{
			uint_0 >>= n;
			int_2 -= n;
		}

		public void method_2()
		{
			uint_0 >>= int_2 & 7;
			int_2 &= -8;
		}

		public int method_3(byte[] output, int offset, int length)
		{
			int num = 0;
			while (int_2 > 0 && length > 0)
			{
				output[offset++] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
				length--;
				num++;
			}
			if (length == 0)
			{
				return num;
			}
			int num2 = int_1 - int_0;
			if (length > num2)
			{
				length = num2;
			}
			Array.Copy(byte_0, int_0, output, offset, length);
			int_0 += length;
			if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
			{
				uint_0 = byte_0[int_0++] & 0xFFu;
				int_2 = 8;
			}
			return num + length;
		}

		public void method_4()
		{
			int_2 = 0;
			int_1 = 0;
			int_0 = 0;
			uint_0 = 0u;
		}

		public void method_5(byte[] buf, int off, int len)
		{
			if (int_0 < int_1)
			{
				throw new InvalidOperationException();
			}
			int num = off + len;
			if (0 <= off && off <= num && num <= buf.Length)
			{
				if (((uint)len & (true ? 1u : 0u)) != 0)
				{
					uint_0 |= (uint)((buf[off++] & 0xFF) << int_2);
					int_2 += 8;
				}
				byte_0 = buf;
				int_0 = off;
				int_1 = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	internal sealed class Class7
	{
		private const int int_0 = 32768;

		private const int int_1 = 32767;

		private byte[] byte_0 = new byte[32768];

		private int int_2 = 0;

		private int int_3 = 0;

		public void method_0(int abyte)
		{
			if (int_3++ == 32768)
			{
				throw new InvalidOperationException();
			}
			byte_0[int_2++] = (byte)abyte;
			int_2 &= 32767;
		}

		private void method_1(int repStart, int len, int dist)
		{
			while (len-- > 0)
			{
				byte_0[int_2++] = byte_0[repStart++];
				int_2 &= 32767;
				repStart &= 0x7FFF;
			}
		}

		public void method_2(int len, int dist)
		{
			if ((int_3 += len) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (int_2 - dist) & 0x7FFF;
			int num2 = 32768 - len;
			if (num <= num2 && int_2 < num2)
			{
				if (len <= dist)
				{
					Array.Copy(byte_0, num, byte_0, int_2, len);
					int_2 += len;
				}
				else
				{
					while (len-- > 0)
					{
						byte_0[int_2++] = byte_0[num++];
					}
				}
			}
			else
			{
				method_1(num, len, dist);
			}
		}

		public int method_3(Class6 input, int len)
		{
			len = Math.Min(Math.Min(len, 32768 - int_3), input.AvailableBytes);
			int num = 32768 - int_2;
			int num2;
			if (len > num)
			{
				num2 = input.method_3(byte_0, int_2, num);
				if (num2 == num)
				{
					num2 += input.method_3(byte_0, 0, len - num);
				}
			}
			else
			{
				num2 = input.method_3(byte_0, int_2, len);
			}
			int_2 = (int_2 + num2) & 0x7FFF;
			int_3 += num2;
			return num2;
		}

		public void method_4(byte[] dict, int offset, int len)
		{
			if (int_3 > 0)
			{
				throw new InvalidOperationException();
			}
			if (len > 32768)
			{
				offset += len - 32768;
				len = 32768;
			}
			Array.Copy(dict, offset, byte_0, 0, len);
			int_2 = len & 0x7FFF;
		}

		public int method_5()
		{
			return 32768 - int_3;
		}

		public int method_6()
		{
			return int_3;
		}

		public int method_7(byte[] output, int offset, int len)
		{
			int num = int_2;
			if (len > int_3)
			{
				len = int_3;
			}
			else
			{
				num = (int_2 - int_3 + len) & 0x7FFF;
			}
			int num2 = len;
			int num3 = len - num;
			if (num3 > 0)
			{
				Array.Copy(byte_0, 32768 - num3, output, offset, num3);
				offset += num3;
				len = num;
			}
			Array.Copy(byte_0, num - len, output, offset, len);
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

	internal sealed class Class8
	{
		private const int int_0 = 15;

		private short[] short_0;

		public static readonly Class8 class8_0;

		public static readonly Class8 class8_1;

		static Class8()
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
			class8_0 = new Class8(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class8_1 = new Class8(array);
		}

		public Class8(byte[] codeLengths)
		{
			method_0(codeLengths);
		}

		private void method_0(byte[] codeLengths)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			foreach (int num in codeLengths)
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
			short_0 = new short[checked((uint)num4)];
			int num7 = 512;
			for (int num8 = 15; num8 >= 10; num8--)
			{
				int num9 = num3 & 0x1FF80;
				num3 -= array[num8] << 16 - num8;
				int num10 = num3 & 0x1FF80;
				for (int k = num10; k < num9; k += 128)
				{
					short_0[Class11.smethod_0(k)] = (short)((-num7 << 4) | num8);
					num7 += 1 << num8 - 9;
				}
			}
			for (int l = 0; l < codeLengths.Length; l++)
			{
				int num11 = codeLengths[l];
				if (num11 == 0)
				{
					continue;
				}
				num3 = array2[num11];
				int num12 = Class11.smethod_0(num3);
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

		public int method_1(Class6 input)
		{
			int num;
			int num2;
			if ((num = input.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					input.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int n = num2 & 0xF;
				if ((num = input.method_0(n)) >= 0)
				{
					num2 = short_0[num3 | (num >> 9)];
					input.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = input.AvailableBits;
				num = input.method_0(availableBits);
				num2 = short_0[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					input.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int availableBits2 = input.AvailableBits;
			num = input.method_0(availableBits2);
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
			{
				input.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class Class9
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

		private Class8 class8_0;

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

		public bool method_0(Class6 input)
		{
			while (true)
			{
				switch (int_8)
				{
				case 5:
				{
					int n = int_7[int_13];
					int num = input.method_0(n);
					if (num >= 0)
					{
						input.method_1(n);
						num += int_6[int_13];
						while (num-- > 0)
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
					int num2;
					while (((num2 = class8_0.method_1(input)) & -16) == 0)
					{
						byte_1[int_14++] = (byte_2 = (byte)num2);
						if (int_14 == int_12)
						{
							return true;
						}
					}
					if (num2 >= 0)
					{
						if (num2 >= 17)
						{
							byte_2 = 0;
						}
						int_13 = num2 - 16;
						int_8 = 5;
						goto case 5;
					}
					return false;
				}
				case 3:
					while (int_14 < int_11)
					{
						int num3 = input.method_0(3);
						if (num3 >= 0)
						{
							input.method_1(3);
							byte_0[int_15[int_14]] = (byte)num3;
							int_14++;
							continue;
						}
						return false;
					}
					class8_0 = new Class8(byte_0);
					byte_0 = null;
					int_14 = 0;
					int_8 = 4;
					goto case 4;
				case 2:
					int_11 = input.method_0(4);
					if (int_11 >= 0)
					{
						int_11 += 4;
						input.method_1(4);
						byte_0 = new byte[19];
						int_14 = 0;
						int_8 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_10 = input.method_0(5);
					if (int_10 >= 0)
					{
						int_10++;
						input.method_1(5);
						int_12 = int_9 + int_10;
						byte_1 = new byte[checked((uint)int_12)];
						int_8 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_9 = input.method_0(5);
					if (int_9 >= 0)
					{
						int_9 += 257;
						input.method_1(5);
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

		public Class8 method_1()
		{
			byte[] array = new byte[checked((uint)int_9)];
			Array.Copy(byte_1, 0, array, 0, int_9);
			return new Class8(array);
		}

		public Class8 method_2()
		{
			byte[] array = new byte[checked((uint)int_10)];
			Array.Copy(byte_1, int_9, array, 0, int_10);
			return new Class8(array);
		}
	}

	internal sealed class Class10
	{
		private const int int_0 = 4;

		private const int int_1 = 8;

		private const int int_2 = 16;

		private const int int_3 = 20;

		private const int int_4 = 28;

		private const int int_5 = 30;

		private int int_6 = 16;

		private long long_0 = 0L;

		private Class14 class14_0;

		private Class13 class13_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_6 == 30)
				{
					return class14_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => class13_0.method_8();

		public Class10()
		{
			class14_0 = new Class14();
			class13_0 = new Class13(class14_0);
		}

		public void method_0()
		{
			int_6 |= 12;
		}

		public void method_1(byte[] buffer)
		{
			class13_0.method_7(buffer);
		}

		public int method_2(byte[] output)
		{
			int num = 0;
			int num2 = output.Length;
			int num3 = num2;
			while (true)
			{
				int num4 = class14_0.method_4(output, num, num2);
				num += num4;
				long_0 += num4;
				num2 -= num4;
				if (num2 == 0 || int_6 == 30)
				{
					break;
				}
				if (class13_0.method_6((int_6 & 4) != 0, (int_6 & 8) != 0))
				{
					continue;
				}
				if (int_6 != 16)
				{
					if (int_6 == 20)
					{
						for (int num5 = 8 + (-class14_0.BitCount & 7); num5 > 0; num5 -= 10)
						{
							class14_0.method_3(2, 10);
						}
						int_6 = 16;
					}
					else if (int_6 == 28)
					{
						class14_0.method_2();
						int_6 = 30;
					}
					continue;
				}
				return num3 - num2;
			}
			return num3 - num2;
		}
	}

	internal sealed class Class11
	{
		public sealed class Class12
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class11 class11_0;

			public Class12(Class11 dh, int elems, int minCodes, int maxLength)
			{
				class11_0 = dh;
				int_0 = minCodes;
				int_3 = maxLength;
				checked
				{
					short_0 = new short[(uint)elems];
					int_2 = new int[(uint)maxLength];
				}
			}

			public void method_0(int code)
			{
				class11_0.class14_0.method_3(short_1[code] & 0xFFFF, byte_0[code]);
			}

			public void method_1(short[] stCodes, byte[] stLength)
			{
				short_1 = stCodes;
				byte_0 = stLength;
			}

			public void method_2()
			{
				int[] array;
				int num;
				checked
				{
					array = new int[(uint)int_3];
					num = 0;
					short_1 = new short[(uint)short_0.Length];
				}
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

			private void method_3(int[] childs)
			{
				byte_0 = new byte[checked((uint)short_0.Length)];
				int num = childs.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < int_3; i++)
				{
					int_2[i] = 0;
				}
				int[] array = new int[checked((uint)num)];
				array[num - 1] = 0;
				int[] array2;
				nint num8;
				for (int num4 = num - 1; num4 >= 0; num4--)
				{
					if (childs[2 * num4 + 1] != -1)
					{
						int num5 = array[num4] + 1;
						if (num5 > int_3)
						{
							num5 = int_3;
							num3++;
						}
						array[childs[2 * num4]] = (array[childs[2 * num4 + 1]] = num5);
					}
					else
					{
						int num6 = array[num4];
						int[] array3 = (array2 = int_2);
						int num7 = num6 - 1;
						num8 = num7;
						array3[num7] = array2[num8] + 1;
						byte_0[childs[2 * num4]] = (byte)array[num4];
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
						int num17 = 2 * childs[num14++];
						if (childs[num17 + 1] == -1)
						{
							byte_0[childs[num17]] = (byte)num15;
							num16--;
						}
					}
				}
			}

			public void method_4()
			{
				int num = short_0.Length;
				int[] array = new int[checked((uint)num)];
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
				int[] array2;
				int[] array3;
				int num9;
				checked
				{
					array2 = new int[(uint)unchecked(4 * num2 - 2)];
					array3 = new int[(uint)unchecked(2 * num2 - 1)];
					num9 = num8;
				}
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

			public void method_6(Class12 blTree)
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
							short[] array2 = (array = blTree.short_0);
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
						short[] array3 = (array = blTree.short_0);
						int num8 = num;
						nint num7 = num8;
						array3[num8] = (short)(array[num7] + (short)num3);
					}
					else if (num != 0)
					{
						short[] array;
						(array = blTree.short_0)[16] = (short)(array[16] + 1);
					}
					else if (num3 <= 10)
					{
						short[] array;
						(array = blTree.short_0)[17] = (short)(array[17] + 1);
					}
					else
					{
						short[] array;
						(array = blTree.short_0)[18] = (short)(array[18] + 1);
					}
				}
			}

			public void method_7(Class12 blTree)
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
							blTree.method_0(num4);
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
							blTree.method_0(num);
						}
					}
					else if (num != 0)
					{
						blTree.method_0(16);
						class11_0.class14_0.method_3(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						blTree.method_0(17);
						class11_0.class14_0.method_3(num3 - 3, 3);
					}
					else
					{
						blTree.method_0(18);
						class11_0.class14_0.method_3(num3 - 11, 7);
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

		private Class14 class14_0;

		private Class12 class12_0;

		private Class12 class12_1;

		private Class12 class12_2;

		private short[] short_0;

		private byte[] byte_1;

		private int int_9;

		private int int_10;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		private static readonly short[] short_2;

		private static readonly byte[] byte_3;

		public static short smethod_0(int toReverse)
		{
			return (short)((byte_0[toReverse & 0xF] << 12) | (byte_0[(toReverse >> 4) & 0xF] << 8) | (byte_0[(toReverse >> 8) & 0xF] << 4) | byte_0[toReverse >> 12]);
		}

		static Class11()
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

		public Class11(Class14 pending)
		{
			class14_0 = pending;
			class12_0 = new Class12(this, 286, 257, 15);
			class12_1 = new Class12(this, 30, 1, 15);
			class12_2 = new Class12(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		public void method_0()
		{
			int_9 = 0;
			int_10 = 0;
		}

		private int method_1(int len)
		{
			if (len == 255)
			{
				return 285;
			}
			int num = 257;
			while (len >= 8)
			{
				num += 4;
				len >>= 1;
			}
			return num + len;
		}

		private int method_2(int distance)
		{
			int num = 0;
			while (distance >= 4)
			{
				num += 2;
				distance >>= 1;
			}
			return num + distance;
		}

		public void method_3(int blTreeCodes)
		{
			class12_2.method_2();
			class12_0.method_2();
			class12_1.method_2();
			class14_0.method_3(class12_0.int_1 - 257, 5);
			class14_0.method_3(class12_1.int_1 - 1, 5);
			class14_0.method_3(blTreeCodes - 4, 4);
			for (int i = 0; i < blTreeCodes; i++)
			{
				class14_0.method_3(class12_2.byte_0[int_8[i]], 3);
			}
			class12_0.method_7(class12_2);
			class12_1.method_7(class12_2);
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
					class12_0.method_0(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						class14_0.method_3(num & ((1 << num4) - 1), num4);
					}
					int num5 = method_2(num2);
					class12_1.method_0(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						class14_0.method_3(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					class12_0.method_0(num);
				}
			}
			class12_0.method_0(256);
		}

		public void method_5(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			class14_0.method_3(lastBlock ? 1 : 0, 3);
			class14_0.method_2();
			class14_0.method_0(storedLength);
			class14_0.method_0(~storedLength);
			class14_0.method_1(stored, storedOffset, storedLength);
			method_0();
		}

		public void method_6(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			short[] array;
			(array = class12_0.short_0)[256] = (short)(array[256] + 1);
			class12_0.method_4();
			class12_1.method_4();
			class12_0.method_6(class12_2);
			class12_1.method_6(class12_2);
			class12_2.method_4();
			int num = 4;
			for (int num2 = 18; num2 > num; num2--)
			{
				if (class12_2.byte_0[int_8[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			int num3 = 14 + num * 3 + class12_2.method_5() + class12_0.method_5() + class12_1.method_5() + int_10;
			int num4 = int_10;
			for (int i = 0; i < 286; i++)
			{
				num4 += class12_0.short_0[i] * byte_2[i];
			}
			for (int j = 0; j < 30; j++)
			{
				num4 += class12_1.short_0[j] * byte_3[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
			{
				method_5(stored, storedOffset, storedLength, lastBlock);
			}
			else if (num3 == num4)
			{
				class14_0.method_3(2 + (lastBlock ? 1 : 0), 3);
				class12_0.method_1(short_1, byte_2);
				class12_1.method_1(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class14_0.method_3(4 + (lastBlock ? 1 : 0), 3);
				method_3(num);
				method_4();
				method_0();
			}
		}

		public bool method_7()
		{
			return int_9 >= 16384;
		}

		public bool method_8(int lit)
		{
			short_0[int_9] = 0;
			byte_1[int_9++] = (byte)lit;
			short[] array;
			short[] array2 = (array = class12_0.short_0);
			nint num = lit;
			array2[lit] = (short)(array[num] + 1);
			return method_7();
		}

		public bool method_9(int dist, int len)
		{
			short_0[int_9] = (short)dist;
			byte_1[int_9++] = (byte)(len - 3);
			int num = method_1(len - 3);
			short[] array;
			short[] array2 = (array = class12_0.short_0);
			nint num2 = num;
			array2[num] = (short)(array[num2] + 1);
			if (num >= 265 && num < 285)
			{
				int_10 += (num - 261) / 4;
			}
			int num3 = method_2(dist - 1);
			short[] array3 = (array = class12_1.short_0);
			num2 = num3;
			array3[num3] = (short)(array[num2] + 1);
			if (num3 >= 4)
			{
				int_10 += num3 / 2 - 1;
			}
			return method_7();
		}
	}

	internal sealed class Class13
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

		private Class14 class14_0;

		private Class11 class11_0;

		public Class13(Class14 pending)
		{
			class14_0 = pending;
			class11_0 = new Class11(pending);
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

		private bool method_4(int curMatch)
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
				if (byte_0[curMatch + num5] != b2 || byte_0[curMatch + num5 - 1] != b || byte_0[curMatch] != byte_0[num3] || byte_0[curMatch + 1] != byte_0[num3 + 1])
				{
					continue;
				}
				int num8 = curMatch + 2;
				num3 += 2;
				while (byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					int_11 = curMatch;
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
			while ((curMatch = array[curMatch & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			int_12 = Math.Min(num5, int_15);
			return int_12 >= 3;
		}

		private bool method_5(bool flush, bool finish)
		{
			if (int_15 < 262 && !flush)
			{
				return false;
			}
			do
			{
				if (int_15 >= 262 || flush)
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
							class11_0.method_9(int_14 - 1 - num, num2);
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
								class11_0.method_8(byte_0[int_14 - 1] & 0xFF);
							}
							bool_0 = true;
							int_14++;
							int_15--;
						}
						continue;
					}
					if (bool_0)
					{
						class11_0.method_8(byte_0[int_14 - 1] & 0xFF);
					}
					bool_0 = false;
					class11_0.method_6(byte_0, int_13, int_14 - int_13, finish);
					int_13 = int_14;
					return false;
				}
				return true;
			}
			while (!class11_0.method_7());
			int num4 = int_14 - int_13;
			if (bool_0)
			{
				num4--;
			}
			bool flag = finish && int_15 == 0 && !bool_0;
			class11_0.method_6(byte_0, int_13, num4, flag);
			int_13 += num4;
			return !flag;
		}

		public bool method_6(bool flush, bool finish)
		{
			bool flag;
			do
			{
				method_3();
				bool flush2 = flush && int_17 == int_18;
				flag = method_5(flush2, finish);
			}
			while (class14_0.IsFlushed && flag);
			return flag;
		}

		public void method_7(byte[] buffer)
		{
			byte_1 = buffer;
			int_17 = 0;
			int_18 = buffer.Length;
		}

		public bool method_8()
		{
			return int_18 == int_17;
		}
	}

	internal sealed class Class14
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

		public int BitCount => int_2;

		public bool IsFlushed => int_1 == 0;

		public void method_0(int s)
		{
			byte_0[int_1++] = (byte)s;
			byte_0[int_1++] = (byte)(s >> 8);
		}

		public void method_1(byte[] block, int offset, int len)
		{
			Array.Copy(block, offset, byte_0, int_1, len);
			int_1 += len;
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

		public void method_3(int b, int count)
		{
			uint_0 |= (uint)(b << int_2);
			int_2 += count;
			if (int_2 >= 16)
			{
				byte_0[int_1++] = (byte)uint_0;
				byte_0[int_1++] = (byte)(uint_0 >> 8);
				uint_0 >>= 16;
				int_2 -= 16;
			}
		}

		public int method_4(byte[] output, int offset, int length)
		{
			if (int_2 >= 8)
			{
				byte_0[int_1++] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
			}
			if (length > int_1 - int_0)
			{
				length = int_1 - int_0;
				Array.Copy(byte_0, int_0, output, offset, length);
				int_0 = 0;
				int_1 = 0;
			}
			else
			{
				Array.Copy(byte_0, int_0, output, offset, length);
				int_0 += length;
			}
			return length;
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public void method_0(int value)
		{
			WriteByte((byte)((uint)value & 0xFFu));
			WriteByte((byte)((uint)(value >> 8) & 0xFFu));
		}

		public void method_1(int value)
		{
			method_0(value);
			method_0(value >> 16);
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

		public Stream0(byte[] buffer)
			: base(buffer, writable: false)
		{
		}
	}

	public static string string_0;

	private static bool smethod_0(Assembly executingAssembly, Assembly callingAssembly)
	{
		byte[] publicKey = executingAssembly.GetName().GetPublicKey();
		byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
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

	public static byte[] smethod_1(byte[] buffer)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !smethod_0(executingAssembly, callingAssembly))
		{
			return null;
		}
		Stream0 stream = new Stream0(buffer);
		byte[] array = new byte[0];
		int num = stream.method_3();
		if (num == 67324752)
		{
			short num2 = (short)stream.method_2();
			int num3 = stream.method_2();
			int num4 = stream.method_2();
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			stream.method_3();
			stream.method_3();
			stream.method_3();
			int num5 = stream.method_3();
			int num6 = stream.method_2();
			int num7 = stream.method_2();
			checked
			{
				if (num6 > 0)
				{
					byte[] buffer2 = new byte[(uint)num6];
					stream.Read(buffer2, 0, num6);
				}
				if (num7 > 0)
				{
					byte[] buffer3 = new byte[(uint)num7];
					stream.Read(buffer3, 0, num7);
				}
				byte[] array2 = new byte[(uint)unchecked(stream.Length - stream.Position)];
				stream.Read(array2, 0, array2.Length);
				Class5 @class = new Class5(array2);
				array = new byte[(uint)num5];
				@class.method_2(array, 0, array.Length);
				array2 = null;
			}
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = stream.method_3();
				array = new byte[checked((uint)num9)];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = stream.method_3();
					num11 = stream.method_3();
					byte[] array3 = new byte[checked((uint)num10)];
					stream.Read(array3, 0, array3.Length);
					Class5 class2 = new Class5(array3);
					class2.method_2(array, i, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] key = new byte[8] { 8, 189, 99, 25, 71, 42, 126, 201 };
				byte[] iv = new byte[8] { 5, 92, 53, 36, 195, 32, 160, 101 };
				using Class3 class3 = new Class3();
				using ICryptoTransform cryptoTransform = class3.method_0(key, iv, decrypt: true);
				byte[] buffer4 = cryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = smethod_1(buffer4);
			}
			if (num8 == 3)
			{
				byte[] key2 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] iv2 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class2 class4 = new Class2();
				using ICryptoTransform cryptoTransform2 = class4.method_0(key2, iv2, decrypt: true);
				byte[] buffer5 = cryptoTransform2.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = smethod_1(buffer5);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	public static byte[] smethod_2(byte[] buffer)
	{
		return smethod_5(buffer, 1, null, null);
	}

	public static byte[] smethod_3(byte[] buffer, byte[] key, byte[] iv)
	{
		return smethod_5(buffer, 2, key, iv);
	}

	public static byte[] smethod_4(byte[] buffer, byte[] key, byte[] iv)
	{
		return smethod_5(buffer, 3, key, iv);
	}

	private static byte[] smethod_5(byte[] buffer, int version, byte[] key, byte[] iv)
	{
		try
		{
			Stream0 stream = new Stream0();
			switch (version)
			{
			case 0:
			{
				Class10 class4 = new Class10();
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
				int num7 = buffer.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ buffer[num6++]) & 0xFF] ^ (num5 >> 8);
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
				stream.method_1(buffer.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				stream.method_0(bytes.Length);
				stream.method_0(0);
				stream.Write(bytes, 0, bytes.Length);
				class4.method_1(buffer);
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
				stream.method_1(buffer.Length);
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
				stream.method_1(buffer.Length);
				byte[] array5;
				for (int i = 0; i < buffer.Length; i += array5.Length)
				{
					Class10 class3;
					long position2;
					checked
					{
						array5 = new byte[(uint)Math.Min(2097151, unchecked(buffer.Length - i))];
						Buffer.BlockCopy(buffer, i, array5, 0, array5.Length);
						long position = stream.Position;
						stream.method_1(0);
						stream.method_1(array5.Length);
						class3 = new Class10();
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
						position2 = stream.Position;
						stream.Position = position;
					}
					stream.method_1((int)class3.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				stream.method_1(41777787);
				byte[] array3 = smethod_5(buffer, 1, null, null);
				using (Class3 class2 = new Class3())
				{
					using ICryptoTransform cryptoTransform2 = class2.method_0(key, iv, decrypt: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				stream.method_1(58555003);
				byte[] array = smethod_5(buffer, 1, null, null);
				using (Class2 @class = new Class2())
				{
					using ICryptoTransform cryptoTransform = @class.method_0(key, iv, decrypt: false);
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
			string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}
}
