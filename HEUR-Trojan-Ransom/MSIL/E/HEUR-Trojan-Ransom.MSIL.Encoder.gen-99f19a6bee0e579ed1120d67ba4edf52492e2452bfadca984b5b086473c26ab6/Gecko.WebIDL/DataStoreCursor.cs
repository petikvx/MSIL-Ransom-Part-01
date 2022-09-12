namespace Gecko.WebIDL;

public class DataStoreCursor : WebIDLBase
{
	public nsISupports Store => GetProperty<nsISupports>("store");

	public DataStoreCursor(nsIDOMWindow globalWindow, nsISupports thisObject)
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

	public void SetDataStoreCursorImpl(nsISupports cursor)
	{
		CallVoidMethod("setDataStoreCursorImpl", cursor);
	}
}
