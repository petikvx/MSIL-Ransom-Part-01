namespace Gecko.WebIDL;

public class DOMMobileMessageError : WebIDLBase
{
	public WebIDLUnion<nsISupports, nsISupports> Data => GetProperty<WebIDLUnion<nsISupports, nsISupports>>("data");

	public DOMMobileMessageError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
