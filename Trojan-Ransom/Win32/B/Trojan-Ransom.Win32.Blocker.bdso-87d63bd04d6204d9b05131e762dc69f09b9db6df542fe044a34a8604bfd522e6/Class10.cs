using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;

internal sealed class Class10
{
	internal sealed class Class11
	{
		internal sealed class Class12
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
			private struct Struct3
			{
				static Struct3()
				{
					Class15.Class16.smethod_7();
				}
			}

			private static bool bool_0;

			private static readonly char[] char_0;

			private static readonly char[] char_1;

			private static readonly string[] string_0;

			internal static Struct3 struct3_0/* Not supported: data(00 00 28 00 00 00 9D 02 2B 19 99 31 6A 07 3B 2A 5E 08 43 10 22 1F 9F 02 5C 19 EE 31 6B 07 33 2A 5B 08 34 10 5A 1F E9 02 5F 19 E7 31 17 07 32 2A 5C 08 31 10 5B 1F 9D 02 2B 19 EA 31 61 07 38 2A 5F 08 32 10 20 1F EC 02 5E 19 EE 31 61 07 32 2A 5B 08 41 10 54 1F) */;

			internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
			{
				string text = smethod_4(2048830263, 6);
				string object_ = text;
				string string_ = Class10.smethod_9((object)object_, (object)'1', 367, 257);
				AppDomain appDomain_ = smethod_10(516, 588);
				Dictionary<string, string> dictionary = (Dictionary<string, string>)smethod_11(appDomain_, string_, 962, 904);
				Assembly assembly;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, string>();
					smethod_5(appDomain_, string_, dictionary, 75, 117);
					Assembly assembly_ = smethod_12(726, 725);
					Stream stream = smethod_6(assembly_, text, 798, 800);
					if (stream == null)
					{
						return null;
					}
					byte[] array = new byte[Class11.smethod_6(stream, 753, 761) - 1L];
					int num = Class11.smethod_7(stream, 412, 475);
					Class14.smethod_5(stream, array, 0, array.Length, 641, 651);
					for (int i = 0; i < array.Length; i++)
					{
						array[i] ^= (byte)((i + num) & 0xFF);
					}
					MemoryStream memoryStream = new MemoryStream();
					using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
					{
						byte[] array2 = new byte[1024];
						int int_;
						while ((int_ = Class14.smethod_5(stream_, array2, 0, array2.Length, 861, 854)) > 0)
						{
							smethod_7(memoryStream, array2, 0, int_, 3, 102);
						}
					}
					assembly = smethod_9(smethod_8(memoryStream, 409, 435), null, smethod_13(assembly_, 105, 27), 245, 220);
					Class15.Class16.Class17.smethod_1(appDomain_, object_, assembly, 254, 136);
					string[] array3 = Class19.smethod_2(assembly, 356, 321);
					foreach (string text2 in array3)
					{
						dictionary[text2] = text2;
					}
				}
				else
				{
					assembly = (Assembly)Class19.smethod_3(appDomain_, object_, 509, 420);
				}
				if (dictionary.ContainsKey(Class15.Class16.Class17.smethod_2(resolveEventArgs_0, 184, 196)))
				{
					return assembly;
				}
				return null;
			}

			internal static string smethod_1(object object_0, object object_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 123:
						return Class15.Class16.Class18.smethod_0(object_0, object_1, 876, 824);
					}
				}
			}

			internal static Assembly smethod_2(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 98:
						return Class15.Class16.smethod_3(byte_0, byte_1, evidence_0, 508, 390);
					}
				}
			}

			internal static void smethod_3()
			{
				if (bool_0)
				{
					return;
				}
				Type obj;
				Class19.smethod_5(obj = Class19.smethod_4(typeof(Class12).TypeHandle, 343, 310), 604, 626);
				try
				{
					if (!bool_0)
					{
						bool_0 = true;
						Class15.Class16.smethod_2(Class15.Class16.Class18.smethod_1(60, 10), smethod_0, 674, 748);
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}

			static Class12()
			{
				if (DateTime.Now > new DateTime(635043905220292968L))
				{
					throw new Exception();
				}
				Class15.Class16.smethod_7();
				if (Class15.Class16.smethod_1(Class19.smethod_0(93, 42), new DateTime(635043901567451171L), 768, 812))
				{
					throw new Exception();
				}
				if (Class15.Class16.smethod_1(Class19.smethod_0(303, 344), new DateTime(635043896442470703L), 191, 147))
				{
					throw new Exception();
				}
				char[] array_ = new char[43];
				Class15.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 593, 545);
				char_1 = array_;
				char[] array = new char[8];
				array[1] = 'ᤝ';
				array[3] = 'ݓ';
				array[6] = 'စ';
				array[5] = 'ࠚ';
				array[4] = '⨋';
				array[2] = '㇟';
				array[7] = 'ὣ';
				array[0] = 'ʨ';
				string_0 = new string[1];
				char_0 = array;
			}

			internal static string smethod_4(int int_0, int int_1)
			{
				int num = int_0 ^ 0x7A1EAB31 ^ int_1;
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

			internal static void smethod_5(AppDomain appDomain_0, string string_1, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 62:
						Class15.Class16.Class17.smethod_1(appDomain_0, string_1, object_0, 137, 255);
						return;
					}
				}
			}

			internal static Stream smethod_6(Assembly assembly_0, string string_1, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 62:
						return Class15.Class16.smethod_4(assembly_0, string_1, 834, 861);
					}
				}
			}

			internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 101:
						Class19.smethod_6(stream_0, byte_0, int_0, int_1, 620, 615);
						return;
					}
				}
			}

			internal static byte[] smethod_8(MemoryStream memoryStream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 42:
						return Class15.Class16.smethod_5(memoryStream_0, 327, 279);
					}
				}
			}

			internal static Assembly smethod_9(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 41:
						return Class15.Class16.smethod_3(byte_0, byte_1, evidence_0, 395, 497);
					}
				}
			}
		}

		internal sealed class Class13
		{
			internal static void smethod_0(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 60:
						Class15.Class16.Class17.smethod_1(appDomain_0, string_0, object_0, 55, 65);
						return;
					}
				}
			}

			internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 110:
						Class15.smethod_3(array_0, runtimeFieldHandle_0, 307, 323);
						return;
					}
				}
			}

			internal static void smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 96:
						Class19.smethod_6(stream_0, byte_0, int_0, int_1, 632, 627);
						return;
					}
				}
			}

			internal static byte[] smethod_3(Encoding encoding_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 11:
						return Class15.smethod_4(encoding_0, string_0, 130, 142);
					}
				}
			}

			internal static byte[] smethod_4(MemoryStream memoryStream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 47:
						return Class15.Class16.smethod_5(memoryStream_0, 504, 424);
					}
				}
			}

			static Class13()
			{
				if (DateTime.Now > new DateTime(635043653220332031L))
				{
					throw new Exception();
				}
				Class15.Class16.smethod_7();
			}
		}

		internal static string[] smethod_0(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return Class19.smethod_2(assembly_0, 377, 348);
				}
			}
		}

		internal static int smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 18:
					return Class15.Class16.Class17.smethod_0(stream_0, byte_0, int_0, int_1, 476, 507);
				}
			}
		}

		internal static string smethod_2(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 120:
					return Class15.Class16.Class17.smethod_3(byte_0, 213, 222);
				}
			}
		}

		internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return Class19.smethod_4(runtimeTypeHandle_0, 287, 382);
				}
			}
		}

		internal static byte[] smethod_4(BinaryReader binaryReader_0, int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 118:
					return Class15.Class16.smethod_6(binaryReader_0, int_0, 596, 569);
				}
			}
		}

		internal static Encoding smethod_5(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					return Class15.Class16.Class18.smethod_2(266, 292);
				}
			}
		}

		internal static long smethod_6(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					return Class15.smethod_2(stream_0, 692, 696);
				}
			}
		}

		internal static int smethod_7(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					return Class15.smethod_1(stream_0, 620, 521);
				}
			}
		}

		static Class11()
		{
			if (DateTime.Now > new DateTime(635043905220253906L))
			{
				throw new Exception();
			}
			Class15.Class16.smethod_7();
		}
	}

	static Class10()
	{
		if (DateTime.Now > new DateTime(635043905220214843L))
		{
			throw new Exception();
		}
		Class15.Class16.smethod_7();
		if (Class15.Class16.smethod_1(Class19.smethod_0(235, 156), new DateTime(635043793567099609L), 289, 269))
		{
			throw new Exception();
		}
		if (Class19.smethod_0(799, 872) > new DateTime(635043896442382812L))
		{
			throw new Exception();
		}
		Class11.Class12.smethod_3();
	}

	internal static int smethod_0(AppDomain appDomain_0, AssemblyName assemblyName_0, Evidence evidence_0, string[] string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				return Class15.Class16.Class17.smethod_4(appDomain_0, assemblyName_0, evidence_0, string_0, 746, 644);
			}
		}
	}

	internal static object smethod_1(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return Class19.smethod_3(appDomain_0, string_0, 567, 622);
			}
		}
	}

	internal static Assembly smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 101:
				return Class15.Class16.Class18.smethod_3(448, 414);
			}
		}
	}

	internal static Stream smethod_3(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return Class15.Class16.smethod_4(assembly_0, string_0, 776, 791);
			}
		}
	}

	internal static string smethod_4(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return Class15.Class16.Class17.smethod_2(resolveEventArgs_0, 865, 797);
			}
		}
	}

	internal static void smethod_5(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				Class19.smethod_5(object_0, 891, 853);
				return;
			case 13:
				Monitor.Exit(object_0);
				return;
			}
		}
	}

	internal static AppDomain smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return Class15.Class16.Class18.smethod_1(367, 345);
			}
		}
	}

	internal static int smethod_7(BinaryReader binaryReader_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return Class19.smethod_7(binaryReader_0, 692, 715);
			}
		}
	}

	internal static Assembly smethod_8(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return Class19.smethod_8(byte_0, 441, 466);
			}
		}
	}

	internal static string smethod_9(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return Class15.Class16.Class18.smethod_0(object_0, object_1, 384, 468);
			}
		}
	}

	internal static AppDomain smethod_10(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return Class15.Class16.Class18.smethod_1(61, 11);
			}
		}
	}

	internal static object smethod_11(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				return Class19.smethod_3(appDomain_0, string_0, 989, 900);
			}
		}
	}

	internal static Assembly smethod_12(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return Class15.Class16.Class18.smethod_3(937, 1015);
			}
		}
	}

	internal static Evidence smethod_13(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				return Class15.smethod_0(assembly_0, 824, 810);
			}
		}
	}
}
