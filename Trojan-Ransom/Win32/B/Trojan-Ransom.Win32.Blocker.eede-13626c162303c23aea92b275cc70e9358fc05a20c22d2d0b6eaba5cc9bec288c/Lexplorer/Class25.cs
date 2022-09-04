using System;
using System.Runtime.InteropServices;

namespace Lexplorer;

internal static class Class25
{
	[DllImport("user32.dll")]
	public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("User32.dll", SetLastError = true)]
	public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

	[DllImport("User32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName, [MarshalAs(UnmanagedType.U4)] int iModeNum, [In][Out] ref DEVMODE lpDevMode);

	[DllImport("User32.dll")]
	[return: MarshalAs(UnmanagedType.I4)]
	public static extern int ChangeDisplaySettings([In][Out] ref DEVMODE lpDevMode, [MarshalAs(UnmanagedType.U4)] uint dwflags);

	[DllImport("user32.dll")]
	public static extern bool PostMessage(IntPtr hhwnd, uint msg, IntPtr wparam, IntPtr lparam);

	[DllImport("user32.dll")]
	public static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);
}
