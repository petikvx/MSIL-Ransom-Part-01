using System;

namespace Gecko.Listeners;

[Obsolete]
internal class GeckoWebProgressListener : GeckoBaseListener, nsIWebProgressListener
{
	public GeckoWebProgressListener(nsIWebProgressListener p_broowser)
	{
		_weakBrowser = new WeakReference(p_broowser);
	}

	public void OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
	{
		((nsIWebProgressListener)base._browser)?.OnStateChange(aWebProgress, aRequest, aStateFlags, aStatus);
	}

	public void OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
	{
		((nsIWebProgressListener)base._browser)?.OnProgressChange(aWebProgress, aRequest, aCurSelfProgress, aMaxSelfProgress, aCurTotalProgress, aMaxTotalProgress);
	}

	public void OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint flags)
	{
		((nsIWebProgressListener)base._browser)?.OnLocationChange(aWebProgress, aRequest, aLocation, flags);
	}

	public void OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
	{
		((nsIWebProgressListener)base._browser)?.OnStatusChange(aWebProgress, aRequest, aStatus, aMessage);
	}

	public void OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
	{
		((nsIWebProgressListener)base._browser)?.OnSecurityChange(aWebProgress, aRequest, aState);
	}
}
