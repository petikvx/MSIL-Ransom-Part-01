using System.Text.RegularExpressions;

namespace VjMQkoKRLykc;

internal sealed class Class10
{
	private string string_0;

	internal Regex regex_0;

	internal Class10(string string_1)
	{
		Regex regex = (regex_0 = null);
		string_0 = string_1;
	}

	internal Match method_0(string string_1)
	{
		method_2();
		return regex_0.Match(string_1);
	}

	internal static void smethod_0(byte[] byte_0)
	{
		for (int i = 0; i < Class0.byte_0.Length; i++)
		{
			GClass1.smethod_0(byte_0, i);
		}
	}

	internal int method_1(string string_1)
	{
		method_2();
		return regex_0.GroupNumberFromName(string_1);
	}

	internal void method_2()
	{
		string pattern = string_0;
		if (regex_0 == null)
		{
			Regex regex = (regex_0 = new Regex(pattern));
			string_0 = null;
		}
	}
}
