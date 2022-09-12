namespace Gecko.WebIDL;

public class Client : WebIDLBase
{
	public USVString Url => GetProperty<USVString>("url");

	public FrameType FrameType => GetProperty<FrameType>("frameType");

	public string Id => GetProperty<string>("id");

	public Client(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PostMessage(object message)
	{
		CallVoidMethod("postMessage", message);
	}

	public void PostMessage(object message, object[] transfer)
	{
		CallVoidMethod("postMessage", message, transfer);
	}
}
