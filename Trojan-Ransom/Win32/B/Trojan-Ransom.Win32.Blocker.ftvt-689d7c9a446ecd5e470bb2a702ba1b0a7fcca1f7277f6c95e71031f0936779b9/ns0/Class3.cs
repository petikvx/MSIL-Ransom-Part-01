using System;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns0;

internal sealed class Class3
{
	[NonSerialized]
	internal static GetString getString_0;

	static Class3()
	{
		Strings.CreateGetStringDelegate(typeof(Class3));
	}

	[SpecialName]
	public static string smethod_0()
	{
		return smethod_2() + getString_0(376) + smethod_1();
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = new Version(getString_0(381));
		return version.Major;
	}

	[SpecialName]
	public static string smethod_2()
	{
		return getString_0(394);
	}
}
