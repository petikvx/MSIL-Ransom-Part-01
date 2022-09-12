namespace Gecko.WebIDL;

public class DataStoreImpl : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Owner => GetProperty<string>("owner");

	public bool ReadOnly => GetProperty<bool>("readOnly");

	public string RevisionId => GetProperty<string>("revisionId");

	public DataStoreImpl(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetEventTarget(nsISupports eventTarget)
	{
		CallVoidMethod("setEventTarget", eventTarget);
	}

	public Promise<object> Get(WebIDLUnion<string, uint> id)
	{
		return CallMethod<Promise<object>>("get", new object[1] { id });
	}

	public Promise Put(object obj, WebIDLUnion<string, uint> id)
	{
		return CallMethod<Promise>("put", new object[2] { obj, id });
	}

	public Promise Put(object obj, WebIDLUnion<string, uint> id, string revisionId)
	{
		return CallMethod<Promise>("put", new object[3] { obj, id, revisionId });
	}

	public Promise<WebIDLUnion<string, uint>> Add(object obj)
	{
		return CallMethod<Promise<WebIDLUnion<string, uint>>>("add", new object[1] { obj });
	}

	public Promise<WebIDLUnion<string, uint>> Add(object obj, WebIDLUnion<string, uint> id)
	{
		return CallMethod<Promise<WebIDLUnion<string, uint>>>("add", new object[2] { obj, id });
	}

	public Promise<WebIDLUnion<string, uint>> Add(object obj, WebIDLUnion<string, uint> id, string revisionId)
	{
		return CallMethod<Promise<WebIDLUnion<string, uint>>>("add", new object[3] { obj, id, revisionId });
	}

	public Promise<bool> Remove(WebIDLUnion<string, uint> id)
	{
		return CallMethod<Promise<bool>>("remove", new object[1] { id });
	}

	public Promise<bool> Remove(WebIDLUnion<string, uint> id, string revisionId)
	{
		return CallMethod<Promise<bool>>("remove", new object[2] { id, revisionId });
	}

	public Promise Clear()
	{
		return CallMethod<Promise>("clear", new object[0]);
	}

	public Promise Clear(string revisionId)
	{
		return CallMethod<Promise>("clear", new object[1] { revisionId });
	}

	public Promise<uint> GetLength()
	{
		return CallMethod<Promise<uint>>("getLength", new object[0]);
	}

	public nsISupports Sync()
	{
		return CallMethod<nsISupports>("sync", new object[0]);
	}

	public nsISupports Sync(string revisionId)
	{
		return CallMethod<nsISupports>("sync", new object[1] { revisionId });
	}
}
