using System;
using System.Runtime.InteropServices;

namespace youknowcaliber;

internal class WinAPI
{
	[DllImport("user32.dll")]
	internal static extern IntPtr GetClipboardData(uint uFormat);

	[DllImport("user32.dll")]
	public static extern bool IsClipboardFormatAvailable(uint format);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool CloseClipboard();

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GlobalLock(IntPtr hMem);

	[DllImport("kernel32.dll")]
	internal static extern bool GlobalUnlock(IntPtr hMem);

	public extern WinAPI();
}
internal sealed class WinApi
{
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string sFileName);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr hModule, string sProcName);

	public extern WinApi();
}
