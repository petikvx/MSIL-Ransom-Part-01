using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class1
{
	internal sealed class Class2
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 298)]
		private struct Struct0
		{
			static Struct0()
			{
				Class15.smethod_6();
				Class10.smethod_7();
				Class5.Class6.smethod_7();
			}
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static Struct0 struct0_0/* Not supported: data(00 00 05 00 00 00 86 26 0D 20 DC 39 C1 3B 4A 15 01 00 08 00 00 00 12 20 C7 39 C8 3B 5C 15 04 14 1C 3D 30 3F 8F 26 02 00 06 00 00 00 DE 39 C1 3B 4B 15 13 14 18 3D 35 3F 03 00 09 00 00 00 C6 3B 56 15 03 14 17 3D 35 3F 8D 26 1D 20 C2 39 C1 3B 04 00 0B 00 00 00 54 15 0F 14 0A 3D 39 3F 82 26 00 20 DA 39 DD 3B 52 15 13 14 00 3D 05 00 16 00 00 00 30 14 18 3D 32 3F 8E 26 16 20 C1 39 CB 3B 52 15 56 14 31 3D 30 3F 88 26 1F 20 8E 39 D2 3B 0B 15 58 14 40 3D 7F 3F 8E 26 0C 20 CB 39 06 00 09 00 00 00 2A 3D 39 3F 8A 26 06 20 DE 39 D2 3B 4D 15 01 14 16 3D 07 00 0C 00 00 00 02 3F 83 26 15 20 DC 39 D4 3B 70 15 18 14 0F 3D 3E 3F 80 26 11 20 DC 39 08 00 28 00 00 00 AD 26 46 20 EB 39 E7 3B 7A 15 37 14 3D 3D 66 3F D8 26 4D 20 9C 39 97 3B 0C 15 33 14 3A 3D 13 3F AA 26 32 20 EF 39 E2 3B 09 15 34 14 4E 3D 68 3F DC 26 35 20 ED 39 94 3B 7A 15 42 14 3D 3D 66 3F D3 26 46 20 9B 39 9D 3B 0B 15 37 14 40 3D 69 3F) */;

		static Class2()
		{
			Class15.smethod_6();
			Class10.smethod_7();
			Class5.Class6.smethod_7();
			char[] array_ = new char[149];
			Class8.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 52, 53);
			char_1 = array_;
			char[] array = new char[8];
			array[7] = '㽑';
			array[3] = '㮤';
			array[1] = '⁴';
			array[4] = 'ᔹ';
			array[0] = '⛫';
			array[5] = 'ᑶ';
			array[6] = '㵹';
			array[2] = '㦮';
			string_0 = new string[9];
			char_0 = array;
		}

		internal static string smethod_0(int int_0, int int_1)
		{
			int num = int_0 ^ 0x70947514 ^ int_1;
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

		internal static bool smethod_1(string string_1, string string_2, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					return Class8.Class9.smethod_0(string_1, string_2, 957, 971);
				}
			}
		}

		internal static Assembly smethod_2(byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 23:
					return Class5.Class6.smethod_1(byte_0, 878, 781);
				}
			}
		}

		internal static string smethod_3(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return Class5.Class6.smethod_2(object_0, object_1, 100, 9);
				}
			}
		}

		internal static object smethod_4(AppDomain appDomain_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 105:
					return Class5.smethod_0(appDomain_0, string_1, 562, 613);
				}
			}
		}

		internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 84:
					return Class5.smethod_1(stream_0, byte_0, int_0, int_1, 842, 803);
				case 85:
					return Class5.smethod_1(stream_0, byte_0, int_0, int_1, 760, 657);
				}
			}
		}

		internal static byte[] smethod_6(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return Class5.Class6.smethod_3(memoryStream_0, 265, 282);
				}
			}
		}
	}

	internal sealed class Class3
	{
		internal sealed class Class4
		{
			internal static object smethod_0(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 111:
						return Class8.smethod_1(resourceManager_0, string_0, 1017, 1008);
					}
				}
			}

			internal static string smethod_1(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 108:
						return Class5.Class7.smethod_0(specialFolder_0, 978, 985);
					}
				}
			}

			internal static Encoding smethod_2(int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 108:
						return Class8.smethod_2(519, 525);
					case 109:
						return Class8.smethod_2(717, 710);
					}
				}
			}

			internal static Type[] smethod_3(Assembly assembly_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 13:
						return Class8.Class9.smethod_1(assembly_0, 394, 406);
					}
				}
			}

			internal static void smethod_4(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 37:
						Class5.Class7.smethod_1(appDomain_0, string_0, object_0, 819, 836);
						return;
					}
				}
			}

			internal static long smethod_5(Stream stream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 126:
						return Class8.smethod_3(stream_0, 554, 626);
					}
				}
			}

			internal static int smethod_6(Stream stream_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 7:
						return Class5.Class6.smethod_4(stream_0, 228, 208);
					}
				}
			}

			internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 126:
						Class8.Class9.smethod_2(stream_0, byte_0, int_0, int_1, 485, 474);
						return;
					}
				}
			}

			internal static Assembly smethod_8(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 81:
						return Class5.smethod_2(byte_0, byte_1, evidence_0, 537, 586);
					}
				}
			}

			static Class4()
			{
				Class15.smethod_6();
				Class10.smethod_7();
				Class5.Class6.smethod_7();
			}
		}

		internal static MethodInfo[] smethod_0(Type type_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					return Class5.Class7.smethod_2(type_0, 545, 534);
				}
			}
		}

		internal static AppDomain smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					return Class8.Class9.smethod_3(923, 911);
				}
			}
		}

		internal static Stream smethod_2(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 4:
					return Class8.Class9.smethod_4(assembly_0, string_0, 1000, 958);
				}
			}
		}

		static Class3()
		{
			Class15.smethod_6();
			Class10.smethod_7();
			Class5.Class6.smethod_7();
		}
	}

	static Class1()
	{
		Class15.smethod_6();
		Class10.smethod_7();
		Class5.Class6.smethod_7();
		Class0.smethod_4();
	}

	internal static Assembly smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return Class5.Class7.smethod_3(599, 607);
			case 120:
				return Class5.Class7.smethod_3(988, 980);
			}
		}
	}

	internal static byte[] smethod_1(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return Class8.Class9.smethod_5(encoding_0, string_0, 592, 623);
			}
		}
	}

	internal static string smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return Class8.smethod_4(861, 811);
			}
		}
	}

	internal static string smethod_3(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return Class8.smethod_5(object_0, 821, 892);
			}
		}
	}

	internal static Evidence smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 38:
				return Class5.Class6.smethod_5(assembly_0, 481, 390);
			}
		}
	}
}
