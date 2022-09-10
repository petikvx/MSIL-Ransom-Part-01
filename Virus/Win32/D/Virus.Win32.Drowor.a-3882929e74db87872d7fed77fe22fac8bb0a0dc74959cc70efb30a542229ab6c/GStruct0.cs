using System.Collections.Generic;
using System.Runtime.CompilerServices;

public struct GStruct0
{
	private string string_0;

	private List<KeyValuePair<string, int>> list_0;

	[SpecialName]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	public List<KeyValuePair<string, int>> method_1()
	{
		return list_0;
	}

	[SpecialName]
	public int method_2()
	{
		if (list_0.Count == 1)
		{
			if (list_0[0].Key == "Crop")
			{
				return list_0[0].Value;
			}
			return 0;
		}
		return list_0[0].Value;
	}

	public GStruct0(string string_1, params KeyValuePair<string, int>[] keyValuePair_0)
	{
		string_0 = string_1;
		list_0 = new List<KeyValuePair<string, int>>();
		for (int i = 0; i < keyValuePair_0.Length; i++)
		{
			list_0.Add(keyValuePair_0[i]);
		}
	}
}
