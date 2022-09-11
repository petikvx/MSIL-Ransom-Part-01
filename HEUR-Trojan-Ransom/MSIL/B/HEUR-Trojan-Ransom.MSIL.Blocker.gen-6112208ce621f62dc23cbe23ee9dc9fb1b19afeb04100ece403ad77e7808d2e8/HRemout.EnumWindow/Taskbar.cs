using System;
using System.Runtime.InteropServices;

namespace HRemout.EnumWindow;

public class Taskbar
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 1;

	[DllImport("user32.dll")]
	private static extern IntPtr FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	public static IntPtr task()
	{
		return FindWindow("Shell_TrayWnd", "");
	}

	private Taskbar()
	{
	}
}
