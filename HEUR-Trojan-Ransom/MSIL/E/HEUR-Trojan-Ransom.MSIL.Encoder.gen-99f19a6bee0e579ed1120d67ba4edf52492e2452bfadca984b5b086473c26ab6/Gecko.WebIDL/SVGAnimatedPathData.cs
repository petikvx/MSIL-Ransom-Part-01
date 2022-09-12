namespace Gecko.WebIDL;

public class SVGAnimatedPathData : WebIDLBase
{
	public nsISupports PathSegList => GetProperty<nsISupports>("pathSegList");

	public nsISupports AnimatedPathSegList => GetProperty<nsISupports>("animatedPathSegList");

	public SVGAnimatedPathData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
