namespace Gecko.WebIDL;

public class SVGFilterPrimitiveStandardAttributes : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public nsISupports Result => GetProperty<nsISupports>("result");

	public SVGFilterPrimitiveStandardAttributes(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
