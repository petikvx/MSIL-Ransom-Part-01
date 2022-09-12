namespace Gecko.WebIDL;

public class BluetoothStatusChangedEvent : WebIDLBase
{
	public string Address => GetProperty<string>("address");

	public bool Status => GetProperty<bool>("status");

	public BluetoothStatusChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
