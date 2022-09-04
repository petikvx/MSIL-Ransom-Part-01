using System;
using System.Runtime.InteropServices;

namespace Lexplorer;

internal static class Class7
{
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool AllocConsole();

	public static void PreventSleep()
	{
		if (SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_AWAYMODE_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS) == (EXECUTION_STATE)0u)
		{
			SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateToolhelp32Snapshot(SnapshotFlags dwFlags, uint th32ProcessID);

	[DllImport("kernel32.dll")]
	public static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

	[DllImport("kernel32.dll")]
	public static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr hObject);
}
