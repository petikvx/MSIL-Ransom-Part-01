namespace Gecko.WebIDL;

public class SVGFitToViewBox : WebIDLBase
{
	public nsISupports ViewBox => GetProperty<nsISupports>("viewBox");

	public nsISupports PreserveAspectRatio => GetProperty<nsISupports>("preserveAspectRatio");

	public SVGFitToViewBox(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
