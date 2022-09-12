namespace Gecko.WebIDL;

public class SVGFEMergeNodeElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public SVGFEMergeNodeElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
