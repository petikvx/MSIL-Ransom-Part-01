namespace Gecko.WebIDL;

public class GainNode : WebIDLBase
{
	public nsISupports Gain => GetProperty<nsISupports>("gain");

	public GainNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
