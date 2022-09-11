using System;
using System.Collections.Generic;
using ns12;

namespace ns22;

internal sealed class Class55
{
	private object[] object_0;

	private Dictionary<string, int> dictionary_0;

	public object this[int int_0] => method_1(int_0);

	public object this[string string_0] => method_2(string_0);

	internal Class55(Dictionary<string, int> dictionary_1, object[] object_1)
	{
		object_0 = object_1;
		dictionary_0 = dictionary_1;
	}

	public string method_0(string string_0)
	{
		return method_2(string_0).ToString();
	}

	private object method_1(int int_0)
	{
		if (int_0 < 0 || int_0 >= object_0.Length)
		{
			throw new IndexOutOfRangeException(string.Format(Class122.InvalidRowIndex, int_0));
		}
		return object_0[int_0];
	}

	private object method_2(string string_0)
	{
		if (!dictionary_0.ContainsKey(string_0))
		{
			throw new InvalidOperationException(string.Format(Class122.InvalidNameIndex, string_0));
		}
		return method_1(dictionary_0[string_0]);
	}
}
