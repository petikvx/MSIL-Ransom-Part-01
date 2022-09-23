using System;
using System.ComponentModel;

internal sealed class Class2
{
	private Class2()
	{
	}

	internal static string PsYjkc_a(Enum a)
	{
		DescriptionAttribute[] array = (DescriptionAttribute[])a.GetType().GetField(a.ToString())!.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
		if (array.Length != 0)
		{
			return array[0].Description;
		}
		return a.ToString();
	}

	internal static object PsYjkc_b(Type a, string b)
	{
		return PsYjkc_c(a, b, c: false);
	}

	internal static object PsYjkc_c(Type a, string b, bool c)
	{
		if (c)
		{
			b = b.ToLower();
		}
		foreach (Enum value in Enum.GetValues(a))
		{
			string text = PsYjkc_a(value);
			if (c)
			{
				text = text.ToLower();
			}
			if (text == b)
			{
				return value;
			}
		}
		return Enum.Parse(a, b, c);
	}
}
