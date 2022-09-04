using System.IO;
using ns4;
using ns6;
using ns7;

namespace ns2;

internal class Class13
{
	private static Stream stream_0;

	static Class13()
	{
		if (stream_0 == null)
		{
			stream_0 = Class18.smethod_15(Class18.smethod_14(16455), "UsersStringsStream", 21202);
		}
	}

	internal static string smethod_0(int int_0)
	{
		BinaryReader binaryReader_ = new BinaryReader(stream_0);
		Class21.smethod_0(Class20.smethod_19(binaryReader_, 1375), int_0, 31857);
		return smethod_1(Class21.smethod_1(binaryReader_, 12301));
	}

	internal static string smethod_1(string string_0)
	{
		byte[] byte_ = Class21.smethod_2(string_0, 6361);
		return Class18.smethod_8(Class18.smethod_6(59429), byte_, 9886);
	}

	internal static string smethod_2(int int_0)
	{
		return smethod_0(int_0);
	}
}
