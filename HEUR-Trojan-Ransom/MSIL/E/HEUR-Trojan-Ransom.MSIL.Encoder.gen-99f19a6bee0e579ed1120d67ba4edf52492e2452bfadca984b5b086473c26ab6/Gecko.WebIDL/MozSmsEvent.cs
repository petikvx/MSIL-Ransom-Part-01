namespace Gecko.WebIDL;

public class MozSmsEvent : WebIDLBase
{
	public nsISupports Message => GetProperty<nsISupports>("message");

	public MozSmsEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
