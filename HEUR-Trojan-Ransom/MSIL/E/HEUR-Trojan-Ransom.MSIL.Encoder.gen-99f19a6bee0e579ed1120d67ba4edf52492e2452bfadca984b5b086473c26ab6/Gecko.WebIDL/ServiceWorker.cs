namespace Gecko.WebIDL;

public class ServiceWorker : WebIDLBase
{
	public USVString ScriptURL => GetProperty<USVString>("scriptURL");

	public ServiceWorkerState State => GetProperty<ServiceWorkerState>("state");

	public ServiceWorker(nsIDOMWindow globalWindow, nsISupports thisObject)
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
}
