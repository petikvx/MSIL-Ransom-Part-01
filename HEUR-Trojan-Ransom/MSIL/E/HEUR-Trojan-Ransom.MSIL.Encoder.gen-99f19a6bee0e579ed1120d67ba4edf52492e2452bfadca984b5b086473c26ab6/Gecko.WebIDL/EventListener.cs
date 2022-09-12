namespace Gecko.WebIDL;

public class EventListener : WebIDLBase
{
	public EventListener(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void HandleEvent(nsIDOMEvent @event)
	{
		CallVoidMethod("handleEvent", @event);
	}
}
