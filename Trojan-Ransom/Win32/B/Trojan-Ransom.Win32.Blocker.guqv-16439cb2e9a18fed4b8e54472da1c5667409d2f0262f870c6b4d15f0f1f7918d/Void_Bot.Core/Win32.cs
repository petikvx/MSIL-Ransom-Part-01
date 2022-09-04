using System;
using System.Runtime.InteropServices;

namespace Void_Bot.Core;

internal class Win32
{
	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public uint dwProcessId;

		public uint dwThreadId;
	}

	public struct STARTUPINFO
	{
		public uint cb;

		public string lpReserved;

		public string lpDesktop;

		public string lpTitle;

		public uint dwX;

		public uint dwY;

		public uint dwXSize;

		public uint dwYSize;

		public uint dwXCountChars;

		public uint dwYCountChars;

		public uint dwFillAttribute;

		public uint dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public IntPtr lpReserved2;

		public IntPtr hStdInput;

		public IntPtr hStdOutput;

		public IntPtr hStdError;
	}

	public struct SECURITY_ATTRIBUTES
	{
		public int length;

		public IntPtr lpSecurityDescriptor;

		public bool bInheritHandle;
	}

	[Flags]
	internal enum ThreadAccess
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CONTEXT = 8,
		SET_CONTEXT = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	internal enum TCP_TABLE_CLASS
	{
		TCP_TABLE_BASIC_LISTENER,
		TCP_TABLE_BASIC_CONNECTIONS,
		TCP_TABLE_BASIC_ALL,
		TCP_TABLE_OWNER_PID_LISTENER,
		TCP_TABLE_OWNER_PID_CONNECTIONS,
		TCP_TABLE_OWNER_PID_ALL,
		TCP_TABLE_OWNER_MODULE_LISTENER,
		TCP_TABLE_OWNER_MODULE_CONNECTIONS,
		TCP_TABLE_OWNER_MODULE_ALL
	}

	internal enum MoveFileFlags
	{
		None = 0,
		DelayUntilReboot = 4
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	public static extern int GetExtendedTcpTable(byte[] pTcpTable, out int dwOutBufLen, bool sort, int ipVersion, TCP_TABLE_CLASS tblClass, int reserved);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] IntPtr pSecurityDescriptor);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	[DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool ConvertStringSecurityDescriptorToSecurityDescriptor([In] string StringSecurityDescriptor, [In] uint StringSDRevision, out IntPtr SecurityDescriptor, out int SecurityDescriptorSize);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll")]
	public static extern uint SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	public static extern int ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process([In] IntPtr hProcess, out bool wow64Process);

	public static bool ScheduleForDeletion(string filePath)
	{
		if (!MoveFileEx(filePath, null, MoveFileFlags.DelayUntilReboot))
		{
			return false;
		}
		return true;
	}

	public static bool RenameFile(string filePath, string dest)
	{
		if (!MoveFileEx(filePath, dest, MoveFileFlags.None))
		{
			return false;
		}
		return true;
	}
}
