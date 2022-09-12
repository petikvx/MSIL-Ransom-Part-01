namespace Gecko.WebIDL;

public class SVGLineElement : WebIDLBase
{
	public nsISupports X1 => GetProperty<nsISupports>("x1");

	public nsISupports Y1 => GetProperty<nsISupports>("y1");

	public nsISupports X2 => GetProperty<nsISupports>("x2");

	public nsISupports Y2 => GetProperty<nsISupports>("y2");

	public SVGLineElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
