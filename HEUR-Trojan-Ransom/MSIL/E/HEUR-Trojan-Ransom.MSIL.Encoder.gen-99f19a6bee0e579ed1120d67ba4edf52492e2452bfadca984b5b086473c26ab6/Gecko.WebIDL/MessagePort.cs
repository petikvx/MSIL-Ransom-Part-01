namespace Gecko.WebIDL;

public class MessagePort : WebIDLBase
{
	public MessagePort(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PostMessage(object message)
	{
		CallVoidMethod("postMessage", message);
	}

	public void PostMessage(object message, object[] transferable)
	{
		CallVoidMethod("postMessage", message, transferable);
	}

	public void Start()
	{
		CallVoidMethod("start");
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
