using System;
using System.Collections.Generic;

internal static class StringExtensions
{
	public static IEnumerable<string> SplitInParts(this string s, int partLength)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (partLength <= 0)
		{
			throw new ArgumentException("Part length has to be positive.", "partLength");
		}
		for (int i = 0; i < s.Length; i += partLength)
		{
			yield return s.Substring(i, Math.Min(partLength, s.Length - i));
		}
	}
}
