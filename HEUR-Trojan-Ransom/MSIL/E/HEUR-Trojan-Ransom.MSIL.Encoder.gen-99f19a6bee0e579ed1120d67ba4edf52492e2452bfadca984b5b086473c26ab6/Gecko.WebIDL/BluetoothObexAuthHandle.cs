namespace Gecko.WebIDL;

public class BluetoothObexAuthHandle : WebIDLBase
{
	public BluetoothObexAuthHandle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise SetPassword(string aPassword)
	{
		return CallMethod<Promise>("setPassword", new object[1] { aPassword });
	}

	public Promise Reject()
	{
		return CallMethod<Promise>("reject", new object[0]);
	}
}
