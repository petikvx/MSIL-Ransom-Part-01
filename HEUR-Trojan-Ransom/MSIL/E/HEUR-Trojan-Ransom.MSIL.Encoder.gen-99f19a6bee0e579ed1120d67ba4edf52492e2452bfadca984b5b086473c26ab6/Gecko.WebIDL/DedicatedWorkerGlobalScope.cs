namespace Gecko.WebIDL;

public class DedicatedWorkerGlobalScope : WebIDLBase
{
	public DedicatedWorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject)
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
