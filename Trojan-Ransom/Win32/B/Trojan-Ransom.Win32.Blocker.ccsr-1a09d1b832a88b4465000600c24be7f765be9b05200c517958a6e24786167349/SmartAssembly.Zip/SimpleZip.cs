using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Zip;

public class SimpleZip
{
	internal sealed class Class3
	{
		private static readonly int[] int_0;

		private static readonly int[] int_1;

		private static readonly int[] int_2;

		private static readonly int[] int_3;

		private Class4 class4_0;

		private Class5 class5_0;

		private Class7 class7_0;

		private Class6 class6_0;

		private Class6 class6_1;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		public Class3(byte[] byte_0)
		{
			try
			{
				class4_0 = new Class4();
				class5_0 = new Class5();
				int_4 = 2;
				class4_0.method_7(byte_0, 0, byte_0.Length);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, byte_0);
				throw;
			}
		}

		private bool method_0()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num9 = default(int);
			int num6 = default(int);
			try
			{
				num = class5_0.method_4();
				while (num >= 258)
				{
					num2 = int_4;
					switch (num2)
					{
					case 7:
					{
						while (((num3 = class6_0.method_1(class4_0)) & -256) == 0)
						{
							class5_0.method_0(num3);
							if (--num < 258)
							{
								return true;
							}
						}
						if (num3 < 257)
						{
							if (num3 < 0)
							{
								return false;
							}
							class6_1 = null;
							class6_0 = null;
							int_4 = 2;
							return true;
						}
						int num4 = (int_6 = int_0[num3 - 257]);
						int num5 = (int_5 = int_1[num3 - 257]);
						goto case 8;
					}
					case 8:
						if (int_5 > 0)
						{
							int_4 = 8;
							num9 = class4_0.method_0(int_5);
							if (num9 < 0)
							{
								return false;
							}
							class4_0.method_1(int_5);
							int_6 += num9;
						}
						int_4 = 9;
						goto case 9;
					case 9:
					{
						num3 = class6_1.method_1(class4_0);
						if (num3 < 0)
						{
							return false;
						}
						int num7 = (int_7 = int_2[num3]);
						int num8 = (int_5 = int_3[num3]);
						goto case 10;
					}
					case 10:
						if (int_5 > 0)
						{
							int_4 = 10;
							num6 = class4_0.method_0(int_5);
							if (num6 < 0)
							{
								return false;
							}
							class4_0.method_1(int_5);
							int_7 += num6;
						}
						class5_0.method_2(int_6, int_7);
						num -= int_6;
						int_4 = 7;
						break;
					}
				}
				return true;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, num3, num9, num6, num2, this);
				throw;
			}
		}

		private bool method_1()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			try
			{
				num = int_4;
				switch (num)
				{
				case 2:
					if (bool_0)
					{
						int_4 = 12;
						return false;
					}
					num2 = class4_0.method_0(3);
					if (num2 < 0)
					{
						return false;
					}
					class4_0.method_1(3);
					if (((uint)num2 & (true ? 1u : 0u)) != 0)
					{
						bool_0 = true;
					}
					num = num2 >> 1;
					switch (num)
					{
					case 0:
						class4_0.method_4();
						int_4 = 3;
						break;
					case 1:
						class6_0 = Class6.class6_0;
						class6_1 = Class6.class6_1;
						int_4 = 7;
						break;
					case 2:
						class7_0 = new Class7();
						int_4 = 6;
						break;
					}
					return true;
				case 3:
				{
					int num4 = (int_8 = (num = class4_0.method_0(16)));
					if (num < 0)
					{
						return false;
					}
					class4_0.method_1(16);
					int_4 = 4;
					goto case 4;
				}
				case 4:
					num3 = class4_0.method_0(16);
					if (num3 < 0)
					{
						return false;
					}
					class4_0.method_1(16);
					int_4 = 5;
					goto case 5;
				case 5:
					num5 = class5_0.method_3(class4_0, int_8);
					int_8 -= num5;
					if (int_8 == 0)
					{
						int_4 = 2;
						return true;
					}
					return !class4_0.method_5();
				case 6:
					if (!class7_0.method_0(class4_0))
					{
						return false;
					}
					class6_0 = class7_0.method_1();
					class6_1 = class7_0.method_2();
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num2, num3, num5, num, this);
				throw;
			}
		}

		public int method_2(byte[] byte_0, int int_9, int int_10)
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				num = 0;
				do
				{
					if (int_4 != 11)
					{
						num2 = class5_0.method_6(byte_0, int_9, int_10);
						int_9 += num2;
						num += num2;
						int_10 -= num2;
						if (int_10 == 0)
						{
							return num;
						}
					}
				}
				while (method_1() || (class5_0.method_5() > 0 && int_4 != 11));
				return num;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, num2, this, byte_0, int_9, int_10);
				throw;
			}
		}

		static Class3()
		{
			DESCryptoIndirector.smethod_0();
			try
			{
				int[] array_ = new int[29];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 789, 874);
				int_0 = array_;
				int[] array_2 = new int[29];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 589, 562);
				int_1 = array_2;
				int[] array_3 = new int[30];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 818, 845);
				int_2 = array_3;
				int_3 = new int[30]
				{
					0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
					4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
					9, 9, 10, 10, 11, 11, 12, 12, 13, 13
				};
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	internal sealed class Class4
	{
		internal byte[] byte_0;

		internal int int_0 = 0;

		internal int int_1 = 0;

		internal uint uint_0 = 0u;

		internal int int_2 = 0;

		public int method_0(int int_3)
		{
			int num2 = default(int);
			try
			{
				if (int_2 < int_3)
				{
					if (int_0 == int_1)
					{
						return -1;
					}
					uint num = uint_0;
					byte[] array = byte_0;
					int num3 = (int_0 = (num2 = int_0) + 1);
					int num4 = array[num2] & 0xFF;
					byte[] array2 = byte_0;
					int num5 = (int_0 = (num2 = int_0) + 1);
					uint num6 = (uint_0 = num | (uint)((num4 | ((array2[num2] & 0xFF) << 8)) << int_2));
					int_2 += 16;
				}
				return (int)(uint_0 & ((1 << int_3) - 1));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num2, this, int_3);
				throw;
			}
		}

		public void method_1(int int_3)
		{
			try
			{
				uint_0 >>= int_3;
				int_2 -= int_3;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, int_3);
				throw;
			}
		}

		[SpecialName]
		public int method_2()
		{
			try
			{
				return int_2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public int method_3()
		{
			try
			{
				return int_1 - int_0 + (int_2 >> 3);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public void method_4()
		{
			try
			{
				uint_0 >>= int_2 & 7;
				int_2 &= -8;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_5()
		{
			try
			{
				return int_0 == int_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int method_6(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				num = 0;
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
				num2 = int_1 - int_0;
				if (int_4 > num2)
				{
					int_4 = num2;
				}
				SendingReportFeedbackEventArgs.smethod_0(byte_0, int_0, byte_1, int_3, int_4, 433, 408);
				int_0 += int_4;
				if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
				{
					byte[] array = byte_0;
					int num4 = (int_0 = (num3 = int_0) + 1);
					uint num5 = (uint_0 = array[num3] & 0xFFu);
					int_2 = 8;
				}
				return num + int_4;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, num2, num3, this, byte_1, int_3, int_4);
				throw;
			}
		}

		public void method_7(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				if (int_0 < int_1)
				{
					throw new InvalidOperationException();
				}
				num = int_3 + int_4;
				if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
				{
					if (((uint)int_4 & (true ? 1u : 0u)) != 0)
					{
						uint_0 |= (uint)((byte_1[int_3++] & 0xFF) << int_2);
						int_2 += 8;
					}
					byte[] array = (byte_0 = byte_1);
					int num2 = (int_0 = int_3);
					int num3 = (int_1 = num);
					return;
				}
				throw new ArgumentOutOfRangeException();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, this, byte_1, int_3, int_4);
				throw;
			}
		}

		static Class4()
		{
			DESCryptoIndirector.smethod_0();
		}

		internal static object smethod_0(RegistryKey registryKey_0, string string_0, object object_0, int int_3, int int_4)
		{
			while (true)
			{
				switch (int_4 ^ int_3)
				{
				case 65:
					return registryKey_0.GetValue(string_0, object_0);
				}
			}
		}
	}

	internal sealed class Class5
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0 = 0;

		internal int int_1 = 0;

		public void method_0(int int_2)
		{
			int num = default(int);
			try
			{
				int num2 = (int_1 = (num = int_1) + 1);
				if (num == 32768)
				{
					throw new InvalidOperationException();
				}
				byte[] array = byte_0;
				int num3 = (int_0 = (num = int_0) + 1);
				array[num] = (byte)int_2;
				int_0 &= 32767;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, int_2);
				throw;
			}
		}

		private void method_1(int int_2, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (int_3-- > 0)
				{
					byte[] array = byte_0;
					int num2 = (int_0 = (num = int_0) + 1);
					array[num] = byte_0[int_2++];
					int_0 &= 32767;
					int_2 &= 0x7FFF;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, this, int_2, int_3, int_4);
				throw;
			}
		}

		public void method_2(int int_2, int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				num = (int_1 += int_2);
				if (num > 32768)
				{
					throw new InvalidOperationException();
				}
				num2 = (int_0 - int_3) & 0x7FFF;
				num3 = 32768 - int_2;
				if (num2 <= num3 && int_0 < num3)
				{
					if (int_2 <= int_3)
					{
						SendingReportFeedbackEventArgs.smethod_0(byte_0, num2, byte_0, int_0, int_2, 23, 62);
						int_0 += int_2;
						return;
					}
					while (int_2-- > 0)
					{
						byte[] array = byte_0;
						int num4 = (int_0 = (num = int_0) + 1);
						array[num] = byte_0[num2++];
					}
				}
				else
				{
					method_1(num2, int_2, int_3);
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num2, num3, num, this, int_2, int_3);
				throw;
			}
		}

		public int method_3(Class4 class4_0, int int_2)
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				int_2 = Class20.smethod_3(Class20.smethod_3(int_2, 32768 - int_1, 129, 157), class4_0.method_3(), 405, 393);
				num = 32768 - int_0;
				if (int_2 > num)
				{
					num2 = class4_0.method_6(byte_0, int_0, num);
					if (num2 == num)
					{
						num2 += class4_0.method_6(byte_0, 0, int_2 - num);
					}
				}
				else
				{
					num2 = class4_0.method_6(byte_0, int_0, int_2);
				}
				int num3 = (int_0 = (int_0 + num2) & 0x7FFF);
				int_1 += num2;
				return num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num2, num, this, class4_0, int_2);
				throw;
			}
		}

		public int method_4()
		{
			try
			{
				return 32768 - int_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int method_5()
		{
			try
			{
				return int_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int method_6(byte[] byte_1, int int_2, int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				num = int_0;
				if (int_3 > int_1)
				{
					int_3 = int_1;
				}
				else
				{
					num = (int_0 - int_1 + int_3) & 0x7FFF;
				}
				num2 = int_3;
				num3 = int_3 - num;
				if (num3 > 0)
				{
					SendingReportFeedbackEventArgs.smethod_0(byte_0, 32768 - num3, byte_1, int_2, num3, 243, 218);
					int_2 += num3;
					int_3 = num;
				}
				SendingReportFeedbackEventArgs.smethod_0(byte_0, num - int_3, byte_1, int_2, int_3, 280, 305);
				int_1 -= num2;
				if (int_1 < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, num2, num3, this, byte_1, int_2, int_3);
				throw;
			}
		}

		static Class5()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	internal sealed class Class6
	{
		public static readonly Class6 class6_0;

		public static readonly Class6 class6_1;

		internal short[] short_0;

		static Class6()
		{
			DESCryptoIndirector.smethod_0();
			byte[] array = default(byte[]);
			int num = default(int);
			try
			{
				array = new byte[288];
				num = 0;
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
				class6_0 = new Class6(array);
				array = new byte[32];
				num = 0;
				while (num < 32)
				{
					array[num++] = 5;
				}
				class6_1 = new Class6(array);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, array, num);
				throw;
			}
		}

		public Class6(byte[] byte_0)
		{
			try
			{
				method_0(byte_0);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, byte_0);
				throw;
			}
		}

		private void method_0(byte[] byte_0)
		{
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int i = default(int);
			int num = default(int);
			int[] array3 = default(int[]);
			nint num3 = default(nint);
			int num4 = default(int);
			int num5 = default(int);
			int j = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int k = default(int);
			int l = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			try
			{
				array = new int[16];
				array2 = new int[16];
				for (i = 0; i < byte_0.Length; i++)
				{
					num = byte_0[i];
					if (num > 0)
					{
						int[] array4 = (array3 = array);
						int num2 = num;
						num3 = num2;
						array4[num2] = array3[num3] + 1;
					}
				}
				num4 = 0;
				num5 = 512;
				for (j = 1; j <= 15; j++)
				{
					array2[j] = num4;
					num4 += array[j] << 16 - j;
					if (j >= 10)
					{
						num6 = array2[j] & 0x1FF80;
						num7 = num4 & 0x1FF80;
						num5 += num7 - num6 >> 16 - j;
					}
				}
				short[] array5 = (short_0 = new short[num5]);
				num8 = 512;
				for (num9 = 15; num9 >= 10; num9--)
				{
					num10 = num4 & 0x1FF80;
					num4 -= array[num9] << 16 - num9;
					num11 = num4 & 0x1FF80;
					for (k = num11; k < num10; k += 128)
					{
						short_0[Class9.smethod_0(k)] = (short)((-num8 << 4) | num9);
						num8 += 1 << num9 - 9;
					}
				}
				for (l = 0; l < byte_0.Length; l++)
				{
					num12 = byte_0[l];
					if (num12 == 0)
					{
						continue;
					}
					num4 = array2[num12];
					num13 = Class9.smethod_0(num4);
					if (num12 <= 9)
					{
						do
						{
							short_0[num13] = (short)((l << 4) | num12);
							num13 += 1 << num12;
						}
						while (num13 < 512);
					}
					else
					{
						num14 = short_0[num13 & 0x1FF];
						num15 = 1 << (num14 & 0xF);
						num14 = -(num14 >> 4);
						do
						{
							short_0[num14 | (num13 >> 9)] = (short)((l << 4) | num12);
							num13 += 1 << num12;
						}
						while (num13 < num15);
					}
					array2[num12] = num4 + (1 << 16 - num12);
				}
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[23]
				{
					array, array2, i, num, num4, num5, j, num6, num7, num8,
					num9, num10, num11, k, l, num12, num13, num14, num15, array3,
					num3, this, byte_0
				});
				throw;
			}
		}

		public int method_1(Class4 class4_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				if ((num = class4_0.method_0(9)) >= 0)
				{
					if ((num2 = short_0[num]) >= 0)
					{
						class4_0.method_1(num2 & 0xF);
						return num2 >> 4;
					}
					num3 = -(num2 >> 4);
					num4 = num2 & 0xF;
					if ((num = class4_0.method_0(num4)) >= 0)
					{
						num2 = short_0[num3 | (num >> 9)];
						class4_0.method_1(num2 & 0xF);
						return num2 >> 4;
					}
					num5 = class4_0.method_2();
					num = class4_0.method_0(num5);
					num2 = short_0[num3 | (num >> 9)];
					if ((num2 & 0xF) <= num5)
					{
						class4_0.method_1(num2 & 0xF);
						return num2 >> 4;
					}
					return -1;
				}
				num6 = class4_0.method_2();
				num = class4_0.method_0(num6);
				num2 = short_0[num];
				if (num2 >= 0 && (num2 & 0xF) <= num6)
				{
					class4_0.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num, num2, num3, num4, num5, num6, this, class4_0);
				throw;
			}
		}
	}

	internal sealed class Class7
	{
		private static readonly int[] int_0;

		private static readonly int[] int_1;

		private Class6 class6_0;

		private static readonly int[] int_2;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal byte byte_2;

		internal int int_9;

		public bool method_0(Class4 class4_0)
		{
			int num = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num9 = default(int);
			byte b = default(byte);
			int num13 = default(int);
			try
			{
				while (true)
				{
					num = int_3;
					switch (num)
					{
					case 5:
						num4 = int_1[int_8];
						num5 = class4_0.method_0(num4);
						if (num5 >= 0)
						{
							class4_0.method_1(num4);
							num5 += int_0[int_8];
							while (num5-- > 0)
							{
								byte[] array2 = byte_1;
								int num6 = (int_9 = (num = int_9) + 1);
								array2[num] = byte_2;
							}
							if (int_9 == int_7)
							{
								return true;
							}
							goto IL_00a1;
						}
						return false;
					case 4:
						while (((num9 = class6_0.method_1(class4_0)) & -16) == 0)
						{
							byte[] array4 = byte_1;
							int num10 = (int_9 = (num = int_9) + 1);
							int num11 = num;
							byte b2 = (byte_2 = (b = (byte)num9));
							array4[num11] = b;
							if (int_9 == int_7)
							{
								return true;
							}
						}
						if (num9 >= 0)
						{
							if (num9 >= 17)
							{
								byte_2 = 0;
							}
							int num12 = (int_8 = num9 - 16);
							int_3 = 5;
							goto case 5;
						}
						return false;
					case 3:
					{
						while (int_9 < int_6)
						{
							num13 = class4_0.method_0(3);
							if (num13 >= 0)
							{
								class4_0.method_1(3);
								byte_0[int_2[int_9]] = (byte)num13;
								int_9++;
								continue;
							}
							return false;
						}
						class6_0 = new Class6(byte_0);
						byte[] array5 = (byte_0 = null);
						int_9 = 0;
						int_3 = 4;
						goto case 4;
					}
					case 2:
					{
						int num3 = (int_6 = class4_0.method_0(4));
						if (int_6 >= 0)
						{
							int_6 += 4;
							class4_0.method_1(4);
							byte[] array = (byte_0 = new byte[19]);
							int_9 = 0;
							int_3 = 3;
							goto case 3;
						}
						return false;
					}
					case 1:
					{
						int num7 = (int_5 = class4_0.method_0(5));
						if (int_5 >= 0)
						{
							int_5++;
							class4_0.method_1(5);
							int num8 = (int_7 = int_4 + int_5);
							byte[] array3 = (byte_1 = new byte[int_7]);
							int_3 = 2;
							goto case 2;
						}
						return false;
					}
					case 0:
					{
						int num2 = (int_4 = class4_0.method_0(5));
						if (int_4 >= 0)
						{
							int_4 += 257;
							class4_0.method_1(5);
							int_3 = 1;
							goto case 1;
						}
						return false;
					}
					}
					continue;
					IL_00a1:
					int_3 = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num13, num9, num4, num5, num, b, this, class4_0);
				throw;
			}
		}

		public Class6 method_1()
		{
			byte[] array = default(byte[]);
			try
			{
				array = new byte[int_4];
				SendingReportFeedbackEventArgs.smethod_0(byte_1, 0, array, 0, int_4, 232, 193);
				return new Class6(array);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, array, this);
				throw;
			}
		}

		public Class6 method_2()
		{
			byte[] array = default(byte[]);
			try
			{
				array = new byte[int_5];
				SendingReportFeedbackEventArgs.smethod_0(byte_1, int_4, array, 0, int_5, 571, 530);
				return new Class6(array);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, array, this);
				throw;
			}
		}

		static Class7()
		{
			DESCryptoIndirector.smethod_0();
			try
			{
				int[] array_ = new int[3];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 716, 691);
				int_0 = array_;
				int[] array_2 = new int[3];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 394, 501);
				int_1 = array_2;
				int_2 = new int[19]
				{
					16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
					11, 4, 12, 3, 13, 2, 14, 1, 15
				};
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	internal sealed class Class8
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1498)]
		private struct Struct0
		{
		}

		private Class12 class12_0;

		private Class11 class11_0;

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		internal int int_0 = 16;

		internal long long_0 = 0L;

		public Class8()
		{
			try
			{
				class12_0 = new Class12();
				class11_0 = new Class11(class12_0);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public long method_0()
		{
			try
			{
				return long_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public void method_1()
		{
			try
			{
				int_0 |= 12;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_2()
		{
			try
			{
				if (int_0 == 30)
				{
					return class12_0.method_5();
				}
				return false;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_3()
		{
			try
			{
				return class11_0.method_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public void method_4(byte[] byte_1)
		{
			try
			{
				class11_0.method_7(byte_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, byte_1);
				throw;
			}
		}

		public int method_5(byte[] byte_1)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				num = 0;
				num2 = byte_1.Length;
				num3 = num2;
				while (true)
				{
					num4 = class12_0.method_6(byte_1, num, num2);
					num += num4;
					long_0 += num4;
					num2 -= num4;
					if (num2 == 0 || int_0 == 30)
					{
						break;
					}
					if (class11_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
					{
						continue;
					}
					if (int_0 != 16)
					{
						if (int_0 == 20)
						{
							for (num5 = 8 + (-class12_0.method_2() & 7); num5 > 0; num5 -= 10)
							{
								class12_0.method_4(2, 10);
							}
							int_0 = 16;
						}
						else if (int_0 == 28)
						{
							class12_0.method_3();
							int_0 = 30;
						}
						continue;
					}
					return num3 - num2;
				}
				return num3 - num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, num2, num3, num4, num5, this, byte_1);
				throw;
			}
		}

		static Class8()
		{
			DESCryptoIndirector.smethod_0();
			char_1 = new char[749];
			char[] array = new char[8];
			array[2] = '⛱';
			array[3] = '\u082d';
			array[0] = '㤖';
			array[6] = 'ໞ';
			array[1] = 'ᮞ';
			array[4] = '\u0952';
			array[7] = '૦';
			array[5] = 'ᡑ';
			string_0 = new string[37];
			char_0 = array;
		}

		internal static RegistryKey smethod_0(RegistryKey registryKey_0, string string_1, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 48:
					return registryKey_0.OpenSubKey(string_1);
				}
			}
		}

		internal static AssemblyName smethod_1(Assembly assembly_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 70:
					return assembly_0.GetName();
				}
			}
		}

		internal static object smethod_2(ResourceManager resourceManager_0, string string_1, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 20:
					return resourceManager_0.GetObject(string_1);
				}
			}
		}
	}

	internal sealed class Class9
	{
		public sealed class Class10
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private Class9 class9_0;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			public Class10(Class9 class9_1, int int_4, int int_5, int int_6)
			{
				try
				{
					class9_0 = class9_1;
					int_0 = int_5;
					int num = (int_3 = int_6);
					short_0 = new short[int_4];
					int[] array = (int_2 = new int[int_6]);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, this, class9_1, int_4, int_5, int_6);
					throw;
				}
			}

			public void method_0(int int_4)
			{
				try
				{
					class9_0.class12_0.method_4(short_1[int_4] & 0xFFFF, byte_0[int_4]);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, int_4);
					throw;
				}
			}

			public void method_1(short[] short_2, byte[] byte_1)
			{
				try
				{
					short[] array = (short_1 = short_2);
					byte_0 = byte_1;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, this, short_2, byte_1);
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
				int[] array3 = default(int[]);
				nint num4 = default(nint);
				try
				{
					array = new int[int_3];
					num = 0;
					short[] array2 = (short_1 = new short[short_0.Length]);
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
							int[] array4 = (array3 = array);
							int num3 = num2 - 1;
							num4 = num3;
							array4[num3] = array3[num4] + (1 << 16 - num2);
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, array, num, i, j, num2, array3, num4, this);
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
				catch (Exception caughtException)
				{
					StackFrameHelper.CreateExceptionN(caughtException, new object[18]
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
					int_1 = Class11.smethod_1(num3 + 1, int_0, 128, 189);
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
						num17 = Class20.smethod_3(array3[num11] & 0xFF, array3[num16] & 0xFF, 337, 333);
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
				catch (Exception caughtException)
				{
					StackFrameHelper.CreateExceptionN(caughtException, new object[23]
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
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num, i, this);
					throw;
				}
			}

			public void method_6(Class10 class10_0)
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
								short[] array2 = (array = class10_0.short_0);
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
							short[] array3 = (array = class10_0.short_0);
							int num9 = num;
							num8 = num9;
							array3[num9] = (short)(array[num8] + (short)num3);
						}
						else if (num != 0)
						{
							(array = class10_0.short_0)[16] = (short)(array[16] + 1);
						}
						else if (num3 <= 10)
						{
							(array = class10_0.short_0)[17] = (short)(array[17] + 1);
						}
						else
						{
							(array = class10_0.short_0)[18] = (short)(array[18] + 1);
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException10(exception, num5, num6, num3, num, num2, num4, array, num8, this, class10_0);
					throw;
				}
			}

			public void method_7(Class10 class10_0)
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
								class10_0.method_0(num4);
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
								class10_0.method_0(num);
							}
						}
						else if (num != 0)
						{
							class10_0.method_0(16);
							class9_0.class12_0.method_4(num3 - 3, 2);
						}
						else if (num3 <= 10)
						{
							class10_0.method_0(17);
							class9_0.class12_0.method_4(num3 - 3, 3);
						}
						else
						{
							class10_0.method_0(18);
							class9_0.class12_0.method_4(num3 - 11, 7);
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num5, num6, num3, num, num2, num4, this, class10_0);
					throw;
				}
			}

			static Class10()
			{
				DESCryptoIndirector.smethod_0();
			}
		}

		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private Class12 class12_0;

		private Class10 class10_0;

		private Class10 class10_1;

		private Class10 class10_2;

		private static readonly short[] short_0;

		private static readonly byte[] byte_1;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		internal short[] short_2;

		internal byte[] byte_3;

		internal int int_1;

		internal int int_2;

		public static short smethod_0(int int_3)
		{
			try
			{
				return (short)((byte_0[int_3 & 0xF] << 12) | (byte_0[(int_3 >> 4) & 0xF] << 8) | (byte_0[(int_3 >> 8) & 0xF] << 4) | byte_0[int_3 >> 12]);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, int_3);
				throw;
			}
		}

		static Class9()
		{
			DESCryptoIndirector.smethod_0();
			int i = default(int);
			try
			{
				int[] array_ = new int[19];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 215, 168);
				int_0 = array_;
				byte[] array_2 = new byte[16];
				SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 282, 357);
				byte_0 = array_2;
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, i);
				throw;
			}
		}

		public Class9(Class12 class12_1)
		{
			try
			{
				class12_0 = class12_1;
				class10_0 = new Class10(this, 286, 257, 15);
				class10_1 = new Class10(this, 30, 1, 15);
				class10_2 = new Class10(this, 19, 4, 7);
				short[] array = (short_2 = new short[16384]);
				byte[] array2 = (byte_3 = new byte[16384]);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, class12_1);
				throw;
			}
		}

		public void method_0()
		{
			try
			{
				int_1 = 0;
				int_2 = 0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, int_3);
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, int_3);
				throw;
			}
		}

		public void method_3(int int_3)
		{
			int i = default(int);
			try
			{
				class10_2.method_2();
				class10_0.method_2();
				class10_1.method_2();
				class12_0.method_4(class10_0.int_1 - 257, 5);
				class12_0.method_4(class10_1.int_1 - 1, 5);
				class12_0.method_4(int_3 - 4, 4);
				for (i = 0; i < int_3; i++)
				{
					class12_0.method_4(class10_2.byte_0[int_0[i]], 3);
				}
				class10_0.method_7(class10_2);
				class10_1.method_7(class10_2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, i, this, int_3);
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
				for (i = 0; i < int_1; i++)
				{
					num = byte_3[i] & 0xFF;
					num2 = short_2[i];
					if (num2-- != 0)
					{
						num3 = method_1(num);
						class10_0.method_0(num3);
						num4 = (num3 - 261) / 4;
						if (num4 > 0 && num4 <= 5)
						{
							class12_0.method_4(num & ((1 << num4) - 1), num4);
						}
						num5 = method_2(num2);
						class10_1.method_0(num5);
						num4 = num5 / 2 - 1;
						if (num4 > 0)
						{
							class12_0.method_4(num2 & ((1 << num4) - 1), num4);
						}
					}
					else
					{
						class10_0.method_0(num);
					}
				}
				class10_0.method_0(256);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, i, num, num2, num3, num4, num5, this);
				throw;
			}
		}

		public void method_5(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			try
			{
				class12_0.method_4(bool_0 ? 1 : 0, 3);
				class12_0.method_3();
				class12_0.method_0(int_4);
				class12_0.method_0(~int_4);
				class12_0.method_1(byte_4, int_3, int_4);
				method_0();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, byte_4, int_3, int_4, bool_0);
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
				(array = class10_0.short_0)[256] = (short)(array[256] + 1);
				class10_0.method_4();
				class10_1.method_4();
				class10_0.method_6(class10_2);
				class10_1.method_6(class10_2);
				class10_2.method_4();
				num = 4;
				for (num2 = 18; num2 > num; num2--)
				{
					if (class10_2.byte_0[int_0[num2]] > 0)
					{
						num = num2 + 1;
					}
				}
				num3 = 14 + num * 3 + class10_2.method_5() + class10_0.method_5() + class10_1.method_5() + int_2;
				num4 = int_2;
				for (i = 0; i < 286; i++)
				{
					num4 += class10_0.short_0[i] * byte_1[i];
				}
				for (j = 0; j < 30; j++)
				{
					num4 += class10_1.short_0[j] * byte_2[j];
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
					class12_0.method_4(2 + (bool_0 ? 1 : 0), 3);
					class10_0.method_1(short_0, byte_1);
					class10_1.method_1(short_1, byte_2);
					method_4();
					method_0();
				}
				else
				{
					class12_0.method_4(4 + (bool_0 ? 1 : 0), 3);
					method_3(num);
					method_4();
					method_0();
				}
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[12]
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
				return int_1 >= 16384;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
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
				short_2[int_1] = 0;
				byte[] array = byte_3;
				int num2 = (int_1 = (num = int_1) + 1);
				array[num] = (byte)int_3;
				short[] array3 = (array2 = class10_0.short_0);
				num3 = int_3;
				array3[int_3] = (short)(array2[num3] + 1);
				return method_7();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, array2, num3, this, int_3);
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
				short_2[int_1] = (short)int_3;
				byte[] array = byte_3;
				int num2 = (int_1 = (num = int_1) + 1);
				array[num] = (byte)(int_4 - 3);
				num3 = method_1(int_4 - 3);
				short[] array3 = (array2 = class10_0.short_0);
				int num4 = num3;
				num5 = num4;
				array3[num4] = (short)(array2[num5] + 1);
				if (num3 >= 265 && num3 < 285)
				{
					int_2 += (num3 - 261) / 4;
				}
				num6 = method_2(int_3 - 1);
				short[] array4 = (array2 = class10_1.short_0);
				int num7 = num6;
				num5 = num7;
				array4[num7] = (short)(array2[num5] + 1);
				if (num6 >= 4)
				{
					int_2 += num6 / 2 - 1;
				}
				return method_7();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num3, num6, num, array2, num5, this, int_3, int_4);
				throw;
			}
		}
	}

	internal sealed class Class11
	{
		private Class12 class12_0;

		private Class9 class9_0;

		internal int int_0;

		internal short[] short_0;

		internal short[] short_1;

		internal int int_1;

		internal int int_2;

		internal bool bool_0;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		public Class11(Class12 class12_1)
		{
			int num = default(int);
			try
			{
				class12_0 = class12_1;
				class9_0 = new Class9(class12_1);
				byte[] array = (byte_0 = new byte[65536]);
				short[] array2 = (short_0 = new short[32768]);
				short[] array3 = (short_1 = new short[32768]);
				num = 1;
				int_4 = 1;
				int_3 = 1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, class12_1);
				throw;
			}
		}

		private void method_0()
		{
			try
			{
				int num = (int_0 = (byte_0[int_4] << 5) ^ byte_0[int_4 + 1]);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		private int method_1()
		{
			int num = default(int);
			short num2 = default(short);
			try
			{
				num = ((int_0 << 5) ^ byte_0[int_4 + 2]) & 0x7FFF;
				num2 = (short_1[int_4 & 0x7FFF] = short_0[num]);
				short_0[num] = (short)int_4;
				int num3 = (int_0 = num);
				return num2 & 0xFFFF;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num2, num, this);
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
				SendingReportFeedbackEventArgs.smethod_0(byte_0, 32768, byte_0, 0, 32768, 785, 824);
				int_1 -= 32768;
				int_4 -= 32768;
				int_3 -= 32768;
				for (i = 0; i < 32768; i++)
				{
					num = short_0[i] & 0xFFFF;
					short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
				}
				for (j = 0; j < 32768; j++)
				{
					num2 = short_1[j] & 0xFFFF;
					short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, i, num, j, num2, this);
				throw;
			}
		}

		public void method_3()
		{
			int num = default(int);
			try
			{
				if (int_4 >= 65274)
				{
					method_2();
				}
				while (int_5 < 262 && int_7 < int_8)
				{
					num = 65536 - int_5 - int_4;
					if (num > int_8 - int_7)
					{
						num = int_8 - int_7;
					}
					SendingReportFeedbackEventArgs.smethod_0(byte_1, int_7, byte_0, int_4 + int_5, num, 456, 481);
					int_7 += num;
					int_6 += num;
					int_5 += num;
				}
				if (int_5 >= 3)
				{
					method_0();
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, num, this);
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
				array = short_1;
				num3 = int_4;
				num4 = int_4 + int_2;
				num5 = smethod_1(int_2, 2, 330, 375);
				num6 = smethod_1(int_4 - 32506, 0, 970, 1015);
				num7 = int_4 + 258 - 1;
				b = byte_0[num4 - 1];
				b2 = byte_0[num4];
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
					num8 = int_9 + 2;
					num3 += 2;
					while (byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && byte_0[++num3] == byte_0[++num8] && num3 < num7)
					{
					}
					if (num3 > num4)
					{
						int num9 = (int_1 = int_9);
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
				int num10 = (int_2 = Class20.smethod_3(num5, int_5, 397, 401));
				return int_2 >= 3;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[13]
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
			int num5 = default(int);
			bool flag = default(bool);
			try
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
							num = int_1;
							num2 = int_2;
							if (int_5 >= 3)
							{
								num3 = method_1();
								if (num3 != 0 && int_4 - num3 <= 32506 && method_4(num3) && int_2 <= 5 && int_2 == 3 && int_4 - int_1 > 4096)
								{
									int_2 = 2;
								}
							}
							if (num2 >= 3 && int_2 <= num2)
							{
								class9_0.method_9(int_4 - 1 - num, num2);
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
									class9_0.method_8(byte_0[int_4 - 1] & 0xFF);
								}
								bool_0 = true;
								int_4++;
								int_5--;
							}
							continue;
						}
						if (bool_0)
						{
							class9_0.method_8(byte_0[int_4 - 1] & 0xFF);
						}
						bool_0 = false;
						class9_0.method_6(byte_0, int_3, int_4 - int_3, bool_2);
						int num4 = (int_3 = int_4);
						return false;
					}
					return true;
				}
				while (!class9_0.method_7());
				num5 = int_4 - int_3;
				if (bool_0)
				{
					num5--;
				}
				flag = bool_2 && int_5 == 0 && !bool_0;
				class9_0.method_6(byte_0, int_3, num5, flag);
				int_3 += num5;
				return !flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num, num2, num3, num5, flag, this, bool_1, bool_2);
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
					flag = bool_1 && int_7 == int_8;
					flag2 = method_5(flag, bool_2);
				}
				while (class12_0.method_5() && flag2);
				return flag2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, flag2, flag, this, bool_1, bool_2);
				throw;
			}
		}

		public void method_7(byte[] byte_2)
		{
			try
			{
				byte[] array = (byte_1 = byte_2);
				int_7 = 0;
				int num = (int_8 = byte_2.Length);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, byte_2);
				throw;
			}
		}

		public bool method_8()
		{
			try
			{
				return int_8 == int_7;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static Class11()
		{
			DESCryptoIndirector.smethod_0();
		}

		internal static int smethod_0(Stream stream_0, byte[] byte_2, int int_9, int int_10, int int_11, int int_12)
		{
			while (true)
			{
				switch (int_12 ^ int_11)
				{
				case 68:
					return stream_0.Read(byte_2, int_9, int_10);
				}
			}
		}

		internal static int smethod_1(int int_9, int int_10, int int_11, int int_12)
		{
			while (true)
			{
				switch (int_12 ^ int_11)
				{
				case 61:
					return Math.Max(int_9, int_10);
				}
			}
		}

		internal static char smethod_2(int int_9, int int_10, int int_11)
		{
			while (true)
			{
				switch (int_11 ^ int_10)
				{
				case 98:
					return Convert.ToChar(int_9);
				}
			}
		}
	}

	internal sealed class Class12
	{
		protected byte[] byte_0 = new byte[65536];

		internal int int_0 = 0;

		internal int int_1 = 0;

		internal uint uint_0 = 0u;

		internal int int_2 = 0;

		public void method_0(int int_3)
		{
			int num = default(int);
			try
			{
				byte[] array = byte_0;
				int num2 = (int_1 = (num = int_1) + 1);
				array[num] = (byte)int_3;
				byte[] array2 = byte_0;
				int num3 = (int_1 = (num = int_1) + 1);
				array2[num] = (byte)(int_3 >> 8);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, int_3);
				throw;
			}
		}

		public void method_1(byte[] byte_1, int int_3, int int_4)
		{
			try
			{
				SendingReportFeedbackEventArgs.smethod_0(byte_1, int_3, byte_0, int_1, int_4, 545, 520);
				int_1 += int_4;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, byte_1, int_3, int_4);
				throw;
			}
		}

		[SpecialName]
		public int method_2()
		{
			try
			{
				return int_2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public void method_3()
		{
			int num = default(int);
			try
			{
				if (int_2 > 0)
				{
					byte[] array = byte_0;
					int num2 = (int_1 = (num = int_1) + 1);
					array[num] = (byte)uint_0;
					if (int_2 > 8)
					{
						byte[] array2 = byte_0;
						int num3 = (int_1 = (num = int_1) + 1);
						array2[num] = (byte)(uint_0 >> 8);
					}
				}
				uint_0 = 0u;
				int_2 = 0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		public void method_4(int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				uint_0 |= (uint)(int_3 << int_2);
				int_2 += int_4;
				if (int_2 >= 16)
				{
					byte[] array = byte_0;
					int num2 = (int_1 = (num = int_1) + 1);
					array[num] = (byte)uint_0;
					byte[] array2 = byte_0;
					int num3 = (int_1 = (num = int_1) + 1);
					array2[num] = (byte)(uint_0 >> 8);
					uint_0 >>= 16;
					int_2 -= 16;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, this, int_3, int_4);
				throw;
			}
		}

		[SpecialName]
		public bool method_5()
		{
			try
			{
				return int_1 == 0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int method_6(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				if (int_2 >= 8)
				{
					byte[] array = byte_0;
					int num2 = (int_1 = (num = int_1) + 1);
					array[num] = (byte)uint_0;
					uint_0 >>= 8;
					int_2 -= 8;
				}
				if (int_4 > int_1 - int_0)
				{
					int_4 = int_1 - int_0;
					SendingReportFeedbackEventArgs.smethod_0(byte_0, int_0, byte_1, int_3, int_4, 359, 334);
					int_0 = 0;
					int_1 = 0;
				}
				else
				{
					SendingReportFeedbackEventArgs.smethod_0(byte_0, int_0, byte_1, int_3, int_4, 749, 708);
					int_0 += int_4;
				}
				return int_4;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, this, byte_1, int_3, int_4);
				throw;
			}
		}

		static Class12()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public void method_0(int int_0)
		{
			try
			{
				WaitSendingReportControl.smethod_1(this, (byte)((uint)int_0 & 0xFFu), 16, 68);
				WaitSendingReportControl.smethod_1(this, (byte)((uint)(int_0 >> 8) & 0xFFu), 15, 91);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, int_0);
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, int_0);
				throw;
			}
		}

		public int method_2()
		{
			try
			{
				return ConfirmFeatureUsageReportingForm.smethod_1(this, 514, 561) | (ConfirmFeatureUsageReportingForm.smethod_1(this, 603, 616) << 8);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int method_3()
		{
			try
			{
				return method_2() | (method_2() << 16);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public Stream0()
		{
		}

		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}

		static Stream0()
		{
			DESCryptoIndirector.smethod_0();
		}

		internal static PropertyInfo smethod_0(Type type_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					return type_0.GetProperty(string_0);
				}
			}
		}

		internal static int smethod_1(ref IntPtr intptr_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return intptr_0.ToInt32();
				}
			}
		}
	}

	public static string ExceptionMessage;

	private static bool smethod_0(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int i = default(int);
		try
		{
			array = Attribute0.smethod_5(Class8.smethod_1(assembly_0, 176, 246), 892, 790);
			array2 = Attribute0.smethod_5(Class8.smethod_1(assembly_1, 909, 971), 837, 815);
			if (array2 == null != (array == null))
			{
				return false;
			}
			if (array2 != null)
			{
				for (i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return false;
					}
				}
			}
			return true;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, array, array2, i, assembly_0, assembly_1);
			throw;
		}
	}

	public static byte[] Unzip(byte[] buffer)
	{
		Assembly assembly = default(Assembly);
		Assembly assembly2 = default(Assembly);
		Stream0 stream = default(Stream0);
		byte[] array = default(byte[]);
		int num = default(int);
		short num2 = default(short);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		Class3 @class = default(Class3);
		int num8 = default(int);
		int num9 = default(int);
		int i = default(int);
		int num10 = default(int);
		int num11 = default(int);
		byte[] array5 = default(byte[]);
		Class3 class2 = default(Class3);
		byte[] array7 = default(byte[]);
		byte[] array9 = default(byte[]);
		DESCryptoIndirector dESCryptoIndirector = default(DESCryptoIndirector);
		ICryptoTransform dESCryptoTransform = default(ICryptoTransform);
		byte[] array10 = default(byte[]);
		byte[] array12 = default(byte[]);
		byte[] array14 = default(byte[]);
		AESCryptoIndirector aESCryptoIndirector = default(AESCryptoIndirector);
		ICryptoTransform aESCryptoTransform = default(ICryptoTransform);
		byte[] array15 = default(byte[]);
		try
		{
			assembly = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_2(361, 359);
			assembly2 = Class24.smethod_1(429, 406);
			if ((object)assembly != assembly2 && !smethod_0(assembly2, assembly))
			{
				return null;
			}
			stream = new Stream0(buffer);
			array = new byte[0];
			num = stream.method_3();
			if (num == 67324752)
			{
				num2 = (short)stream.method_2();
				num3 = stream.method_2();
				num4 = stream.method_2();
				if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
				{
					throw new FormatException("Wrong Header Signature");
				}
				stream.method_3();
				stream.method_3();
				stream.method_3();
				num5 = stream.method_3();
				num6 = stream.method_2();
				num7 = stream.method_2();
				if (num6 > 0)
				{
					array2 = new byte[num6];
					Class11.smethod_0(stream, array2, 0, num6, 142, 202);
				}
				if (num7 > 0)
				{
					array3 = new byte[num7];
					Class11.smethod_0(stream, array3, 0, num7, 704, 644);
				}
				array4 = new byte[ReportExceptionEventArgs.smethod_1(stream, 1007, 987) - stream.Position];
				Class11.smethod_0(stream, array4, 0, array4.Length, 810, 878);
				@class = new Class3(array4);
				array = new byte[num5];
				@class.method_2(array, 0, array.Length);
				array4 = null;
			}
			else
			{
				num8 = num >> 24;
				num -= num8 << 24;
				if (num != 8223355)
				{
					throw new FormatException("Unknown Header");
				}
				if (num8 == 1)
				{
					num9 = stream.method_3();
					array = new byte[num9];
					for (i = 0; i < num9; i += num11)
					{
						num10 = stream.method_3();
						num11 = stream.method_3();
						array5 = new byte[num10];
						Class11.smethod_0(stream, array5, 0, array5.Length, 766, 698);
						class2 = new Class3(array5);
						class2.method_2(array, i, num11);
					}
				}
				if (num8 == 2)
				{
					byte[] array6 = new byte[8];
					SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 227, 156);
					array7 = array6;
					byte[] array8 = new byte[8];
					SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 898, 1021);
					array9 = array8;
					dESCryptoIndirector = new DESCryptoIndirector();
					try
					{
						dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(array7, array9, decrypt: true);
						try
						{
							array10 = dESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
							array = Unzip(array10);
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
				}
				if (num8 == 3)
				{
					byte[] array11 = new byte[16];
					SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 306, 333);
					array12 = array11;
					byte[] array13 = new byte[16];
					SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 723, 684);
					array14 = array13;
					aESCryptoIndirector = new AESCryptoIndirector();
					try
					{
						aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(array12, array14, decrypt: true);
						try
						{
							array15 = aESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
							array = Unzip(array15);
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
				}
			}
			SendingReportFeedbackEventArgs.smethod_1(stream, 407, 490);
			stream = null;
			return array;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[33]
			{
				assembly, assembly2, stream, array, num, num2, num3, num4, num5, num6,
				num7, array2, array3, array4, @class, num8, num9, i, num10, num11,
				class2, array5, array7, array9, dESCryptoIndirector, dESCryptoTransform, array10, array12, array14, aESCryptoIndirector,
				aESCryptoTransform, array15, buffer
			});
			throw;
		}
	}

	public static byte[] Zip(byte[] buffer)
	{
		try
		{
			return smethod_1(buffer, 1, null, null);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, buffer);
			throw;
		}
	}

	public static byte[] ZipAndEncrypt(byte[] buffer, byte[] key, byte[] iv)
	{
		try
		{
			return smethod_1(buffer, 2, key, iv);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, buffer, key, iv);
			throw;
		}
	}

	public static byte[] ZipAndAES(byte[] buffer, byte[] key, byte[] iv)
	{
		try
		{
			return smethod_1(buffer, 3, key, iv);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, buffer, key, iv);
			throw;
		}
	}

	private static byte[] smethod_1(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		Stream0 stream = default(Stream0);
		Class8 class2 = default(Class8);
		DateTime dateTime_ = default(DateTime);
		long num3 = default(long);
		uint[] array9 = default(uint[]);
		uint num4 = default(uint);
		uint num5 = default(uint);
		int num6 = default(int);
		int num7 = default(int);
		long position3 = default(long);
		byte[] array10 = default(byte[]);
		byte[] array11 = default(byte[]);
		int num8 = default(int);
		byte[] array12 = default(byte[]);
		int num9 = default(int);
		long num10 = default(long);
		int i = default(int);
		byte[] array5 = default(byte[]);
		long position = default(long);
		Class8 @class = default(Class8);
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
		byte[] array13 = default(byte[]);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				stream = new Stream0();
				switch (int_0)
				{
				case 0:
				{
					class2 = new Class8();
					dateTime_ = HeaderControl.smethod_2(575, 613);
					num3 = (uint)((((ReportSender.smethod_1(ref dateTime_, 287, 342) - 1980) & 0x7F) << 25) | (FatalExceptionEventArgs.smethod_2(ref dateTime_, 232, 160) << 21) | (FatalExceptionEventArgs.smethod_2(ref dateTime_, 463, 390) << 16) | (Class30.smethod_6(ref dateTime_, 825, 881) << 11) | (ConfirmFeatureUsageReportingForm.smethod_3(ref dateTime_, 922, 948) << 5) | (int)((uint)dateTime_.Second >> 1));
					uint[] array8 = new uint[256];
					SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 20, 107);
					array9 = array8;
					num4 = uint.MaxValue;
					num5 = uint.MaxValue;
					num6 = 0;
					num7 = byte_0.Length;
					while (--num7 >= 0)
					{
						num5 = array9[(num5 ^ byte_0[num6++]) & 0xFF] ^ (num5 >> 8);
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
					array10 = Win32.smethod_12(Class20.smethod_2(340, 314), "{data}", 62, 80);
					stream.method_0(array10.Length);
					stream.method_0(0);
					SendingReportFeedbackEventArgs.smethod_2(stream, array10, 0, array10.Length, 615, 590);
					class2.method_4(byte_0);
					while (!class2.method_3())
					{
						array11 = new byte[512];
						num8 = class2.method_5(array11);
						if (num8 <= 0)
						{
							break;
						}
						SendingReportFeedbackEventArgs.smethod_2(stream, array11, 0, num8, 118, 95);
					}
					class2.method_1();
					while (!class2.method_2())
					{
						array12 = new byte[512];
						num9 = class2.method_5(array12);
						if (num9 <= 0)
						{
							break;
						}
						SendingReportFeedbackEventArgs.smethod_2(stream, array12, 0, num9, 592, 633);
					}
					num10 = class2.method_0();
					stream.method_1(33639248);
					stream.method_0(20);
					stream.method_0(20);
					stream.method_0(0);
					stream.method_0(8);
					stream.method_1((int)num3);
					stream.method_1((int)num5);
					stream.method_1((int)num10);
					stream.method_1(byte_0.Length);
					stream.method_0(array10.Length);
					stream.method_0(0);
					stream.method_0(0);
					stream.method_0(0);
					stream.method_0(0);
					stream.method_1(0);
					stream.method_1(0);
					SendingReportFeedbackEventArgs.smethod_2(stream, array10, 0, array10.Length, 145, 184);
					stream.method_1(101010256);
					stream.method_0(0);
					stream.method_0(0);
					stream.method_0(1);
					stream.method_0(1);
					stream.method_1(46 + array10.Length);
					stream.method_1((int)(30 + array10.Length + num10));
					stream.method_0(0);
					Class37.smethod_7(stream, position3, SeekOrigin.Begin, 113, 58);
					stream.method_1((int)num10);
					break;
				}
				case 1:
					stream.method_1(25000571);
					stream.method_1(byte_0.Length);
					for (i = 0; i < byte_0.Length; i += array5.Length)
					{
						array5 = new byte[Class20.smethod_3(2097151, byte_0.Length - i, 809, 821)];
						DoNotPruneTypeAttribute.smethod_1(byte_0, i, array5, 0, array5.Length, 911, 953);
						position = stream.Position;
						stream.method_1(0);
						stream.method_1(array5.Length);
						@class = new Class8();
						@class.method_4(array5);
						while (!@class.method_3())
						{
							array6 = new byte[512];
							num = @class.method_5(array6);
							if (num <= 0)
							{
								break;
							}
							SendingReportFeedbackEventArgs.smethod_2(stream, array6, 0, num, 1000, 961);
						}
						@class.method_1();
						while (!@class.method_2())
						{
							array7 = new byte[512];
							num2 = @class.method_5(array7);
							if (num2 <= 0)
							{
								break;
							}
							SendingReportFeedbackEventArgs.smethod_2(stream, array7, 0, num2, 868, 845);
						}
						position2 = stream.Position;
						Class29.smethod_5(stream, position, 205, 222);
						stream.method_1((int)@class.method_0());
						Class29.smethod_5(stream, position2, 936, 955);
					}
					break;
				case 2:
					stream.method_1(41777787);
					array3 = smethod_1(byte_0, 1, null, null);
					dESCryptoIndirector = new DESCryptoIndirector();
					try
					{
						dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(byte_1, byte_2, decrypt: false);
						try
						{
							array4 = dESCryptoTransform.TransformFinalBlock(array3, 0, array3.Length);
							SendingReportFeedbackEventArgs.smethod_2(stream, array4, 0, array4.Length, 902, 943);
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
					array = smethod_1(byte_0, 1, null, null);
					aESCryptoIndirector = new AESCryptoIndirector();
					try
					{
						aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(byte_1, byte_2, decrypt: false);
						try
						{
							array2 = aESCryptoTransform.TransformFinalBlock(array, 0, array.Length);
							SendingReportFeedbackEventArgs.smethod_2(stream, array2, 0, array2.Length, 187, 146);
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
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_2(stream, 657, 742);
				SendingReportFeedbackEventArgs.smethod_1(stream, 835, 830);
				array13 = Class37.smethod_5(stream, 426, 442);
				return array13;
			}
			catch (Exception ex)
			{
				ex2 = ex;
				ExceptionMessage = ReportSender.smethod_0("ERR 2003: ", AutoHeightLabel.smethod_1(ex2, 122, 3), 504, 411);
				throw;
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[39]
			{
				stream, class2, dateTime_, num3, array9, num4, num5, num6, num7, position3,
				array10, array11, num8, array12, num9, num10, i, array5, position, @class,
				array6, num, array7, num2, position2, array3, dESCryptoIndirector, dESCryptoTransform, array4, array,
				aESCryptoIndirector, aESCryptoTransform, array2, ex2, array13, byte_0, int_0, byte_1, byte_2
			});
			throw;
		}
	}

	static SimpleZip()
	{
		DESCryptoIndirector.smethod_0();
	}
}
