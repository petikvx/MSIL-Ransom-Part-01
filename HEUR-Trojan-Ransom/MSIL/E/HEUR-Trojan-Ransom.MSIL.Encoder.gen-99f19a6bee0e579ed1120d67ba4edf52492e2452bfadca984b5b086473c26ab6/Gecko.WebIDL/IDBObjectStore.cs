namespace Gecko.WebIDL;

public class IDBObjectStore : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public object KeyPath => GetProperty<object>("keyPath");

	public nsISupports IndexNames => GetProperty<nsISupports>("indexNames");

	public nsISupports Transaction => GetProperty<nsISupports>("transaction");

	public bool AutoIncrement => GetProperty<bool>("autoIncrement");

	public IDBObjectStore(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Put(object value)
	{
		return CallMethod<nsISupports>("put", new object[1] { value });
	}

	public nsISupports Put(object value, object key)
	{
		return CallMethod<nsISupports>("put", new object[2] { value, key });
	}

	public nsISupports Add(object value)
	{
		return CallMethod<nsISupports>("add", new object[1] { value });
	}

	public nsISupports Add(object value, object key)
	{
		return CallMethod<nsISupports>("add", new object[2] { value, key });
	}

	public nsISupports Delete(object key)
	{
		return CallMethod<nsISupports>("delete", new object[1] { key });
	}

	public nsISupports Get(object key)
	{
		return CallMethod<nsISupports>("get", new object[1] { key });
	}

	public nsISupports Clear()
	{
		return CallMethod<nsISupports>("clear", new object[0]);
	}

	public nsISupports OpenCursor()
	{
		return CallMethod<nsISupports>("openCursor", new object[0]);
	}

	public nsISupports OpenCursor(object range)
	{
		return CallMethod<nsISupports>("openCursor", new object[1] { range });
	}

	public nsISupports OpenCursor(object range, IDBCursorDirection direction)
	{
		return CallMethod<nsISupports>("openCursor", new object[2] { range, direction });
	}

	public nsISupports CreateIndex(string name, string keyPath)
	{
		return CallMethod<nsISupports>("createIndex", new object[2] { name, keyPath });
	}

	public nsISupports CreateIndex(string name, string keyPath, object optionalParameters)
	{
		return CallMethod<nsISupports>("createIndex", new object[3] { name, keyPath, optionalParameters });
	}

	public nsISupports CreateIndex(string name, string[] keyPath)
	{
		return CallMethod<nsISupports>("createIndex", new object[2] { name, keyPath });
	}

	public nsISupports CreateIndex(string name, string[] keyPath, object optionalParameters)
	{
		return CallMethod<nsISupports>("createIndex", new object[3] { name, keyPath, optionalParameters });
	}

	public nsISupports Index(string name)
	{
		return CallMethod<nsISupports>("index", new object[1] { name });
	}

	public void DeleteIndex(string indexName)
	{
		CallVoidMethod("deleteIndex", indexName);
	}

	public nsISupports Count()
	{
		return CallMethod<nsISupports>("count", new object[0]);
	}

	public nsISupports Count(object key)
	{
		return CallMethod<nsISupports>("count", new object[1] { key });
	}

	public nsISupports MozGetAll()
	{
		return CallMethod<nsISupports>("mozGetAll", new object[0]);
	}

	public nsISupports MozGetAll(object key)
	{
		return CallMethod<nsISupports>("mozGetAll", new object[1] { key });
	}

	public nsISupports MozGetAll(object key, uint limit)
	{
		return CallMethod<nsISupports>("mozGetAll", new object[2] { key, limit });
	}

	public nsISupports GetAll()
	{
		return CallMethod<nsISupports>("getAll", new object[0]);
	}

	public nsISupports GetAll(object key)
	{
		return CallMethod<nsISupports>("getAll", new object[1] { key });
	}

	public nsISupports GetAll(object key, uint limit)
	{
		return CallMethod<nsISupports>("getAll", new object[2] { key, limit });
	}

	public nsISupports GetAllKeys()
	{
		return CallMethod<nsISupports>("getAllKeys", new object[0]);
	}

	public nsISupports GetAllKeys(object key)
	{
		return CallMethod<nsISupports>("getAllKeys", new object[1] { key });
	}

	public nsISupports GetAllKeys(object key, uint limit)
	{
		return CallMethod<nsISupports>("getAllKeys", new object[2] { key, limit });
	}

	public nsISupports OpenKeyCursor()
	{
		return CallMethod<nsISupports>("openKeyCursor", new object[0]);
	}

	public nsISupports OpenKeyCursor(object range)
	{
		return CallMethod<nsISupports>("openKeyCursor", new object[1] { range });
	}

	public nsISupports OpenKeyCursor(object range, IDBCursorDirection direction)
	{
		return CallMethod<nsISupports>("openKeyCursor", new object[2] { range, direction });
	}
}
