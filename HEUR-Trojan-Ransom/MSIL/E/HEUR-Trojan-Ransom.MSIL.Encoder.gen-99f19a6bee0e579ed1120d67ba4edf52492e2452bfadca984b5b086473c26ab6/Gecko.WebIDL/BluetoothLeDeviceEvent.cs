using System;

namespace Gecko.WebIDL;

public class BluetoothLeDeviceEvent : WebIDLBase
{
	public nsISupports Device => GetProperty<nsISupports>("device");

	public short Rssi => GetProperty<short>("rssi");

	public IntPtr ScanRecord => GetProperty<IntPtr>("scanRecord");

	public BluetoothLeDeviceEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
