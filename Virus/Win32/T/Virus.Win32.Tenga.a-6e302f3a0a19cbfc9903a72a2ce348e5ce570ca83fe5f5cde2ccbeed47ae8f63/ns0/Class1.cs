using System.Collections.Generic;
using System.IO;

namespace ns0;

internal class Class1
{
	public static List<string> smethod_0(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (!string_1.EndsWith("="))
		{
			string_1 += "=";
		}
		if (!string_0.Contains(string_1))
		{
			return null;
		}
		List<string> list = new List<string>();
		int num = string_0.IndexOf(string_1) + 3;
		int num2 = string_0.IndexOf(',', num) - num;
		if (num2 == 0)
		{
			return null;
		}
		if (num2 > 0)
		{
			list.Add(string_0.Substring(num, num2));
			List<string> list2 = smethod_0(string_0.Substring(num + num2), string_1);
			if (list2 != null)
			{
				list.AddRange(list2);
			}
		}
		else
		{
			list.Add(string_0.Substring(num));
		}
		return list;
	}

	public static string smethod_1(string string_0)
	{
		string text = "";
		if (string_0.Length > 0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				int num = string_0[i];
				if ((num >= 48 && num <= 57) || (num >= 65 && num <= 90) || (num >= 97 && num <= 122))
				{
					text += string_0[i];
				}
			}
		}
		return text;
	}

	public static void smethod_2(string string_0, string string_1)
	{
		StreamWriter streamWriter = File.AppendText(string_1);
		streamWriter.Write(string_0);
		streamWriter.Flush();
		streamWriter.Close();
	}
}
