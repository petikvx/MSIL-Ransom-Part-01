using System;
using System.Reflection;

namespace BmHCcZGH;

internal sealed class Class0
{
	internal static bool smethod_0(ResolveEventArgs resolveEventArgs_0, AppDomain appDomain_0, out Assembly assembly_0)
	{
		if (Class4.smethod_0(new string[1] { smethod_1() + Class7.smethod_0() + Class3.smethod_0() + Class8.smethod_0() }, resolveEventArgs_0, appDomain_0, out var assembly_))
		{
			assembly_0 = assembly_;
			return true;
		}
		assembly_0 = null;
		return false;
	}

	internal static string smethod_1()
	{
		return "a";
	}
}
