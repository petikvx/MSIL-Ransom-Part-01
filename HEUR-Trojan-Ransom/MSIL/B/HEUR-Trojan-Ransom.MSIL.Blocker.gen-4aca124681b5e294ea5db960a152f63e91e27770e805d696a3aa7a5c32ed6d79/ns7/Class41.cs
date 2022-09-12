using System;
using System.Globalization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.Shared.ReportHelper;
using SmartAssembly.SmartUsageCore;
using ns10;
using ns2;
using ns4;
using ns6;
using ns8;

namespace ns7;

internal static class Class41
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void smethod_0()
	{
		try
		{
			smethod_1();
			Version version_ = OsInformation.smethod_2(Environment.OSVersion.Version);
			smethod_7(getString_0(107384910) + OsInformation.smethod_0(version_));
			smethod_7(getString_0(107384861) + OsInformation.smethod_4(version_));
			smethod_2();
			smethod_3();
			smethod_4();
		}
		catch
		{
		}
	}

	private static void smethod_1()
	{
		string text = getString_0(107390168);
		if (smethod_5(getString_0(107384864)))
		{
			text = getString_0(107384827) + smethod_6() + getString_0(107384818);
		}
		else if (smethod_5(getString_0(107384833)))
		{
			text = getString_0(107384792);
		}
		else if (smethod_5(getString_0(107384799)))
		{
			text = getString_0(107384758);
		}
		else if (smethod_5(getString_0(107384733)))
		{
			text = getString_0(107384748);
		}
		else if (smethod_5(getString_0(107384691)))
		{
			text = getString_0(107384710);
		}
		smethod_7(getString_0(107385197) + text);
	}

	private static void smethod_2()
	{
		try
		{
			smethod_7(getString_0(107385136) + Environment.ProcessorCount);
		}
		catch
		{
		}
	}

	private static void smethod_3()
	{
		try
		{
			smethod_7(getString_0(107385107) + CultureInfo.CurrentCulture.Name);
		}
		catch
		{
		}
	}

	private static void smethod_4()
	{
		try
		{
			smethod_7(getString_0(107385074) + (OsVersionInformation.smethod_1() ? getString_0(107385040) : getString_0(107385045)));
		}
		catch
		{
		}
	}

	private unsafe static bool smethod_5(string string_0)
	{
		void* ptr = stackalloc byte[2];
		Enum3 enum3_;
		using (Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, getString_0(107385067) + string_0, out enum3_) ?? Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, getString_0(107385006) + string_0, out enum3_))
		{
			*(bool*)ptr = enum3_ == Enum3.const_2;
		}
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	private static string smethod_6()
	{
		Enum3 enum3_;
		using Class7 @class = Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, getString_0(107384417), out enum3_) ?? Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, getString_0(107384316), out enum3_);
		if (enum3_ != 0)
		{
			return getString_0(107384263);
		}
		int valueOrDefault = (@class.vmethod_0(getString_0(107384258)) as int?).GetValueOrDefault();
		if (valueOrDefault >= 461808)
		{
			return getString_0(107384213);
		}
		if (valueOrDefault >= 461308)
		{
			return getString_0(107384224);
		}
		if (valueOrDefault >= 460798)
		{
			return getString_0(107384183);
		}
		if (valueOrDefault >= 394802)
		{
			return getString_0(107384178);
		}
		if (valueOrDefault >= 394254)
		{
			return getString_0(107384201);
		}
		if (valueOrDefault >= 393295)
		{
			return getString_0(107384192);
		}
		if (valueOrDefault >= 379893)
		{
			return getString_0(107384667);
		}
		if (valueOrDefault >= 378675)
		{
			return getString_0(107384658);
		}
		if (valueOrDefault >= 378389)
		{
			return getString_0(107384681);
		}
		return getString_0(107384263);
	}

	public static void smethod_7([FeatureName] string string_0)
	{
		Class46.smethod_1(string_0);
	}

	static Class41()
	{
		Strings.CreateGetStringDelegate(typeof(Class41));
	}
}
