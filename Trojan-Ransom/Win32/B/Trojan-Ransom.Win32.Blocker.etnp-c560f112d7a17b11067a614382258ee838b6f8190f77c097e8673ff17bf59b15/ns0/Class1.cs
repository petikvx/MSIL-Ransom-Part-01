using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class1
{
	[SpecialName]
	public static string smethod_0()
	{
		return smethod_2() + Class5.smethod_0(79261) + smethod_1();
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = new Version(Class5.smethod_0(79266));
		return version.Major;
	}

	[SpecialName]
	public static string smethod_2()
	{
		return Class5.smethod_0(79283);
	}
}
