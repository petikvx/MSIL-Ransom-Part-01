using System;

namespace Gecko.Listeners;

[Obsolete]
internal class GeckoDOMEventListener : GeckoBaseListener, nsIDOMEventListener
{
	public GeckoDOMEventListener(nsIDOMEventListener p_broowser)
	{
		_weakBrowser = new WeakReference(p_broowser);
	}

	public void HandleEvent(nsIDOMEvent @event)
	{
		((nsIDOMEventListener)base._browser)?.HandleEvent(@event);
	}
}
