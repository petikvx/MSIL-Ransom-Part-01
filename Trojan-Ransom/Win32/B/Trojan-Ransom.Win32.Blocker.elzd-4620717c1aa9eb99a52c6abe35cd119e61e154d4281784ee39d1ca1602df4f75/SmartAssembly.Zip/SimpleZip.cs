using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public class SimpleZip
{
	internal sealed class Class7
	{
		private Class11 class11_0;

		private Class10 class10_0;

		internal int int_0 = 16;

		internal long long_0 = 0L;

		public long TotalOut
		{
			get
			{
				try
				{
					return long_0;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public bool IsFinished
		{
			get
			{
				try
				{
					if (int_0 == 30)
					{
						return class11_0.IsFlushed;
					}
					return false;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public bool IsNeedingInput
		{
			get
			{
				try
				{
					return class10_0.method_8();
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public Class7()
		{
			try
			{
				class11_0 = new Class11();
				class10_0 = new Class10(class11_0);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}

		public void method_0()
		{
			try
			{
				int_0 |= 12;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}

		public void method_1(byte[] byte_0)
		{
			try
			{
				class10_0.method_7(byte_0);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, byte_0);
				throw;
			}
		}

		public int method_2(byte[] byte_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				num = 0;
				num2 = byte_0.Length;
				num3 = num2;
				while (true)
				{
					num4 = class11_0.method_4(byte_0, num, num2);
					num += num4;
					long_0 += num4;
					num2 -= num4;
					if (num2 == 0 || int_0 == 30)
					{
						break;
					}
					if (class10_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
					{
						continue;
					}
					if (int_0 != 16)
					{
						if (int_0 == 20)
						{
							for (num5 = 8 + (-class11_0.BitCount & 7); num5 > 0; num5 -= 10)
							{
								class11_0.method_3(2, 10);
							}
							int_0 = 16;
						}
						else if (int_0 == 28)
						{
							class11_0.method_2();
							int_0 = 30;
						}
						continue;
					}
					return num3 - num2;
				}
				return num3 - num2;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException7(exception_, num, num2, num3, num4, num5, this, byte_0);
				throw;
			}
		}
	}

	internal sealed class Class8
	{
		public sealed class Class9
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private Class8 class8_0;

			internal int[] int_2;

			internal int int_3;

			public Class9(Class8 class8_1, int int_4, int int_5, int int_6)
			{
				try
				{
					class8_0 = class8_1;
					int_0 = int_5;
					int num = (int_3 = int_6);
					short_0 = new short[int_4];
					int[] array = (int_2 = new int[int_6]);
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException5(exception_, this, class8_1, int_4, int_5, int_6);
					throw;
				}
			}

			public void method_0(int int_4)
			{
				try
				{
					class8_0.class11_0.method_3(short_1[int_4] & 0xFFFF, byte_0[int_4]);
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException2(exception_, this, int_4);
					throw;
				}
			}

			public void method_1(short[] short_2, byte[] byte_1)
			{
				try
				{
					short_1 = short_2;
					byte_0 = byte_1;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException3(exception_, this, short_2, byte_1);
					throw;
				}
			}

			public void method_2()
			{
				int[] array = default(int[]);
				int num = default(int);
				int i = default(int);
				int j = default(int);
				int num2 = default(int);
				int[] array2 = default(int[]);
				nint num4 = default(nint);
				try
				{
					array = new int[int_3];
					num = 0;
					short_1 = new short[short_0.Length];
					for (i = 0; i < int_3; i++)
					{
						array[i] = num;
						num += int_2[i] << 15 - i;
					}
					for (j = 0; j < int_1; j++)
					{
						num2 = byte_0[j];
						if (num2 > 0)
						{
							short_1[j] = smethod_0(array[num2 - 1]);
							int[] array3 = (array2 = array);
							int num3 = num2 - 1;
							num4 = num3;
							array3[num3] = array2[num4] + (1 << 16 - num2);
						}
					}
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException8(exception_, array, num, i, j, num2, array2, num4, this);
					throw;
				}
			}

			private void method_3(int[] int_4)
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
				int[] array2 = default(int[]);
				nint num9 = default(nint);
				int num10 = default(int);
				int num15 = default(int);
				int num16 = default(int);
				int num17 = default(int);
				int num18 = default(int);
				try
				{
					byte_0 = new byte[short_0.Length];
					num = int_4.Length / 2;
					num2 = (num + 1) / 2;
					num3 = 0;
					for (i = 0; i < int_3; i++)
					{
						int_2[i] = 0;
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
							int[] array3 = (array2 = int_2);
							int num8 = num7 - 1;
							num9 = num8;
							array3[num8] = array2[num9] + 1;
							byte_0[int_4[2 * num4]] = (byte)array[num4];
						}
					}
					if (num3 == 0)
					{
						return;
					}
					num10 = int_3 - 1;
					while (true)
					{
						if (int_2[--num10] != 0)
						{
							do
							{
								int[] array4 = (array2 = int_2);
								int num11 = num10;
								num9 = num11;
								array4[num11] = array2[num9] - 1;
								int[] array5 = (array2 = int_2);
								int num12 = ++num10;
								num9 = num12;
								array5[num12] = array2[num9] + 1;
								num3 -= 1 << int_3 - 1 - num10;
							}
							while (num3 > 0 && num10 < int_3 - 1);
							if (num3 <= 0)
							{
								break;
							}
						}
					}
					int[] array6 = (array2 = int_2);
					int num13 = int_3 - 1;
					num9 = num13;
					array6[num13] = array2[num9] + num3;
					int[] array7 = (array2 = int_2);
					int num14 = int_3 - 2;
					num9 = num14;
					array7[num14] = array2[num9] - num3;
					num15 = 2 * num2;
					for (num16 = int_3; num16 != 0; num16--)
					{
						num17 = int_2[num16 - 1];
						while (num17 > 0)
						{
							num18 = 2 * int_4[num15++];
							if (int_4[num18 + 1] == -1)
							{
								byte_0[int_4[num18]] = (byte)num16;
								num17--;
							}
						}
					}
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateExceptionN(exception_, new object[18]
					{
						num, num2, num3, i, array, num4, num5, num7, num10, num15,
						num16, num17, num18, num6, array2, num9, this, int_4
					});
					throw;
				}
			}

			public void method_4()
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
					int_1 = Math.Max(num3 + 1, int_0);
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
					method_3(array2);
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateExceptionN(exception_, new object[23]
					{
						num, array, num2, num3, i, num4, num5, num6, num7, num8,
						array2, array3, num9, j, num10, num11, num12, num13, num14, num15,
						num16, num17, this
					});
					throw;
				}
			}

			public int method_5()
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
					StackFrameHelper.CreateException3(exception_, num, i, this);
					throw;
				}
			}

			public void method_6(Class9 class9_0)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				short[] array = default(short[]);
				nint num8 = default(nint);
				try
				{
					num = -1;
					num2 = 0;
					while (num2 < int_1)
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
								short[] array2 = (array = class9_0.short_0);
								int num7 = num4;
								num8 = num7;
								array2[num7] = (short)(array[num8] + 1);
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
							short[] array3 = (array = class9_0.short_0);
							int num9 = num;
							num8 = num9;
							array3[num9] = (short)(array[num8] + (short)num3);
						}
						else if (num != 0)
						{
							(array = class9_0.short_0)[16] = (short)(array[16] + 1);
						}
						else if (num3 <= 10)
						{
							(array = class9_0.short_0)[17] = (short)(array[17] + 1);
						}
						else
						{
							(array = class9_0.short_0)[18] = (short)(array[18] + 1);
						}
					}
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException10(exception_, num5, num6, num3, num, num2, num4, array, num8, this, class9_0);
					throw;
				}
			}

			public void method_7(Class9 class9_0)
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
					while (num2 < int_1)
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
								class9_0.method_0(num4);
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
								class9_0.method_0(num);
							}
						}
						else if (num != 0)
						{
							class9_0.method_0(16);
							class8_0.class11_0.method_3(num3 - 3, 2);
						}
						else if (num3 <= 10)
						{
							class9_0.method_0(17);
							class8_0.class11_0.method_3(num3 - 3, 3);
						}
						else
						{
							class9_0.method_0(18);
							class8_0.class11_0.method_3(num3 - 11, 7);
						}
					}
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException8(exception_, num5, num6, num3, num, num2, num4, this, class9_0);
					throw;
				}
			}
		}

		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private Class11 class11_0;

		private Class9 class9_0;

		private Class9 class9_1;

		private Class9 class9_2;

		private int int_1;

		private static readonly short[] short_0;

		private static readonly byte[] byte_1;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		internal short[] short_2;

		internal byte[] byte_3;

		internal int int_2;

		public static short smethod_0(int int_3)
		{
			try
			{
				return (short)((byte_0[int_3 & 0xF] << 12) | (byte_0[(int_3 >> 4) & 0xF] << 8) | (byte_0[(int_3 >> 8) & 0xF] << 4) | byte_0[int_3 >> 12]);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, int_3);
				throw;
			}
		}

		static Class8()
		{
			int i = default(int);
			try
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
				i = 0;
				while (i < 144)
				{
					short_0[i] = smethod_0(48 + i << 8);
					byte_1[i++] = 8;
				}
				while (i < 256)
				{
					short_0[i] = smethod_0(256 + i << 7);
					byte_1[i++] = 9;
				}
				while (i < 280)
				{
					short_0[i] = smethod_0(-256 + i << 9);
					byte_1[i++] = 7;
				}
				while (i < 286)
				{
					short_0[i] = smethod_0(-88 + i << 8);
					byte_1[i++] = 8;
				}
				short_1 = new short[30];
				byte_2 = new byte[30];
				for (i = 0; i < 30; i++)
				{
					short_1[i] = smethod_0(i << 11);
					byte_2[i] = 5;
				}
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, i);
				throw;
			}
		}

		public Class8(Class11 class11_1)
		{
			try
			{
				class11_0 = class11_1;
				class9_0 = new Class9(this, 286, 257, 15);
				class9_1 = new Class9(this, 30, 1, 15);
				class9_2 = new Class9(this, 19, 4, 7);
				short[] array = (short_2 = new short[16384]);
				byte[] array2 = (byte_3 = new byte[16384]);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, class11_1);
				throw;
			}
		}

		public void method_0()
		{
			try
			{
				int_2 = 0;
				int_1 = 0;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}

		private int method_1(int int_3)
		{
			int num = default(int);
			try
			{
				if (int_3 == 255)
				{
					return 285;
				}
				num = 257;
				while (int_3 >= 8)
				{
					num += 4;
					int_3 >>= 1;
				}
				return num + int_3;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, num, this, int_3);
				throw;
			}
		}

		private int method_2(int int_3)
		{
			int num = default(int);
			try
			{
				num = 0;
				while (int_3 >= 4)
				{
					num += 2;
					int_3 >>= 1;
				}
				return num + int_3;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, num, this, int_3);
				throw;
			}
		}

		public void method_3(int int_3)
		{
			int i = default(int);
			try
			{
				class9_2.method_2();
				class9_0.method_2();
				class9_1.method_2();
				class11_0.method_3(class9_0.int_1 - 257, 5);
				class11_0.method_3(class9_1.int_1 - 1, 5);
				class11_0.method_3(int_3 - 4, 4);
				for (i = 0; i < int_3; i++)
				{
					class11_0.method_3(class9_2.byte_0[int_0[i]], 3);
				}
				class9_0.method_7(class9_2);
				class9_1.method_7(class9_2);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, i, this, int_3);
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
				for (i = 0; i < int_2; i++)
				{
					num = byte_3[i] & 0xFF;
					num2 = short_2[i];
					if (num2-- != 0)
					{
						num3 = method_1(num);
						class9_0.method_0(num3);
						num4 = (num3 - 261) / 4;
						if (num4 > 0 && num4 <= 5)
						{
							class11_0.method_3(num & ((1 << num4) - 1), num4);
						}
						num5 = method_2(num2);
						class9_1.method_0(num5);
						num4 = num5 / 2 - 1;
						if (num4 > 0)
						{
							class11_0.method_3(num2 & ((1 << num4) - 1), num4);
						}
					}
					else
					{
						class9_0.method_0(num);
					}
				}
				class9_0.method_0(256);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException7(exception_, i, num, num2, num3, num4, num5, this);
				throw;
			}
		}

		public void method_5(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			try
			{
				class11_0.method_3(bool_0 ? 1 : 0, 3);
				class11_0.method_2();
				class11_0.method_0(int_4);
				class11_0.method_0(~int_4);
				class11_0.method_1(byte_4, int_3, int_4);
				method_0();
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, this, byte_4, int_3, int_4, bool_0);
				throw;
			}
		}

		public void method_6(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			short[] array = default(short[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int i = default(int);
			int j = default(int);
			try
			{
				(array = class9_0.short_0)[256] = (short)(array[256] + 1);
				class9_0.method_4();
				class9_1.method_4();
				class9_0.method_6(class9_2);
				class9_1.method_6(class9_2);
				class9_2.method_4();
				num = 4;
				for (num2 = 18; num2 > num; num2--)
				{
					if (class9_2.byte_0[int_0[num2]] > 0)
					{
						num = num2 + 1;
					}
				}
				num3 = 14 + num * 3 + class9_2.method_5() + class9_0.method_5() + class9_1.method_5() + int_1;
				num4 = int_1;
				for (i = 0; i < 286; i++)
				{
					num4 += class9_0.short_0[i] * byte_1[i];
				}
				for (j = 0; j < 30; j++)
				{
					num4 += class9_1.short_0[j] * byte_2[j];
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
					class11_0.method_3(2 + (bool_0 ? 1 : 0), 3);
					class9_0.method_1(short_0, byte_1);
					class9_1.method_1(short_1, byte_2);
					method_4();
					method_0();
				}
				else
				{
					class11_0.method_3(4 + (bool_0 ? 1 : 0), 3);
					method_3(num);
					method_4();
					method_0();
				}
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateExceptionN(exception_, new object[12]
				{
					num, num2, num3, num4, i, j, array, this, byte_4, int_3,
					int_4, bool_0
				});
				throw;
			}
		}

		public bool method_7()
		{
			try
			{
				return int_2 >= 16384;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}

		public bool method_8(int int_3)
		{
			int num = default(int);
			short[] array2 = default(short[]);
			nint num3 = default(nint);
			try
			{
				short_2[int_2] = 0;
				byte[] array = byte_3;
				int num2 = (int_2 = (num = int_2) + 1);
				array[num] = (byte)int_3;
				short[] array3 = (array2 = class9_0.short_0);
				num3 = int_3;
				array3[int_3] = (short)(array2[num3] + 1);
				return method_7();
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, num, array2, num3, this, int_3);
				throw;
			}
		}

		public bool method_9(int int_3, int int_4)
		{
			int num = default(int);
			int num3 = default(int);
			short[] array2 = default(short[]);
			nint num5 = default(nint);
			int num6 = default(int);
			try
			{
				short_2[int_2] = (short)int_3;
				byte[] array = byte_3;
				int num2 = (int_2 = (num = int_2) + 1);
				array[num] = (byte)(int_4 - 3);
				num3 = method_1(int_4 - 3);
				short[] array3 = (array2 = class9_0.short_0);
				int num4 = num3;
				num5 = num4;
				array3[num4] = (short)(array2[num5] + 1);
				if (num3 >= 265 && num3 < 285)
				{
					int_1 += (num3 - 261) / 4;
				}
				num6 = method_2(int_3 - 1);
				short[] array4 = (array2 = class9_1.short_0);
				int num7 = num6;
				num5 = num7;
				array4[num7] = (short)(array2[num5] + 1);
				if (num6 >= 4)
				{
					int_1 += num6 / 2 - 1;
				}
				return method_7();
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException8(exception_, num3, num6, num, array2, num5, this, int_3, int_4);
				throw;
			}
		}
	}

	internal sealed class Class10
	{
		private short[] short_0;

		private int int_0;

		private bool bool_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private byte[] byte_0;

		private int int_4;

		private int int_5;

		private Class11 class11_0;

		private Class8 class8_0;

		internal int int_6;

		internal short[] short_1;

		internal int int_7;

		internal byte[] byte_1;

		internal int int_8;

		public Class10(Class11 class11_1)
		{
			int num = default(int);
			try
			{
				class11_0 = class11_1;
				class8_0 = new Class8(class11_1);
				byte[] array = (byte_1 = new byte[65536]);
				short[] array2 = (short_1 = new short[32768]);
				short_0 = new short[32768];
				num = 1;
				int_2 = 1;
				int_1 = 1;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, num, this, class11_1);
				throw;
			}
		}

		private void method_0()
		{
			try
			{
				int num = (int_6 = (byte_1[int_2] << 5) ^ byte_1[int_2 + 1]);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}

		private int method_1()
		{
			int num = default(int);
			short num2 = default(short);
			try
			{
				num = ((int_6 << 5) ^ byte_1[int_2 + 2]) & 0x7FFF;
				num2 = (short_0[int_2 & 0x7FFF] = short_1[num]);
				short_1[num] = (short)int_2;
				int num3 = (int_6 = num);
				return num2 & 0xFFFF;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, num2, num, this);
				throw;
			}
		}

		private void method_2()
		{
			int i = default(int);
			int num = default(int);
			int j = default(int);
			int num2 = default(int);
			try
			{
				Array.Copy(byte_1, 32768, byte_1, 0, 32768);
				int_0 -= 32768;
				int_2 -= 32768;
				int_1 -= 32768;
				for (i = 0; i < 32768; i++)
				{
					num = short_1[i] & 0xFFFF;
					short_1[i] = (short)((num >= 32768) ? (num - 32768) : 0);
				}
				for (j = 0; j < 32768; j++)
				{
					num2 = short_0[j] & 0xFFFF;
					short_0[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
				}
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, i, num, j, num2, this);
				throw;
			}
		}

		public void method_3()
		{
			int num = default(int);
			try
			{
				if (int_2 >= 65274)
				{
					method_2();
				}
				while (int_3 < 262 && int_5 < int_8)
				{
					num = 65536 - int_3 - int_2;
					if (num > int_8 - int_5)
					{
						num = int_8 - int_5;
					}
					Array.Copy(byte_0, int_5, byte_1, int_2 + int_3, num);
					int_5 += num;
					int_4 += num;
					int_3 += num;
				}
				if (int_3 >= 3)
				{
					method_0();
				}
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, num, this);
				throw;
			}
		}

		private bool method_4(int int_9)
		{
			int num = default(int);
			int num2 = default(int);
			short[] array = default(short[]);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			byte b = default(byte);
			byte b2 = default(byte);
			int num8 = default(int);
			try
			{
				num = 128;
				num2 = 128;
				array = short_0;
				num3 = int_2;
				num4 = int_2 + int_7;
				num5 = Math.Max(int_7, 2);
				num6 = Math.Max(int_2 - 32506, 0);
				num7 = int_2 + 258 - 1;
				b = byte_1[num4 - 1];
				b2 = byte_1[num4];
				if (num5 >= 8)
				{
					num >>= 2;
				}
				if (num2 > int_3)
				{
					num2 = int_3;
				}
				do
				{
					if (byte_1[int_9 + num5] != b2 || byte_1[int_9 + num5 - 1] != b || byte_1[int_9] != byte_1[num3] || byte_1[int_9 + 1] != byte_1[num3 + 1])
					{
						continue;
					}
					num8 = int_9 + 2;
					num3 += 2;
					while (byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && byte_1[++num3] == byte_1[++num8] && num3 < num7)
					{
					}
					if (num3 > num4)
					{
						int_0 = int_9;
						num4 = num3;
						num5 = num3 - int_2;
						if (num5 >= num2)
						{
							break;
						}
						b = byte_1[num4 - 1];
						b2 = byte_1[num4];
					}
					num3 = int_2;
				}
				while ((int_9 = array[int_9 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
				int num9 = (int_7 = Math.Min(num5, int_3));
				return int_7 >= 3;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateExceptionN(exception_, new object[13]
				{
					num, num2, array, num3, num8, num4, num5, num6, num7, b,
					b2, this, int_9
				});
				throw;
			}
		}

		private bool method_5(bool bool_1, bool bool_2)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			bool flag = default(bool);
			try
			{
				if (int_3 < 262 && !bool_1)
				{
					return false;
				}
				do
				{
					if (int_3 >= 262 || bool_1)
					{
						if (int_3 != 0)
						{
							if (int_2 >= 65274)
							{
								method_2();
							}
							num = int_0;
							num2 = int_7;
							if (int_3 >= 3)
							{
								num3 = method_1();
								if (num3 != 0 && int_2 - num3 <= 32506 && method_4(num3) && int_7 <= 5 && int_7 == 3 && int_2 - int_0 > 4096)
								{
									int_7 = 2;
								}
							}
							if (num2 >= 3 && int_7 <= num2)
							{
								class8_0.method_9(int_2 - 1 - num, num2);
								num2 -= 2;
								do
								{
									int_2++;
									int_3--;
									if (int_3 >= 3)
									{
										method_1();
									}
								}
								while (--num2 > 0);
								int_2++;
								int_3--;
								bool_0 = false;
								int_7 = 2;
							}
							else
							{
								if (bool_0)
								{
									class8_0.method_8(byte_1[int_2 - 1] & 0xFF);
								}
								bool_0 = true;
								int_2++;
								int_3--;
							}
							continue;
						}
						if (bool_0)
						{
							class8_0.method_8(byte_1[int_2 - 1] & 0xFF);
						}
						bool_0 = false;
						class8_0.method_6(byte_1, int_1, int_2 - int_1, bool_2);
						int_1 = int_2;
						return false;
					}
					return true;
				}
				while (!class8_0.method_7());
				num4 = int_2 - int_1;
				if (bool_0)
				{
					num4--;
				}
				flag = bool_2 && int_3 == 0 && !bool_0;
				class8_0.method_6(byte_1, int_1, num4, flag);
				int_1 += num4;
				return !flag;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException8(exception_, num, num2, num3, num4, flag, this, bool_1, bool_2);
				throw;
			}
		}

		public bool method_6(bool bool_1, bool bool_2)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			try
			{
				do
				{
					method_3();
					flag = bool_1 && int_5 == int_8;
					flag2 = method_5(flag, bool_2);
				}
				while (class11_0.IsFlushed && flag2);
				return flag2;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, flag2, flag, this, bool_1, bool_2);
				throw;
			}
		}

		public void method_7(byte[] byte_2)
		{
			try
			{
				byte_0 = byte_2;
				int_5 = 0;
				int num = (int_8 = byte_2.Length);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, byte_2);
				throw;
			}
		}

		public bool method_8()
		{
			try
			{
				return int_8 == int_5;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}
	}

	internal sealed class Class11
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0 = 0;

		private int int_1 = 0;

		internal int int_2 = 0;

		internal uint uint_0 = 0u;

		public int BitCount
		{
			get
			{
				try
				{
					return int_1;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public bool IsFlushed
		{
			get
			{
				try
				{
					return int_2 == 0;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public void method_0(int int_3)
		{
			int num = default(int);
			try
			{
				byte[] array = byte_0;
				int num2 = (int_2 = (num = int_2) + 1);
				array[num] = (byte)int_3;
				byte[] array2 = byte_0;
				int num3 = (int_2 = (num = int_2) + 1);
				array2[num] = (byte)(int_3 >> 8);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, num, this, int_3);
				throw;
			}
		}

		public void method_1(byte[] byte_1, int int_3, int int_4)
		{
			try
			{
				Array.Copy(byte_1, int_3, byte_0, int_2, int_4);
				int_2 += int_4;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException4(exception_, this, byte_1, int_3, int_4);
				throw;
			}
		}

		public void method_2()
		{
			int num = default(int);
			try
			{
				if (int_1 > 0)
				{
					byte[] array = byte_0;
					int num2 = (int_2 = (num = int_2) + 1);
					array[num] = (byte)uint_0;
					if (int_1 > 8)
					{
						byte[] array2 = byte_0;
						int num3 = (int_2 = (num = int_2) + 1);
						array2[num] = (byte)(uint_0 >> 8);
					}
				}
				uint_0 = 0u;
				int_1 = 0;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, num, this);
				throw;
			}
		}

		public void method_3(int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				uint_0 |= (uint)(int_3 << int_1);
				int_1 += int_4;
				if (int_1 >= 16)
				{
					byte[] array = byte_0;
					int num2 = (int_2 = (num = int_2) + 1);
					array[num] = (byte)uint_0;
					byte[] array2 = byte_0;
					int num3 = (int_2 = (num = int_2) + 1);
					array2[num] = (byte)(uint_0 >> 8);
					uint_0 >>= 16;
					int_1 -= 16;
				}
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException4(exception_, num, this, int_3, int_4);
				throw;
			}
		}

		public int method_4(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				if (int_1 >= 8)
				{
					byte[] array = byte_0;
					int num2 = (int_2 = (num = int_2) + 1);
					array[num] = (byte)uint_0;
					uint_0 >>= 8;
					int_1 -= 8;
				}
				if (int_4 > int_2 - int_0)
				{
					int_4 = int_2 - int_0;
					Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
					int_0 = 0;
					int_2 = 0;
				}
				else
				{
					Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
					int_0 += int_4;
				}
				return int_4;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, num, this, byte_1, int_3, int_4);
				throw;
			}
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public void method_0(int int_0)
		{
			try
			{
				WriteByte((byte)((uint)int_0 & 0xFFu));
				WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, int_0);
				throw;
			}
		}

		public void method_1(int int_0)
		{
			try
			{
				method_0(int_0);
				method_0(int_0 >> 16);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, int_0);
				throw;
			}
		}
	}

	public static string ExceptionMessage;

	public static byte[] Zip(byte[] byte_0)
	{
		try
		{
			return smethod_0(byte_0, 1, null, null);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, byte_0);
			throw;
		}
	}

	private static byte[] smethod_0(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		Stream0 stream = default(Stream0);
		Class7 class2 = default(Class7);
		DateTime now = default(DateTime);
		long num3 = default(long);
		uint[] array8 = default(uint[]);
		uint num4 = default(uint);
		uint num5 = default(uint);
		int num6 = default(int);
		int num7 = default(int);
		long position3 = default(long);
		byte[] bytes = default(byte[]);
		byte[] array9 = default(byte[]);
		int num8 = default(int);
		byte[] array10 = default(byte[]);
		int num9 = default(int);
		long totalOut = default(long);
		int i = default(int);
		byte[] array5 = default(byte[]);
		long position = default(long);
		Class7 @class = default(Class7);
		byte[] array6 = default(byte[]);
		int num = default(int);
		byte[] array7 = default(byte[]);
		int num2 = default(int);
		long position2 = default(long);
		byte[] array3 = default(byte[]);
		DESCryptoIndirector dESCryptoIndirector = default(DESCryptoIndirector);
		ICryptoTransform dESCryptoTransform = default(ICryptoTransform);
		byte[] array4 = default(byte[]);
		byte[] array = default(byte[]);
		AESCryptoIndirector aESCryptoIndirector = default(AESCryptoIndirector);
		ICryptoTransform aESCryptoTransform = default(ICryptoTransform);
		byte[] array2 = default(byte[]);
		byte[] array11 = default(byte[]);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				stream = new Stream0();
				switch (int_0)
				{
				case 0:
					class2 = new Class7();
					now = DateTime.Now;
					num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
					array8 = new uint[256]
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
					num4 = uint.MaxValue;
					num5 = uint.MaxValue;
					num6 = 0;
					num7 = byte_0.Length;
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
					position3 = stream.Position;
					stream.method_1(0);
					stream.method_1(byte_0.Length);
					bytes = Encoding.UTF8.GetBytes("{data}");
					stream.method_0(bytes.Length);
					stream.method_0(0);
					stream.Write(bytes, 0, bytes.Length);
					class2.method_1(byte_0);
					while (!class2.IsNeedingInput)
					{
						array9 = new byte[512];
						num8 = class2.method_2(array9);
						if (num8 <= 0)
						{
							break;
						}
						stream.Write(array9, 0, num8);
					}
					class2.method_0();
					while (!class2.IsFinished)
					{
						array10 = new byte[512];
						num9 = class2.method_2(array10);
						if (num9 <= 0)
						{
							break;
						}
						stream.Write(array10, 0, num9);
					}
					totalOut = class2.TotalOut;
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
				case 1:
					stream.method_1(25000571);
					stream.method_1(byte_0.Length);
					for (i = 0; i < byte_0.Length; i += array5.Length)
					{
						array5 = new byte[Math.Min(2097151, byte_0.Length - i)];
						Buffer.BlockCopy(byte_0, i, array5, 0, array5.Length);
						position = stream.Position;
						stream.method_1(0);
						stream.method_1(array5.Length);
						@class = new Class7();
						@class.method_1(array5);
						while (!@class.IsNeedingInput)
						{
							array6 = new byte[512];
							num = @class.method_2(array6);
							if (num <= 0)
							{
								break;
							}
							stream.Write(array6, 0, num);
						}
						@class.method_0();
						while (!@class.IsFinished)
						{
							array7 = new byte[512];
							num2 = @class.method_2(array7);
							if (num2 <= 0)
							{
								break;
							}
							stream.Write(array7, 0, num2);
						}
						position2 = stream.Position;
						stream.Position = position;
						stream.method_1((int)@class.TotalOut);
						stream.Position = position2;
					}
					break;
				case 2:
					stream.method_1(41777787);
					array3 = smethod_0(byte_0, 1, null, null);
					dESCryptoIndirector = new DESCryptoIndirector();
					try
					{
						dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(byte_1, byte_2, bool_0: false);
						try
						{
							array4 = dESCryptoTransform.TransformFinalBlock(array3, 0, array3.Length);
							stream.Write(array4, 0, array4.Length);
						}
						finally
						{
							dESCryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)dESCryptoIndirector)?.Dispose();
					}
					break;
				case 3:
					stream.method_1(58555003);
					array = smethod_0(byte_0, 1, null, null);
					aESCryptoIndirector = new AESCryptoIndirector();
					try
					{
						aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(byte_1, byte_2, bool_0: false);
						try
						{
							array2 = aESCryptoTransform.TransformFinalBlock(array, 0, array.Length);
							stream.Write(array2, 0, array2.Length);
						}
						finally
						{
							aESCryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)aESCryptoIndirector)?.Dispose();
					}
					break;
				}
				stream.Flush();
				stream.Close();
				array11 = stream.ToArray();
				return array11;
			}
			catch (Exception ex)
			{
				ex2 = ex;
				ExceptionMessage = "ERR 2003: " + ex2.Message;
				throw;
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[39]
			{
				stream, class2, now, num3, array8, num4, num5, num6, num7, position3,
				bytes, array9, num8, array10, num9, totalOut, i, array5, position, @class,
				array6, num, array7, num2, position2, array3, dESCryptoIndirector, dESCryptoTransform, array4, array,
				aESCryptoIndirector, aESCryptoTransform, array2, ex2, array11, byte_0, int_0, byte_1, byte_2
			});
			throw;
		}
	}
}
