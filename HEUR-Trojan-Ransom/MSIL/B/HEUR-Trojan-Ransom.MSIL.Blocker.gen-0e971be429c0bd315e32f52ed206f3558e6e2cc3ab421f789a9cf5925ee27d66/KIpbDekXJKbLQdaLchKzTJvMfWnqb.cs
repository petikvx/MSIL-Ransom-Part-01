using System;
using System.Runtime.InteropServices;
using System.Text;

internal class KIpbDekXJKbLQdaLchKzTJvMfWnqb
{
	[Flags]
	public enum YfmFuchTBaFinUscGEZwygfKEvjD
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

	public struct TLskhaFtjQMsdRmEKCGLNFTfrOfw
	{
		public int bqhLyRgtJjGLXPZFUOvfEpwsCVtk;

		public int JtvlCWVphFCqeEizMXrcTAloZDUj;
	}

	public struct toGbQzZOhuyUkmEZkFPqmhuVklfv
	{
		public int yepbfCfpTtarpSmdDVtPCqKRZwRv;

		public int yHowMcqBQtEwZeJKCsCshQycjfzib;

		public int pHmsiBiKNWXhCGaCWTmunAongPQhA;

		public int hqDmabVNLuoTtLVLJaZShNKtQeZX;
	}

	public static int tNvEaNMfPykIvqYbWfvgJvrdkHkS = 131072;

	public static uint vswGaqWdFSCoEmSnYhomCBKKIDHP = 33554432u;

	public static int AEdIvHVZyXMJWSuNIoiCBHzaGsRO = 4095;

	public static int eeIrvsAtTNtisMringgiiXgpPJjo = 16;

	public static int oNKjSekSxDIXvKrvjDwsdMcPSZpM = 16;

	public static int DtnNkBxltbFifEOXSYLiRJhCGdUNA = 32;

	public static int znEbeaJKhzSvcPFhPPhMbkpQvUgrA = 8;

	public static int AovXQiZOyRfEbUhDEiLCvOzzQSEU = 4;

	public static int QMSpRFavqPjmyWiggJaqFzbSlxyL = -1;

	public static uint wrrfXOguJrqAAPNSGEEAYuJFvQL = 1u;

	public static uint HAqLIxrMdLZYefpNvsYyCueKkzus = 2u;

	public static int CmooBNyFRWimMmSufMiSfGWsVHDO = -16;

	public static int BicVOsnhedJbWSJqaGQVDqovNBVB = -20;

	public static int rwNmWRmoIGriwLAiOVAigboMhnTE = 2;

	public static int SKXhvGBHbexSGqKOkCVcuOaJYEkK = 1;

	public static int CuXejKwpEeiZMGJcpNFduGEFPhFA = 2;

	public static int doxdtGgCOWnqluiZjncXuCSqXCVLA = 132;

	public static int HHHbwWGBxmkEyDzNfUmIGWBEFoadd = 513;

	public static int wIQrWkGYtguejvCrhLihlRYuPfPM = 514;

	public static int coQcRYPrztrmsFcBOdpxIvFGPiSVA = 161;

	public static int VhgjFGfiDUNbSfxMaIkLGrTRYbSH = 163;

	public static int JkxiyysLUyMOJcUUOLuLOEzwrfVy = 524288;

	[DllImport("user32.dll")]
	public static extern bool GetCursorPos(out TLskhaFtjQMsdRmEKCGLNFTfrOfw lpPoint);

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
	public static extern int GetWindowRect(IntPtr hwnd, ref toGbQzZOhuyUkmEZkFPqmhuVklfv rect_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr hWnd, int state);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int left, int int_0, int width, int height, uint flags);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();
}
