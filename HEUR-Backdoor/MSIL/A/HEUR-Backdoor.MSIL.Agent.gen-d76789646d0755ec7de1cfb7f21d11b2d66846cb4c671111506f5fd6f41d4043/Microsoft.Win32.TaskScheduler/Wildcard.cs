using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public class Wildcard : Regex
{
	public Wildcard(string pattern, RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace)
		: base(WildcardToRegex(pattern), options)
	{
	}

	public static string WildcardToRegex(string pattern)
	{
		string input = "^" + Regex.Escape(pattern) + "$";
		input = Regex.Replace(input, "(?<!\\\\)\\\\\\*", ".*");
		input = Regex.Replace(input, "\\\\\\\\\\\\\\*", "\\*");
		input = Regex.Replace(input, "(?<!\\\\)\\\\\\?", ".");
		input = Regex.Replace(input, "\\\\\\\\\\\\\\?", "\\?");
		return Regex.Replace(input, "\\\\\\\\\\\\\\\\", "\\\\");
	}
}
