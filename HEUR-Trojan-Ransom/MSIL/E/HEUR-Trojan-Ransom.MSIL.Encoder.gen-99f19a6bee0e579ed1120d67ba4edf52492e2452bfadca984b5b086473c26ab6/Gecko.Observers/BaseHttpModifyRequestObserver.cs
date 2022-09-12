using Gecko.Net;

namespace Gecko.Observers;

public class BaseHttpModifyRequestObserver : NsSupportsBase, nsIObserver
{
	internal bool _isRegistered;

	void nsIObserver.Observe(nsISupports aSubject, string aTopic, string aData)
	{
		if (!(aTopic != "http-on-modify-request"))
		{
			using (HttpChannel channel = HttpChannel.Create(aSubject))
			{
				ObserveRequest(channel);
			}
		}
	}

	protected virtual void ObserveRequest(HttpChannel channel)
	{
	}
}
