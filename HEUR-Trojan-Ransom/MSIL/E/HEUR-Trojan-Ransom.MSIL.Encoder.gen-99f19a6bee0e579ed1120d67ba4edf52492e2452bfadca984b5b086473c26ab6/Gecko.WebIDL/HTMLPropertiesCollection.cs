namespace Gecko.WebIDL;

public class HTMLPropertiesCollection : WebIDLBase
{
	public nsISupports Names => GetProperty<nsISupports>("names");

	public HTMLPropertiesCollection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
