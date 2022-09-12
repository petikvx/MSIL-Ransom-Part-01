using System;
using System.Runtime.InteropServices;

namespace Gecko.Windows;

public static class User32
{
	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;

		internal int width()
		{
			return right - left;
		}

		internal int height()
		{
			return bottom - top;
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hdc);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdc, int nFlags);

	[DllImport("user32")]
	public static extern bool IsChild(IntPtr hWndParent, IntPtr hwnd);

	[DllImport("user32")]
	public static extern IntPtr GetParent(IntPtr hwnd);

	[DllImport("user32")]
	public static extern IntPtr GetFocus();
}
