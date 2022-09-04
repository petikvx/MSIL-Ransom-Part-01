using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class18
{
	private sealed class Class19
	{
		public static readonly Class19 class19_0;

		internal byte[] byte_0;

		static Class19()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(991, 986), new DateTime(635063163073238997L), 160, 143))
			{
				throw new Exception();
			}
			class19_0 = new Class19();
		}

		private Class19()
		{
			Assembly assembly_ = smethod_2(250, 143);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 737, 734);
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
			return Class26.Class29.smethod_2(new string(array), 939, 997);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(161, 164), new DateTime(635063163074039043L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class19.class19_0.method_0(string_0, int_0), 190, 240);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788005, 4), 62304), 62617), 57526);
	}

	static Class18()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static Assembly smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 117:
				return Class26.Class27.smethod_4(645, 647);
			case 118:
				return Class26.Class27.smethod_4(673, 675);
			case 119:
				return Class34.Class35.smethod_1(335, 287);
			}
		}
	}

	internal static char smethod_3(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 82:
				return Class30.smethod_4(int_0, 683, 763);
			}
		}
	}

	internal static string[] smethod_4(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				return Class26.Class29.smethod_10(string_0, 544, 589);
			}
		}
	}

	internal static short smethod_5(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 116:
				return Class26.Class28.smethod_6(byte_0, int_0, 594, 518);
			}
		}
	}

	internal static void smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				Class26.Class29.smethod_12(684, 739);
				return;
			}
		}
	}
}
