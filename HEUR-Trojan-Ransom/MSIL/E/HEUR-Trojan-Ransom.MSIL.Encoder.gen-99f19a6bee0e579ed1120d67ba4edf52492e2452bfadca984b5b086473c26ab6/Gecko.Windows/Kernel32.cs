using System.Runtime.InteropServices;

namespace Gecko.Windows;

internal static class Kernel32
{
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetDllDirectory(string lpPathName);
}
