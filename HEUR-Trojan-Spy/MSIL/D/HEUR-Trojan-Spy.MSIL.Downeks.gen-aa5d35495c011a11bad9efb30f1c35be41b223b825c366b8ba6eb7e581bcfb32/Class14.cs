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
		W59bgGv3Glsy7DPglyi();
	}

	internal static void W59bgGv3Glsy7DPglyi()
	{
	}
}
