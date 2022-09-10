using System.Collections;
using System.Text;

namespace Microsoft.Build.Shared;

internal static class QuotingUtilities
{
	private static readonly char[] splitMarker;

	internal static ArrayList SplitUnquoted(string input, int maxSplits, bool keepEmptySplits, bool unquote, out int emptySplits, params char[] separator)
	{
		ErrorUtilities.VerifyThrow(maxSplits >= 2, "There is no point calling this method for less than two splits.");
		string text = new StringBuilder().Append(separator).ToString();
		ErrorUtilities.VerifyThrow(text.IndexOf('"') == -1, "The double-quote character is not supported as a separator.");
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.EnsureCapacity(input.Length);
		bool flag = false;
		int num = 0;
		int num2 = 1;
		for (int i = 0; i < input.Length; i++)
		{
			if (num2 >= maxSplits)
			{
				break;
			}
			switch (input[i])
			{
			case '\\':
				stringBuilder.Append('\\');
				num++;
				continue;
			case '"':
				stringBuilder.Append('"');
				if (num % 2 == 0)
				{
					if (flag && i < input.Length - 1 && input[i + 1] == '"')
					{
						stringBuilder.Append('"');
						i++;
					}
					flag = !flag;
				}
				num = 0;
				continue;
			case '\0':
				continue;
			}
			if (!flag && ((text.Length == 0 && char.IsWhiteSpace(input[i])) || text.IndexOf(input[i]) != -1))
			{
				stringBuilder.Append('\0');
				if (++num2 == maxSplits)
				{
					stringBuilder.Append(input, i + 1, input.Length - (i + 1));
				}
			}
			else
			{
				stringBuilder.Append(input[i]);
			}
			num = 0;
		}
		ArrayList arrayList = new ArrayList();
		emptySplits = 0;
		string[] array = stringBuilder.ToString().Split(splitMarker, maxSplits);
		foreach (string text2 in array)
		{
			string text3 = (unquote ? Unquote(text2) : text2);
			if (text3.Length <= 0 && !keepEmptySplits)
			{
				emptySplits++;
			}
			else
			{
				arrayList.Add(text3);
			}
		}
		return arrayList;
	}

	internal static ArrayList SplitUnquoted(string input, params char[] separator)
	{
		int emptySplits;
		return SplitUnquoted(input, int.MaxValue, keepEmptySplits: false, unquote: false, out emptySplits, separator);
	}

	internal static string Unquote(string input, out int doubleQuotesRemoved)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.EnsureCapacity(input.Length);
		bool flag = false;
		int num = 0;
		doubleQuotesRemoved = 0;
		for (int i = 0; i < input.Length; i++)
		{
			switch (input[i])
			{
			case '\\':
				num++;
				break;
			default:
				stringBuilder.Append('\\', num);
				stringBuilder.Append(input[i]);
				num = 0;
				break;
			case '"':
				stringBuilder.Append('\\', num / 2);
				if (num % 2 == 0)
				{
					if (flag && i < input.Length - 1 && input[i + 1] == '"')
					{
						stringBuilder.Append('"');
						i++;
					}
					flag = !flag;
					doubleQuotesRemoved++;
				}
				else
				{
					stringBuilder.Append('"');
				}
				num = 0;
				break;
			}
		}
		return stringBuilder.Append('\\', num).ToString();
	}

	internal static string Unquote(string input)
	{
		int doubleQuotesRemoved;
		return Unquote(input, out doubleQuotesRemoved);
	}

	static QuotingUtilities()
	{
		char[] array = (splitMarker = new char[1]);
	}
}
