using System;
using System.Runtime.InteropServices;

namespace Soprqcz;

internal class Native
{
	[DllImport("user32.dll")]
	internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
