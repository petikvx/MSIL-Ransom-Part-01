using System;
using System.Runtime.InteropServices;

internal static class Class19
{
	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern int NtQueryInformationProcess(IntPtr ProcessHandle, int ProcessInformationClass, byte[] ProcessInformation, uint ProcessInformationLength, out int ReturnLength);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern uint NtSetInformationProcess(IntPtr ProcessHandle, int ProcessInformationClass, byte[] ProcessInformation, uint ProcessInformationLength);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll")]
	private static extern bool IsDebuggerPresent();

	[DllImport("kernel32.dll")]
	private static extern int OutputDebugString(string str);

	public static extern void smethod_0();

	private static extern void smethod_1(object thread);
}
