namespace Gecko.WebIDL;

public class SVGFilterElement : WebIDLBase
{
	public nsISupports FilterUnits => GetProperty<nsISupports>("filterUnits");

	public nsISupports PrimitiveUnits => GetProperty<nsISupports>("primitiveUnits");

	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public SVGFilterElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
