namespace Gecko.WebIDL;

public class SVGFEDisplacementMapElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports In2 => GetProperty<nsISupports>("in2");

	public nsISupports Scale => GetProperty<nsISupports>("scale");

	public nsISupports XChannelSelector => GetProperty<nsISupports>("xChannelSelector");

	public nsISupports YChannelSelector => GetProperty<nsISupports>("yChannelSelector");

	public SVGFEDisplacementMapElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
