namespace Gecko.WebIDL;

public class SVGFEColorMatrixElement : WebIDLBase
{
	public nsISupports In1 => GetProperty<nsISupports>("in1");

	public nsISupports Type => GetProperty<nsISupports>("type");

	public nsISupports Values => GetProperty<nsISupports>("values");

	public SVGFEColorMatrixElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
