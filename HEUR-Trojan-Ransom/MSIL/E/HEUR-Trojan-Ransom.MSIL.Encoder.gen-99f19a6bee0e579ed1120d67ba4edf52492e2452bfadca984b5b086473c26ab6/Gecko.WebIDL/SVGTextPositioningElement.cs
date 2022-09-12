namespace Gecko.WebIDL;

public class SVGTextPositioningElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Dx => GetProperty<nsISupports>("dx");

	public nsISupports Dy => GetProperty<nsISupports>("dy");

	public nsISupports Rotate => GetProperty<nsISupports>("rotate");

	public SVGTextPositioningElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
