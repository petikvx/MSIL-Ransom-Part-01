namespace Gecko.WebIDL;

public class IDBEnvironment : WebIDLBase
{
	public nsISupports IndexedDB => GetProperty<nsISupports>("indexedDB");

	public IDBEnvironment(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
