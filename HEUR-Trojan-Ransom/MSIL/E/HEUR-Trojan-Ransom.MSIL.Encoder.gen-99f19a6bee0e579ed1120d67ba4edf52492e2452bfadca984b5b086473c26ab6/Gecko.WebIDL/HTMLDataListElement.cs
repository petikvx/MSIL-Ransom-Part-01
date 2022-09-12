namespace Gecko.WebIDL;

public class HTMLDataListElement : WebIDLBase
{
	public nsISupports Options => GetProperty<nsISupports>("options");

	public HTMLDataListElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
