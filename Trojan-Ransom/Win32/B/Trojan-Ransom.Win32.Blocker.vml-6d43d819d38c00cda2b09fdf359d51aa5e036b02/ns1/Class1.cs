using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns1;

internal class Class1
{
	internal sealed class Class2
	{
		private static int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static int[] int_3 = new int[30]
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

		private Class3 class3_0;

		private Class4 class4_0;

		private Class6 class6_0;

		private Class5 class5_0;

		private Class5 class5_1;

		public Class2(byte[] byte_0)
		{
			class3_0 = new Class3();
			class4_0 = new Class4();
			int_4 = 2;
			class3_0.method_7(byte_0, 0, byte_0.Length);
		}

		private bool method_0()
		{
			int num = class4_0.method_4();
			while (num >= 258)
			{
				switch (int_4)
				{
				case 7:
				{
					int num2;
					while (((num2 = class5_0.method_1(class3_0)) & -256) == 0)
					{
						class4_0.method_0(num2);
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
					class5_1 = null;
					class5_0 = null;
					int_4 = 2;
					return true;
				}
				case 8:
					if (int_5 > 0)
					{
						int_4 = 8;
						int num4 = class3_0.method_0(int_5);
						if (num4 < 0)
						{
							return false;
						}
						class3_0.method_1(int_5);
						int_6 += num4;
					}
					int_4 = 9;
					goto case 9;
				case 9:
				{
					int num2 = class5_1.method_1(class3_0);
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
						int num3 = class3_0.method_0(int_5);
						if (num3 < 0)
						{
							return false;
						}
						class3_0.method_1(int_5);
						int_7 += num3;
					}
					class4_0.method_2(int_6, int_7);
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
				int num = class3_0.method_0(3);
				if (num < 0)
				{
					return false;
				}
				class3_0.method_1(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					bool_0 = true;
				}
				switch (num >> 1)
				{
				case 0:
					class3_0.method_4();
					int_4 = 3;
					break;
				case 1:
					class5_0 = Class5.class5_0;
					class5_1 = Class5.class5_1;
					int_4 = 7;
					break;
				case 2:
					class6_0 = new Class6();
					int_4 = 6;
					break;
				}
				return true;
			}
			case 3:
				if ((int_8 = class3_0.method_0(16)) < 0)
				{
					return false;
				}
				class3_0.method_1(16);
				int_4 = 4;
				goto case 4;
			case 4:
			{
				int num2 = class3_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				class3_0.method_1(16);
				int_4 = 5;
				goto case 5;
			}
			case 5:
			{
				int num3 = class4_0.method_3(class3_0, int_8);
				int_8 -= num3;
				if (int_8 == 0)
				{
					int_4 = 2;
					return true;
				}
				return !class3_0.method_5();
			}
			case 6:
				if (!class6_0.method_0(class3_0))
				{
					return false;
				}
				class5_0 = class6_0.method_1();
				class5_1 = class6_0.method_2();
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
					int num2 = class4_0.method_6(byte_0, int_9, int_10);
					int_9 += num2;
					num += num2;
					int_10 -= num2;
					if (int_10 == 0)
					{
						return num;
					}
				}
			}
			while (method_1() || (class4_0.method_5() > 0 && int_4 != 11));
			return num;
		}
	}

	internal sealed class Class3
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

	internal sealed class Class4
	{
		private static int int_0 = 32768;

		private static int int_1 = int_0 - 1;

		private byte[] byte_0 = new byte[checked((uint)int_0)];

		private int int_2 = 0;

		private int int_3 = 0;

		public void method_0(int int_4)
		{
			if (int_3++ == int_0)
			{
				throw new InvalidOperationException();
			}
			byte_0[int_2++] = (byte)int_4;
			int_2 &= int_1;
		}

		private void method_1(int int_4, int int_5, int int_6)
		{
			while (int_5-- > 0)
			{
				byte_0[int_2++] = byte_0[int_4++];
				int_2 &= int_1;
				int_4 &= int_1;
			}
		}

		public void method_2(int int_4, int int_5)
		{
			if ((int_3 += int_4) > int_0)
			{
				throw new InvalidOperationException();
			}
			int num = (int_2 - int_5) & int_1;
			int num2 = int_0 - int_4;
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

		public int method_3(Class3 class3_0, int int_4)
		{
			int_4 = Math.Min(Math.Min(int_4, int_0 - int_3), class3_0.method_3());
			int num = int_0 - int_2;
			int num2;
			if (int_4 > num)
			{
				num2 = class3_0.method_6(byte_0, int_2, num);
				if (num2 == num)
				{
					num2 += class3_0.method_6(byte_0, 0, int_4 - num);
				}
			}
			else
			{
				num2 = class3_0.method_6(byte_0, int_2, int_4);
			}
			int_2 = (int_2 + num2) & int_1;
			int_3 += num2;
			return num2;
		}

		public int method_4()
		{
			return int_0 - int_3;
		}

		public int method_5()
		{
			return int_3;
		}

		public int method_6(byte[] byte_1, int int_4, int int_5)
		{
			int num = int_2;
			if (int_5 > int_3)
			{
				int_5 = int_3;
			}
			else
			{
				num = (int_2 - int_3 + int_5) & int_1;
			}
			int num2 = int_5;
			int num3 = int_5 - num;
			if (num3 > 0)
			{
				Array.Copy(byte_0, int_0 - num3, byte_1, int_4, num3);
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
	}

	internal sealed class Class5
	{
		private static int int_0;

		private short[] short_0;

		public static Class5 class5_0;

		public static Class5 class5_1;

		static Class5()
		{
			int_0 = 15;
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
			class5_0 = new Class5(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class5_1 = new Class5(array);
		}

		public Class5(byte[] byte_0)
		{
			method_0(byte_0);
		}

		private void method_0(byte[] byte_0)
		{
			int[] array;
			int[] array2;
			checked
			{
				array = new int[(uint)unchecked(int_0 + 1)];
				array2 = new int[(uint)unchecked(int_0 + 1)];
			}
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
			for (int j = 1; j <= int_0; j++)
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
			for (int num8 = int_0; num8 >= 10; num8--)
			{
				int num9 = num3 & 0x1FF80;
				num3 -= array[num8] << 16 - num8;
				int num10 = num3 & 0x1FF80;
				for (int k = num10; k < num9; k += 128)
				{
					short_0[Class7.smethod_0(k)] = (short)((-num7 << 4) | num8);
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
				int num12 = Class7.smethod_0(num3);
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

		public int method_1(Class3 class3_0)
		{
			int num;
			int num2;
			if ((num = class3_0.method_0(9)) >= 0)
			{
				if ((num2 = short_0[num]) >= 0)
				{
					class3_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int int_ = num2 & 0xF;
				if ((num = class3_0.method_0(int_)) >= 0)
				{
					num2 = short_0[num3 | (num >> 9)];
					class3_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				int num4 = class3_0.method_2();
				num = class3_0.method_0(num4);
				num2 = short_0[num3 | (num >> 9)];
				if ((num2 & 0xF) <= num4)
				{
					class3_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int num5 = class3_0.method_2();
			num = class3_0.method_0(num5);
			num2 = short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= num5)
			{
				class3_0.method_1(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class Class6
	{
		private static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		private static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		private byte[] byte_0;

		private byte[] byte_1;

		private Class5 class5_0;

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

		public bool method_0(Class3 class3_0)
		{
			while (true)
			{
				switch (int_2)
				{
				case 5:
				{
					int num = int_1[int_7];
					int num2 = class3_0.method_0(num);
					if (num2 >= 0)
					{
						class3_0.method_1(num);
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
					while (((num3 = class5_0.method_1(class3_0)) & -16) == 0)
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
						int num4 = class3_0.method_0(3);
						if (num4 >= 0)
						{
							class3_0.method_1(3);
							byte_0[int_9[int_8]] = (byte)num4;
							int_8++;
							continue;
						}
						return false;
					}
					class5_0 = new Class5(byte_0);
					byte_0 = null;
					int_8 = 0;
					int_2 = 4;
					goto case 4;
				case 2:
					int_5 = class3_0.method_0(4);
					if (int_5 >= 0)
					{
						int_5 += 4;
						class3_0.method_1(4);
						byte_0 = new byte[19];
						int_8 = 0;
						int_2 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_4 = class3_0.method_0(5);
					if (int_4 >= 0)
					{
						int_4++;
						class3_0.method_1(5);
						int_6 = int_3 + int_4;
						byte_1 = new byte[checked((uint)int_6)];
						int_2 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_3 = class3_0.method_0(5);
					if (int_3 >= 0)
					{
						int_3 += 257;
						class3_0.method_1(5);
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

		public Class5 method_1()
		{
			byte[] destinationArray = new byte[checked((uint)int_3)];
			Array.Copy(byte_1, 0, destinationArray, 0, int_3);
			return new Class5(destinationArray);
		}

		public Class5 method_2()
		{
			byte[] destinationArray = new byte[checked((uint)int_4)];
			Array.Copy(byte_1, int_3, destinationArray, 0, int_4);
			return new Class5(destinationArray);
		}
	}

	internal sealed class Class7
	{
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

		private static short[] short_0;

		private static byte[] byte_1;

		private static short[] short_1;

		private static byte[] byte_2;

		public static short smethod_0(int int_9)
		{
			return (short)((byte_0[int_9 & 0xF] << 12) | (byte_0[(int_9 >> 4) & 0xF] << 8) | (byte_0[(int_9 >> 8) & 0xF] << 4) | byte_0[int_9 >> 12]);
		}

		static Class7()
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
			int num;
			checked
			{
				short_0 = new short[(uint)int_1];
				byte_1 = new byte[(uint)int_1];
				num = 0;
			}
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
			while (num < int_1)
			{
				short_0[num] = smethod_0(-88 + num << 8);
				byte_1[num++] = 8;
			}
			checked
			{
				short_1 = new short[(uint)int_2];
				byte_2 = new byte[(uint)int_2];
			}
			for (num = 0; num < int_2; num++)
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

	public static byte[] smethod_0(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		if ((object)callingAssembly != Assembly.GetExecutingAssembly())
		{
			byte[] array = new byte[160]
			{
				0, 36, 0, 0, 4, 128, 0, 0, 148, 0,
				0, 0, 6, 2, 0, 0, 0, 36, 0, 0,
				82, 83, 65, 49, 0, 4, 0, 0, 1, 0,
				1, 0, 155, 13, 72, 198, 251, 251, 159, 192,
				126, 203, 208, 106, 207, 151, 67, 79, 153, 138,
				42, 235, 200, 100, 41, 4, 48, 247, 182, 10,
				11, 253, 215, 33, 66, 23, 184, 218, 113, 154,
				97, 197, 196, 128, 183, 155, 100, 136, 59, 151,
				215, 247, 208, 46, 251, 160, 227, 202, 42, 33,
				66, 161, 35, 198, 51, 225, 152, 105, 234, 205,
				89, 146, 157, 78, 189, 126, 118, 231, 120, 86,
				231, 57, 149, 79, 14, 98, 249, 174, 164, 130,
				31, 14, 117, 225, 158, 48, 176, 166, 140, 73,
				97, 215, 194, 12, 215, 250, 211, 229, 9, 128,
				11, 234, 142, 76, 19, 107, 229, 30, 127, 42,
				39, 123, 207, 115, 215, 2, 95, 171, 184, 208
			};
			byte[] publicKey = callingAssembly.GetName().GetPublicKey();
			if (publicKey == null)
			{
				return null;
			}
			if (publicKey.Length != 160)
			{
				return null;
			}
			for (int i = 0; i < 160; i++)
			{
				if (publicKey[i] != array[i])
				{
					return null;
				}
			}
		}
		Stream0 stream = new Stream0(byte_0);
		byte[] array2 = new byte[0];
		int num = stream.method_1();
		if (num == 67324752)
		{
			short num2 = (short)stream.method_0();
			int num3 = stream.method_0();
			int num4 = stream.method_0();
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			stream.method_1();
			stream.method_1();
			stream.method_1();
			int num5 = stream.method_1();
			int num6 = stream.method_0();
			int num7 = stream.method_0();
			checked
			{
				if (num6 > 0)
				{
					byte[] buffer = new byte[(uint)num6];
					stream.Read(buffer, 0, num6);
				}
				if (num7 > 0)
				{
					byte[] buffer2 = new byte[(uint)num7];
					stream.Read(buffer2, 0, num7);
				}
				byte[] array3 = new byte[(uint)unchecked(stream.Length - stream.Position)];
				stream.Read(array3, 0, array3.Length);
				Class2 @class = new Class2(array3);
				array2 = new byte[(uint)num5];
				@class.method_2(array2, 0, array2.Length);
				array3 = null;
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
				int num9 = stream.method_1();
				array2 = new byte[checked((uint)num9)];
				int num11;
				for (int j = 0; j < num9; j += num11)
				{
					int num10 = stream.method_1();
					num11 = stream.method_1();
					byte[] array4 = new byte[checked((uint)num10)];
					stream.Read(array4, 0, array4.Length);
					Class2 class2 = new Class2(array4);
					class2.method_2(array2, j, num11);
				}
			}
			if (num8 == 2)
			{
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				dESCryptoServiceProvider.Key = new byte[8] { 110, 243, 21, 252, 239, 13, 5, 83 };
				dESCryptoServiceProvider.IV = new byte[8] { 20, 25, 99, 253, 61, 23, 144, 184 };
				ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				byte[] byte_ = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				dESCryptoServiceProvider.Clear();
				array2 = smethod_0(byte_);
			}
		}
		stream.Close();
		stream = null;
		return array2;
	}
}
