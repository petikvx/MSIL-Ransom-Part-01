using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using ns2;
using ns3;

namespace ns6;

internal class Class7
{
	internal sealed class Class8
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

		private Class9 class9_0;

		private Class10 class10_0;

		private Class12 class12_0;

		private Class11 class11_0;

		private Class11 class11_1;

		public Class8(byte[] byte_0)
		{
			class9_0 = new Class9();
			class10_0 = new Class10();
			int_4 = 2;
			class9_0.method_7(byte_0, 0, byte_0.Length);
		}

		private bool method_0()
		{
			int num = class10_0.method_4();
			while (num >= 258)
			{
				switch (int_4)
				{
				case 7:
				{
					int num2;
					while (((num2 = class11_0.method_1(class9_0)) & -256) == 0)
					{
						class10_0.method_0(num2);
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
					class11_1 = null;
					class11_0 = null;
					int_4 = 2;
					return true;
				}
				case 8:
					if (int_5 > 0)
					{
						int_4 = 8;
						int num4 = class9_0.method_0(int_5);
						if (num4 < 0)
						{
							return false;
						}
						class9_0.method_1(int_5);
						int_6 += num4;
					}
					int_4 = 9;
					goto case 9;
				case 9:
				{
					int num2 = class11_1.method_1(class9_0);
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
						int num3 = class9_0.method_0(int_5);
						if (num3 < 0)
						{
							return false;
						}
						class9_0.method_1(int_5);
						int_7 += num3;
					}
					class10_0.method_2(int_6, int_7);
					num -= int_6;
					int_4 = 7;
					break;
				}
			}
			return true;
		}

		private bool method_1()
		{
			switch (int_4)
			{
			case 2:
			{
				if (bool_0)
				{
					int_4 = 12;
					return false;
				}
				int num = class9_0.method_0(3);
				if (num < 0)
				{
					return false;
				}
				class9_0.method_1(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (num >> 1)
				{
				case 0:
					class9_0.method_4();
					int_4 = 3;
					break;
				case 1:
					class11_0 = Class11.class11_0;
					class11_1 = Class11.class11_1;
					int_4 = 7;
					break;
				case 2:
					class12_0 = new Class12();
					int_4 = 6;
					break;
				}
				return true;
			}
			case 3:
				if ((int_8 = class9_0.method_0(16)) < 0)
				{
					return false;
				}
				class9_0.method_1(16);
				int_4 = 4;
				goto case 4;
			case 4:
			{
				int num2 = class9_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				class9_0.method_1(16);
				int_4 = 5;
				goto case 5;
			}
			case 5:
			{
				int num3 = class10_0.method_3(class9_0, int_8);
				int_8 -= num3;
				if (int_8 == 0)
				{
					int_4 = 2;
					return true;
				}
				return !class9_0.method_5();
			}
			case 6:
				if (!class12_0.method_0(class9_0))
				{
					return false;
				}
				class11_0 = class12_0.method_1();
				class11_1 = class12_0.method_2();
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

		public int method_2(byte[] byte_0, int int_9, int int_10)
		{
			int num = 0;
			do
			{
				if (int_4 != 11)
				{
					int num2 = class10_0.method_6(byte_0, int_9, int_10);
					int_9 += num2;
					num += num2;
					int_10 -= num2;
					if (int_10 == 0)
					{
						return num;
					}
				}
			}
			while (method_1() || (class10_0.method_5() > 0 && int_4 != 11));
			return num;
		}
	}

	internal sealed class Class9
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

		public int method_6(byte[] byte_1, int int_3, int int_4)
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

	internal sealed class Class10
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

		public int method_3(Class9 class9_0, int int_2)
		{
			int_2 = Math.Min(Math.Min(int_2, 32768 - int_1), class9_0.method_3());
			int num = 32768 - int_0;
			int num2;
			if (int_2 > num)
			{
				num2 = class9_0.method_6(byte_0, int_0, num);
				if (num2 == num)
				{
					num2 += class9_0.method_6(byte_0, 0, int_2 - num);
				}
			}
			else
			{
				num2 = class9_0.method_6(byte_0, int_0, int_2);
			}
			int_0 = (int_0 + num2) & 0x7FFF;
			int_1 += num2;
			return num2;
		}

		public int method_4()
		{
			return 32768 - int_1;
		}

		public int method_5()
		{
			return int_1;
		}

		public int method_6(byte[] byte_1, int int_2, int int_3)
		{
			int num = int_0;
			if (int_3 > int_1)
			{
				int_3 = int_1;
			}
			else
			{
				num = (int_0 - int_1 + int_3) & 0x7FFF;
			}
			int num2 = int_3;
			int num3 = int_3 - num;
			if (num3 > 0)
			{
				Array.Copy(byte_0, 32768 - num3, byte_1, int_2, num3);
				int_2 += num3;
				int_3 = num;
			}
			Array.Copy(byte_0, num - int_3, byte_1, int_2, int_3);
			int_1 -= num2;
			if (int_1 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}
	}

	internal sealed class Class11
	{
		private short[] short_0;

		public static readonly Class11 class11_0;

		public static readonly Class11 class11_1;

		static Class11()
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
			class11_0 = new Class11(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class11_1 = new Class11(array);
		}

		public Class11(byte[] byte_0)
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
					short_0[Class14.smethod_0(k)] = (short)((-num7 << 4) | num8);
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
				int num12 = Class14.smethod_0(num3);
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

		public int method_1(Class9 class9_0)
		{
			int num;
			int num2;
			if ((num = class9_0.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					class9_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int int_ = num2 & 0xF;
				if ((num = class9_0.method_0(int_)) >= 0)
				{
					num2 = short_0[num3 | (num >> 9)];
					class9_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int num4 = class9_0.method_2();
				num = class9_0.method_0(num4);
				num2 = short_0[num3 | (num >> 9)];
				if ((num2 & 0xF) <= num4)
				{
					class9_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int num5 = class9_0.method_2();
			num = class9_0.method_0(num5);
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= num5)
			{
				class9_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class Class12
	{
		private static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		private static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		private byte[] byte_0;

		private byte[] byte_1;

		private Class11 class11_0;

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

		public bool method_0(Class9 class9_0)
		{
			while (true)
			{
				switch (int_2)
				{
				case 5:
				{
					int num = int_1[int_7];
					int num2 = class9_0.method_0(num);
					if (num2 >= 0)
					{
						class9_0.method_1(num);
						num2 += int_0[int_7];
						while (num2-- > 0)
						{
							byte_1[int_8++] = byte_2;
						}
						if (int_8 == int_6)
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
					while (((num3 = class11_0.method_1(class9_0)) & -16) == 0)
					{
						byte_1[int_8++] = (byte_2 = (byte)num3);
						if (int_8 == int_6)
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
						int_7 = num3 - 16;
						int_2 = 5;
						goto case 5;
					}
					return false;
				}
				case 3:
					while (int_8 < int_5)
					{
						int num4 = class9_0.method_0(3);
						if (num4 >= 0)
						{
							class9_0.method_1(3);
							byte_0[int_9[int_8]] = (byte)num4;
							int_8++;
							continue;
						}
						return false;
					}
					class11_0 = new Class11(byte_0);
					byte_0 = null;
					int_8 = 0;
					int_2 = 4;
					goto case 4;
				case 2:
					int_5 = class9_0.method_0(4);
					if (int_5 >= 0)
					{
						int_5 += 4;
						class9_0.method_1(4);
						byte_0 = new byte[19];
						int_8 = 0;
						int_2 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_4 = class9_0.method_0(5);
					if (int_4 >= 0)
					{
						int_4++;
						class9_0.method_1(5);
						int_6 = int_3 + int_4;
						byte_1 = new byte[int_6];
						int_2 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_3 = class9_0.method_0(5);
					if (int_3 >= 0)
					{
						int_3 += 257;
						class9_0.method_1(5);
						int_2 = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_009b:
				int_2 = 4;
			}
		}

		public Class11 method_1()
		{
			byte[] destinationArray = new byte[int_3];
			Array.Copy(byte_1, 0, destinationArray, 0, int_3);
			return new Class11(destinationArray);
		}

		public Class11 method_2()
		{
			byte[] destinationArray = new byte[int_4];
			Array.Copy(byte_1, int_3, destinationArray, 0, int_4);
			return new Class11(destinationArray);
		}
	}

	internal sealed class Class13
	{
		private int int_0 = 16;

		private long long_0 = 0L;

		private Class17 class17_0;

		private Class16 class16_0;

		public Class13()
		{
			class17_0 = new Class17();
			class16_0 = new Class16(class17_0);
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
				return class17_0.method_5();
			}
			return false;
		}

		[SpecialName]
		public bool method_3()
		{
			return class16_0.method_8();
		}

		public void method_4(byte[] byte_0)
		{
			class16_0.method_7(byte_0);
		}

		public int method_5(byte[] byte_0)
		{
			int num = 0;
			int num2 = byte_0.Length;
			int num3 = num2;
			while (true)
			{
				int num4 = class17_0.method_6(byte_0, num, num2);
				num += num4;
				long_0 += num4;
				num2 -= num4;
				if (num2 == 0 || int_0 == 30)
				{
					break;
				}
				if (class16_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
				{
					continue;
				}
				if (int_0 != 16)
				{
					if (int_0 == 20)
					{
						for (int num5 = 8 + (-class17_0.method_2() & 7); num5 > 0; num5 -= 10)
						{
							class17_0.method_4(2, 10);
						}
						int_0 = 16;
					}
					else if (int_0 == 28)
					{
						class17_0.method_3();
						int_0 = 30;
					}
					continue;
				}
				return num3 - num2;
			}
			return num3 - num2;
		}
	}

	internal sealed class Class14
	{
		public sealed class Class15
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class14 class14_0;

			public Class15(Class14 class14_1, int int_4, int int_5, int int_6)
			{
				class14_0 = class14_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}

			public void method_0(int int_4)
			{
				class14_0.class17_0.method_4(short_1[int_4] & 0xFFFF, byte_0[int_4]);
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

			public void method_6(Class15 class15_0)
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
							short[] array2 = (array = class15_0.short_0);
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
						short[] array3 = (array = class15_0.short_0);
						int num8 = num;
						nint num7 = num8;
						array3[num8] = (short)(array[num7] + (short)num3);
					}
					else if (num != 0)
					{
						short[] array;
						(array = class15_0.short_0)[16] = (short)(array[16] + 1);
					}
					else if (num3 <= 10)
					{
						short[] array;
						(array = class15_0.short_0)[17] = (short)(array[17] + 1);
					}
					else
					{
						short[] array;
						(array = class15_0.short_0)[18] = (short)(array[18] + 1);
					}
				}
			}

			public void method_7(Class15 class15_0)
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
							class15_0.method_0(num4);
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
							class15_0.method_0(num);
						}
					}
					else if (num != 0)
					{
						class15_0.method_0(16);
						class14_0.class17_0.method_4(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						class15_0.method_0(17);
						class14_0.class17_0.method_4(num3 - 3, 3);
					}
					else
					{
						class15_0.method_0(18);
						class14_0.class17_0.method_4(num3 - 11, 7);
					}
				}
			}
		}

		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private Class17 class17_0;

		private Class15 class15_0;

		private Class15 class15_1;

		private Class15 class15_2;

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

		static Class14()
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

		public Class14(Class17 class17_1)
		{
			class17_0 = class17_1;
			class15_0 = new Class15(this, 286, 257, 15);
			class15_1 = new Class15(this, 30, 1, 15);
			class15_2 = new Class15(this, 19, 4, 7);
			short_0 = new short[16384];
			byte_1 = new byte[16384];
		}

		public void method_0()
		{
			int_1 = 0;
			int_2 = 0;
		}

		private int method_1(int int_3)
		{
			if (int_3 == 255)
			{
				return 285;
			}
			int num = 257;
			while (int_3 >= 8)
			{
				num += 4;
				int_3 >>= 1;
			}
			return num + int_3;
		}

		private int method_2(int int_3)
		{
			int num = 0;
			while (int_3 >= 4)
			{
				num += 2;
				int_3 >>= 1;
			}
			return num + int_3;
		}

		public void method_3(int int_3)
		{
			class15_2.method_2();
			class15_0.method_2();
			class15_1.method_2();
			class17_0.method_4(class15_0.int_1 - 257, 5);
			class17_0.method_4(class15_1.int_1 - 1, 5);
			class17_0.method_4(int_3 - 4, 4);
			for (int i = 0; i < int_3; i++)
			{
				class17_0.method_4(class15_2.byte_0[int_0[i]], 3);
			}
			class15_0.method_7(class15_2);
			class15_1.method_7(class15_2);
		}

		public void method_4()
		{
			for (int i = 0; i < int_1; i++)
			{
				int num = byte_1[i] & 0xFF;
				int num2 = short_0[i];
				if (num2-- != 0)
				{
					int num3 = method_1(num);
					class15_0.method_0(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						class17_0.method_4(num & ((1 << num4) - 1), num4);
					}
					int num5 = method_2(num2);
					class15_1.method_0(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						class17_0.method_4(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					class15_0.method_0(num);
				}
			}
			class15_0.method_0(256);
		}

		public void method_5(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			class17_0.method_4(bool_0 ? 1 : 0, 3);
			class17_0.method_3();
			class17_0.method_0(int_4);
			class17_0.method_0(~int_4);
			class17_0.method_1(byte_4, int_3, int_4);
			method_0();
		}

		public void method_6(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			short[] array;
			(array = class15_0.short_0)[256] = (short)(array[256] + 1);
			class15_0.method_4();
			class15_1.method_4();
			class15_0.method_6(class15_2);
			class15_1.method_6(class15_2);
			class15_2.method_4();
			int num = 4;
			for (int num2 = 18; num2 > num; num2--)
			{
				if (class15_2.byte_0[int_0[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			int num3 = 14 + num * 3 + class15_2.method_5() + class15_0.method_5() + class15_1.method_5() + int_2;
			int num4 = int_2;
			for (int i = 0; i < 286; i++)
			{
				num4 += class15_0.short_0[i] * byte_2[i];
			}
			for (int j = 0; j < 30; j++)
			{
				num4 += class15_1.short_0[j] * byte_3[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (int_3 >= 0 && int_4 + 4 < num3 >> 3)
			{
				method_5(byte_4, int_3, int_4, bool_0);
			}
			else if (num3 == num4)
			{
				class17_0.method_4(2 + (bool_0 ? 1 : 0), 3);
				class15_0.method_1(short_1, byte_2);
				class15_1.method_1(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class17_0.method_4(4 + (bool_0 ? 1 : 0), 3);
				method_3(num);
				method_4();
				method_0();
			}
		}

		public bool method_7()
		{
			return int_1 >= 16384;
		}

		public bool method_8(int int_3)
		{
			short_0[int_1] = 0;
			byte_1[int_1++] = (byte)int_3;
			short[] array;
			short[] array2 = (array = class15_0.short_0);
			nint num = int_3;
			array2[int_3] = (short)(array[num] + 1);
			return method_7();
		}

		public bool method_9(int int_3, int int_4)
		{
			short_0[int_1] = (short)int_3;
			byte_1[int_1++] = (byte)(int_4 - 3);
			int num = method_1(int_4 - 3);
			short[] array;
			short[] array2 = (array = class15_0.short_0);
			nint num2 = num;
			array2[num] = (short)(array[num2] + 1);
			if (num >= 265 && num < 285)
			{
				int_2 += (num - 261) / 4;
			}
			int num3 = method_2(int_3 - 1);
			short[] array3 = (array = class15_1.short_0);
			num2 = num3;
			array3[num3] = (short)(array[num2] + 1);
			if (num3 >= 4)
			{
				int_2 += num3 / 2 - 1;
			}
			return method_7();
		}
	}

	internal sealed class Class16
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

		private Class17 class17_0;

		private Class14 class14_0;

		public Class16(Class17 class17_1)
		{
			class17_0 = class17_1;
			class14_0 = new Class14(class17_1);
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

		private int method_1()
		{
			int num = ((int_0 << 5) ^ byte_0[int_4 + 2]) & 0x7FFF;
			short num2 = (short_1[int_4 & 0x7FFF] = short_0[num]);
			short_0[num] = (short)int_4;
			int_0 = num;
			return num2 & 0xFFFF;
		}

		private void method_2()
		{
			Array.Copy(byte_0, 32768, byte_0, 0, 32768);
			int_1 -= 32768;
			int_4 -= 32768;
			int_3 -= 32768;
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

		private bool method_4(int int_9)
		{
			int num = 128;
			int num2 = 128;
			short[] array = short_1;
			int num3 = int_4;
			int num4 = int_4 + int_2;
			int num5 = Math.Max(int_2, 2);
			int num6 = Math.Max(int_4 - 32506, 0);
			int num7 = int_4 + 258 - 1;
			byte b = byte_0[num4 - 1];
			byte b2 = byte_0[num4];
			if (num5 >= 8)
			{
				num >>= 2;
			}
			if (num2 > int_5)
			{
				num2 = int_5;
			}
			do
			{
				if (byte_0[int_9 + num5] != b2 || byte_0[int_9 + num5 - 1] != b || byte_0[int_9] != byte_0[num3] || byte_0[int_9 + 1] != byte_0[num3 + 1])
				{
					continue;
				}
				int num8 = int_9 + 2;
				num3 += 2;
				while (byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					int_1 = int_9;
					num4 = num3;
					num5 = num3 - int_4;
					if (num5 >= num2)
					{
						break;
					}
					b = byte_0[num4 - 1];
					b2 = byte_0[num4];
				}
				num3 = int_4;
			}
			while ((int_9 = array[int_9 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			int_2 = Math.Min(num5, int_5);
			return int_2 >= 3;
		}

		private bool method_5(bool bool_1, bool bool_2)
		{
			if (int_5 < 262 && !bool_1)
			{
				return false;
			}
			do
			{
				if (int_5 >= 262 || bool_1)
				{
					if (int_5 != 0)
					{
						if (int_4 >= 65274)
						{
							method_2();
						}
						int num = int_1;
						int num2 = int_2;
						if (int_5 >= 3)
						{
							int num3 = method_1();
							if (num3 != 0 && int_4 - num3 <= 32506 && method_4(num3) && int_2 <= 5 && int_2 == 3 && int_4 - int_1 > 4096)
							{
								int_2 = 2;
							}
						}
						if (num2 >= 3 && int_2 <= num2)
						{
							class14_0.method_9(int_4 - 1 - num, num2);
							num2 -= 2;
							do
							{
								int_4++;
								int_5--;
								if (int_5 >= 3)
								{
									method_1();
								}
							}
							while (--num2 > 0);
							int_4++;
							int_5--;
							bool_0 = false;
							int_2 = 2;
						}
						else
						{
							if (bool_0)
							{
								class14_0.method_8(byte_0[int_4 - 1] & 0xFF);
							}
							bool_0 = true;
							int_4++;
							int_5--;
						}
						continue;
					}
					if (bool_0)
					{
						class14_0.method_8(byte_0[int_4 - 1] & 0xFF);
					}
					bool_0 = false;
					class14_0.method_6(byte_0, int_3, int_4 - int_3, bool_2);
					int_3 = int_4;
					return false;
				}
				return true;
			}
			while (!class14_0.method_7());
			int num4 = int_4 - int_3;
			if (bool_0)
			{
				num4--;
			}
			bool flag = bool_2 && int_5 == 0 && !bool_0;
			class14_0.method_6(byte_0, int_3, num4, flag);
			int_3 += num4;
			return !flag;
		}

		public bool method_6(bool bool_1, bool bool_2)
		{
			bool flag;
			do
			{
				method_3();
				bool bool_3 = bool_1 && int_7 == int_8;
				flag = method_5(bool_3, bool_2);
			}
			while (class17_0.method_5() && flag);
			return flag;
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

	internal sealed class Class17
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

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

		public int method_6(byte[] byte_1, int int_3, int int_4)
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
				throw new FormatException("Wrong Header Signature");
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
			Class8 @class = new Class8(array2);
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
				throw new FormatException("Unknown Header");
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
					Class8 class2 = new Class8(array3);
					class2.method_2(array, i, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 173, 147, 142, 126, 165, 143, 250, 139 };
				byte[] byte_2 = new byte[8] { 110, 2, 38, 205, 200, 228, 32, 66 };
				using Class6 class3 = new Class6();
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
				using Class5 class4 = new Class5();
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
		return smethod_3(byte_0, 1, null, null);
	}

	private static byte[] smethod_3(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Stream0 stream = new Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class13 class4 = new Class13();
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
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				stream.method_0(bytes.Length);
				stream.method_0(0);
				stream.Write(bytes, 0, bytes.Length);
				class4.method_4(byte_0);
				while (!class4.method_3())
				{
					byte[] array9 = new byte[512];
					int num8 = class4.method_5(array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				class4.method_1();
				while (!class4.method_2())
				{
					byte[] array10 = new byte[512];
					int num9 = class4.method_5(array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long num10 = class4.method_0();
				stream.method_1(33639248);
				stream.method_0(20);
				stream.method_0(20);
				stream.method_0(0);
				stream.method_0(8);
				stream.method_1((int)num3);
				stream.method_1((int)num5);
				stream.method_1((int)num10);
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
				stream.method_1((int)(30 + bytes.Length + num10));
				stream.method_0(0);
				stream.Seek(position3, SeekOrigin.Begin);
				stream.method_1((int)num10);
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
					Class13 class3 = new Class13();
					class3.method_4(array5);
					while (!class3.method_3())
					{
						byte[] array6 = new byte[512];
						int num = class3.method_5(array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					class3.method_1();
					while (!class3.method_2())
					{
						byte[] array7 = new byte[512];
						int num2 = class3.method_5(array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					stream.method_1((int)class3.method_0());
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				stream.method_1(41777787);
				byte[] array3 = smethod_3(byte_0, 1, null, null);
				using (Class6 class2 = new Class6())
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
				byte[] array = smethod_3(byte_0, 1, null, null);
				using (Class5 @class = new Class5())
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
			string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}
}
