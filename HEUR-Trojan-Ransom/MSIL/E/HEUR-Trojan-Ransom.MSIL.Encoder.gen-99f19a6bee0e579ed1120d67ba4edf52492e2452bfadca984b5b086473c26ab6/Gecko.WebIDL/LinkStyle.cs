namespace Gecko.WebIDL;

public class LinkStyle : WebIDLBase
{
	public nsISupports Sheet => GetProperty<nsISupports>("sheet");

	public LinkStyle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
