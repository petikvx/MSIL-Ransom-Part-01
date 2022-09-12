using System.ComponentModel;

namespace Gecko;

public class GeckoHistoryPurgeEventArgs : CancelEventArgs
{
	public readonly int Count;

	public GeckoHistoryPurgeEventArgs(int count)
	{
		Count = count;
	}
}
