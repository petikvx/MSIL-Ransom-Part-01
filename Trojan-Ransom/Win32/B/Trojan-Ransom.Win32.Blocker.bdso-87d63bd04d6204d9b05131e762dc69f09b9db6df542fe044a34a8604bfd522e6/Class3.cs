using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;

internal sealed class Class3
{
	internal sealed class Class4
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
		private struct Struct0
		{
			static Struct0()
			{
				Class15.Class16.smethod_7();
				Class10.Class11.Class12.smethod_3();
				Class5.Class6.smethod_6();
			}
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static Struct0 struct0_0/* Not supported: data(00 00 3D 00 00 00 B8 1A 35 1D CA 0A 32 21 F9 3A AA 01 ED 17 5D 2D BD 1A 35 1D CA 0A 37 21 F5 3A B7 01 AF 17 40 2D FB 1A 7E 1D 88 0A 6A 21 AC 3A F6 01 F1 17 51 2D EB 1A 33 1D CD 0A 28 21 E8 3A AD 01 B3 17 18 2D F6 1A 3E 1D DD 0A 31 21 E8 3A AA 01 A0 17 11 2D E7 1A 70 1D C8 0A 31 21 FE 3A B4 01 A8 17 1E 2D A0 1A 35 1D C1 0A 30 21 F3 3A B3 01 A4 17 13 2D F6 1A 3E 1D CD 0A 28 21 F0 3A) */;

		private static bool bool_0;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = Class3.smethod_2(767841101, 1);
			string text2 = text;
			string text3 = Class0.Class2.smethod_2(text2, '1', 251, 133);
			AppDomain appDomain_ = Class0.Class2.smethod_3(723, 733);
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class0.smethod_5(appDomain_, text3, 950, 1023);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				Class0.Class2.smethod_4(appDomain_, text3, dictionary, 612, 573);
				Assembly assembly_ = Class0.smethod_6(418, 424);
				Stream stream = Class0.smethod_7(assembly_, text, 510, 391);
				if (stream == null)
				{
					return null;
				}
				byte[] array = new byte[Class0.smethod_8(stream, 215, 202) - 1L];
				int num = Class0.Class1.smethod_1(stream, 788, 783);
				Class0.Class2.smethod_5(stream, array, 0, array.Length, 136, 244);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_;
					while ((int_ = Class0.Class2.smethod_5(stream_, array2, 0, array2.Length, 719, 690)) > 0)
					{
						Class3.smethod_3((Stream)memoryStream, array2, 0, int_, 580, 528);
					}
				}
				assembly = Class3.smethod_4(smethod_4(memoryStream, 439, 409), (byte[])null, Class0.smethod_9(assembly_, 1016, 946), 879, 887);
				Class5.smethod_0(appDomain_, text2, assembly, 411, 418);
				string[] array3 = Class9.smethod_0(assembly, 222, 243);
				foreach (string text4 in array3)
				{
					dictionary[text4] = text4;
				}
			}
			else
			{
				assembly = (Assembly)Class5.smethod_1(appDomain_, text2, 893, 879);
			}
			if (dictionary.ContainsKey(Class5.smethod_2(resolveEventArgs_0, 920, 912)))
			{
				return assembly;
			}
			return null;
		}

		static Class4()
		{
			if (DateTime.Now > new DateTime(635043833219990234L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
			if (Class15.Class16.smethod_1(Class19.smethod_0(464, 423), new DateTime(635043577566591796L), 1003, 967))
			{
				throw new Exception();
			}
			if (Class15.Class16.smethod_1(Class19.smethod_0(662, 737), new DateTime(635043824442119140L), 858, 886))
			{
				throw new Exception();
			}
			Class10.Class11.Class12.smethod_3();
			Class5.Class6.smethod_6();
			char[] array_ = new char[64];
			Class5.Class6.smethod_1(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 726, 732);
			char_1 = array_;
			char[] array = new char[8];
			array[3] = '⅄';
			array[0] = '\u1acb';
			array[5] = 'ǘ';
			array[6] = '\u17c1';
			array[2] = 'સ';
			array[7] = '\u2d7d';
			array[4] = '㪜';
			array[1] = 'ᵐ';
			string_0 = new string[1];
			char_0 = array;
		}

		internal static string smethod_1(int int_0, int int_1)
		{
			int num = int_0 ^ 0x2DC4534C ^ int_1;
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

		internal static string smethod_2(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					return Class5.smethod_2(resolveEventArgs_0, 735, 727);
				}
			}
		}

		internal static void smethod_3()
		{
			if (bool_0)
			{
				return;
			}
			Type object_;
			Class5.Class8.smethod_0(object_ = Class5.Class7.smethod_0(typeof(Class4).TypeHandle, 182, 155), 161, 135);
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					Class5.Class6.smethod_2(Class5.smethod_3(613, 512), smethod_0, 375, 371);
				}
			}
			finally
			{
				Class5.Class8.smethod_0(object_, 896, 935);
			}
		}

		internal static byte[] smethod_4(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return Class5.smethod_4(memoryStream_0, 997, 927);
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct1
	{
		static Struct1()
		{
			Class15.Class16.smethod_7();
			Class10.Class11.Class12.smethod_3();
			Class5.Class6.smethod_6();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 28 00 00 00 22 2F DF 12 90 1C BC 39 CC 3D A8 31 A6 13 6B 0F 5C 2F DE 12 90 1C C8 39 BB 3D DF 31 D5 13 1E 0F 28 2F D0 12 90 1C B2 39 CD 3D DB 31 D2 13 69 0F 59 2F A3 12 93 1C B3 39 BF 3D AC 31 D0 13 1B 0F 5E 2F DF 12 E2 1C CB 39 BE 3D DB 31 D6 13 6D 0F) */;

	static Class3()
	{
		if (DateTime.Now > new DateTime(635043833219951171L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(468, 419), new DateTime(635043577566562500L), 79, 99))
		{
			throw new Exception();
		}
		if (Class15.Class16.smethod_1(Class19.smethod_0(730, 685), new DateTime(635043824442080078L), 1015, 987))
		{
			throw new Exception();
		}
		Class10.Class11.Class12.smethod_3();
		Class5.Class6.smethod_6();
		char[] array_ = new char[43];
		Class5.Class6.smethod_1(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 582, 588);
		char_1 = array_;
		char[] array = new char[8];
		array[5] = '\u31ee';
		array[6] = 'Ꮰ';
		array[3] = '㦊';
		array[7] = '༨';
		array[0] = '⼚';
		array[4] = '㶏';
		array[2] = '\u1cd6';
		array[1] = 'ዦ';
		string_0 = new string[1];
		char_0 = array;
		Class4.smethod_3();
	}

	internal static Stream smethod_0(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Class5.smethod_5(assembly_0, string_1, 175, 201);
			}
		}
	}

	internal static byte[] smethod_1(BinaryReader binaryReader_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 46:
				return Class5.smethod_6(binaryReader_0, int_0, 959, 929);
			}
		}
	}

	internal static string smethod_2(int int_0, int int_1)
	{
		int num = int_0 ^ 0x2DC4534C ^ int_1;
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

	internal static void smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 84:
				Class5.Class8.smethod_1(stream_0, byte_0, int_0, int_1, 456, 510);
				return;
			}
		}
	}

	internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return Class5.Class8.smethod_2(byte_0, byte_1, evidence_0, 439, 462);
			}
		}
	}
}
