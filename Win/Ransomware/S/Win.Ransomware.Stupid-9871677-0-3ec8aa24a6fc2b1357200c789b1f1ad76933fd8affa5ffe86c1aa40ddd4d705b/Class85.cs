using System;
using System.Text.RegularExpressions;

internal sealed class Class85
{
	public static string string_0 = "\": \"";

	public static string smethod_0(string string_1)
	{
		return Regex.Split(Regex.Split(string_1, "\",")[0], "\"")[0];
	}

	public static bool smethod_1(string string_1)
	{
		return string_1.Contains("\"name");
	}

	public static string smethod_2(string string_1, int int_0)
	{
		try
		{
			return smethod_0(Regex.Split(string_1, string_0)[int_0]);
		}
		catch (IndexOutOfRangeException)
		{
			return "Failed to parse url";
		}
	}
}
