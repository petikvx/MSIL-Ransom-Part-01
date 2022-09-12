using System;
using System.ComponentModel;

namespace Gecko;

public class GeckoHistoryEventArgs : CancelEventArgs
{
	public readonly Uri Url;

	public GeckoHistoryEventArgs(Uri url)
	{
		Url = url;
	}
}
