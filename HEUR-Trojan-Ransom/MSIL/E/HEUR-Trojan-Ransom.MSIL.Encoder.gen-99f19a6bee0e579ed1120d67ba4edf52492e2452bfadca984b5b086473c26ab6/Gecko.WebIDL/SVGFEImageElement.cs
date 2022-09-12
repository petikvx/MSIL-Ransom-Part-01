namespace Gecko.WebIDL;

public class SVGFEImageElement : WebIDLBase
{
	public nsISupports PreserveAspectRatio => GetProperty<nsISupports>("preserveAspectRatio");

	public SVGFEImageElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
