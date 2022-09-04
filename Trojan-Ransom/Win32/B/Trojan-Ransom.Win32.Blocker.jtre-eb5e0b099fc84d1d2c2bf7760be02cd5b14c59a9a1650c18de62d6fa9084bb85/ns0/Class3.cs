using System;
using System.Diagnostics;
using System.Timers;
using ns1;

namespace ns0;

internal class Class3
{
	protected Timer timer_0;

	private Timer timer_1;

	public Class3()
	{
		timer_0 = new Timer();
		timer_0.AutoReset = true;
		timer_0.Interval = 1000.0;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Start();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (Debugger.IsAttached)
		{
			timer_0.Stop();
			method_0();
		}
	}

	private void method_0()
	{
		timer_1 = new Timer();
		timer_1.Interval = method_1(3000, 678, 8000);
		timer_1.Elapsed += timer_1_Elapsed;
		timer_1.AutoReset = false;
		timer_1.Start();
	}

	private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
	{
		method_3(26, 16, 55);
	}

	private double method_1(int int_0, int int_1, int int_2)
	{
		Random random = new Random();
		return Convert.ToDouble(random.Next(int_0, int_2));
	}

	private string method_2(int int_0, int int_1, int int_2)
	{
		Random random = new Random();
		return random.Next(int_0, int_2).ToString();
	}

	private void method_3(int int_0, int int_1, int int_2)
	{
		string text;
		if ((text = method_2(int_1 + 10, int_2 - 10, int_0 + 10)) != null)
		{
			if (text == Class4.smethod_0(655576668, 1169193157, 621215563))
			{
				throw new ArgumentException(Class4.smethod_0(995462786, 1169193101, 621215587));
			}
			if (text == Class4.smethod_0(1968299824, 1169193153, 621215563))
			{
				throw new ArgumentNullException(Class4.smethod_0(1878733532, 1169193025, 621215491));
			}
			if (text == Class4.smethod_0(2107375740, 1169193181, 621215563))
			{
				throw new FormatException(Class4.smethod_0(1463786075, 1169192963, 621215501));
			}
			if (text == Class4.smethod_0(1091960670, 1169193177, 621215563))
			{
				throw new NotSupportedException(Class4.smethod_0(1012785301, 1169193011, 621215615));
			}
		}
		Environment.Exit(0);
		Environment.Exit(0);
	}
}
