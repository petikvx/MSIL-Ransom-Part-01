using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Security;

namespace ns0;

internal sealed class Class7
{
	[SecuritySafeCritical]
	static Class7()
	{
		Class0.Class1.smethod_1();
	}

	[SecuritySafeCritical]
	internal static PackagePart smethod_0(Package package_0, Uri uri_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 11:
				return Class0.Class5.Class6.smethod_0(package_0, uri_0, 934, 929);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_1(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 105:
				return Class0.Class5.smethod_0(type_0, 1022, 928);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_2(MemberInfo memberInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 114:
				return Class0.Class1.smethod_4(memberInfo_0, 764, 707);
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return Class0.Class5.smethod_1(282, 286);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_4(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return Class0.Class1.Class2.smethod_1(appDomain_0, string_0, 75, 94);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_5(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 31:
				Class0.smethod_7(stream_0, byte_0, int_0, int_1, 386, 485);
				return;
			}
		}
	}
}
