namespace Gecko.WebIDL;

public class SVGImageElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public nsISupports PreserveAspectRatio => GetProperty<nsISupports>("preserveAspectRatio");

	public SVGImageElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
