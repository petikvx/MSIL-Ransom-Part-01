namespace Gecko.WebIDL;

public class BluetoothManager : WebIDLBase
{
	public nsISupports DefaultAdapter => GetProperty<nsISupports>("defaultAdapter");

	public BluetoothManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports[] GetAdapters()
	{
		return CallMethod<nsISupports[]>("getAdapters", new object[0]);
	}
}
