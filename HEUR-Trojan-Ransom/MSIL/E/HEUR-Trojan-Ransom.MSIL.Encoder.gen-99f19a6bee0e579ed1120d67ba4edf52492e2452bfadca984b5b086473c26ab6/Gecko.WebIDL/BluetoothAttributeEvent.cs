namespace Gecko.WebIDL;

public class BluetoothAttributeEvent : WebIDLBase
{
	public string[] Attrs => GetProperty<string[]>("attrs");

	public BluetoothAttributeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
