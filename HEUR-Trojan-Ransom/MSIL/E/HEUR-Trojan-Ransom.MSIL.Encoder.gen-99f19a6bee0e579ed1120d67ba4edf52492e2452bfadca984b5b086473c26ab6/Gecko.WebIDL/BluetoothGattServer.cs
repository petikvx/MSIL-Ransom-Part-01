namespace Gecko.WebIDL;

public class BluetoothGattServer : WebIDLBase
{
	public nsISupports[] Services => GetProperty<nsISupports[]>("services");

	public BluetoothGattServer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Connect(string address)
	{
		return CallMethod<Promise>("connect", new object[1] { address });
	}

	public Promise Disconnect(string address)
	{
		return CallMethod<Promise>("disconnect", new object[1] { address });
	}

	public Promise AddService(nsISupports service)
	{
		return CallMethod<Promise>("addService", new object[1] { service });
	}

	public Promise RemoveService(nsISupports service)
	{
		return CallMethod<Promise>("removeService", new object[1] { service });
	}

	public Promise NotifyCharacteristicChanged(string address, nsISupports characteristic, bool confirm)
	{
		return CallMethod<Promise>("notifyCharacteristicChanged", new object[3] { address, characteristic, confirm });
	}

	public Promise SendResponse(string address, ushort status, int requestId)
	{
		return CallMethod<Promise>("sendResponse", new object[3] { address, status, requestId });
	}
}
