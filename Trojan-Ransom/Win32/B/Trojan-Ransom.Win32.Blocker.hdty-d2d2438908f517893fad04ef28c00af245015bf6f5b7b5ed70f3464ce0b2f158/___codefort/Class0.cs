using System;
using System.Runtime.InteropServices;

namespace ___codefort;

internal class Class0
{
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, IntPtr dwSize, out int lpNumberOfBytesRead);

	static Class0()
	{
		Class3.smethod_0();
	}
}
