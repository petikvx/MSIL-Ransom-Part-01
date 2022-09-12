using System;

namespace Gecko.Listeners;

[Obsolete]
internal abstract class GeckoBaseListener : nsISupportsWeakReference, nsIWeakReference
{
	protected WeakReference _weakBrowser;

	protected IGeckoWebBrowser _browser
	{
		get
		{
			if (!_weakBrowser.IsAlive)
			{
				return null;
			}
			IGeckoWebBrowser geckoWebBrowser = (IGeckoWebBrowser)_weakBrowser.Target;
			if (geckoWebBrowser.IsDisposed)
			{
				return null;
			}
			return geckoWebBrowser;
		}
	}

	public nsIWeakReference GetWeakReference()
	{
		return this;
	}

	public IntPtr QueryReferent(ref Guid uuid)
	{
		return Xpcom.QueryReferent(this, ref uuid);
	}
}
