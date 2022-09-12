using System;

namespace Gecko.WebIDL;

public class BluetoothGattService : WebIDLBase
{
	public nsISupports[] Characteristics => GetProperty<nsISupports[]>("characteristics");

	public nsISupports[] IncludedServices => GetProperty<nsISupports[]>("includedServices");

	public bool IsPrimary => GetProperty<bool>("isPrimary");

	public string Uuid => GetProperty<string>("uuid");

	public ushort InstanceId => GetProperty<ushort>("instanceId");

	public BluetoothGattService(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> AddCharacteristic(string uuid, object permissions, object properties, IntPtr value)
	{
		return CallMethod<Promise<nsISupports>>("addCharacteristic", new object[4] { uuid, permissions, properties, value });
	}

	public Promise AddIncludedService(nsISupports service)
	{
		return CallMethod<Promise>("addIncludedService", new object[1] { service });
	}
}
