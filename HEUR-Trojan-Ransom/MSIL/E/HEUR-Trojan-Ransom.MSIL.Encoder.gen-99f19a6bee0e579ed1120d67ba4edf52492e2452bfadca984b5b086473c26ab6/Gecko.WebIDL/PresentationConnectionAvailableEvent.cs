namespace Gecko.WebIDL;

public class PresentationConnectionAvailableEvent : WebIDLBase
{
	public nsISupports Connection => GetProperty<nsISupports>("connection");

	public PresentationConnectionAvailableEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
