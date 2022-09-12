using System;
using System.Runtime.InteropServices;

namespace Xsocnyhdhtvskusfwvgz;

internal static class NativeMethod
{
	[DllImport("user32.dll")]
	internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
