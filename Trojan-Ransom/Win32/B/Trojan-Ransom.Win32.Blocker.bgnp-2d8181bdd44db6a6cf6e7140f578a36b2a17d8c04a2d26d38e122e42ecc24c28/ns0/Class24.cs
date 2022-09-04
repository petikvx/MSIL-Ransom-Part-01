using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class24
{
	private sealed class Class25
	{
		public static readonly Class25 class25_0;

		internal byte[] byte_0;

		static Class25()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(775, 770), new DateTime(635063163238598455L), 638, 593))
			{
				throw new Exception();
			}
			class25_0 = new Class25();
		}

		private Class25()
		{
			Assembly assembly_ = Class18.smethod_2(923, 1006);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 111, 30);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 611, 604);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class22.smethod_2(string_0, 170, 250);
			int num2 = int_0 & 0xFF;
			char[] array = Class1.smethod_0(string_0, 987, 994);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class26.Class29.smethod_2(new string(array), 200, 134);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct4
	{
		internal byte[] byte_0;

		static Struct4()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct5
	{
		internal byte[] byte_0;

		static Struct5()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct6
	{
		internal byte[] byte_0;

		static Struct6()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct7
	{
		internal byte[] byte_0;

		static Struct7()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct8
	{
		internal byte[] byte_0;

		static Struct8()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct9
	{
		internal byte[] byte_0;

		static Struct9()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct10
	{
		internal byte[] byte_0;

		static Struct10()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(477, 472), new DateTime(635063163239438503L), 604, 627))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class25.class25_0.method_0(string_0, int_0), 24, 86);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class0.smethod_1(1216788178, 4);
	}

	static Class24()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static object smethod_2(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Class26.Class29.smethod_6(object_0, 806, 816);
			}
		}
	}

	internal static void smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 8:
				Class26.Class29.smethod_9(stream_0, byte_0, int_0, int_1, 878, 864);
				return;
			}
		}
	}

	internal static string smethod_4(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return Class26.Class29.smethod_2(string_0, 261, 330);
			}
		}
	}
}
