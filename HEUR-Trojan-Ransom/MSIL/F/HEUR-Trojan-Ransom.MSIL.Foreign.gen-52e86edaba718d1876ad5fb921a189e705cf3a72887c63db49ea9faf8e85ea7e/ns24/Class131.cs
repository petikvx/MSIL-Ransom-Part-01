using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns24;

internal sealed class Class131
{
	private static bool bool_0;

	private static bool bool_1;

	[NonSerialized]
	internal static GetString getString_0;

	private Class131()
	{
	}

	public static bool smethod_0()
	{
		PlatformID platform = Environment.OSVersion.Platform;
		if ((uint)platform <= 2u)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_1()
	{
		if (!bool_0)
		{
			smethod_2();
		}
		return bool_1;
	}

	private static void smethod_2()
	{
		bool_0 = true;
		bool_1 = Type.GetType(getString_0(107365516)) != null;
	}

	public static bool smethod_3()
	{
		return false;
	}

	static Class131()
	{
		Strings.CreateGetStringDelegate(typeof(Class131));
	}
}
