namespace Gecko.WebIDL;

public class SVGAnimatedAngle : WebIDLBase
{
	public nsISupports BaseVal => GetProperty<nsISupports>("baseVal");

	public nsISupports AnimVal => GetProperty<nsISupports>("animVal");

	public SVGAnimatedAngle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
