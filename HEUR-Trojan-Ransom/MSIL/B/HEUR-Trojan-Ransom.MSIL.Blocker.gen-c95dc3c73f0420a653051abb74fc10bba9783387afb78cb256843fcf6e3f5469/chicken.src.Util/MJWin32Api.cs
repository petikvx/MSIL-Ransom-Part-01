using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace chicken.src.Util;

public class MJWin32Api
{
	[Flags]
	public enum WindowStyle
	{
		WS_OVERLAPPED = 0,
		WS_POPUP = int.MinValue,
		WS_CHILD = 0x40000000,
		WS_MINIMIZE = 0x20000000,
		WS_VISIBLE = 0x10000000,
		WS_DISABLED = 0x8000000,
		WS_CLIPSIBLINGS = 0x4000000,
		WS_CLIPCHILDREN = 0x2000000,
		WS_MAXIMIZE = 0x1000000,
		WS_CAPTION = 0xC00000,
		WS_BORDER = 0x800000,
		WS_DLGFRAME = 0x400000,
		WS_VSCROLL = 0x200000,
		WS_HSCROLL = 0x100000,
		WS_SYSMENU = 0x80000,
		WS_THICKFRAME = 0x40000,
		WS_GROUP = 0x20000,
		WS_TABSTOP = 0x10000,
		WS_MINIMIZEBOX = 0x20000,
		WS_MAXIMIZEBOX = 0x10000,
		WS_TILED = 0,
		WS_ICONIC = 0x20000000,
		WS_SIZEBOX = 0x40000,
		WS_TILEDWINDOW = 0xCF0000,
		WS_OVERLAPPEDWINDOW = 0xCF0000,
		WS_POPUPWINDOW = -2138570752,
		WS_CHILDWINDOW = 0x40000000
	}

	public struct POINT
	{
		public int X;

		public int Y;
	}

	public struct RECT
	{
		public int left;

		public int int_0;

		public int right;

		public int bottom;
	}

	[Flags]
	public enum ThreadAccess
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

	public static int CS_DROPSHADOW = 131072;

	public static uint MAXIMUM_ALLOWED = 33554432u;

	public static int PROCESS_ALL_ACCESS = 4095;

	public static int PROCESS_WM_READ = 16;

	public static int PROCESS_VM_READ = 16;

	public static int PROCESS_VM_WRITE = 32;

	public static int PROCESS_VM_OPERATION = 8;

	public static int PAGE_READWRITE = 4;

	public static int PAGE_EXECUTE_READWRITE = 64;

	public static int HWND_TOPMOST = -1;

	public static uint SWP_NOSIZE = 1u;

	public static uint SWP_NOMOVE = 2u;

	public static int GWL_STYLE = -16;

	public static int GWL_EXSTYLE = -20;

	public static int LWA_ALPHA = 2;

	public static int HTCLIENT = 1;

	public static int HTCAPTION = 2;

	public static int WM_NCHITTEST = 132;

	public static int WM_LBUTTONDOWN = 513;

	public static int WM_LBUTTONUP = 514;

	public static int WM_NCLBUTTONDOWN = 161;

	public static int WM_NCLBUTTONDBLCLK = 163;

	public static int WS_EX_LAYERED = 524288;

	[DllImport("user32.dll")]
	public static extern bool GetCursorPos(out POINT lpPoint);

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

	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_0, out uint uint_1);

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
	public static extern int GetWindowRect(IntPtr hwnd, ref RECT rect_0);

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr hWnd, int state);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int left, int int_0, int width, int height, uint flags);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	[DllImport("kernel32.dll")]
	public static extern uint SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	public static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool InvalidateRect(IntPtr hWnd, ref RECT rect, bool bErase);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetClientRect(IntPtr intptr_0, ref RECT rect_0);

	public static void updateDesktop()
	{
		IntPtr desktopWindow = GetDesktopWindow();
		if (desktopWindow != IntPtr.Zero)
		{
			RECT rect_ = default(RECT);
			GetClientRect(desktopWindow, ref rect_);
			InvalidateRect(desktopWindow, ref rect_, bErase: true);
		}
	}

	public static bool writeProcessMem(IntPtr hProcess, IntPtr addr, byte[] byte_0)
	{
		try
		{
			VirtualProtectEx(hProcess, addr, (UIntPtr)(ulong)byte_0.Length, (uint)PAGE_EXECUTE_READWRITE, out var uint_);
			if (WriteProcessMemory(hProcess, addr, byte_0, (uint)byte_0.Length, 0) != 0)
			{
				VirtualProtectEx(hProcess, addr, (UIntPtr)(ulong)byte_0.Length, uint_, out uint_);
				return true;
			}
			VirtualProtectEx(hProcess, addr, (UIntPtr)(ulong)byte_0.Length, uint_, out uint_);
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void suspendProcess(Process proc)
	{
		IntPtr zero = IntPtr.Zero;
		for (int i = 0; i < proc.Threads.Count; i++)
		{
			zero = OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, (uint)proc.Threads[i].Id);
			if (!(zero == IntPtr.Zero))
			{
				SuspendThread(zero);
				CloseHandle(zero);
			}
		}
	}

	public static void resumeProcess(Process proc)
	{
		IntPtr zero = IntPtr.Zero;
		for (int i = 0; i < proc.Threads.Count; i++)
		{
			zero = OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, (uint)proc.Threads[i].Id);
			if (!(zero == IntPtr.Zero))
			{
				ResumeThread(zero);
				CloseHandle(zero);
			}
		}
	}
}
