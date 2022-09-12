namespace Gecko.WebIDL;

public class BluetoothMapSetMessageStatusEvent : WebIDLBase
{
	public uint HandleId => GetProperty<uint>("handleId");

	public StatusIndicators StatusIndicator => GetProperty<StatusIndicators>("statusIndicator");

	public bool StatusValue => GetProperty<bool>("statusValue");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothMapSetMessageStatusEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
