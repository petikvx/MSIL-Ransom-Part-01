using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsOperations;

public static class GetWindows
{
	private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	public static void WindowsToListBox(ListBox el)
	{
		el.get_Items().Clear();
		EnumWindows(delegate(IntPtr hWnd, IntPtr lParam)
		{
			if (IsWindowVisible(hWnd) && GetWindowTextLength(hWnd) != 0)
			{
				el.get_Items().Add((object)GetWindowText(hWnd));
			}
			return true;
		}, IntPtr.Zero);
	}

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
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);
}
