namespace Gecko.WebIDL;

public class BluetoothDevice : WebIDLBase
{
	public string Address => GetProperty<string>("address");

	public nsISupports Cod => GetProperty<nsISupports>("cod");

	public string Name => GetProperty<string>("name");

	public bool Paired => GetProperty<bool>("paired");

	public BluetoothDeviceType Type => GetProperty<BluetoothDeviceType>("type");

	public nsISupports Gatt => GetProperty<nsISupports>("gatt");

	public string[] Uuids => GetProperty<string[]>("uuids");

	public BluetoothDevice(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<string[]> FetchUuids()
	{
		return CallMethod<Promise<string[]>>("fetchUuids", new object[0]);
	}
}
