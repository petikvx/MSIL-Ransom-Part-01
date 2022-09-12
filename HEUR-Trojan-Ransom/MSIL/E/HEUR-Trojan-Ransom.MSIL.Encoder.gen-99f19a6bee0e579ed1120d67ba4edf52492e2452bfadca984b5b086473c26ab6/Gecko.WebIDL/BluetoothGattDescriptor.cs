using System;

namespace Gecko.WebIDL;

public class BluetoothGattDescriptor : WebIDLBase
{
	public nsISupports Characteristic => GetProperty<nsISupports>("characteristic");

	public string Uuid => GetProperty<string>("uuid");

	public IntPtr Value => GetProperty<IntPtr>("value");

	public object Permissions => GetProperty<object>("permissions");

	public BluetoothGattDescriptor(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<IntPtr> ReadValue()
	{
		return CallMethod<Promise<IntPtr>>("readValue", new object[0]);
	}

	public Promise WriteValue(IntPtr value)
	{
		return CallMethod<Promise>("writeValue", new object[1] { value });
	}
}
