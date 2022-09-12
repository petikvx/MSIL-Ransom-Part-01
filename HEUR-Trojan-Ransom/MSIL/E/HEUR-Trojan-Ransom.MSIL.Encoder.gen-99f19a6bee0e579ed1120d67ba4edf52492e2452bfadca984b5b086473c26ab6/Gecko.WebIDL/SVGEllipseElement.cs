namespace Gecko.WebIDL;

public class SVGEllipseElement : WebIDLBase
{
	public nsISupports Cx => GetProperty<nsISupports>("cx");

	public nsISupports Cy => GetProperty<nsISupports>("cy");

	public nsISupports Rx => GetProperty<nsISupports>("rx");

	public nsISupports Ry => GetProperty<nsISupports>("ry");

	public SVGEllipseElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
