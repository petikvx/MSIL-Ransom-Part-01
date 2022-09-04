using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class4
{
	[SpecialName]
	public static string smethod_0()
	{
		return "SmartAssembly" + " " + smethod_1();
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = new Version("6.8.0.121");
		return version.Major;
	}

	[SpecialName]
	public static string smethod_2()
	{
		return "SmartAssembly";
	}
}
