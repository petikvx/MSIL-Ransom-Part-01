using System;
using System.Diagnostics;

namespace NuGet.Common;

public static class taN7l3a04p
{
	private static Stopwatch Brb9507E3o;

	public static void VTz7AOCgPl()
	{
		if (Brb9507E3o == null)
		{
			Brb9507E3o = Stopwatch.StartNew();
		}
		else
		{
			Brb9507E3o.Start();
		}
	}

	public static void zmWbeKzjR0()
	{
		Brb9507E3o?.Stop();
	}

	public static TimeSpan yDQfrolIcA()
	{
		if (Brb9507E3o != null)
		{
			TimeSpan elapsed = Brb9507E3o.Elapsed;
			Brb9507E3o.Reset();
			return elapsed;
		}
		return TimeSpan.MinValue;
	}

	public static double scYhJQE0sX()
	{
		return yDQfrolIcA().TotalSeconds;
	}
}
