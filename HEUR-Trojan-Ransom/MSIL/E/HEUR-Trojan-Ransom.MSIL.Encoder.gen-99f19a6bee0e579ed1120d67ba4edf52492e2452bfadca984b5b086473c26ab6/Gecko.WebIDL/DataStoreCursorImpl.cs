namespace Gecko.WebIDL;

public class DataStoreCursorImpl : WebIDLBase
{
	public nsISupports Store => GetProperty<nsISupports>("store");

	public DataStoreCursorImpl(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> Next()
	{
		return CallMethod<Promise<object>>("next", new object[0]);
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
