namespace Gecko.WebIDL;

public class NavigatorDataStore : WebIDLBase
{
	public NavigatorDataStore(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetDataStores(string name)
	{
		return CallMethod<Promise<nsISupports[]>>("getDataStores", new object[1] { name });
	}

	public Promise<nsISupports[]> GetDataStores(string name, string owner)
	{
		return CallMethod<Promise<nsISupports[]>>("getDataStores", new object[2] { name, owner });
	}
}
