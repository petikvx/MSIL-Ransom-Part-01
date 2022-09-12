namespace Gecko.WebIDL;

public class SVGTextPathElement : WebIDLBase
{
	public nsISupports StartOffset => GetProperty<nsISupports>("startOffset");

	public nsISupports Method => GetProperty<nsISupports>("method");

	public nsISupports Spacing => GetProperty<nsISupports>("spacing");

	public SVGTextPathElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
