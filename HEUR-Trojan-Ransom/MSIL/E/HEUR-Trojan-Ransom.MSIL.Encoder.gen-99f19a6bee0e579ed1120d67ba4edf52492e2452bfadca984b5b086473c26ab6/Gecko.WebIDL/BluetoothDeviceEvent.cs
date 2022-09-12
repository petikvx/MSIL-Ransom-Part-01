namespace Gecko.WebIDL;

public class BluetoothDeviceEvent : WebIDLBase
{
	public nsISupports Device => GetProperty<nsISupports>("device");

	public string Address => GetProperty<string>("address");

	public BluetoothDeviceEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
