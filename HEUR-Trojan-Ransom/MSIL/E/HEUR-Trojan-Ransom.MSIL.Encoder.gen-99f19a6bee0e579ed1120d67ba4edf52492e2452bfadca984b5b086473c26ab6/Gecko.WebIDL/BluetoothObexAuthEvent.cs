namespace Gecko.WebIDL;

public class BluetoothObexAuthEvent : WebIDLBase
{
	public string UserId => GetProperty<string>("userId");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothObexAuthEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
