using System;
using System.Runtime.InteropServices;

namespace Stealerium.Target.Browsers.Firefox;

internal sealed class WinApi
{
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string sFileName);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr hModule, string sProcName);
}
