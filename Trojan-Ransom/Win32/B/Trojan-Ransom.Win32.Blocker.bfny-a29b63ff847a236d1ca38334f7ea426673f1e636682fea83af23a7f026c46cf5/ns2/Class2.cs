using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns1;

namespace ns2;

internal sealed class Class2
{
	private sealed class Class3
	{
		public static readonly Class3 class3_0;

		private Attribute0.Struct0 struct0_0;

		static Class3()
		{
			Attribute0.smethod_6();
			if (Attribute0.smethod_1(Attribute0.smethod_0(335, 277), new DateTime(635056392177947468L), 507, 508))
			{
				throw new Exception();
			}
			class3_0 = new Class3();
		}

		private Class3()
		{
			Assembly assembly_ = Class0.smethod_2(127, 83);
			Stream stream = Class4.smethod_0(assembly_, smethod_1(), 617, 585);
			if (stream != null)
			{
				byte[] byte_ = new byte[256];
				struct0_0.byte_0 = byte_;
				stream.Read(struct0_0.byte_0, 0, struct0_0.byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = smethod_2(string_0, 119, 80);
			int num2 = int_0 & 0xFF;
			char[] array = Attribute0.smethod_2(string_0, 605, 523);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (struct0_0.byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	internal sealed class Class4
	{
		internal static Stream smethod_0(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 32:
					return assembly_0.GetManifestResourceStream(string_0);
				}
			}
		}

		internal static Encoding smethod_1(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					return Encoding.Default;
				}
			}
		}

		internal static int smethod_2(BinaryReader binaryReader_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return binaryReader_0.ReadInt32();
				}
			}
		}

		internal static object smethod_3(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 12:
					return appDomain_0.GetData(string_0);
				}
			}
		}

		internal static void smethod_4(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					appDomain_0.SetData(string_0, object_0);
					return;
				case 54:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
			}
		}

		internal static void smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 51:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct3
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[8] { '\0', '\u0005', '\0', '㦱', '㗐', '\u2d2c', '\u087c', 'Ҡ' };

	private static readonly string[] string_0;

	internal static Struct3 struct3_0/* Not supported: data(00 00 05 00 00 00 B1 39 D0 35 2C 2D 7C 08 A0 04) */;

	public static string smethod_0(string string_1, int int_0)
	{
		if (Attribute0.smethod_1(Attribute0.smethod_0(946, 1000), new DateTime(635056392178367492L), 344, 351))
		{
			throw new Exception();
		}
		return string.Intern(Class3.class3_0.method_0(string_1, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Attribute0.smethod_3(689392105, 1);
	}

	static Class2()
	{
		char[] array = new char[8];
		array[3] = 'ࡅ';
		array[2] = 'ⴝ';
		array[0] = '㦜';
		array[6] = '\u0b7d';
		array[5] = 'ᣍ';
		array[7] = '⨋';
		array[1] = '㗥';
		array[4] = 'Ӣ';
		string_0 = new string[1];
		char_0 = array;
		Attribute0.smethod_6();
	}

	internal static int smethod_2(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return string_1.Length;
			}
		}
	}

	internal static string smethod_3(int int_0, int int_1)
	{
		int num = int_0 ^ 0x291749D3 ^ int_1;
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

	internal static AppDomain smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 126:
				return AppDomain.CurrentDomain;
			}
		}
	}

	internal static string[] smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 91:
				return assembly_0.GetManifestResourceNames();
			}
		}
	}
}
