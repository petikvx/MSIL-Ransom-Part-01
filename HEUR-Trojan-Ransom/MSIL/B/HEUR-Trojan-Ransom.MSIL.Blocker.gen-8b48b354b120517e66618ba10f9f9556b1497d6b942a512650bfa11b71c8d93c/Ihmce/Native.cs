using System;
using System.Runtime.InteropServices;

namespace Ihmce;

internal class Native
{
	[DllImport("user32.dll")]
	internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
