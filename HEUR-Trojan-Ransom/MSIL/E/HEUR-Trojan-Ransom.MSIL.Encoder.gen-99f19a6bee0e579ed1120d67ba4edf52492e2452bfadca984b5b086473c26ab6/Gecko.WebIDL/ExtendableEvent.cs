namespace Gecko.WebIDL;

public class ExtendableEvent : WebIDLBase
{
	public ExtendableEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void WaitUntil(Promise<object> p)
	{
		CallVoidMethod("waitUntil", p);
	}
}
