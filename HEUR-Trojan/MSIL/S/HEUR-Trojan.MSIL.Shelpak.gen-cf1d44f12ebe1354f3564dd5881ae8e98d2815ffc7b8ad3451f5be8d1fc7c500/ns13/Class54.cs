using System.Collections.Generic;

namespace ns13;

internal sealed class Class54
{
	public static int int_0 = 0;

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static int int_4 = 0;

	public static int int_5 = 0;

	public static int int_6 = 0;

	public static int int_7 = 0;

	public static int int_8 = 0;

	public static int int_9 = 0;

	public static int int_10 = 0;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public static int int_11 = 0;

	public static bool bool_4 = false;

	public static bool bool_5 = false;

	public static bool bool_6 = false;

	public static int int_12 = 0;

	public static int int_13 = 0;

	public static int int_14 = 0;

	public static int int_15 = 0;

	public static bool bool_7 = false;

	public static bool bool_8 = false;

	public static bool bool_9 = false;

	public static List<string> list_0 = new List<string>();

	public static List<string> list_1 = new List<string>();

	public static List<string> list_2 = new List<string>();

	public static string smethod_0(string string_0, bool bool_10)
	{
		if (!bool_10)
		{
			return "";
		}
		return "\n   ∟ " + string_0;
	}

	public static string smethod_1(string string_0, int int_16)
	{
		if (int_16 == 0)
		{
			return "";
		}
		return "\n   ∟ " + string_0 + ": " + int_16;
	}

	public static string smethod_2(string string_0, List<string> list_3, char char_0 = '∟')
	{
		list_3.Sort();
		if (list_3.Count == 0)
		{
			return "\n   ∟ " + string_0 + " (No data)";
		}
		return "\n   ∟ " + string_0 + ":\n\t\t\t\t\t\t\t" + char_0 + " " + string.Join("\n\t\t\t\t\t\t\t" + char_0 + " ", list_3);
	}

	public static string smethod_3(bool bool_10, string string_0, string string_1)
	{
		if (!bool_10)
		{
			return "\n   ∟ " + string_1;
		}
		return "\n   ∟ " + string_0;
	}
}
