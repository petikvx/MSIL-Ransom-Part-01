namespace Gecko.WebIDL;

public class DelayNode : WebIDLBase
{
	public nsISupports DelayTime => GetProperty<nsISupports>("delayTime");

	public DelayNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
