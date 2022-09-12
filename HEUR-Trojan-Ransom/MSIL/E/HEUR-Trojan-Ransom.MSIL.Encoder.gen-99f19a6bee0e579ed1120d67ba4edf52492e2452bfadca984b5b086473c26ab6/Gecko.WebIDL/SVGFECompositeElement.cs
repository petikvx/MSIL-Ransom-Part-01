namespace Gecko.WebIDL;

public class SVGFECompositeElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports In2 => GetProperty<nsISupports>("in2");

	public nsISupports Operator => GetProperty<nsISupports>("operator");

	public nsISupports K1 => GetProperty<nsISupports>("k1");

	public nsISupports K2 => GetProperty<nsISupports>("k2");

	public nsISupports K3 => GetProperty<nsISupports>("k3");

	public nsISupports K4 => GetProperty<nsISupports>("k4");

	public SVGFECompositeElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
