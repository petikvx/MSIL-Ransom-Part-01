namespace Gecko.WebIDL;

public class TVEITBroadcastedEvent : WebIDLBase
{
	public nsISupports[] Programs => GetProperty<nsISupports[]>("programs");

	public TVEITBroadcastedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
