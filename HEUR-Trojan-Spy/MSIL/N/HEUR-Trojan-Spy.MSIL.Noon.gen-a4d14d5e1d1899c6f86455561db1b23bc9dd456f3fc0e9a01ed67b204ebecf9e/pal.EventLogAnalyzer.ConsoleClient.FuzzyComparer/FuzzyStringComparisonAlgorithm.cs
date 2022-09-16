using System;
using System.Text;
using System.Text.RegularExpressions;

namespace pal.EventLogAnalyzer.ConsoleClient.FuzzyComparer;

public class FuzzyStringComparisonAlgorithm : IComparisonAlgorithm<string>
{
	private const string ALLOWED_CHARACTERS = "[A-Za-z\\n\\r\\t]+";

	private const string GUID_PATTERN = ".{8}-.{4}-.{4}-.{4}-.{12}";

	private readonly Regex _onlyAllowedCharacters = new Regex("[A-Za-z\\n\\r\\t]+", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);

	private readonly Regex _guidMatcher = new Regex(".{8}-.{4}-.{4}-.{4}-.{12}", RegexOptions.Compiled);

	private readonly double _leftHash = 0.0;

	public FuzzyStringComparisonAlgorithm(string lhs)
	{
		_leftHash = fuzzyHash(lhs);
	}

	public double DisSimilarityCoefficient(string rhs)
	{
		return Math.Abs(_leftHash - fuzzyHash(rhs));
	}

	private double fuzzyHash(string @string)
	{
		double num = 0.0;
		double num2 = 0.0;
		string text = stripUnwantedAndSanitize(@string);
		string text2 = text;
		foreach (char c in text2)
		{
			if (char.IsControl(c))
			{
				num2 = 0.0;
			}
			else
			{
				num += (double)(int)c * num2++;
			}
		}
		return num;
	}

	private string stripUnwantedAndSanitize(string @string)
	{
		string input = _guidMatcher.Replace(@string, string.Empty);
		StringBuilder stringBuilder = new StringBuilder();
		MatchCollection matchCollection = _onlyAllowedCharacters.Matches(input);
		foreach (Match item in matchCollection)
		{
			stringBuilder.Append(item);
		}
		return stringBuilder.ToString();
	}
}
