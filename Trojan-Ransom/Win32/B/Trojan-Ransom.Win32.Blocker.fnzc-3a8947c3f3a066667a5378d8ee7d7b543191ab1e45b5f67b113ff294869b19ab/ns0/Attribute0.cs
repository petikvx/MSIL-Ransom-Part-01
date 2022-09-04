using System;
using System.IO;
using System.Security;

namespace ns0;

[AttributeUsage(AttributeTargets.Parameter)]
internal sealed class Attribute0 : Attribute
{
	[SecuritySafeCritical]
	static Attribute0()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static long smethod_0(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return stream_0.Length;
			}
		}
	}
}
