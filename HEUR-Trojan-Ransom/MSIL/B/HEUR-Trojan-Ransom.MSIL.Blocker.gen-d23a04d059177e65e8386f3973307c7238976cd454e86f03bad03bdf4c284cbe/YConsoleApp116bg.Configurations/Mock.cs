using System;
using System.Runtime.InteropServices;

namespace YConsoleApp116bg.Configurations;

public static class Mock
{
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr reference, int flags_pol);
}
