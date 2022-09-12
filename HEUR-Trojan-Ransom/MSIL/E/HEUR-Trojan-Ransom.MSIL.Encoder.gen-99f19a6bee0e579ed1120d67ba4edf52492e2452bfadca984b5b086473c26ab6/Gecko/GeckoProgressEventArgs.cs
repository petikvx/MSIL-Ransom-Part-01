using System;

namespace Gecko;

public class GeckoProgressEventArgs : EventArgs
{
	public readonly long CurrentProgress;

	public readonly long MaximumProgress;

	public GeckoProgressEventArgs(long current, long max)
	{
		CurrentProgress = current;
		MaximumProgress = max;
	}
}
