namespace Gecko.WebIDL;

public class MozCellBroadcastEvent : WebIDLBase
{
	public nsISupports Message => GetProperty<nsISupports>("message");

	public MozCellBroadcastEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
