namespace Gecko.WebIDL;

public class CallEvent : WebIDLBase
{
	public nsISupports Call => GetProperty<nsISupports>("call");

	public CallEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
