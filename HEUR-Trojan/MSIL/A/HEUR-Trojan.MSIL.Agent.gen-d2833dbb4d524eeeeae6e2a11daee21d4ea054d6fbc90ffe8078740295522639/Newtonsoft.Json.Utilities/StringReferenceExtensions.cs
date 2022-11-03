using System;

namespace Newtonsoft.Json.Utilities;

internal static class StringReferenceExtensions
{
	public static int IndexOf(this StringReference s, char c, int startIndex, int length)
	{
		int num = Array.IndexOf(s.Chars, c, s.StartIndex + startIndex, length);
		if (num == -1)
		{
			return -1;
		}
		return num - s.StartIndex;
	}

	public static bool StartsWith(this StringReference s, string text)
	{
		if (text.Length > s.Length)
		{
			return false;
		}
		char[] chars = s.Chars;
		int num = 0;
		while (true)
		{
			if (num < text.Length)
			{
				if (text[num] != chars[num + s.StartIndex])
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

	public static bool EndsWith(this StringReference s, string text)
	{
		if (text.Length > s.Length)
		{
			return false;
		}
		char[] chars = s.Chars;
		int num = s.StartIndex + s.Length - text.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 < text.Length)
			{
				if (text[num2] != chars[num2 + num])
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}
}
