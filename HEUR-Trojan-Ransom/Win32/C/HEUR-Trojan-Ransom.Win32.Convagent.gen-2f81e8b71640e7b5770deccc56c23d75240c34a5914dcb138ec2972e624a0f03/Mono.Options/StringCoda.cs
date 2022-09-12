using System;
using System.Collections.Generic;

namespace Mono.Options;

internal static class StringCoda
{
	public static IEnumerable<string> WrappedLines(string self, params int[] widths)
	{
		return WrappedLines(self, (IEnumerable<int>)widths);
	}

	public static IEnumerable<string> WrappedLines(string self, IEnumerable<int> widths)
	{
		if (widths == null)
		{
			throw new ArgumentNullException("widths");
		}
		return CreateWrappedLinesIterator(self, widths);
	}

	private static IEnumerable<string> CreateWrappedLinesIterator(string self, IEnumerable<int> widths)
	{
		if (string.IsNullOrEmpty(self))
		{
			yield return string.Empty;
			yield break;
		}
		using IEnumerator<int> ewidths = widths.GetEnumerator();
		bool? hw = null;
		int width = GetNextWidth(ewidths, int.MaxValue, ref hw);
		int num = 0;
		int end;
		do
		{
			end = GetLineEnd(num, width, self);
			char c = self[end - 1];
			if (char.IsWhiteSpace(c))
			{
				int num2 = end - 1;
				end = num2;
			}
			bool num3 = end != self.Length && !IsEolChar(c);
			string text = "";
			if (num3)
			{
				int num2 = end - 1;
				end = num2;
				text = "-";
			}
			yield return self.Substring(num, end - num) + text;
			num = end;
			if (char.IsWhiteSpace(c))
			{
				num++;
			}
			width = GetNextWidth(ewidths, width, ref hw);
		}
		while (end < self.Length);
	}

	private static int GetNextWidth(IEnumerator<int> ewidths, int curWidth, ref bool? eValid)
	{
		if (eValid.HasValue && (!eValid.HasValue || !eValid.Value))
		{
			return curWidth;
		}
		bool? flag = (eValid = ewidths.MoveNext());
		curWidth = (flag.Value ? ewidths.Current : curWidth);
		if (curWidth < ".-".Length)
		{
			throw new ArgumentOutOfRangeException("widths", string.Format("Element must be >= {0}, was {1}.", ".-".Length, curWidth));
		}
		return curWidth;
	}

	private static bool IsEolChar(char c)
	{
		return !char.IsLetterOrDigit(c);
	}

	private static int GetLineEnd(int start, int length, string description)
	{
		int num = Math.Min(start + length, description.Length);
		int num2 = -1;
		int num3 = start;
		while (true)
		{
			if (num3 < num)
			{
				if (description[num3] == '\n')
				{
					break;
				}
				if (IsEolChar(description[num3]))
				{
					num2 = num3 + 1;
				}
				num3++;
				continue;
			}
			if (num2 != -1 && num != description.Length)
			{
				return num2;
			}
			return num;
		}
		return num3 + 1;
	}
}
