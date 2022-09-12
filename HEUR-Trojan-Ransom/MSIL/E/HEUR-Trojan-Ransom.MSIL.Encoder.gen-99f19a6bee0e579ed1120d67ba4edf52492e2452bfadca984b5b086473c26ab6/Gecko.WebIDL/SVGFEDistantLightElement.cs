namespace Gecko.WebIDL;

public class SVGFEDistantLightElement : WebIDLBase
{
	public nsISupports Azimuth => GetProperty<nsISupports>("azimuth");

	public nsISupports Elevation => GetProperty<nsISupports>("elevation");

	public SVGFEDistantLightElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
