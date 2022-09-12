using System.ComponentModel;

namespace Gecko;

public class GeckoHistoryRepalaceEntryEventArgs : CancelEventArgs
{
	public readonly int Index;

	public GeckoHistoryRepalaceEntryEventArgs(int index)
	{
		Index = index;
	}
}
