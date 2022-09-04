using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace CryptoSrv.Shared.Managers;

public class ProcessManager
{
	public static bool KillProcess(string processName, out string message)
	{
		message = null;
		Process[] processesByName = Process.GetProcessesByName(processName);
		foreach (Process process in processesByName)
		{
			try
			{
				process.Kill();
				process.WaitForExit();
				int count;
				while (IsRunned(processName, out count))
				{
					Thread.Sleep(100);
				}
			}
			catch (Exception ex)
			{
				message = ex.Message + ex.StackTrace;
				return false;
			}
		}
		return true;
	}

	public static bool IsRunned(string processName, out int count)
	{
		count = 0;
		Process[] processesByName = Process.GetProcessesByName(processName);
		for (int i = 0; i < processesByName.Length; i++)
		{
			count++;
		}
		return false;
	}

	public static bool IsFileRunned(string file, out int count)
	{
		return IsRunned(Path.GetFileNameWithoutExtension(file), out count);
	}
}
