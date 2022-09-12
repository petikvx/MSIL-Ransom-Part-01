namespace Gecko.WebIDL;

public class SVGFEPointLightElement : WebIDLBase
{
	public nsISupports X => GetProperty<nsISupports>("x");

	public nsISupports Y => GetProperty<nsISupports>("y");

	public nsISupports Z => GetProperty<nsISupports>("z");

	public SVGFEPointLightElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
