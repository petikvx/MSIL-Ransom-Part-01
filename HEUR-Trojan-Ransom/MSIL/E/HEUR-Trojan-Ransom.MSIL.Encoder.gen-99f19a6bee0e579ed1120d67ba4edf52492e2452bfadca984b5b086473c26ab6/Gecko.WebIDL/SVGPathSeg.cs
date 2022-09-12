namespace Gecko.WebIDL;

public class SVGPathSeg : WebIDLBase
{
	public ushort PathSegType => GetProperty<ushort>("pathSegType");

	public string PathSegTypeAsLetter => GetProperty<string>("pathSegTypeAsLetter");

	public SVGPathSeg(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
