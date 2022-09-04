using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using Microsoft.VisualBasic;
using ns2;

namespace ns0;

internal sealed class Class3
{
	internal sealed class Class4
	{
		internal static char smethod_0(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 120:
					return Strings.ChrW(int_0);
				}
			}
		}

		internal static AppDomain smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					return AppDomain.CurrentDomain;
				}
			}
		}

		internal static AppDomain smethod_2(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return AppDomain.CurrentDomain;
				}
			}
		}

		internal static void smethod_3(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 0:
					appDomain_0.SetData(string_0, object_0);
					return;
				case 1:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
			}
		}

		internal static void smethod_4(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 105:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}

		internal static Assembly smethod_5(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}

		internal static string[] smethod_6(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 59:
					return assembly_0.GetManifestResourceNames();
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct2
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct2 struct2_0/* Not supported: data(00 00 05 00 00 00 EC 28 A5 25 B1 3A 89 2F A4 3A) */;

	public static string smethod_0(string string_1)
	{
		string s = Class0.Class1.Class2.smethod_0(1996671409, 1);
		string[] array = Class0.Class1.smethod_0(string_1, Class0.Class1.Class2.smethod_0(1996671412, 7), -1, (CompareMethod)0, 23, 26);
		foreach (string string_2 in array)
		{
			s = Class0.Class1.smethod_1(s, Class0.Class1.smethod_2(Class4.smethod_0(checked((int)smethod_1(Class0.smethod_4(Class0.Class1.smethod_1(Class0.Class1.Class2.smethod_0(1996671411, 4), string_2, 443, 465), 511, 435), 523, 543)), 751, 663), 701, 675), 950, 988);
		}
		return Encoding.UTF8.GetString(Convert.FromBase64String(s));
	}

	static Class3()
	{
		Class6.smethod_0();
		char_1 = new char[8] { '\0', '\u0005', '\0', '⣬', '▥', '㪱', '⾉', '㪤' };
		char[] array = new char[8];
		array[7] = '៨';
		array[3] = '⾰';
		array[2] = '㪀';
		array[0] = '⣁';
		array[4] = '㫦';
		array[1] = '▐';
		array[6] = '㢦';
		array[5] = 'ᵛ';
		string_0 = new string[1];
		char_0 = array;
		Class0.smethod_7();
	}

	internal static double smethod_1(double double_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Math.Round(double_0);
			}
		}
	}

	internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				appDomain_0.AssemblyResolve += resolveEventHandler_0;
				return;
			}
		}
	}

	internal static string smethod_3(int int_0, int int_1)
	{
		int num = int_0 ^ 0x7702C9B0 ^ int_1;
		char[] array = char_1;
		int num2 = array[num];
		string result;
		if ((result = string_0[num2]) != null)
		{
			return result;
		}
		int num3 = array[num + 1];
		num3 = (int)((uint)array[num + 2] << 16) + num3;
		char[] array2 = new char[num3];
		char[] array3 = char_0;
		int num4 = array3.Length;
		num += 3;
		for (int num5 = 0; num5 < num3; num5 = 1 + num5)
		{
			array2[num5] = (char)(array[num + num5] ^ array3[(num5 + num2) % num4]);
		}
		result = new string(array2);
		string_0[num2] = result;
		return result;
	}

	internal static Assembly smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	internal static object smethod_5(AppDomain appDomain_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 120:
				return appDomain_0.GetData(string_1);
			}
		}
	}
}
