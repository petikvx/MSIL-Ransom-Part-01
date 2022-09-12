namespace Gecko.WebIDL;

public class StereoPannerNode : WebIDLBase
{
	public nsISupports Pan => GetProperty<nsISupports>("pan");

	public StereoPannerNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
