namespace Gecko.WebIDL;

public class BluetoothAdapterEvent : WebIDLBase
{
	public nsISupports Adapter => GetProperty<nsISupports>("adapter");

	public string Address => GetProperty<string>("address");

	public BluetoothAdapterEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
