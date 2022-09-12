namespace Gecko.WebIDL;

public class MediaStreamEvent : WebIDLBase
{
	public nsISupports Stream => GetProperty<nsISupports>("stream");

	public MediaStreamEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
