using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		internal static void smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 8:
					Class5.smethod_8(stream_0, byte_0, int_0, int_1, 309, 304);
					return;
				}
			}
		}

		internal static int smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return Class5.Class6.Class7.smethod_0(79, 106);
				}
			}
		}

		internal static bool smethod_2(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return Class5.Class9.smethod_0(string_0, 91, 46);
				}
			}
		}

		internal static byte[] smethod_3(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return Class5.Class9.smethod_1(memoryStream_0, 842, 784);
				}
			}
		}

		internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 100:
					return Class5.Class6.Class7.smethod_1(byte_0, byte_1, evidence_0, 635, 547);
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct3
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct3 struct3_0/* Not supported: data(00 00 24 00 00 00 D8 1A 01 11 44 2D E7 2A 64 0A F7 07 69 27 65 05 C5 1A 07 11 12 2D B3 2A 31 0A EA 07 6B 27 60 05 8E 1A 02 11 0C 2D EE 2A 6D 0A F3 07 3D 27 2C 05 DE 1A 04 11 43 2D E7 2A 35 0A F7 07 6A 27 30 05 DA 1A 04 11 18 2D E4 2A) */;

	static Class10()
	{
		char[] array_ = new char[39];
		Class5.Class6.smethod_9(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 710, 716);
		char_1 = array_;
		char[] array = new char[8];
		array[1] = 'ᄲ';
		array[5] = '߇';
		array[2] = 'ⴡ';
		array[3] = '⫗';
		array[0] = '\u1ae8';
		array[4] = '\u0a54';
		array[6] = '❟';
		array[7] = 'ԁ';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static int smethod_0(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 57:
				return Class5.Class6.Class7.smethod_2(array_0, int_0, 104, 60);
			}
		}
	}

	internal static void smethod_1(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				Class5.Class9.smethod_2(appDomain_0, resolveEventHandler_0, 354, 304);
				return;
			}
		}
	}

	internal static string smethod_2(int int_0, int int_1)
	{
		int num = int_0 ^ 0x2257AB87 ^ int_1;
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

	internal static Encoding smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 0:
				return Class5.smethod_9(380, 307);
			}
		}
	}

	internal static void smethod_4(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				Class5.Class9.smethod_3(appDomain_0, string_1, object_0, 126, 5);
				return;
			}
		}
	}

	internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 82:
				return Class5.Class6.Class7.smethod_3(stream_0, byte_0, int_0, int_1, 803, 841);
			}
		}
	}
}
