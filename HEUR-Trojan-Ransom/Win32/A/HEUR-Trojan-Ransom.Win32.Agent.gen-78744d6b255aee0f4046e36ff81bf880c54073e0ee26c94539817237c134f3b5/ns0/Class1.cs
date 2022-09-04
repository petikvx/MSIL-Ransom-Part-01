using System;
using System.Diagnostics;
using System.Timers;
using ns1;

namespace ns0;

internal class Class1
{
	protected Timer timer_0;

	private Timer timer_1;

	public Class1()
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
			if (text == Class53.smethod_0(1937907082, 1724873539, 1256738719))
			{
				throw new ArgumentException(Class53.smethod_0(1114745246, 1724873483, 1256738743));
			}
			if (text == Class53.smethod_0(1763307041, 1724873543, 1256738719))
			{
				throw new ArgumentNullException(Class53.smethod_0(92280555, 1724873671, 1256738775));
			}
			if (text == Class53.smethod_0(624986586, 1724873563, 1256738719))
			{
				throw new FormatException(Class53.smethod_0(1972823566, 1724873605, 1256738777));
			}
			if (text == Class53.smethod_0(1210706440, 1724873567, 1256738719))
			{
				throw new NotSupportedException(Class53.smethod_0(1172886175, 1724873653, 1256738731));
			}
		}
		Environment.Exit(0);
		Environment.Exit(0);
	}
}
