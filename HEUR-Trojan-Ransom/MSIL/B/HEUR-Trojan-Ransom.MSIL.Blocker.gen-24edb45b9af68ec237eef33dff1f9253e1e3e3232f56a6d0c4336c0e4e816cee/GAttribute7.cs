using System;
using System.Text.RegularExpressions;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute7 : Attribute, GInterface0
{
	private RegexOptions regexOptions_0;

	private string string_0;

	private string string_1;

	public string String_1 => string_1;

	public RegexOptions RegexOptions_0
	{
		get
		{
			return regexOptions_0;
		}
		set
		{
			regexOptions_0 = value;
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public GAttribute7()
	{
		if (1 == 0)
		{
		}
		string_0 = string.Empty;
		string_1 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		bool flag = false;
		int num = 0;
		string text = default(string);
		Regex regex = default(Regex);
		while (true)
		{
			switch (num)
			{
			case 1:
				text = object_0 as string;
				num = 2;
				continue;
			case 0:
				regex = new Regex(string_0, regexOptions_0);
				num = 1;
				continue;
			}
			if (!string.IsNullOrEmpty(text))
			{
				flag = regex.IsMatch(text);
			}
			if (!flag)
			{
				string_1 = $"The value '{text}' does not match the regular expression '{string_0}'.";
			}
			return flag;
		}
	}
}
