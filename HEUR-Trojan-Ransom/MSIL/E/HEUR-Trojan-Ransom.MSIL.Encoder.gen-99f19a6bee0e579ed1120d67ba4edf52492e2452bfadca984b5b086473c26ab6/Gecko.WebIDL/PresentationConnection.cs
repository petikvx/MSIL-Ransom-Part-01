namespace Gecko.WebIDL;

public class PresentationConnection : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public PresentationConnectionState State => GetProperty<PresentationConnectionState>("state");

	public PresentationConnection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Send(string data)
	{
		CallVoidMethod("send", data);
	}

	public void Terminate()
	{
		CallVoidMethod("terminate");
	}
}
