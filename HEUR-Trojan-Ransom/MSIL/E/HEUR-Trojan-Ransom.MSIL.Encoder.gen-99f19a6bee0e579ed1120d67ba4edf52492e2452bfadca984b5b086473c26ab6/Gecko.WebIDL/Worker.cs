namespace Gecko.WebIDL;

public class Worker : WebIDLBase
{
	public Worker(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Terminate()
	{
		CallVoidMethod("terminate");
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
