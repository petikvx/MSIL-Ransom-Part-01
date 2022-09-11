using System;
using System.Text;

namespace ManualMapInjection.Injection;

internal static class Helpers
{
	internal static string ToStringAnsi(byte[] buffer)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in buffer)
		{
			if (b == 0)
			{
				break;
			}
			stringBuilder.Append((char)b);
		}
		return stringBuilder.ToString();
	}

	internal static bool _stricmp(char[] str1, char[] str2)
	{
		int num = Math.Min(str1.Length, str2.Length);
		for (int i = 0; i < num; i++)
		{
			if (str1[i] == str2[i])
			{
				if (str1[i] == '\0')
				{
					break;
				}
				continue;
			}
			return false;
		}
		return true;
	}
}
