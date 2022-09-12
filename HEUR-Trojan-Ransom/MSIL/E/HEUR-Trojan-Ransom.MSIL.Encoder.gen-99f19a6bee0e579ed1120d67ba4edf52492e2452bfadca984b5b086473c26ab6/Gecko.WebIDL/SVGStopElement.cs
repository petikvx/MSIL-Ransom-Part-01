namespace Gecko.WebIDL;

public class SVGStopElement : WebIDLBase
{
	public nsISupports Offset => GetProperty<nsISupports>("offset");

	public SVGStopElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
