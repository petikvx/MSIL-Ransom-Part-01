namespace Gecko.WebIDL;

public class IDBDatabase : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public ulong Version => GetProperty<ulong>("version");

	public nsISupports ObjectStoreNames => GetProperty<nsISupports>("objectStoreNames");

	public StorageType Storage => GetProperty<StorageType>("storage");

	public IDBDatabase(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateObjectStore(string name)
	{
		return CallMethod<nsISupports>("createObjectStore", new object[1] { name });
	}

	public nsISupports CreateObjectStore(string name, object optionalParameters)
	{
		return CallMethod<nsISupports>("createObjectStore", new object[2] { name, optionalParameters });
	}

	public void DeleteObjectStore(string name)
	{
		CallVoidMethod("deleteObjectStore", name);
	}

	public nsISupports Transaction(WebIDLUnion<string, string[]> storeNames)
	{
		return CallMethod<nsISupports>("transaction", new object[1] { storeNames });
	}

	public nsISupports Transaction(WebIDLUnion<string, string[]> storeNames, IDBTransactionMode mode)
	{
		return CallMethod<nsISupports>("transaction", new object[2] { storeNames, mode });
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public nsISupports CreateMutableFile(string name)
	{
		return CallMethod<nsISupports>("createMutableFile", new object[1] { name });
	}

	public nsISupports CreateMutableFile(string name, string type)
	{
		return CallMethod<nsISupports>("createMutableFile", new object[2] { name, type });
	}

	public nsISupports MozCreateFileHandle(string name)
	{
		return CallMethod<nsISupports>("mozCreateFileHandle", new object[1] { name });
	}

	public nsISupports MozCreateFileHandle(string name, string type)
	{
		return CallMethod<nsISupports>("mozCreateFileHandle", new object[2] { name, type });
	}
}
