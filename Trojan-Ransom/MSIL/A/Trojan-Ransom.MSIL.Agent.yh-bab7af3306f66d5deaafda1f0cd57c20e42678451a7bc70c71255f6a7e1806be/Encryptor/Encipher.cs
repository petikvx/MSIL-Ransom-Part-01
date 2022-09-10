using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Encryptor;

public static class Encipher
{
	public static void GenerateRSAKeyPair(out string publicKey, out string privateKey)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		privateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
	}

	public static string Encrypt(string plainFilePath, string encryptedFilePath, string manifestFilePath, string rsaKey)
	{
		string s = "3824576348976325678645864326754678965463765784235675894678563278";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		string s2 = "1285793273627365";
		byte[] bytes2 = Encoding.UTF8.GetBytes(s2);
		string s3 = "7582934726327385";
		byte[] bytes3 = Encoding.UTF8.GetBytes(s3);
		EncryptFile(plainFilePath, encryptedFilePath, bytes2, bytes3);
		string s4 = "MtVc9lY/pTSBs7miMnvA5N8dIMpPc7c3UUNi+QjPH8k=";
		byte[] bytes4 = Encoding.UTF8.GetBytes(s4);
		CreateManifest(bytes4, bytes, bytes2, bytes3, rsaKey, manifestFilePath);
		return CreateEncryptionInfoXml(bytes, bytes2, bytes3);
	}

	private static string CreateEncryptionInfoXml(byte[] signatureKey, byte[] encryptionKey, byte[] encryptionIV)
	{
		string text = "<EncryptionInfo><AESKeyValue><Key/><IV/></AESKeyValue><HMACSHAKeyValue/></EncryptionInfo>";
		XDocument val = XDocument.Parse(text);
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("AESKeyValue")).Single()).Descendants(XName.op_Implicit("Key")).Single().set_Value(Convert.ToBase64String(encryptionKey));
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("AESKeyValue")).Single()).Descendants(XName.op_Implicit("IV")).Single().set_Value(Convert.ToBase64String(encryptionIV));
		((XContainer)val).Descendants(XName.op_Implicit("HMACSHAKeyValue")).Single().set_Value(Convert.ToBase64String(signatureKey));
		return ((object)val).ToString();
	}

	private static byte[] GenerateRandom(int length)
	{
		byte[] array = new byte[length];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	private static void EncryptFile(string plainFilePath, string encryptedFilePath, byte[] key, byte[] iv)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		try
		{
			aesCryptoServiceProvider.KeySize = 128;
			aesCryptoServiceProvider.Key = key;
			aesCryptoServiceProvider.IV = iv;
			ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
			using FileStream fileStream = File.Open(plainFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			using FileStream stream = File.Open(encryptedFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
			using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			fileStream.CopyTo(destination);
		}
		catch (Exception)
		{
		}
		finally
		{
		}
	}

	public static void DecryptFile(string plainFilePath, string encryptedFilePath, byte[] key, byte[] iv)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 128;
		aesCryptoServiceProvider.Key = key;
		aesCryptoServiceProvider.IV = iv;
		ICryptoTransform transform = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
		using FileStream stream = File.Open(plainFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
		using FileStream fileStream = File.Open(encryptedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
		using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		fileStream.CopyTo(destination);
	}

	public static byte[] RSAEncryptBytes(byte[] datas, string keyXml)
	{
		byte[] result = null;
		using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048))
		{
			rSACryptoServiceProvider.FromXmlString(keyXml);
			result = rSACryptoServiceProvider.Encrypt(datas, fOAEP: true);
		}
		return result;
	}

	public static byte[] RSADescryptBytes(byte[] datas, string keyXml)
	{
		byte[] result = null;
		using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048))
		{
			rSACryptoServiceProvider.FromXmlString(keyXml);
			result = rSACryptoServiceProvider.Decrypt(datas, fOAEP: true);
		}
		return result;
	}

	private static byte[] CalculateSignature(string filePath, byte[] key)
	{
		byte[] result = null;
		using (HMACSHA256 hMACSHA = new HMACSHA256(key))
		{
			using FileStream inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			result = hMACSHA.ComputeHash(inputStream);
		}
		return result;
	}

	private static void CreateManifest(byte[] signature, byte[] signatureKey, byte[] encryptionKey, byte[] encryptionIv, string rsaKey, string manifestFilePath)
	{
		string text = "<DataInfo><Encrypted>True</Encrypted><KeyEncryption algorithm='RSA2048'></KeyEncryption><DataEncryption algorithm='AES128'><AESEncryptedKeyValue><Key/><IV/></AESEncryptedKeyValue></DataEncryption><DataSignature algorithm='HMACSHA256'><Value /><EncryptedKey /></DataSignature></DataInfo>";
		XDocument val = XDocument.Parse(text);
		((XContainer)((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataEncryption")).Single()).Descendants(XName.op_Implicit("AESEncryptedKeyValue")).Single()).Descendants(XName.op_Implicit("Key")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(encryptionKey, rsaKey)));
		((XContainer)((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataEncryption")).Single()).Descendants(XName.op_Implicit("AESEncryptedKeyValue")).Single()).Descendants(XName.op_Implicit("IV")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(encryptionIv, rsaKey)));
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataSignature")).Single()).Descendants(XName.op_Implicit("Value")).Single().set_Value(Convert.ToBase64String(signature));
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataSignature")).Single()).Descendants(XName.op_Implicit("EncryptedKey")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(signatureKey, rsaKey)));
		try
		{
			val.Save(manifestFilePath);
		}
		catch (IOException)
		{
		}
		finally
		{
		}
	}
}
