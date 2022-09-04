using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace ns0;

internal sealed class Class22
{
	private sealed class Class23
	{
		public static readonly Class23 class23_0;

		internal byte[] byte_0;

		static Class23()
		{
			Class36.Class37.smethod_15();
			Class31.Class32.smethod_12();
			Class26.smethod_15();
			Class0.smethod_6();
			if (Class8.smethod_2(Class16.smethod_2(683, 686), new DateTime(635063163189405641L), 610, 589))
			{
				throw new Exception();
			}
			class23_0 = new Class23();
		}

		private Class23()
		{
			Assembly assembly_ = Class18.smethod_2(869, 784);
			Stream stream = Class14.smethod_2(assembly_, smethod_1(), 878, 799);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class26.smethod_4(stream, byte_0, 0, byte_0.Length, 611, 604);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = smethod_2(string_0, 544, 624);
			int num2 = int_0 & 0xFF;
			char[] array = Class1.smethod_0(string_0, 499, 458);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class26.Class29.smethod_2(new string(array), 200, 134);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class8.smethod_2(Class16.smethod_2(197, 192), new DateTime(635063163190225688L), 337, 382))
		{
			throw new Exception();
		}
		return Class26.Class29.smethod_2(Class23.class23_0.method_0(string_0, int_0), 755, 701);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class24.smethod_0(Class0.smethod_1(1216788470, 8), 58604);
	}

	static Class22()
	{
		Class36.Class37.smethod_15();
		Class31.Class32.smethod_12();
		Class26.smethod_15();
		Class0.smethod_6();
	}

	internal static int smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return Class26.Class28.smethod_3(string_0, 24, 51);
			}
		}
	}

	internal static object smethod_3(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				return Class26.smethod_2(appDomain_0, string_0, 460, 498);
			}
		}
	}

	internal static void smethod_4(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				Class26.Class28.smethod_1(appDomain_0, string_0, object_0, 882, 802);
				return;
			}
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return Class30.smethod_14(byte_0, byte_1, evidence_0, 806, 840);
			}
		}
	}

	internal static object smethod_6(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return Class30.smethod_12(methodBase_0, object_0, object_1, 618, 581);
			}
		}
	}

	internal static bool smethod_7(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 87:
				return Class30.smethod_15(string_0, 807, 842);
			}
		}
	}

	internal static void smethod_8(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		while (true)
		{
			switch (int_4 ^ int_3)
			{
			case 36:
				Class26.Class27.smethod_8(array_0, int_0, array_1, int_1, int_2, 1018, 960);
				return;
			}
		}
	}
}
