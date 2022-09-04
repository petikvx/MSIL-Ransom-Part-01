using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class14
{
	private sealed class Class15
	{
		public static readonly Class15 class15_0;

		internal byte[] byte_0;

		static Class15()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(991, 986), new DateTime(635063162985553982L), 160, 143))
			{
				throw new Exception();
			}
			class15_0 = new Class15();
		}

		private Class15()
		{
			Assembly assembly_ = Class18.smethod_2(250, 143);
			Stream stream = smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 780, 819);
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
			return Class26.Class29.smethod_2(new string(array), 261, 331);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(161, 164), new DateTime(635063162986344027L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class15.class15_0.method_0(string_0, int_0), 720, 670);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788067, 4), 60487), 58210), 58079), 62379), 63288);
	}

	static Class14()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static Stream smethod_2(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return Class26.Class29.smethod_0(assembly_0, string_0, 229, 131);
			case 114:
				return Class26.Class29.smethod_0(assembly_0, string_0, 237, 139);
			}
		}
	}

	internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				return Class26.smethod_9(runtimeTypeHandle_0, 993, 1005);
			}
		}
	}

	internal static MethodInfo smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return Class30.smethod_11(assembly_0, 793, 779);
			}
		}
	}
}
