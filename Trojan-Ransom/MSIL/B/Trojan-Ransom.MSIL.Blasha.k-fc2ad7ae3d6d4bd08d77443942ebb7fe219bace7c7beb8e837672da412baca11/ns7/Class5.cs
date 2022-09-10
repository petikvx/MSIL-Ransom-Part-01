using System;
using System.Runtime.CompilerServices;

namespace ns7;

internal sealed class Class5
{
	[SpecialName]
	public static string smethod_0()
	{
		return smethod_2() + " " + smethod_1();
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = new Version("6.10.0.218");
		return version.Major;
	}

	[SpecialName]
	public static string smethod_2()
	{
		return "SmartAssembly";
	}
}
