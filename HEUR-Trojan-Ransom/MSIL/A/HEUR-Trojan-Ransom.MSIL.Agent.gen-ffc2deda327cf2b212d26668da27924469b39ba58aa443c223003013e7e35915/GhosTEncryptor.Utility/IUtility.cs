using System;
using System.Threading;

namespace GhosTEncryptor.Utility;

public static class IUtility
{
	public static string Shorten(string input, int maxLen = 32)
	{
		int num = 0;
		string text = string.Empty;
		foreach (char c in input)
		{
			if (num < maxLen)
			{
				text += c;
			}
		}
		Random random = new Random(10);
		while (text.Length < maxLen)
		{
			text += (char)random.Next(0, 255);
		}
		return text;
	}

	public static bool IsUnique()
	{
		new Mutex(initiallyOwned: true, "UniqueAppId", out var createdNew);
		return createdNew;
	}
}
