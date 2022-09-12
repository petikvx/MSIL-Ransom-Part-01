using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class0
{
	private const int int_0 = 0;

	private const int int_1 = 5;

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_2);

	[DllImport("Kernel32")]
	private static extern IntPtr GetConsoleWindow();

	private static extern void Main(string[] args);

	public extern Class0();
}
