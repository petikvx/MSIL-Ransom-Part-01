using System;

namespace Gecko;

public class GeckoHistoryGotoIndexEventArgs : GeckoHistoryEventArgs
{
	public readonly int Index;

	public GeckoHistoryGotoIndexEventArgs(Uri url, int index)
		: base(url)
	{
		Index = index;
	}
}
