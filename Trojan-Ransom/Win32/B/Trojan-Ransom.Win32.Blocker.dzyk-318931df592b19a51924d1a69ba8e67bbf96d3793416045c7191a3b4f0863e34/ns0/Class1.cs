using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class1
{
	private sealed class Class2
	{
		public static readonly Class2 class2_0;

		internal byte[] byte_0;

		static Class2()
		{
			Class5.smethod_7();
			if (Class3.smethod_2(Class7.smethod_2(391, 497), new DateTime(635307010553442401L), 480, 406))
			{
				throw new Exception();
			}
			class2_0 = new Class2();
		}

		private Class2()
		{
			Assembly assembly_ = Class5.smethod_4(449, 411);
			Stream stream = smethod_2(assembly_, smethod_1(), 169, 146);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class9.Class10.smethod_0(stream, byte_0, 0, byte_0.Length, 726, 764);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class0.smethod_1(string_0, 700, 683);
			int num2 = int_0 & 0xFF;
			char[] array = smethod_3(string_0, 958, 1007);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class9.smethod_0(new string(array), 68, 53);
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct0 struct0_0/* Not supported: data(00 00 05 00 00 00 56 0F 89 1E 4D 3E 57 18 2D 1A) */;

	public static string smethod_0(string string_1, int int_0)
	{
		if (Class3.smethod_2(Class7.smethod_2(539, 621), new DateTime(635307010553882426L), 971, 957))
		{
			throw new Exception();
		}
		return Class9.smethod_0(Class2.class2_0.method_0(string_1, int_0), 310, 327);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class3.smethod_3(1726088005, 1), 62947), 61447), 63603);
	}

	static Class1()
	{
		char[] array_ = new char[8];
		Class9.smethod_3(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 348, 366);
		char_1 = array_;
		char[] array = new char[8];
		array[4] = '\u1a6f';
		array[3] = 'ᡮ';
		array[6] = '\u19cc';
		array[7] = 'ᵾ';
		array[5] = 'd';
		array[2] = '㹼';
		array[1] = 'Ẽ';
		array[0] = '\u0f7b';
		string_0 = new string[1];
		char_0 = array;
		Class5.smethod_7();
	}

	internal static Stream smethod_2(Assembly assembly_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				return Class9.smethod_6(assembly_0, string_1, 151, 170);
			}
		}
	}

	internal static char[] smethod_3(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 81:
				return Class12.Class13.smethod_0(string_1, 50, 127);
			}
		}
	}

	internal static int smethod_4(Random random_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 5:
				return Class12.smethod_3(random_0, int_0, int_1, 155, 184);
			}
		}
	}

	internal static string smethod_5(int int_0, int int_1)
	{
		int num = int_0 ^ 0x66E2032D ^ int_1;
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
}
