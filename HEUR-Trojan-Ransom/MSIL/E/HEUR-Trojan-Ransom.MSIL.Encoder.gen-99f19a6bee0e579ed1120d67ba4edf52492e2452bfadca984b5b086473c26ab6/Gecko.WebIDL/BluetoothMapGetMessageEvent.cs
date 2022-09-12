namespace Gecko.WebIDL;

public class BluetoothMapGetMessageEvent : WebIDLBase
{
	public bool HasAttachment => GetProperty<bool>("hasAttachment");

	public FilterCharset Charset => GetProperty<FilterCharset>("charset");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothMapGetMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
