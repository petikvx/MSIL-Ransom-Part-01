using System;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;

internal static class Class8
{
	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	internal static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern Class9 SetWindowsHookEx(int idHook, GDelegate0 lpfn, IntPtr hMod, int dwThreadId);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int UnhookWindowsHookEx(IntPtr idHook);

	static Class8()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		LHq8CbH3HfGySeRj0H4();
	}

	internal static void LHq8CbH3HfGySeRj0H4()
	{
	}
}
