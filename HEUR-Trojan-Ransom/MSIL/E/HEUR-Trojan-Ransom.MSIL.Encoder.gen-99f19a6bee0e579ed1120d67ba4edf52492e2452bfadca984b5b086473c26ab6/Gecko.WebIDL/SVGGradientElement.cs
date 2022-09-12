namespace Gecko.WebIDL;

public class SVGGradientElement : WebIDLBase
{
	public nsISupports GradientUnits => GetProperty<nsISupports>("gradientUnits");

	public nsISupports GradientTransform => GetProperty<nsISupports>("gradientTransform");

	public nsISupports SpreadMethod => GetProperty<nsISupports>("spreadMethod");

	public SVGGradientElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
