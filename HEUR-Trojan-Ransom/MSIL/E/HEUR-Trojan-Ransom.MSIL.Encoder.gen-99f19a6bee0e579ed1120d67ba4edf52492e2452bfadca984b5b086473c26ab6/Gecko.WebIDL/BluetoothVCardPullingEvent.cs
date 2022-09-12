namespace Gecko.WebIDL;

public class BluetoothVCardPullingEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public VCardVersion Format => GetProperty<VCardVersion>("format");

	public VCardProperties[] PropSelector => GetProperty<VCardProperties[]>("propSelector");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothVCardPullingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
