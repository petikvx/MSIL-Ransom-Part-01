using System;
using System.Reflection;

namespace BmHCcZGH;

internal sealed class Class7
{
	internal static string smethod_0()
	{
		return "r";
	}

	internal static MethodInfo smethod_1(Type type_0, string string_0, params Type[] type_1)
	{
		try
		{
			return type_0.GetMethod(string_0, type_1);
		}
		catch (AmbiguousMatchException)
		{
			return null;
		}
	}
}
