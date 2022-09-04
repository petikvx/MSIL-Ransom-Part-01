using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class3
{
	private sealed class Class4
	{
		public static readonly Class4 class4_0;

		internal byte[] byte_0;

		static Class4()
		{
			Class5.smethod_7();
			if (smethod_2(Class7.smethod_2(571, 589), new DateTime(635307010619686190L), 362, 284))
			{
				throw new Exception();
			}
			class4_0 = new Class4();
		}

		private Class4()
		{
			Assembly assembly_ = Class5.smethod_4(556, 630);
			Stream stream = Class1.smethod_2(assembly_, smethod_1(), 930, 921);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class9.Class10.smethod_0(stream, byte_0, 0, byte_0.Length, 123, 81);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class0.smethod_1(string_0, 195, 212);
			int num2 = int_0 & 0xFF;
			char[] array = Class1.smethod_3(string_0, 297, 376);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class9.smethod_0(new string(array), 802, 851);
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 442)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 20 00 00 00 A1 2F 5F 2D FC 3B 0A 05 FD 3E 06 2B 00 20 9E 0C A4 2F 5B 2D AC 3B 53 05 F8 3E 04 2B 57 20 9D 0C F7 2F 5C 2D FB 3B 08 05 FC 3E 5D 2B 05 20 C8 0C F0 2F 0F 2D F3 3B 0A 05 F9 3E 5D 2B 52 20 94 0C 01 00 20 00 00 00 62 C1 C0 D7 62 E9 97 D2 69 C7 6C CC FB E0 C9 C3 35 C1 95 D7 61 E9 91 D2 3E C7 38 CC A6 E0 CB C3 33 C1 C3 D7 61 E9 C1 D2 6E C7 6B CC F1 E0 C9 C3 65 C1 96 D7 66 E9 91 D2 3A C7 3D CC A7 E0 9A C3 02 00 20 00 00 00 E7 3A 41 04 B6 3F 4B 2A 1A 21 85 0D B8 2E 44 2C E7 3A 17 04 ED 3F 18 2A 4B 21 8D 0D B6 2E 46 2C B2 3A 10 04 E6 3F 48 2A 19 21 8C 0D BC 2E 14 2C B7 3A 45 04 E3 3F 1F 2A 1A 21 84 0D BB 2E 11 2C 03 00 20 00 00 00 D3 F8 27 C3 D8 D6 8F DD 14 F1 28 D2 D1 D0 28 C6 85 F8 71 C3 DC D6 DC DD 42 F1 28 D2 84 D0 27 C6 89 F8 2F C3 DB D6 85 DD 14 F1 7C D2 DD D0 23 C6 D1 F8 20 C3 8A D6 85 DD 45 F1 28 D2 D6 D0 70 C6 04 00 03 00 00 00 34 27 8A 32 9F 39 05 00 0D 00 00 00 BF 24 9F 2F 7C 03 7D 20 FC 22 3D 34 CD 0A 34 31 9E 24 9C 2F 75 03 41 20 9D 22 06 00 38 00 00 00 F3 22 0F 0E 2F 2D E6 2F 52 39 F9 07 41 3C CE 29 D5 22 1E 0E 30 2D 9A 2F 44 39 F9 07 42 3C F1 29 E1 22 74 0E 42 2D 84 2F 62 39 F9 07 60 3C FD 29 CA 22 01 0E 27 2D AB 2F 7E 39 EC 07 59 3C EF 29 FE 22 18 0E 02 2D 9A 2F 73 39 DF 07 6D 3C E7 29 EB 22 23 0E 22 2D 91 2F 4C 39 C1 07 1E 3C D6 29 D2 22 7C 0E 2F 2D 8B 2F 18 39 B9 07 1A 3C E6 29) */;

	public static string smethod_0(string string_1, int int_0)
	{
		if (smethod_2(Class7.smethod_2(1008, 902), new DateTime(635307010620116215L), 325, 307))
		{
			throw new Exception();
		}
		return Class9.smethod_0(Class4.class4_0.method_0(string_1, int_0), 969, 952);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class5.smethod_0(Class7.smethod_0(smethod_3(1726088042, 1), 57667), 57426);
	}

	static Class3()
	{
		Class5.smethod_7();
		char[] array_ = new char[221];
		Class9.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 372, 326);
		char_1 = array_;
		char[] array = new char[8];
		array[6] = '\u2066';
		array[4] = '㻌';
		array[1] = 'ⴾ';
		array[7] = 'ಭ';
		array[3] = 'ի';
		array[2] = '㯊';
		array[5] = '⭥';
		array[0] = '⾖';
		string_0 = new string[7];
		char_0 = array;
	}

	internal static bool smethod_2(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return Class9.Class11.smethod_7(dateTime_0, dateTime_1, 666, 747);
			}
		}
	}

	internal static string smethod_3(int int_0, int int_1)
	{
		int num = int_0 ^ 0x66E2032D ^ int_1;
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

	internal static int smethod_4(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 43:
				return Class12.Class13.smethod_1(array_0, int_0, 853, 879);
			}
		}
	}

	internal static Assembly smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return Class12.smethod_2(376, 313);
			}
		}
	}
}
