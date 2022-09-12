namespace Gecko.WebIDL;

public class WindowSessionStorage : WebIDLBase
{
	public nsISupports SessionStorage => GetProperty<nsISupports>("sessionStorage");

	public WindowSessionStorage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
