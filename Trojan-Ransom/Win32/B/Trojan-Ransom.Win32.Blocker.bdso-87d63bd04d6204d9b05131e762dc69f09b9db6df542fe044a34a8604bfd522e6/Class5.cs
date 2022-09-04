using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;

internal sealed class Class5
{
	internal sealed class Class6
	{
		private static bool bool_0;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = smethod_11(35231812, 1);
			string text2 = text;
			string text3 = Class8.smethod_5(text2, '1', 467, 436);
			AppDomain appDomain_ = Class7.smethod_2(553, 569);
			Dictionary<string, string> dictionary = (Dictionary<string, string>)Class9.smethod_3(appDomain_, text3, 551, 561);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				smethod_12(appDomain_, text3, dictionary, 127, 35);
				Assembly assembly_ = Class9.smethod_4(432, 483);
				Stream stream = Class9.smethod_5(assembly_, text, 480, 413);
				if (stream == null)
				{
					return null;
				}
				byte[] array = new byte[Class7.smethod_3(stream, 140, 196) - 1L];
				int num = smethod_13(stream, 886, 869);
				smethod_14(stream, array, 0, array.Length, 584, 581);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_;
					while ((int_ = smethod_14(stream_, array2, 0, array2.Length, 805, 811)) > 0)
					{
						smethod_7(memoryStream, array2, 0, int_, 529, 616);
					}
				}
				assembly = Class7.smethod_4(Class8.smethod_6(memoryStream, 576, 537), null, Class8.smethod_7(assembly_, 950, 909), 964, 1006);
				Class10.Class11.Class13.smethod_0(appDomain_, text2, assembly, 674, 670);
				string[] array3 = Class10.Class11.smethod_0(assembly, 129, 230);
				foreach (string text4 in array3)
				{
					dictionary[text4] = text4;
				}
			}
			else
			{
				assembly = (Assembly)Class10.smethod_1(appDomain_, text2, 442, 506);
			}
			if (dictionary.ContainsKey(Class10.smethod_4(resolveEventArgs_0, 512, 579)))
			{
				return assembly;
			}
			return null;
		}

		internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 10:
					Class10.Class11.Class13.smethod_1(array_0, runtimeFieldHandle_0, 514, 620);
					return;
				}
			}
		}

		internal static void smethod_2(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 4:
					Class14.smethod_1(appDomain_0, resolveEventHandler_0, 565, 557);
					return;
				case 5:
					appDomain_0.AssemblyResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		internal static int smethod_3(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 21:
					return Class14.smethod_2(stream_0, 847, 768);
				}
			}
		}

		internal static string smethod_4(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return Class10.Class11.Class12.smethod_1(object_0, object_1, 281, 354);
				}
			}
		}

		internal static string smethod_5(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return Class14.smethod_3(string_0, 90, 22);
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
			Class10.smethod_5(object_ = Class10.Class11.smethod_3(typeof(Class6).TypeHandle, 917, 990), 695, 699);
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					Class14.smethod_1(Class10.smethod_6(739, 727), smethod_0, 654, 662);
				}
			}
			finally
			{
				Class10.smethod_5(object_, 293, 296);
			}
		}

		internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 121:
					Class10.Class11.Class13.smethod_2(stream_0, byte_0, int_0, int_1, 987, 955);
					return;
				}
			}
		}

		static Class6()
		{
			if (DateTime.Now > new DateTime(635043545220068359L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
			if (Class15.Class16.smethod_1(Class19.smethod_0(198, 177), new DateTime(635043577566660156L), 456, 484))
			{
				throw new Exception();
			}
			if (Class19.smethod_0(878, 793) > new DateTime(635043752442207031L))
			{
				throw new Exception();
			}
			Class10.Class11.Class12.smethod_3();
		}
	}

	internal sealed class Class7
	{
		internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					return Class10.Class11.smethod_3(runtimeTypeHandle_0, 31, 84);
				}
			}
		}

		internal static long smethod_1(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return Class14.smethod_4(stream_0, 144, 140);
				}
			}
		}

		internal static AppDomain smethod_2(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 16:
					return Class10.smethod_6(187, 143);
				}
			}
		}

		internal static long smethod_3(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 72:
					return Class14.smethod_4(stream_0, 630, 618);
				}
			}
		}

		internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 42:
					return Class10.Class11.Class12.smethod_2(byte_0, byte_1, evidence_0, 511, 413);
				}
			}
		}

		static Class7()
		{
			if (DateTime.Now > new DateTime(635043545220107421L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
			if (Class15.Class16.smethod_1(Class19.smethod_0(936, 991), new DateTime(635043577566689453L), 298, 262))
			{
				throw new Exception();
			}
			if (Class19.smethod_0(589, 570) > new DateTime(635043752442246093L))
			{
				throw new Exception();
			}
			Class10.Class11.Class12.smethod_3();
		}
	}

	internal sealed class Class8
	{
		internal static void smethod_0(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 38:
					Class10.smethod_5(object_0, 684, 672);
					return;
				case 39:
					Monitor.Exit(object_0);
					return;
				}
			}
		}

		internal static void smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 54:
					Class10.Class11.Class13.smethod_2(stream_0, byte_0, int_0, int_1, 462, 430);
					return;
				}
			}
		}

		internal static Assembly smethod_2(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					return Class10.Class11.Class12.smethod_2(byte_0, byte_1, evidence_0, 191, 221);
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
					return Class10.smethod_2(138, 239);
				}
			}
		}

		internal static byte[] smethod_4(Encoding encoding_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 67:
					return Class10.Class11.Class13.smethod_3(encoding_0, string_0, 967, 972);
				}
			}
		}

		internal static string smethod_5(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return Class10.Class11.Class12.smethod_1(object_0, object_1, 427, 464);
				}
			}
		}

		internal static byte[] smethod_6(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 89:
					return Class10.Class11.Class13.smethod_4(memoryStream_0, 767, 720);
				}
			}
		}

		internal static Evidence smethod_7(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 59:
					return Class14.smethod_0(assembly_0, 48, 108);
				}
			}
		}

		static Class8()
		{
			if (DateTime.Now > new DateTime(635043545220146484L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
			if (Class15.Class16.smethod_1(Class19.smethod_0(497, 390), new DateTime(635043649567001953L), 283, 311))
			{
				throw new Exception();
			}
			if (Class19.smethod_0(762, 653) > new DateTime(635043752442294921L))
			{
				throw new Exception();
			}
			Class10.Class11.Class12.smethod_3();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct2
	{
		static Struct2()
		{
			Class15.Class16.smethod_7();
			Class10.Class11.Class12.smethod_3();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct2 struct2_0/* Not supported: data(00 00 28 00 00 00 2F 09 91 39 61 05 2C 06 47 01 22 08 BA 36 2A 2B 5B 09 9A 39 11 05 5B 06 4A 01 59 08 BE 36 2A 2B 53 09 9F 39 60 05 5C 06 46 01 22 08 B9 36 5D 2B 2E 09 E9 39 61 05 5F 06 3D 01 52 08 CE 36 2D 2B 59 09 E9 39 15 05 5E 06 3A 01 50 08 C9 36 20 2B) */;

	static Class5()
	{
		if (DateTime.Now > new DateTime(635043545220039062L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(419, 468), new DateTime(635043577566640625L), 410, 438))
		{
			throw new Exception();
		}
		if (Class15.Class16.smethod_1(Class19.smethod_0(356, 275), new DateTime(635043824442167968L), 766, 722))
		{
			throw new Exception();
		}
		Class10.Class11.Class12.smethod_3();
		char[] array_ = new char[43];
		Class10.Class11.Class13.smethod_1(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 188, 210);
		char_1 = array_;
		char[] array = new char[8];
		array[4] = 'ſ';
		array[5] = 'ࡡ';
		array[6] = '㚋';
		array[2] = 'Փ';
		array[0] = '५';
		array[1] = '㦨';
		array[3] = '٪';
		array[7] = '⬘';
		string_0 = new string[1];
		char_0 = array;
		Class6.smethod_6();
	}

	internal static void smethod_0(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				Class10.Class11.Class13.smethod_0(appDomain_0, string_1, object_0, 763, 711);
				return;
			}
		}
	}

	internal static object smethod_1(AppDomain appDomain_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return Class10.smethod_1(appDomain_0, string_1, 523, 587);
			}
		}
	}

	internal static string smethod_2(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return Class10.smethod_4(resolveEventArgs_0, 327, 260);
			}
		}
	}

	internal static AppDomain smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 101:
				return Class10.smethod_6(102, 82);
			}
		}
	}

	internal static byte[] smethod_4(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				return Class10.Class11.Class13.smethod_4(memoryStream_0, 388, 427);
			}
		}
	}

	internal static Stream smethod_5(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 102:
				return Class10.smethod_3(assembly_0, string_1, 121, 68);
			}
		}
	}

	internal static byte[] smethod_6(BinaryReader binaryReader_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 30:
				return Class10.Class11.smethod_4(binaryReader_0, int_0, 337, 295);
			}
		}
	}

	internal static Encoding smethod_7(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				return Class10.Class11.smethod_5(955, 916);
			}
		}
	}

	internal static int smethod_8(BinaryReader binaryReader_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 27:
				return Class10.smethod_7(binaryReader_0, 978, 941);
			}
		}
	}

	internal static int smethod_9(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 59:
				return Class10.Class11.smethod_1(stream_0, byte_0, int_0, int_1, 234, 248);
			}
		}
	}

	internal static Assembly smethod_10(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return Class10.smethod_8(byte_0, 643, 738);
			}
		}
	}

	internal static string smethod_11(int int_0, int int_1)
	{
		int num = int_0 ^ 0x2199845 ^ int_1;
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

	internal static void smethod_12(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				Class10.Class11.Class13.smethod_0(appDomain_0, string_1, object_0, 515, 575);
				return;
			}
		}
	}

	internal static int smethod_13(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				return Class14.smethod_2(stream_0, 57, 118);
			}
		}
	}

	internal static int smethod_14(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 13:
				return Class10.Class11.smethod_1(stream_0, byte_0, int_0, int_1, 980, 966);
			case 14:
				return Class15.Class16.Class17.smethod_0(stream_0, byte_0, int_0, int_1, 473, 510);
			}
		}
	}
}
