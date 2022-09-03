using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class11
{
	[Flags]
	public enum Enum3
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8,
		flag_4 = 0x10,
		flag_5 = 0x20
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool MoveFileEx(string string_0, string string_1, Enum3 enum3_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_0, uint uint_0, uint uint_1, out uint uint_2);

	[DllImport("Kernel32.dll")]
	public static extern void RtlZeroMemory(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string string_0);
}
