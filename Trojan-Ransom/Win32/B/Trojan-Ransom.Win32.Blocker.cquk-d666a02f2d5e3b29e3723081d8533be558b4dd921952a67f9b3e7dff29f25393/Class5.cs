using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

internal static class Class5
{
	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern int NtQueryInformationProcess(IntPtr ProcessHandle, int ProcessInformationClass, byte[] ProcessInformation, uint ProcessInformationLength, out int ReturnLength);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern uint NtSetInformationProcess(IntPtr ProcessHandle, int ProcessInformationClass, byte[] ProcessInformation, uint ProcessInformationLength);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll")]
	private static extern bool IsDebuggerPresent();

	[DllImport("kernel32.dll")]
	private static extern int OutputDebugString(string str);

	public static void smethod_0()
	{
		if (Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING") != null || Environment.GetEnvironmentVariable("COR_PROFILER") != null)
		{
			Environment.FailFast("Profiler detected");
		}
		Thread thread = new Thread(smethod_1);
		thread.IsBackground = true;
		thread.Start(null);
	}

	private static void smethod_1(object thread)
	{
		Thread thread2 = thread as Thread;
		if (thread2 == null)
		{
			thread2 = new Thread(smethod_1);
			thread2.IsBackground = true;
			thread2.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		while (true)
		{
			if (Debugger.IsAttached || Debugger.IsLogging())
			{
				Environment.FailFast("Debugger detected (Managed)");
			}
			if (!thread2.IsAlive)
			{
				Environment.FailFast("Loop broken");
			}
			Thread.Sleep(1000);
		}
	}
}
