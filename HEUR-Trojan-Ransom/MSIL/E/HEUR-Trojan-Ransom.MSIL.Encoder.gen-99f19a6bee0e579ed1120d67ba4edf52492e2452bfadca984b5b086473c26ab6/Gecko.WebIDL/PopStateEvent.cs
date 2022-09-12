namespace Gecko.WebIDL;

public class PopStateEvent : WebIDLBase
{
	public object State => GetProperty<object>("state");

	public PopStateEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
