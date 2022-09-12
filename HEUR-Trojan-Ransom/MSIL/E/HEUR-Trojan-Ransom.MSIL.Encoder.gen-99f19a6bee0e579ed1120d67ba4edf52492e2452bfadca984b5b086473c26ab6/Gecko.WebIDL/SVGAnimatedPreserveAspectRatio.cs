namespace Gecko.WebIDL;

public class SVGAnimatedPreserveAspectRatio : WebIDLBase
{
	public nsISupports BaseVal => GetProperty<nsISupports>("baseVal");

	public nsISupports AnimVal => GetProperty<nsISupports>("animVal");

	public SVGAnimatedPreserveAspectRatio(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
