using System;

namespace ns0;

internal sealed class Class2
{
	internal static string smethod_0(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	internal static string smethod_1()
	{
		return "";
	}
}
