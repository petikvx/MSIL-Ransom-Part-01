namespace Gecko.WebIDL;

public class DeviceStorageAreaChangedEvent : WebIDLBase
{
	public DeviceStorageAreaChangedEventOperation Operation => GetProperty<DeviceStorageAreaChangedEventOperation>("operation");

	public string StorageName => GetProperty<string>("storageName");

	public DeviceStorageAreaChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
