using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns4;

namespace ns3;

[GAttribute0(20)]
internal class Class3
{
	[GAttribute0(21)]
	internal class Class4
	{
		private int int_0 = 16;

		private long long_0 = 0L;

		private Class8 class8_0;

		private Class7 class7_0;

		public Class4()
		{
			class8_0 = new Class8();
			class7_0 = new Class7(class8_0);
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
				return class8_0.method_5();
			}
			return false;
		}

		[SpecialName]
		public bool method_3()
		{
			return class7_0.method_8();
		}

		public void method_4(byte[] byte_0)
		{
			class7_0.method_7(byte_0);
		}

		public int method_5(byte[] byte_0)
		{
			int num = 0;
			int num2 = byte_0.Length;
			int num3 = num2;
			while (true)
			{
				int num4 = class8_0.method_6(byte_0, num, num2);
				num += num4;
				long_0 += num4;
				num2 -= num4;
				if (num2 == 0 || int_0 == 30)
				{
					break;
				}
				if (class7_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
				{
					continue;
				}
				if (int_0 != 16)
				{
					if (int_0 == 20)
					{
						for (int num5 = 8 + (-class8_0.method_2() & 7); num5 > 0; num5 -= 10)
						{
							class8_0.method_4(2, 10);
						}
						int_0 = 16;
					}
					else if (int_0 == 28)
					{
						class8_0.method_3();
						int_0 = 30;
					}
					continue;
				}
				return num3 - num2;
			}
			return num3 - num2;
		}
	}

	[GAttribute0(22)]
	internal class Class5
	{
		[GAttribute0(23)]
		public class Class6
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class5 class5_0;

			public Class6(Class5 class5_1, int int_4, int int_5, int int_6)
			{
				class5_0 = class5_1;
				int_0 = int_5;
				int_3 = int_6;
				short_0 = new short[int_4];
				int_2 = new int[int_6];
			}

			public void method_0(int int_4)
			{
				class5_0.class8_0.method_4(short_1[int_4] & 0xFFFF, byte_0[int_4]);
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

			public void method_6(Class6 class6_0)
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
							short[] array2 = (array = class6_0.short_0);
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
						short[] array3 = (array = class6_0.short_0);
						int num8 = num;
						nint num7 = num8;
						array3[num8] = (short)(array[num7] + (short)num3);
					}
					else if (num != 0)
					{
						short[] array;
						short[] array4 = (array = class6_0.short_0);
						int int_ = int_4;
						nint num7 = int_;
						array4[int_] = (short)(array[num7] + 1);
					}
					else if (num3 <= 10)
					{
						short[] array;
						short[] array5 = (array = class6_0.short_0);
						int int_2 = int_5;
						nint num7 = int_2;
						array5[int_2] = (short)(array[num7] + 1);
					}
					else
					{
						short[] array;
						short[] array6 = (array = class6_0.short_0);
						int int_3 = int_6;
						nint num7 = int_3;
						array6[int_3] = (short)(array[num7] + 1);
					}
				}
			}

			public void method_7(Class6 class6_0)
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
							class6_0.method_0(num4);
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
							class6_0.method_0(num);
						}
					}
					else if (num != 0)
					{
						class6_0.method_0(int_4);
						class5_0.class8_0.method_4(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						class6_0.method_0(int_5);
						class5_0.class8_0.method_4(num3 - 3, 3);
					}
					else
					{
						class6_0.method_0(int_6);
						class5_0.class8_0.method_4(num3 - 11, 7);
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

		private Class8 class8_0;

		private Class6 class6_0;

		private Class6 class6_1;

		private Class6 class6_2;

		private short[] short_0;

		private byte[] byte_1;

		private int int_9;

		private int int_10;

		private static short[] short_1;

		private static byte[] byte_2;

		private static short[] short_2;

		private static byte[] byte_3;

		public static short smethod_0(int int_11)
		{
			return (short)((byte_0[int_11 & 0xF] << 12) | (byte_0[(int_11 >> 4) & 0xF] << 8) | (byte_0[(int_11 >> 8) & 0xF] << 4) | byte_0[int_11 >> 12]);
		}

		static Class5()
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

		public Class5(Class8 class8_1)
		{
			class8_0 = class8_1;
			class6_0 = new Class6(this, int_1, 257, 15);
			class6_1 = new Class6(this, int_2, 1, 15);
			class6_2 = new Class6(this, int_3, 4, 7);
			short_0 = new short[int_0];
			byte_1 = new byte[int_0];
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
			class6_2.method_2();
			class6_0.method_2();
			class6_1.method_2();
			class8_0.method_4(class6_0.int_1 - 257, 5);
			class8_0.method_4(class6_1.int_1 - 1, 5);
			class8_0.method_4(int_11 - 4, 4);
			for (int i = 0; i < int_11; i++)
			{
				class8_0.method_4(class6_2.byte_0[int_8[i]], 3);
			}
			class6_0.method_7(class6_2);
			class6_1.method_7(class6_2);
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
					class6_0.method_0(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						class8_0.method_4(num & ((1 << num4) - 1), num4);
					}
					int num5 = method_2(num2);
					class6_1.method_0(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						class8_0.method_4(num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					class6_0.method_0(num);
				}
			}
			class6_0.method_0(int_7);
		}

		public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			class8_0.method_4(bool_0 ? 1 : 0, 3);
			class8_0.method_3();
			class8_0.method_0(int_12);
			class8_0.method_0(~int_12);
			class8_0.method_1(byte_4, int_11, int_12);
			method_0();
		}

		public void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			short[] array;
			short[] array2 = (array = class6_0.short_0);
			int num = int_7;
			nint num2 = num;
			array2[num] = (short)(array[num2] + 1);
			class6_0.method_4();
			class6_1.method_4();
			class6_0.method_6(class6_2);
			class6_1.method_6(class6_2);
			class6_2.method_4();
			int num3 = 4;
			for (int num4 = 18; num4 > num3; num4--)
			{
				if (class6_2.byte_0[int_8[num4]] > 0)
				{
					num3 = num4 + 1;
				}
			}
			int num5 = 14 + num3 * 3 + class6_2.method_5() + class6_0.method_5() + class6_1.method_5() + int_10;
			int num6 = int_10;
			for (int i = 0; i < int_1; i++)
			{
				num6 += class6_0.short_0[i] * byte_2[i];
			}
			for (int j = 0; j < int_2; j++)
			{
				num6 += class6_1.short_0[j] * byte_3[j];
			}
			if (num5 >= num6)
			{
				num5 = num6;
			}
			if (int_11 >= 0 && int_12 + 4 < num5 >> 3)
			{
				method_5(byte_4, int_11, int_12, bool_0);
			}
			else if (num5 == num6)
			{
				class8_0.method_4(2 + (bool_0 ? 1 : 0), 3);
				class6_0.method_1(short_1, byte_2);
				class6_1.method_1(short_2, byte_3);
				method_4();
				method_0();
			}
			else
			{
				class8_0.method_4(4 + (bool_0 ? 1 : 0), 3);
				method_3(num3);
				method_4();
				method_0();
			}
		}

		public bool method_7()
		{
			return int_9 >= int_0;
		}

		public bool method_8(int int_11)
		{
			short_0[int_9] = 0;
			byte_1[int_9++] = (byte)int_11;
			short[] array;
			short[] array2 = (array = class6_0.short_0);
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
			short[] array2 = (array = class6_0.short_0);
			nint num2 = num;
			array2[num] = (short)(array[num2] + 1);
			if (num >= 265 && num < 285)
			{
				int_10 += (num - 261) / 4;
			}
			int num3 = method_2(int_11 - 1);
			short[] array3 = (array = class6_1.short_0);
			num2 = num3;
			array3[num3] = (short)(array[num2] + 1);
			if (num3 >= 4)
			{
				int_10 += num3 / 2 - 1;
			}
			return method_7();
		}
	}

	[GAttribute0(24)]
	internal class Class7
	{
		private static int int_0 = 4096;

		private int int_1;

		private short[] short_0;

		private short[] short_1;

		private int int_2;

		private int int_3;

		private bool bool_0;

		private int int_4;

		private int int_5;

		private int int_6;

		private byte[] byte_0;

		private byte[] byte_1;

		private int int_7;

		private int int_8;

		private int int_9;

		private Class8 class8_0;

		private Class5 class5_0;

		public Class7(Class8 class8_1)
		{
			class8_0 = class8_1;
			class5_0 = new Class5(class8_1);
			byte_0 = new byte[65536];
			short_0 = new short[32768];
			short_1 = new short[32768];
			int_5 = 1;
			int_4 = 1;
		}

		private void method_0()
		{
			int_1 = (byte_0[int_5] << 5) ^ byte_0[int_5 + 1];
		}

		private int method_1()
		{
			int num = ((int_1 << 5) ^ byte_0[int_5 + 2]) & 0x7FFF;
			short num2 = (short_1[int_5 & 0x7FFF] = short_0[num]);
			short_0[num] = (short)int_5;
			int_1 = num;
			return num2 & 0xFFFF;
		}

		private void method_2()
		{
			Array.Copy(byte_0, 32768, byte_0, 0, 32768);
			int_2 -= 32768;
			int_5 -= 32768;
			int_4 -= 32768;
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
			if (int_5 >= 65274)
			{
				method_2();
			}
			while (int_6 < 262 && int_8 < int_9)
			{
				int num = 65536 - int_6 - int_5;
				if (num > int_9 - int_8)
				{
					num = int_9 - int_8;
				}
				Array.Copy(byte_1, int_8, byte_0, int_5 + int_6, num);
				int_8 += num;
				int_7 += num;
				int_6 += num;
			}
			if (int_6 >= 3)
			{
				method_0();
			}
		}

		private bool method_4(int int_10)
		{
			int num = 128;
			int num2 = 128;
			short[] array = short_1;
			int num3 = int_5;
			int num4 = int_5 + int_3;
			int num5 = Math.Max(int_3, 2);
			int num6 = Math.Max(int_5 - 32506, 0);
			int num7 = int_5 + 258 - 1;
			byte b = byte_0[num4 - 1];
			byte b2 = byte_0[num4];
			if (num5 >= 8)
			{
				num >>= 2;
			}
			if (num2 > int_6)
			{
				num2 = int_6;
			}
			do
			{
				if (byte_0[int_10 + num5] != b2 || byte_0[int_10 + num5 - 1] != b || byte_0[int_10] != byte_0[num3] || byte_0[int_10 + 1] != byte_0[num3 + 1])
				{
					continue;
				}
				int num8 = int_10 + 2;
				num3 += 2;
				while (byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					int_2 = int_10;
					num4 = num3;
					num5 = num3 - int_5;
					if (num5 >= num2)
					{
						break;
					}
					b = byte_0[num4 - 1];
					b2 = byte_0[num4];
				}
				num3 = int_5;
			}
			while ((int_10 = array[int_10 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			int_3 = Math.Min(num5, int_6);
			return int_3 >= 3;
		}

		private bool method_5(bool bool_1, bool bool_2)
		{
			if (int_6 < 262 && !bool_1)
			{
				return false;
			}
			do
			{
				if (int_6 >= 262 || bool_1)
				{
					if (int_6 != 0)
					{
						if (int_5 >= 65274)
						{
							method_2();
						}
						int num = int_2;
						int num2 = int_3;
						if (int_6 >= 3)
						{
							int num3 = method_1();
							if (num3 != 0 && int_5 - num3 <= 32506 && method_4(num3) && int_3 <= 5 && int_3 == 3 && int_5 - int_2 > int_0)
							{
								int_3 = 2;
							}
						}
						if (num2 >= 3 && int_3 <= num2)
						{
							class5_0.method_9(int_5 - 1 - num, num2);
							num2 -= 2;
							do
							{
								int_5++;
								int_6--;
								if (int_6 >= 3)
								{
									method_1();
								}
							}
							while (--num2 > 0);
							int_5++;
							int_6--;
							bool_0 = false;
							int_3 = 2;
						}
						else
						{
							if (bool_0)
							{
								class5_0.method_8(byte_0[int_5 - 1] & 0xFF);
							}
							bool_0 = true;
							int_5++;
							int_6--;
						}
						continue;
					}
					if (bool_0)
					{
						class5_0.method_8(byte_0[int_5 - 1] & 0xFF);
					}
					bool_0 = false;
					class5_0.method_6(byte_0, int_4, int_5 - int_4, bool_2);
					int_4 = int_5;
					return false;
				}
				return true;
			}
			while (!class5_0.method_7());
			int num4 = int_5 - int_4;
			if (bool_0)
			{
				num4--;
			}
			bool flag = bool_2 && int_6 == 0 && !bool_0;
			class5_0.method_6(byte_0, int_4, num4, flag);
			int_4 += num4;
			return !flag;
		}

		public bool method_6(bool bool_1, bool bool_2)
		{
			bool flag;
			do
			{
				method_3();
				bool bool_3 = bool_1 && int_8 == int_9;
				flag = method_5(bool_3, bool_2);
			}
			while (class8_0.method_5() && flag);
			return flag;
		}

		public void method_7(byte[] byte_2)
		{
			byte_1 = byte_2;
			int_8 = 0;
			int_9 = byte_2.Length;
		}

		public bool method_8()
		{
			return int_9 == int_8;
		}
	}

	[GAttribute0(25)]
	internal class Class8
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

	[GAttribute0(26)]
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
	}

	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0)
	{
		try
		{
			Stream0 stream = new Stream0();
			Class4 @class = new Class4();
			DateTime now = DateTime.Now;
			long num = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
			uint[] array = new uint[256]
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
			uint num2 = uint.MaxValue;
			uint num3 = uint.MaxValue;
			int num4 = 0;
			int num5 = byte_0.Length;
			while (--num5 >= 0)
			{
				num3 = array[(num3 ^ byte_0[num4++]) & 0xFF] ^ (num3 >> 8);
			}
			num3 ^= num2;
			stream.method_1(67324752);
			stream.method_0(20);
			stream.method_0(0);
			stream.method_0(8);
			stream.method_1((int)num);
			stream.method_1((int)num3);
			long position = stream.Position;
			stream.method_1(0);
			stream.method_1(byte_0.Length);
			byte[] bytes = Encoding.ASCII.GetBytes("摻瑡絡");
			stream.method_0(bytes.Length);
			stream.method_0(0);
			stream.Write(bytes, 0, bytes.Length);
			@class.method_4(byte_0);
			while (!@class.method_3())
			{
				byte[] array2 = new byte[512];
				int num6 = @class.method_5(array2);
				if (num6 <= 0)
				{
					break;
				}
				stream.Write(array2, 0, num6);
			}
			@class.method_1();
			while (!@class.method_2())
			{
				byte[] array3 = new byte[512];
				int num7 = @class.method_5(array3);
				if (num7 <= 0)
				{
					break;
				}
				stream.Write(array3, 0, num7);
			}
			long num8 = @class.method_0();
			stream.method_1(33639248);
			stream.method_0(20);
			stream.method_0(20);
			stream.method_0(0);
			stream.method_0(8);
			stream.method_1((int)num);
			stream.method_1((int)num3);
			stream.method_1((int)num8);
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
			stream.method_1((int)(30 + bytes.Length + num8));
			stream.method_0(0);
			stream.Seek(position, SeekOrigin.Begin);
			stream.method_1((int)num8);
			stream.Flush();
			stream.Close();
			return stream.GetBuffer();
		}
		catch (Exception ex)
		{
			string_0 = "剅⁒〲㌰›" + ex.Message;
			return null;
		}
	}
}
