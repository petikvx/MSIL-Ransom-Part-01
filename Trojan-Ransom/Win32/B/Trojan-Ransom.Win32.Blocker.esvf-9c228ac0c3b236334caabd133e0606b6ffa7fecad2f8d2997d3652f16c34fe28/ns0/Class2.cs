using System;
using System.Diagnostics;
using System.Timers;

namespace ns0;

internal class Class2
{
	protected Timer timer_0;

	private Timer timer_1;

	public Class2()
	{
		timer_0 = new Timer();
		timer_0.AutoReset = true;
		timer_0.Interval = 1000.0;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Start();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		try
		{
			if (Debugger.IsAttached)
			{
				timer_0.Stop();
				method_0();
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, sender, e);
			throw;
		}
	}

	private void method_0()
	{
		try
		{
			timer_1 = new Timer();
			timer_1.Interval = method_1(3000, 678, 8000);
			timer_1.Elapsed += timer_1_Elapsed;
			timer_1.AutoReset = false;
			timer_1.Start();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
	{
		try
		{
			method_3(26, 16, 55);
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, sender, e);
			throw;
		}
	}

	private double method_1(int int_0, int int_1, int int_2)
	{
		Random random = default(Random);
		try
		{
			random = new Random();
			return Convert.ToDouble(random.Next(int_0, int_2));
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, int_0, int_1, int_2, random);
			throw;
		}
	}

	private string method_2(int int_0, int int_1, int int_2)
	{
		Random random = default(Random);
		int num = default(int);
		try
		{
			random = new Random();
			num = random.Next(int_0, int_2);
			return num.ToString();
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, int_0, int_1, int_2, random, num);
			throw;
		}
	}

	private void method_3(int int_0, int int_1, int int_2)
	{
		string text = default(string);
		try
		{
			if ((text = method_2(int_1 + 10, int_2 - 10, int_0 + 10)) != null)
			{
				if (text == Class63.smethod_0(423614303, 291738756, 1290231480))
				{
					throw new ArgumentException(Class63.smethod_0(1770245211, 291738828, 1290231440));
				}
				if (text == Class63.smethod_0(720254509, 291738752, 1290231480))
				{
					throw new ArgumentNullException(Class63.smethod_0(236622925, 291738624, 1290231536));
				}
				if (text == Class63.smethod_0(1380390806, 291738780, 1290231480))
				{
					throw new FormatException(Class63.smethod_0(1953662347, 291738690, 1290231550));
				}
				if (text == Class63.smethod_0(1505599984, 291738776, 1290231480))
				{
					throw new NotSupportedException(Class63.smethod_0(1806989161, 291738738, 1290231436));
				}
			}
			Environment.Exit(0);
			Environment.Exit(0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, int_0, int_1, int_2, text);
			throw;
		}
	}
}
