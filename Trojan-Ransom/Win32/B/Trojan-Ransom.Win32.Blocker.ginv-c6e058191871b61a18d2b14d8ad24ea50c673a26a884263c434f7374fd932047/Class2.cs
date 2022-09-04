using System;
using System.Collections.Generic;

internal class Class2
{
	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private string string_0;

	private List<string[]> method_0()
	{
		List<string[]> list = new List<string[]>();
		for (int i = 0; i < list_0.Count; i++)
		{
			string string_ = list_0[i];
			string text = method_1(string_, "id");
			string text2 = method_1(string_, "classid");
			string text3 = string.Empty;
			for (int j = 0; j < list_1.Count; j++)
			{
				if (method_1(list_1[j], "classid") == text2)
				{
					text3 = list_1[j];
					break;
				}
			}
			if (text3 != string.Empty)
			{
				string[] item = new string[6]
				{
					method_1(text3, "appid"),
					method_1(string_, "amount"),
					text,
					method_1(text3, "market_name"),
					method_1(text3, "type").ToLower(),
					string_0
				};
				if (!list.Contains(item) && method_1(text3, "tradable") == "1")
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	private string method_1(string string_1, string string_2)
	{
		string[] array = string_1.Split(new char[2] { '"', ':' }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (array[num] == string_2)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return array[num + 1].Replace(",", "");
	}

	public List<string[]> method_2(string string_1, string string_2)
	{
		string_0 = string_2;
		string[] array = string_1.Split('{', '}');
		if (array.Length > 2 && array[1].IndexOf("true") != -1)
		{
			method_4(array);
			method_3(array);
			return method_0();
		}
		return new List<string[]>();
	}

	private void method_3(string[] string_1)
	{
		int num = -1;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (string_1[i].IndexOf("rgDescriptions") != -1)
			{
				num = i + 1;
				break;
			}
		}
		for (int j = num; j < string_1.Length; j++)
		{
			string[] array = string_1[j].Split(new char[1] { '"' });
			if (array.Length > 2 && array[1] == "appid")
			{
				list_1.Add(string_1[j]);
			}
		}
	}

	private void method_4(string[] string_1)
	{
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (string_1[i].IndexOf("rgInventory") != -1)
			{
				num = i + 1;
			}
			if (num != -1 && string_1[i] == "")
			{
				num2 = i;
				break;
			}
		}
		for (int j = num; j < num2; j++)
		{
			string[] array = string_1[j].Split(new char[1] { '"' });
			if (array.Length > 2 && array[1] == "id")
			{
				list_0.Add(string_1[j]);
			}
		}
	}
}
