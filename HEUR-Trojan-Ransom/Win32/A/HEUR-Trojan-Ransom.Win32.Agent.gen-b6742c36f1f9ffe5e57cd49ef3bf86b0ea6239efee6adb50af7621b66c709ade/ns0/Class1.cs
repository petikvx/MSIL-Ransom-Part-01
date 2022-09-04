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
			if (text == Class53.smethod_0(1320018045, 2131749222, 1202784257))
			{
				throw new ArgumentException(Class53.smethod_0(993646218, 2131749166, 1202784297));
			}
			if (text == Class53.smethod_0(1882617361, 2131749218, 1202784257))
			{
				throw new ArgumentNullException(Class53.smethod_0(1029100256, 2131749346, 1202784329));
			}
			if (text == Class53.smethod_0(611801980, 2131749246, 1202784257))
			{
				throw new FormatException(Class53.smethod_0(1454691464, 2131749280, 1202784327));
			}
			if (text == Class53.smethod_0(2055409300, 2131749242, 1202784257))
			{
				throw new NotSupportedException(Class53.smethod_0(126393506, 2131749264, 1202784309));
			}
		}
		Environment.Exit(0);
		Environment.Exit(0);
	}
}
