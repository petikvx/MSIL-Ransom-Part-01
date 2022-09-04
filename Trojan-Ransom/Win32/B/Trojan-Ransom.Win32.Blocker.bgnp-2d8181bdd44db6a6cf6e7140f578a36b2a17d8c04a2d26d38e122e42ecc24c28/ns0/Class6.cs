using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns0;

internal sealed class Class6
{
	private sealed class Class7
	{
		public static readonly Class7 class7_0;

		internal byte[] byte_0;

		static Class7()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(991, 986), new DateTime(635063162487325485L), 160, 143))
			{
				throw new Exception();
			}
			class7_0 = new Class7();
		}

		private Class7()
		{
			Assembly assembly_ = Class18.smethod_2(250, 143);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 542, 623);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 90, 101);
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
			return Class26.Class29.smethod_2(new string(array), 750, 672);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct2
	{
		internal byte[] byte_0;

		static Struct2()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(161, 164), new DateTime(635063162487965521L), 2, 45))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class7.class7_0.method_0(string_0, int_0), 97, 47);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class8.smethod_0(Class10.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0(Class18.smethod_0(Class20.smethod_0(Class22.smethod_0(Class24.smethod_0(Class0.smethod_1(1216788215, 4), 63689), 62989), 60145), 60608), 59180), 61325), 59513), 60348), 60828);
	}

	static Class6()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static Color smethod_2(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 96:
				return Class26.Class29.smethod_5(int_0, 905, 986);
			}
		}
	}

	internal static ParameterInfo[] smethod_3(MethodBase methodBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return Class26.Class27.smethod_5(methodBase_0, 895, 893);
			}
		}
	}

	internal static void smethod_4(Thread thread_0, ApartmentState apartmentState_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				Class30.smethod_6(thread_0, apartmentState_0, 190, 189);
				return;
			}
		}
	}
}
