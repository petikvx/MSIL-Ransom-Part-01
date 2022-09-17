using System;
using System.Runtime.InteropServices;
using System.Text;
using dg3ypDAonQcOidMs0w;

internal static class Class14
{
	[DllImport("kernel32.dll")]
	internal static extern int GetCurrentThreadId();

	[DllImport("user32.dll")]
	internal static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

	static Class14()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		V9mm8kM14MF9jIRj3r5();
	}

	internal static void V9mm8kM14MF9jIRj3r5()
	{
	}
}
