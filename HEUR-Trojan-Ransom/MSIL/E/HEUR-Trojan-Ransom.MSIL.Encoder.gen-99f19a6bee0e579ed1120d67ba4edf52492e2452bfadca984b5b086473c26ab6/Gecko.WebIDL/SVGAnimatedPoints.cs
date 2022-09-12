namespace Gecko.WebIDL;

public class SVGAnimatedPoints : WebIDLBase
{
	public nsISupports Points => GetProperty<nsISupports>("points");

	public nsISupports AnimatedPoints => GetProperty<nsISupports>("animatedPoints");

	public SVGAnimatedPoints(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
