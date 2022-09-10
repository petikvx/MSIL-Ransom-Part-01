using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class10
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct2
	{
		static Struct2()
		{
			Class15.smethod_6();
		}
	}

	internal sealed class Class11
	{
		internal sealed class Class12
		{
			internal static Assembly smethod_0(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 86:
						return Class15.Class17.smethod_0(61, 22);
					case 87:
						return Class15.Class17.smethod_0(652, 679);
					}
				}
			}

			internal static Assembly smethod_1(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 69:
						return Class15.Class17.smethod_3(byte_0, byte_1, evidence_0, 702, 767);
					case 70:
						return Class15.Class17.smethod_3(byte_0, byte_1, evidence_0, 102, 39);
					}
				}
			}

			internal static Encoding smethod_2(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 2:
						return Class15.Class17.smethod_7(632, 534);
					case 3:
						return Class15.Class17.smethod_7(361, 262);
					}
				}
			}

			internal static string[] smethod_3(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 121:
						return Class18.Class19.smethod_3(assembly_0, 399, 413);
					}
				}
			}

			internal static object smethod_4(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 24:
						return Class18.smethod_7(methodBase_0, object_0, object_1, 874, 885);
					}
				}
			}

			static Class12()
			{
				Class15.smethod_6();
			}
		}

		internal static void smethod_0(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 99:
					appDomain_0.SetData(string_0, object_0);
					return;
				case 100:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
			}
		}

		internal static long smethod_1(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 69:
					return Class15.Class16.smethod_1(stream_0, 479, 491);
				case 70:
					return Class15.Class16.smethod_1(stream_0, 145, 165);
				}
			}
		}

		internal static byte[] smethod_2(Encoding encoding_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					return Class18.smethod_8(encoding_0, string_0, 36, 43);
				}
			}
		}

		internal static string smethod_3(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 7:
					return Class15.Class17.smethod_8(object_0, 426, 510);
				}
			}
		}

		internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 22:
					return Class15.Class16.smethod_4(runtimeTypeHandle_0, 702, 753);
				}
			}
		}

		internal static string smethod_5(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					return Class15.smethod_5(specialFolder_0, 878, 844);
				}
			}
		}

		static Class11()
		{
			Class15.smethod_6();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct2 struct2_0/* Not supported: data(00 00 28 00 00 00 EE 3B 75 26 C2 29 3A 33 61 26 9A 23 AA 01 4D 01 E8 3B 07 26 C7 29 46 33 66 26 EF 23 DF 01 4C 01 98 3B 75 26 C6 29 32 33 14 26 E8 23 AF 01 3F 01 94 3B 07 26 B4 29 43 33 64 26 E7 23 A8 01 3E 01 9E 3B 06 26 C1 29 32 33 1E 26 E8 23 AA 01 39 01) */;

	private static bool bool_0;

	internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = smethod_1(667174546, 5);
		string text2 = text;
		string text3 = Class13.Class14.smethod_0(text2, '1', 49, 49);
		AppDomain appDomain = Class13.smethod_0(687, 724);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class13.smethod_1(appDomain, text3, 820, 853);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Class11.smethod_0(appDomain, text3, dictionary, 259, 352);
			Assembly assembly_ = Class11.Class12.smethod_0(812, 890);
			Stream stream = smethod_2(assembly_, text, 165, 134);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[Class11.smethod_1(stream, 392, 461) - 1L];
			int num = Class13.smethod_2(stream, 117, 111);
			Class13.Class14.smethod_1(stream, array, 0, array.Length, 321, 272);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = Class13.Class14.smethod_1(stream_, array2, 0, array2.Length, 15, 93)) > 0)
				{
					Class13.smethod_3(memoryStream, array2, 0, int_, 537, 636);
				}
			}
			assembly = Class11.Class12.smethod_1(smethod_3(memoryStream, 755, 650), null, Class13.smethod_4(assembly_, 352, 257), 566, 627);
			appDomain.SetData(text2, assembly);
			string[] array3 = Class18.Class19.smethod_3(assembly, 675, 689);
			foreach (string text4 in array3)
			{
				dictionary[text4] = text4;
			}
		}
		else
		{
			assembly = (Assembly)Class18.Class19.smethod_0(appDomain, text2, 935, 941);
		}
		if (dictionary.ContainsKey(Class15.Class16.smethod_5(resolveEventArgs_0, 546, 547)))
		{
			return assembly;
		}
		return null;
	}

	static Class10()
	{
		Class15.smethod_6();
		smethod_7();
		char[] array_ = new char[43];
		Class15.Class16.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 698, 694);
		char_1 = array_;
		char[] array = new char[8];
		array[1] = '☶';
		array[4] = '☧';
		array[7] = 'ź';
		array[6] = 'Ǭ';
		array[0] = '㮬';
		array[3] = '㌂';
		array[5] = '⏟';
		array[2] = '⧲';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static string smethod_1(int int_0, int int_1)
	{
		int num = int_0 ^ 0x27C44697 ^ int_1;
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

	internal static Stream smethod_2(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return Class15.Class17.smethod_1(assembly_0, string_1, 681, 714);
			case 36:
				return Class15.Class17.smethod_1(assembly_0, string_1, 542, 637);
			}
		}
	}

	internal static byte[] smethod_3(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return Class15.Class16.smethod_2(memoryStream_0, 464, 409);
			case 122:
				return Class15.Class16.smethod_2(memoryStream_0, 979, 922);
			}
		}
	}

	internal static Type[] smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 105:
				return Class15.Class17.smethod_9(assembly_0, 235, 255);
			}
		}
	}

	internal static string smethod_5(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				return Class15.Class16.smethod_5(resolveEventArgs_0, 575, 574);
			}
		}
	}

	internal static string smethod_6(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return Class15.Class16.smethod_6(assembly_0, 476, 493);
			}
		}
	}

	internal static void smethod_7()
	{
		if (bool_0)
		{
			return;
		}
		Type obj;
		Class18.smethod_6(obj = Class15.Class16.smethod_4(typeof(Class10).TypeHandle, 32, 111), 603, 535);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class15.Class17.smethod_5(Class15.Class16.smethod_0(246, 181), smethod_0, 30, 35);
			}
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}
}
