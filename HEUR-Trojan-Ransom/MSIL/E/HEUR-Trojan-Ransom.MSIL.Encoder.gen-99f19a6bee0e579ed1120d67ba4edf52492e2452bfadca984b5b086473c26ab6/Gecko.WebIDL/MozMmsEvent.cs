namespace Gecko.WebIDL;

public class MozMmsEvent : WebIDLBase
{
	public nsISupports Message => GetProperty<nsISupports>("message");

	public MozMmsEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
