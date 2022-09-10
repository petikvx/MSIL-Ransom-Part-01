using System;
using System.Security;
using My;

namespace ns0;

internal sealed class Attribute0 : Attribute
{
	internal readonly string s;

	internal Attribute0(string string_0)
	{
		s = string_0;
		MyApplication.smethod_4();
		Class11.smethod_8();
	}

	[SecuritySafeCritical]
	static Attribute0()
	{
		Class7.smethod_6();
		MyApplication.smethod_9();
	}
}
