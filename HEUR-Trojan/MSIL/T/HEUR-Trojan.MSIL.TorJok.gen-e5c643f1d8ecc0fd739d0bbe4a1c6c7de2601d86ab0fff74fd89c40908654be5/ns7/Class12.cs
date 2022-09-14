using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Ionic;
using ns5;
using ns9;

namespace ns7;

internal sealed class Class12 : Class9
{
	internal Regex regex_0;

	private string string_0;

	internal ComparisonOperator comparisonOperator_0;

	internal string string_1;

	[SpecialName]
	internal virtual void vmethod_2(string string_2)
	{
		if (Directory.Exists(string_2))
		{
			string_1 = ".\\" + string_2 + "\\*.*";
		}
		else
		{
			string_1 = string_2;
		}
		string_0 = "^" + Regex.Escape(string_1).Replace("\\\\\\*\\.\\*", "\\\\([^\\.]+|.*\\.[^\\\\\\.]*)").Replace("\\.\\*", "\\.[^\\\\\\.]*")
			.Replace("\\*", ".*")
			.Replace("\\?", "[^\\\\\\.]") + "$";
		regex_0 = new Regex(string_0, RegexOptions.IgnoreCase);
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("name ").Append(Class6.smethod_44((Enum)comparisonOperator_0)).Append(" '")
			.Append(string_1)
			.Append("'");
		return stringBuilder.ToString();
	}

	internal override bool vmethod_0(string string_2)
	{
		return Class6.smethod_16(this, string_2);
	}

	internal override bool vmethod_1(GClass0 gclass0_0)
	{
		string text = gclass0_0.string_1.Replace("/", "\\");
		return Class6.smethod_16(this, text);
	}
}
