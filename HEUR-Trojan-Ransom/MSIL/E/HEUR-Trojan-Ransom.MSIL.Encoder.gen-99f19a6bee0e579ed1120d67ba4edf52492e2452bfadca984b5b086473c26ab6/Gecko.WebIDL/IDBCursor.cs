namespace Gecko.WebIDL;

public class IDBCursor : WebIDLBase
{
	public WebIDLUnion<nsISupports, nsISupports> Source => GetProperty<WebIDLUnion<nsISupports, nsISupports>>("source");

	public IDBCursorDirection Direction => GetProperty<IDBCursorDirection>("direction");

	public object Key => GetProperty<object>("key");

	public object PrimaryKey => GetProperty<object>("primaryKey");

	public IDBCursor(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Update(object value)
	{
		return CallMethod<nsISupports>("update", new object[1] { value });
	}

	public void Advance(uint count)
	{
		CallVoidMethod("advance", count);
	}

	public void Continue()
	{
		CallVoidMethod("continue");
	}

	public void Continue(object key)
	{
		CallVoidMethod("continue", key);
	}

	public nsISupports Delete()
	{
		return CallMethod<nsISupports>("delete", new object[0]);
	}
}
