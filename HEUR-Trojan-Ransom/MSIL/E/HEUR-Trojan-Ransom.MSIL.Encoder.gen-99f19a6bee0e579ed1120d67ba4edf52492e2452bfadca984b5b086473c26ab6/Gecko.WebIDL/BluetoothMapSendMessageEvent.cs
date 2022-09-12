namespace Gecko.WebIDL;

public class BluetoothMapSendMessageEvent : WebIDLBase
{
	public string Recipient => GetProperty<string>("recipient");

	public string MessageBody => GetProperty<string>("messageBody");

	public uint Retry => GetProperty<uint>("retry");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothMapSendMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
