using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using PenterWare.Utils;

namespace PenterWare.Crypt.CipherProviders;

internal class SymmetricCipher<T> : CipherProvider where T : SymmetricAlgorithm, new()
{
	public static int FILE_CHUNCK = 1048576;

	protected override byte[] Key { get; set; }

	public SymmetricCipher()
	{
		using T val = new T();
		Key = val.Key;
	}

	public override string Decrypt(byte[] ciphertext)
	{
		using T val = new T
		{
			Padding = PaddingMode.PKCS7
		};
		val.Key = Key;
		byte[] array = new byte[val.IV.Length];
		Array.Copy(ciphertext, array, val.IV.Length);
		val.IV = array;
		ciphertext = ciphertext.Skip(val.IV.Length).ToArray();
		ICryptoTransform transform = val.CreateDecryptor(val.Key, val.IV);
		using MemoryStream stream = new MemoryStream(ciphertext);
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}

	public override byte[] Encrypt(string cleartext)
	{
		using T val = new T
		{
			Padding = PaddingMode.PKCS7
		};
		val.Key = Key;
		ICryptoTransform transform = val.CreateEncryptor(val.Key, val.IV);
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(val.IV, 0, val.IV.Length);
		using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		using (StreamWriter streamWriter = new StreamWriter(stream))
		{
			streamWriter.Write(cleartext);
		}
		return memoryStream.ToArray();
	}

	public override int EncryptFile(string cleartextFilePath, string encryptedPath)
	{
		int num = 0;
		using T val = new T
		{
			Padding = PaddingMode.PKCS7
		};
		val.Key = Key;
		ICryptoTransform transform = val.CreateEncryptor(val.Key, val.IV);
		using (FileStream fileStream = new FileStream(cleartextFilePath, FileMode.Open, FileAccess.Read))
		{
			if (fileStream.Length > 0L)
			{
				using FileStream stream = new FileStream(encryptedPath, FileMode.Open, FileAccess.Write);
				using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
				byte[] array = new byte[FILE_CHUNCK];
				int num2 = (Policy.FastEncryptionMode ? Policy.MaxBytesForEncryption : FILE_CHUNCK);
				bool flag = false;
				while (num2 > 0 && !flag)
				{
					if (num2 + num >= Policy.MaxBytesForEncryption)
					{
						num2 = Policy.MaxBytesForEncryption - num;
						flag = true;
					}
					num2 = fileStream.Read(array, 0, num2);
					cryptoStream.Write(array, 0, num2);
					Array.Clear(array, 0, array.Length);
					num += num2;
				}
			}
		}
		using FileStream fileStream2 = new FileStream(encryptedPath, FileMode.Append, FileAccess.Write);
		fileStream2.Write(val.IV, 0, val.IV.Length);
		return num;
	}

	public override int DecryptFile(string encryptedPath, string decryptedPath)
	{
		int num = 0;
		using T val = new T
		{
			Padding = PaddingMode.PKCS7
		};
		val.Key = Key;
		byte[] array = new byte[val.IV.Length];
		using (FileStream fileStream = new FileStream(encryptedPath, FileMode.Open, FileAccess.Read))
		{
			fileStream.Position = fileStream.Length - val.IV.Length;
			fileStream.Read(array, 0, val.IV.Length);
		}
		val.IV = array;
		ICryptoTransform transform = val.CreateDecryptor(val.Key, val.IV);
		using FileStream fileStream2 = new FileStream(encryptedPath, FileMode.Open, FileAccess.ReadWrite);
		if (fileStream2.Length > 0L)
		{
			fileStream2.SetLength(fileStream2.Length - val.IV.Length);
			using FileStream stream = new FileStream(decryptedPath, FileMode.Create, FileAccess.Write);
			using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			byte[] array2 = new byte[FILE_CHUNCK];
			int num2 = (Policy.FastEncryptionMode ? Policy.MaxBytesForEncryption : FILE_CHUNCK);
			bool flag = false;
			while (num2 > 0 && !flag)
			{
				if (num2 + num >= Policy.MaxBytesForEncryption)
				{
					num2 = Policy.MaxBytesForEncryption - num;
					flag = true;
				}
				num2 = fileStream2.Read(array2, 0, num2);
				cryptoStream.Write(array2, 0, num2);
				Array.Clear(array2, 0, array2.Length);
				num += num2;
			}
		}
		if (Policy.FastEncryptionMode)
		{
			using (FileStream fileStream3 = new FileStream(decryptedPath, FileMode.Append, FileAccess.Write))
			{
				byte[] array3 = new byte[fileStream2.Length - num];
				fileStream2.Read(array3, 0, array3.Length);
				fileStream3.Write(array3, 0, array3.Length);
				return num;
			}
		}
		return num;
	}

	public override byte[] GetKey()
	{
		return Key;
	}
}
