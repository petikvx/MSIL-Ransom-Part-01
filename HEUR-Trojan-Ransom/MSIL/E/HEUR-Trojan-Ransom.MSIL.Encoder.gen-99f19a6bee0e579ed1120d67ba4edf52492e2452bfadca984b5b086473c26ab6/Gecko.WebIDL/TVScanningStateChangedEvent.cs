namespace Gecko.WebIDL;

public class TVScanningStateChangedEvent : WebIDLBase
{
	public TVScanningState State => GetProperty<TVScanningState>("state");

	public nsISupports Channel => GetProperty<nsISupports>("channel");

	public TVScanningStateChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
