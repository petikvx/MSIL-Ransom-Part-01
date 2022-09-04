using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class12
{
	private sealed class Class13
	{
		public static readonly Class13 class13_0;

		internal byte[] byte_0;

		static Class13()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(991, 986), new DateTime(635063162933821023L), 160, 143))
			{
				throw new Exception();
			}
			class13_0 = new Class13();
		}

		private Class13()
		{
			Assembly assembly_ = Class18.smethod_2(250, 143);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 244, 203);
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
			return Class26.Class29.smethod_2(new string(array), 513, 591);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(161, 164), new DateTime(635063162934571066L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class13.class13_0.method_0(string_0, int_0), 820, 890);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788046, 4), 63121), 60131), 57433), 61373), 59745), 59454);
	}

	static Class12()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static Color smethod_2(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		while (true)
		{
			switch (int_5 ^ int_4)
			{
			case 20:
				return Class26.Class29.smethod_4(int_0, int_1, int_2, int_3, 972, 961);
			}
		}
	}

	internal static string[] smethod_3(string string_0, char[] char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 103:
				return Class30.smethod_1(string_0, char_0, 672, 762);
			}
		}
	}
}
