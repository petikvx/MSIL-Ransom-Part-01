namespace Gecko.WebIDL;

public class SVGViewElement : WebIDLBase
{
	public nsISupports ViewTarget => GetProperty<nsISupports>("viewTarget");

	public SVGViewElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
