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
			if (text == Class4.smethod_0(1578597576, 1029042107, 939728554))
			{
				throw new ArgumentException(Class4.smethod_0(651011350, 1029042163, 939728514));
			}
			if (text == Class4.smethod_0(1526239317, 1029042111, 939728554))
			{
				throw new ArgumentNullException(Class4.smethod_0(479976833, 1029041983, 939728610));
			}
			if (text == Class4.smethod_0(493261712, 1029042083, 939728554))
			{
				throw new FormatException(Class4.smethod_0(591055680, 1029042045, 939728620));
			}
			if (text == Class4.smethod_0(70123297, 1029042087, 939728554))
			{
				throw new NotSupportedException(Class4.smethod_0(862531759, 1029041997, 939728542));
			}
		}
		Environment.Exit(0);
		Environment.Exit(0);
	}
}
