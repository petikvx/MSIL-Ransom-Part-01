using System;

namespace Gecko.WebIDL;

public class BluetoothGattAttributeEvent : WebIDLBase
{
	public string Address => GetProperty<string>("address");

	public int RequestId => GetProperty<int>("requestId");

	public nsISupports Characteristic => GetProperty<nsISupports>("characteristic");

	public nsISupports Descriptor => GetProperty<nsISupports>("descriptor");

	public IntPtr Value => GetProperty<IntPtr>("value");

	public bool NeedResponse => GetProperty<bool>("needResponse");

	public BluetoothGattAttributeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
