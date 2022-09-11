using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns12;

internal sealed class Class125
{
	private readonly bool bool_0;

	[CompilerGenerated]
	private string string_0;

	public string ContextMarkers
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public Class125(string string_1, bool bool_1)
	{
		ContextMarkers = string_1;
		bool_0 = bool_1;
	}

	public int method_0(string string_1, string string_2)
	{
		return method_1(string_1, string_2, 0);
	}

	public int method_1(string string_1, string string_2, int int_0)
	{
		int num = string_1.IndexOf(string_2, int_0);
		while (num != -1 && method_2(string_1, num, int_0))
		{
			num = string_1.IndexOf(string_2, num + 1);
		}
		return num;
	}

	private bool method_2(string string_1, int int_0, int int_1)
	{
		char c = '\0';
		bool flag = false;
		for (int i = int_1; i < int_0; i++)
		{
			char c2 = string_1[i];
			int num = ContextMarkers.IndexOf(c2);
			if (num > -1 && c == ContextMarkers[num] && !flag)
			{
				c = '\0';
			}
			else if (c == '\0' && num > -1 && !flag)
			{
				c = c2;
			}
			else if (c2 == '\\' && bool_0)
			{
				flag = !flag;
			}
		}
		return c != '\0' || flag;
	}

	public int method_3(string string_1, char char_0)
	{
		char c = '\0';
		bool flag = false;
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_1.Length)
			{
				char c2 = string_1[num2];
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
					if (c == '\0' && c2 == char_0)
					{
						break;
					}
					if (c2 == '\\' && bool_0)
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

	public string[] method_4(string string_1, string string_2)
	{
		ArrayList arrayList = new ArrayList();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		char c = '\0';
		foreach (char c2 in string_1)
		{
			if (string_2.IndexOf(c2) != -1 && !flag)
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
			if (c2 == '\\' && bool_0)
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
