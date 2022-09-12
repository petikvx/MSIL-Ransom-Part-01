using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class0
{
	private readonly Random random_0 = new Random();

	internal readonly bool bool_0;

	[CompilerGenerated]
	private string string_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(string string_1)
	{
		string_0 = string_1;
	}

	public Class0()
	{
		method_1(method_2(20));
	}

	private string method_2(int int_0)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			text2 += text[random_0.Next(text.Length)];
		}
		return text2;
	}
}
