using System.Collections.Generic;
using System.Text;

namespace v_BrunoShift;

public static class BrunoShifter
{
	private static Dictionary<string, string> _KEYMAP;

	public static void Initialize()
	{
		_KEYMAP = new Dictionary<string, string>();
		_KEYMAP.Add("a", "z");
		_KEYMAP.Add("b", "y");
		_KEYMAP.Add("c", "x");
		_KEYMAP.Add("d", "w");
		_KEYMAP.Add("e", "v");
		_KEYMAP.Add("f", "u");
		_KEYMAP.Add("g", "t");
		_KEYMAP.Add("h", "s");
		_KEYMAP.Add("i", "r");
		_KEYMAP.Add("j", "q");
		_KEYMAP.Add("k", "p");
		_KEYMAP.Add("l", "o");
		_KEYMAP.Add("m", "n");
		_KEYMAP.Add("n", "m");
		_KEYMAP.Add("o", "l");
		_KEYMAP.Add("p", "k");
		_KEYMAP.Add("q", "j");
		_KEYMAP.Add("r", "i");
		_KEYMAP.Add("s", "h");
		_KEYMAP.Add("t", "g");
		_KEYMAP.Add("u", "f");
		_KEYMAP.Add("v", "e");
		_KEYMAP.Add("w", "d");
		_KEYMAP.Add("x", "c");
		_KEYMAP.Add("y", "b");
		_KEYMAP.Add("z", "a");
	}

	public static string DeBruno(string input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < input.Length; i++)
		{
			string text = input[i].ToString();
			if (text == text.ToUpper())
			{
				text = text.ToUpper();
			}
			foreach (KeyValuePair<string, string> item in _KEYMAP)
			{
				if (item.Value == text)
				{
					stringBuilder.Append(item.Key);
				}
			}
			if (stringBuilder.Length - 1 != i)
			{
				stringBuilder.Append(text);
			}
		}
		input = stringBuilder.ToString();
		int num = input.Length / 2;
		string text2 = input.Substring(0, num);
		string text3 = input.Substring(num, input.Length - num);
		stringBuilder = new StringBuilder();
		for (int j = 0; j < input.Length; j++)
		{
			if (j % 2 == 0)
			{
				stringBuilder.Append(text3[j / 2]);
			}
			else
			{
				stringBuilder.Append(text2[j / 2]);
			}
		}
		return stringBuilder.ToString();
	}
}
