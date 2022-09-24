using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypt0r;

public class Cryptor
{
	public string Key { get; set; }

	public string IV { get; set; }

	public Cryptor(string Key, string IV)
	{
		this.Key = Key;
		this.IV = IV;
	}

	public Cryptor()
	{
		Key = GenStr();
		IV = GenStr(16);
	}

	public static string GenStr(int length = 32)
	{
		Random random = new Random();
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = "";
		for (int i = 0; i < length; i++)
		{
			int index = random.Next(text.Length);
			text2 += text[index];
		}
		return text2;
	}

	public byte[] Encode(byte[] bytesToEncode)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider
		{
			BlockSize = 128,
			KeySize = 256,
			Key = Encoding.UTF8.GetBytes(Key),
			IV = Encoding.UTF8.GetBytes(IV),
			Padding = PaddingMode.PKCS7,
			Mode = CipherMode.CBC
		};
		ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
		bytesToEncode = cryptoTransform.TransformFinalBlock(bytesToEncode, 0, bytesToEncode.Length);
		cryptoTransform.Dispose();
		return bytesToEncode;
	}

	public byte[] Decode(byte[] encryptedBytes)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider
		{
			BlockSize = 128,
			KeySize = 256,
			Key = Encoding.UTF8.GetBytes(Key),
			IV = Encoding.UTF8.GetBytes(IV),
			Padding = PaddingMode.PKCS7,
			Mode = CipherMode.CBC
		};
		ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
		byte[] result = cryptoTransform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
		cryptoTransform.Dispose();
		return result;
	}
}
