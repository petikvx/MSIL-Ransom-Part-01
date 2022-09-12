namespace Gecko.WebIDL;

public class IDBCursorWithValue : WebIDLBase
{
	public object Value => GetProperty<object>("value");

	public IDBCursorWithValue(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
