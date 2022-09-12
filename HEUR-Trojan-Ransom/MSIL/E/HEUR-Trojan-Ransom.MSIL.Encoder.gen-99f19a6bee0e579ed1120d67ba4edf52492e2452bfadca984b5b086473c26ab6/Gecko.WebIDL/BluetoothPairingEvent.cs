namespace Gecko.WebIDL;

public class BluetoothPairingEvent : WebIDLBase
{
	public string DeviceName => GetProperty<string>("deviceName");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothPairingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
