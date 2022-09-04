using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading;

namespace ns0;

internal sealed class Class20
{
	private sealed class Class21
	{
		public static readonly Class21 class21_0;

		internal byte[] byte_0;

		static Class21()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(678, 675), new DateTime(635063163141882923L), 348, 371))
			{
				throw new Exception();
			}
			class21_0 = new Class21();
		}

		private Class21()
		{
			Assembly assembly_ = Class18.smethod_2(675, 726);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 771, 882);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 513, 574);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class22.smethod_2(string_0, 579, 531);
			int num2 = int_0 & 0xFF;
			char[] array = Class1.smethod_0(string_0, 210, 235);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class26.Class29.smethod_2(new string(array), 79, 1);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(607, 602), new DateTime(635063163142712971L), 95, 112))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class21.class21_0.method_0(string_0, int_0), 52, 122);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788377, 2), 62968), 62591);
	}

	static Class20()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static char smethod_2(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 82:
				return Class26.smethod_8(string_0, int_0, 324, 318);
			}
		}
	}

	internal static int smethod_3(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				return Class30.smethod_2(stream_0, 272, 307);
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
				return Class26.Class29.smethod_15(assembly_0, 716, 720);
			}
		}
	}

	internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return Class26.Class27.smethod_7(string_0, string_1, 304, 333);
			}
		}
	}

	internal static void smethod_6(Thread thread_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				Class26.smethod_12(thread_0, object_0, 248, 151);
				return;
			}
		}
	}
}
