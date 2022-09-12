namespace Gecko.WebIDL;

public class WindowLocalStorage : WebIDLBase
{
	public nsISupports LocalStorage => GetProperty<nsISupports>("localStorage");

	public WindowLocalStorage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
