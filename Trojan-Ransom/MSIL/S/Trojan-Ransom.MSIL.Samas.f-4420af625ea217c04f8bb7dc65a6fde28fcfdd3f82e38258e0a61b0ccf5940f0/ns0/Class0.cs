using System;
using System.Diagnostics;
using ns1;

namespace ns0;

internal sealed class Class0
{
	public static string string_0 = Environment.NewLine;

	public static int int_0 = 10240;

	public static int int_1 = 3072;

	public static void smethod_0(string string_1)
	{
		foreach (Process item in Class32.smethod_4(string_1))
		{
			Class32.smethod_36(item, bool_0: true);
		}
	}
}
