using System;
using System.Runtime.InteropServices;

namespace NotRansom_StopCtypt;

internal static class NativeMethods
{
	internal struct LUID
	{
		internal int LowPart;

		internal uint HighPart;
	}

	internal struct TOKEN_PRIVILEGES
	{
		internal int PrivilegeCount;

		internal LUID Luid;

		internal int Attributes;
	}

	internal const int SE_PRIVILEGE_ENABLED = 2;

	internal const int ERROR_NOT_ALL_ASSIGNED = 1300;

	internal const uint STANDARD_RIGHTS_REQUIRED = 983040u;

	internal const uint STANDARD_RIGHTS_READ = 131072u;

	internal const uint TOKEN_ASSIGN_PRIMARY = 1u;

	internal const uint TOKEN_DUPLICATE = 2u;

	internal const uint TOKEN_IMPERSONATE = 4u;

	internal const uint TOKEN_QUERY = 8u;

	internal const uint TOKEN_QUERY_SOURCE = 16u;

	internal const uint TOKEN_ADJUST_PRIVILEGES = 32u;

	internal const uint TOKEN_ADJUST_GROUPS = 64u;

	internal const uint TOKEN_ADJUST_DEFAULT = 128u;

	internal const uint TOKEN_ADJUST_SESSIONID = 256u;

	internal const uint TOKEN_READ = 131080u;

	internal const uint TOKEN_ALL_ACCESS = 983551u;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LookupPrivilegeValue(string lpsystemname, string lpname, [MarshalAs(UnmanagedType.Struct)] ref LUID lpLuid);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AdjustTokenPrivileges(IntPtr tokenhandle, [MarshalAs(UnmanagedType.Bool)] bool disableAllPrivileges, [MarshalAs(UnmanagedType.Struct)] ref TOKEN_PRIVILEGES newstate, uint bufferlength, IntPtr previousState, IntPtr returnlength);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAccesss, out IntPtr tokenHandle);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr hObject);
}
