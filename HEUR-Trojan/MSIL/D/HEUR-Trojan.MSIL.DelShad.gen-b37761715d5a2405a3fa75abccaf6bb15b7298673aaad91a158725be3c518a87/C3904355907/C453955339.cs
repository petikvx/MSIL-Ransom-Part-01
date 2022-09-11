using System;
using System.Runtime.InteropServices;

namespace C3904355907;

internal sealed class C453955339
{
	public const int C3554254475 = 0;

	public const int C3904355907 = 5;

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetConsoleWindow();

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool DefineDosDeviceW(uint uint_0, string string_0, string string_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool MoveFileExW(string string_0, string string_1, uint uint_0);

	[DllImport("user32.dll")]
	internal static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);
}
