using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class31
{
	internal sealed class Class32
	{
		internal sealed class Class33
		{
			internal static byte smethod_0(ref Color color_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 116:
						return Class36.Class38.smethod_0(ref color_0, 91, 41);
					case 117:
						return color_0.B;
					}
				}
			}

			internal static DateTime smethod_1(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 35:
						return Class39.Class40.smethod_0(106, 81);
					}
				}
			}

			internal static byte[] smethod_2(MemoryStream memoryStream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 29:
						return Class39.Class40.smethod_1(memoryStream_0, 512, 633);
					}
				}
			}

			internal static ParameterInfo[] smethod_3(MethodBase methodBase_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 67:
						return Class36.Class37.smethod_2(methodBase_0, 111, 29);
					}
				}
			}

			internal static string smethod_4(char char_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 16:
						return Class39.smethod_4(char_0, 893, 865);
					}
				}
			}

			internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 91:
						return Class39.smethod_5(string_0, string_1, 599, 592);
					}
				}
			}

			internal static Assembly smethod_6(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 7:
						return Class39.smethod_6(byte_0, byte_1, evidence_0, 885, 893);
					}
				}
			}

			internal static bool smethod_7(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 69:
						return Class36.smethod_3(string_0, 339, 339);
					}
				}
			}

			internal static string smethod_8(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 83:
						return Class36.smethod_4(resolveEventArgs_0, 868, 816);
					}
				}
			}

			internal static short smethod_9(byte[] byte_0, int int_0, int int_1, int int_2)
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 0:
						return Class36.Class37.smethod_3(byte_0, int_0, 697, 649);
					}
				}
			}

			internal static string smethod_10(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 106:
						return Class36.Class37.smethod_4(string_0, 543, 538);
					}
				}
			}

			internal static Color smethod_11(int int_0, int int_1, int int_2)
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 59:
						return Class36.smethod_5(int_0, 284, 316);
					}
				}
			}

			internal static object smethod_12(object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 4:
						return Class39.smethod_7(object_0, 727, 755);
					}
				}
			}

			internal static void smethod_13(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 115:
						Class39.Class40.smethod_2(appDomain_0, resolveEventHandler_0, 728, 651);
						return;
					}
				}
			}

			internal static char[] smethod_14(string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 39:
						return Class36.Class37.smethod_5(string_0, 477, 452);
					}
				}
			}

			internal static decimal smethod_15(decimal decimal_0, decimal decimal_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 118:
						return Class36.Class37.smethod_6(decimal_0, decimal_1, 636, 542);
					}
				}
			}

			internal static string smethod_16(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 88:
						return Class36.Class38.smethod_1(868, 832);
					}
				}
			}

			internal static int smethod_17(Stream stream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 71:
						return Class39.smethod_8(stream_0, 162, 207);
					}
				}
			}

			internal static int smethod_18(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 127:
						return Class36.Class37.smethod_7(stream_0, byte_0, int_0, int_1, 579, 570);
					}
				}
			}

			static Class33()
			{
				Class36.Class37.smethod_15();
			}
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
		private struct Struct12
		{
			static Struct12()
			{
				Class36.Class37.smethod_15();
			}
		}

		private static bool bool_0;

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static Struct12 struct12_0/* Not supported: data(00 00 28 00 00 00 C3 39 53 03 B8 1E BA 36 BE 06 61 3C 29 12 9B 29 B3 39 53 03 BA 1E BD 36 BB 06 65 3C 59 12 9E 29 B6 39 53 03 CB 1E CE 36 B9 06 65 3C 5F 12 EC 29 C0 39 28 03 B8 1E CA 36 B8 06 67 3C 5D 12 9B 29 C3 39 2F 03 BD 1E C1 36 CB 06 61 3C 59 12 9C 29) */;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = smethod_13(696253856, 3);
			string object_ = text;
			string text2 = Class34.smethod_13(object_, '1', 451, 456);
			AppDomain appDomain_ = Class31.smethod_9(105, 102);
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class34.Class35.smethod_13(appDomain_, text2, 104, 94);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				Class31.smethod_10(appDomain_, text2, (object)dictionary, 718, 660);
				Assembly assembly_ = Class34.smethod_14(833, 809);
				Stream stream = Class34.smethod_15(assembly_, text, 529, 549);
				if (stream == null)
				{
					return null;
				}
				byte[] array = new byte[Class31.smethod_11(stream, 986, 955) - 1L];
				int num = Class33.smethod_17(stream, 668, 731);
				Class31.smethod_12(stream, array, 0, array.Length, 616, 525);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_;
					while ((int_ = Class33.smethod_18(stream_, array2, 0, array2.Length, 388, 507)) > 0)
					{
						smethod_14(memoryStream, array2, 0, int_, 778, 893);
					}
				}
				assembly = smethod_15(Class34.Class35.smethod_14(memoryStream, 267, 263), null, Class34.Class35.smethod_15(assembly_, 162, 171), 555, 634);
				Class39.smethod_3(appDomain_, object_, assembly, 811, 782);
				string[] array3 = Class36.Class37.smethod_8(assembly, 665, 710);
				foreach (string text3 in array3)
				{
					dictionary[text3] = text3;
				}
			}
			else
			{
				assembly = (Assembly)Class39.smethod_9(appDomain_, object_, 787, 852);
			}
			if (dictionary.ContainsKey(Class36.smethod_4(resolveEventArgs_0, 834, 790)))
			{
				return assembly;
			}
			return null;
		}

		internal static Assembly smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return Class36.smethod_6(556, 627);
				}
			}
		}

		internal static void smethod_2(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 67:
					Class36.Class37.smethod_9(900, 960);
					return;
				}
			}
		}

		internal static string smethod_3(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 31:
					return Class36.Class37.smethod_10(object_0, object_1, 445, 490);
				}
			}
		}

		internal static Process smethod_4(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 107:
					return Class36.smethod_7(int_0, 399, 471);
				}
			}
		}

		internal static Encoding smethod_5(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 13:
					return Class39.smethod_10(655, 711);
				}
			}
		}

		internal static void smethod_6(Exception exception_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					Class36.smethod_8(exception_0, 481, 385);
					return;
				}
			}
		}

		internal static string smethod_7(string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					return Class36.Class37.smethod_4(string_1, 1014, 1008);
				}
			}
		}

		internal static Color smethod_8(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			while (true)
			{
				switch (int_5 ^ int_4)
				{
				case 75:
					return Class36.Class38.smethod_2(int_0, int_1, int_2, int_3, 427, 416);
				}
			}
		}

		internal static AppDomain smethod_9(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 41:
					return Class36.Class37.smethod_11(370, 305);
				}
			}
		}

		internal static char smethod_10(string string_1, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 111:
					return Class39.Class40.smethod_3(string_1, int_0, 869, 788);
				}
			}
		}

		internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 35:
					return Class36.smethod_9(runtimeTypeHandle_0, 17, 22);
				}
			}
		}

		internal static void smethod_12()
		{
			if (bool_0)
			{
				return;
			}
			Type obj;
			Class39.smethod_2(obj = Class36.smethod_9(typeof(Class32).TypeHandle, 694, 689), 333, 353);
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					Class39.Class40.smethod_2(Class36.Class37.smethod_11(895, 828), smethod_0, 365, 318);
				}
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}

		static Class32()
		{
			Class36.Class37.smethod_15();
			char[] array_ = new char[43];
			Class39.smethod_11(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 972, 1005);
			char_1 = array_;
			char[] array = new char[8];
			array[5] = '㱖';
			array[6] = 'ሜ';
			array[3] = '㛹';
			array[7] = '⦪';
			array[1] = '\u036b';
			array[2] = 'ỹ';
			array[0] = '㧲';
			array[4] = 'ڈ';
			string_0 = new string[1];
			char_0 = array;
		}

		internal static string smethod_13(int int_0, int int_1)
		{
			int num = int_0 ^ 0x297FFDA3 ^ int_1;
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

		internal static void smethod_14(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 119:
					Class36.smethod_2(stream_0, byte_0, int_0, int_1, 886, 884);
					return;
				}
			}
		}

		internal static Assembly smethod_15(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 81:
					return Class39.smethod_6(byte_0, byte_1, evidence_0, 1019, 1011);
				}
			}
		}
	}

	static Class31()
	{
		Class36.Class37.smethod_15();
		Class32.smethod_12();
	}

	internal static string[] smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Class36.Class37.smethod_8(assembly_0, 710, 665);
			}
		}
	}

	internal static MethodInfo smethod_1(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				return Class39.Class40.smethod_4(assembly_0, 980, 1019);
			}
		}
	}

	internal static string smethod_2(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 42:
				return Class39.Class40.smethod_5(encoding_0, byte_0, 759, 681);
			}
		}
	}

	internal static object smethod_3(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 77:
				return Class36.Class37.smethod_12(resourceManager_0, string_0, 775, 845);
			}
		}
	}

	internal static string smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return Class39.smethod_12(assembly_0, 0, 104);
			}
		}
	}

	internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 13:
				return Class36.Class37.smethod_7(stream_0, byte_0, int_0, int_1, 537, 608);
			}
		}
	}

	internal static byte[] smethod_6(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 117:
				return Class36.Class37.smethod_13(string_0, 35, 39);
			}
		}
	}

	internal static Evidence smethod_7(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return Class36.Class37.smethod_14(assembly_0, 8, 43);
			}
		}
	}

	internal static object smethod_8(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 66:
				return Class39.smethod_9(appDomain_0, string_0, 186, 253);
			}
		}
	}

	internal static AppDomain smethod_9(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 15:
				return Class36.Class37.smethod_11(437, 502);
			}
		}
	}

	internal static void smethod_10(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				Class39.smethod_3(appDomain_0, string_0, object_0, 388, 417);
				return;
			}
		}
	}

	internal static long smethod_11(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return Class36.Class38.smethod_3(stream_0, 547, 531);
			}
		}
	}

	internal static int smethod_12(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 101:
				return Class36.Class37.smethod_7(stream_0, byte_0, int_0, int_1, 652, 757);
			}
		}
	}
}
