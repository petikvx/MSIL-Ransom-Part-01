using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using ns0;
using ns2;
using ns3;
using ns5;
using ns6;

namespace ns1;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class1
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct5
	{
		internal Struct9 struct9_0;

		internal Struct9 struct9_1;

		internal Struct10[] struct10_0;

		internal Struct10[] struct10_1;

		internal Struct10 struct10_2;

		internal uint uint_0;

		static Struct5()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class1()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (GClass2.smethod_5(resourceManager_0, null, 324, 346))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(Class21.smethod_0(68), Class0.smethod_3(GClass2.smethod_1(typeof(Class1).TypeHandle, 580, 517), 154, 199)));
		}
		return resourceManager_0;
	}

	internal static byte[] smethod_1()
	{
		return (byte[])Class2.smethod_4(smethod_0(), Exception0.smethod_0(859720288, 8), cultureInfo_0, 958, 970);
	}

	static Class1()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static int smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 9:
				return stream_0.Read(byte_0, int_0, int_1);
			case 10:
				return stream_0.Read(byte_0, int_0, int_1);
			case 11:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	internal static bool smethod_3(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return Class7.smethod_11(process_0, 935, 965);
			}
		}
	}

	internal static string[] smethod_4(string string_0, char[] char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return Class9.smethod_9(string_0, char_0, 615, 551);
			}
		}
	}

	internal static AppDomain smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return Class9.Class10.Class11.smethod_0(711, 645);
			case 114:
				return Class9.Class10.Class11.smethod_0(805, 871);
			}
		}
	}

	internal static long smethod_6(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				return Class7.smethod_2(stream_0, 93, 111);
			}
		}
	}
}
