using System;
using System.Threading;

namespace Nvoebk;

internal class IdleWaiter
{
	public int TimesCalled { get; private set; }

	public int Threshold { get; }

	internal IdleWaiter(int threshold)
	{
		Threshold = threshold;
	}

	public void PrintWaiting(object stateInfo)
	{
		AutoResetEvent autoResetEvent = (AutoResetEvent)stateInfo;
		Console.WriteLine($"Waiting... {++TimesCalled}");
		if (TimesCalled >= Threshold)
		{
			autoResetEvent.Set();
		}
	}
}
