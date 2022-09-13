using System;
using System.Runtime.InteropServices;

internal class Class42
{
	[DllImport("user32.dll")]
	internal static extern IntPtr GetClipboardData(uint uint_0);

	[DllImport("user32.dll")]
	public static extern bool IsClipboardFormatAvailable(uint uint_0);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool OpenClipboard(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool CloseClipboard();

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GlobalLock(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	internal static extern bool GlobalUnlock(IntPtr intptr_0);
}
