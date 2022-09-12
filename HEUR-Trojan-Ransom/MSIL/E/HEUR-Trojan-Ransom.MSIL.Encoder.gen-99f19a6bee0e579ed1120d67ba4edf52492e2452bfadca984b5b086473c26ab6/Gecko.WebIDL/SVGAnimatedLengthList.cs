namespace Gecko.WebIDL;

public class SVGAnimatedLengthList : WebIDLBase
{
	public nsISupports BaseVal => GetProperty<nsISupports>("baseVal");

	public nsISupports AnimVal => GetProperty<nsISupports>("animVal");

	public SVGAnimatedLengthList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
