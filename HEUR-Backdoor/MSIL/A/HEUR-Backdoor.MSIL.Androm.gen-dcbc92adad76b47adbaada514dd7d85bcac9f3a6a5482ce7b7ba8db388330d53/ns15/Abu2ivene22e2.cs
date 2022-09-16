using System;
using System.Diagnostics;

namespace ns15;

public static class Abu2ivene22e2
{
	private static Stopwatch T2ofer;

	public static void Jacint4()
	{
		if (T2ofer == null)
		{
			T2ofer = Stopwatch.StartNew();
		}
		else
		{
			T2ofer.Start();
		}
	}

	public static void Qu2lts()
	{
		T2ofer?.Stop();
	}

	public static TimeSpan B1ngalin1()
	{
		if (T2ofer != null)
		{
			TimeSpan elapsed = T2ofer.Elapsed;
			T2ofer.Reset();
			return elapsed;
		}
		return TimeSpan.MinValue;
	}

	public static double P0pk0n()
	{
		return B1ngalin1().TotalSeconds;
	}
}
