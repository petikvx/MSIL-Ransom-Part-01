using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns3;

namespace ns2;

internal sealed class Class3
{
	private sealed class Class4
	{
		public static readonly Class4 class4_0;

		private Class0.Struct0 struct0_0;

		static Class4()
		{
			Class0.Class1.smethod_5();
			if (Class0.smethod_0(Class0.Class2.smethod_0(66, 49), new DateTime(635540974809372639L), 769, 887))
			{
				throw new Exception();
			}
			class4_0 = new Class4();
		}

		private Class4()
		{
			Assembly assembly_ = Class0.smethod_1(565, 578);
			Stream stream = Class0.Class1.smethod_0(assembly_, smethod_1(), 599, 516);
			if (stream != null)
			{
				byte[] byte_ = new byte[256];
				struct0_0.byte_0 = byte_;
				Class5.Class6.smethod_0(stream, struct0_0.byte_0, 0, struct0_0.byte_0.Length, 868, 857);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Attribute0.smethod_0(string_0, 861, 820);
			int num2 = int_0 & 0xFF;
			char[] array = Class0.Class2.smethod_1(string_0, 9, 119);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (struct0_0.byte_0[num2] | int_0));
			}
			return Class5.Class6.Class7.smethod_0(new string(array), 374, 325);
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 562982)]
	private struct Struct2
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 206)]
	private struct Struct3
	{
	}


	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct3 struct3_0/* Not supported: data(00 00 05 00 00 00 0B D9 4B F8 E2 D2 02 DB B4 C9 01 00 05 00 00 00 16 FA F9 D0 4F D9 F9 CB FE F7 02 00 04 00 00 00 C2 DE 3F D7 8D C5 9B F9 03 00 06 00 00 00 E4 DA 33 C8 27 F4 0D D4 9D C8 9F D8 04 00 06 00 00 00 F4 C8 92 F4 E3 D4 2A C8 22 D8 3E F9 05 00 06 00 00 00 F7 E1 F4 C1 61 DD 3F CD 7D EC 93 C6 06 00 06 00 00 00 18 C1 FC DD F5 CD E6 EC 16 C6 EF CF 07 00 06 00 00 00 20 CE 5B DE 18 FF A0 D5 51 DC F6 CE 08 00 20 00 00 00 B4 39 EA 18 1C 32 F1 3B 48 29 43 15 7C 35 A2 29 B0 39 EF 18 4C 32 FD 3B 4B 29 17 15 7C 35 A5 29 BD 39 EF 18 4C 32 A7 3B 1B 29 41 15 79 35 A0 29 E0 39 E8 18 10 32 F5 3B 4D 29 10 15 2D 35 A1 29) */;

	public static string smethod_0(string string_1, int int_0)
	{
		if (Class0.smethod_0(Class0.Class2.smethod_0(186, 201), new DateTime(635540974810283233L), 638, 520))
		{
			throw new Exception();
		}
		return Class5.Class6.Class7.smethod_0(Class4.class4_0.method_0(string_1, int_0), 590, 637);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return smethod_4(67521218, 8);
	}

	static Class3()
	{
		Class0.Class1.smethod_5();
		char[] array_ = new char[103];
		Class10.Class11.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 950, 956);
		char_1 = array_;
		char[] array = new char[8];
		array[1] = 'ᣚ';
		array[5] = 'ᕴ';
		array[6] = '㔚';
		array[0] = '㦅';
		array[4] = '⥿';
		array[2] = '㈩';
		array[7] = '⦐';
		array[3] = '㯅';
		string_0 = new string[9];
		char_0 = array;
	}

	internal static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_3(resolveEventArgs_0, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 562982, Class10.smethod_0(765465988, 0), 240);
	}

	internal static Assembly smethod_3(ResolveEventArgs resolveEventArgs_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, string string_1, int int_1)
	{
		if (int_0 > 0)
		{
			Assembly assembly_ = Class0.Class2.smethod_5(845, 885);
			string text = smethod_6(string_1, Class0.smethod_2(67521165, 3), 117, 80);
			AppDomain appDomain_ = Class0.Class1.smethod_6(443, 509);
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class0.Class2.smethod_6(appDomain_, string_1, 268, 313);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				Class0.Class2.smethod_7(appDomain_, string_1, dictionary, 128, 249);
				byte[] array = new byte[int_0];
				Attribute0.smethod_1(array, runtimeFieldHandle_0, 102, 77);
				for (int i = 0; i < int_0; i++)
				{
					array[i] ^= (byte)((i + int_1) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_2;
					while ((int_2 = Class0.smethod_3(stream_, array2, 0, array2.Length, 927, 967)) > 0)
					{
						smethod_7(memoryStream, array2, 0, int_2, 914, 896);
					}
				}
				assembly = Class0.smethod_4(Class0.Class2.smethod_8(memoryStream, 78, 110), null, Class0.Class1.smethod_7(assembly_, 979, 977), 795, 786);
				Class0.Class2.smethod_7(appDomain_, text, assembly, 390, 508);
				string[] array3 = smethod_8(assembly, 549, 544);
				foreach (string text2 in array3)
				{
					dictionary[text2] = text2;
				}
			}
			else
			{
				assembly = (Assembly)Class10.Class11.smethod_1(appDomain_, text, 343, 354);
			}
			if (dictionary.ContainsKey(Class5.Class6.Class7.smethod_1(resolveEventArgs_0, 152, 219)))
			{
				return assembly;
			}
		}
		return null;
	}

	internal static string smethod_4(int int_0, int int_1)
	{
		int num = int_0 ^ 0x4064A8E ^ int_1;
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

	internal static string smethod_5(string string_1, string string_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return Class10.Class11.smethod_2(string_1, string_2, 907, 991);
			}
		}
	}

	internal static string smethod_6(string string_1, string string_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				return Class10.Class11.smethod_2(string_1, string_2, 123, 47);
			}
		}
	}

	internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 18:
				Class10.smethod_1(stream_0, byte_0, int_0, int_1, 143, 152);
				return;
			}
		}
	}

	internal static string[] smethod_8(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				return Class5.smethod_0(assembly_0, 540, 590);
			}
		}
	}
}