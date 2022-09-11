using System;
using System.Collections.Generic;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;

namespace ns19;

internal sealed class Class82
{
	private int int_0;

	private string string_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, object> smethod_0(string string_1)
	{
		return new Class82().method_0(string_1);
	}

	private Dictionary<string, object> method_0(string string_1)
	{
		string_0 = string_1;
		Dictionary<string, object> result = method_1();
		if (int_0 != string_0.Length)
		{
			throw new IndexOutOfRangeException(getString_0(107407237));
		}
		return result;
	}

	private Dictionary<string, object> method_1()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		method_8('{');
		if (method_4() != '}')
		{
			while (true)
			{
				string text = method_5();
				if (text == null)
				{
					break;
				}
				method_8(':');
				object obj2 = (dictionary[text] = method_2());
				if (method_4() == '}')
				{
					break;
				}
				method_8(',');
			}
		}
		method_8('}');
		return dictionary;
	}

	private object method_2()
	{
		switch (method_4())
		{
		case '"':
			return method_5();
		case '{':
			return method_1();
		case '[':
			return method_3();
		default:
		{
			string text = method_7(',', '}', ']');
			if (bool.TryParse(text, out var result))
			{
				return result;
			}
			if (text.Trim() == getString_0(107408777))
			{
				return null;
			}
			if (int.TryParse(text, out var result2))
			{
				return result2;
			}
			if (long.TryParse(text, out var result3))
			{
				return result3;
			}
			if (double.TryParse(text, out var result4))
			{
				return result4;
			}
			int num = 0;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '(')
				{
					num++;
				}
				else if (text[i] == ')')
				{
					num--;
				}
			}
			while (num > 0)
			{
				text = text + method_7(')') + getString_0(107409168);
				method_8(')');
				num--;
			}
			return new Class45(text);
		}
		}
	}

	private object[] method_3()
	{
		List<object> list = new List<object>();
		method_8('[');
		while (true)
		{
			list.Add(method_2());
			if (method_4() == ']')
			{
				break;
			}
			method_8(',');
		}
		method_8(']');
		return list.ToArray();
	}

	private char method_4()
	{
		method_10();
		if (int_0 == string_0.Length)
		{
			throw new Exception(getString_0(107407200));
		}
		return string_0[int_0];
	}

	private string method_5()
	{
		method_8('"');
		string result = method_7('"');
		method_8('"');
		return result;
	}

	private bool method_6(char[] char_0, char char_1)
	{
		int num = 0;
		while (true)
		{
			if (num < char_0.Length)
			{
				if (char_0[num] == char_1)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private string method_7(params char[] char_0)
	{
		string text = getString_0(107397618);
		while (true)
		{
			if (int_0 < string_0.Length)
			{
				char char_ = string_0[int_0++];
				if (method_6(char_0, char_))
				{
					break;
				}
				text += char_;
				continue;
			}
			throw new Exception(getString_0(107407123));
		}
		int_0--;
		return text;
	}

	private void method_8(char char_0)
	{
		if (!method_9(char_0))
		{
			throw new Exception(getString_0(107406546) + char_0 + getString_0(107407886));
		}
	}

	private bool method_9(char char_0)
	{
		method_10();
		if (int_0 == string_0.Length)
		{
			return false;
		}
		return string_0[int_0++] == char_0;
	}

	private void method_10()
	{
		while (char.IsWhiteSpace(string_0[int_0]))
		{
			int_0++;
		}
	}

	static Class82()
	{
		Strings.CreateGetStringDelegate(typeof(Class82));
	}
}
