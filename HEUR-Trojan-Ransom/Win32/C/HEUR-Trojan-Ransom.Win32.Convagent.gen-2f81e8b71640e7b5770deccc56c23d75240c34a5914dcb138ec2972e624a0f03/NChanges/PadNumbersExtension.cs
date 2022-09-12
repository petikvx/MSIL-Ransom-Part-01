using System.Text.RegularExpressions;

namespace NChanges;

public static class PadNumbersExtension
{
	private static readonly Regex NumbersRegex = new Regex("\\d+");

	public static string PadNumbers(this string value)
	{
		return NumbersRegex.Replace(value, (Match m) => m.Value.PadLeft(10, '0'));
	}
}
