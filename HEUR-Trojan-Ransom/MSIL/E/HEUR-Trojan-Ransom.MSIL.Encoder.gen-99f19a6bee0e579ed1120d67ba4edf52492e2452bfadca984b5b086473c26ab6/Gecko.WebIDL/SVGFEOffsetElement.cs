namespace Gecko.WebIDL;

public class SVGFEOffsetElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports Dx => GetProperty<nsISupports>("dx");

	public nsISupports Dy => GetProperty<nsISupports>("dy");

	public SVGFEOffsetElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
