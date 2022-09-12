namespace Gecko.WebIDL;

public class BroadcastChannel : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public BroadcastChannel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PostMessage(object message)
	{
		CallVoidMethod("postMessage", message);
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
