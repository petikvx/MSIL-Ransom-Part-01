using System;
using System.Runtime.InteropServices;
using System.Text;

internal class NzMhXGhPlibCMPskiBGovgiGrqRA
{
	[Flags]
	public enum pMhzUGXqKjsLSfDXVZCXFnIBZacm
	{
		flag_0 = 0,
		flag_1 = int.MinValue,
		flag_2 = 0x40000000,
		flag_3 = 0x20000000,
		flag_4 = 0x10000000,
		flag_5 = 0x8000000,
		flag_6 = 0x4000000,
		flag_7 = 0x2000000,
		flag_8 = 0x1000000,
		flag_9 = 0xC00000,
		flag_10 = 0x800000,
		flag_11 = 0x400000,
		flag_12 = 0x200000,
		flag_13 = 0x100000,
		flag_14 = 0x80000,
		flag_15 = 0x40000,
		flag_16 = 0x20000,
		flag_17 = 0x10000,
		flag_18 = 0x20000,
		flag_19 = 0x10000,
		flag_20 = 0,
		flag_21 = 0x20000000,
		flag_22 = 0x40000,
		flag_23 = 0xCF0000,
		flag_24 = 0xCF0000,
		flag_25 = -2138570752,
		flag_26 = 0x40000000
	}

	public struct CUgbJJxlnlhElqAxLZBahPYoFleS
	{
		public int ydfGBgKLJMvTVeCiNkjWcjfdzTcF;

		public int UlxLDptadkfoqfWSLVEFbOahRcRS;
	}

	public struct UJiKqWhEakFXHIrjJDUmEhCLnBiRA
	{
		public int xVdiVzLyPIDFhxQYUimekYRSoPOy;

		public int nNmmBFOBAOSnFsTpPVqZewbbGpeJ;

		public int evoYjoIqPdVTGxPxNfiTNnpaeQPm;

		public int wdBMdGdPRJpqxofqKMSnVXJkJuQj;
	}

	public static int wZxQqwwjNFcupHAANAyJctcqDazBb = 131072;

	public static uint cFwYeLubXzsiELKWREmHioNXCsKvA = 33554432u;

	public static int NOpikixAwcZqSbiaZJfhbkgzHTIcA = 4095;

	public static int vrWNJZwuBqYQwvJLwtpFMvfgyngj = 16;

	public static int rwWcuNKjxsDhfgfSyAxZGJxhQscub = 16;

	public static int CavGdmXCbMFYjlEiXGUPzUsPSGTR = 32;

	public static int qUlMXryjGoJwImAIcwjwUmZsxjsA = 8;

	public static int HTfipFrccqVArjYyRYmzRkyadKPH = 4;

	public static int PaSvgmKlqcKhmtSZlbdHbHuTAStS = -1;

	public static uint fydAJmAoqgIYARdyDLTrWytIukNkA = 1u;

	public static uint GPeCoQZmhcWmkYMoakTNapbFKArT = 2u;

	public static int HyqQUsMgTdoAQHFVaIdhPARzxuQN = -16;

	public static int ODeejjGDpCbftsvahJZlbbhsZyUw = -20;

	public static int yrPGSlBKwdvTsJefJZEXiMaZJWYFb = 2;

	public static int VxXMDrhJxJcLEBFfpcTRMGxIpbfCb = 1;

	public static int JKuZQIIkzdPYPphinTUyBbHZPisv = 2;

	public static int cnTXdeqAgzWtiRcTazmCwNfxdMtc = 132;

	public static int SXfMhHvhTXwkWjgZChlccGQpNsCb = 513;

	public static int vwEimXuPbPCHbUoKybREFCZpElCi = 514;

	public static int fYEjhzrevGvAmaXiLdkUHBMBiXDgA = 161;

	public static int WBwVZbLdZnxESOfhnHTqeiSQpfVR = 163;

	public static int IznEjDKaSFEcXDfvPKpagowbFGIX = 524288;

	[DllImport("user32.dll")]
	public static extern bool GetCursorPos(out CUgbJJxlnlhElqAxLZBahPYoFleS lpPoint);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern int GetWindowLong(IntPtr hWnd, int Offset);

	[DllImport("user32.dll")]
	public static extern int MessageBeep(uint uType);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr LoadLibrary(string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesRead);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, int flNewProtect, out uint lpflOldProtect);

	[DllImport("kernel32", SetLastError = true)]
	public static extern int GetLastError();

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool SetCurrentDirectory(string lpPathName);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, uint lParam);

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string ipClassName, string IpWindowName);

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string Ipsz1, string Ipsz2);

	[DllImport("user32")]
	public static extern bool IsWindowVisible(IntPtr hwnd);

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder title, int size);

	[DllImport("user32.dll")]
	public static extern int GetWindowRect(IntPtr hwnd, ref UJiKqWhEakFXHIrjJDUmEhCLnBiRA rect_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr hWnd, int state);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int left, int int_0, int width, int height, uint flags);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();
}
