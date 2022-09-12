using System;

namespace Gecko.Listeners;

[Obsolete]
internal class GeckoSHistoryListener : GeckoBaseListener, nsISHistoryListener
{
	public GeckoSHistoryListener(nsISHistoryListener p_broowser)
	{
		_weakBrowser = new WeakReference(p_broowser);
	}

	public void OnHistoryNewEntry(nsIURI aNewURI)
	{
		((nsISHistoryListener)base._browser)?.OnHistoryNewEntry(aNewURI);
	}

	public bool OnHistoryGoBack(nsIURI aBackURI)
	{
		return ((nsISHistoryListener)base._browser)?.OnHistoryGoBack(aBackURI) ?? false;
	}

	public bool OnHistoryGoForward(nsIURI aForwardURI)
	{
		return ((nsISHistoryListener)base._browser)?.OnHistoryGoForward(aForwardURI) ?? false;
	}

	public bool OnHistoryReload(nsIURI aReloadURI, uint aReloadFlags)
	{
		return ((nsISHistoryListener)base._browser)?.OnHistoryReload(aReloadURI, aReloadFlags) ?? false;
	}

	public bool OnHistoryGotoIndex(int aIndex, nsIURI aGotoURI)
	{
		return ((nsISHistoryListener)base._browser)?.OnHistoryGotoIndex(aIndex, aGotoURI) ?? false;
	}

	public bool OnHistoryPurge(int aNumEntries)
	{
		return ((nsISHistoryListener)base._browser)?.OnHistoryPurge(aNumEntries) ?? false;
	}

	public void OnHistoryReplaceEntry(int aIndex)
	{
		throw new NotImplementedException();
	}
}
