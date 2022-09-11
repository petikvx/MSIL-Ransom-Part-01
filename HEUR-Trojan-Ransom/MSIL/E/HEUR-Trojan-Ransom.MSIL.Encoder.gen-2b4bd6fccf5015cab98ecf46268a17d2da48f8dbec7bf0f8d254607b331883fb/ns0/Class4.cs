using System;
using System.Globalization;

namespace ns0;

internal sealed class Class4
{
	internal string[] string_0;

	internal bool[] bool_0;

	internal bool[] bool_1;

	public static string smethod_0()
	{
		return "Me";
	}

	internal Class4(string[] string_1)
	{
		string[] array = (string_0 = new string[string_1.Length]);
		bool[] array2 = (bool_0 = new bool[string_1.Length]);
		bool[] array3 = (bool_1 = new bool[string_1.Length]);
		for (int i = 0; i < string_1.Length; i++)
		{
			string text = string_1[i].ToLower(CultureInfo.InvariantCulture);
			if (text.StartsWith("*", StringComparison.Ordinal))
			{
				bool_0[i] = true;
				bool_1[i] = true;
				text = text.Substring(1);
			}
			else if (text.StartsWith("+", StringComparison.Ordinal))
			{
				bool_0[i] = false;
				bool_1[i] = true;
				text = text.Substring(1);
			}
			string_0[i] = text;
		}
	}

	internal string method_0(string string_1, out bool bool_2, out bool bool_3)
	{
		bool flag = false;
		int num = -1;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (string_1.Equals(string_0[num2], StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				if (string_0[num2].StartsWith(string_1, StringComparison.OrdinalIgnoreCase))
				{
					if (flag)
					{
						throw new ApplicationException("");
					}
					flag = true;
					num = num2;
				}
				num2++;
				continue;
			}
			if (flag)
			{
				bool_2 = bool_0[num];
				bool_3 = bool_1[num];
				return string_0[num];
			}
			throw new ApplicationException("");
		}
		bool_2 = bool_0[num2];
		bool_3 = bool_1[num2];
		return string_0[num2];
	}
}
