using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class GClass8
{
	[CompilerGenerated]
	private sealed class Class3
	{
		public string string_0;

		public bool method_0(string string_1)
		{
			return string_1 == string_0;
		}
	}

	private List<string> list_0;

	private int int_0;

	[SpecialName]
	public List<string> method_0()
	{
		return list_0;
	}

	[SpecialName]
	public void method_1(List<string> list_1)
	{
		list_0 = list_1;
	}

	public GClass8()
	{
		list_0 = new List<string>();
		int_0 = 10;
	}

	public void method_2(string string_0)
	{
		if (list_0.Count <= int_0)
		{
			list_0.Add(string_0);
		}
	}

	public void method_3(int int_1)
	{
		list_0.RemoveAt(int_1);
	}

	public void method_4(string string_0)
	{
		int num = list_0.FindIndex((string string_1) => string_1 == string_0);
		if (num != -1)
		{
			list_0.RemoveAt(num);
		}
	}
}
