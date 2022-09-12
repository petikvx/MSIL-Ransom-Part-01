namespace Gecko.WebIDL;

public class SVGURIReference : WebIDLBase
{
	public nsISupports Href => GetProperty<nsISupports>("href");

	public SVGURIReference(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
