namespace Gecko.WebIDL;

public class TVCurrentSourceChangedEvent : WebIDLBase
{
	public nsISupports Source => GetProperty<nsISupports>("source");

	public TVCurrentSourceChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
