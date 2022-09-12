namespace Gecko.WebIDL;

public class Geolocation : WebIDLBase
{
	public Geolocation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ClearWatch(int watchId)
	{
		CallVoidMethod("clearWatch", watchId);
	}
}
