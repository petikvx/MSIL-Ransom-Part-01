namespace Gecko.WebIDL;

public class SVGAnimatedRect : WebIDLBase
{
	public nsISupports BaseVal => GetProperty<nsISupports>("baseVal");

	public nsISupports AnimVal => GetProperty<nsISupports>("animVal");

	public SVGAnimatedRect(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
