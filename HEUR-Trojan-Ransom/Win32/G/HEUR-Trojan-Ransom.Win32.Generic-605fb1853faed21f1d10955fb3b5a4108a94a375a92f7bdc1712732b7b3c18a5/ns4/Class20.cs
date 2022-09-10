using System;
using ns1;

namespace ns4;

internal sealed class Class20
{
	public static string smethod_0(string string_0)
	{
		string text = string.Empty;
		Random random = new Random(1646475713);
		string[] array = string_0.Split(new char[1] { Class19.char_0 });
		string[] array2 = array;
		foreach (string s in array2)
		{
			int value = int.Parse(s) / random.Next(10000);
			text += Convert.ToChar(value);
		}
		return text;
	}
}
