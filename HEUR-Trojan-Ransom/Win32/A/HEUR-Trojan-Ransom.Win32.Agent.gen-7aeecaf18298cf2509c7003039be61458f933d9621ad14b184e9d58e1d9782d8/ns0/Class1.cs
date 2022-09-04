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
			if (text == Class53.smethod_0(2131409474, 1387274504, 320710413))
			{
				throw new ArgumentException(Class53.smethod_0(12434212, 1387274560, 320710437));
			}
			if (text == Class53.smethod_0(995194694, 1387274508, 320710413))
			{
				throw new ArgumentNullException(Class53.smethod_0(1886540535, 1387274636, 320710469));
			}
			if (text == Class53.smethod_0(1777133405, 1387274512, 320710413))
			{
				throw new FormatException(Class53.smethod_0(1063663065, 1387274702, 320710475));
			}
			if (text == Class53.smethod_0(942284298, 1387274516, 320710413))
			{
				throw new NotSupportedException(Class53.smethod_0(1177927621, 1387274750, 320710457));
			}
		}
		Environment.Exit(0);
		Environment.Exit(0);
	}
}
