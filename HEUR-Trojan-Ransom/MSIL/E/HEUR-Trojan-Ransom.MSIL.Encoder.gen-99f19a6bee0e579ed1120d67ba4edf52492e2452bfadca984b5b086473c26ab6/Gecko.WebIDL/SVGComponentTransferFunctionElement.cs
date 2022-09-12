namespace Gecko.WebIDL;

public class SVGComponentTransferFunctionElement : WebIDLBase
{
	public nsISupports Type => GetProperty<nsISupports>("type");

	public nsISupports TableValues => GetProperty<nsISupports>("tableValues");

	public nsISupports Slope => GetProperty<nsISupports>("slope");

	public nsISupports Intercept => GetProperty<nsISupports>("intercept");

	public nsISupports Amplitude => GetProperty<nsISupports>("amplitude");

	public nsISupports Exponent => GetProperty<nsISupports>("exponent");

	public nsISupports Offset => GetProperty<nsISupports>("offset");

	public SVGComponentTransferFunctionElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
