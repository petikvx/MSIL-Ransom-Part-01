namespace Gecko.WebIDL;

public class SVGFEMorphologyElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports Operator => GetProperty<nsISupports>("operator");

	public nsISupports RadiusX => GetProperty<nsISupports>("radiusX");

	public nsISupports RadiusY => GetProperty<nsISupports>("radiusY");

	public SVGFEMorphologyElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
