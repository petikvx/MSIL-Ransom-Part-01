namespace Gecko.WebIDL;

public class BluetoothMapMessageUpdateEvent : WebIDLBase
{
	public uint InstanceId => GetProperty<uint>("instanceId");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothMapMessageUpdateEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
