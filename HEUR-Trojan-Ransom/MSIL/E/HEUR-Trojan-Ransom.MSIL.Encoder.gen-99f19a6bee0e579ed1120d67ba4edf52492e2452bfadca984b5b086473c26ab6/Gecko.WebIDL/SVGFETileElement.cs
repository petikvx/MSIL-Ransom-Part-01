namespace Gecko.WebIDL;

public class SVGFETileElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public SVGFETileElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
