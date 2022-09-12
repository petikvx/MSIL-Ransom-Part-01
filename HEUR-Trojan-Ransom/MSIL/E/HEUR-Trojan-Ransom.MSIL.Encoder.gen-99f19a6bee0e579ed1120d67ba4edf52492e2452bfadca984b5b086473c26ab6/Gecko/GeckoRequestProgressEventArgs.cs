using System;

namespace Gecko;

public class GeckoRequestProgressEventArgs : EventArgs
{
	private nsIRequest _request;

	private GeckoResponse _reqWrapper;

	public readonly long CurrentProgress;

	public readonly long MaximumProgress;

	public GeckoResponse Request => _reqWrapper ?? (_reqWrapper = new GeckoResponse(_request));

	public GeckoRequestProgressEventArgs(long current, long max, nsIRequest req)
	{
		CurrentProgress = current;
		MaximumProgress = max;
		_request = req;
	}
}
