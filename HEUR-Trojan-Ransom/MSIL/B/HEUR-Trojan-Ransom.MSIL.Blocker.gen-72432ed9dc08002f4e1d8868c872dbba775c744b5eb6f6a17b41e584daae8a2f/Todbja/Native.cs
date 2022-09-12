using System;
using System.Runtime.InteropServices;

namespace Todbja;

internal class Native : ICups
{
	[DllImport("user32.dll")]
	internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
