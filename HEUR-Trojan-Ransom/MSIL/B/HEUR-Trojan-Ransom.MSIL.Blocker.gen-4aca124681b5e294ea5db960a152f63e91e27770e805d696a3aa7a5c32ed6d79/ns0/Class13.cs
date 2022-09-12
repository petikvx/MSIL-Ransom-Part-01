using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using ns2;

namespace ns0;

internal static class Class13
{
	internal sealed class Class14
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

		private Class15 class15_0;

		private Class16 class16_0;

		private Class18 class18_0;

		private Class17 class17_0;

		private Class17 class17_1;

		public Class14(byte[] byte_0)
		{
			class15_0 = new Class15();
			class16_0 = new Class16();
			int_4 = 2;
			class15_0.method_7(byte_0, 0, byte_0.Length);
		}

		private unsafe bool method_0()
		{
			void* ptr = stackalloc byte[13];
			int num = class16_0.method_4();
			while (true)
			{
				if (num >= 258)
				{
					*(int*)ptr = int_4;
					switch (*(int*)ptr)
					{
					case 7:
					{
						int num2;
						while (((num2 = class17_0.method_1(class15_0)) & -256) == 0)
						{
							class16_0.method_0(num2);
							if (--num >= 258)
							{
								continue;
							}
							goto IL_01e5;
						}
						if (num2 >= 257)
						{
							int_6 = int_0[num2 - 257];
							int_5 = int_1[num2 - 257];
							goto case 8;
						}
						if (num2 < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						class17_1 = null;
						class17_0 = null;
						int_4 = 2;
						((byte*)ptr)[12] = 1;
						break;
					}
					case 8:
						if (int_5 > 0)
						{
							int_4 = 8;
							*(int*)((byte*)ptr + 4) = class15_0.method_0(int_5);
							if (*(int*)((byte*)ptr + 4) < 0)
							{
								((byte*)ptr)[12] = 0;
								break;
							}
							class15_0.method_1(int_5);
							int_6 += *(int*)((byte*)ptr + 4);
						}
						int_4 = 9;
						goto case 9;
					case 9:
					{
						int num2 = class17_1.method_1(class15_0);
						if (num2 >= 0)
						{
							int_7 = int_2[num2];
							int_5 = int_3[num2];
							goto case 10;
						}
						((byte*)ptr)[12] = 0;
						break;
					}
					case 10:
						if (int_5 > 0)
						{
							int_4 = 10;
							*(int*)((byte*)ptr + 8) = class15_0.method_0(int_5);
							if (*(int*)((byte*)ptr + 8) < 0)
							{
								((byte*)ptr)[12] = 0;
								break;
							}
							class15_0.method_1(int_5);
							int_7 += *(int*)((byte*)ptr + 8);
						}
						class16_0.method_2(int_6, int_7);
						num -= int_6;
						int_4 = 7;
						continue;
					default:
						continue;
						IL_01e5:
						((byte*)ptr)[12] = 1;
						break;
					}
				}
				else
				{
					((byte*)ptr)[12] = 1;
				}
				break;
			}
			return ((byte*)ptr)[12] != 0;
		}

		private unsafe bool method_1()
		{
			void* ptr = stackalloc byte[13];
			*(int*)((byte*)ptr + 4) = int_4;
			switch (*(int*)((byte*)ptr + 4))
			{
			case 2:
				if (bool_0)
				{
					int_4 = 12;
					((byte*)ptr)[12] = 0;
					break;
				}
				*(int*)ptr = class15_0.method_0(3);
				if (*(int*)ptr < 0)
				{
					((byte*)ptr)[12] = 0;
					break;
				}
				class15_0.method_1(3);
				if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (*(int*)ptr >> 1)
				{
				case 0:
					class15_0.method_4();
					int_4 = 3;
					break;
				case 1:
					class17_0 = Class17.class17_0;
					class17_1 = Class17.class17_1;
					int_4 = 7;
					break;
				case 2:
					class18_0 = new Class18();
					int_4 = 6;
					break;
				}
				((byte*)ptr)[12] = 1;
				break;
			case 3:
				if ((int_8 = class15_0.method_0(16)) < 0)
				{
					((byte*)ptr)[12] = 0;
					break;
				}
				class15_0.method_1(16);
				int_4 = 4;
				goto case 4;
			case 4:
				if (class15_0.method_0(16) < 0)
				{
					((byte*)ptr)[12] = 0;
					break;
				}
				class15_0.method_1(16);
				int_4 = 5;
				goto case 5;
			case 5:
				*(int*)((byte*)ptr + 8) = class16_0.method_3(class15_0, int_8);
				int_8 -= *(int*)((byte*)ptr + 8);
				if (int_8 == 0)
				{
					int_4 = 2;
					((byte*)ptr)[12] = 1;
				}
				else
				{
					((byte*)ptr)[12] = ((!class15_0.method_5()) ? ((byte)1) : ((byte)0));
				}
				break;
			case 6:
				if (!class18_0.method_0(class15_0))
				{
					((byte*)ptr)[12] = 0;
					break;
				}
				class17_0 = class18_0.method_1();
				class17_1 = class18_0.method_2();
				int_4 = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				((byte*)ptr)[12] = (method_0() ? ((byte)1) : ((byte)0));
				break;
			default:
				((byte*)ptr)[12] = 0;
				break;
			case 12:
				((byte*)ptr)[12] = 0;
				break;
			}
			return ((byte*)ptr)[12] != 0;
		}

		public unsafe int method_2(byte[] byte_0, int int_9, int int_10)
		{
			void* ptr = stackalloc byte[12];
			*(int*)ptr = 0;
			while (true)
			{
				if (int_4 != 11)
				{
					*(int*)((byte*)ptr + 4) = class16_0.method_6(byte_0, int_9, int_10);
					int_9 += *(int*)((byte*)ptr + 4);
					*(int*)ptr += *(int*)((byte*)ptr + 4);
					int_10 -= *(int*)((byte*)ptr + 4);
					if (int_10 == 0)
					{
						*(int*)((byte*)ptr + 8) = *(int*)ptr;
						break;
					}
				}
				if (!method_1() && (class16_0.method_5() <= 0 || int_4 == 11))
				{
					*(int*)((byte*)ptr + 8) = *(int*)ptr;
					break;
				}
			}
			return *(int*)((byte*)ptr + 8);
		}
	}

	internal sealed class Class15
	{
		private byte[] byte_0;

		private int int_0;

		private int int_1;

		private uint uint_0;

		private int int_2;

		public unsafe int method_0(int int_3)
		{
			void* ptr = stackalloc byte[8];
			if (int_2 < int_3)
			{
				if (int_0 == int_1)
				{
					*(int*)((byte*)ptr + 4) = -1;
					goto IL_00ac;
				}
				uint num = uint_0;
				byte[] array = byte_0;
				*(int*)ptr = int_0;
				int_0 = *(int*)ptr + 1;
				int num2 = array[*(int*)ptr] & 0xFF;
				byte[] array2 = byte_0;
				*(int*)ptr = int_0;
				int_0 = *(int*)ptr + 1;
				uint_0 = num | (uint)((num2 | ((array2[*(int*)ptr] & 0xFF) << 8)) << int_2);
				int_2 += 16;
			}
			*(int*)((byte*)ptr + 4) = (int)(uint_0 & ((1 << int_3) - 1));
			goto IL_00ac;
			IL_00ac:
			return *(int*)((byte*)ptr + 4);
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
			void* ptr = stackalloc byte[16];
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
				*(int*)((byte*)ptr + 12) = *(int*)ptr;
			}
			else
			{
				*(int*)((byte*)ptr + 4) = int_1 - int_0;
				if (int_4 > *(int*)((byte*)ptr + 4))
				{
					int_4 = *(int*)((byte*)ptr + 4);
				}
				Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
				int_0 += int_4;
				if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
				{
					byte[] array = byte_0;
					*(int*)((byte*)ptr + 8) = int_0;
					int_0 = *(int*)((byte*)ptr + 8) + 1;
					uint_0 = array[*(int*)((byte*)ptr + 8)] & 0xFFu;
					int_2 = 8;
				}
				*(int*)((byte*)ptr + 12) = *(int*)ptr + int_4;
			}
			return *(int*)((byte*)ptr + 12);
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

	internal sealed class Class16
	{
		private byte[] byte_0 = new byte[32768];

		private int int_0;

		private int int_1;

		public void method_0(int int_2)
		{
			if (int_1++ == 32768)
			{
				throw new InvalidOperationException();
			}
			byte_0[int_0++] = (byte)int_2;
			int_0 &= 32767;
		}

		private void method_1(int int_2, int int_3)
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
				method_1(num, int_2);
			}
		}

		public unsafe int method_3(Class15 class15_0, int int_2)
		{
			void* ptr = stackalloc byte[12];
			int_2 = Math.Min(Math.Min(int_2, 32768 - int_1), class15_0.method_3());
			*(int*)((byte*)ptr + 4) = 32768 - int_0;
			if (int_2 > *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr = class15_0.method_6(byte_0, int_0, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr += class15_0.method_6(byte_0, 0, int_2 - *(int*)((byte*)ptr + 4));
				}
			}
			else
			{
				*(int*)ptr = class15_0.method_6(byte_0, int_0, int_2);
			}
			int_0 = (int_0 + *(int*)ptr) & 0x7FFF;
			int_1 += *(int*)ptr;
			*(int*)((byte*)ptr + 8) = *(int*)ptr;
			return *(int*)((byte*)ptr + 8);
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
			void* ptr = stackalloc byte[16];
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
			*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
			return *(int*)((byte*)ptr + 12);
		}
	}

	internal sealed class Class17
	{
		private short[] short_0;

		public static readonly Class17 class17_0;

		public static readonly Class17 class17_1;

		static Class17()
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
			class17_0 = new Class17(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class17_1 = new Class17(array);
		}

		public Class17(byte[] byte_0)
		{
			method_0(byte_0);
		}

		private unsafe void method_0(byte[] byte_0)
		{
			void* ptr = stackalloc byte[64];
			int[] array = new int[16];
			int[] array2 = new int[16];
			*(int*)((byte*)ptr + 12) = 0;
			while (*(int*)((byte*)ptr + 12) < byte_0.Length)
			{
				*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
				if (*(int*)((byte*)ptr + 16) > 0)
				{
					array[*(int*)((byte*)ptr + 16)]++;
				}
				(*(int*)((byte*)ptr + 12))++;
			}
			*(int*)ptr = 0;
			*(int*)((byte*)ptr + 4) = 512;
			*(int*)((byte*)ptr + 20) = 1;
			while (*(int*)((byte*)ptr + 20) <= 15)
			{
				array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
				*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
				if (*(int*)((byte*)ptr + 20) >= 10)
				{
					*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
					*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
					*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
				}
				(*(int*)((byte*)ptr + 20))++;
			}
			short_0 = new short[*(int*)((byte*)ptr + 4)];
			*(int*)((byte*)ptr + 8) = 512;
			*(int*)((byte*)ptr + 32) = 15;
			while (*(int*)((byte*)ptr + 32) >= 10)
			{
				*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
				*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
				*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
				while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
				{
					short_0[Class20.smethod_0(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
					*(int*)((byte*)ptr + 40) += 128;
				}
				(*(int*)((byte*)ptr + 32))--;
			}
			*(int*)((byte*)ptr + 44) = 0;
			while (*(int*)((byte*)ptr + 44) < byte_0.Length)
			{
				*(int*)((byte*)ptr + 48) = byte_0[*(int*)((byte*)ptr + 44)];
				if (*(int*)((byte*)ptr + 48) != 0)
				{
					*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
					*(int*)((byte*)ptr + 52) = Class20.smethod_0(*(int*)ptr);
					if (*(int*)((byte*)ptr + 48) <= 9)
					{
						do
						{
							short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
							*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
						}
						while (*(int*)((byte*)ptr + 52) < 512);
					}
					else
					{
						*(int*)((byte*)ptr + 56) = short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
						*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
						*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
						do
						{
							short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
							*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
						}
						while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
					}
					array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
				}
				(*(int*)((byte*)ptr + 44))++;
			}
		}

		public unsafe int method_1(Class15 class15_0)
		{
			void* ptr = stackalloc byte[20];
			int num;
			if ((num = class15_0.method_0(9)) >= 0)
			{
				int num2;
				if ((num2 = short_0[num]) >= 0)
				{
					class15_0.method_1(num2 & 0xF);
					*(int*)((byte*)ptr + 16) = num2 >> 4;
				}
				else
				{
					*(int*)ptr = -(num2 >> 4);
					*(int*)((byte*)ptr + 4) = num2 & 0xF;
					if ((num = class15_0.method_0(*(int*)((byte*)ptr + 4))) >= 0)
					{
						num2 = short_0[*(int*)ptr | (num >> 9)];
						class15_0.method_1(num2 & 0xF);
						*(int*)((byte*)ptr + 16) = num2 >> 4;
					}
					else
					{
						*(int*)((byte*)ptr + 8) = class15_0.method_2();
						num = class15_0.method_0(*(int*)((byte*)ptr + 8));
						num2 = short_0[*(int*)ptr | (num >> 9)];
						if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
						{
							class15_0.method_1(num2 & 0xF);
							*(int*)((byte*)ptr + 16) = num2 >> 4;
						}
						else
						{
							*(int*)((byte*)ptr + 16) = -1;
						}
					}
				}
			}
			else
			{
				*(int*)((byte*)ptr + 12) = class15_0.method_2();
				num = class15_0.method_0(*(int*)((byte*)ptr + 12));
				int num2 = short_0[num];
				if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
				{
					class15_0.method_1(num2 & 0xF);
					*(int*)((byte*)ptr + 16) = num2 >> 4;
				}
				else
				{
					*(int*)((byte*)ptr + 16) = -1;
				}
			}
			return *(int*)((byte*)ptr + 16);
		}
	}

	internal sealed class Class18
	{
		private static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		private static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		private byte[] byte_0;

		private byte[] byte_1;

		private Class17 class17_0;

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

		public unsafe bool method_0(Class15 class15_0)
		{
			void* ptr = stackalloc byte[17];
			while (true)
			{
				*(int*)ptr = int_2;
				switch (*(int*)ptr)
				{
				default:
					continue;
				case 5:
				{
					*(int*)((byte*)ptr + 12) = int_1[int_7];
					int num = class15_0.method_0(*(int*)((byte*)ptr + 12));
					if (num >= 0)
					{
						class15_0.method_1(*(int*)((byte*)ptr + 12));
						num += int_0[int_7];
						while (num-- > 0)
						{
							byte[] array = byte_1;
							*(int*)((byte*)ptr + 8) = int_8;
							int_8 = *(int*)((byte*)ptr + 8) + 1;
							array[*(int*)((byte*)ptr + 8)] = byte_2;
						}
						if (int_8 == int_6)
						{
							((byte*)ptr)[16] = 1;
							break;
						}
						goto IL_00b4;
					}
					((byte*)ptr)[16] = 0;
					break;
				}
				case 4:
				{
					int num2;
					while (((num2 = class17_0.method_1(class15_0)) & -16) == 0)
					{
						byte[] array2 = byte_1;
						*(int*)((byte*)ptr + 8) = int_8;
						int_8 = *(int*)((byte*)ptr + 8) + 1;
						array2[*(int*)((byte*)ptr + 8)] = (byte_2 = (byte)num2);
						if (int_8 != int_6)
						{
							continue;
						}
						goto IL_02cb;
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
					((byte*)ptr)[16] = 0;
					break;
				}
				case 3:
					while (int_8 < int_5)
					{
						*(int*)((byte*)ptr + 4) = class15_0.method_0(3);
						if (*(int*)((byte*)ptr + 4) >= 0)
						{
							class15_0.method_1(3);
							byte_0[int_9[int_8]] = (byte)(*(uint*)((byte*)ptr + 4));
							int_8++;
							continue;
						}
						goto IL_02bb;
					}
					class17_0 = new Class17(byte_0);
					byte_0 = null;
					int_8 = 0;
					int_2 = 4;
					goto case 4;
				case 2:
					int_5 = class15_0.method_0(4);
					if (int_5 >= 0)
					{
						int_5 += 4;
						class15_0.method_1(4);
						byte_0 = new byte[19];
						int_8 = 0;
						int_2 = 3;
						goto case 3;
					}
					((byte*)ptr)[16] = 0;
					break;
				case 1:
					int_4 = class15_0.method_0(5);
					if (int_4 >= 0)
					{
						int_4++;
						class15_0.method_1(5);
						int_6 = int_3 + int_4;
						byte_1 = new byte[int_6];
						int_2 = 2;
						goto case 2;
					}
					((byte*)ptr)[16] = 0;
					break;
				case 0:
					{
						int_3 = class15_0.method_0(5);
						if (int_3 >= 0)
						{
							int_3 += 257;
							class15_0.method_1(5);
							int_2 = 1;
							goto case 1;
						}
						((byte*)ptr)[16] = 0;
						break;
					}
					IL_02cb:
					((byte*)ptr)[16] = 1;
					break;
					IL_02bb:
					((byte*)ptr)[16] = 0;
					break;
				}
				break;
				IL_00b4:
				int_2 = 4;
			}
			return ((byte*)ptr)[16] != 0;
		}

		public Class17 method_1()
		{
			byte[] destinationArray = new byte[int_3];
			Array.Copy(byte_1, 0, destinationArray, 0, int_3);
			return new Class17(destinationArray);
		}

		public Class17 method_2()
		{
			byte[] destinationArray = new byte[int_4];
			Array.Copy(byte_1, int_3, destinationArray, 0, int_4);
			return new Class17(destinationArray);
		}
	}

	internal sealed class Class19
	{
		private int int_0 = 16;

		private long long_0;

		private Class23 class23_0;

		private Class22 class22_0;

		public Class19()
		{
			class23_0 = new Class23();
			class22_0 = new Class22(class23_0);
		}

		[SpecialName]
		public long method_0()
		{
			return long_0;
		}

		public void method_1()
		{
			int_0 |= 12;
		}

		[SpecialName]
		public bool method_2()
		{
			if (int_0 == 30)
			{
				return class23_0.method_5();
			}
			return false;
		}

		[SpecialName]
		public bool method_3()
		{
			return class22_0.method_8();
		}

		public void method_4(byte[] byte_0)
		{
			class22_0.method_7(byte_0);
		}

		public unsafe int method_5(byte[] byte_0)
		{
			void* ptr = stackalloc byte[24];
			*(int*)ptr = 0;
			*(int*)((byte*)ptr + 4) = byte_0.Length;
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
			while (true)
			{
				*(int*)((byte*)ptr + 12) = class23_0.method_6(byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
				*(int*)ptr += *(int*)((byte*)ptr + 12);
				long_0 += *(int*)((byte*)ptr + 12);
				*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
				if (*(int*)((byte*)ptr + 4) != 0 && int_0 != 30)
				{
					if (class22_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
					{
						continue;
					}
					if (int_0 != 16)
					{
						if (int_0 == 20)
						{
							*(int*)((byte*)ptr + 16) = 8 + (-class23_0.method_2() & 7);
							while (*(int*)((byte*)ptr + 16) > 0)
							{
								class23_0.method_4(2, 10);
								*(int*)((byte*)ptr + 16) -= 10;
							}
							int_0 = 16;
						}
						else if (int_0 == 28)
						{
							class23_0.method_3();
							int_0 = 30;
						}
						continue;
					}
					*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
					break;
				}
				*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
				break;
			}
			return *(int*)((byte*)ptr + 20);
		}
	}

	internal sealed class Class20
	{
		public sealed class Class21
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class20 class20_0;

			public Class21(Class20 class20_1, int int_4, int int_5, int int_6)
			{
				class20_0 = class20_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}

			public void method_0(int int_4)
			{
				class20_0.class23_0.method_4(short_1[int_4] & 0xFFFF, byte_0[int_4]);
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
				void* ptr = stackalloc byte[32];
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
				int num6 = num;
				int[] array2 = new int[4 * num - 2];
				int[] array3 = new int[2 * num - 1];
				int num7 = num6;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < num)
				{
					*(int*)((byte*)ptr + 16) = array[*(int*)((byte*)ptr + 12)];
					array2[2 * *(int*)((byte*)ptr + 12)] = *(int*)((byte*)ptr + 16);
					array2[2 * *(int*)((byte*)ptr + 12) + 1] = -1;
					array3[*(int*)((byte*)ptr + 12)] = short_0[*(int*)((byte*)ptr + 16)] << 8;
					array[*(int*)((byte*)ptr + 12)] = *(int*)((byte*)ptr + 12);
					(*(int*)((byte*)ptr + 12))++;
				}
				do
				{
					*(int*)((byte*)ptr + 20) = array[0];
					int num8 = array[--num];
					int num9 = 0;
					int num10;
					for (num10 = 1; num10 < num; num10 = num10 * 2 + 1)
					{
						if (num10 + 1 < num && array3[array[num10]] > array3[array[num10 + 1]])
						{
							num10++;
						}
						array[num9] = array[num10];
						num9 = num10;
					}
					int num11 = array3[num8];
					while ((num10 = num9) > 0 && array3[array[num9 = (num10 - 1) / 2]] > num11)
					{
						array[num10] = array[num9];
					}
					array[num10] = num8;
					*(int*)((byte*)ptr + 24) = array[0];
					num8 = num7++;
					array2[2 * num8] = *(int*)((byte*)ptr + 20);
					array2[2 * num8 + 1] = *(int*)((byte*)ptr + 24);
					*(int*)((byte*)ptr + 28) = Math.Min(array3[*(int*)((byte*)ptr + 20)] & 0xFF, array3[*(int*)((byte*)ptr + 24)] & 0xFF);
					num11 = (array3[num8] = array3[*(int*)((byte*)ptr + 20)] + array3[*(int*)((byte*)ptr + 24)] - *(int*)((byte*)ptr + 28) + 1);
					num9 = 0;
					for (num10 = 1; num10 < num; num10 = num9 * 2 + 1)
					{
						if (num10 + 1 < num && array3[array[num10]] > array3[array[num10 + 1]])
						{
							num10++;
						}
						array[num9] = array[num10];
						num9 = num10;
					}
					while ((num10 = num9) > 0 && array3[array[num9 = (num10 - 1) / 2]] > num11)
					{
						array[num10] = array[num9];
					}
					array[num10] = num8;
				}
				while (num > 1);
				method_3(array2);
			}

			public unsafe int method_5()
			{
				void* ptr = stackalloc byte[12];
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < short_0.Length)
				{
					*(int*)ptr += short_0[*(int*)((byte*)ptr + 4)] * byte_0[*(int*)((byte*)ptr + 4)];
					(*(int*)((byte*)ptr + 4))++;
				}
				*(int*)((byte*)ptr + 8) = *(int*)ptr;
				return *(int*)((byte*)ptr + 8);
			}

			public unsafe void method_6(Class21 class21_0)
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
							class21_0.short_0[*(int*)((byte*)ptr + 16)]++;
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
						class21_0.short_0[*(int*)((byte*)ptr + 8)] += (short)num;
					}
					else if (*(int*)((byte*)ptr + 8) != 0)
					{
						class21_0.short_0[16]++;
					}
					else if (num <= 10)
					{
						class21_0.short_0[17]++;
					}
					else
					{
						class21_0.short_0[18]++;
					}
				}
			}

			public unsafe void method_7(Class21 class21_0)
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
							class21_0.method_0(*(int*)((byte*)ptr + 16));
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
							class21_0.method_0(*(int*)((byte*)ptr + 8));
						}
					}
					else if (*(int*)((byte*)ptr + 8) != 0)
					{
						class21_0.method_0(16);
						class20_0.class23_0.method_4(num - 3, 2);
					}
					else if (num <= 10)
					{
						class21_0.method_0(17);
						class20_0.class23_0.method_4(num - 3, 3);
					}
					else
					{
						class21_0.method_0(18);
						class20_0.class23_0.method_4(num - 11, 7);
					}
				}
			}
		}

		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private Class23 class23_0;

		private Class21 class21_0;

		private Class21 class21_1;

		private Class21 class21_2;

		private short[] short_0;

		private byte[] byte_1;

		private int int_1;

		private int int_2;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		private static readonly short[] short_2;

		private static readonly byte[] byte_3;

		public static short smethod_0(int int_3)
		{
			return (short)((byte_0[int_3 & 0xF] << 12) | (byte_0[(int_3 >> 4) & 0xF] << 8) | (byte_0[(int_3 >> 8) & 0xF] << 4) | byte_0[int_3 >> 12]);
		}

		static Class20()
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

		public Class20(Class23 class23_1)
		{
			class23_0 = class23_1;
			class21_0 = new Class21(this, 286, 257, 15);
			class21_1 = new Class21(this, 30, 1, 15);
			class21_2 = new Class21(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		public void method_0()
		{
			int_1 = 0;
			int_2 = 0;
		}

		private unsafe int method_1(int int_3)
		{
			void* ptr = stackalloc byte[8];
			if (int_3 == 255)
			{
				*(int*)((byte*)ptr + 4) = 285;
			}
			else
			{
				*(int*)ptr = 257;
				while (int_3 >= 8)
				{
					*(int*)ptr += 4;
					int_3 >>= 1;
				}
				*(int*)((byte*)ptr + 4) = *(int*)ptr + int_3;
			}
			return *(int*)((byte*)ptr + 4);
		}

		private unsafe int method_2(int int_3)
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = 0;
			while (int_3 >= 4)
			{
				*(int*)ptr += 2;
				int_3 >>= 1;
			}
			*(int*)((byte*)ptr + 4) = *(int*)ptr + int_3;
			return *(int*)((byte*)ptr + 4);
		}

		public void method_3(int int_3)
		{
			class21_2.method_2();
			class21_0.method_2();
			class21_1.method_2();
			class23_0.method_4(class21_0.int_1 - 257, 5);
			class23_0.method_4(class21_1.int_1 - 1, 5);
			class23_0.method_4(int_3 - 4, 4);
			for (int i = 0; i < int_3; i++)
			{
				class23_0.method_4(class21_2.byte_0[int_0[i]], 3);
			}
			class21_0.method_7(class21_2);
			class21_1.method_7(class21_2);
		}

		public unsafe void method_4()
		{
			void* ptr = stackalloc byte[20];
			*(int*)ptr = 0;
			while (*(int*)ptr < int_1)
			{
				*(int*)((byte*)ptr + 4) = byte_1[*(int*)ptr] & 0xFF;
				int num = short_0[*(int*)ptr];
				if (num-- != 0)
				{
					*(int*)((byte*)ptr + 8) = method_1(*(int*)((byte*)ptr + 4));
					class21_0.method_0(*(int*)((byte*)ptr + 8));
					*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
					if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
					{
						class23_0.method_4(*(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
					}
					*(int*)((byte*)ptr + 16) = method_2(num);
					class21_1.method_0(*(int*)((byte*)ptr + 16));
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
					if (*(int*)((byte*)ptr + 12) > 0)
					{
						class23_0.method_4(num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
					}
				}
				else
				{
					class21_0.method_0(*(int*)((byte*)ptr + 4));
				}
				(*(int*)ptr)++;
			}
			class21_0.method_0(256);
		}

		public void method_5(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			class23_0.method_4(bool_0 ? 1 : 0, 3);
			class23_0.method_3();
			class23_0.method_0(int_4);
			class23_0.method_0(~int_4);
			class23_0.method_1(byte_4, int_3, int_4);
			method_0();
		}

		public unsafe void method_6(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			void* ptr = stackalloc byte[24];
			class21_0.short_0[256]++;
			class21_0.method_4();
			class21_1.method_4();
			class21_0.method_6(class21_2);
			class21_1.method_6(class21_2);
			class21_2.method_4();
			*(int*)ptr = 4;
			*(int*)((byte*)ptr + 12) = 18;
			while (*(int*)((byte*)ptr + 12) > *(int*)ptr)
			{
				if (class21_2.byte_0[int_0[*(int*)((byte*)ptr + 12)]] > 0)
				{
					*(int*)ptr = *(int*)((byte*)ptr + 12) + 1;
				}
				(*(int*)((byte*)ptr + 12))--;
			}
			*(int*)((byte*)ptr + 4) = 14 + *(int*)ptr * 3 + class21_2.method_5() + class21_0.method_5() + class21_1.method_5() + int_2;
			*(int*)((byte*)ptr + 8) = int_2;
			*(int*)((byte*)ptr + 16) = 0;
			while (*(int*)((byte*)ptr + 16) < 286)
			{
				*(int*)((byte*)ptr + 8) += class21_0.short_0[*(int*)((byte*)ptr + 16)] * byte_2[*(int*)((byte*)ptr + 16)];
				(*(int*)((byte*)ptr + 16))++;
			}
			*(int*)((byte*)ptr + 20) = 0;
			while (*(int*)((byte*)ptr + 20) < 30)
			{
				*(int*)((byte*)ptr + 8) += class21_1.short_0[*(int*)((byte*)ptr + 20)] * byte_3[*(int*)((byte*)ptr + 20)];
				(*(int*)((byte*)ptr + 20))++;
			}
			if (*(int*)((byte*)ptr + 4) >= *(int*)((byte*)ptr + 8))
			{
				*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
			}
			if (int_3 >= 0 && int_4 + 4 < *(int*)((byte*)ptr + 4) >> 3)
			{
				method_5(byte_4, int_3, int_4, bool_0);
			}
			else if (*(int*)((byte*)ptr + 4) == *(int*)((byte*)ptr + 8))
			{
				class23_0.method_4(2 + (bool_0 ? 1 : 0), 3);
				class21_0.method_1(short_1, byte_2);
				class21_1.method_1(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class23_0.method_4(4 + (bool_0 ? 1 : 0), 3);
				method_3(*(int*)ptr);
				method_4();
				method_0();
			}
		}

		public bool method_7()
		{
			return int_1 >= 16384;
		}

		public unsafe bool method_8(int int_3)
		{
			void* ptr = stackalloc byte[5];
			short_0[int_1] = 0;
			byte[] array = byte_1;
			*(int*)ptr = int_1;
			int_1 = *(int*)ptr + 1;
			array[*(int*)ptr] = (byte)int_3;
			class21_0.short_0[int_3]++;
			((byte*)ptr)[4] = (method_7() ? ((byte)1) : ((byte)0));
			return ((byte*)ptr)[4] != 0;
		}

		public unsafe bool method_9(int int_3, int int_4)
		{
			void* ptr = stackalloc byte[13];
			short_0[int_1] = (short)int_3;
			byte[] array = byte_1;
			*(int*)((byte*)ptr + 8) = int_1;
			int_1 = *(int*)((byte*)ptr + 8) + 1;
			array[*(int*)((byte*)ptr + 8)] = (byte)(int_4 - 3);
			*(int*)ptr = method_1(int_4 - 3);
			class21_0.short_0[*(int*)ptr]++;
			if (*(int*)ptr >= 265 && *(int*)ptr < 285)
			{
				int_2 += (*(int*)ptr - 261) / 4;
			}
			*(int*)((byte*)ptr + 4) = method_2(int_3 - 1);
			class21_1.short_0[*(int*)((byte*)ptr + 4)]++;
			if (*(int*)((byte*)ptr + 4) >= 4)
			{
				int_2 += *(int*)((byte*)ptr + 4) / 2 - 1;
			}
			((byte*)ptr)[12] = (method_7() ? ((byte)1) : ((byte)0));
			return ((byte*)ptr)[12] != 0;
		}
	}

	internal sealed class Class22
	{
		private int int_0;

		private short[] short_0;

		private short[] short_1;

		private int int_1;

		private int int_2;

		private bool bool_0;

		private int int_3;

		private int int_4;

		private int int_5;

		private byte[] byte_0;

		private byte[] byte_1;

		private int int_6;

		private int int_7;

		private int int_8;

		private Class23 class23_0;

		private Class20 class20_0;

		public Class22(Class23 class23_1)
		{
			class23_0 = class23_1;
			class20_0 = new Class20(class23_1);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int num = 1;
			int_4 = 1;
			int_3 = 1;
		}

		private void method_0()
		{
			int_0 = (byte_0[int_4] << 5) ^ byte_0[int_4 + 1];
		}

		private unsafe int method_1()
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = ((int_0 << 5) ^ byte_0[int_4 + 2]) & 0x7FFF;
			short num = (short_1[int_4 & 0x7FFF] = short_0[*(int*)ptr]);
			short_0[*(int*)ptr] = (short)int_4;
			int_0 = *(int*)ptr;
			*(int*)((byte*)ptr + 4) = num & 0xFFFF;
			return *(int*)((byte*)ptr + 4);
		}

		private unsafe void method_2()
		{
			void* ptr = stackalloc byte[16];
			Array.Copy(byte_0, 32768, byte_0, 0, 32768);
			int_1 -= 32768;
			int_4 -= 32768;
			int_3 -= 32768;
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
			if (int_4 >= 65274)
			{
				method_2();
			}
			while (int_5 < 262 && int_7 < int_8)
			{
				int num = 65536 - int_5 - int_4;
				if (num > int_8 - int_7)
				{
					num = int_8 - int_7;
				}
				Array.Copy(byte_1, int_7, byte_0, int_4 + int_5, num);
				int_7 += num;
				int_6 += num;
				int_5 += num;
			}
			if (int_5 >= 3)
			{
				method_0();
			}
		}

		private unsafe bool method_4(int int_9)
		{
			void* ptr = stackalloc byte[23];
			int num = 128;
			*(int*)ptr = 128;
			short[] array = short_1;
			int num2 = int_4;
			*(int*)((byte*)ptr + 4) = int_4 + int_2;
			*(int*)((byte*)ptr + 8) = Math.Max(int_2, 2);
			*(int*)((byte*)ptr + 12) = Math.Max(int_4 - 32506, 0);
			*(int*)((byte*)ptr + 16) = int_4 + 258 - 1;
			((byte*)ptr)[20] = byte_0[*(int*)((byte*)ptr + 4) - 1];
			((byte*)ptr)[21] = byte_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) >= 8)
			{
				num >>= 2;
			}
			if (*(int*)ptr > int_5)
			{
				*(int*)ptr = int_5;
			}
			do
			{
				if (byte_0[int_9 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || byte_0[int_9 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || byte_0[int_9] != byte_0[num2] || byte_0[int_9 + 1] != byte_0[num2 + 1])
				{
					continue;
				}
				int num3 = int_9 + 2;
				num2 += 2;
				while (byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && byte_0[++num2] == byte_0[++num3] && num2 < *(int*)((byte*)ptr + 16))
				{
				}
				if (num2 > *(int*)((byte*)ptr + 4))
				{
					int_1 = int_9;
					*(int*)((byte*)ptr + 4) = num2;
					*(int*)((byte*)ptr + 8) = num2 - int_4;
					if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
					{
						break;
					}
					((byte*)ptr)[20] = byte_0[*(int*)((byte*)ptr + 4) - 1];
					((byte*)ptr)[21] = byte_0[*(int*)((byte*)ptr + 4)];
				}
				num2 = int_4;
			}
			while ((int_9 = array[int_9 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
			int_2 = Math.Min(*(int*)((byte*)ptr + 8), int_5);
			((byte*)ptr)[22] = ((int_2 >= 3) ? ((byte)1) : ((byte)0));
			return ((byte*)ptr)[22] != 0;
		}

		private unsafe bool method_5(bool bool_1, bool bool_2)
		{
			void* ptr = stackalloc byte[13];
			if (int_5 < 262 && !bool_1)
			{
				((byte*)ptr)[12] = 0;
			}
			else
			{
				while (true)
				{
					if (int_5 >= 262 || bool_1)
					{
						if (int_5 != 0)
						{
							if (int_4 >= 65274)
							{
								method_2();
							}
							*(int*)ptr = int_1;
							int num = int_2;
							if (int_5 >= 3)
							{
								*(int*)((byte*)ptr + 4) = method_1();
								if (*(int*)((byte*)ptr + 4) != 0 && int_4 - *(int*)((byte*)ptr + 4) <= 32506 && method_4(*(int*)((byte*)ptr + 4)) && int_2 <= 5 && int_2 == 3 && int_4 - int_1 > 4096)
								{
									int_2 = 2;
								}
							}
							if (num >= 3 && int_2 <= num)
							{
								class20_0.method_9(int_4 - 1 - *(int*)ptr, num);
								num -= 2;
								do
								{
									int_4++;
									int_5--;
									if (int_5 >= 3)
									{
										method_1();
									}
								}
								while (--num > 0);
								int_4++;
								int_5--;
								bool_0 = false;
								int_2 = 2;
							}
							else
							{
								if (bool_0)
								{
									class20_0.method_8(byte_0[int_4 - 1] & 0xFF);
								}
								bool_0 = true;
								int_4++;
								int_5--;
							}
							if (class20_0.method_7())
							{
								*(int*)((byte*)ptr + 8) = int_4 - int_3;
								if (bool_0)
								{
									(*(int*)((byte*)ptr + 8))--;
								}
								bool flag = bool_2 && int_5 == 0 && !bool_0;
								class20_0.method_6(byte_0, int_3, *(int*)((byte*)ptr + 8), flag);
								int_3 += *(int*)((byte*)ptr + 8);
								((byte*)ptr)[12] = ((!flag) ? ((byte)1) : ((byte)0));
								break;
							}
							continue;
						}
						if (bool_0)
						{
							class20_0.method_8(byte_0[int_4 - 1] & 0xFF);
						}
						bool_0 = false;
						class20_0.method_6(byte_0, int_3, int_4 - int_3, bool_2);
						int_3 = int_4;
						((byte*)ptr)[12] = 0;
						break;
					}
					((byte*)ptr)[12] = 1;
					break;
				}
			}
			return ((byte*)ptr)[12] != 0;
		}

		public unsafe bool method_6(bool bool_1, bool bool_2)
		{
			void* ptr = stackalloc byte[2];
			do
			{
				method_3();
				bool bool_3 = bool_1 && int_7 == int_8;
				*(bool*)ptr = method_5(bool_3, bool_2);
			}
			while (class23_0.method_5() & *(bool*)ptr);
			((byte*)ptr)[1] = *(byte*)ptr;
			return ((byte*)ptr)[1] != 0;
		}

		public void method_7(byte[] byte_2)
		{
			byte_1 = byte_2;
			int_7 = 0;
			int_8 = byte_2.Length;
		}

		public bool method_8()
		{
			return int_8 == int_7;
		}
	}

	internal sealed class Class23
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0;

		private int int_1;

		private uint uint_0;

		private int int_2;

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

		[SpecialName]
		public int method_2()
		{
			return int_2;
		}

		public void method_3()
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

		public void method_4(int int_3, int int_4)
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

		[SpecialName]
		public bool method_5()
		{
			return int_1 == 0;
		}

		public unsafe int method_6(byte[] byte_1, int int_3, int int_4)
		{
			void* ptr = stackalloc byte[8];
			if (int_2 >= 8)
			{
				byte[] array = byte_0;
				*(int*)ptr = int_1;
				int_1 = *(int*)ptr + 1;
				array[*(int*)ptr] = (byte)uint_0;
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
			*(int*)((byte*)ptr + 4) = int_4;
			return *(int*)((byte*)ptr + 4);
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

	private static ICryptoTransform smethod_0(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		return bool_0 ? rijndaelManaged.CreateDecryptor(byte_0, byte_1) : rijndaelManaged.CreateEncryptor(byte_0, byte_1);
	}

	public unsafe static byte[] smethod_1(byte[] byte_0)
	{
		void* ptr = stackalloc byte[16];
		Stream0 stream = new Stream0(byte_0);
		byte[] array = new byte[0];
		int num = stream.method_3();
		int num2 = num >> 24;
		if (num - (num2 << 24) == 8223355)
		{
			switch (num2)
			{
			case 1:
				*(int*)ptr = stream.method_3();
				array = new byte[*(int*)ptr];
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
				{
					*(int*)((byte*)ptr + 8) = stream.method_3();
					*(int*)((byte*)ptr + 12) = stream.method_3();
					byte[] array2 = new byte[*(int*)((byte*)ptr + 8)];
					stream.Read(array2, 0, array2.Length);
					new Class14(array2).method_2(array, *(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 12));
					*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 12);
				}
				break;
			default:
				throw new ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.");
			case 3:
			{
				byte[] byte_ = new byte[16]
				{
					26, 168, 133, 198, 53, 90, 174, 184, 121, 28,
					77, 247, 215, 247, 235, 143
				};
				byte[] byte_2 = new byte[16]
				{
					14, 221, 88, 171, 234, 112, 159, 10, 124, 72,
					103, 80, 22, 233, 210, 56
				};
				using (ICryptoTransform cryptoTransform = smethod_0(byte_, byte_2, bool_0: true))
				{
					array = smethod_1(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
				}
				break;
			}
			}
			stream.Close();
			stream = null;
			return array;
		}
		throw new FormatException("Unknown Header");
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		return smethod_3(byte_0, Enum5.const_1, null, null);
	}

	private unsafe static byte[] smethod_3(byte[] byte_0, Enum5 enum5_0, byte[] byte_1, byte[] byte_2)
	{
		void* ptr = stackalloc byte[28];
		try
		{
			Stream0 stream = new Stream0();
			switch (enum5_0)
			{
			case Enum5.const_1:
				stream.method_1(25000571);
				stream.method_1(byte_0.Length);
				*(int*)((byte*)ptr + 16) = 0;
				while (*(int*)((byte*)ptr + 16) < byte_0.Length)
				{
					byte[] array3 = new byte[Math.Min(2097151, byte_0.Length - *(int*)((byte*)ptr + 16))];
					Buffer.BlockCopy(byte_0, *(int*)((byte*)ptr + 16), array3, 0, array3.Length);
					*(long*)ptr = stream.Position;
					stream.method_1(0);
					stream.method_1(array3.Length);
					Class19 @class = new Class19();
					@class.method_4(array3);
					while (!@class.method_3())
					{
						byte[] array4 = new byte[512];
						*(int*)((byte*)ptr + 20) = @class.method_5(array4);
						if (*(int*)((byte*)ptr + 20) <= 0)
						{
							break;
						}
						stream.Write(array4, 0, *(int*)((byte*)ptr + 20));
					}
					@class.method_1();
					while (!@class.method_2())
					{
						byte[] array5 = new byte[512];
						*(int*)((byte*)ptr + 24) = @class.method_5(array5);
						if (*(int*)((byte*)ptr + 24) <= 0)
						{
							break;
						}
						stream.Write(array5, 0, *(int*)((byte*)ptr + 24));
					}
					*(long*)((byte*)ptr + 8) = stream.Position;
					stream.Position = *(long*)ptr;
					stream.method_1((int)@class.method_0());
					stream.Position = *(long*)((byte*)ptr + 8);
					*(int*)((byte*)ptr + 16) += array3.Length;
				}
				break;
			default:
				throw new ArgumentOutOfRangeException("algorithm", enum5_0, "Selected compression algorithm is not supported.");
			case Enum5.const_3:
			{
				stream.method_1(58555003);
				byte[] array = smethod_3(byte_0, Enum5.const_1, null, null);
				using (ICryptoTransform cryptoTransform = smethod_0(byte_1, byte_2, bool_0: false))
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
