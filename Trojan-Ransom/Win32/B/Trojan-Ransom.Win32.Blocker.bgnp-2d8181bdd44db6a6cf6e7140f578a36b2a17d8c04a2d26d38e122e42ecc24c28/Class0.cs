using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class0 : ApplicationBase
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct0
	{
		internal byte[] byte_0;

		static Struct0()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1742)]
	private struct Struct1
	{
		static Struct1()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 28 00 00 00 52 2C 9E 36 1E 2B 02 39 86 2F 93 2F 56 3F 9E 01 57 2C E9 36 1B 2B 07 39 F6 2F 92 2F 21 3F 9D 01 55 2C 96 36 6D 2B 72 39 87 2F E6 2F 23 3F EF 01 24 2C 9D 36 6E 2B 71 39 87 2F E6 2F 29 3F ED 01 25 2C E9 36 1C 2B 04 39 F6 2F 97 2F 26 3F E8 01 01 00 09 00 00 00 78 31 A9 2C DD 3E 79 28 28 28 C0 38 1C 06 AC 2B 60 31 02 00 1C 00 00 00 7D 3D 14 2F 96 39 E5 39 0B 29 A8 17 36 3A E8 20 10 3D 05 2F 8A 39 C3 39 0F 29 A5 17 12 3A 86 20 5D 3D 37 2F F3 39 C4 39 03 29 AF 17 0B 3A 9C 20 1D 3D 0C 2F 96 39 EA 39 03 00 2C 00 00 00 EE 31 68 27 0C 27 DD 37 4E 09 FE 24 77 3E E7 23 8C 31 6A 27 08 27 DA 37 14 09 E3 24 65 3E 8A 23 CF 31 7E 27 36 27 D3 37 6E 09 C3 24 0B 3E B0 23 CA 31 77 27 25 27 E8 37 69 09 EE 24 47 3E AB 23 F5 31 0A 27 08 27 D0 37 65 09 CE 24 41 3E 8B 23 8A 31 5D 27 6A 27 EB 37 04 00 08 00 00 00 CA 32 B5 32 55 22 A1 1C 14 31 D0 2B 3C 36 38 24 05 00 10 00 00 00 FB 36 04 26 BC 18 19 35 A0 2F 76 32 3A 20 E1 36 8D 36 22 26 B8 18 25 35 E7 2F 4C 32 34 20 E9 36 06 00 0B 00 00 00 27 21 C6 1F 2C 32 8B 28 05 35 18 27 9C 31 85 31 4A 21 9C 1F 4C 32 07 00 20 00 00 00 3A 00 87 2D 48 37 E8 2A 8D 38 14 2E 2A 2E B0 3E 08 00 94 2D 3A 37 C5 2A 90 38 22 2E 39 2E 92 3E 0F 00 AE 2D 40 37 C1 2A A6 38 10 2E 4D 2E 91 3E 0D 00 ED 2D 1C 37 DD 2A A6 38 2D 2E 48 2E FA 3E 08 00 24 00 00 00 E8 23 56 39 D0 24 EF 36 65 20 1A 20 83 30 63 0E DA 23 45 39 A2 24 C2 36 77 20 2F 20 CF 30 52 0E CE 23 60 39 AD 24 E9 36 41 20 5A 20 E0 30 71 0E C7 23 3C 39 D1 24 C5 36 4D 20 45 20 F1 30 42 0E EB 23 46 39 DD 24 B5 36 09 00 24 00 00 00 6D 27 9A 3A 83 28 53 3E 3F 3E E7 2E 04 10 E5 3D 5F 27 89 3A F1 28 7E 3E 65 3E C2 2E 48 10 C3 3D 5F 27 A1 3A C0 28 55 3E 05 3E CA 2E 7F 10 F4 3D 5E 27 F4 3A F5 28 42 3E 13 3E E6 2E 1B 10 D1 3D 6D 27 ED 3A 87 28 09 3E 0A 00 24 00 00 00 4F 22 37 30 95 26 B1 26 2F 36 B7 08 26 25 97 3F 77 22 23 30 BB 26 EE 26 72 36 A8 08 05 25 AB 3F 7D 22 1F 30 D2 26 C1 26 0B 36 CC 08 22 25 CB 3F 78 22 11 30 A4 26 CB 26 00 36 A9 08 27 25 BF 3F 45 22 17 30 89 26 BE 26 0B 00 20 00 00 00 73 3C F4 2A E4 2A 75 3A C4 04 67 29 86 33 2D 2E 41 3C E7 2A 96 2A 58 3A 9F 04 42 29 FC 33 1E 2E 5D 3C CD 2A E0 2A 58 3A FE 04 62 29 E5 33 0D 2E 41 3C FA 2A E5 2A 50 3A E0 04 65 29 DE 33 67 2E 0C 00 24 00 00 00 73 38 12 38 A5 28 4E 16 FE 3B 5E 21 F6 3C C2 2E 41 38 01 38 D7 28 63 16 A5 3B 68 21 E5 3C EC 2E 5D 38 24 38 A1 28 1D 16 DD 3B 63 21 F2 3C EF 2E 47 38 35 38 D3 28 7B 16 C4 3B 5F 21 84 3C F4 2E 7A 38 22 38 C0 28 7A 16 0D 00 24 00 00 00 79 3F BF 2F 72 11 98 3C 2B 26 C2 3B F5 29 2E 3F 4B 3F AC 2F 00 11 B5 3C 71 26 F7 3B B9 29 1F 3F 5F 3F 89 2F 0F 11 9E 3C 0F 26 82 3B 96 29 3C 3F 56 3F D5 2F 73 11 B2 3C 03 26 9D 3B 87 29 0F 3F 7A 3F AF 2F 7F 11 C2 3C 0E 00 1C 00 00 00 7C 38 C0 06 0C 2B E5 31 1F 2C 69 3E B1 28 8C 28 4E 38 D3 06 7E 2B C8 31 45 2C 4C 3E FD 28 B8 28 52 38 E6 06 65 2B CC 31 37 2C 72 3E F0 28 B2 28 48 38 E4 06 72 2B C5 31 0F 00 06 00 00 00 44 19 D3 34 2B 2E A0 33 CB 21 3B 37 10 00 08 00 00 00 F8 36 54 2C A8 31 8A 23 4F 35 2F 35 F7 25 44 1B 11 00 0C 00 00 00 53 29 92 34 B9 26 7B 30 0C 30 94 20 74 1E D4 33 2A 29 8E 34 D4 26 37 30 12 00 0A 00 00 00 E3 33 C4 21 34 37 23 37 97 27 48 19 A9 34 27 2E AD 33 C5 21 13 00 20 00 00 00 51 39 83 2F EE 2F 76 3F CA 01 74 2C CB 36 61 2B 05 39 D2 2F EE 2F 27 3F 98 01 20 2C CC 36 3D 2B 51 39 81 2F E2 2F 23 3F 95 01 22 2C CE 36 6F 2B 53 39 8E 2F B4 2F 22 3F 9B 01 26 2C 9D 36 6C 2B 14 00 20 00 00 00 24 C1 42 C1 DF D1 38 EF D6 C2 68 D8 CD C5 F2 D7 27 C1 10 C1 D2 D1 63 EF D3 C2 3C D8 C8 C5 A4 D7 78 C1 15 C1 83 D1 6B EF D4 C2 6D D8 CB C5 A7 D7 71 C1 18 C1 D3 D1 3E EF 82 C2 6E D8 CC C5 A2 D7 15 00 20 00 00 00 32 28 F1 38 47 06 F0 2B 49 31 EF 2C D1 3E 54 28 60 28 A6 38 4D 06 F7 2B 49 31 B8 2C DB 3E 06 28 65 28 A7 38 47 06 A7 2B 48 31 EE 2C D2 3E 54 28 34 28 A7 38 4E 06 F1 2B 4F 31 BA 2C 84 3E 07 28 16 00 20 00 00 00 19 C6 A6 F8 4B D5 F6 CF 54 D2 3C C0 BD D6 8B D6 19 C6 F5 F8 4C D5 A1 CF 04 D2 6D C0 BB D6 DA D6 19 C6 A0 F8 4F D5 F4 CF 01 D2 3A C0 E6 D6 8D D6 40 C6 F4 F8 18 D5 F1 CF 00 D2 6F C0 BA D6 8E D6 17 00 20 00 00 00 E6 13 59 3E B3 24 1C 39 75 2B FB 3D CE 3D 5D 2D B3 13 58 3E E0 24 43 39 79 2B F9 3D 98 3D 08 2D B0 13 5D 3E B0 24 14 39 7B 2B F3 3D CE 3D 5E 2D E4 13 0D 3E B6 24 11 39 7E 2B A8 3D 9B 3D 08 2D 18 00 20 00 00 00 42 C5 AA DF 5B C2 64 D0 E6 C6 82 C6 14 D6 A0 E8 45 C5 F9 DF 5A C2 34 D0 B6 C6 D6 C6 43 D6 AB E8 1C C5 FE DF 0C C2 64 D0 E7 C6 D0 C6 17 D6 A8 E8 42 C5 AC DF 55 C2 64 D0 E7 C6 86 C6 1D D6 FA E8 19 00 20 00 00 00 D4 20 75 3D 4E 2F 9A 39 F9 39 3B 29 82 17 38 3A D7 20 20 3D 14 2F 92 39 FF 39 39 29 85 17 6D 3A 8A 20 21 3D 49 2F 9F 39 FD 39 38 29 D0 17 3B 3A 8B 20 77 3D 4B 2F C8 39 FA 39 3B 29 84 17 35 3A 1A 00 20 00 00 00 38 CC 05 DE 8C C8 E1 C8 24 D8 9B E6 26 CB 98 D1 6A CC 07 DE 85 C8 B7 C8 27 D8 99 E6 20 CB 9B D1 62 CC 07 DE D7 C8 B7 C8 24 D8 98 E6 73 CB CF D1 69 CC 52 DE D0 C8 B3 C8 2A D8 9C E6 23 CB 9B D1 1B 00 20 00 00 00 E9 DD 6A CB 0C CB C9 DB 72 E5 98 C8 74 D2 8C CF ED DD 3E CB 0F CB 99 DB 75 E5 9A C8 75 D2 D1 CF E5 DD 3F CB 0A CB CA DB 71 E5 9A C8 77 D2 8D CF BC DD 6E CB 5A CB CA DB 71 E5 CF C8 77 D2 D3 CF 1C 00 20 00 00 00 80 2E B6 2E 70 3E 98 00 75 2D 9A 37 6B 2A 03 38 D5 2E E5 2E 75 3E 9B 00 23 2D 99 37 3D 2A 50 38 89 2E B4 2E 73 3E CF 00 24 2D 98 37 6F 2A 03 38 D3 2E E8 2E 25 3E 98 00 21 2D 90 37 67 2A 54 38) */;

	private static bool bool_0;

	internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = smethod_1(1216787674, 5);
		string object_ = text;
		string text2 = BabelAttribute.smethod_0(object_, '1', 486, 390);
		AppDomain appDomain_ = Class8.smethod_3(774, 841);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class22.smethod_3(appDomain_, text2, 18, 97);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Class22.smethod_4(appDomain_, text2, dictionary, 584, 581);
			Assembly assembly_ = Class18.smethod_2(645, 755);
			Stream stream = Class14.smethod_2(assembly_, text, 699, 713);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[Class10.smethod_3(stream, 497, 394) - 1L];
			int num = Class20.smethod_3(stream, 33, 82);
			Class8.smethod_4(stream, array, 0, array.Length, 277, 331);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = Class8.smethod_4(stream_, array2, 0, array2.Length, 253, 162)) > 0)
				{
					Class24.smethod_3(memoryStream, array2, 0, int_, 958, 950);
				}
			}
			assembly = Class22.smethod_5(smethod_3(memoryStream, 831, 810), null, Class20.smethod_4(assembly_, 60, 26), 480, 467);
			Class26.Class28.smethod_1(appDomain_, object_, assembly, 86, 6);
			string[] array3 = Class30.smethod_0(assembly, 372, 269);
			foreach (string text3 in array3)
			{
				dictionary[text3] = text3;
			}
		}
		else
		{
			assembly = (Assembly)Class26.smethod_2(appDomain_, object_, 850, 876);
		}
		if (dictionary.ContainsKey(Class26.Class28.smethod_4(resolveEventArgs_0, 365, 292)))
		{
			return assembly;
		}
		return null;
	}

	static Class0()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		smethod_6();
		char[] array_ = new char[871];
		Class26.smethod_11(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 339, 274);
		char_1 = array_;
		char[] array = new char[8];
		array[6] = '㼐';
		array[7] = 'Ƭ';
		array[3] = '㤰';
		array[1] = '㚯';
		array[2] = '⭘';
		array[4] = '⾷';
		array[0] = 'Ⱁ';
		array[5] = '\u2fd6';
		string_0 = new string[29];
		char_0 = array;
	}

	internal static string smethod_1(int int_0, int int_1)
	{
		int num = int_0 ^ 0x4886B4DF ^ int_1;
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

	internal static byte[] smethod_2(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				return Class26.Class29.smethod_11(string_1, 381, 346);
			}
		}
	}

	internal static byte[] smethod_3(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				return Class30.smethod_7(memoryStream_0, 863, 819);
			}
		}
	}

	internal static int smethod_4(ref IntPtr intptr_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 9:
				return Class26.Class29.smethod_13(ref intptr_0, 948, 927);
			}
		}
	}

	internal static object smethod_5(ResourceManager resourceManager_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return Class26.Class28.smethod_7(resourceManager_0, string_1, 297, 314);
			}
		}
	}

	internal static void smethod_6()
	{
		if (bool_0)
		{
			return;
		}
		Type object_;
		Class30.smethod_8(object_ = Class26.smethod_9(typeof(Class0).TypeHandle, 610, 622), 519, 540);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class26.Class29.smethod_14(Class26.smethod_1(422, 483), smethod_0, 669, 740);
			}
		}
		finally
		{
			Class30.smethod_10(object_, 817, 855);
		}
	}
}
