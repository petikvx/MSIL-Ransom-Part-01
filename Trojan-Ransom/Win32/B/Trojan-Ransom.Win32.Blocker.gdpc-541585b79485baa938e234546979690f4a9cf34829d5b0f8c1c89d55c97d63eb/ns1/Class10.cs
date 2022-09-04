using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using ns3;

namespace ns1;

internal sealed class Class10
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct4
	{
	}

	internal sealed class Class11
	{
		internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					Class5.smethod_5(array_0, runtimeFieldHandle_0, 841, 787);
					return;
				}
			}
		}

		internal static object smethod_1(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					return Class5.Class6.smethod_6(appDomain_0, string_0, 133, 191);
				}
			}
		}

		internal static string smethod_2(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 84:
					return Class5.Class6.Class7.smethod_5(string_0, string_1, 448, 475);
				}
			}
		}

		internal static DateTime smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return Class5.Class6.Class8.smethod_0(309, 374);
				}
			}
		}

		internal static Assembly smethod_4(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					return Class5.Class6.Class8.smethod_1(157, 173);
				}
			}
		}

		internal static void smethod_5(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 107:
					Class5.Class6.Class7.smethod_6(process_0, 915, 949);
					return;
				}
			}
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct4 struct4_0/* Not supported: data(00 00 24 00 00 00 16 1D FF 21 AB 27 E3 01 97 21 7E 2E 29 37 BC 0E 0F 1D F1 21 A8 27 BB 01 C9 21 60 2E 78 37 BE 0E 15 1D AE 21 B4 27 E2 01 C2 21 2B 2E 7D 37 F7 0E 10 1D FD 21 A8 27 BF 01 94 21 2C 2E 75 37 EE 0E 47 1D AA 21 AB 27 BB 01) */;

	static Class10()
	{
		char[] array_ = new char[39];
		Class5.smethod_5(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 253, 167);
		char_1 = array_;
		char[] array = new char[8];
		array[2] = '➙';
		array[6] = '㝌';
		array[5] = '⹍';
		array[0] = 'ᴢ';
		array[1] = '⇈';
		array[3] = 'ǚ';
		array[4] = '⇱';
		array[7] = '\u0eda';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static string smethod_0(int int_0, int int_1)
	{
		int num = int_0 ^ 0x2DA01584 ^ int_1;
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

	internal static void smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 23:
				Class5.Class6.smethod_7(stream_0, byte_0, int_0, int_1, 908, 896);
				return;
			}
		}
	}

	internal static void smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				Class5.smethod_6(stream_0, 816, 883);
				return;
			}
		}
	}

	internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				return Class5.smethod_7(runtimeTypeHandle_0, 672, 722);
			}
		}
	}

	internal static char[] smethod_4(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return Class5.Class6.Class8.smethod_3(string_1, 442, 508);
			}
		}
	}

	internal static long smethod_5(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 53:
				return Class5.Class6.Class8.smethod_4(stream_0, 5, 64);
			}
		}
	}

	internal static byte[] smethod_6(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return Class5.Class6.smethod_9(memoryStream_0, 926, 953);
			}
		}
	}

	internal static void smethod_7(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				Class5.Class6.smethod_8(processStartInfo_0, processWindowStyle_0, 13, 33);
				return;
			}
		}
	}
}
