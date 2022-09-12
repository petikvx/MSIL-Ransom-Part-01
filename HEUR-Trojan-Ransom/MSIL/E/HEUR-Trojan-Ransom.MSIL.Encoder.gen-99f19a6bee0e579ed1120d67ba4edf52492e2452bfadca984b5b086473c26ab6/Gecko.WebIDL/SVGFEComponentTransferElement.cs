namespace Gecko.WebIDL;

public class SVGFEComponentTransferElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public SVGFEComponentTransferElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
