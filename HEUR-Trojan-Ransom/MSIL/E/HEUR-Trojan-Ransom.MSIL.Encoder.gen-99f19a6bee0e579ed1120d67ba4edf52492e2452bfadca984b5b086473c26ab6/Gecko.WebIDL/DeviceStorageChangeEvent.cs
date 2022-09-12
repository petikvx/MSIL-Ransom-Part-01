namespace Gecko.WebIDL;

public class DeviceStorageChangeEvent : WebIDLBase
{
	public string Path => GetProperty<string>("path");

	public string Reason => GetProperty<string>("reason");

	public DeviceStorageChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
