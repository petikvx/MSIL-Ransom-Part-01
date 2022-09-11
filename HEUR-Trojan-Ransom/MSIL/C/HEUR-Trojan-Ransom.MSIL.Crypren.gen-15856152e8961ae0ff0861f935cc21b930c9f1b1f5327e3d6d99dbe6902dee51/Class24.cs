using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static class Class24
{
	public const int int_0 = 183;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern SafeFileHandle CreateFileMapping(SafeFileHandle safeFileHandle_0, IntPtr intptr_0, Enum3 enum3_0, int int_1, int int_2, string string_0);

	[DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr MapViewOfFile(SafeFileHandle safeFileHandle_0, GEnum1 genum1_0, uint uint_0, uint uint_1, UIntPtr uintptr_0);

	[DllImport("kernel32", ExactSpelling = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern int CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr CreateJobObject(IntPtr intptr_0, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetInformationJobObject(IntPtr intptr_0, Enum2 enum2_0, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetProcessWindowStation();

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetThreadDesktop(int int_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern int GetCurrentThreadId();

	[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern int RegGetValue(UIntPtr uintptr_0, string string_0, string string_1, Enum8 enum8_0, out Enum9 enum9_0, IntPtr intptr_0, ref uint uint_0);
}
