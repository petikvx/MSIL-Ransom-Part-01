namespace Gecko.WebIDL;

public class StorageEvent : WebIDLBase
{
	public string Key => GetProperty<string>("key");

	public string OldValue => GetProperty<string>("oldValue");

	public string NewValue => GetProperty<string>("newValue");

	public string Url => GetProperty<string>("url");

	public nsISupports StorageArea => GetProperty<nsISupports>("storageArea");

	public StorageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, nsISupports storageArea)
	{
		CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue, newValue, url, storageArea);
	}
}
