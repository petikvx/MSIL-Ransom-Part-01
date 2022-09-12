namespace Gecko.WebIDL;

public class IDBIndex : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public nsISupports ObjectStore => GetProperty<nsISupports>("objectStore");

	public object KeyPath => GetProperty<object>("keyPath");

	public bool MultiEntry => GetProperty<bool>("multiEntry");

	public bool Unique => GetProperty<bool>("unique");

	public string Locale => GetProperty<string>("locale");

	public bool IsAutoLocale => GetProperty<bool>("isAutoLocale");

	public IDBIndex(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
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

	public nsISupports Get(object key)
	{
		return CallMethod<nsISupports>("get", new object[1] { key });
	}

	public nsISupports GetKey(object key)
	{
		return CallMethod<nsISupports>("getKey", new object[1] { key });
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

	public nsISupports MozGetAllKeys()
	{
		return CallMethod<nsISupports>("mozGetAllKeys", new object[0]);
	}

	public nsISupports MozGetAllKeys(object key)
	{
		return CallMethod<nsISupports>("mozGetAllKeys", new object[1] { key });
	}

	public nsISupports MozGetAllKeys(object key, uint limit)
	{
		return CallMethod<nsISupports>("mozGetAllKeys", new object[2] { key, limit });
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
}
