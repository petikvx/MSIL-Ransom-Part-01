namespace Gecko.WebIDL;

public class SVGFEBlendElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports In2 => GetProperty<nsISupports>("in2");

	public nsISupports Mode => GetProperty<nsISupports>("mode");

	public SVGFEBlendElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
