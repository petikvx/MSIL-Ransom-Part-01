using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsOperations;

public class CloseWindows
{
	private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

	public static string GetWindowText(IntPtr hWnd)
	{
		int num = GetWindowTextLength(hWnd) + 1;
		StringBuilder stringBuilder = new StringBuilder(num);
		num = GetWindowText(hWnd, stringBuilder, num);
		return stringBuilder.ToString(0, num);
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowTextLength(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

	public static void KillWinByT(string NameOfWindow)
	{
		string currWindow = null;
		int pid;
		if (!EnumWindows(delegate(IntPtr hWnd, IntPtr lParam)
		{
			currWindow = GetWindowText(hWnd);
			if (!string.IsNullOrEmpty(currWindow) && currWindow.Contains(NameOfWindow))
			{
				GetWindowThreadProcessId(hWnd, out pid);
				Process.GetProcessById(pid).Kill();
			}
			return true;
		}, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}
}
