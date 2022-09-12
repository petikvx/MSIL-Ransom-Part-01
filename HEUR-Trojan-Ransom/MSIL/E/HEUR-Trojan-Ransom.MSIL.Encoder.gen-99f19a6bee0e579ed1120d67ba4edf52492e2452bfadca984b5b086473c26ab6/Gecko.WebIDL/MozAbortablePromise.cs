namespace Gecko.WebIDL;

public class MozAbortablePromise : WebIDLBase
{
	public MozAbortablePromise(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}
}
