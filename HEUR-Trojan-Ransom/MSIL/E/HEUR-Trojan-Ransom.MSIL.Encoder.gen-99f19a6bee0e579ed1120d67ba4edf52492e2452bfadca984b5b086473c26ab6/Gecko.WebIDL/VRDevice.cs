namespace Gecko.WebIDL;

public class VRDevice : WebIDLBase
{
	public string HardwareUnitId => GetProperty<string>("hardwareUnitId");

	public string DeviceId => GetProperty<string>("deviceId");

	public string DeviceName => GetProperty<string>("deviceName");

	public VRDevice(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
