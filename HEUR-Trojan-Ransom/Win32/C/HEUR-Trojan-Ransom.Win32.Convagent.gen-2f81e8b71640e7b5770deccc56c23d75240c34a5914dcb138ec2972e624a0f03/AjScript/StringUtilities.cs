using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AjScript;

public class StringUtilities
{
	private static Regex rex = new Regex("\\$\\{[^\\}]*\\}");

	public static IList<string> SplitText(string text)
	{
		int num = 0;
		List<string> list = new List<string>();
		Match match = rex.Match(text);
		while (match.Success)
		{
			list.Add(text.Substring(num, match.Index - num));
			list.Add(match.ToString().Substring(2, match.Length - 3));
			num = match.Index + match.Length;
			match = match.NextMatch();
		}
		if (num < text.Length)
		{
			list.Add(text.Substring(num, text.Length - num));
		}
		else if (list.Count == 0)
		{
			list.Add(text);
		}
		return list;
	}
}
