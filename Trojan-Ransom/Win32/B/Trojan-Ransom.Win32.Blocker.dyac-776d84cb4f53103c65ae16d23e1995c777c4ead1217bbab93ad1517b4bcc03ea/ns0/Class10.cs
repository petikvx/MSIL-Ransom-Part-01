using System;
using System.Collections;
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
			Class4.smethod_2();
			if (Class0.smethod_1(Class0.Class1.smethod_0(187, 'Ý'), new DateTime(635305920631396484L), 819, 849))
			{
				throw new Exception();
			}
			class11_0 = new Class11();
		}

		private Class11()
		{
			Assembly gparam_ = Class0.smethod_2('K', 29);
			Stream stream = (Stream)(IDisposable)Class4.smethod_3(gparam_, smethod_1(), 773, 804);
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				Class12.smethod_0(stream, byte_0, 0, byte_0.Length, 346, 372);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = Class2.smethod_2(string_0, 'ʤ', 694);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(IList)Class0.Class1.smethod_1(string_0, 310, 'Ħ');
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return Class12.smethod_1(new string(array), 645, 'ʨ');
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class0.smethod_1(Class0.Class1.smethod_0(421, 'ǃ'), new DateTime(635305920632851562L), 252, 158))
		{
			throw new Exception();
		}
		return Class12.smethod_1(Class11.class11_0.method_0(string_0, int_0), 643, 'ʮ');
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "61ea08ad039641ffa08e26e0b6b9d20d";
	}
}
