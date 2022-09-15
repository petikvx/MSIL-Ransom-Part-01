using System;
using System.Runtime.InteropServices;

internal static class NativeMethods
{
	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern IntPtr GetModuleHandle(string lpModuleName);
}
