using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Shrug;

public class Cryptor
{
	private bool IsRegistred = false;

	public string Key { get; set; }

	public string IV { get; set; }

	public Cryptor(string Key, string IV)
	{
		if (Key.Length != 32)
		{
			GenerateKey();
		}
		else
		{
			this.Key = Key;
		}
		if (IV.Length != 16)
		{
			GenerateIV();
		}
		else
		{
			this.IV = IV;
		}
	}

	public Cryptor()
	{
		GenerateKey();
		GenerateIV();
	}

	public void GenerateKey()
	{
		Random random = new Random();
		List<int> list = new List<int>();
		for (int i = 65; i <= 90; i++)
		{
			list.Add(i);
		}
		for (int j = 97; j <= 122; j++)
		{
			list.Add(j);
		}
		for (int k = 48; k <= 57; k++)
		{
			list.Add(k);
		}
		string text = "";
		for (int l = 0; l < 32; l++)
		{
			int index = random.Next(list.Count);
			text += (char)list[index];
		}
		Key = text;
	}

	public void GenerateIV()
	{
		Random random = new Random();
		List<int> list = new List<int>();
		for (int num = 90; num >= 65; num--)
		{
			list.Add(num);
		}
		for (int num2 = 122; num2 >= 97; num2--)
		{
			list.Add(num2);
		}
		for (int num3 = 57; num3 >= 48; num3--)
		{
			list.Add(num3);
		}
		string text = "";
		for (int i = 0; i < 16; i++)
		{
			int index = random.Next(list.Count);
			text += (char)list[index];
		}
		IV = text;
	}

	public byte[] EncodeBytes(byte[] bytesToEncode)
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

	public byte[] DecodeBytes(byte[] encryptedBytes)
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
