namespace Gecko.WebIDL;

public class MediaDeviceInfo : WebIDLBase
{
	public string DeviceId => GetProperty<string>("deviceId");

	public MediaDeviceKind Kind => GetProperty<MediaDeviceKind>("kind");

	public string Label => GetProperty<string>("label");

	public string GroupId => GetProperty<string>("groupId");

	public MediaDeviceInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
