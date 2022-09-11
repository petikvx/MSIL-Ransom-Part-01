using System;
using System.Runtime.CompilerServices;

namespace ns3;

internal class Class18
{
	private string string_0 = string.Empty;

	private string string_1;

	private string string_2;

	internal static Func<string, bool> func_0;

	public Class18(string string_3, string string_4)
	{
		method_1(string_3);
		method_3(string_4);
	}

	[SpecialName]
	public string method_0()
	{
		return string_1;
	}

	[SpecialName]
	private void method_1(string string_3)
	{
		string_1 = string_3;
	}

	[SpecialName]
	public string method_2()
	{
		return string_2;
	}

	[SpecialName]
	private void method_3(string string_3)
	{
		string_2 = string_3;
	}

	internal static bool smethod_0(string string_3)
	{
		return !string.IsNullOrEmpty(string_3);
	}
}
