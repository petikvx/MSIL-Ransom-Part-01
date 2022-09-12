namespace Gecko.WebIDL;

public class SVGPatternElement : WebIDLBase
{
	public nsISupports PatternUnits => GetProperty<nsISupports>("patternUnits");

	public nsISupports PatternContentUnits => GetProperty<nsISupports>("patternContentUnits");

	public nsISupports PatternTransform => GetProperty<nsISupports>("patternTransform");

	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Width => GetProperty<nsISupports>("width");

	public nsISupports Height => GetProperty<nsISupports>("height");

	public SVGPatternElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
