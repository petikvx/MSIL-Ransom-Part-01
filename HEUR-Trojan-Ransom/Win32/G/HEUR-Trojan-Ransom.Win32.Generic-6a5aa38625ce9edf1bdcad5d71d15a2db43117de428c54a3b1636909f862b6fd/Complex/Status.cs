using System.Diagnostics;
using System.Timers;

namespace Complex;

internal class Status
{
	public static int lastCount;

	public static int currentCount;

	public static int totalCount;

	private static Timer statusTimer;

	private static Stopwatch runTimer;

	internal static void StartOutputTimer()
	{
		PrintStatus();
		statusTimer = new Timer(30000.0);
		runTimer = new Stopwatch();
		runTimer.Start();
		statusTimer.Elapsed += delegate
		{
			PrintStatus();
			lastCount = currentCount;
		};
		statusTimer.AutoReset = true;
		statusTimer.Start();
	}

	internal static void PrintStatus()
	{
	}
}
