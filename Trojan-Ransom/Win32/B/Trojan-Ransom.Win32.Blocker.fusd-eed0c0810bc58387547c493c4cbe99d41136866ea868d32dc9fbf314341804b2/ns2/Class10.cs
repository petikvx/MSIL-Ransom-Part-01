using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace ns2;

internal static class Class10
{
	internal class Class11
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

		private Class12 class12_0;

		private Class13 class13_0;

		private Class15 class15_0;

		private Class14 class14_0;

		private Class14 class14_1;

		public Class11(byte[] bytes)
		{
			class12_0 = new Class12();
			class13_0 = new Class13();
			int_17 = 2;
			class12_0.method_5(bytes, 0, bytes.Length);
		}

		private unsafe bool method_0()
		{
			void* ptr = stackalloc byte[12];
			int num = class13_0.method_5();
			while (num >= 258)
			{
				*(int*)((byte*)ptr + 8) = int_17;
				switch (*(int*)((byte*)ptr + 8))
				{
				case 7:
				{
					int num2;
					while (((num2 = class14_0.method_1(class12_0)) & -256) == 0)
					{
						class13_0.method_0(num2);
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
					class14_1 = null;
					class14_0 = null;
					int_17 = 2;
					return true;
				}
				case 8:
					if (int_18 > 0)
					{
						int_17 = 8;
						*(int*)ptr = class12_0.method_0(int_18);
						if (*(int*)ptr < 0)
						{
							return false;
						}
						class12_0.method_1(int_18);
						int_19 += *(int*)ptr;
					}
					int_17 = 9;
					goto case 9;
				case 9:
				{
					int num2 = class14_1.method_1(class12_0);
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
						*(int*)((byte*)ptr + 4) = class12_0.method_0(int_18);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							return false;
						}
						class12_0.method_1(int_18);
						int_20 += *(int*)((byte*)ptr + 4);
					}
					class13_0.method_2(int_19, int_20);
					num -= int_19;
					int_17 = 7;
					break;
				}
			}
			return true;
		}

		private unsafe bool method_1()
		{
			void* ptr = stackalloc byte[20];
			*(int*)((byte*)ptr + 12) = int_17;
			switch (*(int*)((byte*)ptr + 12))
			{
			case 2:
				if (bool_0)
				{
					int_17 = 12;
					return false;
				}
				*(int*)ptr = class12_0.method_0(3);
				if (*(int*)ptr < 0)
				{
					return false;
				}
				class12_0.method_1(3);
				if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				*(int*)((byte*)ptr + 16) = *(int*)ptr >> 1;
				switch (*(int*)((byte*)ptr + 16))
				{
				case 0:
					class12_0.method_2();
					int_17 = 3;
					break;
				case 1:
					class14_0 = Class14.class14_0;
					class14_1 = Class14.class14_1;
					int_17 = 7;
					break;
				case 2:
					class15_0 = new Class15();
					int_17 = 6;
					break;
				}
				return true;
			case 3:
				if ((int_21 = class12_0.method_0(16)) < 0)
				{
					return false;
				}
				class12_0.method_1(16);
				int_17 = 4;
				goto case 4;
			case 4:
				*(int*)((byte*)ptr + 4) = class12_0.method_0(16);
				if (*(int*)((byte*)ptr + 4) < 0)
				{
					return false;
				}
				class12_0.method_1(16);
				int_17 = 5;
				goto case 5;
			case 5:
				*(int*)((byte*)ptr + 8) = class13_0.method_3(class12_0, int_21);
				int_21 -= *(int*)((byte*)ptr + 8);
				if (int_21 == 0)
				{
					int_17 = 2;
					return true;
				}
				return !class12_0.IsNeedingInput;
			case 6:
				if (!class15_0.method_0(class12_0))
				{
					return false;
				}
				class14_0 = class15_0.method_1();
				class14_1 = class15_0.method_2();
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

		public unsafe int method_2(byte[] byte_0, int int_22, int int_23)
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = 0;
			do
			{
				if (int_17 != 11)
				{
					*(int*)((byte*)ptr + 4) = class13_0.method_7(byte_0, int_22, int_23);
					int_22 += *(int*)((byte*)ptr + 4);
					*(int*)ptr += *(int*)((byte*)ptr + 4);
					int_23 -= *(int*)((byte*)ptr + 4);
					if (int_23 == 0)
					{
						return *(int*)ptr;
					}
				}
			}
			while (method_1() || (class13_0.method_6() > 0 && int_17 != 11));
			return *(int*)ptr;
		}
	}

	internal class Class12
	{
		private byte[] byte_0;

		private int int_0;

		private int int_1;

		private uint uint_0;

		private int int_2;

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

		public unsafe int method_3(byte[] byte_1, int int_3, int int_4)
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = 0;
			while (int_2 > 0 && int_4 > 0)
			{
				byte_1[int_3++] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
				int_4--;
				(*(int*)ptr)++;
			}
			if (int_4 == 0)
			{
				return *(int*)ptr;
			}
			*(int*)((byte*)ptr + 4) = int_1 - int_0;
			if (int_4 > *(int*)((byte*)ptr + 4))
			{
				int_4 = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
			int_0 += int_4;
			if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
			{
				uint_0 = byte_0[int_0++] & 0xFFu;
				int_2 = 8;
			}
			return *(int*)ptr + int_4;
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

	internal class Class13
	{
		private const int int_0 = 32768;

		private const int int_1 = 32767;

		private byte[] byte_0 = new byte[32768];

		private int int_2;

		private int int_3;

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

		public unsafe int method_3(Class12 class12_0, int int_4)
		{
			void* ptr = stackalloc byte[8];
			int_4 = Math.Min(Math.Min(int_4, 32768 - int_3), class12_0.AvailableBytes);
			*(int*)((byte*)ptr + 4) = 32768 - int_2;
			if (int_4 > *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr = class12_0.method_3(byte_0, int_2, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr += class12_0.method_3(byte_0, 0, int_4 - *(int*)((byte*)ptr + 4));
				}
			}
			else
			{
				*(int*)ptr = class12_0.method_3(byte_0, int_2, int_4);
			}
			int_2 = (int_2 + *(int*)ptr) & 0x7FFF;
			int_3 += *(int*)ptr;
			return *(int*)ptr;
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

		public unsafe int method_7(byte[] byte_1, int int_4, int int_5)
		{
			void* ptr = stackalloc byte[12];
			*(int*)ptr = int_2;
			if (int_5 > int_3)
			{
				int_5 = int_3;
			}
			else
			{
				*(int*)ptr = (int_2 - int_3 + int_5) & 0x7FFF;
			}
			*(int*)((byte*)ptr + 4) = int_5;
			*(int*)((byte*)ptr + 8) = int_5 - *(int*)ptr;
			if (*(int*)((byte*)ptr + 8) > 0)
			{
				Array.Copy(byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_1, int_4, *(int*)((byte*)ptr + 8));
				int_4 += *(int*)((byte*)ptr + 8);
				int_5 = *(int*)ptr;
			}
			Array.Copy(byte_0, *(int*)ptr - int_5, byte_1, int_4, int_5);
			int_3 -= *(int*)((byte*)ptr + 4);
			if (int_3 < 0)
			{
				throw new InvalidOperationException();
			}
			return *(int*)((byte*)ptr + 4);
		}

		public void method_8()
		{
			int_2 = 0;
			int_3 = 0;
		}
	}

	internal class Class14
	{
		private const int int_0 = 15;

		private short[] short_0;

		public static readonly Class14 class14_0;

		public static readonly Class14 class14_1;

		static Class14()
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
			class14_0 = new Class14(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class14_1 = new Class14(array);
		}

		public Class14(byte[] codeLengths)
		{
			method_0(codeLengths);
		}

		private unsafe void method_0(byte[] byte_0)
		{
			void* ptr = stackalloc byte[68];
			int[] array = new int[16];
			int[] array2 = new int[16];
			*(int*)ptr = 0;
			while (*(int*)ptr < byte_0.Length)
			{
				*(int*)((byte*)ptr + 4) = byte_0[*(int*)ptr];
				if (*(int*)((byte*)ptr + 4) > 0)
				{
					array[*(int*)((byte*)ptr + 4)]++;
				}
				(*(int*)ptr)++;
			}
			*(int*)((byte*)ptr + 8) = 0;
			*(int*)((byte*)ptr + 12) = 512;
			*(int*)((byte*)ptr + 16) = 1;
			while (*(int*)((byte*)ptr + 16) <= 15)
			{
				array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
				*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
				if (*(int*)((byte*)ptr + 16) >= 10)
				{
					*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
					*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
					*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
				}
				(*(int*)((byte*)ptr + 16))++;
			}
			short_0 = new short[*(int*)((byte*)ptr + 12)];
			*(int*)((byte*)ptr + 28) = 512;
			*(int*)((byte*)ptr + 32) = 15;
			while (*(int*)((byte*)ptr + 32) >= 10)
			{
				*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
				*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
				while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
				{
					short_0[Class17.smethod_0(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
					*(int*)((byte*)ptr + 44) += 128;
				}
				(*(int*)((byte*)ptr + 32))--;
			}
			*(int*)((byte*)ptr + 48) = 0;
			while (*(int*)((byte*)ptr + 48) < byte_0.Length)
			{
				*(int*)((byte*)ptr + 52) = byte_0[*(int*)((byte*)ptr + 48)];
				if (*(int*)((byte*)ptr + 52) != 0)
				{
					*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
					*(int*)((byte*)ptr + 56) = Class17.smethod_0(*(int*)((byte*)ptr + 8));
					if (*(int*)((byte*)ptr + 52) <= 9)
					{
						do
						{
							short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
							*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
						}
						while (*(int*)((byte*)ptr + 56) < 512);
					}
					else
					{
						*(int*)((byte*)ptr + 60) = short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
						*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
						*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
						do
						{
							short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
							*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
						}
						while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
					}
					array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
				}
				(*(int*)((byte*)ptr + 48))++;
			}
		}

		public unsafe int method_1(Class12 class12_0)
		{
			void* ptr = stackalloc byte[16];
			int num;
			int num2;
			if ((num = class12_0.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					class12_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)ptr = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = num2 & 0xF;
				if ((num = class12_0.method_0(*(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = short_0[*(int*)ptr | (num >> 9)];
					class12_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)((byte*)ptr + 8) = class12_0.AvailableBits;
				num = class12_0.method_0(*(int*)((byte*)ptr + 8));
				num2 = short_0[*(int*)ptr | (num >> 9)];
				if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
				{
					class12_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			*(int*)((byte*)ptr + 12) = class12_0.AvailableBits;
			num = class12_0.method_0(*(int*)((byte*)ptr + 12));
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				class12_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal class Class15
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

		private Class14 class14_0;

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

		public unsafe bool method_0(Class12 class12_0)
		{
			void* ptr = stackalloc byte[12];
			while (true)
			{
				*(int*)((byte*)ptr + 8) = int_8;
				switch (*(int*)((byte*)ptr + 8))
				{
				case 5:
				{
					*(int*)((byte*)ptr + 4) = int_7[int_13];
					int num = class12_0.method_0(*(int*)((byte*)ptr + 4));
					if (num >= 0)
					{
						class12_0.method_1(*(int*)((byte*)ptr + 4));
						num += int_6[int_13];
						while (num-- > 0)
						{
							byte_1[int_14++] = byte_2;
						}
						if (int_14 == int_12)
						{
							return true;
						}
						goto IL_0083;
					}
					return false;
				}
				case 4:
				{
					int num2;
					while (((num2 = class14_0.method_1(class12_0)) & -16) == 0)
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
						*(int*)ptr = class12_0.method_0(3);
						if (*(int*)ptr >= 0)
						{
							class12_0.method_1(3);
							byte_0[int_15[int_14]] = (byte)(*(uint*)ptr);
							int_14++;
							continue;
						}
						return false;
					}
					class14_0 = new Class14(byte_0);
					byte_0 = null;
					int_14 = 0;
					int_8 = 4;
					goto case 4;
				case 2:
					int_11 = class12_0.method_0(4);
					if (int_11 >= 0)
					{
						int_11 += 4;
						class12_0.method_1(4);
						byte_0 = new byte[19];
						int_14 = 0;
						int_8 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_10 = class12_0.method_0(5);
					if (int_10 >= 0)
					{
						int_10++;
						class12_0.method_1(5);
						int_12 = int_9 + int_10;
						byte_1 = new byte[int_12];
						int_8 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_9 = class12_0.method_0(5);
					if (int_9 >= 0)
					{
						int_9 += 257;
						class12_0.method_1(5);
						int_8 = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_0083:
				int_8 = 4;
			}
		}

		public Class14 method_1()
		{
			byte[] array = new byte[int_9];
			Array.Copy(byte_1, 0, array, 0, int_9);
			return new Class14(array);
		}

		public Class14 method_2()
		{
			byte[] array = new byte[int_10];
			Array.Copy(byte_1, int_9, array, 0, int_10);
			return new Class14(array);
		}
	}

	internal class Class16
	{
		private const int int_0 = 4;

		private const int int_1 = 8;

		private const int int_2 = 16;

		private const int int_3 = 20;

		private const int int_4 = 28;

		private const int int_5 = 30;

		private int int_6 = 16;

		private long long_0;

		private Class20 class20_0;

		private Class19 class19_0;

		public long TotalOut => long_0;

		public bool IsFinished
		{
			get
			{
				if (int_6 == 30)
				{
					return class20_0.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => class19_0.method_8();

		public Class16()
		{
			class20_0 = new Class20();
			class19_0 = new Class19(class20_0);
		}

		public void method_0()
		{
			int_6 |= 12;
		}

		public void method_1(byte[] byte_0)
		{
			class19_0.method_7(byte_0);
		}

		public unsafe int method_2(byte[] byte_0)
		{
			void* ptr = stackalloc byte[20];
			*(int*)ptr = 0;
			*(int*)((byte*)ptr + 4) = byte_0.Length;
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
			while (true)
			{
				*(int*)((byte*)ptr + 12) = class20_0.method_4(byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
				*(int*)ptr += *(int*)((byte*)ptr + 12);
				long_0 += *(int*)((byte*)ptr + 12);
				*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
				if (*(int*)((byte*)ptr + 4) == 0 || int_6 == 30)
				{
					break;
				}
				if (class19_0.method_6((int_6 & 4) != 0, (int_6 & 8) != 0))
				{
					continue;
				}
				if (int_6 != 16)
				{
					if (int_6 == 20)
					{
						*(int*)((byte*)ptr + 16) = 8 + (-class20_0.BitCount & 7);
						while (*(int*)((byte*)ptr + 16) > 0)
						{
							class20_0.method_3(2, 10);
							*(int*)((byte*)ptr + 16) -= 10;
						}
						int_6 = 16;
					}
					else if (int_6 == 28)
					{
						class20_0.method_2();
						int_6 = 30;
					}
					continue;
				}
				return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
	}

	internal class Class17
	{
		public class Class18
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class17 class17_0;

			public Class18(Class17 dh, int elems, int minCodes, int maxLength)
			{
				class17_0 = dh;
				int_0 = minCodes;
				int_3 = maxLength;
				short_0 = new short[elems];
				int_2 = new int[maxLength];
			}

			public void method_0(int int_4)
			{
				class17_0.class20_0.method_3(short_1[int_4] & 0xFFFF, byte_0[int_4]);
			}

			public void method_1(short[] short_2, byte[] byte_1)
			{
				short_1 = short_2;
				byte_0 = byte_1;
			}

			public unsafe void method_2()
			{
				void* ptr = stackalloc byte[16];
				int[] array = new int[int_3];
				*(int*)ptr = 0;
				short_1 = new short[short_0.Length];
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < int_3)
				{
					array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
					*(int*)ptr += int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
					(*(int*)((byte*)ptr + 4))++;
				}
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < int_1)
				{
					*(int*)((byte*)ptr + 12) = byte_0[*(int*)((byte*)ptr + 8)];
					if (*(int*)((byte*)ptr + 12) > 0)
					{
						short_1[*(int*)((byte*)ptr + 8)] = smethod_0(array[*(int*)((byte*)ptr + 12) - 1]);
						array[*(int*)((byte*)ptr + 12) - 1] += 1 << 16 - *(int*)((byte*)ptr + 12);
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}

			private unsafe void method_3(int[] int_4)
			{
				void* ptr = stackalloc byte[36];
				byte_0 = new byte[short_0.Length];
				*(int*)ptr = int_4.Length / 2;
				*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
				*(int*)((byte*)ptr + 8) = 0;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < int_3)
				{
					int_2[*(int*)((byte*)ptr + 12)] = 0;
					(*(int*)((byte*)ptr + 12))++;
				}
				int[] array = new int[*(int*)ptr];
				array[*(int*)ptr - 1] = 0;
				*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
				while (*(int*)((byte*)ptr + 16) >= 0)
				{
					if (int_4[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
					{
						*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
						if (*(int*)((byte*)ptr + 20) > int_3)
						{
							*(int*)((byte*)ptr + 20) = int_3;
							(*(int*)((byte*)ptr + 8))++;
						}
						array[int_4[2 * *(int*)((byte*)ptr + 16)]] = (array[int_4[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
					}
					else
					{
						*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
						int_2[*(int*)((byte*)ptr + 24) - 1]++;
						byte_0[int_4[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
					}
					(*(int*)((byte*)ptr + 16))--;
				}
				if (*(int*)((byte*)ptr + 8) == 0)
				{
					return;
				}
				int num = int_3 - 1;
				while (true)
				{
					if (int_2[--num] != 0)
					{
						do
						{
							int_2[num]--;
							int_2[++num]++;
							*(int*)((byte*)ptr + 8) -= 1 << int_3 - 1 - num;
						}
						while (*(int*)((byte*)ptr + 8) > 0 && num < int_3 - 1);
						if (*(int*)((byte*)ptr + 8) <= 0)
						{
							break;
						}
					}
				}
				int_2[int_3 - 1] += *(int*)((byte*)ptr + 8);
				int_2[int_3 - 2] -= *(int*)((byte*)ptr + 8);
				int num2 = 2 * *(int*)((byte*)ptr + 4);
				*(int*)((byte*)ptr + 28) = int_3;
				while (*(int*)((byte*)ptr + 28) != 0)
				{
					*(int*)((byte*)ptr + 32) = int_2[*(int*)((byte*)ptr + 28) - 1];
					while (*(int*)((byte*)ptr + 32) > 0)
					{
						int num3 = 2 * int_4[num2++];
						if (int_4[num3 + 1] == -1)
						{
							byte_0[int_4[num3]] = (byte)(*(uint*)((byte*)ptr + 28));
							(*(int*)((byte*)ptr + 32))--;
						}
					}
					(*(int*)((byte*)ptr + 28))--;
				}
			}

			public unsafe void method_4()
			{
				void* ptr = stackalloc byte[36];
				*(int*)ptr = short_0.Length;
				int[] array = new int[*(int*)ptr];
				int num = 0;
				int num2 = 0;
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
				{
					*(int*)((byte*)ptr + 8) = short_0[*(int*)((byte*)ptr + 4)];
					if (*(int*)((byte*)ptr + 8) != 0)
					{
						int num3 = num++;
						int num4;
						while (num3 > 0 && short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
						{
							array[num3] = array[num4];
							num3 = num4;
						}
						array[num3] = *(int*)((byte*)ptr + 4);
						num2 = *(int*)((byte*)ptr + 4);
					}
					(*(int*)((byte*)ptr + 4))++;
				}
				while (num < 2)
				{
					int num5 = ((num2 < 2) ? (++num2) : 0);
					array[num++] = num5;
				}
				int_1 = Math.Max(num2 + 1, int_0);
				*(int*)((byte*)ptr + 12) = num;
				int[] array2 = new int[4 * num - 2];
				int[] array3 = new int[2 * num - 1];
				int num6 = *(int*)((byte*)ptr + 12);
				*(int*)((byte*)ptr + 16) = 0;
				while (*(int*)((byte*)ptr + 16) < num)
				{
					*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
					array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
					array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
					array3[*(int*)((byte*)ptr + 16)] = short_0[*(int*)((byte*)ptr + 20)] << 8;
					array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
					(*(int*)((byte*)ptr + 16))++;
				}
				do
				{
					*(int*)((byte*)ptr + 24) = array[0];
					int num7 = array[--num];
					int num8 = 0;
					int num9;
					for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
					{
						if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
						{
							num9++;
						}
						array[num8] = array[num9];
						num8 = num9;
					}
					int num10 = array3[num7];
					while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
					{
						array[num9] = array[num8];
					}
					array[num9] = num7;
					*(int*)((byte*)ptr + 28) = array[0];
					num7 = num6++;
					array2[2 * num7] = *(int*)((byte*)ptr + 24);
					array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
					*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
					num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
					num8 = 0;
					for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
					{
						if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
						{
							num9++;
						}
						array[num8] = array[num9];
						num8 = num9;
					}
					while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
					{
						array[num9] = array[num8];
					}
					array[num9] = num7;
				}
				while (num > 1);
				method_3(array2);
			}

			public unsafe int method_5()
			{
				void* ptr = stackalloc byte[8];
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < short_0.Length)
				{
					*(int*)ptr += short_0[*(int*)((byte*)ptr + 4)] * byte_0[*(int*)((byte*)ptr + 4)];
					(*(int*)((byte*)ptr + 4))++;
				}
				return *(int*)ptr;
			}

			public unsafe void method_6(Class18 class18_0)
			{
				void* ptr = stackalloc byte[20];
				*(int*)((byte*)ptr + 8) = -1;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < int_1)
				{
					int num = 1;
					*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
					if (*(int*)((byte*)ptr + 16) == 0)
					{
						*(int*)ptr = 138;
						*(int*)((byte*)ptr + 4) = 3;
					}
					else
					{
						*(int*)ptr = 6;
						*(int*)((byte*)ptr + 4) = 3;
						if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
						{
							class18_0.short_0[*(int*)((byte*)ptr + 16)]++;
							num = 0;
						}
					}
					*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
					(*(int*)((byte*)ptr + 12))++;
					while (*(int*)((byte*)ptr + 12) < int_1 && *(int*)((byte*)ptr + 8) == byte_0[*(int*)((byte*)ptr + 12)])
					{
						(*(int*)((byte*)ptr + 12))++;
						if (++num >= *(int*)ptr)
						{
							break;
						}
					}
					if (num < *(int*)((byte*)ptr + 4))
					{
						class18_0.short_0[*(int*)((byte*)ptr + 8)] += (short)num;
					}
					else if (*(int*)((byte*)ptr + 8) != 0)
					{
						class18_0.short_0[16]++;
					}
					else if (num <= 10)
					{
						class18_0.short_0[17]++;
					}
					else
					{
						class18_0.short_0[18]++;
					}
				}
			}

			public unsafe void method_7(Class18 class18_0)
			{
				void* ptr = stackalloc byte[20];
				*(int*)((byte*)ptr + 8) = -1;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < int_1)
				{
					int num = 1;
					*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
					if (*(int*)((byte*)ptr + 16) == 0)
					{
						*(int*)ptr = 138;
						*(int*)((byte*)ptr + 4) = 3;
					}
					else
					{
						*(int*)ptr = 6;
						*(int*)((byte*)ptr + 4) = 3;
						if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
						{
							class18_0.method_0(*(int*)((byte*)ptr + 16));
							num = 0;
						}
					}
					*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
					(*(int*)((byte*)ptr + 12))++;
					while (*(int*)((byte*)ptr + 12) < int_1 && *(int*)((byte*)ptr + 8) == byte_0[*(int*)((byte*)ptr + 12)])
					{
						(*(int*)((byte*)ptr + 12))++;
						if (++num >= *(int*)ptr)
						{
							break;
						}
					}
					if (num < *(int*)((byte*)ptr + 4))
					{
						while (num-- > 0)
						{
							class18_0.method_0(*(int*)((byte*)ptr + 8));
						}
					}
					else if (*(int*)((byte*)ptr + 8) != 0)
					{
						class18_0.method_0(16);
						class17_0.class20_0.method_3(num - 3, 2);
					}
					else if (num <= 10)
					{
						class18_0.method_0(17);
						class17_0.class20_0.method_3(num - 3, 3);
					}
					else
					{
						class18_0.method_0(18);
						class17_0.class20_0.method_3(num - 11, 7);
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

		private Class20 class20_0;

		private Class18 class18_0;

		private Class18 class18_1;

		private Class18 class18_2;

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

		static Class17()
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

		public Class17(Class20 pending)
		{
			class20_0 = pending;
			class18_0 = new Class18(this, 286, 257, 15);
			class18_1 = new Class18(this, 30, 1, 15);
			class18_2 = new Class18(this, 19, 4, 7);
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
			class18_2.method_2();
			class18_0.method_2();
			class18_1.method_2();
			class20_0.method_3(class18_0.int_1 - 257, 5);
			class20_0.method_3(class18_1.int_1 - 1, 5);
			class20_0.method_3(int_11 - 4, 4);
			for (int i = 0; i < int_11; i++)
			{
				class20_0.method_3(class18_2.byte_0[int_8[i]], 3);
			}
			class18_0.method_7(class18_2);
			class18_1.method_7(class18_2);
		}

		public unsafe void method_4()
		{
			void* ptr = stackalloc byte[20];
			*(int*)ptr = 0;
			while (*(int*)ptr < int_9)
			{
				*(int*)((byte*)ptr + 4) = byte_1[*(int*)ptr] & 0xFF;
				int num = short_0[*(int*)ptr];
				if (num-- != 0)
				{
					*(int*)((byte*)ptr + 8) = method_1(*(int*)((byte*)ptr + 4));
					class18_0.method_0(*(int*)((byte*)ptr + 8));
					*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
					if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
					{
						class20_0.method_3(*(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
					}
					*(int*)((byte*)ptr + 16) = method_2(num);
					class18_1.method_0(*(int*)((byte*)ptr + 16));
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
					if (*(int*)((byte*)ptr + 12) > 0)
					{
						class20_0.method_3(num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
					}
				}
				else
				{
					class18_0.method_0(*(int*)((byte*)ptr + 4));
				}
				(*(int*)ptr)++;
			}
			class18_0.method_0(256);
		}

		public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			class20_0.method_3(bool_0 ? 1 : 0, 3);
			class20_0.method_2();
			class20_0.method_0(int_12);
			class20_0.method_0(~int_12);
			class20_0.method_1(byte_4, int_11, int_12);
			method_0();
		}

		public unsafe void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			void* ptr = stackalloc byte[24];
			class18_0.short_0[256]++;
			class18_0.method_4();
			class18_1.method_4();
			class18_0.method_6(class18_2);
			class18_1.method_6(class18_2);
			class18_2.method_4();
			*(int*)ptr = 4;
			*(int*)((byte*)ptr + 4) = 18;
			while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
			{
				if (class18_2.byte_0[int_8[*(int*)((byte*)ptr + 4)]] > 0)
				{
					*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
				}
				(*(int*)((byte*)ptr + 4))--;
			}
			*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + class18_2.method_5() + class18_0.method_5() + class18_1.method_5() + int_10;
			*(int*)((byte*)ptr + 12) = int_10;
			*(int*)((byte*)ptr + 16) = 0;
			while (*(int*)((byte*)ptr + 16) < 286)
			{
				*(int*)((byte*)ptr + 12) += class18_0.short_0[*(int*)((byte*)ptr + 16)] * byte_2[*(int*)((byte*)ptr + 16)];
				(*(int*)((byte*)ptr + 16))++;
			}
			*(int*)((byte*)ptr + 20) = 0;
			while (*(int*)((byte*)ptr + 20) < 30)
			{
				*(int*)((byte*)ptr + 12) += class18_1.short_0[*(int*)((byte*)ptr + 20)] * byte_3[*(int*)((byte*)ptr + 20)];
				(*(int*)((byte*)ptr + 20))++;
			}
			if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
			{
				*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
			}
			if (int_11 >= 0 && int_12 + 4 < *(int*)((byte*)ptr + 8) >> 3)
			{
				method_5(byte_4, int_11, int_12, bool_0);
			}
			else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
			{
				class20_0.method_3(2 + (bool_0 ? 1 : 0), 3);
				class18_0.method_1(short_1, byte_2);
				class18_1.method_1(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class20_0.method_3(4 + (bool_0 ? 1 : 0), 3);
				method_3(*(int*)ptr);
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
			class18_0.short_0[int_11]++;
			return method_7();
		}

		public unsafe bool method_9(int int_11, int int_12)
		{
			void* ptr = stackalloc byte[8];
			short_0[int_9] = (short)int_11;
			byte_1[int_9++] = (byte)(int_12 - 3);
			*(int*)ptr = method_1(int_12 - 3);
			class18_0.short_0[*(int*)ptr]++;
			if (*(int*)ptr >= 265 && *(int*)ptr < 285)
			{
				int_10 += (*(int*)ptr - 261) / 4;
			}
			*(int*)((byte*)ptr + 4) = method_2(int_11 - 1);
			class18_1.short_0[*(int*)((byte*)ptr + 4)]++;
			if (*(int*)((byte*)ptr + 4) >= 4)
			{
				int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
			}
			return method_7();
		}
	}

	internal class Class19
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

		private Class20 class20_0;

		private Class17 class17_0;

		public Class19(Class20 pending)
		{
			class20_0 = pending;
			class17_0 = new Class17(pending);
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

		private unsafe void method_2()
		{
			void* ptr = stackalloc byte[16];
			Array.Copy(byte_0, 32768, byte_0, 0, 32768);
			int_11 -= 32768;
			int_14 -= 32768;
			int_13 -= 32768;
			*(int*)ptr = 0;
			while (*(int*)ptr < 32768)
			{
				*(int*)((byte*)ptr + 4) = short_0[*(int*)ptr] & 0xFFFF;
				short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
				(*(int*)ptr)++;
			}
			*(int*)((byte*)ptr + 8) = 0;
			while (*(int*)((byte*)ptr + 8) < 32768)
			{
				*(int*)((byte*)ptr + 12) = short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
				short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
				(*(int*)((byte*)ptr + 8))++;
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

		private unsafe bool method_4(int int_19)
		{
			void* ptr = stackalloc byte[22];
			int num = 128;
			*(int*)ptr = 128;
			short[] array = short_1;
			int num2 = int_14;
			*(int*)((byte*)ptr + 4) = int_14 + int_12;
			*(int*)((byte*)ptr + 8) = Math.Max(int_12, 2);
			*(int*)((byte*)ptr + 12) = Math.Max(int_14 - 32506, 0);
			*(int*)((byte*)ptr + 16) = int_14 + 258 - 1;
			((byte*)ptr)[20] = byte_0[*(int*)((byte*)ptr + 4) - 1];
			((byte*)ptr)[21] = byte_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) >= 8)
			{
				num >>= 2;
			}
			if (*(int*)ptr > int_15)
			{
				*(int*)ptr = int_15;
			}
			do
			{
				if (byte_0[int_19 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || byte_0[int_19 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || byte_0[int_19] != byte_0[num2] || byte_0[int_19 + 1] != byte_0[num2 + 1])
				{
					continue;
				}
				int num3 = int_19 + 2;
				num2 += 2;
				while (byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && num2 < *(int*)((byte*)ptr + 16))
				{
				}
				if (num2 > *(int*)((byte*)ptr + 4))
				{
					int_11 = int_19;
					*(int*)((byte*)ptr + 4) = num2;
					*(int*)((byte*)ptr + 8) = num2 - int_14;
					if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
					{
						break;
					}
					((byte*)ptr)[20] = byte_0[*(int*)((byte*)ptr + 4) - 1];
					((byte*)ptr)[21] = byte_0[*(int*)((byte*)ptr + 4)];
				}
				num2 = int_14;
			}
			while ((int_19 = array[int_19 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
			int_12 = Math.Min(*(int*)((byte*)ptr + 8), int_15);
			return int_12 >= 3;
		}

		private unsafe bool method_5(bool bool_1, bool bool_2)
		{
			void* ptr = stackalloc byte[12];
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
						*(int*)ptr = int_11;
						int num = int_12;
						if (int_15 >= 3)
						{
							*(int*)((byte*)ptr + 4) = method_1();
							if (*(int*)((byte*)ptr + 4) != 0 && int_14 - *(int*)((byte*)ptr + 4) <= 32506 && method_4(*(int*)((byte*)ptr + 4)) && int_12 <= 5 && int_12 == 3 && int_14 - int_11 > 4096)
							{
								int_12 = 2;
							}
						}
						if (num >= 3 && int_12 <= num)
						{
							class17_0.method_9(int_14 - 1 - *(int*)ptr, num);
							num -= 2;
							do
							{
								int_14++;
								int_15--;
								if (int_15 >= 3)
								{
									method_1();
								}
							}
							while (--num > 0);
							int_14++;
							int_15--;
							bool_0 = false;
							int_12 = 2;
						}
						else
						{
							if (bool_0)
							{
								class17_0.method_8(byte_0[int_14 - 1] & 0xFF);
							}
							bool_0 = true;
							int_14++;
							int_15--;
						}
						continue;
					}
					if (bool_0)
					{
						class17_0.method_8(byte_0[int_14 - 1] & 0xFF);
					}
					bool_0 = false;
					class17_0.method_6(byte_0, int_13, int_14 - int_13, bool_2);
					int_13 = int_14;
					return false;
				}
				return true;
			}
			while (!class17_0.method_7());
			*(int*)((byte*)ptr + 8) = int_14 - int_13;
			if (bool_0)
			{
				(*(int*)((byte*)ptr + 8))--;
			}
			bool flag = bool_2 && int_15 == 0 && !bool_0;
			class17_0.method_6(byte_0, int_13, *(int*)((byte*)ptr + 8), flag);
			int_13 += *(int*)((byte*)ptr + 8);
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
			while (class20_0.IsFlushed && flag);
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

	internal class Class20
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0;

		private int int_1;

		private uint uint_0;

		private int int_2;

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

	internal class Stream0 : MemoryStream
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

		public Stream0(byte[] buffer)
			: base(buffer, writable: false)
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

	private static ICryptoTransform smethod_1(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	private static ICryptoTransform smethod_2(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	public unsafe static byte[] smethod_3(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !smethod_0(executingAssembly, callingAssembly))
		{
			return null;
		}
		Stream0 stream = new Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = stream.method_3();
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)stream.method_2();
			*(int*)((byte*)ptr + 4) = stream.method_2();
			*(int*)((byte*)ptr + 8) = stream.method_2();
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			stream.method_3();
			stream.method_3();
			stream.method_3();
			*(int*)((byte*)ptr + 12) = stream.method_3();
			*(int*)((byte*)ptr + 16) = stream.method_2();
			*(int*)((byte*)ptr + 20) = stream.method_2();
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class11 @class = new Class11(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			@class.method_2(array, 0, array.Length);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = stream.method_3();
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = stream.method_3();
					*(int*)((byte*)ptr + 40) = stream.method_3();
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class11 class2 = new Class11(array3);
					class2.method_2(array, *(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 40));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 92, 74, 41, 136, 11, 196, 102, 234 };
				byte[] byte_2 = new byte[8] { 19, 228, 113, 248, 242, 169, 148, 108 };
				using ICryptoTransform cryptoTransform = smethod_2(byte_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = smethod_3(byte_3);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
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
				using ICryptoTransform cryptoTransform2 = smethod_1(byte_4, byte_5, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = smethod_3(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	public static byte[] smethod_4(byte[] byte_0)
	{
		return smethod_7(byte_0, 1, null, null);
	}

	public static byte[] smethod_5(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return smethod_7(byte_0, 2, byte_1, byte_2);
	}

	public static byte[] smethod_6(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return smethod_7(byte_0, 3, byte_1, byte_2);
	}

	private unsafe static byte[] smethod_7(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Stream0 stream = new Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class16 class2 = new Class16();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
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
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = byte_0.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_0[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				stream.method_1(67324752);
				stream.method_0(20);
				stream.method_0(0);
				stream.method_0(8);
				stream.method_1((int)(*(long*)ptr));
				stream.method_1((int)num);
				*(long*)((byte*)ptr + 8) = stream.Position;
				stream.method_1(0);
				stream.method_1(byte_0.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				stream.method_0(bytes.Length);
				stream.method_0(0);
				stream.Write(bytes, 0, bytes.Length);
				class2.method_1(byte_0);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = class2.method_2(array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				class2.method_0();
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = class2.method_2(array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.TotalOut;
				stream.method_1(33639248);
				stream.method_0(20);
				stream.method_0(20);
				stream.method_0(0);
				stream.method_0(8);
				stream.method_1((int)(*(long*)ptr));
				stream.method_1((int)num);
				stream.method_1((int)(*(long*)((byte*)ptr + 16)));
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
				stream.method_1((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)));
				stream.method_0(0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				stream.method_1((int)(*(long*)((byte*)ptr + 16)));
				break;
			}
			case 1:
				stream.method_1(25000571);
				stream.method_1(byte_0.Length);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_0.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_0.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_0, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					stream.method_1(0);
					stream.method_1(array5.Length);
					Class16 @class = new Class16();
					@class.method_1(array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = @class.method_2(array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					@class.method_0();
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = @class.method_2(array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					stream.method_1((int)@class.TotalOut);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				stream.method_1(41777787);
				byte[] array3 = smethod_7(byte_0, 1, null, null);
				using (ICryptoTransform cryptoTransform2 = smethod_2(byte_1, byte_2, bool_0: false))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				stream.method_1(58555003);
				byte[] array = smethod_7(byte_0, 1, null, null);
				using (ICryptoTransform cryptoTransform = smethod_1(byte_1, byte_2, bool_0: false))
				{
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
