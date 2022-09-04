using System;
using System.Runtime.CompilerServices;

internal sealed class Class14
{
	[SpecialName]
	public static string smethod_0()
	{
		return smethod_2() + " " + smethod_1();
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = new Version("6.0.0.503");
		return version.Major;
	}

	[SpecialName]
	public static string smethod_2()
	{
		return "SmartAssembly";
	}
}
