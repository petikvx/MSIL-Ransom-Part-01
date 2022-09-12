using System;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns8;

namespace ns5;

internal sealed class Class5
{
	[NonSerialized]
	internal static GetString getString_0;

	[SpecialName]
	public static string smethod_0()
	{
		return getString_0(107391393) + Class3.smethod_0();
	}

	[SpecialName]
	public static string smethod_1()
	{
		return getString_0(107391336) + Class3.smethod_0();
	}

	static Class5()
	{
		Strings.CreateGetStringDelegate(typeof(Class5));
	}
}
