namespace Gecko.WebIDL;

public class PushEvent : WebIDLBase
{
	public nsISupports Data => GetProperty<nsISupports>("data");

	public PushEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
