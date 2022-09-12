namespace Gecko.WebIDL;

public class BluetoothAdapter : WebIDLBase
{
	public BluetoothAdapterState State => GetProperty<BluetoothAdapterState>("state");

	public string Address => GetProperty<string>("address");

	public string Name => GetProperty<string>("name");

	public bool Discoverable => GetProperty<bool>("discoverable");

	public bool Discovering => GetProperty<bool>("discovering");

	public nsISupports GattServer => GetProperty<nsISupports>("gattServer");

	public nsISupports PairingReqs => GetProperty<nsISupports>("pairingReqs");

	public BluetoothAdapter(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Enable()
	{
		return CallMethod<Promise>("enable", new object[0]);
	}

	public Promise Disable()
	{
		return CallMethod<Promise>("disable", new object[0]);
	}

	public Promise SetName(string name)
	{
		return CallMethod<Promise>("setName", new object[1] { name });
	}

	public Promise SetDiscoverable(bool discoverable)
	{
		return CallMethod<Promise>("setDiscoverable", new object[1] { discoverable });
	}

	public Promise<nsISupports> StartDiscovery()
	{
		return CallMethod<Promise<nsISupports>>("startDiscovery", new object[0]);
	}

	public Promise StopDiscovery()
	{
		return CallMethod<Promise>("stopDiscovery", new object[0]);
	}

	public Promise Pair(string deviceAddress)
	{
		return CallMethod<Promise>("pair", new object[1] { deviceAddress });
	}

	public Promise Unpair(string deviceAddress)
	{
		return CallMethod<Promise>("unpair", new object[1] { deviceAddress });
	}

	public nsISupports[] GetPairedDevices()
	{
		return CallMethod<nsISupports[]>("getPairedDevices", new object[0]);
	}

	public Promise<nsISupports> StartLeScan(string[] serviceUuids)
	{
		return CallMethod<Promise<nsISupports>>("startLeScan", serviceUuids);
	}

	public Promise StopLeScan(nsISupports discoveryHandle)
	{
		return CallMethod<Promise>("stopLeScan", new object[1] { discoveryHandle });
	}

	public nsISupports GetConnectedDevices(ushort serviceUuid)
	{
		return CallMethod<nsISupports>("getConnectedDevices", new object[1] { serviceUuid });
	}

	public nsISupports Connect(nsISupports device)
	{
		return CallMethod<nsISupports>("connect", new object[1] { device });
	}

	public nsISupports Connect(nsISupports device, ushort serviceUuid)
	{
		return CallMethod<nsISupports>("connect", new object[2] { device, serviceUuid });
	}

	public nsISupports Disconnect(nsISupports device)
	{
		return CallMethod<nsISupports>("disconnect", new object[1] { device });
	}

	public nsISupports Disconnect(nsISupports device, ushort serviceUuid)
	{
		return CallMethod<nsISupports>("disconnect", new object[2] { device, serviceUuid });
	}

	public nsISupports SendFile(string deviceAddress, nsIDOMBlob blob)
	{
		return CallMethod<nsISupports>("sendFile", new object[2] { deviceAddress, blob });
	}

	public nsISupports StopSendingFile(string deviceAddress)
	{
		return CallMethod<nsISupports>("stopSendingFile", new object[1] { deviceAddress });
	}

	public nsISupports ConfirmReceivingFile(string deviceAddress, bool confirmation)
	{
		return CallMethod<nsISupports>("confirmReceivingFile", new object[2] { deviceAddress, confirmation });
	}

	public nsISupports ConnectSco()
	{
		return CallMethod<nsISupports>("connectSco", new object[0]);
	}

	public nsISupports DisconnectSco()
	{
		return CallMethod<nsISupports>("disconnectSco", new object[0]);
	}

	public nsISupports IsScoConnected()
	{
		return CallMethod<nsISupports>("isScoConnected", new object[0]);
	}

	public nsISupports AnswerWaitingCall()
	{
		return CallMethod<nsISupports>("answerWaitingCall", new object[0]);
	}

	public nsISupports IgnoreWaitingCall()
	{
		return CallMethod<nsISupports>("ignoreWaitingCall", new object[0]);
	}

	public nsISupports ToggleCalls()
	{
		return CallMethod<nsISupports>("toggleCalls", new object[0]);
	}

	public nsISupports SendMediaMetaData()
	{
		return CallMethod<nsISupports>("sendMediaMetaData", new object[0]);
	}

	public nsISupports SendMediaMetaData(object mediaMetaData)
	{
		return CallMethod<nsISupports>("sendMediaMetaData", new object[1] { mediaMetaData });
	}

	public nsISupports SendMediaPlayStatus()
	{
		return CallMethod<nsISupports>("sendMediaPlayStatus", new object[0]);
	}

	public nsISupports SendMediaPlayStatus(object mediaPlayStatus)
	{
		return CallMethod<nsISupports>("sendMediaPlayStatus", new object[1] { mediaPlayStatus });
	}
}
