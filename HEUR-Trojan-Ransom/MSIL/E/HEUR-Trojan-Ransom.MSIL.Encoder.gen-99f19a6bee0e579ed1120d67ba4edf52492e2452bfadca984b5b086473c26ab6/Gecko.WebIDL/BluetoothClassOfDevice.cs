namespace Gecko.WebIDL;

public class BluetoothClassOfDevice : WebIDLBase
{
	public ushort MajorServiceClass => GetProperty<ushort>("majorServiceClass");

	public byte MajorDeviceClass => GetProperty<byte>("majorDeviceClass");

	public byte MinorDeviceClass => GetProperty<byte>("minorDeviceClass");

	public BluetoothClassOfDevice(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
