using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using ns0;
using ns2;
using ns5;

namespace ns3;

internal sealed class Exception0 : ApplicationException
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 212)]
	private struct Struct12
	{
		static Struct12()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct13
	{
		internal Struct9[] struct9_0;

		internal int int_0;

		static Struct13()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct14
	{
		internal Class2.Class4.Struct6[] struct6_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		static Struct14()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct12 struct12_0/* Not supported: data(00 00 11 00 00 00 67 37 44 3D 7C 11 E7 2E 33 22 BA 3D B8 15 DA 3D 7E 37 4B 3D 78 11 E7 2E 32 22 B6 3D A8 15 9F 3D 5C 37 01 00 0A 00 00 00 6E 3D 6B 11 F2 2E 3E 22 F3 3D 99 15 88 3D 5C 37 45 3D 78 11 02 00 04 00 00 00 24 11 E2 2E 33 22 BF 3D 03 00 01 00 00 00 A8 2E 04 00 03 00 00 00 04 22 FD 3D 81 15 05 00 01 00 00 00 F9 3D 06 00 02 00 00 00 F2 15 D0 3D 07 00 01 00 00 00 9C 3D 08 00 28 00 00 00 68 37 69 3D 4E 11 B6 2E 69 22 91 3D E4 15 BF 3D 18 37 68 3D 48 11 B4 2E 1C 22 EA 3D EC 15 B9 3D 1C 37 68 3D 33 11 BE 2E 1C 22 E1 3D 9E 15 B8 3D 1F 37 6E 3D 4E 11 C4 2E 6F 22 E6 3D 9F 15 BB 3D 17 37 13 3D 49 11 B1 2E 6B 22 92 3D 99 15 B8 3D) */;

	public Exception0()
		: base(smethod_0(859720262, 1))
	{
	}

	static Exception0()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
		char[] array_ = new char[106];
		Class9.Class10.smethod_1(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 310, 317);
		char_1 = array_;
		char[] array = new char[8];
		array[7] = '㷺';
		array[0] = '㜮';
		array[6] = 'ᗜ';
		array[4] = '≟';
		array[1] = '㴪';
		array[2] = 'ᄊ';
		array[3] = '⺆';
		array[5] = '㷓';
		string_0 = new string[9];
		char_0 = array;
	}

	internal static string smethod_0(int int_0, int int_1)
	{
		int num = int_0 ^ 0x333E4A53 ^ int_1;
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

	internal static long smethod_1(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				return Class7.smethod_4(stream_0, long_0, seekOrigin_0, 483, 393);
			}
		}
	}

	internal static void smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				Class7.smethod_5(stream_0, 676, 699);
				return;
			}
		}
	}

	internal static void smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 100:
				Class7.Class8.smethod_4(stream_0, byte_0, int_0, int_1, 1014, 950);
				return;
			case 101:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	internal static void smethod_4(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				Class9.smethod_3(appDomain_0, string_1, object_0, 369, 358);
				return;
			}
		}
	}

	internal static Stream smethod_5(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 124:
				return Class9.Class10.Class11.smethod_3(assembly_0, string_1, 628, 542);
			}
		}
	}
}
