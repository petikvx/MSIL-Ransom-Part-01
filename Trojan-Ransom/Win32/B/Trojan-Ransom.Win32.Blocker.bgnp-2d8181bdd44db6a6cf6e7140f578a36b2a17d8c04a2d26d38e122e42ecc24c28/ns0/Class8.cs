using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class8
{
	private sealed class Class9
	{
		public static readonly Class9 class9_0;

		internal byte[] byte_0;

		static Class9()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (smethod_2(Class16.smethod_2(991, 986), new DateTime(635063162838145550L), 160, 143))
			{
				throw new Exception();
			}
			class9_0 = new Class9();
		}

		private Class9()
		{
			Assembly assembly_ = Class18.smethod_2(250, 143);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 15, 48);
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
			return Class26.Class29.smethod_2(new string(array), 482, 428);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (smethod_2(Class16.smethod_2(161, 164), new DateTime(635063162838855591L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class9.class9_0.method_0(string_0, int_0), 626, 572);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788116, 4), 59253), 62486), 62111), 61766), 61093), 58302), 62907), 61199);
	}

	static Class8()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static bool smethod_2(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 47:
				return Class26.Class27.smethod_3(dateTime_0, dateTime_1, 426, 389);
			}
		}
	}

	internal static AppDomain smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Class26.smethod_1(1012, 945);
			}
		}
	}

	internal static int smethod_4(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 94:
				return Class26.smethod_4(stream_0, byte_0, int_0, int_1, 550, 537);
			case 95:
				return Class26.smethod_4(stream_0, byte_0, int_0, int_1, 995, 988);
			}
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Class26.Class27.smethod_6(byte_0, 731, 690);
			}
		}
	}

	internal static string smethod_6(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return Class26.Class28.smethod_8(assembly_0, 198, 253);
			}
		}
	}

	internal static string smethod_7(char char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return Class30.smethod_9(char_0, 115, 79);
			}
		}
	}
}
