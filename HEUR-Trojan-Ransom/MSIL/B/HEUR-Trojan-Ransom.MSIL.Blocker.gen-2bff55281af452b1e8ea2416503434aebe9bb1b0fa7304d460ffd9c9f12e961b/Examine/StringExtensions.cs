using System;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using Lucene.Net.Analysis.Standard;

namespace Examine;

public static class StringExtensions
{
	internal static string EnsureEndsWith(this string input, char value)
	{
		if (!input.EndsWith(value.ToString(CultureInfo.InvariantCulture)))
		{
			return input + value;
		}
		return input;
	}

	internal static string ReplaceNonAlphanumericChars(this string input, string replacement)
	{
		string text = input;
		foreach (char item in from c in text.ToCharArray()
			where !char.IsLetterOrDigit(c)
			select c)
		{
			text = text.Replace(item.ToString(CultureInfo.InvariantCulture), replacement);
		}
		return text;
	}

	[SecuritySafeCritical]
	private static bool IsStandardAnalyzerStopWord(string stringToCheck)
	{
		if (StandardAnalyzer.STOP_WORDS_SET.Contains(stringToCheck.ToLower()))
		{
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	public static string RemoveStopWords(this string searchText)
	{
		Action<string, StringBuilder> action = delegate(string str, StringBuilder b)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			string[] array = str.Split(new char[1] { ' ' });
			foreach (string text3 in array)
			{
				if (!IsStandardAnalyzerStopWord(text3))
				{
					stringBuilder2.Append(text3);
					stringBuilder2.Append(" ");
				}
			}
			b.Append(stringBuilder2.ToString());
		};
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		while (num < searchText.Length)
		{
			int num2 = searchText.IndexOf("\"", num);
			if (num2 >= 0 && num == num2)
			{
				num = searchText.IndexOf("\"", num2 + 1) + 1;
				if (num > 0)
				{
					string text = searchText.Substring(num2 + 1, num - num2 - Convert.ToInt32(3.0 - Math.Round(1.0)));
					stringBuilder.Append("\"" + text.Trim() + "\" ");
				}
				else
				{
					num = num2 + 1;
				}
				continue;
			}
			int num3 = searchText.IndexOf("\"", num);
			if (num3 < 0)
			{
				num3 = searchText.Length;
			}
			string text2 = searchText.Substring(num, num3 - num).Trim();
			if (!string.IsNullOrWhiteSpace(text2))
			{
				action(text2, stringBuilder);
			}
			num = num3;
		}
		return stringBuilder.ToString().TrimEnd(new char[1] { (char)Convert.ToInt32(33.204119982655925 - Math.Log10(16.0)) });
	}
}
