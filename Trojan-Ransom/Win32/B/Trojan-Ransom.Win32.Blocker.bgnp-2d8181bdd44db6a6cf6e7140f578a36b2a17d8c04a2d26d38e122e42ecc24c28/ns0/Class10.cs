using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class10
{
	private sealed class Class11
	{
		public static readonly Class11 class11_0;

		internal byte[] byte_0;

		static Class11()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(991, 986), new DateTime(635063162895098808L), 160, 143))
			{
				throw new Exception();
			}
			class11_0 = new Class11();
		}

		private Class11()
		{
			Assembly assembly_ = Class18.smethod_2(250, 143);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 520, 567);
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
			return Class26.Class29.smethod_2(new string(array), 218, 148);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(161, 164), new DateTime(635063162895818849L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class11.class11_0.method_0(string_0, int_0), 100, 42);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788137, 4), 58710), 58635), 59357), 63233), 62934), 62137), 60944);
	}

	static Class10()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static decimal smethod_2(decimal decimal_0, decimal decimal_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Class26.smethod_7(decimal_0, decimal_1, 145, 128);
			}
		}
	}

	internal static long smethod_3(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				return Class26.Class29.smethod_8(stream_0, 843, 786);
			}
		}
	}

	internal static string smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Class26.smethod_10(44, 42);
			}
		}
	}
}
