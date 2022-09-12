namespace Gecko.WebIDL;

public class SVGRadialGradientElement : WebIDLBase
{
	public nsISupports Cx => GetProperty<nsISupports>("cx");

	public nsISupports Cy => GetProperty<nsISupports>("cy");

	public nsISupports R => GetProperty<nsISupports>("r");

	public nsISupports Fx => GetProperty<nsISupports>("fx");

	public nsISupports Fy => GetProperty<nsISupports>("fy");

	public SVGRadialGradientElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
