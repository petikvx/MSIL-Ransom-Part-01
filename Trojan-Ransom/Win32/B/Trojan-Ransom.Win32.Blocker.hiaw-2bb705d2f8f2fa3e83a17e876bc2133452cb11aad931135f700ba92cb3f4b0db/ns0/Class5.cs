using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6
	{
		private static bool bool_0;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = Class5.smethod_6(2126288540, 8);
			string text2 = text;
			string string_ = Class7.smethod_8(text2, '1', 298, 315);
			AppDomain appDomain_ = Class5.smethod_7(781, 870);
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class8.smethod_7(appDomain_, string_, 221, 253);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				Class8.Class9.smethod_8(appDomain_, string_, dictionary, 704, 737);
				Assembly assembly_ = Class8.Class9.smethod_9(365, 360);
				Stream stream = smethod_8(assembly_, text, 357, 361);
				if (stream == null)
				{
					return null;
				}
				byte[] array = new byte[Class8.Class9.smethod_10(stream, 62, 30) - 1L];
				int num = Class8.smethod_8(stream, 112, 16);
				Class8.smethod_9(stream, array, 0, array.Length, 421, 420);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_;
					while ((int_ = Class8.smethod_9(stream_, array2, 0, array2.Length, 240, 242)) > 0)
					{
						smethod_9(memoryStream, array2, 0, int_, 797, 784);
					}
				}
				assembly = Class8.smethod_10(Class8.Class9.smethod_11(memoryStream, 597, 522), null, smethod_10(assembly_, 483, 392), 11, 103);
				Class10.Class11.smethod_0(appDomain_, text2, assembly, 523, 623);
				string[] array3 = Class10.Class11.Class12.smethod_3(assembly, 504, 385);
				foreach (string text3 in array3)
				{
					dictionary[text3] = text3;
				}
			}
			else
			{
				assembly = (Assembly)Class13.smethod_1(appDomain_, text2, 633, 539);
			}
			if (dictionary.ContainsKey(Class10.smethod_5(resolveEventArgs_0, 801, 849)))
			{
				return assembly;
			}
			return null;
		}

		internal static Assembly smethod_1(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 99:
					return Class13.Class14.smethod_6(byte_0, 526, 631);
				}
			}
		}

		internal static string smethod_2(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Class13.Class14.smethod_0(object_0, object_1, 568, 569);
				}
			}
		}

		internal static byte[] smethod_3(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return Class10.smethod_3(memoryStream_0, 353, 283);
				}
			}
		}

		internal static int smethod_4(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					return Class13.smethod_2(stream_0, 7, 28);
				}
			}
		}

		internal static Evidence smethod_5(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return Class13.smethod_4(assembly_0, 329, 299);
				}
			}
		}

		internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return Class10.Class11.smethod_4(runtimeTypeHandle_0, 838, 848);
				}
			}
		}

		internal static void smethod_7()
		{
			if (bool_0)
			{
				return;
			}
			Type object_;
			Class13.smethod_7(object_ = Class10.Class11.smethod_4(typeof(Class6).TypeHandle, 999, 1009), 840, 849);
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					Class13.Class14.smethod_7(Class13.smethod_0(49, 77), smethod_0, 757, 697);
				}
			}
			finally
			{
				Class13.smethod_7(object_, 431, 437);
			}
		}

		static Class6()
		{
			Class15.smethod_6();
			Class10.smethod_7();
		}
	}

	internal sealed class Class7
	{
		internal static string smethod_0(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 11:
					return Class10.Class11.smethod_5(specialFolder_0, 251, 250);
				}
			}
		}

		internal static void smethod_1(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					Class10.Class11.smethod_0(appDomain_0, string_0, object_0, 646, 738);
					return;
				}
			}
		}

		internal static MethodInfo[] smethod_2(Type type_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 55:
					return Class13.smethod_8(type_0, 772, 799);
				}
			}
		}

		internal static Assembly smethod_3(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					return Class10.Class11.Class12.smethod_0(470, 385);
				}
			}
		}

		internal static string smethod_4(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return Class13.Class14.smethod_8(string_0, string_1, 917, 913);
				}
			}
		}

		internal static string[] smethod_5(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					return Class10.Class11.Class12.smethod_3(assembly_0, 136, 241);
				}
			}
		}

		internal static string smethod_6(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 59:
					return Class10.smethod_6(assembly_0, 283, 319);
				}
			}
		}

		internal static void smethod_7(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					Class13.smethod_7(object_0, 717, 724);
					return;
				case 44:
					Monitor.Exit(object_0);
					return;
				}
			}
		}

		internal static string smethod_8(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 17:
					return Class13.Class14.smethod_0(object_0, object_1, 487, 486);
				}
			}
		}

		static Class7()
		{
			Class15.smethod_6();
			Class10.smethod_7();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct1
	{
		static Struct1()
		{
			Class15.smethod_6();
			Class10.smethod_7();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 28 00 00 00 B4 0A 8D 17 D4 09 EC 02 CF 27 0F 22 76 22 E2 22 B0 0A 8F 17 D1 09 EC 02 CC 27 05 22 72 22 E5 22 C4 0A 8D 17 A4 09 ED 02 C3 27 7B 22 06 22 92 22 C3 0A 8B 17 D4 09 EF 02 C8 27 08 22 03 22 E7 22 C0 0A FC 17 DE 09 99 02 CF 27 7C 22 74 22 95 22) */;

	static Class5()
	{
		Class15.smethod_6();
		Class10.smethod_7();
		char[] array_ = new char[43];
		Class13.Class14.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 913, 1023);
		char_1 = array_;
		char[] array = new char[8];
		array[1] = '\u17b8';
		array[5] = '∽';
		array[7] = '⋐';
		array[2] = '০';
		array[0] = 'આ';
		array[4] = '⟻';
		array[3] = 'ʩ';
		array[6] = '∷';
		string_0 = new string[1];
		char_0 = array;
		Class6.smethod_7();
	}

	internal static object smethod_0(AppDomain appDomain_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 87:
				return Class13.smethod_1(appDomain_0, string_1, 0, 98);
			}
		}
	}

	internal static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 105:
				return Class13.Class14.smethod_1(stream_0, byte_0, int_0, int_1, 944, 995);
			}
		}
	}

	internal static Assembly smethod_2(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 83:
				return Class10.Class11.Class12.smethod_1(byte_0, byte_1, evidence_0, 650, 716);
			}
		}
	}

	internal static void smethod_3(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				Class13.Class14.smethod_9(resourceManager_0, 952, 908);
				return;
			}
		}
	}

	internal static object smethod_4(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return Class10.Class11.Class12.smethod_4(methodBase_0, object_0, object_1, 74, 82);
			}
		}
	}

	internal static void smethod_5(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				Class13.Class14.smethod_7(appDomain_0, resolveEventHandler_0, 767, 691);
				return;
			}
		}
	}

	internal static string smethod_6(int int_0, int int_1)
	{
		int num = int_0 ^ 0x7EBC9694 ^ int_1;
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

	internal static AppDomain smethod_7(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return Class13.smethod_0(274, 366);
			}
		}
	}

	internal static Stream smethod_8(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return Class10.smethod_2(assembly_0, string_1, 393, 429);
			}
		}
	}

	internal static void smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 13:
				Class13.smethod_3(stream_0, byte_0, int_0, int_1, 136, 238);
				return;
			}
		}
	}

	internal static Evidence smethod_10(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return Class13.smethod_4(assembly_0, 80, 50);
			}
		}
	}
}
