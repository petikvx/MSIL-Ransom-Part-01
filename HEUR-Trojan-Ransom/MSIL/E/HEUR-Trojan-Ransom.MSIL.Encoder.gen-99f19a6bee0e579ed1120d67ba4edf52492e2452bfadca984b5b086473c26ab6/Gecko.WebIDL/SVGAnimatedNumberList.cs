namespace Gecko.WebIDL;

public class SVGAnimatedNumberList : WebIDLBase
{
	public nsISupports BaseVal => GetProperty<nsISupports>("baseVal");

	public nsISupports AnimVal => GetProperty<nsISupports>("animVal");

	public SVGAnimatedNumberList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
