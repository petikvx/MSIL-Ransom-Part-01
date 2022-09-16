using System;
using System.Threading;

namespace Client.Modules.Implant;

internal sealed class StartDelay
{
	private static readonly int SleepMin = 0;

	private static readonly int SleepMax = 10;

	public static void Run()
	{
		Thread.Sleep(new Random().Next(SleepMin * 1000, SleepMax * 1000));
	}
}
