namespace Gecko.WebIDL;

public class BluetoothGatt : WebIDLBase
{
	public nsISupports[] Services => GetProperty<nsISupports[]>("services");

	public BluetoothConnectionState ConnectionState => GetProperty<BluetoothConnectionState>("connectionState");

	public BluetoothGatt(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Connect()
	{
		return CallMethod<Promise>("connect", new object[0]);
	}

	public Promise Disconnect()
	{
		return CallMethod<Promise>("disconnect", new object[0]);
	}

	public Promise DiscoverServices()
	{
		return CallMethod<Promise>("discoverServices", new object[0]);
	}

	public Promise<short> ReadRemoteRssi()
	{
		return CallMethod<Promise<short>>("readRemoteRssi", new object[0]);
	}
}
