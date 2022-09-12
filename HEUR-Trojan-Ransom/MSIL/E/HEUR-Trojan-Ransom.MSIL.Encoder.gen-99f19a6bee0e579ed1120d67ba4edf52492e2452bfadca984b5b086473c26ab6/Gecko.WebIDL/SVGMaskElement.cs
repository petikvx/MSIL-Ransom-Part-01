namespace Gecko.WebIDL;

public class SVGMaskElement : WebIDLBase
{
	public nsISupports MaskUnits => GetProperty<nsISupports>("maskUnits");

	public nsISupports MaskContentUnits => GetProperty<nsISupports>("maskContentUnits");

	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public SVGMaskElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
