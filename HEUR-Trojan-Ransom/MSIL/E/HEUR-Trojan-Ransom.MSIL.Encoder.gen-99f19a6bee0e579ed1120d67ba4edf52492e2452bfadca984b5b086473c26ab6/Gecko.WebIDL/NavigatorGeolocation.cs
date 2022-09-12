namespace Gecko.WebIDL;

public class NavigatorGeolocation : WebIDLBase
{
	public nsISupports Geolocation => GetProperty<nsISupports>("geolocation");

	public NavigatorGeolocation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
