using System.Collections;
using System.Text;

namespace MySql.Data.Common;

internal class ContextString
{
	private readonly bool _escapeBackslash;

	public string ContextMarkers { get; set; }

	public ContextString(string contextMarkers, bool escapeBackslash)
	{
		ContextMarkers = contextMarkers;
		_escapeBackslash = escapeBackslash;
	}

	public int IndexOf(string src, string target)
	{
		return IndexOf(src, target, 0);
	}

	public int IndexOf(string src, string target, int startIndex)
	{
		int num = src.IndexOf(target, startIndex);
		while (num != -1 && IndexInQuotes(src, num, startIndex))
		{
			num = src.IndexOf(target, num + 1);
		}
		return num;
	}

	private bool IndexInQuotes(string src, int index, int startIndex)
	{
		char c = '\0';
		bool flag = false;
		for (int i = startIndex; i < index; i++)
		{
			char c2 = src[i];
			int num = ContextMarkers.IndexOf(c2);
			if (num > -1 && c == ContextMarkers[num] && !flag)
			{
				c = '\0';
			}
			else if (c == '\0' && num > -1 && !flag)
			{
				c = c2;
			}
			else if (c2 == '\\' && _escapeBackslash)
			{
				flag = !flag;
			}
		}
		return c != '\0' || flag;
	}

	public int IndexOf(string src, char target)
	{
		char c = '\0';
		bool flag = false;
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < src.Length)
			{
				char c2 = src[num2];
				int num3 = ContextMarkers.IndexOf(c2);
				if (num3 > -1 && c == ContextMarkers[num3] && !flag)
				{
					c = '\0';
				}
				else if (c == '\0' && num3 > -1 && !flag)
				{
					c = c2;
				}
				else
				{
					if (c == '\0' && c2 == target)
					{
						break;
					}
					if (c2 == '\\' && _escapeBackslash)
					{
						flag = !flag;
					}
				}
				num++;
				num2++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public string[] Split(string src, string delimiters)
	{
		ArrayList arrayList = new ArrayList();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		char c = '\0';
		foreach (char c2 in src)
		{
			if (delimiters.IndexOf(c2) != -1 && !flag)
			{
				if (c != 0)
				{
					stringBuilder.Append(c2);
				}
				else if (stringBuilder.Length > 0)
				{
					arrayList.Add(stringBuilder.ToString());
					stringBuilder.Remove(0, stringBuilder.Length);
				}
				continue;
			}
			if (c2 == '\\' && _escapeBackslash)
			{
				flag = !flag;
				continue;
			}
			int num = ContextMarkers.IndexOf(c2);
			if (!flag && num != -1)
			{
				if (num % 2 == 1)
				{
					if (c == ContextMarkers[num - 1])
					{
						c = '\0';
					}
				}
				else if (c == ContextMarkers[num + 1])
				{
					c = '\0';
				}
				else if (c == '\0')
				{
					c = c2;
				}
			}
			stringBuilder.Append(c2);
		}
		if (stringBuilder.Length > 0)
		{
			arrayList.Add(stringBuilder.ToString());
		}
		return (string[])arrayList.ToArray(typeof(string));
	}
}
