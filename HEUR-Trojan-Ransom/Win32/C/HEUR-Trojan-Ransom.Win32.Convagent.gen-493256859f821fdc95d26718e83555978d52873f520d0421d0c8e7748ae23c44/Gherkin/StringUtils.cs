using System.Globalization;

namespace Gherkin;

public class StringUtils
{
	public static bool StartsWith(string a, string b)
	{
		return StartsWith(a.ToCharArray(), b.ToCharArray());
	}

	private static bool StartsWith(char[] a, char[] b)
	{
		if (a.Length < b.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < b.Length)
			{
				if (a[num] != b[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static int CountSymbols(string s)
	{
		return new StringInfo(s).LengthInTextElements;
	}
}
