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

internal sealed class Class26
{
	internal sealed class Class27
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
		private struct Struct11
		{
			static Struct11()
			{
				Class36.Class37.smethod_15();
				Class31.Class32.smethod_12();
			}
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static Struct11 struct11_0/* Not supported: data(00 00 28 00 00 00 EB 22 31 0B FE 0E 0D 02 AE 2E 7C 27 B4 1F A5 05 9A 22 36 0B 8A 0E 7A 02 D2 2E 0A 27 C7 1F D6 05 9B 22 4A 0B FB 0E 0F 02 AE 2E 7F 27 CD 1F A4 05 9F 22 4B 0B F9 0E 78 02 DE 2E 0B 27 B4 1F A5 05 EA 22 34 0B FC 0E 0D 02 DD 2E 05 27 C3 1F A4 05) */;

		static Class27()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			char[] array_ = new char[43];
			Class34.smethod_1(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 983, 966);
			char_1 = array_;
			char[] array = new char[8];
			array[1] = '୲';
			array[5] = '✽';
			array[7] = 'ס';
			array[4] = '⻪';
			array[3] = 'Ɏ';
			array[6] = '\u1ff5';
			array[0] = '⊯';
			array[2] = '\u0eba';
			string_0 = new string[1];
			char_0 = array;
		}

		internal static string smethod_0(int int_0, int int_1)
		{
			int num = int_0 ^ 0x3F048C11 ^ int_1;
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

		internal static Assembly smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 48:
					return Class31.Class32.smethod_1(476, 503);
				}
			}
		}

		internal static DateTime smethod_2(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 62:
					return Class31.Class32.Class33.smethod_1(260, 295);
				}
			}
		}

		internal static bool smethod_3(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					return Class34.smethod_3(dateTime_0, dateTime_1, 46, 30);
				}
			}
		}

		internal static Assembly smethod_4(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return Class31.Class32.smethod_1(647, 684);
				}
			}
		}

		internal static ParameterInfo[] smethod_5(MethodBase methodBase_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return Class31.Class32.Class33.smethod_3(methodBase_0, 679, 740);
				}
			}
		}

		internal static Assembly smethod_6(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 105:
					return Class34.smethod_4(byte_0, 752, 727);
				}
			}
		}

		internal static string smethod_7(string string_1, string string_2, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					return Class31.Class32.Class33.smethod_5(string_1, string_2, 1003, 944);
				}
			}
		}

		internal static void smethod_8(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
		{
			while (true)
			{
				switch (int_4 ^ int_3)
				{
				case 58:
					Class34.smethod_5(array_0, int_0, array_1, int_1, int_2, 182, 237);
					return;
				}
			}
		}
	}

	internal sealed class Class28
	{
		internal static string smethod_0(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 112:
					return Class31.Class32.smethod_3(object_0, object_1, 600, 583);
				case 113:
					return Class31.Class32.smethod_3(object_0, object_1, 441, 422);
				}
			}
		}

		internal static void smethod_1(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					Class34.Class35.smethod_8(appDomain_0, string_0, object_0, 593, 557);
					return;
				case 80:
					Class39.smethod_3(appDomain_0, string_0, object_0, 1003, 974);
					return;
				}
			}
		}

		internal static string smethod_2(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return Class31.smethod_2(encoding_0, byte_0, 1011, 985);
				}
			}
		}

		internal static int smethod_3(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return Class34.smethod_6(string_0, 859, 787);
				}
			}
		}

		internal static string smethod_4(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					return Class31.Class32.Class33.smethod_8(resolveEventArgs_0, 983, 900);
				}
			}
		}

		internal static Encoding smethod_5(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					return Class31.Class32.smethod_5(486, 491);
				}
			}
		}

		internal static short smethod_6(byte[] byte_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 84:
					return Class31.Class32.Class33.smethod_9(byte_0, int_0, 246, 246);
				}
			}
		}

		internal static object smethod_7(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return Class31.smethod_3(resourceManager_0, string_0, 185, 244);
				}
			}
		}

		internal static string smethod_8(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 59:
					return Class31.smethod_4(assembly_0, 561, 588);
				}
			}
		}

		internal static void smethod_9(Exception exception_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					Class31.Class32.smethod_6(exception_0, 410, 430);
					return;
				}
			}
		}

		internal static void smethod_10(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 40:
					Class34.smethod_7(process_0, 450, 404);
					return;
				}
			}
		}

		static Class28()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
		}
	}

	internal sealed class Class29
	{
		internal static Stream smethod_0(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 101:
					return Class34.Class35.smethod_9(assembly_0, string_0, 748, 678);
				case 102:
					return Class34.Class35.smethod_9(assembly_0, string_0, 611, 553);
				}
			}
		}

		internal static byte smethod_1(ref Color color_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 63:
					return Class31.Class32.Class33.smethod_0(ref color_0, 362, 287);
				case 64:
					return Class34.Class35.smethod_2(ref color_0, 425, 455);
				}
			}
		}

		internal static string smethod_2(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return Class31.Class32.smethod_7(string_0, 564, 529);
				case 79:
					return Class31.Class32.Class33.smethod_10(string_0, 921, 1011);
				}
			}
		}

		internal static int smethod_3(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return Class34.smethod_0(stream_0, 542, 624);
				}
			}
		}

		internal static Color smethod_4(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			while (true)
			{
				switch (int_5 ^ int_4)
				{
				case 13:
					return Class31.Class32.smethod_8(int_0, int_1, int_2, int_3, 34, 105);
				}
			}
		}

		internal static Color smethod_5(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 83:
					return Class31.Class32.Class33.smethod_11(int_0, 2, 57);
				}
			}
		}

		internal static object smethod_6(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 22:
					return Class31.Class32.Class33.smethod_12(object_0, 812, 808);
				}
			}
		}

		internal static int smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 93:
					return Class31.smethod_5(stream_0, byte_0, int_0, int_1, 561, 572);
				}
			}
		}

		internal static long smethod_8(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 89:
					return Class34.smethod_8(stream_0, 84, 113);
				}
			}
		}

		internal static void smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 14:
					Class34.Class35.smethod_10(stream_0, byte_0, int_0, int_1, 939, 896);
					return;
				case 15:
					Class36.smethod_2(stream_0, byte_0, int_0, int_1, 572, 574);
					return;
				}
			}
		}

		internal static string[] smethod_10(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return Class34.smethod_9(string_0, 491, 426);
				}
			}
		}

		internal static byte[] smethod_11(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 39:
					return Class31.smethod_6(string_0, 284, 361);
				}
			}
		}

		internal static void smethod_12(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					Class31.Class32.smethod_2(537, 602);
					return;
				}
			}
		}

		internal static int smethod_13(ref IntPtr intptr_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return Class34.smethod_10(ref intptr_0, 125, 121);
				}
			}
		}

		internal static void smethod_14(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					Class31.Class32.Class33.smethod_13(appDomain_0, resolveEventHandler_0, 275, 352);
					return;
				}
			}
		}

		internal static Evidence smethod_15(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return Class31.smethod_7(assembly_0, 695, 743);
				case 29:
					return Class31.smethod_7(assembly_0, 636, 556);
				}
			}
		}

		internal static Delegate smethod_16(IntPtr intptr_0, Type type_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					return Class34.smethod_11(intptr_0, type_0, 3, 27);
				}
			}
		}

		static Class29()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
		}
	}

	private static bool bool_0;

	internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = Class27.smethod_0(1057262611, 2);
		string text2 = text;
		string string_ = Class28.smethod_0(text2, '1', 889, 777);
		AppDomain appDomain_ = smethod_1(442, 510);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)smethod_2(appDomain_, string_, 185, 132);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Class28.smethod_1(appDomain_, string_, dictionary, 62, 113);
			Assembly assembly_ = Class27.smethod_1(30, 46);
			Stream stream = Class29.smethod_0(assembly_, text, 625, 532);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[smethod_5(stream, 697, 712) - 1L];
			int num = Class29.smethod_3(stream, 135, 225);
			Class29.smethod_7(stream, array, 0, array.Length, 171, 246);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = smethod_4(stream_, array2, 0, array2.Length, 31, 95)) > 0)
				{
					Class29.smethod_9(memoryStream, array2, 0, int_, 791, 792);
				}
			}
			assembly = Class30.smethod_14(smethod_13(memoryStream, 670, 715), null, Class29.smethod_15(assembly_, 683, 694), 812, 833);
			Class34.Class35.smethod_8(appDomain_, text2, assembly, 480, 412);
			string[] array3 = Class31.smethod_0(assembly, 707, 727);
			foreach (string text3 in array3)
			{
				dictionary[text3] = text3;
			}
		}
		else
		{
			assembly = (Assembly)Class31.smethod_8(appDomain_, text2, 965, 903);
		}
		if (dictionary.ContainsKey(Class31.Class32.Class33.smethod_8(resolveEventArgs_0, 734, 653)))
		{
			return assembly;
		}
		return null;
	}

	static Class26()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		smethod_15();
	}

	internal static AppDomain smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 68:
				return Class31.Class32.smethod_9(18, 59);
			case 69:
				return Class31.Class32.smethod_9(556, 517);
			}
		}
	}

	internal static object smethod_2(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return Class31.smethod_8(appDomain_0, string_0, 961, 899);
			case 62:
				return Class31.smethod_8(appDomain_0, string_0, 205, 143);
			}
		}
	}

	internal static char[] smethod_3(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return Class31.Class32.Class33.smethod_14(string_0, 660, 691);
			}
		}
	}

	internal static int smethod_4(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 63:
				return Class31.smethod_5(stream_0, byte_0, int_0, int_1, 186, 183);
			case 64:
				return Class31.smethod_5(stream_0, byte_0, int_0, int_1, 258, 271);
			}
		}
	}

	internal static long smethod_5(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return Class34.smethod_8(stream_0, 798, 827);
			}
		}
	}

	internal static int smethod_6(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return Class34.Class35.smethod_11(ref color_0, 1002, 911);
			}
		}
	}

	internal static decimal smethod_7(decimal decimal_0, decimal decimal_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return Class31.Class32.Class33.smethod_15(decimal_0, decimal_1, 575, 585);
			}
		}
	}

	internal static char smethod_8(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 122:
				return Class31.Class32.smethod_10(string_0, int_0, 816, 863);
			}
		}
	}

	internal static Type smethod_9(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return Class31.Class32.smethod_11(runtimeTypeHandle_0, 935, 900);
			}
		}
	}

	internal static string smethod_10(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 6:
				return Class31.Class32.Class33.smethod_16(873, 817);
			}
		}
	}

	internal static void smethod_11(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				Class34.smethod_1(array_0, runtimeFieldHandle_0, 779, 794);
				return;
			}
		}
	}

	internal static void smethod_12(Thread thread_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 111:
				Class34.Class35.smethod_12(thread_0, object_0, 88, 108);
				return;
			}
		}
	}

	internal static byte[] smethod_13(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				return Class31.Class32.Class33.smethod_2(memoryStream_0, 245, 232);
			}
		}
	}

	internal static Exception smethod_14(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 123:
				return Class34.smethod_12(int_0, 310, 323);
			}
		}
	}

	internal static void smethod_15()
	{
		if (bool_0)
		{
			return;
		}
		Type object_;
		Class34.Class35.smethod_5(object_ = Class31.Class32.smethod_11(typeof(Class26).TypeHandle, 368, 339), 3, 12);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class31.Class32.Class33.smethod_13(Class31.Class32.smethod_9(903, 942), smethod_0, 795, 872);
			}
		}
		finally
		{
			Class34.Class35.smethod_6(object_, 168, 141);
		}
	}
}
