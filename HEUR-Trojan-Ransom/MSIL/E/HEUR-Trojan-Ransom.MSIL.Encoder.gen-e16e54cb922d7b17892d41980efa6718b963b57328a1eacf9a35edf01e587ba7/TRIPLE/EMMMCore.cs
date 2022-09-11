using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace TRIPLE;

public static class EMMMCore
{
	public static void GetCoreKeys(out string CorePub, out string CorePriv)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		CorePub = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		CorePriv = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
		GC.Collect();
	}

	public static string EMMMCoreEnc(string EMMMCorePlain, string EMMMCorePlainCrypted, string EMMMCoreManifest, string EMMCoreRSAKey)
	{
		byte[] array = GenerateRandom(64);
		byte[] array2 = GenerateRandom(16);
		byte[] array3 = GenerateRandom(16);
		EMMMCoreEncFile(EMMMCorePlain, EMMMCorePlainCrypted, array2, array3);
		byte[] signature = CalculateSignature(EMMMCorePlainCrypted, array);
		CreateManifest(EMMMCorePlainCrypted, signature, array, array2, array3, EMMCoreRSAKey, EMMMCoreManifest);
		return EMMCoreInfoXML(array, array2, array3);
	}

	private static string EMMCoreInfoXML(byte[] EMMSignKey, byte[] EMMMAesKey, byte[] EMMMAesIV)
	{
		string text = "<EncryptionInfo><AESKeyValue><Key/><IV/></AESKeyValue><HMACSHAKeyValue/></EncryptionInfo>";
		XDocument val = XDocument.Parse(text);
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("AESKeyValue")).Single()).Descendants(XName.op_Implicit("Key")).Single().set_Value(Convert.ToBase64String(EMMMAesKey));
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("AESKeyValue")).Single()).Descendants(XName.op_Implicit("IV")).Single().set_Value(Convert.ToBase64String(EMMMAesIV));
		((XContainer)val).Descendants(XName.op_Implicit("HMACSHAKeyValue")).Single().set_Value(Convert.ToBase64String(EMMSignKey));
		return ((object)val).ToString();
	}

	public static byte[] GenerateRandom(int length)
	{
		byte[] array = new byte[length];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static void EMMMCoreEncFile(string EMMMCorePlain, string EMMMCorePlainCrypted, byte[] EMMMAesKey, byte[] EMMMAesIV)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 128;
		aesCryptoServiceProvider.Key = EMMMAesKey;
		aesCryptoServiceProvider.IV = EMMMAesIV;
		ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
		using FileStream fileStream = File.Open(EMMMCorePlain, FileMode.Open, FileAccess.Read, FileShare.Read);
		using FileStream stream = File.Open(EMMMCorePlainCrypted, FileMode.Create, FileAccess.Write, FileShare.None);
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

	private static void CreateManifest(string filename, byte[] signature, byte[] signatureKey, byte[] encryptionKey, byte[] encryptionIv, string rsaKey, string manifestFilePath)
	{
		string text = "<DataInfo><Encrypted>True</Encrypted><KeyEncryption algorithm='RSA2048'></KeyEncryption><DataEncryption algorithm='AES128'><AESEncryptedKeyValue><Key/><IV/><EncryptedFileName/></AESEncryptedKeyValue></DataEncryption><DataSignature algorithm='HMACSHA256'><EncryptedFileName /><Value /><EncryptedKey /></DataSignature></DataInfo>";
		XDocument val = XDocument.Parse(text);
		((XContainer)((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataEncryption")).Single()).Descendants(XName.op_Implicit("AESEncryptedKeyValue")).Single()).Descendants(XName.op_Implicit("Key")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(encryptionKey, rsaKey)));
		((XContainer)((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataEncryption")).Single()).Descendants(XName.op_Implicit("AESEncryptedKeyValue")).Single()).Descendants(XName.op_Implicit("IV")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(encryptionIv, rsaKey)));
		((XContainer)((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataEncryption")).Single()).Descendants(XName.op_Implicit("AESEncryptedKeyValue")).Single()).Descendants(XName.op_Implicit("EncryptedFileName")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(Encoding.ASCII.GetBytes(filename), rsaKey)));
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataSignature")).Single()).Descendants(XName.op_Implicit("Value")).Single().set_Value(Convert.ToBase64String(signature));
		((XContainer)((XContainer)val).Descendants(XName.op_Implicit("DataSignature")).Single()).Descendants(XName.op_Implicit("EncryptedKey")).Single().set_Value(Convert.ToBase64String(RSAEncryptBytes(signatureKey, rsaKey)));
		val.Save(manifestFilePath);
	}
}
