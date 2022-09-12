namespace Gecko.WebIDL;

public class IDBTransaction : WebIDLBase
{
	public IDBTransactionMode Mode => GetProperty<IDBTransactionMode>("mode");

	public nsISupports Db => GetProperty<nsISupports>("db");

	public nsISupports Error => GetProperty<nsISupports>("error");

	public nsISupports ObjectStoreNames => GetProperty<nsISupports>("objectStoreNames");

	public IDBTransaction(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports ObjectStore(string name)
	{
		return CallMethod<nsISupports>("objectStore", new object[1] { name });
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}
}
