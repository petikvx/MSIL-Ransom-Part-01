namespace Gecko.WebIDL;

public class SVGRectElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public nsISupports Rx => GetProperty<nsISupports>("rx");

	public nsISupports Ry => GetProperty<nsISupports>("ry");

	public SVGRectElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
