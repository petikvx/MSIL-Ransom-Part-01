namespace Gecko.WebIDL;

public class SVGCircleElement : WebIDLBase
{
	public nsISupports Cx => GetProperty<nsISupports>("cx");

	public nsISupports Cy => GetProperty<nsISupports>("cy");

	public nsISupports R => GetProperty<nsISupports>("r");

	public SVGCircleElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
