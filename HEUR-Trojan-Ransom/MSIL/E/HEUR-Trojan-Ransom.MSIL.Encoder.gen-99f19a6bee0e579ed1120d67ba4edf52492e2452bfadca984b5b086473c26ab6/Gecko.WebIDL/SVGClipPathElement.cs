namespace Gecko.WebIDL;

public class SVGClipPathElement : WebIDLBase
{
	public nsISupports ClipPathUnits => GetProperty<nsISupports>("clipPathUnits");

	public nsISupports Transform => GetProperty<nsISupports>("transform");

	public SVGClipPathElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
