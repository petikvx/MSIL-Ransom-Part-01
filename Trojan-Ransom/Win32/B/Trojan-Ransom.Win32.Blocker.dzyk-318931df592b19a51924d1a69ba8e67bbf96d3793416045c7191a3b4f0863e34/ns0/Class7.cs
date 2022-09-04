using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class7
{
	private sealed class Class8
	{
		public static readonly Class8 class8_0;

		internal byte[] byte_0;

		static Class8()
		{
			Class5.smethod_7();
			if (Class3.smethod_2(smethod_2(108, 26), new DateTime(635307010742193197L), 227, 149))
			{
				throw new Exception();
			}
			class8_0 = new Class8();
		}

		private Class8()
		{
			Assembly assembly_ = Class5.smethod_4(595, 521);
			Stream stream = Class1.smethod_2(assembly_, smethod_1(), 219, 224);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class9.Class10.smethod_0(stream, byte_0, 0, byte_0.Length, 294, 268);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class0.smethod_1(string_0, 837, 850);
			int num2 = int_0 & 0xFF;
			char[] array = Class1.smethod_3(string_0, 488, 441);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class9.smethod_0(new string(array), 47, 94);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class3.smethod_2(smethod_2(254, 136), new DateTime(635307010742613221L), 907, 1021))
		{
			throw new Exception();
		}
		return Class9.smethod_0(Class8.class8_0.method_0(string_0, int_0), 622, 543);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class3.smethod_3(1726087981, 0);
	}

	static Class7()
	{
		Class5.smethod_7();
	}

	internal static DateTime smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return Class9.Class10.smethod_1(408, 457);
			}
		}
	}

	internal static byte[] smethod_3(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 70:
				return Class9.smethod_1(encoding_0, string_0, 670, 676);
			}
		}
	}

	internal static string smethod_4(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return Class9.Class11.smethod_1(string_0, string_1, 751, 763);
			}
		}
	}

	internal static int smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 29:
				return Class9.Class10.smethod_0(stream_0, byte_0, int_0, int_1, 587, 609);
			}
		}
	}

	internal static Assembly smethod_6(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return Class9.Class11.smethod_2(byte_0, byte_1, evidence_0, 393, 484);
			}
		}
	}
}
