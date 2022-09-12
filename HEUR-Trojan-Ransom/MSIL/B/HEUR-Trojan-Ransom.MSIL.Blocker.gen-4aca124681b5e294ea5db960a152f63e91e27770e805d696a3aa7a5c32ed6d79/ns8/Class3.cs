using System;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns8;

internal sealed class Class3
{
	private static Version version_0;

	private static string string_0;

	[NonSerialized]
	internal static GetString getString_0;

	[SpecialName]
	public static string smethod_0()
	{
		return smethod_2() + getString_0(107396182) + smethod_1();
	}

	[SpecialName]
	public static int smethod_1()
	{
		return version_0.Major;
	}

	[SpecialName]
	public static string smethod_2()
	{
		return getString_0(107391406);
	}

	static Class3()
	{
		Strings.CreateGetStringDelegate(typeof(Class3));
		version_0 = new Version(getString_0(107391417));
		string_0 = null;
	}
}
