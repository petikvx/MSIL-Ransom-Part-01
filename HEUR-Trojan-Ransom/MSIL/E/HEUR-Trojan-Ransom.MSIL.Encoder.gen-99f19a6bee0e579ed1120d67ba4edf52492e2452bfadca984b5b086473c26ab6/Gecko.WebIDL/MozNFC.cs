namespace Gecko.WebIDL;

public class MozNFC : WebIDLBase
{
	public bool Enabled => GetProperty<bool>("enabled");

	public MozNFC(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void EventListenerWasAdded(string aType)
	{
		CallVoidMethod("eventListenerWasAdded", aType);
	}

	public void EventListenerWasRemoved(string aType)
	{
		CallVoidMethod("eventListenerWasRemoved", aType);
	}
}
