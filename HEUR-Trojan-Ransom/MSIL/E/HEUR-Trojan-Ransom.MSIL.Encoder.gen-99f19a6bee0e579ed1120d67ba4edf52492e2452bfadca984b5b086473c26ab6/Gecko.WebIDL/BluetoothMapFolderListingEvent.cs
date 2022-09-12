namespace Gecko.WebIDL;

public class BluetoothMapFolderListingEvent : WebIDLBase
{
	public uint MaxListCount => GetProperty<uint>("maxListCount");

	public uint ListStartOffset => GetProperty<uint>("listStartOffset");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothMapFolderListingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
