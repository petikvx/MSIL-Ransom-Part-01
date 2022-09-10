using System;
using System.Text.RegularExpressions;

namespace Stealerium.Target.Browsers.Chromium;

internal sealed class Parser
{
	public static string Separator = "\": \"";

	public static string RemoveLatest(string data)
	{
		return Regex.Split(Regex.Split(data, "\",")[0], "\"")[0];
	}

	public static bool DetectTitle(string data)
	{
		return data.Contains("\"name");
	}

	public static string Get(string data, int index)
	{
		try
		{
			return RemoveLatest(Regex.Split(data, Separator)[index]);
		}
		catch (IndexOutOfRangeException)
		{
			return "Failed to parse url";
		}
	}
}
