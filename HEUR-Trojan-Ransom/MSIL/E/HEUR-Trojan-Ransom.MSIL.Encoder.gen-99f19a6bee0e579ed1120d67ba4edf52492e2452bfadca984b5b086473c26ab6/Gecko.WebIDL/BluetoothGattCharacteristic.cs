using System;

namespace Gecko.WebIDL;

public class BluetoothGattCharacteristic : WebIDLBase
{
	public nsISupports Service => GetProperty<nsISupports>("service");

	public nsISupports[] Descriptors => GetProperty<nsISupports[]>("descriptors");

	public string Uuid => GetProperty<string>("uuid");

	public ushort InstanceId => GetProperty<ushort>("instanceId");

	public IntPtr Value => GetProperty<IntPtr>("value");

	public object Permissions => GetProperty<object>("permissions");

	public object Properties => GetProperty<object>("properties");

	public BluetoothGattCharacteristic(nsIDOMWindow globalWindow, nsISupports thisObject)
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

	public Promise StartNotifications()
	{
		return CallMethod<Promise>("startNotifications", new object[0]);
	}

	public Promise StopNotifications()
	{
		return CallMethod<Promise>("stopNotifications", new object[0]);
	}

	public Promise<nsISupports> AddDescriptor(string uuid, object permissions, IntPtr value)
	{
		return CallMethod<Promise<nsISupports>>("addDescriptor", new object[3] { uuid, permissions, value });
	}
}
