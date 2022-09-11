using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Complex;

public static class Encryptions
{
	public const int AES256KeySize = 256;

	public static byte[] RandomByteArray(int length)
	{
		byte[] array = new byte[length];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool AESEncryptFile(string filePath, byte[] password, bool delete)
	{
		byte[] array = RandomByteArray(16);
		using FileStream fileStream = new FileStream(filePath + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = GenerateKey(password, array);
		password = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(filePath, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (delete)
			{
				File.Delete(filePath);
			}
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool AESDecryptFile(string filePath, byte[] password, bool keep)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(filePath, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = GenerateKey(password, array);
		password = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(filePath.Remove(filePath.Length - 4), FileMode.Create);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			while (cryptoStream.Read(array2, 0, array2.Length) > 0)
			{
				fileStream2.Write(array2, 0, array2.Length);
			}
			cryptoStream.FlushFinalBlock();
			fileStream2.Close();
			fileStream.Close();
			cryptoStream.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static byte[] AESEncryptBytes(byte[] clear, byte[] password, byte[] salt)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = GenerateKey(password, salt);
		password = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(clear, 0, clear.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static byte[] AESDecryptBytes(byte[] encrypted, byte[] password, byte[] salt)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = GenerateKey(password, salt);
		password = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(encrypted, 0, encrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static bool CheckPassword(byte[] password, byte[] salt, byte[] key)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = GenerateKey(password, salt);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(key);
	}

	public static Rfc2898DeriveBytes GenerateKey(byte[] password, byte[] salt)
	{
		return new Rfc2898DeriveBytes(password, salt, 52768);
	}

	public static byte[] ReadFromFile(string filename, int count)
	{
		byte[] array = new byte[count];
		try
		{
			if (Program.Mmf == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(filename, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, count);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, count);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, "File: " + filename + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, count);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
	}

	public static bool WriteToFile(string filename, byte[] encrypted, byte[] cryptPass = null)
	{
		try
		{
			byte[] array = null;
			if (Program.Mmf == "YES")
			{
				array = (Program.Unique ? Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode("Kw==") + Convert.ToString(Program.PartialSize) + Program.Base64Decode("Kw==")) : Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode("LQ==") + Convert.ToString(Program.PartialSize) + Program.Base64Decode("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(filename, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(encrypted, 0, encrypted.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!Program.Unique)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(cryptPass, 0, cryptPass.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (Program.Unique ? Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode("Kw==") + Convert.ToString(Program.PartialSize) + Program.Base64Decode("Kw==")) : Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode("LQ==") + Convert.ToString(Program.PartialSize) + Program.Base64Decode("LQ==")));
				FileStream fileStream2 = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(encrypted, 0, encrypted.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!Program.Unique)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(cryptPass, 0, cryptPass.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			Program.ProcessedFiles++;
		}
		catch (Exception ex)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, "File: " + filename + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (Program.Unique ? Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode("Kw==") + Convert.ToString(Program.PartialSize) + Program.Base64Decode("Kw==")) : Encoding.ASCII.GetBytes(Program.Base64Decode(Program.MySign) + Program.Base64Decode("LQ==") + Convert.ToString(Program.PartialSize) + Program.Base64Decode("LQ==")));
				FileStream fileStream2 = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(encrypted, 0, encrypted.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!Program.Unique)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(cryptPass, 0, cryptPass.Length);
						fileStream.Write(array, 0, array.Length);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return true;
	}
}
