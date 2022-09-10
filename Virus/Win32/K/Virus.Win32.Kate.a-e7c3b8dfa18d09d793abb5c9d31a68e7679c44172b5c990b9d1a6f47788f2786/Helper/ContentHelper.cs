using System;
using System.Collections.Generic;
using System.Text;

namespace Helper;

public static class ContentHelper
{
	public static string GetMidString(string str, string start, string end)
	{
		int pos;
		return GetMidString(str, start, end, out pos);
	}

	public static int GetMidInteger(string str, string start, string end)
	{
		int pos;
		return GetMidInteger(str, start, end, out pos);
	}

	public static int GetMidInteger(string str, string start, string end, out int pos)
	{
		string midString = GetMidString(str, start, end, out pos);
		return GetInteger(midString);
	}

	public static string GetMidString(string str, string start, string end, out int pos)
	{
		pos = -1;
		if (!string.IsNullOrEmpty(str) && !string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(end))
		{
			int num = str.IndexOf(start, StringComparison.CurrentCultureIgnoreCase);
			if (-1 == num)
			{
				return null;
			}
			num += start.Length;
			int num2 = str.IndexOf(end, num, StringComparison.CurrentCultureIgnoreCase);
			if (-1 == num2)
			{
				return null;
			}
			pos = num2;
			return str.Substring(num, num2 - num).Trim();
		}
		return null;
	}

	public static int GetInteger(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return -1;
		}
		if (int.TryParse(str, out var result))
		{
			return result;
		}
		return -1;
	}

	public static List<int> GetIntegerList(string str, string del)
	{
		List<int> list = new List<int>();
		if (string.IsNullOrEmpty(str))
		{
			return list;
		}
		string[] array = str.Split(del.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		string[] array2 = array;
		foreach (string str2 in array2)
		{
			int integer = GetInteger(str2);
			if (integer != -1)
			{
				list.Add(integer);
			}
		}
		return list;
	}

	public static List<int> GetIntegerList(string str)
	{
		return GetIntegerList(str, ",");
	}

	public static string NoHtml(string result)
	{
		if (result == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		foreach (char c in result)
		{
			switch (c)
			{
			case '<':
				flag = true;
				continue;
			case '>':
				flag = false;
				continue;
			}
			if (!flag)
			{
				switch (c)
				{
				case '\n':
					stringBuilder.Append(" ");
					break;
				default:
					stringBuilder.Append(c);
					break;
				case '\t':
				case '\r':
				case ' ':
					break;
				}
			}
		}
		return stringBuilder.ToString().Trim().Replace("&yen;", "￥")
			.Replace("&nbsp;", "");
	}
}
