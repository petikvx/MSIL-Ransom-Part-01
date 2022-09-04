using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using ns1;

namespace ns0;

internal sealed class Attribute0 : Attribute
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct0
	{
		internal byte[] byte_0;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 188)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 38 00 00 00 3F EE D7 F4 42 DB 57 F6 F9 D6 58 D3 97 F3 5F C9 27 EE 95 F4 5F DB 11 F6 B2 D6 1A D3 CA F3 06 C9 66 EE CB F4 4E DB 01 F6 FF D6 5F D3 88 F3 42 C9 3D EE 89 F4 07 DB 1C F6 F2 D6 4F D3 91 F3 42 C9 3A EE 9A F4 0E DB 0D F6 BC D6 5A D3 91 F3 54 C9 24 EE 92 F4 01 DB 4A F6 F9 D6 53 D3 90 F3 59 C9 23 EE 9E F4 0C DB 1C F6 F2 D6 5F D3 88 F3 5A C9 01 00 20 00 00 00 74 01 B8 2E AC 03 44 23 F5 26 3D 06 BC 3C 97 1B 76 01 BF 2E FE 03 1E 23 A5 26 6D 06 BF 3C C0 1B 22 01 B8 2E A9 03 42 23 F0 26 3D 06 B5 3C 95 1B 26 01 E9 2E F8 03 44 23 F2 26 3B 06 EB 3C C4 1B) */;

	private static bool bool_0;

	static Attribute0()
	{
		smethod_6();
		char_1 = new char[94]
		{
			'\0', '8', '\0', '\uee3f', '\uf4d7', '\udb42', '\uf657', '훹', '퍘', '\uf397',
			'쥟', '\uee27', '\uf495', '\udb5f', '\uf611', '횲', '팚', '\uf3ca', '줆', '\uee66',
			'\uf4cb', '\udb4e', '\uf601', '훿', '퍟', '\uf388', '쥂', '\uee3d', '\uf489', '\udb07',
			'\uf61c', '훲', '퍏', '\uf391', '쥂', '\uee3a', '\uf49a', '\udb0e', '\uf60d', '횼',
			'퍚', '\uf391', '쥔', '\uee24', '\uf492', '\udb01', '\uf64a', '훹', '퍓', '\uf390',
			'쥙', '\uee23', '\uf49e', '\udb0c', '\uf61c', '훲', '퍟', '\uf388', '쥚', '\u0001',
			' ', '\0', 'Ŵ', '⺸', 'ά', '⍄', '⛵', 'ؽ', '㲼', 'ᮗ',
			'Ŷ', '⺿', 'Ͼ', '⌞', '⚥', '٭', '㲿', 'ᯀ', 'Ģ', '⺸',
			'Ω', '⍂', '⛰', 'ؽ', '㲵', 'ᮕ', 'Ħ', '⻩', 'ϸ', '⍄',
			'⛲', 'ػ', '㳫', 'ᯄ'
		};
		char[] array = new char[8];
		array[7] = '㲍';
		array[4] = '⌧';
		array[2] = '⻙';
		array[6] = '\u065f';
		array[5] = '⚑';
		array[1] = 'ŀ';
		array[0] = '\u1bf3';
		array[3] = 'Κ';
		string_0 = new string[2];
		char_0 = array;
	}

	internal static DateTime smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				return DateTime.Now;
			}
		}
	}

	internal static bool smethod_1(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return dateTime_0 > dateTime_1;
			}
		}
	}

	internal static char[] smethod_2(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				return string_1.ToCharArray();
			}
		}
	}

	internal static string smethod_3(int int_0, int int_1)
	{
		int num = int_0 ^ 0x291749D3 ^ int_1;
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

	internal static AppDomain smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				return AppDomain.CurrentDomain;
			}
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 6:
				return Assembly.Load(byte_0);
			}
		}
	}

	internal static void smethod_6()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Attribute0))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += Class0.Class1.smethod_0;
			}
		}
	}

	internal static Assembly smethod_7(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	internal static int smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 87:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	internal static Assembly smethod_9(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}
}
