namespace Gecko.WebIDL;

public class TVCurrentChannelChangedEvent : WebIDLBase
{
	public nsISupports Channel => GetProperty<nsISupports>("channel");

	public TVCurrentChannelChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
