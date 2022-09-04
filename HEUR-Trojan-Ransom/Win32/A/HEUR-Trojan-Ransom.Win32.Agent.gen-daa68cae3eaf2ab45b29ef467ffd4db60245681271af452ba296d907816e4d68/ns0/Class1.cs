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
			if (text == Class53.smethod_0(393984859, 545860322, 941747449))
			{
				throw new ArgumentException(Class53.smethod_0(908095196, 545860266, 941747409));
			}
			if (text == Class53.smethod_0(1074005213, 545860326, 941747449))
			{
				throw new ArgumentNullException(Class53.smethod_0(641440782, 545860198, 941747377));
			}
			if (text == Class53.smethod_0(1555745104, 545860346, 941747449))
			{
				throw new FormatException(Class53.smethod_0(829285729, 545860132, 941747391));
			}
			if (text == Class53.smethod_0(1886356033, 545860350, 941747449))
			{
				throw new NotSupportedException(Class53.smethod_0(2034970401, 545860116, 941747405));
			}
		}
		Environment.Exit(0);
		Environment.Exit(0);
	}
}
