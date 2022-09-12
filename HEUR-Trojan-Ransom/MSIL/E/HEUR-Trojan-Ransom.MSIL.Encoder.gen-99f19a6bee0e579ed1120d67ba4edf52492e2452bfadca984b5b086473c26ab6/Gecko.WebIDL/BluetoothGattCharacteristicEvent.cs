namespace Gecko.WebIDL;

public class BluetoothGattCharacteristicEvent : WebIDLBase
{
	public nsISupports Characteristic => GetProperty<nsISupports>("characteristic");

	public BluetoothGattCharacteristicEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
