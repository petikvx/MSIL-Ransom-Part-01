using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal sealed class Class16
{
	private sealed class Class17
	{
		public static readonly Class17 class17_0;

		internal byte[] byte_0;

		static Class17()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(smethod_2(991, 986), new DateTime(635063163027266367L), 160, 143))
			{
				throw new Exception();
			}
			class17_0 = new Class17();
		}

		private Class17()
		{
			Assembly assembly_ = Class18.smethod_2(250, 143);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 340, 363);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class22.smethod_2(string_0, 597, 517);
			int num2 = int_0 & 0xFF;
			char[] array = Class1.smethod_0(string_0, 37, 28);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class26.Class29.smethod_2(new string(array), 5, 75);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct3
	{
		internal byte[] byte_0;

		static Struct3()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(smethod_2(161, 164), new DateTime(635063163028056413L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class17.class17_0.method_0(string_0, int_0), 556, 610);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216787968, 4), 63695), 58662), 60726), 58947);
	}

	static Class16()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static DateTime smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				return Class26.Class27.smethod_2(334, 368);
			}
		}
	}

	internal static Encoding smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 55:
				return Class26.Class28.smethod_5(860, 853);
			}
		}
	}

	internal static bool smethod_4(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 83:
				return Class30.smethod_5(string_0, string_1, 67, 117);
			}
		}
	}
}
