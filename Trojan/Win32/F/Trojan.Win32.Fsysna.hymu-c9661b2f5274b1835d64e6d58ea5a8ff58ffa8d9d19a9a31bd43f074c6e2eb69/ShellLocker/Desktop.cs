using System;
using System.Runtime.InteropServices;

namespace ShellLocker;

public class Desktop
{
	private const int SW_HIDE = 0;

	private const int SW_RESTORE = 9;

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

	public static void DesktopIconsHide()
	{
		string lpClassName = null;
		string lpWindowName = "Program Manager";
		IntPtr intPtr = (IntPtr)FindWindowA(ref lpClassName, ref lpWindowName);
		if (!(intPtr == (IntPtr)0))
		{
			ShowWindow(intPtr, 0);
		}
	}

	public static void DesktopIconsShow()
	{
		string lpClassName = null;
		string lpWindowName = "Program Manager";
		IntPtr intPtr = (IntPtr)FindWindowA(ref lpClassName, ref lpWindowName);
		if (!(intPtr == (IntPtr)0))
		{
			ShowWindow(intPtr, 9);
		}
	}
}
