using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Ionic;

internal class Class3 : Class0
{
	private Regex regex_0;

	private string string_0;

	internal ComparisonOperator comparisonOperator_0;

	private string string_1;

	internal virtual string MatchingFileSpec
	{
		set
		{
			if (Directory.Exists(value))
			{
				string_1 = ".\\" + value + "\\*.*";
			}
			else
			{
				string_1 = value;
			}
			string_0 = "^" + Regex.Escape(string_1).Replace("\\\\\\*\\.\\*", "\\\\([^\\.]+|.*\\.[^\\\\\\.]*)").Replace("\\.\\*", "\\.[^\\\\\\.]*")
				.Replace("\\*", ".*")
				.Replace("\\?", "[^\\\\\\.]") + "$";
			regex_0 = new Regex(string_0, RegexOptions.IgnoreCase);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("name ").Append(Class8.smethod_0(comparisonOperator_0)).Append(" '")
			.Append(string_1)
			.Append("'");
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		return method_0(filename);
	}

	private bool method_0(string string_2)
	{
		string input = ((string_1.IndexOf('\\') == -1) ? Path.GetFileName(string_2) : string_2);
		bool flag = regex_0.IsMatch(input);
		if (comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool Evaluate(GClass8 entry)
	{
		string string_ = entry.String_2.Replace("/", "\\");
		return method_0(string_);
	}
}
