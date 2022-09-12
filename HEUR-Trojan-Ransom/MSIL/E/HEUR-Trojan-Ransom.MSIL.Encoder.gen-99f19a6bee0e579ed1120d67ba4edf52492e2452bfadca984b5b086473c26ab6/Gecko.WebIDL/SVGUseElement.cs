namespace Gecko.WebIDL;

public class SVGUseElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public SVGUseElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
