using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Policy;
using System.Windows.Forms;
using SmartAssembly.License;
using SmartAssembly.Shared;

namespace ns0;

internal sealed class Class1
{
	private sealed class Class2
	{
		public static readonly Class2 class2_0;

		private AppNameFinder.Struct1 struct1_0;

		[SecuritySafeCritical]
		static Class2()
		{
			AppPathFinder.smethod_3();
			if (smethod_3(License.smethod_7(118, 15), new DateTime(635522134092702120L), 278, 267))
			{
				throw new Exception();
			}
			class2_0 = new Class2();
		}

		private Class2()
		{
			Assembly assembly_ = License.smethod_5(582, 530);
			Stream stream = Class3.smethod_1(assembly_, smethod_1(), 977, 968);
			if (stream != null)
			{
				byte[] byte_ = new byte[256];
				struct1_0.byte_0 = byte_;
				Class4.Class5.Class6.Class7.smethod_5(stream, struct1_0.byte_0, 0, struct1_0.byte_0.Length, 785, 840);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = AppPathFinder.smethod_2(string_0, 878, 787);
			int num2 = int_0 & 0xFF;
			char[] array = smethod_4(string_0, 650, 675);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (struct1_0.byte_0[num2] | int_0));
			}
			return Class4.Class5.Class6.smethod_9(new string(array), 247, 179);
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (smethod_3(License.smethod_7(479, 422), new DateTime(635522134093732179L), 672, 701))
		{
			throw new Exception();
		}
		return Class4.Class5.Class6.smethod_9(Class2.class2_0.method_0(string_0, int_0), 415, 475);
	}

	[SpecialName]
	public static string smethod_1()
	{
		return AppRegistryKeys.smethod_0(512390123, 5);
	}

	[SecuritySafeCritical]
	static Class1()
	{
		AppPathFinder.smethod_3();
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Form form_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				Class4.Class5.Class6.Class7.smethod_12(form_0, 365, 341);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_3(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				return Class4.Class5.Class6.smethod_10(dateTime_0, dateTime_1, 644, 739);
			case 30:
				return Class4.Class5.Class6.smethod_10(dateTime_0, dateTime_1, 828, 852);
			}
		}
	}

	[SecuritySafeCritical]
	internal static char[] smethod_4(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 41:
				return Class0.smethod_14(string_0, 504, 494);
			}
		}
	}

	[SecuritySafeCritical]
	internal static PackagePart smethod_5(Package package_0, Uri uri_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 60:
				return Class0.smethod_15(package_0, uri_0, 135, 186);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_6(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return Class0.smethod_16(type_0, 92, 99);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 19:
				Class4.smethod_17(stream_0, byte_0, int_0, int_1, 384, 485);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_8(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return Class4.Class5.Class6.smethod_11(byte_0, byte_1, evidence_0, 417, 476);
			}
		}
	}
}
