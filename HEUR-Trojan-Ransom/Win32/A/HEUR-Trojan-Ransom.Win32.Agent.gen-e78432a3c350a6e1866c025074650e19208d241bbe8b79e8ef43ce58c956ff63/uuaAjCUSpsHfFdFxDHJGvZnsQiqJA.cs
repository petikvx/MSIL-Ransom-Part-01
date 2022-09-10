using System;
using System.Runtime.InteropServices;

internal class uuaAjCUSpsHfFdFxDHJGvZnsQiqJA
{
	public struct qgQBbndKClGZyTRpCQoGGptwZTdA
	{
		public int ByqgCnIJUsbZfHVaZvAUmMXGUlCWA;

		public IntPtr FPwJgJhXVIHhFylIYzdEfBWNLjCi;

		public int eZzYyQSMLkjasnKFBiPjtVfNdAIc;
	}

	[Flags]
	internal enum PMvuqcBfUwPdXoPgCDWDCIVxIDIf
	{
		TERMINATE = 1,
		SUSPEND_RESUME = 2,
		GET_CONTEXT = 8,
		SET_CONTEXT = 0x10,
		SET_INFORMATION = 0x20,
		QUERY_INFORMATION = 0x40,
		SET_THREAD_TOKEN = 0x80,
		IMPERSONATE = 0x100,
		DIRECT_IMPERSONATION = 0x200
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnableWindow(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] IntPtr intptr_1);

	[DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool ConvertStringSecurityDescriptorToSecurityDescriptor([In] string string_0, [In] uint uint_0, out IntPtr intptr_0, out int int_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenThread(PMvuqcBfUwPdXoPgCDWDCIVxIDIf pmvuqcBfUwPdXoPgCDWDCIVxIDIf_0, bool bool_0, uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern uint SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);
}
