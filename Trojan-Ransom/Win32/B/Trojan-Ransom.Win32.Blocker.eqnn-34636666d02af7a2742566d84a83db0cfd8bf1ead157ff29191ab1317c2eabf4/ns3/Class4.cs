using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using ns0;

namespace ns3;

internal sealed class Class4
{
	internal sealed class Class5
	{
		private static readonly int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static readonly int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static readonly int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static readonly int[] int_3 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private bool bool_0;

		private Class6 class6_0;

		private Class7 class7_0;

		private Class9 class9_0;

		private Class8 class8_0;

		private Class8 class8_1;

		public Class5(byte[] byte_0)
		{
			class6_0 = new Class6();
			class7_0 = new Class7();
			int_4 = 2;
			class6_0.method_7(byte_0, 0, byte_0.Length);
		}

		private unsafe bool method_0()
		{
			void* ptr = stackalloc byte[12];
			int num = class7_0.method_4();
			while (num >= 258)
			{
				*(int*)((byte*)ptr + 8) = int_4;
				switch (*(int*)((byte*)ptr + 8))
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
						int_6 = int_0[num2 - 257];
						int_5 = int_1[num2 - 257];
						goto case 8;
					}
					if (num2 < 0)
					{
						return false;
					}
					class8_1 = null;
					class8_0 = null;
					int_4 = 2;
					return true;
				}
				case 8:
					if (int_5 > 0)
					{
						int_4 = 8;
						*(int*)ptr = class6_0.method_0(int_5);
						if (*(int*)ptr < 0)
						{
							return false;
						}
						class6_0.method_1(int_5);
						int_6 += *(int*)ptr;
					}
					int_4 = 9;
					goto case 9;
				case 9:
				{
					int num2 = class8_1.method_1(class6_0);
					if (num2 >= 0)
					{
						int_7 = int_2[num2];
						int_5 = int_3[num2];
						goto case 10;
					}
					return false;
				}
				case 10:
					if (int_5 > 0)
					{
						int_4 = 10;
						*(int*)((byte*)ptr + 4) = class6_0.method_0(int_5);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							return false;
						}
						class6_0.method_1(int_5);
						int_7 += *(int*)((byte*)ptr + 4);
					}
					class7_0.method_2(int_6, int_7);
					num -= int_6;
					int_4 = 7;
					break;
				}
			}
			return true;
		}

		private unsafe bool method_1()
		{
			void* ptr = stackalloc byte[12];
			switch (int_4)
			{
			case 2:
				if (bool_0)
				{
					int_4 = 12;
					return false;
				}
				*(int*)ptr = class6_0.method_0(3);
				if (*(int*)ptr < 0)
				{
					return false;
				}
				class6_0.method_1(3);
				if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (*(int*)ptr >> 1)
				{
				case 0:
					class6_0.method_4();
					int_4 = 3;
					break;
				case 1:
					class8_0 = Class8.class8_0;
					class8_1 = Class8.class8_1;
					int_4 = 7;
					break;
				case 2:
					class9_0 = new Class9();
					int_4 = 6;
					break;
				}
				return true;
			case 3:
				if ((int_8 = class6_0.method_0(16)) < 0)
				{
					return false;
				}
				class6_0.method_1(16);
				int_4 = 4;
				goto case 4;
			case 4:
				*(int*)((byte*)ptr + 4) = class6_0.method_0(16);
				if (*(int*)((byte*)ptr + 4) < 0)
				{
					return false;
				}
				class6_0.method_1(16);
				int_4 = 5;
				goto case 5;
			case 5:
				*(int*)((byte*)ptr + 8) = class7_0.method_3(class6_0, int_8);
				int_8 -= *(int*)((byte*)ptr + 8);
				if (int_8 == 0)
				{
					int_4 = 2;
					return true;
				}
				return !class6_0.method_5();
			case 6:
				if (!class9_0.method_0(class6_0))
				{
					return false;
				}
				class8_0 = class9_0.method_1();
				class8_1 = class9_0.method_2();
				int_4 = 7;
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

		public unsafe int method_2(byte[] byte_0, int int_9, int int_10)
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = 0;
			do
			{
				if (int_4 != 11)
				{
					*(int*)((byte*)ptr + 4) = class7_0.method_6(byte_0, int_9, int_10);
					int_9 += *(int*)((byte*)ptr + 4);
					*(int*)ptr += *(int*)((byte*)ptr + 4);
					int_10 -= *(int*)((byte*)ptr + 4);
					if (int_10 == 0)
					{
						return *(int*)ptr;
					}
				}
			}
			while (method_1() || (class7_0.method_5() > 0 && int_4 != 11));
			return *(int*)ptr;
		}
	}

	internal sealed class Class6
	{
		private byte[] byte_0;

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

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

		[SpecialName]
		public int method_2()
		{
			return int_2;
		}

		[SpecialName]
		public int method_3()
		{
			return int_1 - int_0 + (int_2 >> 3);
		}

		public void method_4()
		{
			uint_0 >>= int_2 & 7;
			int_2 &= -8;
		}

		[SpecialName]
		public bool method_5()
		{
			return int_0 == int_1;
		}

		public unsafe int method_6(byte[] byte_1, int int_3, int int_4)
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

		public void method_7(byte[] byte_1, int int_3, int int_4)
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

	internal sealed class Class7
	{
		private byte[] byte_0 = new byte[32768];

		private int int_0 = 0;

		private int int_1 = 0;

		public void method_0(int int_2)
		{
			if (int_1++ == 32768)
			{
				throw new InvalidOperationException();
			}
			byte_0[int_0++] = (byte)int_2;
			int_0 &= 32767;
		}

		private void method_1(int int_2, int int_3, int int_4)
		{
			while (int_3-- > 0)
			{
				byte_0[int_0++] = byte_0[int_2++];
				int_0 &= 32767;
				int_2 &= 0x7FFF;
			}
		}

		public void method_2(int int_2, int int_3)
		{
			if ((int_1 += int_2) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (int_0 - int_3) & 0x7FFF;
			int num2 = 32768 - int_2;
			if (num <= num2 && int_0 < num2)
			{
				if (int_2 <= int_3)
				{
					Array.Copy(byte_0, num, byte_0, int_0, int_2);
					int_0 += int_2;
				}
				else
				{
					while (int_2-- > 0)
					{
						byte_0[int_0++] = byte_0[num++];
					}
				}
			}
			else
			{
				method_1(num, int_2, int_3);
			}
		}

		public unsafe int method_3(Class6 class6_0, int int_2)
		{
			void* ptr = stackalloc byte[8];
			int_2 = Math.Min(Math.Min(int_2, 32768 - int_1), class6_0.method_3());
			*(int*)((byte*)ptr + 4) = 32768 - int_0;
			if (int_2 > *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr = class6_0.method_6(byte_0, int_0, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr += class6_0.method_6(byte_0, 0, int_2 - *(int*)((byte*)ptr + 4));
				}
			}
			else
			{
				*(int*)ptr = class6_0.method_6(byte_0, int_0, int_2);
			}
			int_0 = (int_0 + *(int*)ptr) & 0x7FFF;
			int_1 += *(int*)ptr;
			return *(int*)ptr;
		}

		public int method_4()
		{
			return 32768 - int_1;
		}

		public int method_5()
		{
			return int_1;
		}

		public unsafe int method_6(byte[] byte_1, int int_2, int int_3)
		{
			void* ptr = stackalloc byte[12];
			*(int*)ptr = int_0;
			if (int_3 > int_1)
			{
				int_3 = int_1;
			}
			else
			{
				*(int*)ptr = (int_0 - int_1 + int_3) & 0x7FFF;
			}
			*(int*)((byte*)ptr + 4) = int_3;
			*(int*)((byte*)ptr + 8) = int_3 - *(int*)ptr;
			if (*(int*)((byte*)ptr + 8) > 0)
			{
				Array.Copy(byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_1, int_2, *(int*)((byte*)ptr + 8));
				int_2 += *(int*)((byte*)ptr + 8);
				int_3 = *(int*)ptr;
			}
			Array.Copy(byte_0, *(int*)ptr - int_3, byte_1, int_2, int_3);
			int_1 -= *(int*)((byte*)ptr + 4);
			if (int_1 < 0)
			{
				throw new InvalidOperationException();
			}
			return *(int*)((byte*)ptr + 4);
		}
	}

	internal sealed class Class8
	{
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

		public Class8(byte[] byte_0)
		{
			method_0(byte_0);
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
					int[] array3;
					int[] array4 = (array3 = array);
					int num = *(int*)((byte*)ptr + 4);
					nint num2 = num;
					array4[num] = array3[num2] + 1;
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
					short_0[Class10.smethod_0(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
					*(int*)((byte*)ptr + 56) = Class10.smethod_0(*(int*)((byte*)ptr + 8));
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

		public unsafe int method_1(Class6 class6_0)
		{
			void* ptr = stackalloc byte[16];
			int num;
			int num2;
			if ((num = class6_0.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					class6_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)ptr = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = num2 & 0xF;
				if ((num = class6_0.method_0(*(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = short_0[*(int*)ptr | (num >> 9)];
					class6_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)((byte*)ptr + 8) = class6_0.method_2();
				num = class6_0.method_0(*(int*)((byte*)ptr + 8));
				num2 = short_0[*(int*)ptr | (num >> 9)];
				if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
				{
					class6_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			*(int*)((byte*)ptr + 12) = class6_0.method_2();
			num = class6_0.method_0(*(int*)((byte*)ptr + 12));
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				class6_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class Class9
	{
		private static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		private static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		private byte[] byte_0;

		private byte[] byte_1;

		private Class8 class8_0;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private byte byte_2;

		private int int_8;

		private static readonly int[] int_9 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		public unsafe bool method_0(Class6 class6_0)
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				switch (int_2)
				{
				case 5:
				{
					*(int*)((byte*)ptr + 4) = int_1[int_7];
					int num = class6_0.method_0(*(int*)((byte*)ptr + 4));
					if (num >= 0)
					{
						class6_0.method_1(*(int*)((byte*)ptr + 4));
						num += int_0[int_7];
						while (num-- > 0)
						{
							byte_1[int_8++] = byte_2;
						}
						if (int_8 == int_6)
						{
							return true;
						}
						goto IL_0080;
					}
					return false;
				}
				case 4:
				{
					int num2;
					while (((num2 = class8_0.method_1(class6_0)) & -16) == 0)
					{
						byte_1[int_8++] = (byte_2 = (byte)num2);
						if (int_8 == int_6)
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
						int_7 = num2 - 16;
						int_2 = 5;
						goto case 5;
					}
					return false;
				}
				case 3:
					while (int_8 < int_5)
					{
						*(int*)ptr = class6_0.method_0(3);
						if (*(int*)ptr >= 0)
						{
							class6_0.method_1(3);
							byte_0[int_9[int_8]] = (byte)(*(uint*)ptr);
							int_8++;
							continue;
						}
						return false;
					}
					class8_0 = new Class8(byte_0);
					byte_0 = null;
					int_8 = 0;
					int_2 = 4;
					goto case 4;
				case 2:
					int_5 = class6_0.method_0(4);
					if (int_5 >= 0)
					{
						int_5 += 4;
						class6_0.method_1(4);
						byte_0 = new byte[19];
						int_8 = 0;
						int_2 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_4 = class6_0.method_0(5);
					if (int_4 >= 0)
					{
						int_4++;
						class6_0.method_1(5);
						int_6 = int_3 + int_4;
						byte_1 = new byte[int_6];
						int_2 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_3 = class6_0.method_0(5);
					if (int_3 >= 0)
					{
						int_3 += 257;
						class6_0.method_1(5);
						int_2 = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_0080:
				int_2 = 4;
			}
		}

		public Class8 method_1()
		{
			byte[] destinationArray = new byte[int_3];
			Array.Copy(byte_1, 0, destinationArray, 0, int_3);
			return new Class8(destinationArray);
		}

		public Class8 method_2()
		{
			byte[] destinationArray = new byte[int_4];
			Array.Copy(byte_1, int_3, destinationArray, 0, int_4);
			return new Class8(destinationArray);
		}
	}

	internal sealed class Class10
	{
		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private static readonly short[] short_0;

		private static readonly byte[] byte_1;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		public static short smethod_0(int int_1)
		{
			return (short)((byte_0[int_1 & 0xF] << 12) | (byte_0[(int_1 >> 4) & 0xF] << 8) | (byte_0[(int_1 >> 8) & 0xF] << 4) | byte_0[int_1 >> 12]);
		}

		static Class10()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			byte_0 = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			short_0 = new short[286];
			byte_1 = new byte[286];
			int num = 0;
			while (num < 144)
			{
				short_0[num] = smethod_0(48 + num << 8);
				byte_1[num++] = 8;
			}
			while (num < 256)
			{
				short_0[num] = smethod_0(256 + num << 7);
				byte_1[num++] = 9;
			}
			while (num < 280)
			{
				short_0[num] = smethod_0(-256 + num << 9);
				byte_1[num++] = 7;
			}
			while (num < 286)
			{
				short_0[num] = smethod_0(-88 + num << 8);
				byte_1[num++] = 8;
			}
			short_1 = new short[30];
			byte_2 = new byte[30];
			for (num = 0; num < 30; num++)
			{
				short_1[num] = smethod_0(num << 11);
				byte_2[num] = 5;
			}
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public int method_0()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int method_1()
		{
			return method_0() | (method_0() << 16);
		}

		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}

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

	public unsafe static byte[] smethod_1(byte[] byte_0)
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
		*(int*)ptr = stream.method_1();
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)stream.method_0();
			*(int*)((byte*)ptr + 4) = stream.method_0();
			*(int*)((byte*)ptr + 8) = stream.method_0();
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			stream.method_1();
			stream.method_1();
			stream.method_1();
			*(int*)((byte*)ptr + 12) = stream.method_1();
			*(int*)((byte*)ptr + 16) = stream.method_0();
			*(int*)((byte*)ptr + 20) = stream.method_0();
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
			Class5 @class = new Class5(array2);
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
				*(int*)((byte*)ptr + 28) = stream.method_1();
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = stream.method_1();
					*(int*)((byte*)ptr + 40) = stream.method_1();
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class5 class2 = new Class5(array3);
					class2.method_2(array, *(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 40));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 251, 63, 11, 150, 205, 232, 188, 163 };
				byte[] byte_2 = new byte[8] { 197, 121, 165, 226, 125, 28, 238, 46 };
				using Class3 class3 = new Class3();
				using ICryptoTransform cryptoTransform = class3.method_0(byte_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = smethod_1(byte_3);
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
				using Class2 class4 = new Class2();
				using ICryptoTransform cryptoTransform2 = class4.method_0(byte_4, byte_5, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = smethod_1(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}
}
